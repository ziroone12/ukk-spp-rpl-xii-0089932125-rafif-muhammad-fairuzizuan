using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_csharp.view
{
    public partial class FormRegistrasiPetugas : Form
    {
        public FormRegistrasiPetugas()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrEmpty(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtnamaPetugas.Text) ||
                string.IsNullOrWhiteSpace(txtKonfirmasiPasword.Text))
            {
                MessageBox.Show("Tidak boleh kosong");
            }if (txtPassword.Text != txtKonfirmasiPasword.Text)
            {
                MessageBox.Show("password anda tidak sesuai");
            }
            if (txtPassword.Text.Length<6)
            {
                MessageBox.Show("password tidak boleh lebih dari 6");
                
            }
        }
    }
}
