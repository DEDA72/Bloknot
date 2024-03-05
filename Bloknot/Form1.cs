using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloknot
{
    public partial class Form1 : Form
    {
        bool CheckedStripMenu = true;
        string FileName;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Новый файл";
            textBox.Size = new Size(this.Width - 15, this.Height - 85);
            Cancel.Enabled = false;
            Delete.Enabled = false;
            Copy.Enabled = false;
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            try
            {
                textBox.Text = "";
                fileDialog.Filter = "TXT |*.txt";
                fileDialog.Title = "Создание файла!";
                fileDialog.ShowDialog();
                if (fileDialog.FileName != null)
                {
                    this.Text = fileDialog.FileName;
                    FileName = fileDialog.FileName;

                    using (StreamWriter sw = File.CreateText(FileName))
                    {
                        sw.Write(textBox.Text);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            try
            {
                fileDialog.Filter = "TXT |*.txt";
                fileDialog.Title = "Открытие файла!";
                fileDialog.ShowDialog();
                if (fileDialog.FileName != null)
                {
                    this.Text = fileDialog.FileName;
                    using(StreamReader sw = File.OpenText(fileDialog.FileName))
                    {
                        string s = sw.ReadToEnd();
                        textBox.Text = s;
                    }
                    FileName = fileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileName != null)
                {
                    using (StreamWriter sw = File.CreateText(FileName))
                    {
                        sw.Write(textBox.Text);
                    }
                }
                else
                {
                    this.NewFile_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            textBox.Size = new Size(this.Width-15, this.Height-85);
        }

        private void Font_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
            textBox.Font = font.Font;
        }

        private void NewWindow_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DateAndTime_Click(object sender, EventArgs e)
        {
            textBox.Text += ' ' + DateTime.Now.ToString();
        }

        private void Progg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Kyryl Nazarets PV121!","Author",MessageBoxButtons.OK);
        }

        private void Strip_Click(object sender, EventArgs e)
        {
            if(CheckedStripMenu)
            {
                CheckedStripMenu = false;
                Strip.Checked = false;
                statusStrip1.Visible = false;
            }
            else
            {
                CheckedStripMenu = true;
                Strip.Checked = true;
                statusStrip1.Visible = true;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int q = textBox.Text.Length;

            toolStripStatusLabel1.Text = $"Символы {q}";
            if(q <= 1)
            {
                Cancel.Enabled = false;
                Delete.Enabled = false;
                Copy.Enabled = false;
            }
            else
            {
                Cancel.Enabled = true;
                Delete.Enabled = true;
                Copy.Enabled = true;
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void WYDall_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }
    }
}
