
namespace Examen
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxSucursal = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "DORMIMOS PIZZA\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADMINISTRACION";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "DESCRIPCION";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRECIO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 56);
            this.label5.TabIndex = 5;
            this.label5.Text = "PIZZA\r\nNOMBRE\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "SUCURSAL";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // listBoxSucursal
            // 
            this.listBoxSucursal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxSucursal.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSucursal.FormattingEnabled = true;
            this.listBoxSucursal.Location = new System.Drawing.Point(143, 112);
            this.listBoxSucursal.Name = "listBoxSucursal";
            this.listBoxSucursal.Size = new System.Drawing.Size(156, 29);
            this.listBoxSucursal.TabIndex = 7;
            this.listBoxSucursal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombre.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(143, 195);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 28);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrecio.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.FormattingEnabled = true;
            this.txtPrecio.Items.AddRange(new object[] {
            "50",
            "75",
            "100",
            "125",
            "150"});
            this.txtPrecio.Location = new System.Drawing.Point(143, 245);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(156, 29);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.SelectedIndexChanged += new System.EventHandler(this.txtPrecio_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDescripcion.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(12, 344);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(549, 28);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Gray;
            this.btnAdmin.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Aqua;
            this.btnAdmin.Location = new System.Drawing.Point(12, 378);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(125, 41);
            this.btnAdmin.TabIndex = 11;
            this.btnAdmin.Text = "CREAR";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.DESCRIPCION,
            this.PRECIO});
            this.dataGridViewAdmin.Location = new System.Drawing.Point(12, 432);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(494, 78);
            this.dataGridViewAdmin.TabIndex = 12;
            this.dataGridViewAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NOMBRE
            // 
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.NOMBRE.DefaultCellStyle = dataGridViewCellStyle13;
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 150;
            // 
            // DESCRIPCION
            // 
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            this.DESCRIPCION.DefaultCellStyle = dataGridViewCellStyle14;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.Width = 150;
            // 
            // PRECIO
            // 
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.PRECIO.DefaultCellStyle = dataGridViewCellStyle15;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(449, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "REGRESAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(586, 565);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.listBoxSucursal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox listBoxSucursal;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.ComboBox txtPrecio;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.Button btnAdmin;
        public System.Windows.Forms.DataGridView dataGridViewAdmin;
        public System.Windows.Forms.Button button1;
    }
}