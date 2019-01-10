using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.IO;
using System;

namespace Exercício1
{
    class RibbonPresenter
    {
        static private Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
        static private Word.Selection selecao = Globals.ThisAddIn.Application.Selection;

        private static string fullPath()
        {
            string sfileName_Document = doc.Name;
            string sPath = doc.Path;
            string sFullpath_pdf = sPath + "\\" + sfileName_Document + ".pdf";
            return sFullpath_pdf;
        }

        public static void savePDF()
        {
            try {
                doc.ExportAsFixedFormat(fullPath(), Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
                }
            catch (System.Runtime.InteropServices.COMException e)
            {
                MessageBox.Show("Verifique se seu arquivo está salvo em algum local válido!\n\n" + e.Message);
            }
        }

        public static void addImage()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\Netlex\Google Drive\Minhas automatizações\Outros";
                //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                selecao.Select();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selecao.InlineShapes.AddPicture(openFileDialog.FileName);
                }
            }
        }

        public static void inserirTabela()
        {
            TableConfigWindow tableconf = new TableConfigWindow();
            tableconf.Show();
        }

        public static void criarTabela(string ln, string cl, TableConfigWindow tableconf)
        {
            int linha, coluna;
            Int32.TryParse(ln, out linha);
            Int32.TryParse(cl, out coluna);
            
            Word.Range rg = Globals.ThisAddIn.Application.Selection.Range;
            var tab = doc.Tables.Add(rg, linha, coluna);

            try
            {
                tab.set_Style("Tabela com grade");
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                tab.set_Style("Table Grid 8");
                Console.WriteLine(e);
            }

            tableconf.Close();
        }

        public static void invertCase()
        {
            int start = doc.Application.Selection.Start;
            int end = doc.Application.Selection.End;
            //Word.Range rg = doc.Range(start, end);
            selecao.Select();
            string aux ="";
            foreach (char c in selecao.Text)
            {
                if (Char.IsLetter(c))
                {
                    if (Char.IsLower(c))
                    {
                        aux = aux + Char.ToUpper(c);
                    }
                    else aux = aux + Char.ToLower(c);
                    
                }
                else aux = aux + c;
            }
            selecao.TypeText(aux);
            doc.Range(start, end).Select();
        }

        /*public static void enable_disable_button()
        {
            
            var docObj = Globals.Factory.GetVstoObject(doc);
            docObj.SelectionChange += docObj_SelectionChange;
            

        }*/

        public static void adicionarSpan(string span)
        {
            selecao.Font.Subscript = 0;
            selecao.InsertBefore("[");
            selecao.InsertAfter("]");
            doc.Range(doc.Application.Selection.Start + 1, doc.Application.Selection.Start + 1).Select();
            selecao.InsertBefore(span);
            selecao.Font.Subscript = -1;
            doc.Range(selecao.Start - 1, selecao.Start - 1).Select();
        }
    }
}
