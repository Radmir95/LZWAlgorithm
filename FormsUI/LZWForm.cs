using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (typeOfAction.Text == "Архивировать")
            {
                Archivator.InputString = inputForm.Text;
                outputForm.Text = Archivator.Compress();
            }

            if (typeOfAction.Text == "Разархивировать")
            {
               
                    outputForm.Text = Archivator.Decompress();

            }
        }
    }
}
