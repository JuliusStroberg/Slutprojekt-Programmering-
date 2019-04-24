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
            // 
            // utökadToolStripMenuItem
            // 
            this.utökadToolStripMenuItem.Name = "utökadToolStripMenuItem";
            this.utökadToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.utökadToolStripMenuItem.Text = "Utökad";
            // 
            // HexadecimalToolStripMenuItem
            // 
            this.HexadecimalToolStripMenuItem.Name = "HexadecimalToolStripMenuItem";
            this.HexadecimalToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.HexadecimalToolStripMenuItem.Text = "Hexadecimal";
            // 
            // binärToolStripMenuItem
            // 
            this.binärToolStripMenuItem.Name = "binärToolStripMenuItem";
            this.binärToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.binärToolStripMenuItem.Text = "Binär";
            // 
            // typvärdeToolStripMenuItem
            // 
            this.typvärdeToolStripMenuItem.Name = "typvärdeToolStripMenuItem";
            this.typvärdeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.typvärdeToolStripMenuItem.Text = "Typvärde";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}