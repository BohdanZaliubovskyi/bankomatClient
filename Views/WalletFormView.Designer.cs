namespace BankomatClient.Views
{
    partial class WalletFormView
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
            this.pictureBoxFullCard = new System.Windows.Forms.PictureBox();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.labelBank = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelHolderName = new System.Windows.Forms.Label();
            this.buttonCloseWallet = new System.Windows.Forms.Button();
            this.buttonPutCard = new System.Windows.Forms.Button();
            this.pictureBoxWallet = new System.Windows.Forms.PictureBox();
            this.panelCardsItems = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFullCard
            // 
            this.pictureBoxFullCard.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFullCard.BackgroundImage = global::BankomatClient.Properties.Resources.BlackCard;
            this.pictureBoxFullCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFullCard.Location = new System.Drawing.Point(76, 459);
            this.pictureBoxFullCard.Name = "pictureBoxFullCard";
            this.pictureBoxFullCard.Size = new System.Drawing.Size(419, 247);
            this.pictureBoxFullCard.TabIndex = 2;
            this.pictureBoxFullCard.TabStop = false;
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.BackColor = System.Drawing.Color.LightGray;
            this.labelCardNumber.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNumber.Location = new System.Drawing.Point(107, 600);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(317, 38);
            this.labelCardNumber.TabIndex = 3;
            this.labelCardNumber.Text = "1111   1111   1111    1111";
            // 
            // labelBank
            // 
            this.labelBank.AutoSize = true;
            this.labelBank.BackColor = System.Drawing.Color.LightGray;
            this.labelBank.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelBank.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBank.Location = new System.Drawing.Point(166, 481);
            this.labelBank.Name = "labelBank";
            this.labelBank.Size = new System.Drawing.Size(129, 26);
            this.labelBank.TabIndex = 4;
            this.labelBank.Text = "TrustBank";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.LightGray;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(285, 647);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(49, 17);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "01/15";
            // 
            // labelHolderName
            // 
            this.labelHolderName.AutoSize = true;
            this.labelHolderName.BackColor = System.Drawing.Color.LightGray;
            this.labelHolderName.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHolderName.Location = new System.Drawing.Point(111, 675);
            this.labelHolderName.Name = "labelHolderName";
            this.labelHolderName.Size = new System.Drawing.Size(94, 18);
            this.labelHolderName.TabIndex = 6;
            this.labelHolderName.Text = "Holder Name";
            // 
            // buttonCloseWallet
            // 
            this.buttonCloseWallet.Location = new System.Drawing.Point(173, 356);
            this.buttonCloseWallet.Name = "buttonCloseWallet";
            this.buttonCloseWallet.Size = new System.Drawing.Size(273, 35);
            this.buttonCloseWallet.TabIndex = 7;
            this.buttonCloseWallet.Text = "Спрятать кошелек обратно в карман";
            this.buttonCloseWallet.UseVisualStyleBackColor = true;
            this.buttonCloseWallet.Click += new System.EventHandler(this.buttonCloseWallet_Click);
            // 
            // buttonPutCard
            // 
            this.buttonPutCard.Location = new System.Drawing.Point(114, 712);
            this.buttonPutCard.Name = "buttonPutCard";
            this.buttonPutCard.Size = new System.Drawing.Size(332, 26);
            this.buttonPutCard.TabIndex = 8;
            this.buttonPutCard.Text = "Вставить в банкомат эту карту";
            this.buttonPutCard.UseVisualStyleBackColor = true;
            this.buttonPutCard.Click += new System.EventHandler(this.buttonPutCard_Click);
            // 
            // pictureBoxWallet
            // 
            this.pictureBoxWallet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWallet.BackgroundImage = global::BankomatClient.Properties.Resources.wallet;
            this.pictureBoxWallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWallet.Location = new System.Drawing.Point(44, 12);
            this.pictureBoxWallet.Name = "pictureBoxWallet";
            this.pictureBoxWallet.Size = new System.Drawing.Size(587, 326);
            this.pictureBoxWallet.TabIndex = 1;
            this.pictureBoxWallet.TabStop = false;
            // 
            // panelCardsItems
            // 
            this.panelCardsItems.AutoScroll = true;
            this.panelCardsItems.BackColor = System.Drawing.Color.Transparent;
            this.panelCardsItems.Location = new System.Drawing.Point(74, 108);
            this.panelCardsItems.Name = "panelCardsItems";
            this.panelCardsItems.Size = new System.Drawing.Size(421, 134);
            this.panelCardsItems.TabIndex = 11;
            // 
            // WalletFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(728, 754);
            this.ControlBox = false;
            this.Controls.Add(this.panelCardsItems);
            this.Controls.Add(this.pictureBoxWallet);
            this.Controls.Add(this.buttonPutCard);
            this.Controls.Add(this.buttonCloseWallet);
            this.Controls.Add(this.labelHolderName);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelBank);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.pictureBoxFullCard);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WalletFormView";
            this.Text = "WalletFormView";
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.Load += new System.EventHandler(this.WalletFormView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFullCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWallet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxFullCard;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.Label labelBank;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelHolderName;
        private System.Windows.Forms.Button buttonCloseWallet;
        private System.Windows.Forms.Button buttonPutCard;
        private System.Windows.Forms.PictureBox pictureBoxWallet;
        private System.Windows.Forms.Panel panelCardsItems;
    }
}