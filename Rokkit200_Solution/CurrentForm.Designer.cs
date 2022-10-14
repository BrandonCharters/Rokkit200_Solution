namespace Rokkit200_Solution
{
    partial class CurrentForm
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
            this.currentBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.withdrawTxt = new System.Windows.Forms.TextBox();
            this.depositTxt = new System.Windows.Forms.TextBox();
            this.currentDepositBtn = new System.Windows.Forms.Button();
            this.currentWithdrawBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.withdrawErrorLbl = new System.Windows.Forms.Label();
            this.depositErrorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance is as follows:";
            // 
            // currentBalance
            // 
            this.currentBalance.AutoSize = true;
            this.currentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBalance.ForeColor = System.Drawing.Color.SteelBlue;
            this.currentBalance.Location = new System.Drawing.Point(239, 87);
            this.currentBalance.Name = "currentBalance";
            this.currentBalance.Size = new System.Drawing.Size(80, 18);
            this.currentBalance.TabIndex = 3;
            this.currentBalance.Text = "*balance*";
            this.currentBalance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.currentBalance.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "How much would you like to deposit?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "How much would you like to withdraw?";
            // 
            // withdrawTxt
            // 
            this.withdrawTxt.Location = new System.Drawing.Point(203, 166);
            this.withdrawTxt.Name = "withdrawTxt";
            this.withdrawTxt.Size = new System.Drawing.Size(151, 20);
            this.withdrawTxt.TabIndex = 8;
            // 
            // depositTxt
            // 
            this.depositTxt.Location = new System.Drawing.Point(203, 286);
            this.depositTxt.Name = "depositTxt";
            this.depositTxt.Size = new System.Drawing.Size(151, 20);
            this.depositTxt.TabIndex = 9;
            // 
            // currentDepositBtn
            // 
            this.currentDepositBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDepositBtn.Location = new System.Drawing.Point(506, 266);
            this.currentDepositBtn.Name = "currentDepositBtn";
            this.currentDepositBtn.Size = new System.Drawing.Size(93, 40);
            this.currentDepositBtn.TabIndex = 10;
            this.currentDepositBtn.Text = "deposit";
            this.currentDepositBtn.UseVisualStyleBackColor = true;
            this.currentDepositBtn.Click += new System.EventHandler(this.currentDepositBtn_Click);
            // 
            // currentWithdrawBtn
            // 
            this.currentWithdrawBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWithdrawBtn.Location = new System.Drawing.Point(506, 146);
            this.currentWithdrawBtn.Name = "currentWithdrawBtn";
            this.currentWithdrawBtn.Size = new System.Drawing.Size(93, 40);
            this.currentWithdrawBtn.TabIndex = 11;
            this.currentWithdrawBtn.Text = "withdraw";
            this.currentWithdrawBtn.UseVisualStyleBackColor = true;
            this.currentWithdrawBtn.Click += new System.EventHandler(this.currentWithdrawBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(34, 389);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(88, 33);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Current Account Page";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(700, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(88, 33);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // withdrawErrorLbl
            // 
            this.withdrawErrorLbl.AutoSize = true;
            this.withdrawErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.withdrawErrorLbl.Location = new System.Drawing.Point(200, 189);
            this.withdrawErrorLbl.Name = "withdrawErrorLbl";
            this.withdrawErrorLbl.Size = new System.Drawing.Size(85, 13);
            this.withdrawErrorLbl.TabIndex = 20;
            this.withdrawErrorLbl.Text = "withdrawErrorLbl";
            this.withdrawErrorLbl.Visible = false;
            // 
            // depositErrorLbl
            // 
            this.depositErrorLbl.AutoSize = true;
            this.depositErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.depositErrorLbl.Location = new System.Drawing.Point(200, 309);
            this.depositErrorLbl.Name = "depositErrorLbl";
            this.depositErrorLbl.Size = new System.Drawing.Size(77, 13);
            this.depositErrorLbl.TabIndex = 21;
            this.depositErrorLbl.Text = "depositErrorLbl";
            this.depositErrorLbl.Visible = false;
            // 
            // CurrentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depositErrorLbl);
            this.Controls.Add(this.withdrawErrorLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.currentWithdrawBtn);
            this.Controls.Add(this.currentDepositBtn);
            this.Controls.Add(this.depositTxt);
            this.Controls.Add(this.withdrawTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentBalance);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CurrentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Account Page";
            this.Load += new System.EventHandler(this.CurrentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox withdrawTxt;
        private System.Windows.Forms.TextBox depositTxt;
        private System.Windows.Forms.Button currentDepositBtn;
        private System.Windows.Forms.Button currentWithdrawBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label withdrawErrorLbl;
        private System.Windows.Forms.Label depositErrorLbl;
    }
}