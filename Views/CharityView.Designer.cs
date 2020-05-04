namespace BankomatClient.Views
{
    partial class CharityView
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
            this.buttonPenguins = new System.Windows.Forms.Button();
            this.buttonSquirrel = new System.Windows.Forms.Button();
            this.buttonAI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPersonalArea
            // 
            this.buttonPersonalArea.Location = new System.Drawing.Point(594, 217);
            this.buttonPersonalArea.Size = new System.Drawing.Size(218, 29);
            // 
            // labelBalance
            // 
            this.labelBalance.Location = new System.Drawing.Point(621, 197);
            // 
            // buttonPenguins
            // 
            this.buttonPenguins.Location = new System.Drawing.Point(190, 307);
            this.buttonPenguins.Name = "buttonPenguins";
            this.buttonPenguins.Size = new System.Drawing.Size(293, 45);
            this.buttonPenguins.TabIndex = 7;
            this.buttonPenguins.Text = "Пингвины на льдине";
            this.buttonPenguins.UseVisualStyleBackColor = true;
            this.buttonPenguins.Click += new System.EventHandler(this.buttonPenguins_Click);
            // 
            // buttonSquirrel
            // 
            this.buttonSquirrel.Location = new System.Drawing.Point(190, 368);
            this.buttonSquirrel.Name = "buttonSquirrel";
            this.buttonSquirrel.Size = new System.Drawing.Size(293, 45);
            this.buttonSquirrel.TabIndex = 7;
            this.buttonSquirrel.Text = "Полторы белочки";
            this.buttonSquirrel.UseVisualStyleBackColor = true;
            this.buttonSquirrel.Click += new System.EventHandler(this.buttonSquirrel_Click);
            // 
            // buttonAI
            // 
            this.buttonAI.Location = new System.Drawing.Point(190, 430);
            this.buttonAI.Name = "buttonAI";
            this.buttonAI.Size = new System.Drawing.Size(293, 45);
            this.buttonAI.TabIndex = 7;
            this.buttonAI.Text = "Отложить разработку ИИ";
            this.buttonAI.UseVisualStyleBackColor = true;
            this.buttonAI.Click += new System.EventHandler(this.buttonAI_Click);
            // 
            // CharityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAI);
            this.Controls.Add(this.buttonSquirrel);
            this.Controls.Add(this.buttonPenguins);
            this.Name = "CharityView";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonToStartPage, 0);
            this.Controls.SetChildIndex(this.labelDetails, 0);
            this.Controls.SetChildIndex(this.labelPageName, 0);
            this.Controls.SetChildIndex(this.labelInstructions, 0);
            this.Controls.SetChildIndex(this.labelNotifyMessage, 0);
            this.Controls.SetChildIndex(this.buttonPersonalArea, 0);
            this.Controls.SetChildIndex(this.labelBalance, 0);
            this.Controls.SetChildIndex(this.buttonPenguins, 0);
            this.Controls.SetChildIndex(this.buttonSquirrel, 0);
            this.Controls.SetChildIndex(this.buttonAI, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPenguins;
        private System.Windows.Forms.Button buttonSquirrel;
        private System.Windows.Forms.Button buttonAI;
    }
}
