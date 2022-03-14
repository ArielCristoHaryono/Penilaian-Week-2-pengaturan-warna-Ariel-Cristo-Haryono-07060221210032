using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penilaian_Week_2_pengaturan_warna
{
    public partial class FormPengaturanWarna : Form
    {
        public FormPengaturanWarna()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "warna")
            {
                Random random = new Random();
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                lblOutput.ForeColor = color;
            }
            if (txtInput.Text == "kecilkan")
            {
                txtInput.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                lblOutput.Text = txtInput.Text;
            }

            if (txtInput.Text == "besarkan")
            {
                txtInput.Font = new Font("Times New Roman", 30, FontStyle.Bold);
                lblOutput.Text = txtInput.Text;
            }
            if (txtInput.Text == "restart")
            {
                clear();
            }
            void clear()
            {
                txtInput.Clear();
            }
        }
    }
}
