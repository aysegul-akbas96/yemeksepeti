namespace _15_Mart_2019__Yemek_Sepeti
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.burgerKingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hDKabapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tatlıDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.littleCaesarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.komaganeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Fuchsia;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.burgerKingToolStripMenuItem,
            this.hDKabapToolStripMenuItem,
            this.tatlıDToolStripMenuItem,
            this.littleCaesarsToolStripMenuItem,
            this.komaganeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // burgerKingToolStripMenuItem
            // 
            this.burgerKingToolStripMenuItem.Name = "burgerKingToolStripMenuItem";
            this.burgerKingToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.burgerKingToolStripMenuItem.Text = "Burger King";
            this.burgerKingToolStripMenuItem.Click += new System.EventHandler(this.burgerKingToolStripMenuItem_Click);
            // 
            // hDKabapToolStripMenuItem
            // 
            this.hDKabapToolStripMenuItem.Name = "hDKabapToolStripMenuItem";
            this.hDKabapToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hDKabapToolStripMenuItem.Text = "HD Kebap";
            // 
            // tatlıDToolStripMenuItem
            // 
            this.tatlıDToolStripMenuItem.Name = "tatlıDToolStripMenuItem";
            this.tatlıDToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.tatlıDToolStripMenuItem.Text = "Pasta/Tatlı";
            // 
            // littleCaesarsToolStripMenuItem
            // 
            this.littleCaesarsToolStripMenuItem.Name = "littleCaesarsToolStripMenuItem";
            this.littleCaesarsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.littleCaesarsToolStripMenuItem.Text = "Little Caesars";
            // 
            // komaganeToolStripMenuItem
            // 
            this.komaganeToolStripMenuItem.Name = "komaganeToolStripMenuItem";
            this.komaganeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.komaganeToolStripMenuItem.Text = "Komagene";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Fuchsia;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yemek Sepetine Hoşgeldiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(627, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem burgerKingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hDKabapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tatlıDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem littleCaesarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem komaganeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

