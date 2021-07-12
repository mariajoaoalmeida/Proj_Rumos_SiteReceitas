
namespace CHEF_GATO_ADMIN
{
    partial class Receitas
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
            this.Procura_Rec_por_Nome_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.procura_rec_por_nome = new System.Windows.Forms.Label();
            this.proc_rec_por_ing = new System.Windows.Forms.Label();
            this.proc_rec_por_categoria = new System.Windows.Forms.Label();
            this.proc_rec_ing_btn = new System.Windows.Forms.Button();
            this.proc_rec_categoria = new System.Windows.Forms.TextBox();
            this.proc_rec_categoria_btn = new System.Windows.Forms.Button();
            this.rec__por_validar_btn = new System.Windows.Forms.Button();
            this.Resultado_cbx = new System.Windows.Forms.ComboBox();
            this.ver_detalhes_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.proc_rec_nome = new System.Windows.Forms.TextBox();
            this.proc_rec_ing = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Procura_Rec_por_Nome_Btn
            // 
            this.Procura_Rec_por_Nome_Btn.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procura_Rec_por_Nome_Btn.Location = new System.Drawing.Point(418, 80);
            this.Procura_Rec_por_Nome_Btn.Name = "Procura_Rec_por_Nome_Btn";
            this.Procura_Rec_por_Nome_Btn.Size = new System.Drawing.Size(95, 38);
            this.Procura_Rec_por_Nome_Btn.TabIndex = 0;
            this.Procura_Rec_por_Nome_Btn.Text = "Procura";
            this.Procura_Rec_por_Nome_Btn.UseVisualStyleBackColor = true;
            this.Procura_Rec_por_Nome_Btn.Click += new System.EventHandler(this.Procura_Rec_por_Nome_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Procurar Receita";
            // 
            // procura_rec_por_nome
            // 
            this.procura_rec_por_nome.AutoSize = true;
            this.procura_rec_por_nome.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procura_rec_por_nome.Location = new System.Drawing.Point(71, 84);
            this.procura_rec_por_nome.Name = "procura_rec_por_nome";
            this.procura_rec_por_nome.Size = new System.Drawing.Size(122, 33);
            this.procura_rec_por_nome.TabIndex = 3;
            this.procura_rec_por_nome.Text = "Por Nome";
            // 
            // proc_rec_por_ing
            // 
            this.proc_rec_por_ing.AutoSize = true;
            this.proc_rec_por_ing.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proc_rec_por_ing.Location = new System.Drawing.Point(71, 128);
            this.proc_rec_por_ing.Name = "proc_rec_por_ing";
            this.proc_rec_por_ing.Size = new System.Drawing.Size(192, 33);
            this.proc_rec_por_ing.TabIndex = 4;
            this.proc_rec_por_ing.Text = "Por Ingrediente";
            // 
            // proc_rec_por_categoria
            // 
            this.proc_rec_por_categoria.AutoSize = true;
            this.proc_rec_por_categoria.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proc_rec_por_categoria.Location = new System.Drawing.Point(73, 175);
            this.proc_rec_por_categoria.Name = "proc_rec_por_categoria";
            this.proc_rec_por_categoria.Size = new System.Drawing.Size(164, 33);
            this.proc_rec_por_categoria.TabIndex = 5;
            this.proc_rec_por_categoria.Text = "Por Categoria";
            // 
            // proc_rec_ing_btn
            // 
            this.proc_rec_ing_btn.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proc_rec_ing_btn.Location = new System.Drawing.Point(418, 124);
            this.proc_rec_ing_btn.Name = "proc_rec_ing_btn";
            this.proc_rec_ing_btn.Size = new System.Drawing.Size(95, 39);
            this.proc_rec_ing_btn.TabIndex = 8;
            this.proc_rec_ing_btn.Text = "Procura";
            this.proc_rec_ing_btn.UseVisualStyleBackColor = true;
            this.proc_rec_ing_btn.Click += new System.EventHandler(this.Proc_rec_ing_btn_Click);
            // 
            // proc_rec_categoria
            // 
            this.proc_rec_categoria.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proc_rec_categoria.Location = new System.Drawing.Point(268, 175);
            this.proc_rec_categoria.Multiline = true;
            this.proc_rec_categoria.Name = "proc_rec_categoria";
            this.proc_rec_categoria.Size = new System.Drawing.Size(144, 34);
            this.proc_rec_categoria.TabIndex = 9;
            this.proc_rec_categoria.TextChanged += new System.EventHandler(this.Proc_rec_categoria_TextChanged);
            // 
            // proc_rec_categoria_btn
            // 
            this.proc_rec_categoria_btn.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proc_rec_categoria_btn.Location = new System.Drawing.Point(418, 169);
            this.proc_rec_categoria_btn.Name = "proc_rec_categoria_btn";
            this.proc_rec_categoria_btn.Size = new System.Drawing.Size(95, 42);
            this.proc_rec_categoria_btn.TabIndex = 10;
            this.proc_rec_categoria_btn.Text = "Procura";
            this.proc_rec_categoria_btn.UseVisualStyleBackColor = true;
            this.proc_rec_categoria_btn.Click += new System.EventHandler(this.Proc_rec_categoria_btn_Click);
            // 
            // rec__por_validar_btn
            // 
            this.rec__por_validar_btn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec__por_validar_btn.Location = new System.Drawing.Point(615, 84);
            this.rec__por_validar_btn.Name = "rec__por_validar_btn";
            this.rec__por_validar_btn.Size = new System.Drawing.Size(386, 66);
            this.rec__por_validar_btn.TabIndex = 12;
            this.rec__por_validar_btn.Text = "Ver receitas por validar";
            this.rec__por_validar_btn.UseVisualStyleBackColor = true;
            this.rec__por_validar_btn.Click += new System.EventHandler(this.Rec__por_validar_btn_Click);
            // 
            // Resultado_cbx
            // 
            this.Resultado_cbx.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado_cbx.FormattingEnabled = true;
            this.Resultado_cbx.Location = new System.Drawing.Point(76, 453);
            this.Resultado_cbx.Name = "Resultado_cbx";
            this.Resultado_cbx.Size = new System.Drawing.Size(437, 36);
            this.Resultado_cbx.TabIndex = 13;
            // 
            // ver_detalhes_btn
            // 
            this.ver_detalhes_btn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver_detalhes_btn.Location = new System.Drawing.Point(535, 445);
            this.ver_detalhes_btn.Name = "ver_detalhes_btn";
            this.ver_detalhes_btn.Size = new System.Drawing.Size(148, 51);
            this.ver_detalhes_btn.TabIndex = 14;
            this.ver_detalhes_btn.Text = "Ver Detalhes";
            this.ver_detalhes_btn.UseVisualStyleBackColor = true;
            this.ver_detalhes_btn.Click += new System.EventHandler(this.Ver_detalhes_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "Resutado da Pesquisa";
            // 
            // proc_rec_nome
            // 
            this.proc_rec_nome.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proc_rec_nome.Location = new System.Drawing.Point(268, 80);
            this.proc_rec_nome.Multiline = true;
            this.proc_rec_nome.Name = "proc_rec_nome";
            this.proc_rec_nome.Size = new System.Drawing.Size(144, 36);
            this.proc_rec_nome.TabIndex = 16;
            this.proc_rec_nome.TextChanged += new System.EventHandler(this.Proc_rec_nome_TextChanged);
            // 
            // proc_rec_ing
            // 
            this.proc_rec_ing.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proc_rec_ing.Location = new System.Drawing.Point(268, 127);
            this.proc_rec_ing.Multiline = true;
            this.proc_rec_ing.Name = "proc_rec_ing";
            this.proc_rec_ing.Size = new System.Drawing.Size(144, 34);
            this.proc_rec_ing.TabIndex = 17;
            this.proc_rec_ing.TextChanged += new System.EventHandler(this.Proc_rec_ing_TextChanged);
            // 
            // Receitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1251, 618);
            this.Controls.Add(this.proc_rec_ing);
            this.Controls.Add(this.proc_rec_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ver_detalhes_btn);
            this.Controls.Add(this.Resultado_cbx);
            this.Controls.Add(this.rec__por_validar_btn);
            this.Controls.Add(this.proc_rec_categoria_btn);
            this.Controls.Add(this.proc_rec_categoria);
            this.Controls.Add(this.proc_rec_ing_btn);
            this.Controls.Add(this.proc_rec_por_categoria);
            this.Controls.Add(this.proc_rec_por_ing);
            this.Controls.Add(this.procura_rec_por_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Procura_Rec_por_Nome_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receitas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Procura_Rec_por_Nome_Btn;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label procura_rec_por_nome;
        private System.Windows.Forms.Label proc_rec_por_ing;
        private System.Windows.Forms.Label proc_rec_por_categoria;

        private System.Windows.Forms.Button proc_rec_ing_btn;
        private System.Windows.Forms.TextBox proc_rec_categoria;
        private System.Windows.Forms.Button proc_rec_categoria_btn;
        private System.Windows.Forms.Button rec__por_validar_btn;
   

 
        private System.Windows.Forms.ComboBox Resultado_cbx;
        private System.Windows.Forms.Button ver_detalhes_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proc_rec_nome;
        private System.Windows.Forms.TextBox proc_rec_ing;
    }
}