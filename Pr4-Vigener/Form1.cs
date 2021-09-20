using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr4_Vigener
{
    public partial class Form1 : Form
    {
        Vigener v;
        FileHandler fh;
        public Form1(Vigener v1, FileHandler f)
        {
            v = v1;
            fh = f;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cbLanguage.Items.Count == 0)
            {
                cbLanguage.Items.Add("Русский");
                cbLanguage.Items.Add("Английский");
            }
            cbLanguage.SelectedIndex = 0;
            tbKeyWord.Text = "ЛАЙМ";
            tbKeyNums.Text = "2 3 1 0";
            rtbTextNums.Text = "АХ КАК МНЕ ЗДОРОВО";
            rtbTextWord.Text = "АХ КАК МНЕ ЗДОРОВО";
        }

        private void btnEncodeText_Click(object sender, EventArgs e)
        {
            if (cbLanguage.SelectedItem.ToString() == "Русский")
                rtbResWord.Text = v.Encrypt(Language.Русский, rtbTextWord.Text, tbKeyWord.Text);

            if (cbLanguage.SelectedItem.ToString() == "Английский")
                rtbResWord.Text = v.Encrypt(Language.Английский, rtbTextWord.Text, tbKeyWord.Text);
        }

        private void btnDecodeText_Click(object sender, EventArgs e)
        {
            if (cbLanguage.SelectedItem.ToString() == "Русский")
                rtbResWord.Text = v.Decrypt(Language.Русский, rtbTextWord.Text, tbKeyWord.Text);

            if (cbLanguage.SelectedItem.ToString() == "Английский")
                rtbResWord.Text = v.Decrypt(Language.Английский, rtbTextWord.Text, tbKeyWord.Text);
        }

        private void btnEncodeNums_Click(object sender, EventArgs e)
        {
            int[] nums = Array.ConvertAll(tbKeyNums.Text.Split(), int.Parse);

            if (cbLanguage.SelectedItem.ToString() == "Русский")
                rtbResNums.Text = v.Encrypt(Language.Русский, rtbTextNums.Text, nums);

            if (cbLanguage.SelectedItem.ToString() == "Английский")
                rtbResNums.Text = v.Encrypt(Language.Английский, rtbTextNums.Text, nums);
        }

        private void btnDecodeNums_Click(object sender, EventArgs e)
        {
            int[] nums = Array.ConvertAll(tbKeyNums.Text.Split(), int.Parse);

            if (cbLanguage.SelectedItem.ToString() == "Русский")
                rtbResNums.Text = v.Decrypt(Language.Русский, rtbTextNums.Text, nums);

            if (cbLanguage.SelectedItem.ToString() == "Английский")
                rtbResNums.Text = v.Decrypt(Language.Английский, rtbTextNums.Text, nums);
        }

        private void btnLoadWord_Click(object sender, EventArgs e)
        {
            rtbTextWord.Text = fh.Open();
        }

        private void btnLoadNums_Click(object sender, EventArgs e)
        {
            rtbTextNums.Text = fh.Open();
        }

        private void btnSaveWord_Click(object sender, EventArgs e)
        {
            fh.Save(rtbResWord.Text);
        }

        private void btnSaveNums_Click(object sender, EventArgs e)
        {
            fh.Save(rtbResNums.Text);
        }

        #region Блок отвечающий за изменение данных
        private void tbKeyWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            LangCheck(sender, e);
        }

        private void rtbTextWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            LangCheck(sender, e);
        }

        private void rtbTextNums_KeyPress(object sender, KeyPressEventArgs e)
        {
            LangCheck(sender, e);
        }

        private void tbKeyNums_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
                return;
            }           
        }

        private void LangCheck(object sender, KeyPressEventArgs e)
        {
            if (cbLanguage.SelectedItem.ToString() == "Русский")
            {
                if (!(e.KeyChar >= 'А' && e.KeyChar <= 'Я') && !(e.KeyChar >= 'а' && e.KeyChar <= 'я') && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                {
                    e.Handled = true;
                    return;
                }
            }
            else
            {
                if (!(e.KeyChar >= 'A' && e.KeyChar <= 'Z') && !(e.KeyChar >= 'a' && e.KeyChar <= 'z') && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        #endregion

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbTextNums.Clear();
            rtbTextWord.Clear();
            tbKeyWord.Text = "";
        }
    }
}
