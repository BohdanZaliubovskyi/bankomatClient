namespace BankomatClient.Views
{
    partial class BlockCardView
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
            this.buttonBlockCard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPersonalArea
            // 
            this.buttonPersonalArea.Location = new System.Drawing.Point(579, 217);
            this.buttonPersonalArea.Size = new System.Drawing.Size(233, 29);
            // 
            // labelBalance
            // 
            this.labelBalance.Location = new System.Drawing.Point(604, 197);
            // 
            // buttonBlockCard
            // 
            this.buttonBlockCard.Location = new System.Drawing.Point(380, 379);
            this.buttonBlockCard.Name = "buttonBlockCard";
            this.buttonBlockCard.Size = new System.Drawing.Size(223, 38);
            this.buttonBlockCard.TabIndex = 6;
            this.buttonBlockCard.Text = "Заблокировать карту";
            this.buttonBlockCard.UseVisualStyleBackColor = true;
            this.buttonBlockCard.Click += new System.EventHandler(this.buttonBlockCard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Внимание! После нажатия кнопки ниже, карта будет заблокирована.";
            // 
            // BlockCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBlockCard);
            this.Name = "BlockCardView";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonToStartPage, 0);
            this.Controls.SetChildIndex(this.labelDetails, 0);
            this.Controls.SetChildIndex(this.labelBalance, 0);
            this.Controls.SetChildIndex(this.labelPageName, 0);
            this.Controls.SetChildIndex(this.labelInstructions, 0);
            this.Controls.SetChildIndex(this.labelNotifyMessage, 0);
            this.Controls.SetChildIndex(this.buttonPersonalArea, 0);
            this.Controls.SetChildIndex(this.buttonBlockCard, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBlockCard;
        private System.Windows.Forms.Label label2;
    }
}
