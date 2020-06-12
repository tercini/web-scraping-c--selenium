namespace WebScraping
{
    partial class frWebScraping
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnScraping = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informação extraída";
            // 
            // btnScraping
            // 
            this.btnScraping.Location = new System.Drawing.Point(312, 228);
            this.btnScraping.Name = "btnScraping";
            this.btnScraping.Size = new System.Drawing.Size(97, 29);
            this.btnScraping.TabIndex = 2;
            this.btnScraping.Text = "Iniciar Scraping";
            this.btnScraping.UseVisualStyleBackColor = true;
            this.btnScraping.Click += new System.EventHandler(this.btnScraping_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(125, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 130);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // frWebScraping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 289);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnScraping);
            this.Controls.Add(this.label1);
            this.Name = "frWebScraping";
            this.Text = "Web Scraping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScraping;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

