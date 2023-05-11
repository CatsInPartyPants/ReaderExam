using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using EpubSharp;

namespace ReaderExam
{
    
    internal class GetStringsFromFile
    {
        string fileContent;
        string filePath;
        OpenFileDialog ofd;

        public GetStringsFromFile()
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt; *.docx; *.rtf; *.epub;)|*.txt; *.docx; *.rtf; *.epub";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            fileContent = string.Empty;
            filePath = string.Empty;
            ofd.InitialDirectory = "c:\\";
        }

        public string OpenFile()
        {
            string totalText = string.Empty;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                try
                {
                    string[] temp = ofd.FileName.Split('.');

                    //open, read docx file and send back all text 
                    if (temp[1] == "docx")
                    {
                        Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                        object miss = System.Reflection.Missing.Value;
                        object path = filePath;
                        object readOnly = true;
                        
                        Document doc = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss
                            , ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss
                            , ref miss, ref miss, ref miss, ref miss, ref miss);

                        foreach (Paragraph p in doc.Paragraphs)
                        {
                            totalText += p.Range.Text.ToString();
                        }
                    }
                    //open, read txt file and send back all text 
                    else if (temp[1] == "txt")
                    {
                        
                        var fileStream = ofd.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            totalText = reader.ReadToEnd();

                        }
                    }
                    //open, read rtf file and send back all text 
                    else if (temp[1] == "rtf")
                    {
                        RichTextBox rtb = new RichTextBox();
                        try
                        {
                            rtb.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                            totalText = rtb.Text;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error GetStringsFromFile module");
                        }
                    }
                    else if (temp[1] == "epub")
                    {
                        EpubBook book = EpubReader.Read(ofd.FileName);
                        totalText = book.ToPlainText();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error GetStringsFromFile module");
                }
            }
            return totalText;
        }
    }
}
