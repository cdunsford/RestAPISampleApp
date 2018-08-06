using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RestAPISampleApp

/*
 To use the MakeRequest() or CreateFolder() (or any action functions) this class expects certain properties to be set BEFORE calling the action
 function (such as MakeRequest() or CreateFolder()). 
 The following items are required before doing a Post or Get through the aforementioned functions:
 1 - You must log in to eDocs and store the DST, username, and library in a cookie jar by calling StoreCookies()
    a. You only have to call StoreCookies() once unless you want to change users
    b. Before calling StoreCookies(), you ust set the JSON.
       An example is, RestClient.jSON = "{\"data\":{\"userid\":\"" + this.textBoxUserName.Text + "\",\"password\":\"" + this.textBoxPassword.Text + "\",\"library\":\"" + loginLIbrary + "\"}}";
    c. Not needed, but if you want to get a list of libraries from eDocs, you must set the endPoint and set the resource as Libraries. Example below
       RestClient rClient = new RestClient();
       rClient.endPoint = "http://azureserverdm16.eastus.cloudapp.azure.com:7080/edocsapi/v1.0/libraries"
       string response = rClient.MakeRequest();

The following settings are needed before EVERY action call
2 - The endPoint must be set. For example:
rClient.endPoint = "http://azureserverdm16.eastus.cloudapp.azure.com:7080/edocsapi/v1.0/folders?library=LEGAL"
3 - The JSON must be set (if using the POST method to add content to eDocs. For example:
rClient.jSON = "{ \"data\":{ \"DOCNAME\":\"" + this.textBoxFolderName.Text + "\",\"AUTHOR_ID\":\"CDUNSFORD\",\"CLIENT_NAME\":\"Default Client\",\"CLIENT_ID\":\"DEFAULT\",\"MATTER_NAME\":\"Default Matter\",\"MATTER_ID\":\"DEFAULT\",\"TYPE_ID\":\"DEFAULT\",\"APP_ID\":\"FOLDER\",\"FULLTEXT\":\"Y\",\"TYPIST_ID\":\"CDUNSFORD\",\"_restapi\":{ \"form_name\":\"LAWPROF_164\",\"ref\":{ \"type\":\"folders\",\"id\":\"public\",\"lib\":\"LEGAL\",\"DOCNAME\":\"Public Folders\"} } } }";
4 - The HTTP method must be set. For example, 
rClient.httpMethod = httpVerb.POST;

At this point, you can call the function you need to do. For example, 
string statusCode =  rClient.CreateFolder();


 */
{
    public enum httpVerb
    {
        GET,
        POST, 
        PUT,
        DELETE
    }
    //authenticationType not currently used
    public enum authenticationType
    {
        Basic,
        NTLM
    }
    //authenticationTechnique Not currently used
    public enum authenticationTechnique
    {
        RollYourOwn,
        NetworkCredential
    }

    class RestClient
    {   
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public authenticationType authType { get; set; }
        public authenticationTechnique authTechnique { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string jSON { get; set; }
        public CookieContainer cookies { get; set; }
        

        public RestClient(string endPoint, httpVerb httpMethod)
        {
            this.endPoint = endPoint;
            this.httpMethod = httpMethod;
        }
        public RestClient()
        {
            this.endPoint = string.Empty;
            this.httpMethod = httpVerb.GET;
        }

        public bool StoreCookies(string url, httpVerb verb)
        {
            //This will store the userID, DST, and groupID
            //We will need to pass this cookiejar with each Restful API call

            Dictionary<string, string> Cookies = new Dictionary<string, string>();
            CookieContainer cookieJar = new CookieContainer();
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.CookieContainer = cookieJar;
            request.Method = verb.ToString();

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {               

                streamWriter.Write(jSON);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (cookieJar != null)
                {
                    cookies = cookieJar;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
           
            

        }
        public string MakeRequest()
        {
            string _response = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = this.httpMethod.ToString();


            //string authHeader = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(userName + ":" + userPassword));
            //request.Headers.Add("Authorization", authType.ToString() + " " + authHeader);
            HttpWebResponse response = null;


            try
            {
                response = (HttpWebResponse)request.GetResponse();
               

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {

                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            _response = reader.ReadToEnd();
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                _response = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if(response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }


                return _response;

        }

        public async Task<int> DownloadFile(string host, string docname, string api_url, string userID, string userPassword, string library)
        {

            //First issue login...if succeeded (i.e., response.IsSuccessStatusCode), then download file
            HttpClient client = new HttpClient();
            HttpResponseMessage response = new HttpResponseMessage();
            string url = host + api_url + "connect";
            string json = "{\"data\":{\"userid\":\"" + userID + "\",\"password\":\"" + userPassword + "\",\"library\":\"" + library + "\"}}";

            //We use encoding to pass the json text over http so that http doesn't get tripped up over spaces and other special chars
            StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            //string url = api_url + "documents/" + docNum + "/versions/" + versionID + libq;
            int returnStatus = 0;
            HttpRequestMessage request = new HttpRequestMessage();

            request.RequestUri = new Uri(url);

            client.BaseAddress = new Uri(host);

            response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {

                using (HttpResponseMessage responseMessage = await client.GetAsync(this.endPoint, HttpCompletionOption.ResponseHeadersRead))
                {
                    returnStatus = (int)responseMessage.StatusCode;
                    using (Stream streamToReadFrom = await responseMessage.Content.ReadAsStreamAsync())
                    {
                        string fileToWriteTo = "C:\\downloads\\" + docname; //hardcode download location
                        using (Stream streamToWriteTo = File.Open(fileToWriteTo, FileMode.Create))
                        {
                            await streamToReadFrom.CopyToAsync(streamToWriteTo);
                        }
                    }
                }
                return returnStatus;


            }
            else
            {
                return returnStatus;
            }


        }

        public string CreateFolder()
        {
            


            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(this.endPoint);
            request.CookieContainer = cookies;
            request.Method = this.httpMethod.ToString();

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {



                streamWriter.Write(this.jSON);
                streamWriter.Flush();
                streamWriter.Close();
            }

            HttpWebResponse response = null;
            string _response;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if(response != null)
                {
                    _response = response.StatusCode.ToString();
                }
                else
                {
                    _response = "UNKNOWN ERROR";
                }
            }
            catch(Exception ex)
            {
                _response = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }

            return _response;

            


        }

        public string CheckOutDocument()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(this.endPoint);
            request.CookieContainer = cookies;
            request.Method = this.httpMethod.ToString();
            //request.Method = "PATCH";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {


                StringContent content1 = new StringContent(this.jSON, System.Text.Encoding.UTF8, "application/json");
                streamWriter.Write(content1);
                streamWriter.Flush();
                streamWriter.Close();
            }

            HttpWebResponse response = null;
            string _response;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if(response != null)
                {
                    _response = response.StatusCode.ToString();
                }
                else
                {
                    _response = "UNKNOWN ERROR";
                }
            }
            catch(Exception ex)
            {
                _response = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }

            return _response;
        }

        public async Task<int> CreateDocumentAsync(string docpath, string host, string api_url,string userID,string userPassword,string library)
        {
            //Must log in again to upload documents

            HttpClient client = new HttpClient();
            HttpResponseMessage response1 = new HttpResponseMessage();
            string url = host + api_url + "connect";
            string json = "{\"data\":{\"userid\":\"" + userID + "\",\"password\":\"" + userPassword + "\",\"library\":\"" + library + "\"}}";

            HttpRequestMessage request1 = new HttpRequestMessage();

            //We use encoding to pass the json text over http so that http doesn't get tripped up over spaces and other special chars
            StringContent content1 = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            request1.RequestUri = new Uri(url);
            client.BaseAddress = new Uri(host);
            response1 = await client.PostAsync(url, content1);
            if (response1.IsSuccessStatusCode)
            {
                
                FileStream s = new FileStream(docpath, FileMode.Open, FileAccess.Read);
                StreamContent body = new StreamContent(s);
                body.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                MultipartFormDataContent content = new MultipartFormDataContent();
                StringContent profile = new StringContent(this.jSON, System.Text.Encoding.UTF8, "application/json");
                content.Add(body, "file", docpath);
                content.Add(profile, "data");
                HttpRequestMessage request = new HttpRequestMessage();

                request.RequestUri = new Uri(this.endPoint);

                HttpResponseMessage response = await client.PostAsync(this.endPoint, content);
                return (int)response.StatusCode;

            }
            else
            {
                return 0;
            }


        }

    }
}
