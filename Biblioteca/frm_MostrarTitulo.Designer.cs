﻿namespace Biblioteca
{
    partial class frm_MostrarTitulo
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
            this.lbl_TituloDisp = new System.Windows.Forms.Label();
            this.btn_SolicitarEm = new System.Windows.Forms.Button();
            this.btn_ConsultarEm = new System.Windows.Forms.Button();
            this.lbl_SubBibliSofi1 = new System.Windows.Forms.Label();
            this.btn_Sair1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TituloDisp
            // 
            this.lbl_TituloDisp.AutoSize = true;
            this.lbl_TituloDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloDisp.Location = new System.Drawing.Point(35, 31);
            this.lbl_TituloDisp.Name = "lbl_TituloDisp";
            this.lbl_TituloDisp.Size = new System.Drawing.Size(242, 31);
            this.lbl_TituloDisp.TabIndex = 0;
            this.lbl_TituloDisp.Text = "Títulos Disponíveis";
            this.lbl_TituloDisp.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_SolicitarEm
            // 
            this.btn_SolicitarEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_SolicitarEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_SolicitarEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SolicitarEm.Location = new System.Drawing.Point(67, 391);
            this.btn_SolicitarEm.Name = "btn_SolicitarEm";
            this.btn_SolicitarEm.Size = new System.Drawing.Size(303, 62);
            this.btn_SolicitarEm.TabIndex = 2;
            this.btn_SolicitarEm.Text = "Solicitar Empréstimo";
            this.btn_SolicitarEm.UseVisualStyleBackColor = false;
            this.btn_SolicitarEm.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // btn_ConsultarEm
            // 
            this.btn_ConsultarEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_ConsultarEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ConsultarEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsultarEm.Location = new System.Drawing.Point(67, 459);
            this.btn_ConsultarEm.Name = "btn_ConsultarEm";
            this.btn_ConsultarEm.Size = new System.Drawing.Size(303, 62);
            this.btn_ConsultarEm.TabIndex = 3;
            this.btn_ConsultarEm.Text = "Consultar Empréstimo";
            this.btn_ConsultarEm.UseVisualStyleBackColor = false;
            this.btn_ConsultarEm.Click += new System.EventHandler(this.btn_ConsultarEm_Click);
            // 
            // lbl_SubBibliSofi1
            // 
            this.lbl_SubBibliSofi1.AutoSize = true;
            this.lbl_SubBibliSofi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubBibliSofi1.Location = new System.Drawing.Point(12, 564);
            this.lbl_SubBibliSofi1.Name = "lbl_SubBibliSofi1";
            this.lbl_SubBibliSofi1.Size = new System.Drawing.Size(173, 25);
            this.lbl_SubBibliSofi1.TabIndex = 10;
            this.lbl_SubBibliSofi1.Text = "Biblioteca da Sofia";
            this.lbl_SubBibliSofi1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_SubBibliSofi1.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Sair1
            // 
            this.btn_Sair1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Sair1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sair1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair1.Location = new System.Drawing.Point(645, 527);
            this.btn_Sair1.Name = "btn_Sair1";
            this.btn_Sair1.Size = new System.Drawing.Size(109, 62);
            this.btn_Sair1.TabIndex = 11;
            this.btn_Sair1.Text = "Sair";
            this.btn_Sair1.UseVisualStyleBackColor = false;
            this.btn_Sair1.Click += new System.EventHandler(this.btn_Sair1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.coruja;
            this.pictureBox1.Location = new System.Drawing.Point(839, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 192);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_MostrarTitulo
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
            this.Controls.Add(this.lbl_TituloDisp);
            this.Name = "frm_MostrarTitulo";
            this.Text = "frm_MostrarTitulo";
            this.Load += new System.EventHandler(this.frm_MostrarTitulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TituloDisp;
        private System.Windows.Forms.Button btn_SolicitarEm;
        private System.Windows.Forms.Button btn_ConsultarEm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_SubBibliSofi1;
        private System.Windows.Forms.Button btn_Sair1;
    }
}