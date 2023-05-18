using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECTEMP02_MARCRAMILO.model;

namespace PROJECTEMP02_MARCRAMILO
{
    public partial class Formulari : Form
    {
        public Formulari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbPathFile.Text = "";
            OpenFileDialog opendDialog = new OpenFileDialog();
            opendDialog.Filter = "Filter XML (*xml) | *.xml";
            

            if (opendDialog.ShowDialog() == DialogResult.OK)
            {
                //NO S'HA DE FER NEW PERQUE ES STATIC
                dmc.carregarModel(opendDialog.FileName);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void tbPathFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
