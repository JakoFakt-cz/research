using FactChackerAnalyzatorApp.Models;
using FactChackerAnalyzatorApp.Services;
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
        private readonly AiService _aiService;
        public TextForm()
        {
            InitializeComponent();

            _aiService = new AiService();

            _btnAnalyzateText.Click += AnalyzateTextClicked;
        }

        private void _btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void AnalyzateTextClicked(object? sender, EventArgs e)
        {
            _rtbOutput.Text = "Generuji odpověď...";

            var text = _rtbMainText.Text;

            var answer = await _aiService.BuildText(text);

            if (answer is null)
            {
                _rtbOutput.Text = "Chyba při načítání odpověďi";
                return;
            }

            _rtbOutput.Clear();
            _rtbOutput.Text = "\"=============== VÝSLEDEK =================== \n \n";

            _rtbOutput.AppendText($"Fake Score: {answer.FakeScore}/100 \n");
            _rtbOutput.AppendText($"Status: {answer.Status} \n");
            _rtbOutput.AppendText($"\nShrnutí: \n{answer.Shrnutí} \n");
            _rtbOutput.AppendText($"\nDůvody hodnocení: \n");
            foreach (var důvod in answer.Důvody)
            {
                _rtbOutput.AppendText($"- {důvod} \n");
            }
            _rtbOutput.AppendText($"\nOvěřené zdroje: \n");
            foreach (var zdroj in answer.Zdroje)
            {
                _rtbOutput.AppendText($"- {zdroj} \n");
            }
        }
    }
}
