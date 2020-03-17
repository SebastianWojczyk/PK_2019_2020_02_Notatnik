namespace _02_Notatnik
{
    partial class ConfigEditorDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBackColor = new System.Windows.Forms.Button();
            this.colorDialogBack = new System.Windows.Forms.ColorDialog();
            this.buttonFontColor = new System.Windows.Forms.Button();
            this.colorDialogFont = new System.Windows.Forms.ColorDialog();
            this.buttonFont = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(100, 103);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(126, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "Zatwierdź";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kolor tła";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kolor czcionki";
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.Location = new System.Drawing.Point(100, 4);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(126, 23);
            this.buttonBackColor.TabIndex = 3;
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // colorDialogBack
            // 
            this.colorDialogBack.FullOpen = true;
            // 
            // buttonFontColor
            // 
            this.buttonFontColor.Location = new System.Drawing.Point(100, 33);
            this.buttonFontColor.Name = "buttonFontColor";
            this.buttonFontColor.Size = new System.Drawing.Size(126, 23);
            this.buttonFontColor.TabIndex = 4;
            this.buttonFontColor.UseVisualStyleBackColor = true;
            this.buttonFontColor.Click += new System.EventHandler(this.buttonFontColor_Click);
            // 
            // colorDialogFont
            // 
            this.colorDialogFont.FullOpen = true;
            // 
            // buttonFont
            // 
            this.buttonFont.AutoSize = true;
            this.buttonFont.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFont.Location = new System.Drawing.Point(100, 62);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(58, 23);
            this.buttonFont.TabIndex = 5;
            this.buttonFont.Text = "Font test";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Czcionka";
            // 
            // ConfigEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 138);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.buttonFontColor);
            this.Controls.Add(this.buttonBackColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.Name = "ConfigEditorDialog";
            this.Text = "Konfiguracja edytora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBackColor;
        private System.Windows.Forms.ColorDialog colorDialogBack;
        private System.Windows.Forms.Button buttonFontColor;
        private System.Windows.Forms.ColorDialog colorDialogFont;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}