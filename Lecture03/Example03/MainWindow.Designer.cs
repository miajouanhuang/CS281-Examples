namespace Example03
{
    partial class MainWindow
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
            this.scenePictureBox = new System.Windows.Forms.PictureBox();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scenePictureBox
            // 
            this.scenePictureBox.Image = global::Example03.Properties.Resources._1;
            this.scenePictureBox.Location = new System.Drawing.Point(9, 10);
            this.scenePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scenePictureBox.Name = "scenePictureBox";
            this.scenePictureBox.Size = new System.Drawing.Size(544, 446);
            this.scenePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scenePictureBox.TabIndex = 0;
            this.scenePictureBox.TabStop = false;
            this.scenePictureBox.Click += new System.EventHandler(this.scenePictureBox_Click);
            // 
            // yesButton
            // 
            this.yesButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yesButton.Location = new System.Drawing.Point(11, 474);
            this.yesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(262, 81);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.noButton.Location = new System.Drawing.Point(291, 474);
            this.noButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(262, 81);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 580);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.scenePictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox scenePictureBox;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
    }
}