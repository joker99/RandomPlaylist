namespace RandomPlaylist
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
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetTargetDirectory = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.listSourceDirectories = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSourceDirectory = new System.Windows.Forms.Button();
            this.removeSourceDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.lblProgress = new System.Windows.Forms.Label();
            this.panelProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTargetDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtTargetDirectory.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RandomPlaylist.Properties.Settings.Default, "TargetDirectory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTargetDirectory.Location = new System.Drawing.Point(12, 308);
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.Size = new System.Drawing.Size(627, 20);
            this.txtTargetDirectory.TabIndex = 0;
            this.txtTargetDirectory.Text = global::RandomPlaylist.Properties.Settings.Default.TargetDirectory;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target directory:";
            // 
            // btnSetTargetDirectory
            // 
            this.btnSetTargetDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetTargetDirectory.Location = new System.Drawing.Point(645, 306);
            this.btnSetTargetDirectory.Name = "btnSetTargetDirectory";
            this.btnSetTargetDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnSetTargetDirectory.TabIndex = 2;
            this.btnSetTargetDirectory.Text = "Browse";
            this.btnSetTargetDirectory.UseVisualStyleBackColor = true;
            this.btnSetTargetDirectory.Click += new System.EventHandler(this.btnSetTargetDirectory_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGo.Location = new System.Drawing.Point(330, 334);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "GO!!!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // listSourceDirectories
            // 
            this.listSourceDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listSourceDirectories.FormattingEnabled = true;
            this.listSourceDirectories.Location = new System.Drawing.Point(12, 25);
            this.listSourceDirectories.Name = "listSourceDirectories";
            this.listSourceDirectories.Size = new System.Drawing.Size(711, 225);
            this.listSourceDirectories.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Source directories:";
            // 
            // btnAddSourceDirectory
            // 
            this.btnAddSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddSourceDirectory.Location = new System.Drawing.Point(12, 258);
            this.btnAddSourceDirectory.Name = "btnAddSourceDirectory";
            this.btnAddSourceDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnAddSourceDirectory.TabIndex = 7;
            this.btnAddSourceDirectory.Text = "Add";
            this.btnAddSourceDirectory.UseVisualStyleBackColor = true;
            this.btnAddSourceDirectory.Click += new System.EventHandler(this.btnAddSourceDirectory_Click);
            // 
            // removeSourceDirectory
            // 
            this.removeSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeSourceDirectory.Location = new System.Drawing.Point(93, 258);
            this.removeSourceDirectory.Name = "removeSourceDirectory";
            this.removeSourceDirectory.Size = new System.Drawing.Size(75, 23);
            this.removeSourceDirectory.TabIndex = 8;
            this.removeSourceDirectory.Text = "Remove";
            this.removeSourceDirectory.UseVisualStyleBackColor = true;
            this.removeSourceDirectory.Click += new System.EventHandler(this.removeSourceDirectory_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // panelProgress
            // 
            this.panelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProgress.Controls.Add(this.lblProgress);
            this.panelProgress.Location = new System.Drawing.Point(170, 114);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(394, 141);
            this.panelProgress.TabIndex = 9;
            this.panelProgress.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(20, 64);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(56, 13);
            this.lblProgress.TabIndex = 0;
            this.lblProgress.Text = "Working...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 369);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.removeSourceDirectory);
            this.Controls.Add(this.btnAddSourceDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listSourceDirectories);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnSetTargetDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTargetDirectory);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::RandomPlaylist.Properties.Settings.Default, "FormLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::RandomPlaylist.Properties.Settings.Default.FormLocation;
            this.Name = "Form1";
            this.Text = "Random playlist creator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTargetDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetTargetDirectory;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListBox listSourceDirectories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSourceDirectory;
        private System.Windows.Forms.Button removeSourceDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Label lblProgress;
    }
}

