using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class FontSettings : Form
    {
        public int FontSize = 0;
        public System.Drawing.FontStyle FontStyle = FontStyle.Regular;
        public bool isFontChanged = false;
        public FontSettings()
        {
            InitializeComponent();
            FontSizeBox.SelectedItem = FontSizeBox.Items[0];
            FontStyleBox.SelectedItem = FontStyleBox.Items[0];
        }

        private void FontSettings_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        }


        private void onFontSizeChanged(object sender, EventArgs e)
        {
            ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontSizeBox.SelectedItem.ToString()));
            FontSize = int.Parse(FontSizeBox.SelectedItem.ToString());
        }

        private void onFontStyleChanged(object sender, EventArgs e)
        {
            switch (FontStyleBox.SelectedItem.ToString())
            {
                case "звичайний":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontSizeBox.SelectedItem.ToString()),
                        FontStyle.Regular);
                    break;
                case "курсив":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontSizeBox.SelectedItem.ToString()),
                        FontStyle.Italic);
                    break;
                case "жирний":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontSizeBox.SelectedItem.ToString()),
                        FontStyle.Bold);
                    break;
                case "закреслення":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontSizeBox.SelectedItem.ToString()),
                        FontStyle.Strikeout);
                    break;
                case "підкреслення":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(FontSizeBox.SelectedItem.ToString()),
                        FontStyle.Underline);
                    break;
                    
            }
            FontStyle = ExampleText.Font.Style;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            isFontChanged = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isFontChanged = false;
            this.Hide();
        }
    }
}

