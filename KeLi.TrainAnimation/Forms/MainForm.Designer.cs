
namespace KeLi.TrainAnimation.Forms
{
    partial class MainForm
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
            this.tcTrain = new KeLi.TrainAnimation.Controls.TrainControl();
            this.SuspendLayout();
            // 
            // tcTrain
            // 
            this.tcTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tcTrain.Location = new System.Drawing.Point(16, 16);
            this.tcTrain.Name = "tcTrain";
            this.tcTrain.Size = new System.Drawing.Size(498, 298);
            this.tcTrain.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 331);
            this.Controls.Add(this.tcTrain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Train Animation";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TrainControl tcTrain;
    }
}

