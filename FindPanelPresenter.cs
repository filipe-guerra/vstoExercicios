using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício1
{
   
    public partial class FindPanelPresenter : UserControl
    {

        public FindPanelPresenter()
        {
            InitializeComponent();
        }

        private void MyUserControl_Load(object sender, EventArgs e)
        {
        }

        private void findNext_Click(object sender, EventArgs e)
        {
           FindPanel.findNext(findBox.Text, checkBoxCase.Checked);
        }

        private void replaceAll_Click(object sender, EventArgs e)
        {
            FindPanel.replaceAll(findBox.Text, replaceBox.Text, checkBoxCase.Checked);
        }

        private void replace_Click(object sender, EventArgs e)
        {
            FindPanel.replace(findBox.Text, replaceBox.Text, checkBoxCase.Checked);
        }
    }
}
