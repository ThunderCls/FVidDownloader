namespace facebook_viddownloader
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtVideoURL = new System.Windows.Forms.TextBox();
            this.txtSaveVideoPath = new System.Windows.Forms.TextBox();
            this.combVidQuality = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(132, 178);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtVideoURL
            // 
            this.txtVideoURL.Location = new System.Drawing.Point(49, 53);
            this.txtVideoURL.Name = "txtVideoURL";
            this.txtVideoURL.Size = new System.Drawing.Size(256, 20);
            this.txtVideoURL.TabIndex = 1;
            this.txtVideoURL.Text = "https://www.facebook.com/todocuba/videos/1814276785253237/";
            // 
            // txtSaveVideoPath
            // 
            this.txtSaveVideoPath.Location = new System.Drawing.Point(49, 91);
            this.txtSaveVideoPath.Name = "txtSaveVideoPath";
            this.txtSaveVideoPath.Size = new System.Drawing.Size(256, 20);
            this.txtSaveVideoPath.TabIndex = 2;
            this.txtSaveVideoPath.Text = "D:\\video.mp4";
            // 
            // combVidQuality
            // 
            this.combVidQuality.FormattingEnabled = true;
            this.combVidQuality.Items.AddRange(new object[] {
            "Standard",
            "HD"});
            this.combVidQuality.Location = new System.Drawing.Point(112, 137);
            this.combVidQuality.Name = "combVidQuality";
            this.combVidQuality.Size = new System.Drawing.Size(121, 21);
            this.combVidQuality.TabIndex = 3;
            this.combVidQuality.Text = "Standard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(49, 268);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 303);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combVidQuality);
            this.Controls.Add(this.txtSaveVideoPath);
            this.Controls.Add(this.txtVideoURL);
            this.Controls.Add(this.btnDownload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtVideoURL;
        private System.Windows.Forms.TextBox txtSaveVideoPath;
        private System.Windows.Forms.ComboBox combVidQuality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

