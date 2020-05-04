namespace BankomatClient.Views
{
    partial class CardOperationsView
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
            this.buttonChangePin = new System.Windows.Forms.Button();
            this.buttonBlockCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPersonalArea
            // 
            this.buttonPersonalArea.Location = new System.Drawing.Point(583, 217);
            this.buttonPersonalArea.Size = new System.Drawing.Size(229, 29);
            // 
            // labelBalance
            // 
            this.labelBalance.Location = new System.Drawing.Point(615, 197);
            // 
            // buttonChangePin
            // 
            this.buttonChangePin.Location = new System.Drawing.Point(191, 310);
            this.buttonChangePin.Name = "buttonChangePin";
            this.buttonChangePin.Size = new System.Drawing.Size(259, 39);
            this.buttonChangePin.TabIndex = 6;
            this.buttonChangePin.Text = "Сменить пин текущей карты";
            this.buttonChangePin.UseVisualStyleBackColor = true;
            this.buttonChangePin.Click += new System.EventHandler(this.buttonChangePin_Click);
            // 
            // buttonBlockCard
            // 
            this.buttonBlockCard.Location = new System.Drawing.Point(191, 367);
            this.buttonBlockCard.Name = "buttonBlockCard";
            this.buttonBlockCard.Size = new System.Drawing.Size(259, 39);
            this.buttonBlockCard.TabIndex = 6;
            this.buttonBlockCard.Text = "Заблокировать текущую карту";
            this.buttonBlockCard.UseVisualStyleBackColor = true;
            this.buttonBlockCard.Click += new System.EventHandler(this.buttonBlockCard_Click);
            // 
            // CardOperationsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBlockCard);
            this.Controls.Add(this.buttonChangePin);
            this.Name = "CardOperationsView";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonToStartPage, 0);
            this.Controls.SetChildIndex(this.labelDetails, 0);
            this.Controls.SetChildIndex(this.labelBalance, 0);
            this.Controls.SetChildIndex(this.labelPageName, 0);
            this.Controls.SetChildIndex(this.labelInstructions, 0);
            this.Controls.SetChildIndex(this.labelNotifyMessage, 0);
            this.Controls.SetChildIndex(this.buttonPersonalArea, 0);
            this.Controls.SetChildIndex(this.buttonChangePin, 0);
            this.Controls.SetChildIndex(this.buttonBlockCard, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangePin;
        private System.Windows.Forms.Button buttonBlockCard;
    }
}
