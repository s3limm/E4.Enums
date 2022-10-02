using E4.Enums.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E4.Enums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDisfficulty.Items.Add(Difficulty.Easy);
            cmbDisfficulty.Items.Add(Difficulty.Medium);
            cmbDisfficulty.Items.Add(Difficulty.Hard);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            User game = new User();
            game.userName = txtUserName.Text;

            if(string.IsNullOrEmpty(game.userName))
            {
                MessageBox.Show("Lütfen kullanıcı adınızı giriniz.");
                txtUserName.Focus();
            }
            else 
            {
                return;
            }

            if(rbMale.Checked)
            {
                game.gender = Gender.Male; 
            }
            else if (rbFemale.Checked)
            {
                game.gender = Gender.Female;
            }
            else
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz.");
            }

        }
    }
}
