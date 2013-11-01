namespace HaarTesting
{
    partial class Form1
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
            this.VideoWindow = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.VideoWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoWindow
            // 
            this.VideoWindow.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.VideoWindow.Location = new System.Drawing.Point(12, 12);
            this.VideoWindow.Name = "VideoWindow";
            this.VideoWindow.Size = new System.Drawing.Size(640, 480);
            this.VideoWindow.TabIndex = 2;
            this.VideoWindow.TabStop = false;
            this.VideoWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VideoWindow_MouseDown);
            this.VideoWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VideoWindow_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 500);
            this.Controls.Add(this.VideoWindow);
            this.Name = "Form1";
            this.Text = "Haar finding";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VideoWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox VideoWindow;
    }
}

