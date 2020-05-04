namespace BankomatClient.Views
{
    partial class ImageMessageView
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
            this.pictureBoxMainImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRezMessage
            // 
            this.labelRezMessage.Location = new System.Drawing.Point(192, 260);
            // 
            // buttonPersonalArea
            // 
            this.buttonPersonalArea.Location = new System.Drawing.Point(581, 217);
            this.buttonPersonalArea.Size = new System.Drawing.Size(231, 29);
            // 
            // labelBalance
            // 
            this.labelBalance.Location = new System.Drawing.Point(621, 197);
            // 
            // pictureBoxMainImage
            // 
            this.pictureBoxMainImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMainImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMainImage.Location = new System.Drawing.Point(238, 280);
            this.pictureBoxMainImage.Name = "pictureBoxMainImage";
            this.pictureBoxMainImage.Size = new System.Drawing.Size(514, 221);
            this.pictureBoxMainImage.TabIndex = 7;
            this.pictureBoxMainImage.TabStop = false;
            // 
            // ImageMessageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxMainImage);
            this.Name = "ImageMessageView";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonToStartPage, 0);
            this.Controls.SetChildIndex(this.labelRezMessage, 0);
            this.Controls.SetChildIndex(this.labelOffMessage, 0);
            this.Controls.SetChildIndex(this.labelDetails, 0);
            this.Controls.SetChildIndex(this.labelBalance, 0);
            this.Controls.SetChildIndex(this.buttonPersonalArea, 0);
            this.Controls.SetChildIndex(this.labelPageName, 0);
            this.Controls.SetChildIndex(this.labelInstructions, 0);
            this.Controls.SetChildIndex(this.labelNotifyMessage, 0);
            this.Controls.SetChildIndex(this.pictureBoxMainImage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMainImage;
    }
}
