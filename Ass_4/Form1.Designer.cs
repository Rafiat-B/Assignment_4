namespace Ass_4
{
    partial class LoginForm
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
            Btn_Login = new System.Windows.Forms.Button();
            Btn_Cancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txt_UserId = new System.Windows.Forms.TextBox();
            txt_Password = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // Btn_Login
            // 
            Btn_Login.Location = new System.Drawing.Point(109, 351);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new System.Drawing.Size(163, 43);
            Btn_Login.TabIndex = 0;
            Btn_Login.Text = "Login";
            Btn_Login.UseVisualStyleBackColor = true;
            Btn_Login.Click += Btn_Login_Click;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new System.Drawing.Point(383, 351);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new System.Drawing.Size(163, 43);
            Btn_Cancel.TabIndex = 1;
            Btn_Cancel.Text = "Cancel";
            Btn_Cancel.UseVisualStyleBackColor = true;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(109, 79);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 30);
            label1.TabIndex = 2;
            label1.Text = "User ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(109, 181);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 30);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // txt_UserId
            // 
            txt_UserId.Location = new System.Drawing.Point(274, 80);
            txt_UserId.Name = "txt_UserId";
            txt_UserId.Size = new System.Drawing.Size(253, 31);
            txt_UserId.TabIndex = 4;
            // 
            // txt_Password
            // 
            txt_Password.Location = new System.Drawing.Point(274, 182);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new System.Drawing.Size(253, 31);
            txt_Password.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(680, 558);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_Login);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.TextBox txt_Password;
    }
}

