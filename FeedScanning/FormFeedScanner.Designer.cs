﻿namespace FeedScanning
{
    partial class FormFeedScanner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFeedScanner));
            this.dataGridViewFeed = new System.Windows.Forms.DataGridView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxFeedUrl = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonRefreshCancel = new System.Windows.Forms.Button();
            this.checkBoxDeleteAfterCopy = new System.Windows.Forms.CheckBox();
            this.buttonDeleteDone = new System.Windows.Forms.Button();
            this.buttonPurgeNonFavorites = new System.Windows.Forms.Button();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewFavoriteShow = new System.Windows.Forms.DataGridView();
            this.QualitySetting = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favoriteShowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeed)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavoriteShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteShowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFeed
            // 
            this.dataGridViewFeed.AllowUserToAddRows = false;
            this.dataGridViewFeed.AllowUserToDeleteRows = false;
            this.dataGridViewFeed.AllowUserToOrderColumns = true;
            this.dataGridViewFeed.AllowUserToResizeRows = false;
            this.dataGridViewFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFeed.AutoGenerateColumns = false;
            this.dataGridViewFeed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Done,
            this.titleDataGridViewTextBoxColumn});
            this.dataGridViewFeed.DataSource = this.feedItemBindingSource;
            this.dataGridViewFeed.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewFeed.MultiSelect = false;
            this.dataGridViewFeed.Name = "dataGridViewFeed";
            this.dataGridViewFeed.RowHeadersVisible = false;
            this.dataGridViewFeed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFeed.Size = new System.Drawing.Size(416, 346);
            this.dataGridViewFeed.TabIndex = 0;
            this.dataGridViewFeed.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFeed_CellDoubleClick);
            this.dataGridViewFeed.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewFeed_RowPrePaint);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "FeedScanner";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripMenuItemShow,
            this.toolStripSeparator2,
            this.toolStripMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 60);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // toolStripMenuItemShow
            // 
            this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
            this.toolStripMenuItemShow.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItemShow.Text = "Show Window";
            this.toolStripMenuItemShow.Click += new System.EventHandler(this.toolStripMenuItemShow_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // textBoxFeedUrl
            // 
            this.textBoxFeedUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFeedUrl.BackColor = System.Drawing.Color.White;
            this.textBoxFeedUrl.Location = new System.Drawing.Point(13, 13);
            this.textBoxFeedUrl.Name = "textBoxFeedUrl";
            this.textBoxFeedUrl.ReadOnly = true;
            this.textBoxFeedUrl.Size = new System.Drawing.Size(334, 20);
            this.textBoxFeedUrl.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 388);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(765, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel1.Text = "status";
            // 
            // buttonRefreshCancel
            // 
            this.buttonRefreshCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshCancel.Location = new System.Drawing.Point(353, 11);
            this.buttonRefreshCancel.Name = "buttonRefreshCancel";
            this.buttonRefreshCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshCancel.TabIndex = 3;
            this.buttonRefreshCancel.Text = "Refresh";
            this.buttonRefreshCancel.UseVisualStyleBackColor = true;
            this.buttonRefreshCancel.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // checkBoxDeleteAfterCopy
            // 
            this.checkBoxDeleteAfterCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDeleteAfterCopy.AutoSize = true;
            this.checkBoxDeleteAfterCopy.Location = new System.Drawing.Point(472, 15);
            this.checkBoxDeleteAfterCopy.Name = "checkBoxDeleteAfterCopy";
            this.checkBoxDeleteAfterCopy.Size = new System.Drawing.Size(79, 17);
            this.checkBoxDeleteAfterCopy.TabIndex = 7;
            this.checkBoxDeleteAfterCopy.Text = "AutoDelete";
            this.checkBoxDeleteAfterCopy.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteDone
            // 
            this.buttonDeleteDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteDone.Location = new System.Drawing.Point(557, 11);
            this.buttonDeleteDone.Name = "buttonDeleteDone";
            this.buttonDeleteDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteDone.TabIndex = 8;
            this.buttonDeleteDone.Text = "Delete Done";
            this.buttonDeleteDone.UseVisualStyleBackColor = true;
            this.buttonDeleteDone.Click += new System.EventHandler(this.buttonDeleteDone_Click);
            // 
            // buttonPurgeNonFavorites
            // 
            this.buttonPurgeNonFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPurgeNonFavorites.Location = new System.Drawing.Point(638, 11);
            this.buttonPurgeNonFavorites.Name = "buttonPurgeNonFavorites";
            this.buttonPurgeNonFavorites.Size = new System.Drawing.Size(115, 23);
            this.buttonPurgeNonFavorites.TabIndex = 9;
            this.buttonPurgeNonFavorites.Text = "Purge Non-Favorites";
            this.buttonPurgeNonFavorites.UseVisualStyleBackColor = true;
            this.buttonPurgeNonFavorites.Click += new System.EventHandler(this.buttonPurgeNonFavorites_Click);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Favorite";
            this.dataGridViewCheckBoxColumn1.FillWeight = 1F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Favorite";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // Done
            // 
            this.Done.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Done.DataPropertyName = "Done";
            this.Done.FillWeight = 1F;
            this.Done.HeaderText = "Done";
            this.Done.Name = "Done";
            this.Done.Width = 5;
            // 
            // dataGridViewFavoriteShow
            // 
            this.dataGridViewFavoriteShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFavoriteShow.AutoGenerateColumns = false;
            this.dataGridViewFavoriteShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFavoriteShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.QualitySetting});
            this.dataGridViewFavoriteShow.DataSource = this.favoriteShowBindingSource;
            this.dataGridViewFavoriteShow.Location = new System.Drawing.Point(434, 40);
            this.dataGridViewFavoriteShow.MultiSelect = false;
            this.dataGridViewFavoriteShow.Name = "dataGridViewFavoriteShow";
            this.dataGridViewFavoriteShow.RowHeadersVisible = false;
            this.dataGridViewFavoriteShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFavoriteShow.Size = new System.Drawing.Size(319, 345);
            this.dataGridViewFavoriteShow.TabIndex = 7;
            // 
            // QualitySetting
            // 
            this.QualitySetting.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QualitySetting.DataPropertyName = "QualitySetting";
            this.QualitySetting.HeaderText = "QualitySetting";
            this.QualitySetting.Name = "QualitySetting";
            this.QualitySetting.Width = 78;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SearchPattern";
            this.dataGridViewTextBoxColumn1.HeaderText = "SearchPattern";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // favoriteShowBindingSource
            // 
            this.favoriteShowBindingSource.DataSource = typeof(FeedScanning.FavoriteShow);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feedItemBindingSource
            // 
            this.feedItemBindingSource.DataSource = typeof(FeedScanning.FeedItem);
            // 
            // FormFeedScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 410);
            this.Controls.Add(this.dataGridViewFavoriteShow);
            this.Controls.Add(this.buttonPurgeNonFavorites);
            this.Controls.Add(this.buttonDeleteDone);
            this.Controls.Add(this.checkBoxDeleteAfterCopy);
            this.Controls.Add(this.buttonRefreshCancel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxFeedUrl);
            this.Controls.Add(this.dataGridViewFeed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFeedScanner";
            this.Text = "FeedScanner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeed)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavoriteShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteShowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFeed;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.TextBox textBoxFeedUrl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonRefreshCancel;
        private System.Windows.Forms.BindingSource feedItemBindingSource;
        private System.Windows.Forms.BindingSource favoriteShowBindingSource;
        private System.Windows.Forms.CheckBox checkBoxDeleteAfterCopy;
        private System.Windows.Forms.Button buttonDeleteDone;
        private System.Windows.Forms.Button buttonPurgeNonFavorites;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Done;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewFavoriteShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn QualitySetting;
    }
}

