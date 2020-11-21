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
            this.assetList = new System.Windows.Forms.ComboBox();
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.layersTable = new System.Windows.Forms.TableLayoutPanel();
            this.Layerspic = new System.Windows.Forms.PictureBox();
            this.LayerList = new System.Windows.Forms.ComboBox();
            this.ToolStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.assetBox)).BeginInit();
            this.primaryVerticalLayout.SuspendLayout();
            this.PrimaryHorizontalTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            this.layersTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Layerspic)).BeginInit();
            this.ToolStrip.SuspendLayout();
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
            this.assetBox.Click += new System.EventHandler(this.AssetBox_Click);
            // 
            // primaryVerticalLayout
            // 
            this.primaryVerticalLayout.AutoSize = true;
            this.primaryVerticalLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.primaryVerticalLayout.ColumnCount = 3;
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.primaryVerticalLayout.Controls.Add(this.PrimaryHorizontalTable, 0, 0);
            this.primaryVerticalLayout.Controls.Add(this.mapPictureBox, 1, 0);
            this.primaryVerticalLayout.Controls.Add(this.layersTable, 2, 0);
            this.primaryVerticalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryVerticalLayout.Location = new System.Drawing.Point(0, 28);
            this.primaryVerticalLayout.Name = "primaryVerticalLayout";
            this.primaryVerticalLayout.RowCount = 1;
            this.primaryVerticalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.primaryVerticalLayout.Size = new System.Drawing.Size(832, 588);
            this.primaryVerticalLayout.TabIndex = 3;
            // 
            // PrimaryHorizontalTable
            // 
            this.PrimaryHorizontalTable.AutoSize = true;
            this.PrimaryHorizontalTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrimaryHorizontalTable.ColumnCount = 1;
            this.PrimaryHorizontalTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PrimaryHorizontalTable.Controls.Add(this.assetBox, 0, 0);
            this.PrimaryHorizontalTable.Controls.Add(this.assetList, 0, 1);
            this.PrimaryHorizontalTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryHorizontalTable.Location = new System.Drawing.Point(3, 3);
            this.PrimaryHorizontalTable.Name = "PrimaryHorizontalTable";
            this.PrimaryHorizontalTable.RowCount = 3;
            this.PrimaryHorizontalTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrimaryHorizontalTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PrimaryHorizontalTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PrimaryHorizontalTable.Size = new System.Drawing.Size(206, 582);
            this.PrimaryHorizontalTable.TabIndex = 4;
            // 
            // assetList
            // 
            this.assetList.CausesValidation = false;
            this.assetList.FormattingEnabled = true;
            this.assetList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.assetList.Items.AddRange(new object[] {
            "Agents",
            "Weapons",
            "Abilities"});
            this.assetList.Location = new System.Drawing.Point(3, 312);
            this.assetList.Name = "assetList";
            this.assetList.Size = new System.Drawing.Size(193, 24);
            this.assetList.TabIndex = 1;
            this.assetList.TabStop = false;
            this.assetList.SelectedIndexChanged += new System.EventHandler(this.assetList_SelectedIndexChanged);
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mapPictureBox.Image")));
            this.mapPictureBox.Location = new System.Drawing.Point(215, 3);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(407, 582);
            this.mapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPictureBox.TabIndex = 0;
            this.mapPictureBox.TabStop = false;
            this.mapPictureBox.Click += new System.EventHandler(this.MapPictureBox_Click);
            this.mapPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapPictureBox_MouseMove);
            this.mapPictureBox.Resize += new System.EventHandler(this.MapPictureBox_Resize);
            // 
            // layersTable
            // 
            this.layersTable.AutoSize = true;
            this.layersTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layersTable.ColumnCount = 1;
            this.layersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.layersTable.Controls.Add(this.Layerspic, 0, 0);
            this.layersTable.Controls.Add(this.LayerList, 0, 1);
            this.layersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layersTable.Location = new System.Drawing.Point(628, 3);
            this.layersTable.Name = "layersTable";
            this.layersTable.RowCount = 2;
            this.layersTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layersTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layersTable.Size = new System.Drawing.Size(201, 582);
            this.layersTable.TabIndex = 5;
            // 
            // Layerspic
            // 
            this.Layerspic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layerspic.Location = new System.Drawing.Point(3, 3);
            this.Layerspic.Name = "Layerspic";
            this.Layerspic.Size = new System.Drawing.Size(195, 299);
            this.Layerspic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Layerspic.TabIndex = 0;
            this.Layerspic.TabStop = false;
            this.Layerspic.Click += new System.EventHandler(this.Layerspic_Click);
            // 
            // LayerList
            // 
            this.LayerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayerList.FormattingEnabled = true;
            this.LayerList.Location = new System.Drawing.Point(3, 308);
            this.LayerList.Name = "LayerList";
            this.LayerList.Size = new System.Drawing.Size(195, 24);
            this.LayerList.TabIndex = 1;
            this.LayerList.SelectedValueChanged += new System.EventHandler(this.LayerList_SelectedValueChanged);
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(832, 28);
            this.ToolStrip.TabIndex = 4;
            this.ToolStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(832, 616);
            this.Controls.Add(this.primaryVerticalLayout);
            this.Controls.Add(this.ToolStrip);
            this.MainMenuStrip = this.ToolStrip;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.assetBox)).EndInit();
            this.primaryVerticalLayout.ResumeLayout(false);
            this.primaryVerticalLayout.PerformLayout();
            this.PrimaryHorizontalTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            this.layersTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Layerspic)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox assetBox;
        private System.Windows.Forms.TableLayoutPanel primaryVerticalLayout;
        private System.Windows.Forms.TableLayoutPanel PrimaryHorizontalTable;
        private System.Windows.Forms.ComboBox assetList;
        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.TableLayoutPanel layersTable;
        private System.Windows.Forms.PictureBox Layerspic;
        private System.Windows.Forms.ComboBox LayerList;
        private System.Windows.Forms.MenuStrip ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

