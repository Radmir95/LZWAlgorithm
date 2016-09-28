using System;
using System.IO;
using System.Windows.Forms;
using LZWAlgorithm.Core;

namespace FormsUI
{
    public partial class LZWForm : Form
    {

        public LZWForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (typeOfAction.Text == "Архивировать" && strategyOfOutput.Text == "В окно")
            {
                Archivator.InputString = inputForm.Text;
                var dict = Archivator.Compress();
                var result = "";
                foreach (var dictKey in dict)
                {
                    result += dictKey.Value + " ";
                }
                outputForm.Text = result;
            }

            if (typeOfAction.Text == "Разархивировать" && strategyOfOutput.Text == "В окно")
            {
                    outputForm.Text = Archivator.Decompress();
            }

            if (typeOfAction.Text == "Архивировать" && strategyOfOutput.Text == "В файл")
            {

                Archivator.InputString = inputForm.Text;
                var dict = Archivator.Compress();
                var result = "";
                foreach (var dictKey in dict)
                {
                    result += dictKey.Value + " ";
                }
                System.IO.File.WriteAllText(@"H:\lzwTest\lzwcompressed.txt", result);

            }
            if (typeOfAction.Text == "Архивировать" && strategyOfOutput.Text == "В бинарный")
            {
                Archivator.InputString = inputForm.Text;
                var dict = Archivator.Compress();
                var result = "";
                foreach (var dictKey in dict)
                {
                    result += dictKey.Value + " ";
                }
                using (var writer = new BinaryWriter(File.Open(@"H:\lzwTest\binnarycompressed.stg", FileMode.Create)))
                {
                    writer.Write(result);
                }
            }
        }
    }
}
