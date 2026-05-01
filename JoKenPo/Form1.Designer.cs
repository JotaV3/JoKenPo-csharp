namespace JoKenPo
{
    partial class form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.picBoxResult = new System.Windows.Forms.PictureBox();
            this.picBoxPlayer = new System.Windows.Forms.PictureBox();
            this.picBoxPc = new System.Windows.Forms.PictureBox();
            this.btnScissors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "PC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Você";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // btnPaper
            // 
            this.btnPaper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPaper.BackgroundImage = global::JoKenPo.Properties.Resources.Papel;
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaper.Location = new System.Drawing.Point(219, 273);
            this.btnPaper.Margin = new System.Windows.Forms.Padding(0);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(120, 120);
            this.btnPaper.TabIndex = 7;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImage = global::JoKenPo.Properties.Resources.Pedra;
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRock.Location = new System.Drawing.Point(44, 273);
            this.btnRock.Margin = new System.Windows.Forms.Padding(0);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(120, 120);
            this.btnRock.TabIndex = 6;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // picBoxResult
            // 
            this.picBoxResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picBoxResult.Location = new System.Drawing.Point(399, 100);
            this.picBoxResult.Name = "picBoxResult";
            this.picBoxResult.Size = new System.Drawing.Size(120, 120);
            this.picBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxResult.TabIndex = 2;
            this.picBoxResult.TabStop = false;
            // 
            // picBoxPlayer
            // 
            this.picBoxPlayer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picBoxPlayer.Location = new System.Drawing.Point(219, 100);
            this.picBoxPlayer.Name = "picBoxPlayer";
            this.picBoxPlayer.Size = new System.Drawing.Size(120, 120);
            this.picBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayer.TabIndex = 1;
            this.picBoxPlayer.TabStop = false;
            // 
            // picBoxPc
            // 
            this.picBoxPc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picBoxPc.Location = new System.Drawing.Point(44, 100);
            this.picBoxPc.Name = "picBoxPc";
            this.picBoxPc.Size = new System.Drawing.Size(120, 120);
            this.picBoxPc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPc.TabIndex = 0;
            this.picBoxPc.TabStop = false;
            // 
            // btnScissors
            // 
            this.btnScissors.BackgroundImage = global::JoKenPo.Properties.Resources.Tesoura;
            this.btnScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScissors.Location = new System.Drawing.Point(399, 273);
            this.btnScissors.Margin = new System.Windows.Forms.Padding(0);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(120, 120);
            this.btnScissors.TabIndex = 8;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxResult);
            this.Controls.Add(this.picBoxPlayer);
            this.Controls.Add(this.picBoxPc);
            this.Name = "form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JoKenPo";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPc;
        private System.Windows.Forms.PictureBox picBoxPlayer;
        private System.Windows.Forms.PictureBox picBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
    }
}

