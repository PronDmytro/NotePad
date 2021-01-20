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

namespace NotePad
{
    public partial class Form1 : Form
    {
        public int FontSize = 0;
        public System.Drawing.FontStyle FontStyle = FontStyle.Regular;

        public string FileName;
        public bool isFileChanged;

        public FontSettings FontSettings;

        public Form1()
        {
            InitializeComponent();
            Init();

        }
        
        public void Init()
        {
            FileName = "";
            isFileChanged = false;
            UpdateTextWithTitle();
        }

        public void CreateNewDocument(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            textBox1.Text = "";
            FileName = "";
            isFileChanged = false;
            UpdateTextWithTitle();
        }

        public void OpenFile(object sender, EventArgs e)
        {
            SaveUnsavedFile();
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    FileName = openFileDialog1.FileName;
                    isFileChanged = false;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Неможливо відкрити файл!");
                }
            }

            UpdateTextWithTitle();
        }

        public void SaveFile(string _filename)
        {
            if (_filename == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                }
            }

            try
            {
                StreamWriter sw = new StreamWriter(_filename + ".txt");
                sw.Write(textBox1.Text);
                FileName = _filename;
                sw.Close();
                isFileChanged = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Неможливо зберегти файл!");
            }
            
        }

        public void Save(object sender, EventArgs e)
        {
            SaveFile(FileName);
        }
        public void SaveAs(object sender, EventArgs e)
        {
            SaveFile("");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (isFileChanged) return;
            this.Text = this.Text.Replace("*", "");
            isFileChanged = true;
            this.Text = "*" + this.Text;
        }

        public void UpdateTextWithTitle()
        {
            if(FileName!="")
                this.Text = FileName + ": NotePad";
            else
                this.Text = FileName + "NoName: NotePad";
        }

        public void SaveUnsavedFile()
        {
            if (isFileChanged)
            {
                DialogResult result = MessageBox.Show("Зберегти зміни, внесені до файлу " + FileName,"Зберегти",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(FileName);
                }
            }
        }

        public void CopyText()
        {
            Clipboard.SetText(textBox1.SelectedText);
        }
        public void CutText()
        {
            Clipboard.SetText(textBox1.Text.Substring(textBox1.SelectionStart, textBox1.SelectionLength));
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
        }
        public void PasteText()
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.SelectionStart) + Clipboard.GetText() +
                            textBox1.Text.Substring(textBox1.SelectionStart,
                                textBox1.Text.Length - textBox1.SelectionStart);
        }

        public void DeleteText()
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
        }
        private void onCopyClick(object sender, EventArgs e)
        {
            CopyText();
        }

        private void onCutClick(object sender, EventArgs e)
        {
            CutText();
        }

        private void onPasteClick(object sender, EventArgs e)
        {
            PasteText();
        }

        private void onDelClick(object sender, EventArgs e)
        {
            DeleteText();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUnsavedFile();
        }

        private void onFontClick(object sender, EventArgs e)
        {
            FontSettings = new FontSettings();
            FontSettings.Show();
        }

        private void OnFocus(object sender, EventArgs e)
        {
            if (FontSettings != null&& FontSettings.isFontChanged)
            {
                FontSize = FontSettings.FontSize;
                FontStyle = FontSettings.FontStyle;
                textBox1.Font = new Font(textBox1.Font.FontFamily, FontSize, FontStyle);

                FontSettings.Close();
            }
        }

        private void onExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Розроблено спеціально на замовлення від КМРФ ДУІТ." +
                                                  "\nЗа деталями писати: pron.dmytro@kmrf.kiev.ua", "Довідка",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
