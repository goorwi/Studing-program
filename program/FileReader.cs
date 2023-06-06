using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using Microsoft.Office.Interop.Word;
using Microsoft.Win32;
using System.Windows.Xps.Packaging;
using System.Windows.Xps.Serialization;
using System.Windows.Documents;
using System.Windows.Markup;

namespace program
{
    class FileReader
    {
        private RichTextBox rtb;
        private tabPanel tp;
        public FileReader(RichTextBox _rtb, tabPanel _tp)
        {
            tp = _tp;
            rtb = _rtb;
            Init();
        }
        private void Init()
        {
            string path = Directory.GetCurrentDirectory();
            switch (tp)
            {
                case tabPanel.start:
                    {
                        path += @"\start.rtf";
                        break;
                    }
                case tabPanel.test:
                    {
                        path += @"\testing.rtf";
                        break;
                    }
                case tabPanel.unit:
                    {
                        path += @"\unit.rtf";
                        break;
                    }
                case tabPanel.integration:
                    {
                        path += @"\integration.rtf";
                        break;
                    }
                case tabPanel.prepare:
                    {
                        path += @"\prepare.rtf";
                        break;
                    }
                case tabPanel.unitTesting:
                    {
                        path += @"\unit-testing.rtf";
                        break;
                    }
                case tabPanel.end:
                    {
                        path += @"\end.rtf";
                        break;
                    }
            }

            TextRange t = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                if (Path.GetExtension(path).ToLower() == ".rtf")
                {
                    t.Load(fs, DataFormats.Rtf);
                }
            }
        }
    }
}
