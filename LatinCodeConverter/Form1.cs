using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using net.uyghurdev.Text;
using System.IO;

namespace LatinCodeConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ئۇيغۇرچىدىن لاتىنچىغا
        /// </summary>
        private void UEY2ULY()
        {
                    CodeConvert cc = new CodeConvert(LatinCodeConverter.Properties.Resources.UEY2ULY);
            txtLatin.Text = cc.ToConvert(txtUyghur.Text);

        }

        /// <summary>
        /// لاتىنچىدىن ئۇيغۇرچىغا
        /// </summary>
        private void ULY2UEY()
        { 
                    CodeConvert cc = new CodeConvert(LatinCodeConverter.Properties.Resources.ULY2UEY);
            txtUyghur.Text = cc.ToConvert(txtLatin.Text);

        }
        private void btnLatin2UyghurConvert_Click(object sender, EventArgs e)
        {
            ULY2UEY();
        }

        private void btnUyghur2LatinConvert_Click(object sender, EventArgs e)
        {
            UEY2ULY();
        }

        private void changeUyghurFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = txtUyghur.Font;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtUyghur.Font = fd.Font;
            }
        }

        private void changeLatinFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = txtLatin.Font;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtLatin.Font = fd.Font;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtLatin.Text = string.Empty;
            txtUyghur.Text = string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((txtUyghur.SelectedText.Length>0) || (txtLatin.SelectedText.Length>0l))
            {
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
            }
            else
            {
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;

            }
            if (Clipboard.GetText().Length > 0)
            {
                pastToolStripMenuItem.Enabled = true;
            }
            else
            {
                pastToolStripMenuItem.Enabled = false;
            }
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtLatin.ContainsFocus)
            {
                txtLatin.Paste();
            }
            else if (txtUyghur.ContainsFocus)
            {
                txtUyghur.Paste();
            }
        }

        private void copyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (txtLatin.SelectionLength > 0)
            {
                Clipboard.SetText(txtLatin.SelectedText);
            }
            else if (txtUyghur.SelectionLength > 0)
            {
                Clipboard.SetText(txtUyghur.SelectedText);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtLatin.SelectionLength > 0)
            {
                Clipboard.SetText(txtLatin.SelectedText);
                txtLatin.SelectedText = "";
            }
            else if (txtUyghur.SelectionLength > 0)
            {
                Clipboard.SetText(txtUyghur.SelectedText);
                txtUyghur.SelectedText = "";
            }
        }

       
        private void uyghurToLatinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UEY2ULY();
        }

       
        private void latinToUyghurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ULY2UEY();
        }

        private void openUyghurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Text File *.txt|*.txt";
            if (od.ShowDialog() == DialogResult.OK)
            {
               txtUyghur.Text= ReadText(od.FileName);
            }
        }

        /// <summary>
        /// تېكست ئوقۇش
        /// </summary>
        /// <param name="strFileName"></param>
        /// <returns></returns>
        private string ReadText(string strFileName)
        {
            StreamReader sr = new StreamReader(strFileName, Encoding.Default);
            return sr.ReadToEnd() ;
        }

        /// <summary>
        /// تېكست يېزىش
        /// </summary>
        /// <param name="strFileName"></param>
        /// <param name="strText"></param>
        private void WriteText(string strFileName, string strText)
        {
            StreamWriter sw = new StreamWriter(strFileName, false, Encoding.UTF8);
            sw.Write(strText);
            sw.Close();
        }

        private void openLatinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Text File *.txt|*.txt";
            if (od.ShowDialog() == DialogResult.OK)
            {
                txtLatin.Text = ReadText(od.FileName);
            }

        }

        private void saveUyghurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Text File *.txt|*.txt";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                WriteText(sd.FileName, txtUyghur.Text);
            }
        }

        private void saveLatinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Text File *.txt|*.txt";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                WriteText(sd.FileName, txtLatin.Text);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmA = new frmAbout();
            frmA.ShowDialog();
        }
       
    }
}
