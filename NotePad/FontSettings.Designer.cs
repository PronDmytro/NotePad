namespace NotePad
{
    partial class FontSettings
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
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.ExampleText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FontSizeBox = new System.Windows.Forms.ListBox();
            this.FontStyleBox = new System.Windows.Forms.ListBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Location = new System.Drawing.Point(18, 161);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(55, 17);
            this.ExampleLabel.TabIndex = 0;
            this.ExampleLabel.Text = "Зразок";
            // 
            // ExampleText
            // 
            this.ExampleText.AutoSize = true;
            this.ExampleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExampleText.Location = new System.Drawing.Point(12, 187);
            this.ExampleText.Name = "ExampleText";
            this.ExampleText.Size = new System.Drawing.Size(227, 51);
            this.ExampleText.TabIndex = 1;
            this.ExampleText.Text = "AaBbYyZz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стиль шрифту";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Розмір:";
            // 
            // FontSizeBox
            // 
            this.FontSizeBox.FormattingEnabled = true;
            this.FontSizeBox.ItemHeight = 16;
            this.FontSizeBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "72"});
            this.FontSizeBox.Location = new System.Drawing.Point(158, 28);
            this.FontSizeBox.Name = "FontSizeBox";
            this.FontSizeBox.Size = new System.Drawing.Size(121, 116);
            this.FontSizeBox.TabIndex = 8;
            this.FontSizeBox.SelectedValueChanged += new System.EventHandler(this.onFontSizeChanged);
            // 
            // FontStyleBox
            // 
            this.FontStyleBox.FormattingEnabled = true;
            this.FontStyleBox.ItemHeight = 16;
            this.FontStyleBox.Items.AddRange(new object[] {
            "звичайний",
            "курсив",
            "жирний",
            "закреслення",
            "підкреслення"});
            this.FontStyleBox.Location = new System.Drawing.Point(18, 28);
            this.FontStyleBox.Name = "FontStyleBox";
            this.FontStyleBox.Size = new System.Drawing.Size(121, 116);
            this.FontStyleBox.TabIndex = 10;
            this.FontStyleBox.SelectedValueChanged += new System.EventHandler(this.onFontStyleChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(283, 161);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(88, 28);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Скасувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 243);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.FontStyleBox);
            this.Controls.Add(this.FontSizeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExampleText);
            this.Controls.Add(this.ExampleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Шрифт";
            this.Load += new System.EventHandler(this.FontSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label ExampleText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox FontSizeBox;
        private System.Windows.Forms.ListBox FontStyleBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button button2;
    }
}