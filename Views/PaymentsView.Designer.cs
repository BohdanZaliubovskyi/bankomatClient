namespace BankomatClient.Views
{
    partial class PaymentsView
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
            this.buttonCharity = new System.Windows.Forms.Button();
            this.buttonFillMobile = new System.Windows.Forms.Button();
            this.buttonSendToOtherCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPersonalArea
            // 
            this.buttonPersonalArea.Location = new System.Drawing.Point(584, 217);
            this.buttonPersonalArea.Size = new System.Drawing.Size(228, 29);
            // 
            // labelBalance
            // 
            this.labelBalance.Location = new System.Drawing.Point(615, 197);
            // 
            // buttonCharity
            // 
            this.buttonCharity.Location = new System.Drawing.Point(210, 286);
            this.buttonCharity.Name = "buttonCharity";
            this.buttonCharity.Size = new System.Drawing.Size(216, 45);
            this.buttonCharity.TabIndex = 6;
            this.buttonCharity.Text = "Благотворительность";
            this.buttonCharity.UseVisualStyleBackColor = true;
            this.buttonCharity.Click += new System.EventHandler(this.buttonCharity_Click);
            // 
            // buttonFillMobile
            // 
            this.buttonFillMobile.Location = new System.Drawing.Point(210, 337);
            this.buttonFillMobile.Name = "buttonFillMobile";
            this.buttonFillMobile.Size = new System.Drawing.Size(216, 46);
            this.buttonFillMobile.TabIndex = 6;
            this.buttonFillMobile.Text = "Пополнить мобильный";
            this.buttonFillMobile.UseVisualStyleBackColor = true;
            this.buttonFillMobile.Click += new System.EventHandler(this.buttonFillMobile_Click);
            // 
            // buttonSendToOtherCard
            // 
            this.buttonSendToOtherCard.Location = new System.Drawing.Point(210, 389);
            this.buttonSendToOtherCard.Name = "buttonSendToOtherCard";
            this.buttonSendToOtherCard.Size = new System.Drawing.Size(216, 49);
            this.buttonSendToOtherCard.TabIndex = 6;
            this.buttonSendToOtherCard.Text = "Перевести на другую карту";
            this.buttonSendToOtherCard.UseVisualStyleBackColor = true;
            this.buttonSendToOtherCard.Click += new System.EventHandler(this.buttonSendToOtherCard_Click);
            // 
            // PaymentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSendToOtherCard);
            this.Controls.Add(this.buttonFillMobile);
            this.Controls.Add(this.buttonCharity);
            this.Name = "PaymentsView";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonToStartPage, 0);
            this.Controls.SetChildIndex(this.labelDetails, 0);
            this.Controls.SetChildIndex(this.labelBalance, 0);
            this.Controls.SetChildIndex(this.labelPageName, 0);
            this.Controls.SetChildIndex(this.labelInstructions, 0);
            this.Controls.SetChildIndex(this.labelNotifyMessage, 0);
            this.Controls.SetChildIndex(this.buttonPersonalArea, 0);
            this.Controls.SetChildIndex(this.buttonCharity, 0);
            this.Controls.SetChildIndex(this.buttonFillMobile, 0);
            this.Controls.SetChildIndex(this.buttonSendToOtherCard, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCharity;
        private System.Windows.Forms.Button buttonFillMobile;
        private System.Windows.Forms.Button buttonSendToOtherCard;
    }
}
