
namespace Assignment7_1_Chat
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
            this.components = new System.ComponentModel.Container();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.textFriendsIp = new System.Windows.Forms.TextBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textFriendsPort = new System.Windows.Forms.TextBox();
            this.iPAddressLabel = new System.Windows.Forms.Label();
            this.friendIPAddressLabel = new System.Windows.Forms.Label();
            this.iPAddressPortLabel = new System.Windows.Forms.Label();
            this.friendIPAddressPortLabel = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.RichTextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listMessage = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(171, 32);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(170, 20);
            this.textLocalIp.TabIndex = 0;
            // 
            // textFriendsIp
            // 
            this.textFriendsIp.Location = new System.Drawing.Point(171, 58);
            this.textFriendsIp.Name = "textFriendsIp";
            this.textFriendsIp.Size = new System.Drawing.Size(170, 20);
            this.textFriendsIp.TabIndex = 1;
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(403, 32);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(113, 20);
            this.textLocalPort.TabIndex = 2;
            // 
            // textFriendsPort
            // 
            this.textFriendsPort.Location = new System.Drawing.Point(403, 58);
            this.textFriendsPort.Name = "textFriendsPort";
            this.textFriendsPort.Size = new System.Drawing.Size(113, 20);
            this.textFriendsPort.TabIndex = 3;
            // 
            // iPAddressLabel
            // 
            this.iPAddressLabel.AutoSize = true;
            this.iPAddressLabel.Location = new System.Drawing.Point(72, 35);
            this.iPAddressLabel.Name = "iPAddressLabel";
            this.iPAddressLabel.Size = new System.Drawing.Size(61, 13);
            this.iPAddressLabel.TabIndex = 4;
            this.iPAddressLabel.Text = "IP Address:";
            // 
            // friendIPAddressLabel
            // 
            this.friendIPAddressLabel.AutoSize = true;
            this.friendIPAddressLabel.Location = new System.Drawing.Point(72, 61);
            this.friendIPAddressLabel.Name = "friendIPAddressLabel";
            this.friendIPAddressLabel.Size = new System.Drawing.Size(93, 13);
            this.friendIPAddressLabel.TabIndex = 5;
            this.friendIPAddressLabel.Text = "Friend IP Address:";
            // 
            // iPAddressPortLabel
            // 
            this.iPAddressPortLabel.AutoSize = true;
            this.iPAddressPortLabel.Location = new System.Drawing.Point(368, 35);
            this.iPAddressPortLabel.Name = "iPAddressPortLabel";
            this.iPAddressPortLabel.Size = new System.Drawing.Size(29, 13);
            this.iPAddressPortLabel.TabIndex = 6;
            this.iPAddressPortLabel.Text = "Port:";
            // 
            // friendIPAddressPortLabel
            // 
            this.friendIPAddressPortLabel.AutoSize = true;
            this.friendIPAddressPortLabel.Location = new System.Drawing.Point(368, 61);
            this.friendIPAddressPortLabel.Name = "friendIPAddressPortLabel";
            this.friendIPAddressPortLabel.Size = new System.Drawing.Size(29, 13);
            this.friendIPAddressPortLabel.TabIndex = 7;
            this.friendIPAddressPortLabel.Text = "Port:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(75, 84);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(441, 37);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(75, 127);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(441, 213);
            this.textMessage.TabIndex = 9;
            this.textMessage.Text = "";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(441, 382);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 11;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(75, 346);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(441, 30);
            this.listMessage.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.friendIPAddressPortLabel);
            this.Controls.Add(this.iPAddressPortLabel);
            this.Controls.Add(this.friendIPAddressLabel);
            this.Controls.Add(this.iPAddressLabel);
            this.Controls.Add(this.textFriendsPort);
            this.Controls.Add(this.textLocalPort);
            this.Controls.Add(this.textFriendsIp);
            this.Controls.Add(this.textLocalIp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.TextBox textFriendsIp;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textFriendsPort;
        private System.Windows.Forms.Label iPAddressLabel;
        private System.Windows.Forms.Label friendIPAddressLabel;
        private System.Windows.Forms.Label iPAddressPortLabel;
        private System.Windows.Forms.Label friendIPAddressPortLabel;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox textMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox listMessage;
    }
}

