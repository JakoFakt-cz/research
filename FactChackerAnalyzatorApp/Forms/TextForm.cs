using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactChackerAnalyzatorApp
{
    public partial class TextForm : Form
    {
        public TextForm()
        {
            InitializeComponent();
        }

        private void _btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _btnAnalyzate_Click(object sender, EventArgs e)
        {
            // TODO: AI analyzator
            MessageBox.Show("Analyzation feature is not implemented yet.");
        }
    }
}
