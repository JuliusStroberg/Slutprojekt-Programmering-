namespace Calculator
{
    partial class Form4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miniräknartypToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utökadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HexadecimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binärToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typvärdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.input = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Typvärde = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Typvärde_value = new System.Windows.Forms.TextBox();
            this.Median_value = new System.Windows.Forms.TextBox();
            this.Medel_value = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miniräknartypToolStripMenuItem,
            this.HexadecimalToolStripMenuItem,
            this.binärToolStripMenuItem,
            this.typvärdeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miniräknartypToolStripMenuItem
            // 
            this.miniräknartypToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utökadToolStripMenuItem});
            this.miniräknartypToolStripMenuItem.Name = "miniräknartypToolStripMenuItem";
            this.miniräknartypToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.miniräknartypToolStripMenuItem.Text = "Standard";
            this.miniräknartypToolStripMenuItem.Click += new System.EventHandler(this.MiniräknartypToolStripMenuItem_Click);
            // 
            // utökadToolStripMenuItem
            // 
            this.utökadToolStripMenuItem.Name = "utökadToolStripMenuItem";
            this.utökadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.utökadToolStripMenuItem.Text = "Utökad";
            this.utökadToolStripMenuItem.Click += new System.EventHandler(this.UtökadToolStripMenuItem_Click);
            // 
            // HexadecimalToolStripMenuItem
            // 
            this.HexadecimalToolStripMenuItem.Name = "HexadecimalToolStripMenuItem";
            this.HexadecimalToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.HexadecimalToolStripMenuItem.Text = "Hexadecimal";
            this.HexadecimalToolStripMenuItem.Click += new System.EventHandler(this.HexadecimalToolStripMenuItem_Click);
            // 
            // binärToolStripMenuItem
            // 
            this.binärToolStripMenuItem.Name = "binärToolStripMenuItem";
            this.binärToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.binärToolStripMenuItem.Text = "Binär";
            this.binärToolStripMenuItem.Click += new System.EventHandler(this.BinärToolStripMenuItem_Click);
            // 
            // typvärdeToolStripMenuItem
            // 
            this.typvärdeToolStripMenuItem.Name = "typvärdeToolStripMenuItem";
            this.typvärdeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.typvärdeToolStripMenuItem.Text = "Lägesmått";
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(231, 134);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(137, 30);
            this.input.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(374, 135);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 30);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(583, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 394);
            this.listBox1.TabIndex = 5;
            // 
            // Typvärde
            // 
            this.Typvärde.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Typvärde.Location = new System.Drawing.Point(67, 210);
            this.Typvärde.Name = "Typvärde";
            this.Typvärde.Size = new System.Drawing.Size(107, 61);
            this.Typvärde.TabIndex = 6;
            this.Typvärde.Text = "Hämta Typvärde";
            this.Typvärde.UseVisualStyleBackColor = true;
            this.Typvärde.Click += new System.EventHandler(this.Typvärde_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(231, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 61);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hämta Median";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(384, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 61);
            this.button3.TabIndex = 8;
            this.button3.Text = "Hämta Medelvärde";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Typvärde_value
            // 
            this.Typvärde_value.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Typvärde_value.Location = new System.Drawing.Point(67, 292);
            this.Typvärde_value.Name = "Typvärde_value";
            this.Typvärde_value.Size = new System.Drawing.Size(107, 25);
            this.Typvärde_value.TabIndex = 9;
            // 
            // Median_value
            // 
            this.Median_value.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Median_value.Location = new System.Drawing.Point(231, 292);
            this.Median_value.Name = "Median_value";
            this.Median_value.Size = new System.Drawing.Size(107, 25);
            this.Median_value.TabIndex = 10;
            // 
            // Medel_value
            // 
            this.Medel_value.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medel_value.Location = new System.Drawing.Point(384, 292);
            this.Medel_value.Name = "Medel_value";
            this.Medel_value.Size = new System.Drawing.Size(122, 25);
            this.Medel_value.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Medel_value);
            this.Controls.Add(this.Median_value);
            this.Controls.Add(this.Typvärde_value);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Typvärde);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.input);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miniräknartypToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utökadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HexadecimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binärToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typvärdeToolStripMenuItem;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Typvärde;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Typvärde_value;
        private System.Windows.Forms.TextBox Median_value;
        private System.Windows.Forms.TextBox Medel_value;
    }
}