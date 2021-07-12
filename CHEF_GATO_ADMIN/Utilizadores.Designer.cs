
namespace CHEF_GATO_ADMIN
{
    partial class Utilizadores
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
            this.users_cbx = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Bloqueados_cbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizadores Desbloqueados";
            // 
            // users_cbx
            // 
            this.users_cbx.FormattingEnabled = true;
            this.users_cbx.Location = new System.Drawing.Point(286, 47);
            this.users_cbx.Name = "users_cbx";
            this.users_cbx.Size = new System.Drawing.Size(277, 28);
            this.users_cbx.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bloquear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Desbloquear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bloqueados_cbx
            // 
            this.Bloqueados_cbx.FormattingEnabled = true;
            this.Bloqueados_cbx.Location = new System.Drawing.Point(286, 155);
            this.Bloqueados_cbx.Name = "Bloqueados_cbx";
            this.Bloqueados_cbx.Size = new System.Drawing.Size(277, 28);
            this.Bloqueados_cbx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Utilizadores Bloqueados";
            // 
            // Utilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bloqueados_cbx);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.users_cbx);
            this.Controls.Add(this.label1);
            this.Name = "Utilizadores";
            this.Text = "Utilizadores";
            this.Load += new System.EventHandler(this.Utilizadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox users_cbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Bloqueados_cbx;
        private System.Windows.Forms.Label label2;
    }
}