
namespace CHEF_GATO_ADMIN
{
    partial class Ingredientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.insere_ing_txb = new System.Windows.Forms.TextBox();
            this.adicionar_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Eliminar_btn = new System.Windows.Forms.Button();
            this.elimina_ing_cbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo Ingrediente";
            // 
            // insere_ing_txb
            // 
            this.insere_ing_txb.Location = new System.Drawing.Point(209, 50);
            this.insere_ing_txb.Name = "insere_ing_txb";
            this.insere_ing_txb.Size = new System.Drawing.Size(212, 26);
            this.insere_ing_txb.TabIndex = 1;
            // 
            // adicionar_btn
            // 
            this.adicionar_btn.Location = new System.Drawing.Point(445, 41);
            this.adicionar_btn.Name = "adicionar_btn";
            this.adicionar_btn.Size = new System.Drawing.Size(176, 45);
            this.adicionar_btn.TabIndex = 2;
            this.adicionar_btn.Text = "Adicionar Ingrediente";
            this.adicionar_btn.UseVisualStyleBackColor = true;
            this.adicionar_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eliminar Ingrediente";
            // 
            // Eliminar_btn
            // 
            this.Eliminar_btn.Location = new System.Drawing.Point(445, 128);
            this.Eliminar_btn.Name = "Eliminar_btn";
            this.Eliminar_btn.Size = new System.Drawing.Size(176, 37);
            this.Eliminar_btn.TabIndex = 5;
            this.Eliminar_btn.Text = "Eliminar";
            this.Eliminar_btn.UseVisualStyleBackColor = true;
            this.Eliminar_btn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // elimina_ing_cbx
            // 
            this.elimina_ing_cbx.FormattingEnabled = true;
            this.elimina_ing_cbx.Location = new System.Drawing.Point(209, 133);
            this.elimina_ing_cbx.Name = "elimina_ing_cbx";
            this.elimina_ing_cbx.Size = new System.Drawing.Size(212, 28);
            this.elimina_ing_cbx.TabIndex = 6;
            this.elimina_ing_cbx.SelectedIndexChanged += new System.EventHandler(this.Elimina_ind_cbx_SelectedIndexChanged);
            // 
            // Ingredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elimina_ing_cbx);
            this.Controls.Add(this.Eliminar_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adicionar_btn);
            this.Controls.Add(this.insere_ing_txb);
            this.Controls.Add(this.label1);
            this.Name = "Ingredientes";
            this.Text = "Ingredientes";
            this.Load += new System.EventHandler(this.Ingredientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox insere_ing_txb;
        private System.Windows.Forms.Button adicionar_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Eliminar_btn;
        private System.Windows.Forms.ComboBox elimina_ing_cbx;
    }
}