namespace CaseStudy_DevExp
{
    partial class ChildForm
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
            emailText = new DevExpress.XtraEditors.TextEdit();
            passwordText = new DevExpress.XtraEditors.TextEdit();
            Login = new DevExpress.XtraEditors.SimpleButton();
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)emailText.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordText.Properties).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // emailText
            // 
            emailText.Location = new System.Drawing.Point(156, 143);
            emailText.Name = "emailText";
            emailText.Size = new System.Drawing.Size(175, 20);
            emailText.TabIndex = 1;
            emailText.EditValueChanged += textEdit1_EditValueChanged;
            // 
            // passwordText
            // 
            passwordText.Location = new System.Drawing.Point(156, 169);
            passwordText.Name = "passwordText";
            passwordText.Properties.UseSystemPasswordChar = true;
            passwordText.Size = new System.Drawing.Size(175, 20);
            passwordText.TabIndex = 2;
            passwordText.EditValueChanged += passwordText_EditValueChanged;
            // 
            // Login
            // 
            Login.Location = new System.Drawing.Point(156, 214);
            Login.Name = "Login";
            Login.Size = new System.Drawing.Size(175, 24);
            Login.TabIndex = 3;
            Login.Text = "Login";
            Login.Click += simpleButton1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Login);
            panel1.Controls.Add(emailText);
            panel1.Controls.Add(passwordText);
            panel1.Location = new System.Drawing.Point(12, -5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(467, 381);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            label3.Location = new System.Drawing.Point(95, 171);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 15);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            label2.Location = new System.Drawing.Point(95, 145);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "E-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            label1.Location = new System.Drawing.Point(195, 101);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 19);
            label1.TabIndex = 6;
            label1.Text = "Login Panel";
            label1.Click += label1_Click;
            // 
            // ChildForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(498, 388);
            Controls.Add(panel1);
            Name = "ChildForm";
            Text = "ChildForm";
            ((System.ComponentModel.ISupportInitialize)emailText.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordText.Properties).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit emailText;
        private DevExpress.XtraEditors.TextEdit passwordText;
        private DevExpress.XtraEditors.SimpleButton Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}