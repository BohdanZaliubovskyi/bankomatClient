namespace BankomatClient.Views
{
    partial class PersonalAreaView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPayments = new System.Windows.Forms.Button();
            this.buttonFillCard = new System.Windows.Forms.Button();
            this.buttonGetMoney = new System.Windows.Forms.Button();
            this.buttonCardOperations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPersonalArea
            // 
            this.buttonPersonalArea.Location = new System.Drawing.Point(586, 217);
            this.buttonPersonalArea.Size = new System.Drawing.Size(226, 29);
            // 
            // labelBalance
            // 
            this.labelBalance.Location = new System.Drawing.Point(622, 197);
            // 
            // buttonPayments
            // 
            this.buttonPayments.Location = new System.Drawing.Point(205, 418);
            this.buttonPayments.Name = "buttonPayments";
            this.buttonPayments.Size = new System.Drawing.Size(238, 40);
            this.buttonPayments.TabIndex = 5;
            this.buttonPayments.Text = "Платежи";
            this.buttonPayments.UseVisualStyleBackColor = true;
            this.buttonPayments.Click += new System.EventHandler(this.buttonPayments_Click);
            // 
            // buttonFillCard
            // 
            this.buttonFillCard.Location = new System.Drawing.Point(205, 372);
            this.buttonFillCard.Name = "buttonFillCard";
            this.buttonFillCard.Size = new System.Drawing.Size(238, 40);
            this.buttonFillCard.TabIndex = 5;
            this.buttonFillCard.Text = "Пополнить карту";
            this.buttonFillCard.UseVisualStyleBackColor = true;
            this.buttonFillCard.Click += new System.EventHandler(this.buttonFillCard_Click);
            // 
            // buttonGetMoney
            // 
            this.buttonGetMoney.Location = new System.Drawing.Point(205, 326);
            this.buttonGetMoney.Name = "buttonGetMoney";
            this.buttonGetMoney.Size = new System.Drawing.Size(238, 40);
            this.buttonGetMoney.TabIndex = 5;
            this.buttonGetMoney.Text = "Снять деньги";
            this.buttonGetMoney.UseVisualStyleBackColor = true;
            this.buttonGetMoney.Click += new System.EventHandler(this.buttonGetMoney_Click);
            // 
            // buttonCardOperations
            // 
            this.buttonCardOperations.Location = new System.Drawing.Point(205, 280);
            this.buttonCardOperations.Name = "buttonCardOperations";
            this.buttonCardOperations.Size = new System.Drawing.Size(238, 40);
            this.buttonCardOperations.TabIndex = 5;
            this.buttonCardOperations.Text = "Операции с картой";
            this.buttonCardOperations.UseVisualStyleBackColor = true;
            this.buttonCardOperations.Click += new System.EventHandler(this.buttonCardOperations_Click);
            // 
            // PersonalAreaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCardOperations);
            this.Controls.Add(this.buttonGetMoney);
            this.Controls.Add(this.buttonFillCard);
            this.Controls.Add(this.buttonPayments);
            this.Name = "PersonalAreaView";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonToStartPage, 0);
            this.Controls.SetChildIndex(this.labelDetails, 0);
            this.Controls.SetChildIndex(this.buttonPersonalArea, 0);
            this.Controls.SetChildIndex(this.labelBalance, 0);
            this.Controls.SetChildIndex(this.labelPageName, 0);
            this.Controls.SetChildIndex(this.labelInstructions, 0);
            this.Controls.SetChildIndex(this.labelNotifyMessage, 0);
            this.Controls.SetChildIndex(this.buttonPayments, 0);
            this.Controls.SetChildIndex(this.buttonFillCard, 0);
            this.Controls.SetChildIndex(this.buttonGetMoney, 0);
            this.Controls.SetChildIndex(this.buttonCardOperations, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPayments;
        private System.Windows.Forms.Button buttonFillCard;
        private System.Windows.Forms.Button buttonGetMoney;
        private System.Windows.Forms.Button buttonCardOperations;
    }
}
