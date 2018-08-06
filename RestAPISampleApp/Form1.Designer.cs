namespace RestAPISampleApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxURI = new System.Windows.Forms.TextBox();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxAuthenticationType = new System.Windows.Forms.GroupBox();
            this.radioButtonNTLM = new System.Windows.Forms.RadioButton();
            this.radioButtonBasicAuthentication = new System.Windows.Forms.RadioButton();
            this.groupBoxTechnique = new System.Windows.Forms.GroupBox();
            this.radioButtonNetworkCredentialClass = new System.Windows.Forms.RadioButton();
            this.radioButtonRollYourOwn = new System.Windows.Forms.RadioButton();
            this.comboBoxActionItems = new System.Windows.Forms.ComboBox();
            this.labelCreate = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxLibraries = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxObjectName = new System.Windows.Forms.TextBox();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.textBoxDocumentNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonGet = new System.Windows.Forms.Button();
            this.comboBoxGetItems = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxAuthenticationType.SuspendLayout();
            this.groupBoxTechnique.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxURI
            // 
            this.textBoxURI.Location = new System.Drawing.Point(129, 19);
            this.textBoxURI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxURI.Name = "textBoxURI";
            this.textBoxURI.Size = new System.Drawing.Size(412, 20);
            this.textBoxURI.TabIndex = 0;
            this.textBoxURI.Text = "http://azureserverdm16.eastus.cloudapp.azure.com:7080";
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResponse.Location = new System.Drawing.Point(123, 348);
            this.textBoxResponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponse.Size = new System.Drawing.Size(434, 153);
            this.textBoxResponse.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(129, 102);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(77, 34);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Request URI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Response:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(132, 75);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(154, 20);
            this.textBoxUserName.TabIndex = 5;
            this.textBoxUserName.Text = "cdunsford";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(420, 75);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(122, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // groupBoxAuthenticationType
            // 
            this.groupBoxAuthenticationType.Controls.Add(this.radioButtonNTLM);
            this.groupBoxAuthenticationType.Controls.Add(this.radioButtonBasicAuthentication);
            this.groupBoxAuthenticationType.Location = new System.Drawing.Point(724, 41);
            this.groupBoxAuthenticationType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAuthenticationType.Name = "groupBoxAuthenticationType";
            this.groupBoxAuthenticationType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAuthenticationType.Size = new System.Drawing.Size(184, 57);
            this.groupBoxAuthenticationType.TabIndex = 9;
            this.groupBoxAuthenticationType.TabStop = false;
            this.groupBoxAuthenticationType.Text = "Authen Type";
            // 
            // radioButtonNTLM
            // 
            this.radioButtonNTLM.AutoSize = true;
            this.radioButtonNTLM.Location = new System.Drawing.Point(8, 34);
            this.radioButtonNTLM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonNTLM.Name = "radioButtonNTLM";
            this.radioButtonNTLM.Size = new System.Drawing.Size(108, 17);
            this.radioButtonNTLM.TabIndex = 1;
            this.radioButtonNTLM.TabStop = true;
            this.radioButtonNTLM.Text = "NTLM (Windows)";
            this.radioButtonNTLM.UseVisualStyleBackColor = true;
            // 
            // radioButtonBasicAuthentication
            // 
            this.radioButtonBasicAuthentication.AutoSize = true;
            this.radioButtonBasicAuthentication.Checked = true;
            this.radioButtonBasicAuthentication.Location = new System.Drawing.Point(8, 16);
            this.radioButtonBasicAuthentication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonBasicAuthentication.Name = "radioButtonBasicAuthentication";
            this.radioButtonBasicAuthentication.Size = new System.Drawing.Size(122, 17);
            this.radioButtonBasicAuthentication.TabIndex = 0;
            this.radioButtonBasicAuthentication.TabStop = true;
            this.radioButtonBasicAuthentication.Text = "Basic Authentication";
            this.radioButtonBasicAuthentication.UseVisualStyleBackColor = true;
            // 
            // groupBoxTechnique
            // 
            this.groupBoxTechnique.Controls.Add(this.radioButtonNetworkCredentialClass);
            this.groupBoxTechnique.Controls.Add(this.radioButtonRollYourOwn);
            this.groupBoxTechnique.Location = new System.Drawing.Point(711, 124);
            this.groupBoxTechnique.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTechnique.Name = "groupBoxTechnique";
            this.groupBoxTechnique.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTechnique.Size = new System.Drawing.Size(198, 57);
            this.groupBoxTechnique.TabIndex = 10;
            this.groupBoxTechnique.TabStop = false;
            this.groupBoxTechnique.Text = "Technique";
            // 
            // radioButtonNetworkCredentialClass
            // 
            this.radioButtonNetworkCredentialClass.AutoSize = true;
            this.radioButtonNetworkCredentialClass.Location = new System.Drawing.Point(10, 34);
            this.radioButtonNetworkCredentialClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonNetworkCredentialClass.Name = "radioButtonNetworkCredentialClass";
            this.radioButtonNetworkCredentialClass.Size = new System.Drawing.Size(140, 17);
            this.radioButtonNetworkCredentialClass.TabIndex = 3;
            this.radioButtonNetworkCredentialClass.TabStop = true;
            this.radioButtonNetworkCredentialClass.Text = "NetworkCredential Class";
            this.radioButtonNetworkCredentialClass.UseVisualStyleBackColor = true;
            // 
            // radioButtonRollYourOwn
            // 
            this.radioButtonRollYourOwn.AutoSize = true;
            this.radioButtonRollYourOwn.Checked = true;
            this.radioButtonRollYourOwn.Location = new System.Drawing.Point(10, 16);
            this.radioButtonRollYourOwn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonRollYourOwn.Name = "radioButtonRollYourOwn";
            this.radioButtonRollYourOwn.Size = new System.Drawing.Size(93, 17);
            this.radioButtonRollYourOwn.TabIndex = 2;
            this.radioButtonRollYourOwn.TabStop = true;
            this.radioButtonRollYourOwn.Text = "Roll Your Own";
            this.radioButtonRollYourOwn.UseVisualStyleBackColor = true;
            // 
            // comboBoxActionItems
            // 
            this.comboBoxActionItems.FormattingEnabled = true;
            this.comboBoxActionItems.Items.AddRange(new object[] {
            "documents",
            "folders"});
            this.comboBoxActionItems.Location = new System.Drawing.Point(76, 110);
            this.comboBoxActionItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxActionItems.Name = "comboBoxActionItems";
            this.comboBoxActionItems.Size = new System.Drawing.Size(154, 21);
            this.comboBoxActionItems.TabIndex = 13;
            this.comboBoxActionItems.Text = "documents";
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.Location = new System.Drawing.Point(24, 114);
            this.labelCreate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(38, 13);
            this.labelCreate.TabIndex = 14;
            this.labelCreate.Text = "Create";
            // 
            // buttonGo
            // 
            this.buttonGo.Enabled = false;
            this.buttonGo.Location = new System.Drawing.Point(76, 132);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(58, 28);
            this.buttonGo.TabIndex = 15;
            this.buttonGo.Text = "Go!";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Library";
            // 
            // comboBoxLibraries
            // 
            this.comboBoxLibraries.FormattingEnabled = true;
            this.comboBoxLibraries.Location = new System.Drawing.Point(129, 48);
            this.comboBoxLibraries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxLibraries.Name = "comboBoxLibraries";
            this.comboBoxLibraries.Size = new System.Drawing.Size(154, 21);
            this.comboBoxLibraries.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Object Name";
            // 
            // textBoxObjectName
            // 
            this.textBoxObjectName.Location = new System.Drawing.Point(363, 114);
            this.textBoxObjectName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxObjectName.Name = "textBoxObjectName";
            this.textBoxObjectName.Size = new System.Drawing.Size(121, 20);
            this.textBoxObjectName.TabIndex = 18;
            this.textBoxObjectName.Text = "My New Object";
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.buttonCheckout);
            this.groupBoxAction.Controls.Add(this.textBoxDocumentNumber);
            this.groupBoxAction.Controls.Add(this.label9);
            this.groupBoxAction.Controls.Add(this.textBoxFilePath);
            this.groupBoxAction.Controls.Add(this.label8);
            this.groupBoxAction.Controls.Add(this.buttonGet);
            this.groupBoxAction.Controls.Add(this.comboBoxGetItems);
            this.groupBoxAction.Controls.Add(this.label5);
            this.groupBoxAction.Controls.Add(this.textBoxObjectName);
            this.groupBoxAction.Controls.Add(this.label7);
            this.groupBoxAction.Controls.Add(this.comboBoxActionItems);
            this.groupBoxAction.Controls.Add(this.labelCreate);
            this.groupBoxAction.Controls.Add(this.buttonGo);
            this.groupBoxAction.Location = new System.Drawing.Point(54, 154);
            this.groupBoxAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAction.Size = new System.Drawing.Size(501, 178);
            this.groupBoxAction.TabIndex = 20;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Actions";
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Enabled = false;
            this.buttonCheckout.Location = new System.Drawing.Point(413, 55);
            this.buttonCheckout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(73, 28);
            this.buttonCheckout.TabIndex = 26;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // textBoxDocumentNumber
            // 
            this.textBoxDocumentNumber.Location = new System.Drawing.Point(363, 27);
            this.textBoxDocumentNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDocumentNumber.Name = "textBoxDocumentNumber";
            this.textBoxDocumentNumber.Size = new System.Drawing.Size(125, 20);
            this.textBoxDocumentNumber.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "DocNumber";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilePath.Location = new System.Drawing.Point(242, 138);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(242, 23);
            this.textBoxFilePath.TabIndex = 23;
            this.textBoxFilePath.Text = "c:\\uploads\\testfile.docx";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "File Path";
            // 
            // buttonGet
            // 
            this.buttonGet.Enabled = false;
            this.buttonGet.Location = new System.Drawing.Point(76, 55);
            this.buttonGet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(58, 28);
            this.buttonGet.TabIndex = 22;
            this.buttonGet.Text = "Get!";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // comboBoxGetItems
            // 
            this.comboBoxGetItems.FormattingEnabled = true;
            this.comboBoxGetItems.Items.AddRange(new object[] {
            "documents",
            "matters",
            "clients"});
            this.comboBoxGetItems.Location = new System.Drawing.Point(76, 27);
            this.comboBoxGetItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxGetItems.Name = "comboBoxGetItems";
            this.comboBoxGetItems.Size = new System.Drawing.Size(154, 21);
            this.comboBoxGetItems.TabIndex = 21;
            this.comboBoxGetItems.Text = "documents";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Get";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 552);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxLibraries);
            this.Controls.Add(this.groupBoxTechnique);
            this.Controls.Add(this.groupBoxAuthenticationType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.textBoxURI);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(21, 558);
            this.Name = "Form1";
            this.Text = "C# Rest API Sample Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAuthenticationType.ResumeLayout(false);
            this.groupBoxAuthenticationType.PerformLayout();
            this.groupBoxTechnique.ResumeLayout(false);
            this.groupBoxTechnique.PerformLayout();
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURI;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxAuthenticationType;
        private System.Windows.Forms.GroupBox groupBoxTechnique;
        private System.Windows.Forms.RadioButton radioButtonNTLM;
        private System.Windows.Forms.RadioButton radioButtonBasicAuthentication;
        private System.Windows.Forms.RadioButton radioButtonNetworkCredentialClass;
        private System.Windows.Forms.RadioButton radioButtonRollYourOwn;
        private System.Windows.Forms.ComboBox comboBoxActionItems;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxLibraries;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxObjectName;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.ComboBox comboBoxGetItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.TextBox textBoxDocumentNumber;
        private System.Windows.Forms.Label label9;
    }
}

