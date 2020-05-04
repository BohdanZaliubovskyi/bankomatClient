namespace BankomatClient.Views
{
    partial class BasePersonalAreaView
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
            this.buttonPersonalArea = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInstructions
            // 
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInstructions.Location = new System.Drawing.Point(187, 203);
            this.labelInstructions.Size = new System.Drawing.Size(80, 17);
            // 
            // labelPageName
            // 
            this.labelPageName.Location = new System.Drawing.Point(185, 123);
            // 
            // labelDetails
            // 
            this.labelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDetails.Location = new System.Drawing.Point(187, 172);
            this.labelDetails.Size = new System.Drawing.Size(51, 17);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(188, 232);
            // 
            // buttonToStartPage
            // 
            this.buttonToStartPage.Location = new System.Drawing.Point(688, 123);
            // 
            // buttonPersonalArea
            // 
            this.buttonPersonalArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPersonalArea.Location = new System.Drawing.Point(584, 217);
            this.buttonPersonalArea.Name = "buttonPersonalArea";
            this.buttonPersonalArea.Size = new System.Drawing.Size(228, 29);
            this.buttonPersonalArea.TabIndex = 5;
            this.buttonPersonalArea.Text = "Вернуться в личный кабинет";
            this.buttonPersonalArea.UseVisualStyleBackColor = true;
            this.buttonPersonalArea.Click += new System.EventHandler(this.buttonPersonalArea_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(612, 197);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(46, 17);
            this.labelBalance.TabIndex = 6;
            this.labelBalance.Text = "label2";
            // 
            // BasePersonalAreaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.buttonPersonalArea);
            this.Name = "BasePersonalAreaView";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonToStartPage, 0);
            this.Controls.SetChildIndex(this.labelDetails, 0);
            this.Controls.SetChildIndex(this.labelPageName, 0);
            this.Controls.SetChildIndex(this.labelInstructions, 0);
            this.Controls.SetChildIndex(this.labelNotifyMessage, 0);
            this.Controls.SetChildIndex(this.buttonPersonalArea, 0);
            this.Controls.SetChildIndex(this.labelBalance, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button buttonPersonalArea;
        protected System.Windows.Forms.Label labelBalance;
    }
}
