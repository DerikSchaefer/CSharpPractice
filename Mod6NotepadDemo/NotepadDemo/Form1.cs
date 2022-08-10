using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NotepadDemo
{
    public partial class Form1 : Form
    {

        string filepath;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
            saveToolStripMenuItem.Enabled = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files(*.txt)|*.txt";
            openFileDialog.Title = "Open text Files";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != string.Empty)
            {
                filepath = openFileDialog.FileName;
                richTextBox1.Text = File.ReadAllText(filepath);
            }
            saveToolStripMenuItem.Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(filepath))
            {
                File.WriteAllText(filepath, richTextBox1.Text); 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = false;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            SaveFileDialog saveFileDiaglog = new SaveFileDialog();
            saveFileDiaglog.Filter = "Text files(*.txt)|*.txt";
            var result = saveFileDiaglog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Stream stream = saveFileDiaglog.OpenFile();
                StreamWriter streamWriter = new StreamWriter(stream);
                streamWriter.WriteLine(richTextBox1.Text);
                streamWriter.Close();
                stream.Close();
                saveToolStripMenuItem.Enabled = true;
            }
            else if (result == DialogResult.Cancel)
            {
                
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            this.Text = Clipboard.GetText();
        }
    }
}
