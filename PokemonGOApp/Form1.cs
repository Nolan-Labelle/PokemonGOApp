using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGOApp
{
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }

        private void Output1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox CB = (ComboBox)sender;
            if (CB.SelectedIndex != -1)
            {
                pokemon2.Visible = true;
                candies2.Visible = true;
                equals2.Visible = true;
                output2.Visible = true;
            }
        }

        private void pokemon2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox CB = (ComboBox)sender;
            if (CB.SelectedIndex != -1)
            {
                pokemon3.Visible = true;
                candies3.Visible = true;
                equals3.Visible = true;
                output3.Visible = true;
            }
        }

        private void pokemon3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox CB = (ComboBox)sender;
            if (CB.SelectedIndex != -1)
            {
                pokemon4.Visible = true;
                candies4.Visible = true;
                equals4.Visible = true;
                output4.Visible = true;
            }
        }

        private void pokemon4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox CB = (ComboBox)sender;
            if (CB.SelectedIndex != -1)
            {
                pokemon5.Visible = true;
                candies5.Visible = true;
                equals5.Visible = true;
                output5.Visible = true;
            }
        }

        private void pokemon5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox CB = (ComboBox)sender;
            if (CB.SelectedIndex != -1)
            {
                pokemon6.Visible = true;
                candies6.Visible = true;
                equals6.Visible = true;
                output6.Visible = true;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (pokemon1.SelectedIndex != -1)
            {
                output1.Text = "" + pokemon1.SelectedIndex;
            }
        }
    }
}
