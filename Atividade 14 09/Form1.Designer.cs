namespace Atividade_14_09
{
    partial class Form1
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
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.pc1 = new System.Windows.Forms.PictureBox();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            this.SuspendLayout();
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(6, 29);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(69, 17);
            this.rb1.TabIndex = 1;
            this.rb1.TabStop = true;
            this.rb1.Text = "Imagen 1";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(6, 56);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(69, 17);
            this.rb2.TabIndex = 2;
            this.rb2.TabStop = true;
            this.rb2.Text = "Imagen 2";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(6, 79);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(84, 17);
            this.rb3.TabIndex = 3;
            this.rb3.TabStop = true;
            this.rb3.Text = "Sem Imagen";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(6, 18);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(77, 17);
            this.rb4.TabIndex = 4;
            this.rb4.TabStop = true;
            this.rb4.Text = "Sem Borda";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.rb4_CheckedChanged);
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(6, 41);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(83, 17);
            this.rb5.TabIndex = 5;
            this.rb5.TabStop = true;
            this.rb5.Text = "Fixa Simples";
            this.rb5.UseVisualStyleBackColor = true;
            this.rb5.CheckedChanged += new System.EventHandler(this.rb5_CheckedChanged);
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(6, 64);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(39, 17);
            this.rb6.TabIndex = 6;
            this.rb6.TabStop = true;
            this.rb6.Text = "3D";
            this.rb6.UseVisualStyleBackColor = true;
            this.rb6.CheckedChanged += new System.EventHandler(this.rb6_CheckedChanged);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(334, 402);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(141, 17);
            this.cb1.TabIndex = 7;
            this.cb1.Text = "Imagen Visível/Invisível";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rb1);
            this.gb1.Controls.Add(this.rb2);
            this.gb1.Controls.Add(this.rb3);
            this.gb1.Location = new System.Drawing.Point(27, 402);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(149, 115);
            this.gb1.TabIndex = 8;
            this.gb1.TabStop = false;
            this.gb1.Text = "Tipo de Imagen";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.rb4);
            this.gb2.Controls.Add(this.rb6);
            this.gb2.Controls.Add(this.rb5);
            this.gb2.Location = new System.Drawing.Point(182, 402);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(146, 115);
            this.gb2.TabIndex = 11;
            this.gb2.TabStop = false;
            this.gb2.Text = "Bordas";
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(334, 425);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(141, 92);
            this.bt1.TabIndex = 12;
            this.bt1.Text = "Sair";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // pc1
            // 
            this.pc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pc1.Image = global::Atividade_14_09.Properties.Resources.indo_ali_1;
            this.pc1.Location = new System.Drawing.Point(12, 12);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(575, 365);
            this.pc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc1.TabIndex = 0;
            this.pc1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 626);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.pc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button bt1;
    }
}

