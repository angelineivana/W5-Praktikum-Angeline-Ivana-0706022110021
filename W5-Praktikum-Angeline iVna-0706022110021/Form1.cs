using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W5_Praktikum_Angeline_iVna_0706022110021
{
    public partial class FormMateri : Form
    {
        public static bool bisaWarna;
        public FormMateri()
        {
            InitializeComponent();
        }

        private void radioButtonMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (bisaWarna == true)
            {
                labelTextOutput.ForeColor = Color.Red;
            }
        }
        public static int tes = 0;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxShow.Items.Contains(textBoxInput.Text) == true)
            {
                MessageBox.Show("Input Kembar");
            }
            else
            {
                listBoxShow.Items.Add(textBoxInput.Text);
            }
            textBoxInput.Text = "";
        }

        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                bisaWarna = true;
            }
            else
            {
                bisaWarna = false;
                labelTextOutput.ForeColor = Color.Black;
            }
        }

        private void radioButtonBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (bisaWarna == true)
            {
                labelTextOutput.ForeColor = Color.Blue;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
            listBoxShow.Items.Clear();
            checkBoxAktif.Checked = false;
            radioButtonMerah.Checked = true;
            radioButtonBiru.Checked = false;
            bisaWarna = false;
            labelTextOutput.Text = "";
            labelTextOutput.ForeColor = Color.Black;
        }

        private void listBoxShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTextOutput.Text = listBoxShow.SelectedItem.ToString();
        }
    }
}
