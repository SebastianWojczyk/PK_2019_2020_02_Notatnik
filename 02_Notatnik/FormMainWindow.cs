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

namespace _02_Notatnik
{
    public partial class FormMainWindow : Form
    {
        private string currentFileName = "";
        public FormMainWindow()
        {
            InitializeComponent();
            setFormText();
        }

        private void zakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentFileName = "";
            textBoxEditor.Text = "";
            setFormText();
        }
        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFileName = openFileDialog.FileName;
                textBoxEditor.Text = File.ReadAllText(openFileDialog.FileName);
                setFormText();
            }
        }
        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFileName == "")
            {
                zapiszJakoToolStripMenuItem_Click(null, null);
            }
            else
            {
                File.WriteAllText(currentFileName, textBoxEditor.Text);
            }
            setFormText();
        }
        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFileName = saveFileDialog.FileName;
                File.WriteAllText(currentFileName, textBoxEditor.Text);
            }
            setFormText();
        }
        private void setFormText()
        {
            if (currentFileName == "")
            {
                Text = "Nowy";
            }
            else
            {
                Text = Path.GetFileNameWithoutExtension(currentFileName);
            }
        }
        private void textBoxEditor_TextChanged(object sender, EventArgs e)
        {
            setFormText();
            Text += "*";
        }
        ConfigEditorDialog configEditorDialog = new ConfigEditorDialog();
        private void kofiguracjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configEditorDialog.ConfigBackColor = textBoxEditor.BackColor;
            configEditorDialog.ConfigFontColor = textBoxEditor.ForeColor;
            configEditorDialog.ConfigFont = textBoxEditor.Font;
            if (configEditorDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxEditor.BackColor = configEditorDialog.ConfigBackColor;
                textBoxEditor.ForeColor = configEditorDialog.ConfigFontColor;
                textBoxEditor.Font = configEditorDialog.ConfigFont;
            }
        }
    }
}
