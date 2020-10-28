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
            this.assetBox = new System.Windows.Forms.PictureBox();
            this.primaryVerticalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PrimaryHorizontalTable = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.assetBox)).BeginInit();
            this.primaryVerticalLayout.SuspendLayout();
            this.PrimaryHorizontalTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // assetBox
            // 
            this.assetBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetBox.Image = ((System.Drawing.Image)(resources.GetObject("assetBox.Image")));
            this.assetBox.Location = new System.Drawing.Point(3, 3);
            this.assetBox.Name = "assetBox";
            this.assetBox.Size = new System.Drawing.Size(196, 303);
            this.assetBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.assetBox.TabIndex = 2;
            this.assetBox.TabStop = false;
            this.assetBox.Click += new System.EventHandler(this.assetBox_Click);
            // 
            // primaryVerticalLayout
            // 
            this.primaryVerticalLayout.AutoSize = true;
            this.primaryVerticalLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.primaryVerticalLayout.ColumnCount = 2;
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.primaryVerticalLayout.Controls.Add(this.PrimaryHorizontalTable, 0, 0);
            this.primaryVerticalLayout.Controls.Add(this.mapPictureBox, 1, 0);
            this.primaryVerticalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryVerticalLayout.Location = new System.Drawing.Point(0, 0);
            this.primaryVerticalLayout.Name = "primaryVerticalLayout";
            this.primaryVerticalLayout.RowCount = 1;
            this.primaryVerticalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.primaryVerticalLayout.Size = new System.Drawing.Size(1127, 826);
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
            this.PrimaryHorizontalTable.Controls.Add(this.comboBox2, 0, 2);
            this.PrimaryHorizontalTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryHorizontalTable.Location = new System.Drawing.Point(3, 3);
            this.PrimaryHorizontalTable.Name = "PrimaryHorizontalTable";
            this.PrimaryHorizontalTable.RowCount = 3;
            this.PrimaryHorizontalTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrimaryHorizontalTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrimaryHorizontalTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrimaryHorizontalTable.Size = new System.Drawing.Size(202, 820);
            this.PrimaryHorizontalTable.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "Agents",
            "Weapons",
            "Abilities"});
            this.comboBox1.Location = new System.Drawing.Point(3, 312);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 342);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.TabStop = false;
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mapPictureBox.Image")));
            this.mapPictureBox.Location = new System.Drawing.Point(211, 3);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(913, 820);
            this.mapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPictureBox.TabIndex = 0;
            this.mapPictureBox.TabStop = false;
            this.mapPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapPictureBox_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1127, 826);
            this.Controls.Add(this.primaryVerticalLayout);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.assetBox)).EndInit();
            this.primaryVerticalLayout.ResumeLayout(false);
            this.primaryVerticalLayout.PerformLayout();
            this.PrimaryHorizontalTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox assetBox;
        private System.Windows.Forms.TableLayoutPanel primaryVerticalLayout;
        private System.Windows.Forms.TableLayoutPanel PrimaryHorizontalTable;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox mapPictureBox;
    }
}

