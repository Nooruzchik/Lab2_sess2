namespace Lab2_sess2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            Enums = new TabControl();
            tabPage1.SuspendLayout();
            Enums.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(ValuesListBox);
            tabPage1.Controls.Add(EnumsListBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(864, 623);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(538, 39);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 34);
            textBox1.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(281, 39);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(200, 304);
            ValuesListBox.TabIndex = 1;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Location = new Point(20, 39);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(200, 304);
            EnumsListBox.TabIndex = 0;
            // 
            // Enums
            // 
            Enums.Controls.Add(tabPage1);
            Enums.Dock = DockStyle.Fill;
            Enums.Location = new Point(0, 0);
            Enums.Name = "Enums";
            Enums.SelectedIndex = 0;
            Enums.Size = new Size(872, 656);
            Enums.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 656);
            Controls.Add(Enums);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Programming";
            Load += Form1_Load;
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            Enums.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private TextBox textBox1;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private TabControl Enums;
    }
}
