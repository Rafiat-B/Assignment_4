namespace Ass_4
{
    partial class TransactionForm
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
            txt_Amount = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            dateTimePicker_TR = new System.Windows.Forms.DateTimePicker();
            txt_Desc = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txt_AcctId2 = new System.Windows.Forms.TextBox();
            txt_transId = new System.Windows.Forms.TextBox();
            label_AcctId = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btn_Ex = new System.Windows.Forms.Button();
            btn_AddTrans = new System.Windows.Forms.Button();
            btn_UpdateTrans = new System.Windows.Forms.Button();
            btn_DelTrans = new System.Windows.Forms.Button();
            dvgTransH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgTransH).BeginInit();
            SuspendLayout();
            // 
            // txt_Amount
            // 
            txt_Amount.Location = new System.Drawing.Point(1003, 25);
            txt_Amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Amount.Name = "txt_Amount";
            txt_Amount.Size = new System.Drawing.Size(152, 31);
            txt_Amount.TabIndex = 99;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(850, 28);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(93, 25);
            label5.TabIndex = 98;
            label5.Text = "Amount:";
            // 
            // dateTimePicker_TR
            // 
            dateTimePicker_TR.Location = new System.Drawing.Point(265, 78);
            dateTimePicker_TR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePicker_TR.Name = "dateTimePicker_TR";
            dateTimePicker_TR.Size = new System.Drawing.Size(213, 31);
            dateTimePicker_TR.TabIndex = 97;
            // 
            // txt_Desc
            // 
            txt_Desc.Location = new System.Drawing.Point(781, 81);
            txt_Desc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_Desc.Name = "txt_Desc";
            txt_Desc.Size = new System.Drawing.Size(182, 31);
            txt_Desc.TabIndex = 96;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(622, 84);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 25);
            label1.TabIndex = 95;
            label1.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(75, 87);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(184, 25);
            label2.TabIndex = 94;
            label2.Text = "Transaction Date:";
            // 
            // txt_AcctId2
            // 
            txt_AcctId2.Location = new System.Drawing.Point(184, 19);
            txt_AcctId2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_AcctId2.Name = "txt_AcctId2";
            txt_AcctId2.Size = new System.Drawing.Size(152, 31);
            txt_AcctId2.TabIndex = 93;
            // 
            // txt_transId
            // 
            txt_transId.Location = new System.Drawing.Point(616, 22);
            txt_transId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_transId.Name = "txt_transId";
            txt_transId.Size = new System.Drawing.Size(125, 31);
            txt_transId.TabIndex = 92;
            // 
            // label_AcctId
            // 
            label_AcctId.AutoSize = true;
            label_AcctId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label_AcctId.Location = new System.Drawing.Point(25, 25);
            label_AcctId.Name = "label_AcctId";
            label_AcctId.Size = new System.Drawing.Size(125, 25);
            label_AcctId.TabIndex = 91;
            label_AcctId.Text = "Account ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(444, 25);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(166, 25);
            label4.TabIndex = 90;
            label4.Text = "Transacttion ID:";
            // 
            // btn_Ex
            // 
            btn_Ex.Location = new System.Drawing.Point(882, 483);
            btn_Ex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Ex.Name = "btn_Ex";
            btn_Ex.Size = new System.Drawing.Size(147, 48);
            btn_Ex.TabIndex = 89;
            btn_Ex.Text = "Exit";
            btn_Ex.UseVisualStyleBackColor = true;
            btn_Ex.Click += btn_Ex_Click;
            // 
            // btn_AddTrans
            // 
            btn_AddTrans.Location = new System.Drawing.Point(72, 483);
            btn_AddTrans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_AddTrans.Name = "btn_AddTrans";
            btn_AddTrans.Size = new System.Drawing.Size(147, 48);
            btn_AddTrans.TabIndex = 86;
            btn_AddTrans.Text = "Add";
            btn_AddTrans.UseVisualStyleBackColor = true;
            btn_AddTrans.Click += btn_AddTrans_Click;
            // 
            // btn_UpdateTrans
            // 
            btn_UpdateTrans.Location = new System.Drawing.Point(279, 483);
            btn_UpdateTrans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_UpdateTrans.Name = "btn_UpdateTrans";
            btn_UpdateTrans.Size = new System.Drawing.Size(147, 48);
            btn_UpdateTrans.TabIndex = 87;
            btn_UpdateTrans.Text = "Update";
            btn_UpdateTrans.UseVisualStyleBackColor = true;
            btn_UpdateTrans.Click += btn_UpdateTrans_Click;
            // 
            // btn_DelTrans
            // 
            btn_DelTrans.Location = new System.Drawing.Point(511, 483);
            btn_DelTrans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_DelTrans.Name = "btn_DelTrans";
            btn_DelTrans.Size = new System.Drawing.Size(147, 48);
            btn_DelTrans.TabIndex = 88;
            btn_DelTrans.Text = "Delete";
            btn_DelTrans.UseVisualStyleBackColor = true;
            btn_DelTrans.Click += btn_DelTrans_Click;
            // 
            // dvgTransH
            // 
            dvgTransH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dvgTransH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTransH.Location = new System.Drawing.Point(136, 134);
            dvgTransH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dvgTransH.Name = "dvgTransH";
            dvgTransH.RowHeadersWidth = 62;
            dvgTransH.RowTemplate.Height = 28;
            dvgTransH.Size = new System.Drawing.Size(816, 320);
            dvgTransH.TabIndex = 85;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1177, 557);
            Controls.Add(txt_Amount);
            Controls.Add(label5);
            Controls.Add(dateTimePicker_TR);
            Controls.Add(txt_Desc);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txt_AcctId2);
            Controls.Add(txt_transId);
            Controls.Add(label_AcctId);
            Controls.Add(label4);
            Controls.Add(btn_Ex);
            Controls.Add(btn_AddTrans);
            Controls.Add(btn_UpdateTrans);
            Controls.Add(btn_DelTrans);
            Controls.Add(dvgTransH);
            Name = "TransactionForm";
            Text = "Transaction Form";
            Load += TransactionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvgTransH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TR;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_AcctId2;
        private System.Windows.Forms.TextBox txt_transId;
        private System.Windows.Forms.Label label_AcctId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Ex;
        private System.Windows.Forms.Button btn_AddTrans;
        private System.Windows.Forms.Button btn_UpdateTrans;
        private System.Windows.Forms.Button btn_DelTrans;
        private System.Windows.Forms.DataGridView dvgTransH;
    }
}