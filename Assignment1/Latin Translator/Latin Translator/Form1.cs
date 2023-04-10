using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latin_Translator
{
    public partial class Latin_Translator1 : Form
    {
        public Latin_Translator1()
        {
            InitializeComponent();
        }

        private void exempli_gratisbutton_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "for example";
        }

        private void quid_pro_quobutton_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Something for Something";
        }

        private void ille_estbutton_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "that is";
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            labelOutput.Text = string.Empty;
        }

        private void English_Translatorlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
