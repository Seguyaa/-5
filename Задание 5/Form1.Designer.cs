namespace EncryptionExample
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.TextBox textBoxDecrypted;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // textBoxInput
            //
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxInput.Location = new System.Drawing.Point(0, 0);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(800, 20);
            this.textBoxInput.TabIndex = 0;
            //
            // buttonEncrypt
            //
            this.buttonEncrypt.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEncrypt.Location = new System.Drawing.Point(0, 20);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(800, 23);
            this.buttonEncrypt.TabIndex = 1;
            this.buttonEncrypt.Text = "Шифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            //
            // buttonDecrypt
            //
            this.buttonDecrypt.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDecrypt.Location = new System.Drawing.Point(0, 43);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(800, 23);
            this.buttonDecrypt.TabIndex = 2;
            this.buttonDecrypt.Text = "Дешифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            //
            // textBoxEncrypted
            //
            this.textBoxEncrypted.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxEncrypted.Location = new System.Drawing.Point(0, 66);
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.ReadOnly = true;
            this.textBoxEncrypted.Size = new System.Drawing.Size(800, 20);
            this.textBoxEncrypted.TabIndex = 3;
            //
            // textBoxDecrypted
            //
            this.textBoxDecrypted.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDecrypted.Location = new System.Drawing.Point(0, 86);
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.ReadOnly = true;
            this.textBoxDecrypted.Size = new System.Drawing.Size(800, 20);
            this.textBoxDecrypted.TabIndex = 4;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDecrypted);
            this.Controls.Add(this.textBoxEncrypted);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
