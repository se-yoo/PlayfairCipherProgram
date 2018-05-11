using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3510_encryptionTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            encKeyInput.Select();
        }

        private void enc_bt_Click(object sender, EventArgs e)
        {
            if(this.encKeyInput.Text==""||this.textInput.Text=="")
            {
                MessageBox.Show("내용을 입력해주세요");
            }
            Encrypt enc = new Encrypt(this.encKeyInput.Text, this.textInput.Text);
            enc.textRelocation(); enc.makeEncpan();
            this.reorgText.Text = enc.getTextRelocSpace();
            this.encpan.Text = enc.getEncpanEnter();
            this.encText.Text = enc.encryption();
        }

        private void dec_bt_Click(object sender, EventArgs e)
        {
            Encrypt enc = new Encrypt(this.encKeyInput.Text, this.textInput.Text);
            enc.textRelocation(); enc.makeEncpan();
            this.decText.Text = enc.decode();
        }
    }
}
