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
    public class UploadHelper
    {
        public event EventHandler CurrentFileChanged;

        private DataTable _DataSource;
        public DataTable DataSource
        {
            get { return _DataSource; }
            set { _DataSource = value; }
        }


        public UploadHelper(DataTable dataSource)
        {
            _DataSource = dataSource;
        }

        private UploadedFile _CurrentFile;
        public UploadedFile CurrentFile
        {
            get { return _CurrentFile; }
            set { _CurrentFile = value; OnCurrentFileChanged(); }
        }

        private void OnCurrentFileChanged()
        {
            if (CurrentFileChanged != null)
                CurrentFileChanged(this, EventArgs.Empty);
        }

        public void UploadFile()
        {
            UploadFile(-1);
        }
        public void UploadFile(int dataSourceRowIndex)
        {
            if (CurrentFile != null)
            {
                object[] values = new object[] { CurrentFile.FileName, CurrentFile.FileSize, CurrentFile.FileContent };
                if (dataSourceRowIndex < -1)
                    DataSource.Rows.Add(values);
                else
                    DataSource.Rows[dataSourceRowIndex].ItemArray = values;
            }
            CurrentFile = null;
        }

        public void ChooseFile()
        {
            if (CurrentFile != null)
            {
                MessageBox.Show(String.Format("Please upload the{0} file", CurrentFile.FileName));
                return;
            }
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                CurrentFile = new UploadedFile(fd.FileName);
            }

        }

        public void PostNewFile(int dataSourceRowIndex)
        {
            ChooseFile();
            UploadFile(dataSourceRowIndex);
        }
    }
}
