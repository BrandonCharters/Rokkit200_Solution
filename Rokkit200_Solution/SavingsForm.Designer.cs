namespace Rokkit200_Solution
{
    partial class SavingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.currentBalancelbl = new System.Windows.Forms.Label();
            this.withdrawTxt = new System.Windows.Forms.TextBox();
            this.depositTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.savingsWithdrawBtn = new System.Windows.Forms.Button();
            this.savingsDepositBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.withdrawErrorLbl = new System.Windows.Forms.Label();
            this.depositErrorLbl = new System.Windows.Forms.Label();
            this.withdrawErrorsLbl = new System.Windows.Forms.Label();
            this.depositApprovedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balance is as follows:";
            // 
            // currentBalancelbl
            // 
            this.currentBalancelbl.AutoSize = true;
            this.currentBalancelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBalancelbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.currentBalancelbl.Location = new System.Drawing.Point(365, 85);
            this.currentBalancelbl.Name = "currentBalancelbl";
            this.currentBalancelbl.Size = new System.Drawing.Size(80, 18);
            this.currentBalancelbl.TabIndex = 2;
            this.currentBalancelbl.Text = "*balance*";
            this.currentBalancelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.currentBalancelbl.Visible = false;
            // 
            // withdrawTxt
            // 
            this.withdrawTxt.Location = new System.Drawing.Point(189, 185);
            this.withdrawTxt.Name = "withdrawTxt";
            this.withdrawTxt.Size = new System.Drawing.Size(151, 20);
            this.withdrawTxt.TabIndex = 3;
            // 
            // depositTxt
            // 
            this.depositTxt.Location = new System.Drawing.Point(189, 273);
            this.depositTxt.Name = "depositTxt";
            this.depositTxt.Size = new System.Drawing.Size(151, 20);
            this.depositTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "How much would you like to withdraw?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "How much would you like to deposit?";
            // 
            // savingsWithdrawBtn
            // 
            this.savingsWithdrawBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsWithdrawBtn.Location = new System.Drawing.Point(492, 165);
            this.savingsWithdrawBtn.Name = "savingsWithdrawBtn";
            this.savingsWithdrawBtn.Size = new System.Drawing.Size(93, 40);
            this.savingsWithdrawBtn.TabIndex = 7;
            this.savingsWithdrawBtn.Text = "withdraw";
            this.savingsWithdrawBtn.UseVisualStyleBackColor = true;
            this.savingsWithdrawBtn.Click += new System.EventHandler(this.savingsWithdrawBtn_Click);
            // 
            // savingsDepositBtn
            // 
            this.savingsDepositBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingsDepositBtn.Location = new System.Drawing.Point(492, 253);
            this.savingsDepositBtn.Name = "savingsDepositBtn";
            this.savingsDepositBtn.Size = new System.Drawing.Size(93, 40);
            this.savingsDepositBtn.TabIndex = 8;
            this.savingsDepositBtn.Text = "deposit";
            this.savingsDepositBtn.UseVisualStyleBackColor = true;
            this.savingsDepositBtn.Click += new System.EventHandler(this.savingsDepositBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(59, 378);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(88, 33);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Savings Account Page";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(700, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(88, 33);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // withdrawErrorLbl
            // 
            this.withdrawErrorLbl.AutoSize = true;
            this.withdrawErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.withdrawErrorLbl.Location = new System.Drawing.Point(346, 188);
            this.withdrawErrorLbl.Name = "withdrawErrorLbl";
            this.withdrawErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.withdrawErrorLbl.TabIndex = 16;
            // 
            // depositErrorLbl
            // 
            this.depositErrorLbl.AutoSize = true;
            this.depositErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.depositErrorLbl.Location = new System.Drawing.Point(189, 296);
            this.depositErrorLbl.Name = "depositErrorLbl";
            this.depositErrorLbl.Size = new System.Drawing.Size(77, 13);
            this.depositErrorLbl.TabIndex = 17;
            this.depositErrorLbl.Text = "depositErrorLbl";
            this.depositErrorLbl.Visible = false;
            // 
            // withdrawErrorsLbl
            // 
            this.withdrawErrorsLbl.AutoSize = true;
            this.withdrawErrorsLbl.ForeColor = System.Drawing.Color.Red;
            this.withdrawErrorsLbl.Location = new System.Drawing.Point(189, 208);
            this.withdrawErrorsLbl.Name = "withdrawErrorsLbl";
            this.withdrawErrorsLbl.Size = new System.Drawing.Size(90, 13);
            this.withdrawErrorsLbl.TabIndex = 18;
            this.withdrawErrorsLbl.Text = "withdrawErrorsLbl";
            this.withdrawErrorsLbl.Visible = false;
            // 
            // depositApprovedLbl
            // 
            this.depositApprovedLbl.AutoSize = true;
            this.depositApprovedLbl.ForeColor = System.Drawing.Color.Green;
            this.depositApprovedLbl.Location = new System.Drawing.Point(365, 113);
            this.depositApprovedLbl.Name = "depositApprovedLbl";
            this.depositApprovedLbl.Size = new System.Drawing.Size(101, 13);
            this.depositApprovedLbl.TabIndex = 19;
            this.depositApprovedLbl.Text = "depositApprovedLbl";
            this.depositApprovedLbl.Visible = false;
            // 
            // SavingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depositApprovedLbl);
            this.Controls.Add(this.withdrawErrorsLbl);
            this.Controls.Add(this.depositErrorLbl);
            this.Controls.Add(this.withdrawErrorLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.savingsDepositBtn);
            this.Controls.Add(this.savingsWithdrawBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depositTxt);
            this.Controls.Add(this.withdrawTxt);
            this.Controls.Add(this.currentBalancelbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SavingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings Account Page";
            this.Load += new System.EventHandler(this.SavingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentBalancelbl;
        private System.Windows.Forms.TextBox withdrawTxt;
        private System.Windows.Forms.TextBox depositTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button savingsWithdrawBtn;
        private System.Windows.Forms.Button savingsDepositBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label withdrawErrorLbl;
        private System.Windows.Forms.Label depositErrorLbl;
        private System.Windows.Forms.Label withdrawErrorsLbl;
        private System.Windows.Forms.Label depositApprovedLbl;
    }
}