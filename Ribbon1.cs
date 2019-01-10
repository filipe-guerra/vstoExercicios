using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace Exercício1
{
    public partial class Ribbon1
    {
        private FindPanelPresenter myUserControl;
        private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            myUserControl = new FindPanelPresenter();
            myCustomTaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(myUserControl, "Find and Replace");
            myCustomTaskPane.Visible = false;
        }

        private void btnSave_as_PDF_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.savePDF();
        }

        private void AddImage_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.addImage();
        }

        private void insTabela_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.inserirTabela();
        }

        private void invertCase_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.invertCase();
        }

        private void findReplace_Click(object sender, RibbonControlEventArgs e)
        {
            myCustomTaskPane.Visible = !myCustomTaskPane.Visible;
        }

        private void addSpan_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.criarSpanForm();
        }

        private void addField_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.criarFieldForm();
        }

        private void qualificacaoPJ_Click(object sender, RibbonControlEventArgs e)
        {
            RibbonPresenter.criarQualificacaoForm();
        }
    }
}
