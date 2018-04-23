using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        DataTable tbl;

        UploadHelper helper;

        public UploadedFile CurrentFile
        {
            get { return helper == null ? null : helper.CurrentFile; }
        }
    
        public Form1()
        {
            InitializeComponent();
            DataTable table = CreateTable();
            gridControl1.DataSource = table;
            helper = new UploadHelper(table);
            helper.CurrentFileChanged += helper_CurrentFileChanged;
            repositoryItemButtonEdit1.ButtonClick += repositoryItemButtonEdit1_ButtonClick;
        }

        void helper_CurrentFileChanged(object sender, EventArgs e)
        {
            UpdateHyperLink();
        }

        public DataTable CreateTable()
        {
            tbl = new DataTable();
            tbl.Columns.Add("FileName", typeof(string));
            tbl.Columns.Add("FileSize", typeof(int));
            tbl.Columns.Add("FileContent", typeof(object));
            return tbl;
        }


        void UpdateHyperLink()
        {
            if (helper.CurrentFile == null)
            {
                hyperLinkEdit1.Enabled = false;
                hyperLinkEdit1.Text = "No file chosen";
            }
            else
            {
                hyperLinkEdit1.Enabled = true;
                hyperLinkEdit1.Text = String.Format("{0} ({1})", CurrentFile.FullPath, CurrentFile.FileSize);
            }
        }


        UploadedFile GetFocusedFile()
        {
            DataRow dataRow =gridView1.GetFocusedDataRow();
            if (dataRow == null)
            {
                helper.PostNewFile(-1);
                return GetFocusedFile();
            }
            return new UploadedFile((byte[])dataRow["FileContent"], (string)dataRow["FileName"]);
        }

        void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    GetFocusedFile().OpenFile();
                    break;
                case 1:
                    helper.PostNewFile(gridView1.GetFocusedDataSourceRowIndex());
                    gridView1.UpdateCurrentRow();
                    break;
            }
        }
    
        private void btOpenFile_Click(object sender, EventArgs e)
        {
            helper.ChooseFile();
        }

        private void btUploadFile_Click(object sender, EventArgs e)
        {
            helper.UploadFile();
        }
    }
}