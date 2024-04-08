namespace Ass_4
{
    partial class Account_Details_Form
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
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label_ID = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txt_UserId = new System.Windows.Forms.TextBox();
            txt_AccountId = new System.Windows.Forms.TextBox();
            txt_AcctType = new System.Windows.Forms.TextBox();
            txt_CurBal = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            Btn_TransH = new System.Windows.Forms.Button();
            Btn_Cancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(282, 306);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(250, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label_ID.Location = new System.Drawing.Point(83, 39);
            label_ID.Name = "label_ID";
            label_ID.Size = new System.Drawing.Size(86, 28);
            label_ID.TabIndex = 1;
            label_ID.Text = "User ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(83, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 28);
            label2.TabIndex = 2;
            label2.Text = "Account ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(83, 306);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(141, 28);
            label3.TabIndex = 3;
            label3.Text = "Date Created:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(83, 161);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(146, 28);
            label4.TabIndex = 4;
            label4.Text = "Account Type:";
            // 
            // txt_UserId
            // 
            txt_UserId.Location = new System.Drawing.Point(295, 36);
            txt_UserId.Name = "txt_UserId";
            txt_UserId.ReadOnly = true;
            txt_UserId.Size = new System.Drawing.Size(237, 31);
            txt_UserId.TabIndex = 5;
            // 
            // txt_AccountId
            // 
            txt_AccountId.Location = new System.Drawing.Point(295, 103);
            txt_AccountId.Name = "txt_AccountId";
            txt_AccountId.ReadOnly = true;
            txt_AccountId.Size = new System.Drawing.Size(237, 31);
            txt_AccountId.TabIndex = 6;
            // 
            // txt_AcctType
            // 
            txt_AcctType.Location = new System.Drawing.Point(295, 158);
            txt_AcctType.Name = "txt_AcctType";
            txt_AcctType.ReadOnly = true;
            txt_AcctType.Size = new System.Drawing.Size(237, 31);
            txt_AcctType.TabIndex = 7;
            // 
            // txt_CurBal
            // 
            txt_CurBal.Location = new System.Drawing.Point(295, 228);
            txt_CurBal.Name = "txt_CurBal";
            txt_CurBal.ReadOnly = true;
            txt_CurBal.Size = new System.Drawing.Size(237, 31);
            txt_CurBal.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(83, 231);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(168, 28);
            label1.TabIndex = 8;
            label1.Text = "Current Balance:";
            // 
            // Btn_TransH
            // 
            Btn_TransH.Location = new System.Drawing.Point(573, 97);
            Btn_TransH.Name = "Btn_TransH";
            Btn_TransH.Size = new System.Drawing.Size(206, 42);
            Btn_TransH.TabIndex = 10;
            Btn_TransH.Text = "Transaction History";
            Btn_TransH.UseVisualStyleBackColor = true;
            Btn_TransH.Click += Btn_TransH_Click;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Location = new System.Drawing.Point(608, 199);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new System.Drawing.Size(136, 42);
            Btn_Cancel.TabIndex = 11;
            Btn_Cancel.Text = "Cancel";
            Btn_Cancel.UseVisualStyleBackColor = true;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // Account_Details_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_TransH);
            Controls.Add(txt_CurBal);
            Controls.Add(label1);
            Controls.Add(txt_AcctType);
            Controls.Add(txt_AccountId);
            Controls.Add(txt_UserId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label_ID);
            Controls.Add(dateTimePicker1);
            Name = "Account_Details_Form";
            Text = "Account Details";
            Load += Account_Details_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UserId;
        private System.Windows.Forms.TextBox txt_AccountId;
        private System.Windows.Forms.TextBox txt_AcctType;
        private System.Windows.Forms.TextBox txt_CurBal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_TransH;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}