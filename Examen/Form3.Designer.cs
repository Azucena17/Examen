
namespace Examen
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboSucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboPizza = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrdenes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "DORMIMOS PIZZA\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(12, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "SUCURSAL";
            // 
            // comboSucursal
            // 
            this.comboSucursal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboSucursal.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSucursal.FormattingEnabled = true;
            this.comboSucursal.Location = new System.Drawing.Point(143, 69);
            this.comboSucursal.Name = "comboSucursal";
            this.comboSucursal.Size = new System.Drawing.Size(171, 29);
            this.comboSucursal.TabIndex = 8;
            this.comboSucursal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(548, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "PIZZA";
            // 
            // comboPizza
            // 
            this.comboPizza.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboPizza.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPizza.FormattingEnabled = true;
            this.comboPizza.Location = new System.Drawing.Point(631, 69);
            this.comboPizza.Name = "comboPizza";
            this.comboPizza.Size = new System.Drawing.Size(171, 29);
            this.comboPizza.TabIndex = 10;
            this.comboPizza.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "DESCRIPCION";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDescripcion.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(12, 178);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(790, 28);
            this.txtDescripcion.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(721, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 28);
            this.textBox1.TabIndex = 13;
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.DESCRIPCION,
            this.PRECIO});
            this.dataGridViewAdmin.Location = new System.Drawing.Point(17, 319);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(794, 192);
            this.dataGridViewAdmin.TabIndex = 14;
            // 
            // NOMBRE
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.NOMBRE.DefaultCellStyle = dataGridViewCellStyle7;
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 250;
            // 
            // DESCRIPCION
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.DESCRIPCION.DefaultCellStyle = dataGridViewCellStyle8;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.Width = 250;
            // 
            // PRECIO
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle9;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Width = 250;
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.Gray;
            this.btnOrdenes.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.ForeColor = System.Drawing.Color.Aqua;
            this.btnOrdenes.Location = new System.Drawing.Point(12, 238);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(125, 41);
            this.btnOrdenes.TabIndex = 15;
            this.btnOrdenes.Text = "ORDENAR";
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 546);
            this.Controls.Add(this.btnOrdenes);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboPizza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboSucursal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboPizza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.Button btnOrdenes;
    }
}