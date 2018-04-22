namespace JapaneseLearning
{
    partial class Form1
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
            this.btnNext = new System.Windows.Forms.Button();
            this.lbHiragana = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiraganaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRomaijHiragana = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRomajiKatakana = new System.Windows.Forms.Label();
            this.chkShowRomaji = new System.Windows.Forms.CheckBox();
            this.chkSenquence = new System.Windows.Forms.CheckBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(319, 302);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbHiragana
            // 
            this.lbHiragana.AutoSize = true;
            this.lbHiragana.Font = new System.Drawing.Font("Times New Roman", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHiragana.Location = new System.Drawing.Point(53, 20);
            this.lbHiragana.Name = "lbHiragana";
            this.lbHiragana.Size = new System.Drawing.Size(172, 151);
            this.lbHiragana.TabIndex = 3;
            this.lbHiragana.Text = "あ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiraganaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // hiraganaToolStripMenuItem
            // 
            this.hiraganaToolStripMenuItem.Name = "hiraganaToolStripMenuItem";
            this.hiraganaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.hiraganaToolStripMenuItem.Text = "Hiragana";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRomaijHiragana);
            this.groupBox1.Controls.Add(this.lbHiragana);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 214);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiragana";
            // 
            // lbRomaijHiragana
            // 
            this.lbRomaijHiragana.AutoSize = true;
            this.lbRomaijHiragana.Location = new System.Drawing.Point(107, 184);
            this.lbRomaijHiragana.Name = "lbRomaijHiragana";
            this.lbRomaijHiragana.Size = new System.Drawing.Size(18, 20);
            this.lbRomaijHiragana.TabIndex = 8;
            this.lbRomaijHiragana.Text = "a";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRomajiKatakana);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(340, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 214);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Katakana";
            // 
            // lbRomajiKatakana
            // 
            this.lbRomajiKatakana.AutoSize = true;
            this.lbRomajiKatakana.Location = new System.Drawing.Point(89, 184);
            this.lbRomajiKatakana.Name = "lbRomajiKatakana";
            this.lbRomajiKatakana.Size = new System.Drawing.Size(51, 20);
            this.lbRomajiKatakana.TabIndex = 8;
            this.lbRomajiKatakana.Text = "label1";
            // 
            // chkShowRomaji
            // 
            this.chkShowRomaji.AutoSize = true;
            this.chkShowRomaji.Checked = true;
            this.chkShowRomaji.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowRomaji.Location = new System.Drawing.Point(12, 280);
            this.chkShowRomaji.Name = "chkShowRomaji";
            this.chkShowRomaji.Size = new System.Drawing.Size(115, 17);
            this.chkShowRomaji.TabIndex = 7;
            this.chkShowRomaji.Text = "Show/Hide Romaji";
            this.chkShowRomaji.UseVisualStyleBackColor = true;
            this.chkShowRomaji.CheckedChanged += new System.EventHandler(this.chkShowRomaji_CheckedChanged);
            // 
            // chkSenquence
            // 
            this.chkSenquence.AutoSize = true;
            this.chkSenquence.Location = new System.Drawing.Point(12, 257);
            this.chkSenquence.Name = "chkSenquence";
            this.chkSenquence.Size = new System.Drawing.Size(83, 17);
            this.chkSenquence.TabIndex = 8;
            this.chkSenquence.Text = "Sequentially";
            this.chkSenquence.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(205, 302);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(96, 23);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "<< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 481);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.chkSenquence);
            this.Controls.Add(this.chkShowRomaji);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Japanese Learning";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbHiragana;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiraganaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkShowRomaji;
        private System.Windows.Forms.Label lbRomaijHiragana;
        private System.Windows.Forms.Label lbRomajiKatakana;
        private System.Windows.Forms.CheckBox chkSenquence;
        private System.Windows.Forms.Button btnPrevious;
    }
}

