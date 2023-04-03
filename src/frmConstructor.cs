using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace RSSGuardHelper
{
    //https://html-agility-pack.net/online-examples

    public partial class frmConstructor : Form
    {
        private BindingSource bindSource;

        public frmConstructor()
        {
            InitializeComponent();

            this.Text = Application.ProductName + " v" + Application.ProductVersion;

            System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;

            grpList.Top = grpSingle.Top;

            //listbox binding
            //General.db = new List<PRJsettings>();

            bindSource = new BindingSource();
            bindSource.DataSource = General.db;
            lst.DataSource = bindSource;
            lst.DisplayMember = "URL";


            //editable controls binding
            //https://stackoverflow.com/q/11485377
            //bool - Binding.FormattingEnabled Property - https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.binding.formattingenabled?view=windowsdesktop-7.0
            txtURL.DataBindings.Add(new Binding("Text", this.bindSource, "URL", false));
            chkURLactive.DataBindings.Add(new Binding("Checked", this.bindSource, "URLactive", false));
            txtAuthor.DataBindings.Add(new Binding("Text", this.bindSource, "author", false));
            chkMono.DataBindings.Add(new Binding("Checked", this.bindSource, "isMono", false));
            txtParentElement.DataBindings.Add(new Binding("Text", this.bindSource, "parentElementSelector", false));
            txtTitleElemet.DataBindings.Add(new Binding("Text", this.bindSource, "titleElementSelector", false));
            txtLinkElement.DataBindings.Add(new Binding("Text", this.bindSource, "linkElementSelector", false));
            txtMonoSelector.DataBindings.Add(new Binding("Text", this.bindSource, "monoElementSelector", false));
        }

        #region " LST EVENTS "

        private void lstv_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move | DragDropEffects.Copy | DragDropEffects.Scroll;
            }
        }

        private void lstv_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);

                General.db.Clear();
                General.LoadFile(data[0]);
                bindSource.ResetBindings(false);
            }
        }

        private void lst_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                toolStripDelete.Visible = bindSource.Current != null;
                ctx.Show(System.Windows.Forms.Cursor.Position);
            }
        }

        #endregion


        private void btnNew_Click(object sender, EventArgs e)
        {
            if (lst.Items.Count > 0)
            {
                if (General.Mes("This action will remove all the item(s).\n\nAre you sure?", MessageBoxIcon.Information, MessageBoxButtons.YesNoCancel) != System.Windows.Forms.DialogResult.Yes)
                    return;
            }

            ClearPreviews();
            General.db.Clear();
            bindSource.ResetBindings(false);
        }


        private void chkMono_CheckedChanged(object sender, EventArgs e)
        {   //dont alter the /visible/ property of controls because breaks the binding. wtf!?
            if (chkMono.Checked)
            {
                grpList.Size = new System.Drawing.Size(0, 0);
                grpSingle.Size = new System.Drawing.Size(542, 109);
            }
            else
            {
                grpList.Size = new System.Drawing.Size(542, 226);
                grpSingle.Size = new System.Drawing.Size(0, 0);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (!General.ValidateItemExistance())
                return;

            ClearPreviews();
            Parser.pageSourceAll = string.Empty;

            txtPreviewJSON.Text = General.ParseFeeds().Serialize().Replace(",\"url\":", "\r\n,\"url\":").Replace(",\"title\"", "\r\n,\"title\"");
            txtPreviewPageSource.Text = Parser.pageSourceAll;
        }

        private void ClearPreviews()
        {
            txtPreviewPageSource.Text = "Page(s) source";
            txtPreviewJSON.Text = "JSON export for RSSGuard";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!General.ValidateItemExistance())
                return;

            SaveFileDialog cdlg = new SaveFileDialog();

            try
            {
                cdlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (General.loadedFilename != string.Empty)
                {
                    cdlg.FileName = Path.GetFileName(General.loadedFilename);
                    cdlg.InitialDirectory = Path.GetFullPath(General.loadedFilename);
                }
                else
                    cdlg.InitialDirectory = Application.StartupPath;

                if (cdlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
            }
            catch (Exception ex)
            {
                General.Mes(ex.Message, MessageBoxIcon.Error, MessageBoxButtons.OK);
            }
            finally
            {
                cdlg.Dispose();
            }

            if (!string.IsNullOrEmpty(cdlg.FileName))
                File.WriteAllText(cdlg.FileName, General.db.Serialize(), Encoding.UTF8);

        }

        private void toolStripAddItem_Click(object sender, EventArgs e)
        {
            General.db.Add(new PRJsettings() { URL = "http://new entry" });
            bindSource.ResetBindings(false);
        }

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            General.db.Remove((PRJsettings)bindSource.Current);
            bindSource.ResetBindings(false);
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            if (bindSource.Current == null)
                txtURL.Text = "use list, context menu to add new entry";
        }

        private void txtPreview_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as TextBox).SelectAll();
        }



    }
}
