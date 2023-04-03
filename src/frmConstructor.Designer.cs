namespace RSSGuardHelper
{
    partial class frmConstructor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkMono = new System.Windows.Forms.CheckBox();
            this.grpSingle = new System.Windows.Forms.GroupBox();
            this.txtMonoSelector = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.txtLinkElement = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitleElemet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParentElement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtPreviewJSON = new System.Windows.Forms.TextBox();
            this.lst = new System.Windows.Forms.ListBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPreviewPageSource = new System.Windows.Forms.TextBox();
            this.chkURLactive = new System.Windows.Forms.CheckBox();
            this.grpSingle.SuspendLayout();
            this.grpList.SuspendLayout();
            this.ctx.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(436, 34);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(542, 25);
            this.txtURL.TabIndex = 5;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(771, 98);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(207, 25);
            this.txtAuthor.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(768, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "author";
            // 
            // chkMono
            // 
            this.chkMono.AutoSize = true;
            this.chkMono.Location = new System.Drawing.Point(436, 98);
            this.chkMono.Name = "chkMono";
            this.chkMono.Size = new System.Drawing.Size(97, 21);
            this.chkMono.TabIndex = 8;
            this.chkMono.Text = "Single Value";
            this.chkMono.UseVisualStyleBackColor = true;
            this.chkMono.CheckedChanged += new System.EventHandler(this.chkMono_CheckedChanged);
            // 
            // grpSingle
            // 
            this.grpSingle.Controls.Add(this.txtMonoSelector);
            this.grpSingle.Controls.Add(this.label3);
            this.grpSingle.Location = new System.Drawing.Point(436, 148);
            this.grpSingle.Name = "grpSingle";
            this.grpSingle.Size = new System.Drawing.Size(542, 109);
            this.grpSingle.TabIndex = 9;
            this.grpSingle.TabStop = false;
            this.grpSingle.Visible = false;
            // 
            // txtMonoSelector
            // 
            this.txtMonoSelector.Location = new System.Drawing.Point(15, 50);
            this.txtMonoSelector.Name = "txtMonoSelector";
            this.txtMonoSelector.Size = new System.Drawing.Size(508, 25);
            this.txtMonoSelector.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selector";
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.txtLinkElement);
            this.grpList.Controls.Add(this.label6);
            this.grpList.Controls.Add(this.txtTitleElemet);
            this.grpList.Controls.Add(this.label5);
            this.grpList.Controls.Add(this.txtParentElement);
            this.grpList.Controls.Add(this.label4);
            this.grpList.Location = new System.Drawing.Point(436, 148);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(542, 226);
            this.grpList.TabIndex = 10;
            this.grpList.TabStop = false;
            // 
            // txtLinkElement
            // 
            this.txtLinkElement.Location = new System.Drawing.Point(15, 181);
            this.txtLinkElement.Name = "txtLinkElement";
            this.txtLinkElement.Size = new System.Drawing.Size(508, 25);
            this.txtLinkElement.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Link element (found in \'List element\')";
            // 
            // txtTitleElemet
            // 
            this.txtTitleElemet.Location = new System.Drawing.Point(15, 118);
            this.txtTitleElemet.Name = "txtTitleElemet";
            this.txtTitleElemet.Size = new System.Drawing.Size(508, 25);
            this.txtTitleElemet.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Title element (found in \'List element\')";
            // 
            // txtParentElement
            // 
            this.txtParentElement.Location = new System.Drawing.Point(15, 50);
            this.txtParentElement.Name = "txtParentElement";
            this.txtParentElement.Size = new System.Drawing.Size(508, 25);
            this.txtParentElement.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "List element";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(13, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 30);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "new file";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtPreviewJSON
            // 
            this.txtPreviewJSON.Location = new System.Drawing.Point(14, 387);
            this.txtPreviewJSON.MaxLength = 0;
            this.txtPreviewJSON.Multiline = true;
            this.txtPreviewJSON.Name = "txtPreviewJSON";
            this.txtPreviewJSON.ReadOnly = true;
            this.txtPreviewJSON.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPreviewJSON.Size = new System.Drawing.Size(456, 177);
            this.txtPreviewJSON.TabIndex = 12;
            this.txtPreviewJSON.Text = "JSON export for RSSGuard";
            this.txtPreviewJSON.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtPreview_MouseMove);
            // 
            // lst
            // 
            this.lst.AllowDrop = true;
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 17;
            this.lst.Location = new System.Drawing.Point(14, 54);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(399, 327);
            this.lst.TabIndex = 13;
            this.lst.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstv_DragDrop);
            this.lst.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstv_DragEnter);
            this.lst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lst_MouseDown);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(333, 13);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(80, 30);
            this.btnPreview.TabIndex = 14;
            this.btnPreview.Text = "preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(108, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "save file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctx
            // 
            this.ctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddItem,
            this.toolStripDelete});
            this.ctx.Name = "ctx";
            this.ctx.Size = new System.Drawing.Size(120, 48);
            // 
            // toolStripAddItem
            // 
            this.toolStripAddItem.Image = global::RSSGuardHelper.Properties.Resources.add16;
            this.toolStripAddItem.Name = "toolStripAddItem";
            this.toolStripAddItem.Size = new System.Drawing.Size(119, 22);
            this.toolStripAddItem.Text = "add new";
            this.toolStripAddItem.Click += new System.EventHandler(this.toolStripAddItem_Click);
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.Image = global::RSSGuardHelper.Properties.Resources.del16;
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(119, 22);
            this.toolStripDelete.Text = "delete";
            this.toolStripDelete.Click += new System.EventHandler(this.toolStripDelete_Click);
            // 
            // txtPreviewPageSource
            // 
            this.txtPreviewPageSource.Location = new System.Drawing.Point(476, 387);
            this.txtPreviewPageSource.MaxLength = 0;
            this.txtPreviewPageSource.Multiline = true;
            this.txtPreviewPageSource.Name = "txtPreviewPageSource";
            this.txtPreviewPageSource.ReadOnly = true;
            this.txtPreviewPageSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPreviewPageSource.Size = new System.Drawing.Size(502, 177);
            this.txtPreviewPageSource.TabIndex = 16;
            this.txtPreviewPageSource.Text = "Page(s) source";
            this.txtPreviewPageSource.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtPreview_MouseMove);
            // 
            // chkURLactive
            // 
            this.chkURLactive.AutoSize = true;
            this.chkURLactive.Location = new System.Drawing.Point(591, 98);
            this.chkURLactive.Name = "chkURLactive";
            this.chkURLactive.Size = new System.Drawing.Size(61, 21);
            this.chkURLactive.TabIndex = 17;
            this.chkURLactive.Text = "Active";
            this.chkURLactive.UseVisualStyleBackColor = true;
            // 
            // frmConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 570);
            this.Controls.Add(this.chkURLactive);
            this.Controls.Add(this.txtPreviewPageSource);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.txtPreviewJSON);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grpSingle);
            this.Controls.Add(this.chkMono);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmConstructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grpSingle.ResumeLayout(false);
            this.grpSingle.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.ctx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkMono;
        private System.Windows.Forms.GroupBox grpSingle;
        private System.Windows.Forms.TextBox txtMonoSelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.TextBox txtLinkElement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitleElemet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtParentElement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtPreviewJSON;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip ctx;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripDelete;
        private System.Windows.Forms.TextBox txtPreviewPageSource;
        private System.Windows.Forms.CheckBox chkURLactive;
    }
}

