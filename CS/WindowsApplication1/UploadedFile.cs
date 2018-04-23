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
    public class UploadedFile
    {
        private string tempDirectory = "C:\\";

        private string _FileName;
        public string FileName
        {
            get { return _FileName; }
        }

        private string _FullPath;
        public string FullPath
        {
            get { return _FullPath; }
            set { _FullPath = value; }
        }

        public long FileSize
        {
            get { return FileContent.Length; }
        }

        private byte[] _File;
        public byte[] FileContent
        {
            get { return _File; }
        }

        private void ReadFile(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                _File = new byte[stream.Length];
                stream.Read(FileContent, 0, (int)stream.Length);
                stream.Close();
            }
        }


        private static void ReadWriteStream(byte[] buffer, Stream writeStream)
        {
            writeStream.Write(buffer, 0, buffer.Length);    
            writeStream.Close();
        }

        private byte[] GetContent(FileStream fileContent )
        {
            byte[] result = new byte[FileSize];
            fileContent.Read(result, 0, (int)FileSize);
            fileContent.Close();
            return result;
        }

 

        private static void WriteFile(string filePath, byte[] content)
        {
            using (FileStream writeStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                ReadWriteStream(content, writeStream);
                writeStream.Close();
            }
        }

        public void OpenFile()
        {
            Process.Start(FullPath);
        }

        public UploadedFile(string filePath)
        {
            ReadFile(filePath);
            _FileName = Path.GetFileName(filePath);
            _FullPath = filePath;
        }


        public UploadedFile(byte[] content, string fileName)
        {
            _FullPath = tempDirectory + fileName;
            WriteFile(FullPath , content);
            _FileName = fileName;

        }
    }
}
