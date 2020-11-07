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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mousePy = new System.Windows.Forms.Label();
            this.mousePx = new System.Windows.Forms.Label();
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.layersTable = new System.Windows.Forms.TableLayoutPanel();
            this.Layerspic = new System.Windows.Forms.PictureBox();
            this.LayerList = new System.Windows.Forms.ComboBox();
            this.debugStatis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assetBox)).BeginInit();
            this.primaryVerticalLayout.SuspendLayout();
            this.PrimaryHorizontalTable.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            this.layersTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Layerspic)).BeginInit();
            this.SuspendLayout();
            // 
            // assetBox
            // 
            this.assetBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetBox.Image = ((System.Drawing.Image)(resources.GetObject("assetBox.Image")));
            this.assetBox.Location = new System.Drawing.Point(3, 3);
            this.assetBox.Name = "assetBox";
            this.assetBox.Size = new System.Drawing.Size(200, 303);
            this.assetBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.assetBox.TabIndex = 2;
            this.assetBox.TabStop = false;
            this.assetBox.Click += new System.EventHandler(this.assetBox_Click);
            // 
            // primaryVerticalLayout
            // 
            this.primaryVerticalLayout.AutoSize = true;
            this.primaryVerticalLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.primaryVerticalLayout.ColumnCount = 3;
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.19355F));
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.80645F));
            this.primaryVerticalLayout.Controls.Add(this.PrimaryHorizontalTable, 0, 0);
            this.primaryVerticalLayout.Controls.Add(this.mapPictureBox, 1, 0);
            this.primaryVerticalLayout.Controls.Add(this.layersTable, 2, 0);
            this.primaryVerticalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryVerticalLayout.Location = new System.Drawing.Point(0, 0);
            this.primaryVerticalLayout.Name = "primaryVerticalLayout";
            this.primaryVerticalLayout.RowCount = 1;
            this.primaryVerticalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.primaryVerticalLayout.Size = new System.Drawing.Size(832, 616);
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
            this.PrimaryHorizontalTable.Controls.Add(this.panel1, 0, 2);
            this.PrimaryHorizontalTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryHorizontalTable.Location = new System.Drawing.Point(3, 3);
            this.PrimaryHorizontalTable.Name = "PrimaryHorizontalTable";
            this.PrimaryHorizontalTable.RowCount = 3;
            this.PrimaryHorizontalTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrimaryHorizontalTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrimaryHorizontalTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PrimaryHorizontalTable.Size = new System.Drawing.Size(206, 610);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.debugStatis);
            this.panel1.Controls.Add(this.mousePy);
            this.panel1.Controls.Add(this.mousePx);
            this.panel1.Location = new System.Drawing.Point(3, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 157);
            this.panel1.TabIndex = 3;
            // 
            // mousePy
            // 
            this.mousePy.AutoSize = true;
            this.mousePy.Location = new System.Drawing.Point(6, 31);
            this.mousePy.Name = "mousePy";
            this.mousePy.Size = new System.Drawing.Size(74, 17);
            this.mousePy.TabIndex = 1;
            this.mousePy.Text = "mousePy: ";
            // 
            // mousePx
            // 
            this.mousePx.AutoSize = true;
            this.mousePx.Location = new System.Drawing.Point(6, 0);
            this.mousePx.Name = "mousePx";
            this.mousePx.Size = new System.Drawing.Size(73, 17);
            this.mousePx.TabIndex = 0;
            this.mousePx.Text = "mousePx: ";
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mapPictureBox.Image")));
            this.mapPictureBox.Location = new System.Drawing.Point(215, 3);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(423, 610);
            this.mapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPictureBox.TabIndex = 0;
            this.mapPictureBox.TabStop = false;
            this.mapPictureBox.Click += new System.EventHandler(this.mapPictureBox_Click);
            this.mapPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapPictureBox_MouseMove);
            this.mapPictureBox.Resize += new System.EventHandler(this.mapPictureBox_Resize);
            // 
            // layersTable
            // 
            this.layersTable.AutoSize = true;
            this.layersTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layersTable.ColumnCount = 1;
            this.layersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layersTable.Controls.Add(this.Layerspic, 0, 0);
            this.layersTable.Controls.Add(this.LayerList, 0, 1);
            this.layersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layersTable.Location = new System.Drawing.Point(644, 3);
            this.layersTable.Name = "layersTable";
            this.layersTable.RowCount = 2;
            this.layersTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layersTable.Size = new System.Drawing.Size(185, 610);
            this.layersTable.TabIndex = 5;
            // 
            // Layerspic
            // 
            this.Layerspic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layerspic.Location = new System.Drawing.Point(3, 3);
            this.Layerspic.Name = "Layerspic";
            this.Layerspic.Size = new System.Drawing.Size(179, 299);
            this.Layerspic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Layerspic.TabIndex = 0;
            this.Layerspic.TabStop = false;
            // 
            // LayerList
            // 
            this.LayerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayerList.FormattingEnabled = true;
            this.LayerList.Location = new System.Drawing.Point(3, 308);
            this.LayerList.Name = "LayerList";
            this.LayerList.Size = new System.Drawing.Size(179, 24);
            this.LayerList.TabIndex = 1;
            this.LayerList.SelectedValueChanged += new System.EventHandler(this.LayerList_SelectedValueChanged);
            // 
            // debugStatis
            // 
            this.debugStatis.AutoSize = true;
            this.debugStatis.Location = new System.Drawing.Point(6, 59);
            this.debugStatis.Name = "debugStatis";
            this.debugStatis.Size = new System.Drawing.Size(88, 17);
            this.debugStatis.TabIndex = 2;
            this.debugStatis.Text = "debugStatus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(832, 616);
            this.Controls.Add(this.primaryVerticalLayout);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.assetBox)).EndInit();
            this.primaryVerticalLayout.ResumeLayout(false);
            this.primaryVerticalLayout.PerformLayout();
            this.PrimaryHorizontalTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            this.layersTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Layerspic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox assetBox;
        private System.Windows.Forms.TableLayoutPanel primaryVerticalLayout;
        private System.Windows.Forms.TableLayoutPanel PrimaryHorizontalTable;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mousePy;
        private System.Windows.Forms.Label mousePx;
        private System.Windows.Forms.TableLayoutPanel layersTable;
        private System.Windows.Forms.PictureBox Layerspic;
        private System.Windows.Forms.ComboBox LayerList;
        private System.Windows.Forms.Label debugStatis;
    }
}

