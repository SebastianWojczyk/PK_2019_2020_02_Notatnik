using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Notatnik
{
    public partial class ConfigEditorDialog : Form
    {
        public Color ConfigBackColor
        {
            set
            {
                buttonBackColor.BackColor = value;
                buttonFont.BackColor = value;
            }
            get
            {
                return buttonBackColor.BackColor;
            }
        }
        public Color ConfigFontColor
        {
            set
            {
                buttonFontColor.BackColor = value;
                buttonFont.ForeColor = value;
            }
            get
            {
                return buttonFontColor.BackColor;
            }
        }
        public Font ConfigFont
        {
            set
            {
                buttonFont.Font = value;
            }
            get
            {
                return buttonFont.Font;
            }
        }
        public ConfigEditorDialog()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            colorDialogBack.Color = ConfigBackColor;
            if (colorDialogBack.ShowDialog() == DialogResult.OK)
            {
                ConfigBackColor = colorDialogBack.Color;
            }
        }

        private void buttonFontColor_Click(object sender, EventArgs e)
        {
            colorDialogFont.Color = ConfigFontColor;
            if (colorDialogFont.ShowDialog() == DialogResult.OK)
            {
                ConfigFontColor = colorDialogFont.Color;
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            fontDialog.Font = ConfigFont;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                ConfigFont = fontDialog.Font;
            }
        }
    }
}
