
using System;

namespace Cesar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buscar = new System.Windows.Forms.Button();
            this.encriptar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.key_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.path_box = new System.Windows.Forms.TextBox();
            this.textarea = new System.Windows.Forms.RichTextBox();
            this.desencriptar = new System.Windows.Forms.Button();
            this.guarda = new System.Windows.Forms.Button();
            this.bruta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(203, 18);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // encriptar
            // 
            this.encriptar.Location = new System.Drawing.Point(166, 49);
            this.encriptar.Name = "encriptar";
            this.encriptar.Size = new System.Drawing.Size(75, 23);
            this.encriptar.TabIndex = 2;
            this.encriptar.Text = "Encriptar";
            this.encriptar.UseVisualStyleBackColor = true;
            this.encriptar.Click += new System.EventHandler(this.encriptar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(60, 78);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // key_list
            // 
            this.key_list.FormattingEnabled = true;
            this.key_list.Location = new System.Drawing.Point(60, 51);
            this.key_list.Name = "key_list";
            this.key_list.Size = new System.Drawing.Size(65, 21);
            this.key_list.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "KEY:";
            // 
            // path_box
            // 
            this.path_box.Location = new System.Drawing.Point(12, 20);
            this.path_box.Name = "path_box";
            this.path_box.Size = new System.Drawing.Size(185, 20);
            this.path_box.TabIndex = 0;
            // 
            // textarea
            // 
            this.textarea.Location = new System.Drawing.Point(12, 107);
            this.textarea.Name = "textarea";
            this.textarea.Size = new System.Drawing.Size(346, 198);
            this.textarea.TabIndex = 6;
            this.textarea.Text = "";
            // 
            // desencriptar
            // 
            this.desencriptar.Location = new System.Drawing.Point(247, 49);
            this.desencriptar.Name = "desencriptar";
            this.desencriptar.Size = new System.Drawing.Size(75, 23);
            this.desencriptar.TabIndex = 7;
            this.desencriptar.Text = "desencriptar";
            this.desencriptar.UseVisualStyleBackColor = true;
            this.desencriptar.Click += new System.EventHandler(this.desencriptar_Click);
            // 
            // guarda
            // 
            this.guarda.Location = new System.Drawing.Point(247, 78);
            this.guarda.Name = "guarda";
            this.guarda.Size = new System.Drawing.Size(75, 23);
            this.guarda.TabIndex = 8;
            this.guarda.Text = "Guardar";
            this.guarda.UseVisualStyleBackColor = true;
            this.guarda.Click += new System.EventHandler(this.guarda_Click);
            // 
            // bruta
            // 
            this.bruta.Location = new System.Drawing.Point(166, 78);
            this.bruta.Name = "bruta";
            this.bruta.Size = new System.Drawing.Size(75, 23);
            this.bruta.TabIndex = 9;
            this.bruta.Text = "FB.";
            this.bruta.UseVisualStyleBackColor = true;
            this.bruta.Click += new System.EventHandler(this.bruta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 317);
            this.Controls.Add(this.bruta);
            this.Controls.Add(this.guarda);
            this.Controls.Add(this.desencriptar);
            this.Controls.Add(this.textarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.key_list);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.encriptar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.path_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button encriptar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox key_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox path_box;
        private System.Windows.Forms.RichTextBox textarea;
        private System.Windows.Forms.Button desencriptar;
        private System.Windows.Forms.Button guarda;
        private System.Windows.Forms.Button bruta;
    }
}

