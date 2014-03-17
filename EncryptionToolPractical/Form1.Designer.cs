namespace EncryptionToolPractical
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
            this.encryptionMethodsGroup = new System.Windows.Forms.GroupBox();
            this.rot13EncryptRB = new System.Windows.Forms.RadioButton();
            this.plainTextEncryptRB = new System.Windows.Forms.RadioButton();
            this.textToEncryptTB = new System.Windows.Forms.TextBox();
            this.encryptedTextResultsTB = new System.Windows.Forms.TextBox();
            this.textToEncryptGroup = new System.Windows.Forms.GroupBox();
            this.encryptTextBTN = new System.Windows.Forms.Button();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.encryptionMethodsGroup.SuspendLayout();
            this.textToEncryptGroup.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // encryptionMethodsGroup
            // 
            this.encryptionMethodsGroup.Controls.Add(this.rot13EncryptRB);
            this.encryptionMethodsGroup.Controls.Add(this.plainTextEncryptRB);
            this.encryptionMethodsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptionMethodsGroup.Location = new System.Drawing.Point(12, 12);
            this.encryptionMethodsGroup.Name = "encryptionMethodsGroup";
            this.encryptionMethodsGroup.Size = new System.Drawing.Size(374, 86);
            this.encryptionMethodsGroup.TabIndex = 0;
            this.encryptionMethodsGroup.TabStop = false;
            this.encryptionMethodsGroup.Text = "Encryption Method";
            // 
            // rot13EncryptRB
            // 
            this.rot13EncryptRB.AutoSize = true;
            this.rot13EncryptRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rot13EncryptRB.Location = new System.Drawing.Point(6, 56);
            this.rot13EncryptRB.Name = "rot13EncryptRB";
            this.rot13EncryptRB.Size = new System.Drawing.Size(78, 24);
            this.rot13EncryptRB.TabIndex = 1;
            this.rot13EncryptRB.Text = "ROT13";
            this.rot13EncryptRB.UseVisualStyleBackColor = true;
            // 
            // plainTextEncryptRB
            // 
            this.plainTextEncryptRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plainTextEncryptRB.Location = new System.Drawing.Point(6, 25);
            this.plainTextEncryptRB.Name = "plainTextEncryptRB";
            this.plainTextEncryptRB.Size = new System.Drawing.Size(95, 24);
            this.plainTextEncryptRB.TabIndex = 0;
            this.plainTextEncryptRB.Text = "Plain Text";
            this.plainTextEncryptRB.UseVisualStyleBackColor = true;
            // 
            // textToEncryptTB
            // 
            this.textToEncryptTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToEncryptTB.Location = new System.Drawing.Point(6, 24);
            this.textToEncryptTB.Name = "textToEncryptTB";
            this.textToEncryptTB.Size = new System.Drawing.Size(228, 26);
            this.textToEncryptTB.TabIndex = 1;
            this.textToEncryptTB.Text = "Please encrypt me!";
            // 
            // encryptedTextResultsTB
            // 
            this.encryptedTextResultsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedTextResultsTB.Location = new System.Drawing.Point(6, 25);
            this.encryptedTextResultsTB.Multiline = true;
            this.encryptedTextResultsTB.Name = "encryptedTextResultsTB";
            this.encryptedTextResultsTB.Size = new System.Drawing.Size(358, 138);
            this.encryptedTextResultsTB.TabIndex = 2;
            // 
            // textToEncryptGroup
            // 
            this.textToEncryptGroup.Controls.Add(this.encryptTextBTN);
            this.textToEncryptGroup.Controls.Add(this.textToEncryptTB);
            this.textToEncryptGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToEncryptGroup.Location = new System.Drawing.Point(11, 104);
            this.textToEncryptGroup.Name = "textToEncryptGroup";
            this.textToEncryptGroup.Size = new System.Drawing.Size(375, 61);
            this.textToEncryptGroup.TabIndex = 5;
            this.textToEncryptGroup.TabStop = false;
            this.textToEncryptGroup.Text = "Text To Encrypt";
            // 
            // encryptTextBTN
            // 
            this.encryptTextBTN.Location = new System.Drawing.Point(250, 24);
            this.encryptTextBTN.Name = "encryptTextBTN";
            this.encryptTextBTN.Size = new System.Drawing.Size(115, 26);
            this.encryptTextBTN.TabIndex = 2;
            this.encryptTextBTN.Text = "Encrypt Me";
            this.encryptTextBTN.UseVisualStyleBackColor = true;
            this.encryptTextBTN.Click += new System.EventHandler(this.encryptTextBTN_Click);
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.encryptedTextResultsTB);
            this.resultsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsGroupBox.Location = new System.Drawing.Point(12, 181);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(374, 173);
            this.resultsGroupBox.TabIndex = 6;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results Of Encrypted Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 364);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.textToEncryptGroup);
            this.Controls.Add(this.encryptionMethodsGroup);
            this.Name = "Form1";
            this.Text = "SuperTextEncryptor";
            this.encryptionMethodsGroup.ResumeLayout(false);
            this.encryptionMethodsGroup.PerformLayout();
            this.textToEncryptGroup.ResumeLayout(false);
            this.textToEncryptGroup.PerformLayout();
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox encryptionMethodsGroup;
        private System.Windows.Forms.RadioButton rot13EncryptRB;
        private System.Windows.Forms.RadioButton plainTextEncryptRB;
        private System.Windows.Forms.TextBox textToEncryptTB;
        private System.Windows.Forms.TextBox encryptedTextResultsTB;
        private System.Windows.Forms.GroupBox textToEncryptGroup;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.Button encryptTextBTN;
    }
}

