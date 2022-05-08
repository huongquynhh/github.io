using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_font
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdoXanh_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoXanh.Checked)
            {
                txtnhapten.ForeColor= Color.Blue;
            }    

        }

        private void rdoDo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDo.Checked)
            {
                txtnhapten.ForeColor = Color.Red;
            }


        }

        private void rdoVang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVang.Checked)
            {
                txtnhapten.ForeColor = Color.Yellow;
            }
        }

        private void rdoTim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTim.Checked)
            {
                txtnhapten.ForeColor = Color.Purple;
            }
        }

        private void ckbBold_CheckedChanged(object sender, EventArgs e)
        {
            if( ckbBold.Checked)
            {
                txtnhapten.Font = new Font(txtnhapten.Font, txtnhapten.Font.Style | FontStyle.Bold);

            }
        }

        private void ckbItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbItalic.Checked)
            {
                txtnhapten.Font = new Font(txtnhapten.Font, txtnhapten.Font.Style | FontStyle.Italic);

            }
        }

        private void ckbStrikeout_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbStrikeout.Checked)
            {
                txtnhapten.Font = new Font(txtnhapten.Font, txtnhapten.Font.Style | FontStyle.Strikeout);

            }
        }

        private void ckbUnderLine_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbUnderLine.Checked)
            {
                txtnhapten.Font = new Font(txtnhapten.Font, txtnhapten.Font.Style | FontStyle.Underline);

            }
        }

        private void rdoVnTime_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoVnTime.Checked)
            {
                txtnhapten.Font = new Font("VnTime", 10);
            }    
        }

        private void rdoVnUniverse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVnUniverse.Checked)
            {
                txtnhapten.Font = new Font("VnUniverse", 10);
            }
        }

        private void rdoVnVogue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVnVogue.Checked)
            {
                txtnhapten.Font = new Font("VnVogue", 10);
            }
        }

        private void rdoTahoma_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTahoma.Checked)
            {
                txtnhapten.Font = new Font("Tahoma", 10);
            }
        }
    }

}
