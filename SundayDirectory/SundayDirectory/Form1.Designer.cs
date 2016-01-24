namespace SundayDirectory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.RenameButton = new System.Windows.Forms.Button();
            this.SelectDirButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.TahunNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TahunNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 52);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sebelum Menggunakan program ini buat \r\nDirektori Tahun terlebih dahulu.\r\nlalu pil" +
    "ih dirrektori tahun dengn tombol direktori.\r\nlalu pilih tombol buat direktori \r\n" +
    "";
            // 
            // RenameButton
            // 
            this.RenameButton.Location = new System.Drawing.Point(12, 226);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(92, 23);
            this.RenameButton.TabIndex = 11;
            this.RenameButton.Text = "Create Directory";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // SelectDirButton
            // 
            this.SelectDirButton.Location = new System.Drawing.Point(12, 12);
            this.SelectDirButton.Name = "SelectDirButton";
            this.SelectDirButton.Size = new System.Drawing.Size(104, 23);
            this.SelectDirButton.TabIndex = 10;
            this.SelectDirButton.Text = "Select Directory";
            this.SelectDirButton.UseVisualStyleBackColor = true;
            this.SelectDirButton.Click += new System.EventHandler(this.SelectDirButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tahun :";
            // 
            // TahunNumericUpDown1
            // 
            this.TahunNumericUpDown1.Location = new System.Drawing.Point(172, 12);
            this.TahunNumericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.TahunNumericUpDown1.Name = "TahunNumericUpDown1";
            this.TahunNumericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.TahunNumericUpDown1.TabIndex = 15;
            this.TahunNumericUpDown1.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TahunNumericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.SelectDirButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buat Direktori PerBulan";
            ((System.ComponentModel.ISupportInitialize)(this.TahunNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Button SelectDirButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TahunNumericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}

