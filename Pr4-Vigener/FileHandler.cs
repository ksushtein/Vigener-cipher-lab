using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr4_Vigener
{
    public class FileHandler
    {
        public void Save(string text)
        {
            SaveFileDialog sf1 = new SaveFileDialog();
            sf1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (sf1.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = sf1.FileName;
            System.IO.File.WriteAllText(fileName, text);
        }

        public string Open()
        {
            OpenFileDialog of1 = new OpenFileDialog();
            of1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (of1.ShowDialog() == DialogResult.Cancel)
                return "";
            string filename = of1.FileName;
            // читаем файл в строку
            return System.IO.File.ReadAllText(filename);
        }
    }
}
