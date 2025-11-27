using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactChackerAnalyzatorApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _btnTextFormEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
            TextForm textForm = new TextForm();
            textForm.ShowDialog();
            this.Show();
        }

        private void _btnLinkFormEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
            LinkForm linkForm = new LinkForm();
            linkForm.ShowDialog();
            this.Show();
        }
    }
}
