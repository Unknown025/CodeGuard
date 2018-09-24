namespace CodeGuard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.openMenuItem = new System.Windows.Forms.MenuItem();
            this.clearAllMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.runMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.optionsMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.viewMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.helpMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.filesGroupBox = new System.Windows.Forms.GroupBox();
            this.filesListView = new System.Windows.Forms.ListView();
            this.filesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.runButton = new System.Windows.Forms.Button();
            this.desiredOutputPage = new System.Windows.Forms.TabPage();
            this.resultsPage = new System.Windows.Forms.TabPage();
            this.assignmentDetails = new System.Windows.Forms.RichTextBox();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.assignmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.plagiarismColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip.SuspendLayout();
            this.filesGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            this.resultsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem,
            this.optionsMenuItem,
            this.viewMenuItem,
            this.helpMenuItem});
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Index = 0;
            this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.openMenuItem,
            this.clearAllMenuItem,
            this.menuItem1,
            this.runMenuItem,
            this.menuItem10,
            this.exitMenuItem});
            this.fileMenuItem.Text = "&File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Index = 0;
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // clearAllMenuItem
            // 
            this.clearAllMenuItem.Index = 1;
            this.clearAllMenuItem.Text = "Clear All";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // runMenuItem
            // 
            this.runMenuItem.Index = 3;
            this.runMenuItem.Text = "Run Tests";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 4;
            this.menuItem10.Text = "-";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Index = 5;
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Index = 1;
            this.optionsMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6});
            this.optionsMenuItem.Text = "&Edit";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "Desired Output";
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.Index = 2;
            this.viewMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4});
            this.viewMenuItem.Text = "&View";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Settings";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Index = 3;
            this.helpMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7,
            this.menuItem8,
            this.menuItem3,
            this.menuItem9});
            this.helpMenuItem.Text = "&Help";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Text = "View Help";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.Text = "-";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "Check for updates";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            this.menuItem9.Text = "About CodeGuard";
            // 
            // filesGroupBox
            // 
            this.filesGroupBox.Controls.Add(this.filesListView);
            this.filesGroupBox.Location = new System.Drawing.Point(6, 6);
            this.filesGroupBox.Name = "filesGroupBox";
            this.filesGroupBox.Size = new System.Drawing.Size(270, 375);
            this.filesGroupBox.TabIndex = 1;
            this.filesGroupBox.TabStop = false;
            this.filesGroupBox.Text = "Files to compile";
            // 
            // filesListView
            // 
            this.filesListView.CheckBoxes = true;
            this.filesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.filesHeader});
            this.filesListView.Location = new System.Drawing.Point(6, 19);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(255, 350);
            this.filesListView.TabIndex = 0;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.Details;
            // 
            // filesHeader
            // 
            this.filesHeader.Text = "Files";
            this.filesHeader.Width = 190;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.generalTabPage);
            this.tabControl.Controls.Add(this.desiredOutputPage);
            this.tabControl.Controls.Add(this.resultsPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 413);
            this.tabControl.TabIndex = 1;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.optionsGroupBox);
            this.generalTabPage.Controls.Add(this.filesGroupBox);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(768, 387);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            this.generalTabPage.UseVisualStyleBackColor = true;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.runButton);
            this.optionsGroupBox.Location = new System.Drawing.Point(283, 6);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(479, 369);
            this.optionsGroupBox.TabIndex = 2;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(398, 340);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run Tests";
            this.runButton.UseVisualStyleBackColor = true;
            // 
            // desiredOutputPage
            // 
            this.desiredOutputPage.Location = new System.Drawing.Point(4, 22);
            this.desiredOutputPage.Name = "desiredOutputPage";
            this.desiredOutputPage.Padding = new System.Windows.Forms.Padding(3);
            this.desiredOutputPage.Size = new System.Drawing.Size(768, 387);
            this.desiredOutputPage.TabIndex = 1;
            this.desiredOutputPage.Text = "Test Case";
            this.desiredOutputPage.UseVisualStyleBackColor = true;
            // 
            // resultsPage
            // 
            this.resultsPage.Controls.Add(this.assignmentDetails);
            this.resultsPage.Controls.Add(this.resultGridView);
            this.resultsPage.Location = new System.Drawing.Point(4, 22);
            this.resultsPage.Name = "resultsPage";
            this.resultsPage.Padding = new System.Windows.Forms.Padding(3);
            this.resultsPage.Size = new System.Drawing.Size(768, 387);
            this.resultsPage.TabIndex = 2;
            this.resultsPage.Text = "Results";
            this.resultsPage.UseVisualStyleBackColor = true;
            // 
            // assignmentDetails
            // 
            this.assignmentDetails.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.assignmentDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.assignmentDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.assignmentDetails.Location = new System.Drawing.Point(7, 315);
            this.assignmentDetails.Name = "assignmentDetails";
            this.assignmentDetails.ReadOnly = true;
            this.assignmentDetails.Size = new System.Drawing.Size(755, 66);
            this.assignmentDetails.TabIndex = 1;
            this.assignmentDetails.Text = "";
            // 
            // resultGridView
            // 
            this.resultGridView.AllowUserToAddRows = false;
            this.resultGridView.AllowUserToDeleteRows = false;
            this.resultGridView.AllowUserToResizeColumns = false;
            this.resultGridView.AllowUserToResizeRows = false;
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.resultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assignmentColumn,
            this.statusColumn,
            this.plagiarismColumn});
            this.resultGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.resultGridView.Location = new System.Drawing.Point(7, 7);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.ReadOnly = true;
            this.resultGridView.RowHeadersVisible = false;
            this.resultGridView.ShowEditingIcon = false;
            this.resultGridView.ShowRowErrors = false;
            this.resultGridView.Size = new System.Drawing.Size(755, 301);
            this.resultGridView.TabIndex = 0;
            // 
            // assignmentColumn
            // 
            this.assignmentColumn.HeaderText = "Assignment";
            this.assignmentColumn.Name = "assignmentColumn";
            this.assignmentColumn.ReadOnly = true;
            this.assignmentColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.assignmentColumn.Width = 450;
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            this.statusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // plagiarismColumn
            // 
            this.plagiarismColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plagiarismColumn.HeaderText = "Plagiarism";
            this.plagiarismColumn.Name = "plagiarismColumn";
            this.plagiarismColumn.ReadOnly = true;
            this.plagiarismColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Icon_0322_16.png");
            this.imageList.Images.SetKeyName(1, "Icon_0323_16.png");
            this.imageList.Images.SetKeyName(2, "Icon_0324_16.png");
            this.imageList.Images.SetKeyName(3, "Icon_0325_16.png");
            this.imageList.Images.SetKeyName(4, "Icon_0331_16.png");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Menu = this.mainMenu;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "CodeGuard v1.0.0.0";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.filesGroupBox.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.optionsGroupBox.ResumeLayout(false);
            this.resultsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem fileMenuItem;
        private System.Windows.Forms.MenuItem optionsMenuItem;
        private System.Windows.Forms.MenuItem openMenuItem;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem viewMenuItem;
        private System.Windows.Forms.MenuItem helpMenuItem;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem runMenuItem;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.GroupBox filesGroupBox;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem exitMenuItem;
        private System.Windows.Forms.ColumnHeader filesHeader;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage desiredOutputPage;
        private System.Windows.Forms.TabPage resultsPage;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentColumn;
        private System.Windows.Forms.DataGridViewImageColumn statusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plagiarismColumn;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.MenuItem clearAllMenuItem;
        private System.Windows.Forms.RichTextBox assignmentDetails;
    }
}

