namespace Biblioteca
{
    partial class frm_ConsultarSolicitacao
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
            this.btn_Sair2 = new System.Windows.Forms.Button();
            this.lbl_SubBibliSofi2 = new System.Windows.Forms.Label();
            this.btn_RemoverEm = new System.Windows.Forms.Button();
            this.lbl_TituloSol = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sair2
            // 
            this.btn_Sair2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Sair2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Sair2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair2.Location = new System.Drawing.Point(590, 536);
            this.btn_Sair2.Name = "btn_Sair2";
            this.btn_Sair2.Size = new System.Drawing.Size(109, 62);
            this.btn_Sair2.TabIndex = 17;
            this.btn_Sair2.Text = "Sair";
            this.btn_Sair2.UseVisualStyleBackColor = false;
            // 
            // lbl_SubBibliSofi2
            // 
            this.lbl_SubBibliSofi2.AutoSize = true;
            this.lbl_SubBibliSofi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubBibliSofi2.Location = new System.Drawing.Point(12, 573);
            this.lbl_SubBibliSofi2.Name = "lbl_SubBibliSofi2";
            this.lbl_SubBibliSofi2.Size = new System.Drawing.Size(173, 25);
            this.lbl_SubBibliSofi2.TabIndex = 16;
            this.lbl_SubBibliSofi2.Text = "Biblioteca da Sofia";
            this.lbl_SubBibliSofi2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_RemoverEm
            // 
            this.btn_RemoverEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_RemoverEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_RemoverEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoverEm.Location = new System.Drawing.Point(90, 453);
            this.btn_RemoverEm.Name = "btn_RemoverEm";
            this.btn_RemoverEm.Size = new System.Drawing.Size(303, 62);
            this.btn_RemoverEm.TabIndex = 13;
            this.btn_RemoverEm.Text = "Remover Empréstrimo";
            this.btn_RemoverEm.UseVisualStyleBackColor = false;
            // 
            // lbl_TituloSol
            // 
            this.lbl_TituloSol.AutoSize = true;
            this.lbl_TituloSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloSol.Location = new System.Drawing.Point(27, 28);
            this.lbl_TituloSol.Name = "lbl_TituloSol";
            this.lbl_TituloSol.Size = new System.Drawing.Size(234, 31);
            this.lbl_TituloSol.TabIndex = 12;
            this.lbl_TituloSol.Text = "Títulos Solicitados";
            this.lbl_TituloSol.Click += new System.EventHandler(this.lbl_TituloDisp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.coruja;
            this.pictureBox1.Location = new System.Drawing.Point(839, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 192);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frm_ConsultarSolicitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(958, 610);
            this.Controls.Add(this.btn_Sair2);
            this.Controls.Add(this.lbl_SubBibliSofi2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_RemoverEm);
            this.Controls.Add(this.lbl_TituloSol);
            this.Name = "frm_ConsultarSolicitacao";
            this.Text = "frm_ConsultarSolicitacao";
            this.Load += new System.EventHandler(this.frm_ConsultarSolicitacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sair2;
        private System.Windows.Forms.Label lbl_SubBibliSofi2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_RemoverEm;
        private System.Windows.Forms.Label lbl_TituloSol;
    }
}