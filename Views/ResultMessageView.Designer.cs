namespace BankomatClient.Views
{
    partial class ResultMessageView
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
            this.labelRezMessage = new System.Windows.Forms.Label();
            this.labelOffMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPersonalArea
            // 
            this.buttonPersonalArea.Location = new System.Drawing.Point(584, 217);
            this.buttonPersonalArea.Size = new System.Drawing.Size(228, 29);
            // 
            // labelBalance
            // 
            this.labelBalance.Location = new System.Drawing.Point(619, 197);
            // 
            // labelRezMessage
            // 
            this.labelRezMessage.AutoSize = true;
            this.labelRezMessage.Location = new System.Drawing.Point(188, 265);
            this.labelRezMessage.Name = "labelRezMessage";
            this.labelRezMessage.Size = new System.Drawing.Size(46, 17);
            this.labelRezMessage.TabIndex = 5;
            this.labelRezMessage.Text = "label2";
            // 
            // labelOffMessage
            // 
            this.labelOffMessage.AutoSize = true;
            this.labelOffMessage.Location = new System.Drawing.Point(188, 328);
            this.labelOffMessage.Name = "labelOffMessage";
            this.labelOffMessage.Size = new System.Drawing.Size(46, 17);
            this.labelOffMessage.TabIndex = 5;
            this.labelOffMessage.Text = "label2";
            // 
            // ResultMessageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelOffMessage);
            this.Controls.Add(this.labelRezMessage);
            this.Name = "ResultMessageView";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonToStartPage, 0);
            this.Controls.SetChildIndex(this.labelDetails, 0);
            this.Controls.SetChildIndex(this.labelBalance, 0);
            this.Controls.SetChildIndex(this.buttonPersonalArea, 0);
            this.Controls.SetChildIndex(this.labelPageName, 0);
            this.Controls.SetChildIndex(this.labelInstructions, 0);
            this.Controls.SetChildIndex(this.labelNotifyMessage, 0);
            this.Controls.SetChildIndex(this.labelRezMessage, 0);
            this.Controls.SetChildIndex(this.labelOffMessage, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelRezMessage;
        protected System.Windows.Forms.Label labelOffMessage;
    }
}
