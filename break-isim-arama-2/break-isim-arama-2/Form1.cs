using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace break_isim_arama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtİsim.Text;
            bool kontrol=false;
            for (int i = 0; i < lstİsim.Items.Count; i++)
            {
                if (aranan == lstİsim.Items[i].ToString())
                {
                   kontrol = true;
                    break;
                }
            }

            if (sayac == 0)
            {
                MessageBox.Show("Öğrenci Bulunamadı.");
            }
            else
            {
                MessageBox.Show(sayac + " adet öğrenci bulundu");
            }

        }
    }
}
