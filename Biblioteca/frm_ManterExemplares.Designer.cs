namespace Biblioteca
{
    partial class frm_ManterExemplares
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
            this.btn_Sair1 = new System.Windows.Forms.Button();
            this.lbl_SubBibliSofi1 = new System.Windows.Forms.Label();
            this.btn_ConsultarEm = new System.Windows.Forms.Button();
            this.btn_SolicitarEm = new System.Windows.Forms.Button();
            this.lbl_Exemplares = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sair1
            // 
            this.btn_Sair1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Sair1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair1.Location = new System.Drawing.Point(645, 518);
            this.btn_Sair1.Name = "btn_Sair1";
            this.btn_Sair1.Size = new System.Drawing.Size(109, 62);
            this.btn_Sair1.TabIndex = 17;
            this.btn_Sair1.Text = "Sair";
            this.btn_Sair1.UseVisualStyleBackColor = false;
            this.btn_Sair1.Click += new System.EventHandler(this.btn_Sair1_Click);
            // 
            // lbl_SubBibliSofi1
            // 
            this.lbl_SubBibliSofi1.AutoSize = true;
            this.lbl_SubBibliSofi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubBibliSofi1.Location = new System.Drawing.Point(12, 555);
            this.lbl_SubBibliSofi1.Name = "lbl_SubBibliSofi1";
            this.lbl_SubBibliSofi1.Size = new System.Drawing.Size(173, 25);
            this.lbl_SubBibliSofi1.TabIndex = 16;
            this.lbl_SubBibliSofi1.Text = "Biblioteca da Sofia";
            this.lbl_SubBibliSofi1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_SubBibliSofi1.Click += new System.EventHandler(this.lbl_SubBibliSofi1_Click);
            // 
            // btn_ConsultarEm
            // 
            this.btn_ConsultarEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_ConsultarEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ConsultarEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsultarEm.Location = new System.Drawing.Point(244, 426);
            this.btn_ConsultarEm.Name = "btn_ConsultarEm";
            this.btn_ConsultarEm.Size = new System.Drawing.Size(122, 62);
            this.btn_ConsultarEm.TabIndex = 14;
            this.btn_ConsultarEm.Text = "Excluir";
            this.btn_ConsultarEm.UseVisualStyleBackColor = false;
            this.btn_ConsultarEm.Click += new System.EventHandler(this.btn_ConsultarEm_Click);
            // 
            // btn_SolicitarEm
            // 
            this.btn_SolicitarEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_SolicitarEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_SolicitarEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SolicitarEm.Location = new System.Drawing.Point(86, 426);
            this.btn_SolicitarEm.Name = "btn_SolicitarEm";
            this.btn_SolicitarEm.Size = new System.Drawing.Size(118, 62);
            this.btn_SolicitarEm.TabIndex = 13;
            this.btn_SolicitarEm.Text = "Criar";
            this.btn_SolicitarEm.UseVisualStyleBackColor = false;
            this.btn_SolicitarEm.Click += new System.EventHandler(this.btn_SolicitarEm_Click);
            // 
            // lbl_Exemplares
            // 
            this.lbl_Exemplares.AutoSize = true;
            this.lbl_Exemplares.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exemplares.Location = new System.Drawing.Point(35, 22);
            this.lbl_Exemplares.Name = "lbl_Exemplares";
            this.lbl_Exemplares.Size = new System.Drawing.Size(156, 31);
            this.lbl_Exemplares.TabIndex = 12;
            this.lbl_Exemplares.Text = "Exemplares";
            this.lbl_Exemplares.Click += new System.EventHandler(this.lbl_TituloDisp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.coruja;
            this.pictureBox1.Location = new System.Drawing.Point(839, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 192);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_ManterExemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(958, 610);
            this.Controls.Add(this.btn_Sair1);
            this.Controls.Add(this.lbl_SubBibliSofi1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ConsultarEm);
            this.Controls.Add(this.btn_SolicitarEm);
            this.Controls.Add(this.lbl_Exemplares);
            this.Name = "frm_ManterExemplares";
            this.Text = "frm_ManterExemplares";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sair1;
        private System.Windows.Forms.Label lbl_SubBibliSofi1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ConsultarEm;
        private System.Windows.Forms.Button btn_SolicitarEm;
        private System.Windows.Forms.Label lbl_Exemplares;
    }
}