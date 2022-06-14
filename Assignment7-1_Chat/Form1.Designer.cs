
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
            this.iPAddressTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.friendIPAddressTextBox = new System.Windows.Forms.TextBox();
            this.iPAddressPortTextBox = new System.Windows.Forms.TextBox();
            this.friendIPAddressPortTextBox = new System.Windows.Forms.TextBox();
            this.iPAddressLabel = new System.Windows.Forms.Label();
            this.friendIPAddressLabel = new System.Windows.Forms.Label();
            this.iPAddressPortLabel = new System.Windows.Forms.Label();
            this.friendIPAddressPortLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.mainRIchTextBox = new System.Windows.Forms.RichTextBox();
            this.subRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // iPAddressTextBox
            // 
            this.iPAddressTextBox.Location = new System.Drawing.Point(171, 32);
            this.iPAddressTextBox.Name = "iPAddressTextBox";
            this.iPAddressTextBox.Size = new System.Drawing.Size(170, 20);
            this.iPAddressTextBox.TabIndex = 0;
            // 
            // friendIPAddressTextBox
            // 
            this.friendIPAddressTextBox.Location = new System.Drawing.Point(171, 58);
            this.friendIPAddressTextBox.Name = "friendIPAddressTextBox";
            this.friendIPAddressTextBox.Size = new System.Drawing.Size(170, 20);
            this.friendIPAddressTextBox.TabIndex = 1;
            // 
            // iPAddressPortTextBox
            // 
            this.iPAddressPortTextBox.Location = new System.Drawing.Point(403, 32);
            this.iPAddressPortTextBox.Name = "iPAddressPortTextBox";
            this.iPAddressPortTextBox.Size = new System.Drawing.Size(113, 20);
            this.iPAddressPortTextBox.TabIndex = 2;
            // 
            // friendIPAddressPortTextBox
            // 
            this.friendIPAddressPortTextBox.Location = new System.Drawing.Point(403, 58);
            this.friendIPAddressPortTextBox.Name = "friendIPAddressPortTextBox";
            this.friendIPAddressPortTextBox.Size = new System.Drawing.Size(113, 20);
            this.friendIPAddressPortTextBox.TabIndex = 3;
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
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(75, 84);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(441, 37);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // mainRIchTextBox
            // 
            this.mainRIchTextBox.Location = new System.Drawing.Point(75, 127);
            this.mainRIchTextBox.Name = "mainRIchTextBox";
            this.mainRIchTextBox.Size = new System.Drawing.Size(441, 213);
            this.mainRIchTextBox.TabIndex = 9;
            this.mainRIchTextBox.Text = "";
            // 
            // subRichTextBox
            // 
            this.subRichTextBox.Location = new System.Drawing.Point(75, 347);
            this.subRichTextBox.Name = "subRichTextBox";
            this.subRichTextBox.Size = new System.Drawing.Size(441, 25);
            this.subRichTextBox.TabIndex = 10;
            this.subRichTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(441, 378);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 11;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.subRichTextBox);
            this.Controls.Add(this.mainRIchTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.friendIPAddressPortLabel);
            this.Controls.Add(this.iPAddressPortLabel);
            this.Controls.Add(this.friendIPAddressLabel);
            this.Controls.Add(this.iPAddressLabel);
            this.Controls.Add(this.friendIPAddressPortTextBox);
            this.Controls.Add(this.iPAddressPortTextBox);
            this.Controls.Add(this.friendIPAddressTextBox);
            this.Controls.Add(this.iPAddressTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iPAddressTextBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox friendIPAddressTextBox;
        private System.Windows.Forms.TextBox iPAddressPortTextBox;
        private System.Windows.Forms.TextBox friendIPAddressPortTextBox;
        private System.Windows.Forms.Label iPAddressLabel;
        private System.Windows.Forms.Label friendIPAddressLabel;
        private System.Windows.Forms.Label iPAddressPortLabel;
        private System.Windows.Forms.Label friendIPAddressPortLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RichTextBox mainRIchTextBox;
        private System.Windows.Forms.RichTextBox subRichTextBox;
        private System.Windows.Forms.Button sendButton;
    }
}

