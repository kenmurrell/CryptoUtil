namespace CryptoUtil
{
    partial class CryptoUtil
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
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.decryptedLabel = new System.Windows.Forms.Label();
            this.encryptedLabel = new System.Windows.Forms.Label();
            this.decryptedTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptedTextBox = new System.Windows.Forms.RichTextBox();
            this.genKeysButton = new System.Windows.Forms.Button();
            this.loadKeysButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.keyTextBox = new System.Windows.Forms.RichTextBox();
            this.keysLabel = new System.Windows.Forms.Label();
            this.messageLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(219, 101);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "&ENCRYPT";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(219, 141);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 1;
            this.decryptButton.Text = "&DECRYPT";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // decryptedLabel
            // 
            this.decryptedLabel.AutoSize = true;
            this.decryptedLabel.Location = new System.Drawing.Point(62, 24);
            this.decryptedLabel.Name = "decryptedLabel";
            this.decryptedLabel.Size = new System.Drawing.Size(56, 13);
            this.decryptedLabel.TabIndex = 2;
            this.decryptedLabel.Text = "Decrypted";
            // 
            // encryptedLabel
            // 
            this.encryptedLabel.AutoSize = true;
            this.encryptedLabel.Location = new System.Drawing.Point(382, 24);
            this.encryptedLabel.Name = "encryptedLabel";
            this.encryptedLabel.Size = new System.Drawing.Size(55, 13);
            this.encryptedLabel.TabIndex = 3;
            this.encryptedLabel.Text = "Encrypted";
            // 
            // decryptedTextBox
            // 
            this.decryptedTextBox.Location = new System.Drawing.Point(12, 51);
            this.decryptedTextBox.Name = "decryptedTextBox";
            this.decryptedTextBox.Size = new System.Drawing.Size(177, 164);
            this.decryptedTextBox.TabIndex = 6;
            this.decryptedTextBox.Text = "";
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Location = new System.Drawing.Point(317, 51);
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.Size = new System.Drawing.Size(180, 164);
            this.encryptedTextBox.TabIndex = 7;
            this.encryptedTextBox.Text = "";
            // 
            // genKeysButton
            // 
            this.genKeysButton.Location = new System.Drawing.Point(12, 243);
            this.genKeysButton.Name = "genKeysButton";
            this.genKeysButton.Size = new System.Drawing.Size(75, 53);
            this.genKeysButton.TabIndex = 8;
            this.genKeysButton.Text = "Generate Keys";
            this.genKeysButton.UseVisualStyleBackColor = true;
            this.genKeysButton.Click += new System.EventHandler(this.genKeysButton_Click);
            // 
            // loadKeysButton
            // 
            this.loadKeysButton.Location = new System.Drawing.Point(114, 243);
            this.loadKeysButton.Name = "loadKeysButton";
            this.loadKeysButton.Size = new System.Drawing.Size(75, 53);
            this.loadKeysButton.TabIndex = 10;
            this.loadKeysButton.Text = "Load Keys";
            this.loadKeysButton.UseVisualStyleBackColor = true;
            this.loadKeysButton.Click += new System.EventHandler(this.loadKeysButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(256, 243);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(195, 25);
            this.keyTextBox.TabIndex = 11;
            this.keyTextBox.Text = "";
            // 
            // keysLabel
            // 
            this.keysLabel.AutoSize = true;
            this.keysLabel.Location = new System.Drawing.Point(195, 246);
            this.keysLabel.Name = "keysLabel";
            this.keysLabel.Size = new System.Drawing.Size(24, 13);
            this.keysLabel.TabIndex = 13;
            this.keysLabel.Text = "key";
            // 
            // messageLabel1
            // 
            this.messageLabel1.AutoSize = true;
            this.messageLabel1.Location = new System.Drawing.Point(461, 264);
            this.messageLabel1.Name = "messageLabel1";
            this.messageLabel1.Size = new System.Drawing.Size(0, 13);
            this.messageLabel1.TabIndex = 15;
            // 
            // CryptoUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 311);
            this.Controls.Add(this.messageLabel1);
            this.Controls.Add(this.keysLabel);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.loadKeysButton);
            this.Controls.Add(this.genKeysButton);
            this.Controls.Add(this.encryptedTextBox);
            this.Controls.Add(this.decryptedTextBox);
            this.Controls.Add(this.encryptedLabel);
            this.Controls.Add(this.decryptedLabel);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Name = "CryptoUtil";
            this.Text = "CryptoUtil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label decryptedLabel;
        private System.Windows.Forms.Label encryptedLabel;
        private System.Windows.Forms.RichTextBox decryptedTextBox;
        private System.Windows.Forms.RichTextBox encryptedTextBox;
        private System.Windows.Forms.Button genKeysButton;
        private System.Windows.Forms.Button loadKeysButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox keyTextBox;
        private System.Windows.Forms.Label keysLabel;
        private System.Windows.Forms.Label messageLabel1;
    }
}

