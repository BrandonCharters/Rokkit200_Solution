namespace Rokkit200_Solution
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
            this.label1 = new System.Windows.Forms.Label();
            this.currentAccountPage = new System.Windows.Forms.Button();
            this.SavingsAccountPage = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.user1Radio = new System.Windows.Forms.RadioButton();
            this.user2Radio = new System.Windows.Forms.RadioButton();
            this.userErrorLbl = new System.Windows.Forms.Label();
            this.userErrorLbls = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Would you like to view your savings or current account?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentAccountPage
            // 
            this.currentAccountPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAccountPage.Location = new System.Drawing.Point(177, 325);
            this.currentAccountPage.Name = "currentAccountPage";
            this.currentAccountPage.Size = new System.Drawing.Size(160, 52);
            this.currentAccountPage.TabIndex = 1;
            this.currentAccountPage.Text = "Current Account";
            this.currentAccountPage.UseVisualStyleBackColor = true;
            this.currentAccountPage.Click += new System.EventHandler(this.currentAccountPage_Click);
            // 
            // SavingsAccountPage
            // 
            this.SavingsAccountPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsAccountPage.Location = new System.Drawing.Point(463, 325);
            this.SavingsAccountPage.Name = "SavingsAccountPage";
            this.SavingsAccountPage.Size = new System.Drawing.Size(160, 52);
            this.SavingsAccountPage.TabIndex = 2;
            this.SavingsAccountPage.Text = "Savings Account";
            this.SavingsAccountPage.UseVisualStyleBackColor = true;
            this.SavingsAccountPage.Click += new System.EventHandler(this.SavingsAccountPage_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "What user would you like to login as?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // user1Radio
            // 
            this.user1Radio.AutoSize = true;
            this.user1Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user1Radio.Location = new System.Drawing.Point(355, 137);
            this.user1Radio.Name = "user1Radio";
            this.user1Radio.Size = new System.Drawing.Size(76, 22);
            this.user1Radio.TabIndex = 18;
            this.user1Radio.TabStop = true;
            this.user1Radio.Text = "User 1";
            this.user1Radio.UseVisualStyleBackColor = true;
            // 
            // user2Radio
            // 
            this.user2Radio.AutoSize = true;
            this.user2Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user2Radio.Location = new System.Drawing.Point(355, 183);
            this.user2Radio.Name = "user2Radio";
            this.user2Radio.Size = new System.Drawing.Size(76, 22);
            this.user2Radio.TabIndex = 19;
            this.user2Radio.TabStop = true;
            this.user2Radio.Text = "User 2";
            this.user2Radio.UseVisualStyleBackColor = true;
            // 
            // userErrorLbl
            // 
            this.userErrorLbl.AutoSize = true;
            this.userErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.userErrorLbl.Location = new System.Drawing.Point(437, 159);
            this.userErrorLbl.Name = "userErrorLbl";
            this.userErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.userErrorLbl.TabIndex = 20;
            this.userErrorLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userErrorLbls
            // 
            this.userErrorLbls.AutoSize = true;
            this.userErrorLbls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userErrorLbls.ForeColor = System.Drawing.Color.Red;
            this.userErrorLbls.Location = new System.Drawing.Point(443, 164);
            this.userErrorLbls.Name = "userErrorLbls";
            this.userErrorLbls.Size = new System.Drawing.Size(41, 15);
            this.userErrorLbls.TabIndex = 21;
            this.userErrorLbls.Text = "label3";
            this.userErrorLbls.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userErrorLbls);
            this.Controls.Add(this.userErrorLbl);
            this.Controls.Add(this.user2Radio);
            this.Controls.Add(this.user1Radio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.SavingsAccountPage);
            this.Controls.Add(this.currentAccountPage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button currentAccountPage;
        private System.Windows.Forms.Button SavingsAccountPage;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton user1Radio;
        private System.Windows.Forms.RadioButton user2Radio;
        private System.Windows.Forms.Label userErrorLbl;
        private System.Windows.Forms.Label userErrorLbls;
    }
}

