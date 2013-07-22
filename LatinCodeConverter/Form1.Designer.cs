namespace LatinCodeConverter
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openUyghurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLatinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveUyghurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLatinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUyghurFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLatinFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.uyghurToLatinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.latinToUyghurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyghurKeyboardLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.latinKeyboardLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLatin = new System.Windows.Forms.TextBox();
            this.btnLatin2UyghurConvert = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUyghur2LatinConvert = new System.Windows.Forms.Button();
            this.txtUyghur = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("ALKATIP Tor", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolStripMenuItem2,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.fileToolStripMenuItem.Text = "ھۆججەت";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openUyghurToolStripMenuItem,
            this.openLatinToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "ئېچىش";
            // 
            // openUyghurToolStripMenuItem
            // 
            this.openUyghurToolStripMenuItem.Name = "openUyghurToolStripMenuItem";
            this.openUyghurToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openUyghurToolStripMenuItem.Text = "ئۇيغۇرچە";
            this.openUyghurToolStripMenuItem.Click += new System.EventHandler(this.openUyghurToolStripMenuItem_Click);
            // 
            // openLatinToolStripMenuItem
            // 
            this.openLatinToolStripMenuItem.Name = "openLatinToolStripMenuItem";
            this.openLatinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openLatinToolStripMenuItem.Text = "لاتىنچە";
            this.openLatinToolStripMenuItem.Click += new System.EventHandler(this.openLatinToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveUyghurToolStripMenuItem,
            this.saveLatinToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "ساقلاش";
            // 
            // saveUyghurToolStripMenuItem
            // 
            this.saveUyghurToolStripMenuItem.Name = "saveUyghurToolStripMenuItem";
            this.saveUyghurToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveUyghurToolStripMenuItem.Text = "ئۇيغۇرچە";
            this.saveUyghurToolStripMenuItem.Click += new System.EventHandler(this.saveUyghurToolStripMenuItem_Click);
            // 
            // saveLatinToolStripMenuItem
            // 
            this.saveLatinToolStripMenuItem.Name = "saveLatinToolStripMenuItem";
            this.saveLatinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveLatinToolStripMenuItem.Text = "لاتىنچە";
            this.saveLatinToolStripMenuItem.Click += new System.EventHandler(this.saveLatinToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "تاقاش";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "چىكىنىش";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pastToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.editToolStripMenuItem.Text = "تەھرىرلەش";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "كۆچۈرۈش";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click_1);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "كىسىش";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pastToolStripMenuItem
            // 
            this.pastToolStripMenuItem.Name = "pastToolStripMenuItem";
            this.pastToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pastToolStripMenuItem.Text = "چاپلاش";
            this.pastToolStripMenuItem.Click += new System.EventHandler(this.pastToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUyghurFontToolStripMenuItem,
            this.changeLatinFontToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.viewToolStripMenuItem.Text = "كۆرۈش";
            // 
            // changeUyghurFontToolStripMenuItem
            // 
            this.changeUyghurFontToolStripMenuItem.Name = "changeUyghurFontToolStripMenuItem";
            this.changeUyghurFontToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.changeUyghurFontToolStripMenuItem.Text = "ئۇيغۇرچە خەت نۇسخىسىنى بەلگىلەش";
            this.changeUyghurFontToolStripMenuItem.Click += new System.EventHandler(this.changeUyghurFontToolStripMenuItem_Click);
            // 
            // changeLatinFontToolStripMenuItem
            // 
            this.changeLatinFontToolStripMenuItem.Name = "changeLatinFontToolStripMenuItem";
            this.changeLatinFontToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.changeLatinFontToolStripMenuItem.Text = "لاتىنچە خەت نۇسخىسىنى بەلگىلەش";
            this.changeLatinFontToolStripMenuItem.Click += new System.EventHandler(this.changeLatinFontToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uyghurToLatinToolStripMenuItem,
            this.latinToUyghurToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(77, 22);
            this.toolStripMenuItem2.Text = "ئايلاندۇرۇش";
            // 
            // uyghurToLatinToolStripMenuItem
            // 
            this.uyghurToLatinToolStripMenuItem.Name = "uyghurToLatinToolStripMenuItem";
            this.uyghurToLatinToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.uyghurToLatinToolStripMenuItem.Text = "ئۇيغۇرچىدىن لاتىنچىغا";
            this.uyghurToLatinToolStripMenuItem.Click += new System.EventHandler(this.uyghurToLatinToolStripMenuItem_Click);
            // 
            // latinToUyghurToolStripMenuItem
            // 
            this.latinToUyghurToolStripMenuItem.Name = "latinToUyghurToolStripMenuItem";
            this.latinToUyghurToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.latinToUyghurToolStripMenuItem.Text = "لاتىنچىدىن ئۇيغۇرچىغا";
            this.latinToUyghurToolStripMenuItem.Click += new System.EventHandler(this.latinToUyghurToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uyghurKeyboardLayoutToolStripMenuItem,
            this.latinKeyboardLayoutToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.helpToolStripMenuItem.Text = "ياردەم";
            // 
            // uyghurKeyboardLayoutToolStripMenuItem
            // 
            this.uyghurKeyboardLayoutToolStripMenuItem.Name = "uyghurKeyboardLayoutToolStripMenuItem";
            this.uyghurKeyboardLayoutToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.uyghurKeyboardLayoutToolStripMenuItem.Text = "ئۇيغۇرچە كونۇپكا تاختىسى لايىھەسى";
            // 
            // latinKeyboardLayoutToolStripMenuItem
            // 
            this.latinKeyboardLayoutToolStripMenuItem.Name = "latinKeyboardLayoutToolStripMenuItem";
            this.latinKeyboardLayoutToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.latinKeyboardLayoutToolStripMenuItem.Text = "لاتىنچە كونۇپكا تاختىسى لايىھەسى";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(199, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.aboutToolStripMenuItem.Text = "يۇمشاق دېتال ھەققىدە";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(624, 396);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtLatin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLatin2UyghurConvert, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.547739F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.45226F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 396);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtLatin
            // 
            this.txtLatin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatin.Location = new System.Drawing.Point(3, 40);
            this.txtLatin.Multiline = true;
            this.txtLatin.Name = "txtLatin";
            this.txtLatin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLatin.Size = new System.Drawing.Size(304, 353);
            this.txtLatin.TabIndex = 1;
            // 
            // btnLatin2UyghurConvert
            // 
            this.btnLatin2UyghurConvert.Location = new System.Drawing.Point(3, 3);
            this.btnLatin2UyghurConvert.Name = "btnLatin2UyghurConvert";
            this.btnLatin2UyghurConvert.Size = new System.Drawing.Size(136, 23);
            this.btnLatin2UyghurConvert.TabIndex = 0;
            this.btnLatin2UyghurConvert.Text = "لاتىنچىدىن ئۇيغۇرچىغا =>";
            this.btnLatin2UyghurConvert.UseVisualStyleBackColor = true;
            this.btnLatin2UyghurConvert.Click += new System.EventHandler(this.btnLatin2UyghurConvert_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtUyghur, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnUyghur2LatinConvert, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.798995F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.201F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(310, 396);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnUyghur2LatinConvert
            // 
            this.btnUyghur2LatinConvert.Location = new System.Drawing.Point(3, 3);
            this.btnUyghur2LatinConvert.Name = "btnUyghur2LatinConvert";
            this.btnUyghur2LatinConvert.Size = new System.Drawing.Size(134, 23);
            this.btnUyghur2LatinConvert.TabIndex = 0;
            this.btnUyghur2LatinConvert.Text = "<= ئۇيغۇرچىدىن لاتىنچىغا";
            this.btnUyghur2LatinConvert.UseVisualStyleBackColor = true;
            this.btnUyghur2LatinConvert.Click += new System.EventHandler(this.btnUyghur2LatinConvert_Click);
            // 
            // txtUyghur
            // 
            this.txtUyghur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUyghur.Font = new System.Drawing.Font("ALKATIP Tor", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUyghur.Location = new System.Drawing.Point(3, 41);
            this.txtUyghur.Multiline = true;
            this.txtUyghur.Name = "txtUyghur";
            this.txtUyghur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUyghur.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUyghur.Size = new System.Drawing.Size(304, 352);
            this.txtUyghur.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(624, 444);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("ALKATIP Tor", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Uyghur Latin Code Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openUyghurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLatinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveUyghurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLatinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUyghurFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLatinFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyghurToLatinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem latinToUyghurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyghurKeyboardLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem latinKeyboardLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLatin2UyghurConvert;
        private System.Windows.Forms.TextBox txtLatin;
        private System.Windows.Forms.TextBox txtUyghur;
        private System.Windows.Forms.Button btnUyghur2LatinConvert;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

