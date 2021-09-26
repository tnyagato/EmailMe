namespace EmailMe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnSend = new System.Windows.Forms.Button();
			this.txtResponse = new System.Windows.Forms.RichTextBox();
			this.txtFrom = new System.Windows.Forms.TextBox();
			this.txtTo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.txtBody = new System.Windows.Forms.RichTextBox();
			this.cbkSSL = new System.Windows.Forms.CheckBox();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.cbkHTML = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(418, 23);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(55, 131);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtResponse
			// 
			this.txtResponse.Location = new System.Drawing.Point(12, 304);
			this.txtResponse.Name = "txtResponse";
			this.txtResponse.ReadOnly = true;
			this.txtResponse.Size = new System.Drawing.Size(461, 89);
			this.txtResponse.TabIndex = 1;
			this.txtResponse.Text = "";
			// 
			// txtFrom
			// 
			this.txtFrom.Location = new System.Drawing.Point(99, 23);
			this.txtFrom.Name = "txtFrom";
			this.txtFrom.Size = new System.Drawing.Size(229, 20);
			this.txtFrom.TabIndex = 2;
			// 
			// txtTo
			// 
			this.txtTo.Location = new System.Drawing.Point(99, 49);
			this.txtTo.Name = "txtTo";
			this.txtTo.Size = new System.Drawing.Size(229, 20);
			this.txtTo.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "From";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "To";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Body";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Subject";
			// 
			// txtSubject
			// 
			this.txtSubject.Location = new System.Drawing.Point(99, 89);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(229, 20);
			this.txtSubject.TabIndex = 6;
			// 
			// txtBody
			// 
			this.txtBody.Location = new System.Drawing.Point(99, 118);
			this.txtBody.Name = "txtBody";
			this.txtBody.Size = new System.Drawing.Size(229, 39);
			this.txtBody.TabIndex = 10;
			this.txtBody.Text = "";
			// 
			// cbkSSL
			// 
			this.cbkSSL.AutoSize = true;
			this.cbkSSL.Location = new System.Drawing.Point(17, 194);
			this.cbkSSL.Name = "cbkSSL";
			this.cbkSSL.Size = new System.Drawing.Size(46, 17);
			this.cbkSSL.TabIndex = 11;
			this.cbkSSL.Text = "SSL";
			this.cbkSSL.UseVisualStyleBackColor = true;
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(331, 233);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(61, 20);
			this.txtPort.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(287, 236);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Port";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 233);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Username";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(97, 230);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(164, 20);
			this.txtUsername.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 259);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "Password";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(97, 256);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(164, 20);
			this.txtPassword.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(287, 262);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "Server";
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(331, 259);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(135, 20);
			this.txtServer.TabIndex = 18;
			// 
			// cbkHTML
			// 
			this.cbkHTML.AutoSize = true;
			this.cbkHTML.Checked = true;
			this.cbkHTML.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbkHTML.Location = new System.Drawing.Point(99, 194);
			this.cbkHTML.Name = "cbkHTML";
			this.cbkHTML.Size = new System.Drawing.Size(56, 17);
			this.cbkHTML.TabIndex = 20;
			this.cbkHTML.Text = "HTML";
			this.cbkHTML.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 405);
			this.Controls.Add(this.cbkHTML);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtServer);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.cbkSSL);
			this.Controls.Add(this.txtBody);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSubject);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTo);
			this.Controls.Add(this.txtFrom);
			this.Controls.Add(this.txtResponse);
			this.Controls.Add(this.btnSend);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Email Test Tool";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.RichTextBox txtResponse;
		private System.Windows.Forms.TextBox txtFrom;
		private System.Windows.Forms.TextBox txtTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.RichTextBox txtBody;
		private System.Windows.Forms.CheckBox cbkSSL;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.CheckBox cbkHTML;
	}
}

