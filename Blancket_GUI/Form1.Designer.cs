namespace Blancket_GUI
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvMain = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbWeight = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.btnMakeAverageFace = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.pbxAfter = new System.Windows.Forms.PictureBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDrawMesh = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWeight)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAfter)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvMain);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 543);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "画像リスト";
            // 
            // lvMain
            // 
            this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMain.FullRowSelect = true;
            this.lvMain.GridLines = true;
            this.lvMain.Location = new System.Drawing.Point(3, 15);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(273, 491);
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            this.lvMain.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvMain_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ファイル名";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "重み";
            this.columnHeader2.Width = 57;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "mes";
            this.columnHeader3.Width = 42;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Path";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbWeight);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 34);
            this.panel1.TabIndex = 1;
            // 
            // tbWeight
            // 
            this.tbWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWeight.Location = new System.Drawing.Point(0, 0);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(210, 34);
            this.tbWeight.TabIndex = 0;
            this.tbWeight.Scroll += new System.EventHandler(this.tbWeight_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudWeight);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(63, 34);
            this.panel2.TabIndex = 1;
            // 
            // nudWeight
            // 
            this.nudWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudWeight.Location = new System.Drawing.Point(0, 5);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(63, 19);
            this.nudWeight.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(63, 5);
            this.panel3.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(279, 48);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 543);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pbMain);
            this.panel4.Controls.Add(this.btnMakeAverageFace);
            this.panel4.Controls.Add(this.btnSaveImage);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(282, 554);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(759, 37);
            this.panel4.TabIndex = 3;
            // 
            // pbMain
            // 
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMain.Location = new System.Drawing.Point(75, 5);
            this.pbMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(609, 27);
            this.pbMain.TabIndex = 4;
            // 
            // btnMakeAverageFace
            // 
            this.btnMakeAverageFace.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMakeAverageFace.Location = new System.Drawing.Point(0, 5);
            this.btnMakeAverageFace.Name = "btnMakeAverageFace";
            this.btnMakeAverageFace.Size = new System.Drawing.Size(75, 27);
            this.btnMakeAverageFace.TabIndex = 3;
            this.btnMakeAverageFace.Text = "平均顔作成";
            this.btnMakeAverageFace.UseVisualStyleBackColor = true;
            this.btnMakeAverageFace.Click += new System.EventHandler(this.btnMakeAverageFace_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveImage.Location = new System.Drawing.Point(684, 5);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 27);
            this.btnSaveImage.TabIndex = 2;
            this.btnSaveImage.Text = "画像を保存";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(759, 5);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(759, 5);
            this.panel5.TabIndex = 0;
            // 
            // pbxMain
            // 
            this.pbxMain.BackColor = System.Drawing.SystemColors.Desktop;
            this.pbxMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxMain.Location = new System.Drawing.Point(282, 48);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(409, 506);
            this.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMain.TabIndex = 4;
            this.pbxMain.TabStop = false;
            // 
            // pbxAfter
            // 
            this.pbxAfter.BackColor = System.Drawing.SystemColors.Desktop;
            this.pbxAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxAfter.Location = new System.Drawing.Point(691, 48);
            this.pbxAfter.Name = "pbxAfter";
            this.pbxAfter.Size = new System.Drawing.Size(350, 506);
            this.pbxAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAfter.TabIndex = 5;
            this.pbxAfter.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(691, 48);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 506);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiView});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsmiView
            // 
            this.tsmiView.Checked = true;
            this.tsmiView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDrawMesh});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(58, 22);
            this.tsmiView.Text = "表示(&V)";
            // 
            // tsmiDrawMesh
            // 
            this.tsmiDrawMesh.Checked = true;
            this.tsmiDrawMesh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiDrawMesh.Name = "tsmiDrawMesh";
            this.tsmiDrawMesh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.tsmiDrawMesh.Size = new System.Drawing.Size(204, 22);
            this.tsmiDrawMesh.Text = "メッシュを表示(&M)";
            this.tsmiDrawMesh.Click += new System.EventHandler(this.tsmiDrawMesh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 591);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.pbxAfter);
            this.Controls.Add(this.pbxMain);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "平均顔作成ツール";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbWeight)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAfter)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tbWeight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbxMain;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnMakeAverageFace;
        private System.Windows.Forms.PictureBox pbxAfter;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrawMesh;
    }
}

