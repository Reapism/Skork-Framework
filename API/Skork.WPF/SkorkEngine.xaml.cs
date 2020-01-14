using Skork.Language.Parse;
using Skork.Language.Parse.Cleaner;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace Skork.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SkorkEngine : System.Windows.Window
    {
        public SkorkEngine()
        {
            InitializeComponent();
        }

        private IEnumerable<string> GetPotentialCode()
        {
            var range = new TextRange(richTextCode.Document.ContentStart, richTextCode.Document.ContentEnd);
            var lines = range.Text;

            List<string> lstCode = new List<string>()
            {
                range.Text
            };

            return lstCode;
        }

        private void menuCompile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuClean_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuParse_Click(object sender, RoutedEventArgs e)
        {
            var parser = new SkorkSRFParser(GetPotentialCode());
            var parsedCode = parser.Parse();

            foreach (var line in parsedCode)
            {
                MessageBox.Show(line);
            }
        }

        private void menuCustom_Click(object sender, RoutedEventArgs e)
        {
            var action = new Action(() =>
            {

            });
        }

        private void menuGetPotentialCodeLines_Click(object sender, RoutedEventArgs e)
        {
            var parsedCode = SRFGetPotentialCodeLines.GetPotentialCodeStatements(GetPotentialCode());
            foreach (var line in parsedCode)
            {
                MessageBox.Show(line);
            }
        }
    }
}
