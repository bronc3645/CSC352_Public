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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.assetBox = new System.Windows.Forms.PictureBox();
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.primaryVerticalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PrimaryHorizontalTable = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.assetBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            this.primaryVerticalLayout.SuspendLayout();
            this.PrimaryHorizontalTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 313);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // assetBox
            // 
            this.assetBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetBox.Image = ((System.Drawing.Image)(resources.GetObject("assetBox.Image")));
            this.assetBox.Location = new System.Drawing.Point(3, 3);
            this.assetBox.Name = "assetBox";
            this.assetBox.Size = new System.Drawing.Size(193, 304);
            this.assetBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.assetBox.TabIndex = 2;
            this.assetBox.TabStop = false;
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mapPictureBox.Image")));
            this.mapPictureBox.Location = new System.Drawing.Point(208, 3);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(853, 620);
            this.mapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPictureBox.TabIndex = 0;
            this.mapPictureBox.TabStop = false;
            // 
            // primaryVerticalLayout
            // 
            this.primaryVerticalLayout.AutoSize = true;
            this.primaryVerticalLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.primaryVerticalLayout.ColumnCount = 2;
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryVerticalLayout.Controls.Add(this.PrimaryHorizontalTable, 0, 0);
            this.primaryVerticalLayout.Controls.Add(this.mapPictureBox, 1, 0);
            this.primaryVerticalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryVerticalLayout.Location = new System.Drawing.Point(0, 0);
            this.primaryVerticalLayout.Name = "primaryVerticalLayout";
            this.primaryVerticalLayout.RowCount = 1;
            this.primaryVerticalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.primaryVerticalLayout.Size = new System.Drawing.Size(919, 626);
            this.primaryVerticalLayout.TabIndex = 3;
            // 
            // PrimaryHorizontalTable
            // 
            this.PrimaryHorizontalTable.AutoSize = true;
            this.PrimaryHorizontalTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrimaryHorizontalTable.ColumnCount = 1;
            this.PrimaryHorizontalTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PrimaryHorizontalTable.Controls.Add(this.assetBox, 0, 0);
            this.PrimaryHorizontalTable.Controls.Add(this.comboBox1, 0, 1);
            this.PrimaryHorizontalTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryHorizontalTable.Location = new System.Drawing.Point(3, 3);
            this.PrimaryHorizontalTable.Name = "PrimaryHorizontalTable";
            this.PrimaryHorizontalTable.RowCount = 2;
            this.PrimaryHorizontalTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PrimaryHorizontalTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PrimaryHorizontalTable.Size = new System.Drawing.Size(199, 620);
            this.PrimaryHorizontalTable.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(919, 626);
            this.Controls.Add(this.primaryVerticalLayout);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.assetBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            this.primaryVerticalLayout.ResumeLayout(false);
            this.primaryVerticalLayout.PerformLayout();
            this.PrimaryHorizontalTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox assetBox;
        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.TableLayoutPanel primaryVerticalLayout;
        private System.Windows.Forms.TableLayoutPanel PrimaryHorizontalTable;
    }
}

