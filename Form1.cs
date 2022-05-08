using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_thaydoimaunen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hsbRed_ValueChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            lblRed.Text = hsbRed.Value.ToString();

        }

        private void hsbGreen_ValueChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            lblGreen.Text = hsbGreen.Value.ToString();

        }

        private void hsbBlue_ValueChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            lblBlue.Text = hsbBlue.Value.ToString();

        }
    }
}
