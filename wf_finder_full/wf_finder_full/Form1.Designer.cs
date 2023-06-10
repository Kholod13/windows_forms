namespace wf_finder_full
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenRoot = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonMinus = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPlus = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNewDirectory = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxNewDirectory = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonRenameDirectory = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxRenameDirectory = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonRenameFile = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxRenameFile = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonDeleteFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDublicate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowHidden = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.toolStripComboBoxView = new System.Windows.Forms.ToolStripComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenRoot,
            this.toolStripLabel1,
            this.toolStripComboBoxView,
            this.toolStripButtonMinus,
            this.toolStripButtonPlus,
            this.toolStripButtonNewDirectory,
            this.toolStripTextBoxNewDirectory,
            this.toolStripButtonRenameDirectory,
            this.toolStripTextBoxRenameDirectory,
            this.toolStripButtonRenameFile,
            this.toolStripTextBoxRenameFile,
            this.toolStripButtonDeleteFile,
            this.toolStripButtonDublicate,
            this.toolStripButtonShowHidden});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1078, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpenRoot
            // 
            this.toolStripButtonOpenRoot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOpenRoot.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenRoot.Image")));
            this.toolStripButtonOpenRoot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenRoot.Name = "toolStripButtonOpenRoot";
            this.toolStripButtonOpenRoot.Size = new System.Drawing.Size(68, 22);
            this.toolStripButtonOpenRoot.Text = "Open Root";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "View:";
            // 
            // toolStripButtonMinus
            // 
            this.toolStripButtonMinus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMinus.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMinus.Image")));
            this.toolStripButtonMinus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMinus.Name = "toolStripButtonMinus";
            this.toolStripButtonMinus.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMinus.Text = "toolStripButton2";
            // 
            // toolStripButtonPlus
            // 
            this.toolStripButtonPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPlus.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPlus.Image")));
            this.toolStripButtonPlus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPlus.Name = "toolStripButtonPlus";
            this.toolStripButtonPlus.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPlus.Text = "toolStripButton3";
            // 
            // toolStripButtonNewDirectory
            // 
            this.toolStripButtonNewDirectory.Name = "toolStripButtonNewDirectory";
            this.toolStripButtonNewDirectory.Size = new System.Drawing.Size(84, 22);
            this.toolStripButtonNewDirectory.Text = "New directory:";
            // 
            // toolStripTextBoxNewDirectory
            // 
            this.toolStripTextBoxNewDirectory.Name = "toolStripTextBoxNewDirectory";
            this.toolStripTextBoxNewDirectory.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonRenameDirectory
            // 
            this.toolStripButtonRenameDirectory.Name = "toolStripButtonRenameDirectory";
            this.toolStripButtonRenameDirectory.Size = new System.Drawing.Size(103, 22);
            this.toolStripButtonRenameDirectory.Text = "Rename directory:";
            // 
            // toolStripTextBoxRenameDirectory
            // 
            this.toolStripTextBoxRenameDirectory.Name = "toolStripTextBoxRenameDirectory";
            this.toolStripTextBoxRenameDirectory.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonRenameFile
            // 
            this.toolStripButtonRenameFile.Name = "toolStripButtonRenameFile";
            this.toolStripButtonRenameFile.Size = new System.Drawing.Size(72, 22);
            this.toolStripButtonRenameFile.Text = "Rename file:";
            // 
            // toolStripTextBoxRenameFile
            // 
            this.toolStripTextBoxRenameFile.Name = "toolStripTextBoxRenameFile";
            this.toolStripTextBoxRenameFile.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonDeleteFile
            // 
            this.toolStripButtonDeleteFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDeleteFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteFile.Image")));
            this.toolStripButtonDeleteFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteFile.Name = "toolStripButtonDeleteFile";
            this.toolStripButtonDeleteFile.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonDeleteFile.Text = "Delete file";
            // 
            // toolStripButtonDublicate
            // 
            this.toolStripButtonDublicate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDublicate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDublicate.Image")));
            this.toolStripButtonDublicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDublicate.Name = "toolStripButtonDublicate";
            this.toolStripButtonDublicate.Size = new System.Drawing.Size(61, 22);
            this.toolStripButtonDublicate.Text = "Dublicate";
            // 
            // toolStripButtonShowHidden
            // 
            this.toolStripButtonShowHidden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonShowHidden.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowHidden.Image")));
            this.toolStripButtonShowHidden.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowHidden.Name = "toolStripButtonShowHidden";
            this.toolStripButtonShowHidden.Size = new System.Drawing.Size(83, 22);
            this.toolStripButtonShowHidden.Text = "Show hedden";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 41);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(471, 397);
            this.treeView1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(511, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(547, 397);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripComboBoxView
            // 
            this.toolStripComboBoxView.Name = "toolStripComboBoxView";
            this.toolStripComboBoxView.Size = new System.Drawing.Size(121, 25);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonOpenRoot;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolStripButtonMinus;
        private ToolStripButton toolStripButtonPlus;
        private ToolStripLabel toolStripButtonNewDirectory;
        private ToolStripTextBox toolStripTextBoxNewDirectory;
        private ToolStripLabel toolStripButtonRenameDirectory;
        private ToolStripTextBox toolStripTextBoxRenameDirectory;
        private ToolStripLabel toolStripButtonRenameFile;
        private ToolStripTextBox toolStripTextBoxRenameFile;
        private ToolStripButton toolStripButtonDeleteFile;
        private ToolStripButton toolStripButtonDublicate;
        private ToolStripButton toolStripButtonShowHidden;
        private TreeView treeView1;
        private ListView listView1;
        private ToolStripComboBox toolStripComboBoxView;
        private ImageList imageList1;
    }
}