
namespace Examen
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "  BIENVENIDOS A \r\nDORMIMOS PIZZA\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Gray;
            this.btnAdmin.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Aqua;
            this.btnAdmin.Location = new System.Drawing.Point(30, 107);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(173, 60);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "ADMINISTRACION";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.Gray;
            this.btnOrdenes.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.ForeColor = System.Drawing.Color.Aqua;
            this.btnOrdenes.Location = new System.Drawing.Point(237, 107);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(173, 60);
            this.btnOrdenes.TabIndex = 2;
            this.btnOrdenes.Text = "ORDENES";
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(458, 262);
            this.Controls.Add(this.btnOrdenes);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnOrdenes;
    }
}

