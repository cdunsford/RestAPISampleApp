using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RestAPISampleApp
{
    public partial class Form1 : Form
    {
        string BaseURL_edocs = "/edocsapi/v1.0/";
        string BaseURL_jira = "/rest/api/2/";
        string loginLIbrary = string.Empty;
        string libq = "?library=";
        string userID = string.Empty;
        string userPassword = string.Empty;
        RestClient rClient;


        public Form1()
        {
            InitializeComponent();
        }

        #region UIEventHandlers
        private void buttonGo_Click(object sender, EventArgs e)
        {
            
            //rClient.userName = this.textBoxUserName.Text;
            //rClient.userPassword = this.textBoxPassword.Text;
            
            rClient.jSON = "{\"data\":{\"userid\":\"" + this.textBoxUserName.Text + "\",\"password\":\"" + this.textBoxPassword.Text + "\",\"library\":\"" + loginLIbrary + "\"}}";
            bool cookieJar = rClient.StoreCookies(this.textBoxURI.Text + BaseURL_edocs + "connect",httpVerb.POST);

            if (cookieJar)
            {
                DebugOutput("Login Succeeded");
                this.buttonGo.Enabled = true;
                this.buttonGet.Enabled = true;
                this.buttonCheckout.Enabled = true;
            }
            else
            {
                DebugOutput("Login did not succeed");
                this.buttonGo.Enabled = false;
                this.buttonGet.Enabled = false;
                this.buttonCheckout.Enabled = false;
            }
            






        }

        private DMLibraries GetDMLibraries(string response)
        {
            DMLibraries _dmLibs = null;

            try
            {

                _dmLibs = JsonConvert.DeserializeObject<DMLibraries>(response);

                return _dmLibs;
            }
            catch (Exception ex)
            {

                DebugOutput("Error! " + ex.Message.ToString());
            }

            return _dmLibs;


        }
        //var DMLibraries = JsonConvert.DeserializeObject<dynamic>(response);
        private void DeserializeJSON(string response)
        {
            try
            {
                //var DMLibraries = JsonConvert.DeserializeObject<dynamic>(response);
                DMLibraries _dmLIbs = JsonConvert.DeserializeObject<DMLibraries>(response);
                DebugOutput("Accessing the first item in the libraries array: " + _dmLIbs.data[0]);
                DebugOutput("Here's our jSON object: " + _dmLIbs.ToString());
            }
            catch (Exception ex)
            {

                DebugOutput("Error! " + ex.Message.ToString());
            }


        }
        #endregion

        private void DebugOutput(string debugTest)
        {
            try
            {
                System.Diagnostics.Debug.Write(debugTest + Environment.NewLine);
                textBoxResponse.Text = textBoxResponse.Text + debugTest + Environment.NewLine;
                textBoxResponse.SelectionStart = textBoxResponse.TextLength;
                textBoxResponse.ScrollToCaret();

            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            //Create a folder with name 'fiddler folder' inside folder named Dunsford Folder
            //{"data":{"DOCNAME":"fiddler folder","AUTHOR_ID":"CDUNSFORD","CLIENT_ID":"DEFAULT","MATTER_ID":"DEFAULT","TYPE_ID":"DEFAULT","APP_ID":"FOLDER","FULLTEXT":"Y","TYPIST_ID":"CDUNSFORD","_restapi":{"form_name":"LAWPROF_164","ref":{"type":"folders","id":"2134","lib":"LEGAL","DOCNAME":"Dunsford Folder"}},"SEC_REASON_LINK":"1"}}

            //Create public folder
            //{ "data":{ "DOCNAME":"x1234","AUTHOR_ID":"CDUNSFORD","CLIENT_NAME":"Default Client","CLIENT_ID":"DEFAULT","MATTER_NAME":"Default Matter","MATTER_ID":"DEFAULT","TYPE_ID":"DEFAULT","APP_ID":"FOLDER","FULLTEXT":"Y","TYPIST_ID":"CDUNSFORD","_restapi":{ "form_name":"LAWPROF_164","ref":{ "type":"folders","id":"public","lib":"LEGAL","DOCNAME":"Public Folders"} } } }

            //Create a document
            //{ "DOCNAME":"sdf","AUTHOR_ID":"CDUNSFORD","CLIENT_NAME":"Default Client","CLIENT_ID":"DEFAULT","MATTER_NAME":"Default Matter","MATTER_ID":"DEFAULT","TYPE_ID":"DEFAULT","APP_ID":"MS WORD","FULLTEXT":"Y","TYPIST_ID":"CDUNSFORD","_restapi":{ "form_name":"BWLAWPROF"} }

            if (this.textBoxObjectName.Text == string.Empty)
            {
                DebugOutput("Object name must be supplied");
                this.textBoxObjectName.Focus();
            }

            
            loginLIbrary = this.comboBoxLibraries.Text;
            rClient.endPoint = this.textBoxURI.Text + BaseURL_edocs + comboBoxActionItems.Text + libq;
            rClient.httpMethod = httpVerb.POST;
            string statusCode = string.Empty;
            int rc = 0;


            if (this.comboBoxActionItems.Text == "folders")
            {
                rClient.jSON = "{ \"data\":{ \"DOCNAME\":\"" + this.textBoxObjectName.Text + "\",\"AUTHOR_ID\":\"CDUNSFORD\",\"CLIENT_NAME\":\"Default Client\",\"CLIENT_ID\":\"DEFAULT\",\"MATTER_NAME\":\"Default Matter\",\"MATTER_ID\":\"DEFAULT\",\"TYPE_ID\":\"DEFAULT\",\"APP_ID\":\"FOLDER\",\"FULLTEXT\":\"Y\",\"TYPIST_ID\":\"CDUNSFORD\",\"_restapi\":{ \"form_name\":\"LAWPROF_164\",\"ref\":{ \"type\":\"folders\",\"id\":\"public\",\"lib\":\"LEGAL\",\"DOCNAME\":\"Public Folders\"} } } }";
                statusCode = rClient.CreateFolder();
                DebugOutput("Objecct Created = " + statusCode);
            }
            else
            {
                //{"DOCNAME":"sdf","AUTHOR_ID":"CDUNSFORD","CLIENT_NAME":"Default Client","CLIENT_ID":"DEFAULT","MATTER_NAME":"Default Matter","MATTER_ID":"DEFAULT","TYPE_ID":"DEFAULT","APP_ID":"MS WORD","FULLTEXT":"Y","STORAGE":"K","TYPIST_ID":"CDUNSFORD","SECURITY":"1","_restapi":{"form_name":"BWLAWPROF","security":[{"flag":2,"USER_ID":"CDUNSFORD","rights":32255}]},"SEC_REASON_LINK":"1"}
                rClient.jSON = "{\"DOCNAME\":\"" + this.textBoxObjectName.Text + "\",\"AUTHOR_ID\":\"CDUNSFORD\",\"CLIENT_NAME\":\"Default Client\",\"CLIENT_ID\":\"DEFAULT\",\"MATTER_NAME\":\"Default Matter\",\"MATTER_ID\":\"DEFAULT\",\"TYPE_ID\":\"DEFAULT\",\"APP_ID\":\"MS WORD\",\"FULLTEXT\":\"Y\",\"TYPIST_ID\":\"CDUNSFORD\",\"_restapi\":{\"form_name\":\"BWLAWPROF\"}}";
                
                rc = await UploadDocumentAsync();
                DebugOutput("Object Created = " + rc.ToString());
            }
            
            
            

            


        }

        private async Task<int> UploadDocumentAsync()
        {
            return await rClient.CreateDocumentAsync(this.textBoxFilePath.Text, this.textBoxURI.Text, BaseURL_edocs, this.textBoxUserName.Text, this.textBoxPassword.Text, loginLIbrary);
            //return await rClient.CreateDocumentAsync(this.textBoxFilePath.Text, "", "", "", "", loginLIbrary);

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            rClient = new RestClient();

            rClient.endPoint = this.textBoxURI.Text + BaseURL_edocs + "libraries"; 
            string response = string.Empty;
            response = rClient.MakeRequest();
            DebugOutput(response);
            //DeserializeJSON(response);

            //Convert JSON to a DMLibraries object
            DMLibraries _libs = GetDMLibraries(response);

            //Update the UI with the library list
            this.comboBoxLibraries.BeginUpdate();

            foreach (var item in _libs.data)
            {
                this.comboBoxLibraries.Items.Add(item);

            }

            this.comboBoxLibraries.Text = _libs.data[0];
            this.comboBoxLibraries.EndUpdate();
            this.loginLIbrary = this.comboBoxLibraries.Text;
            this.libq += loginLIbrary;

        }

        private async void buttonGet_Click(object sender, EventArgs e)
        {
            string response = string.Empty;
            int rc;

            if (this.comboBoxGetItems.Text == "documents")
            {
                //http://azureserverdm16.eastus.cloudapp.azure.com:7080/edocsapi/v1.0/documents/18384/versions/C?library=LEGAL
                rClient.httpMethod = httpVerb.GET;
                rClient.endPoint = "http://azureserverdm16.eastus.cloudapp.azure.com:7080/edocsapi/v1.0/documents/18384/versions/C?library=LEGAL";
                rc = await rClient.DownloadFile(textBoxURI.Text, "ellie", BaseURL_edocs, "cdunsford", "pcdocs", loginLIbrary);
                DebugOutput(rc.ToString());
            }
            else
            {
                rClient.endPoint = this.textBoxURI.Text + BaseURL_edocs + "lookups/MATTER/profile?library=LEGAL&key=MATTER";
                
                response = rClient.MakeRequest();
                DebugOutput(response);
            }
        
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {

            rClient.endPoint = "http://azureserverdm16.eastus.cloudapp.azure.com:7080/edocsapi/v1.0/documents/16472/profile?library=LEGAL";
            string response = string.Empty;
            rClient.httpMethod = httpVerb.PUT;
            rClient.jSON = "{\"%CHECKIN_DATE\":\"08-06-2018\",\"%CHECKOUT_COMMENT\":\"TEST COMMENT\",\"%STATUS\":\"%LOCK_FOR_CHECKOUT\",\"_restapi\":{}}";
            //rClient.jSON = "{\"data\":{\"%CHECKIN_LOCATION\":\"C:\\Users\\cdunsford\\Downloads\",\"_restapi\":{},\"%STATUS\":\"%LOCK_FOR_CHECKOUT\"}}";
            //rClient.jSON = "{\"data\":{\"edx_folder_loc\":\"LOCAL\",\"%CHECKIN_LOCATION\":\"C:\\Users\\cdunsford\\Downloads\",\"%CHECKIN_DATE\":\"2018-08-06\",\"%CHECKOUT_COMMENT\":\"TEST COMMENT\",\"%STATUS\":\"%LOCK_FOR_CHECKOUT\"}";
            response = rClient.CheckOutDocument();
            DebugOutput(response);




            return;


            if (this.textBoxDocumentNumber.Text == string.Empty)
            {
                DebugOutput("Object number must be supplied");
                this.textBoxDocumentNumber.Focus();
            }


            loginLIbrary = this.comboBoxLibraries.Text;

            //http://azureserverdm16.eastus.cloudapp.azure.com:7080/edocsapi/v1.0/documents/18644/profile?library=LEGAL
            //rClient.endPoint = this.textBoxURI.Text + BaseURL_edocs + "documents/" + this.textBoxDocumentNumber.Text + "/profile" + libq + loginLIbrary;
            rClient.endPoint = "http://azureserverdm16.eastus.cloudapp.azure.com:7080/edocsapi/v1.0/documents/18644/profile?library=LEGAL";
            rClient.httpMethod = httpVerb.PUT;
            string statusCode = string.Empty;
            int rc = 0;

            //{"data":{"%CHECKIN_LOCATION":"C:\\Users\\cdunsford\\Downloads","_restapi":{},"%STATUS":"%LOCK_FOR_CHECKOUT"}}
            //rClient.jSON = "{ \"data\":{ \"%CHECKIN_LOCATION\":\"C:\\Users\\cdunsford\\Downloads\",\"_restapi\":{},\"%STATUS\":\"%LOCK_FOR_CHECKOUT\" } }";
            rClient.jSON = "{\"data\":{\"%CHECKIN_LOCATION\":\"C:\\Users\\cdunsford\\Downloads\",\"_restapi\":{},\"%STATUS\":\"%LOCK_FOR_CHECKOUT\"}}";
            statusCode = rClient.CheckOutDocument();
            DebugOutput("Objecct Created = " + statusCode);
            
        
        }
    }
}
