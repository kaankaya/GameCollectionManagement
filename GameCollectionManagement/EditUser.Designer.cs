namespace GameCollectionManagement
{
    partial class EditUser
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtRole = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 169);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 15;
            label4.Text = "Role:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 121);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 14;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 78);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 13;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 34);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 12;
            label1.Text = "UserName:";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(138, 161);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(170, 23);
            txtRole.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(138, 118);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 23);
            txtPassword.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(138, 75);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(170, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(138, 31);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(170, 23);
            txtUserName.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(263, 211);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "Güncelle";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 291);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRole);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Name = "EditUser";
            Text = "EditUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtRole;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtUserName;
        private Button btnSave;
    }
}