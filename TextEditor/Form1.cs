using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Archivos de texto(*.txt)|*.txt";
            dialogo.ShowDialog();
            if (dialogo.FileName != "")
            {
                StreamReader flujo = new StreamReader(dialogo.FileName);
                txtEditor.Text = flujo.ReadToEnd();
                flujo.Close();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Filter = "Archivos de texto(*.txt)|*.txt";
            dialogo.ShowDialog();
            if (dialogo.FileName != "")
            {
                StreamWriter flujo = new StreamWriter(dialogo.FileName);
                flujo.Write(txtEditor.Text);
                flujo.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
