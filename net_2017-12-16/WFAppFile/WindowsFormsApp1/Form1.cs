using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.DefaultExt = "txt";
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Clear();
                    toolStripStatusLabel1.Text = dialog.FileName;
                    toolStripStatusLabel1.Visible = true;
                    richTextBox1.AppendText(File.ReadAllText(dialog.FileName));
                }
            }
        }

        private void safeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.DefaultExt = "txt";
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, richTextBox1.Text);
                    toolStripStatusLabel1.Text = dialog.FileName;
                    toolStripStatusLabel1.Visible = true;
                }
            }
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.DefaultExt = "txt";
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Clear();
                    toolStripStatusLabel1.Text = dialog.FileName;
                    toolStripStatusLabel1.Visible = true;
                    FileInfo file = new FileInfo(dialog.FileName);
                    using (StreamReader sr = file.OpenText())
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            richTextBox1.AppendText(s+"\n");
                        }                        
                    }                        
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.DefaultExt = "txt";
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(dialog.FileName);
                    using (StreamWriter sw = file.CreateText())
                    {
                        foreach(string s in richTextBox1.Lines)
                        {
                            sw.WriteLine(s);
                        }
                    }
                }
            }
        }



        private void sAveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.DefaultExt = "txt";
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(dialog.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            foreach (string s in richTextBox1.Lines)
                            {
                                sw.WriteLine(s);
                            }
                        }
                    }
                }
            }
        }

        private void loadToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.DefaultExt = "txt";
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Clear();
                    toolStripStatusLabel1.Text = dialog.FileName;
                    toolStripStatusLabel1.Visible = true;

                    using (FileStream fs = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            richTextBox1.AppendText(sr.ReadToEnd());
                        }
                    }
                }
            }
        }

        private void loadToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.DefaultExt = "txt";
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Clear();
                    toolStripStatusLabel1.Text = dialog.FileName;
                    toolStripStatusLabel1.Visible = true;

                    using (FileStream fs = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        byte[] b = new byte[fs.Length];
                        UTF8Encoding temp = new UTF8Encoding(true);
                        while (fs.Read(b, 0, b.Length) > 0)
                        {
                            richTextBox1.AppendText(temp.GetString(b)+"\n");
                        }

                    }
                }
            }
        }


        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.DefaultExt = "txt";
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(dialog.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        foreach (string s in richTextBox1.Lines)
                        {
                            AddText(fs, s + "\n");
                        }
                    }
                }
            }
        }
    }
}
