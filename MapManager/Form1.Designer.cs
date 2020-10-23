namespace MapManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.assetBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mapPictureBox.Image")));
            this.mapPictureBox.Location = new System.Drawing.Point(291, 12);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(639, 574);
            this.mapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPictureBox.TabIndex = 0;
            this.mapPictureBox.TabStop = false;
            this.mapPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.mapPictureBox_DragEnter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 288);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // assetBox
            // 
            this.assetBox.Image = ((System.Drawing.Image)(resources.GetObject("assetBox.Image")));
            this.assetBox.Location = new System.Drawing.Point(13, 37);
            this.assetBox.Name = "assetBox";
            this.assetBox.Size = new System.Drawing.Size(193, 223);
            this.assetBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.assetBox.TabIndex = 2;
            this.assetBox.TabStop = false;
            this.assetBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.assetBox_DragDrop);
            this.assetBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.assetBox_DragEnter);
            this.assetBox.DragOver += new System.Windows.Forms.DragEventHandler(this.assetBox_DragOver);
            this.assetBox.DragLeave += new System.EventHandler(this.assetBox_DragLeave);
            this.assetBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.assetBox_MouseDown);
            this.assetBox.Move += new System.EventHandler(this.assetBox_Move);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 739);
            this.Controls.Add(this.assetBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mapPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox assetBox;
    }
}

