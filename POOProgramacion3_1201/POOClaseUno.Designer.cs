
namespace POOProgramacion3_1201
{
    partial class POOClaseUno
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
            this.Btn_probar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_edad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.Btn_lista = new System.Windows.Forms.Button();
            this.DGV_listaPersonas = new System.Windows.Forms.DataGridView();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_listaPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_probar
            // 
            this.Btn_probar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_probar.Location = new System.Drawing.Point(340, 53);
            this.Btn_probar.Name = "Btn_probar";
            this.Btn_probar.Size = new System.Drawing.Size(84, 51);
            this.Btn_probar.TabIndex = 0;
            this.Btn_probar.Text = "Probar";
            this.Btn_probar.UseVisualStyleBackColor = true;
            this.Btn_probar.Click += new System.EventHandler(this.Btn_probar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(141, 46);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(133, 20);
            this.Txt_nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // Txt_apellido
            // 
            this.Txt_apellido.Location = new System.Drawing.Point(141, 84);
            this.Txt_apellido.Name = "Txt_apellido";
            this.Txt_apellido.Size = new System.Drawing.Size(133, 20);
            this.Txt_apellido.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Edad:";
            // 
            // Txt_edad
            // 
            this.Txt_edad.Location = new System.Drawing.Point(141, 119);
            this.Txt_edad.Name = "Txt_edad";
            this.Txt_edad.Size = new System.Drawing.Size(133, 20);
            this.Txt_edad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dirección:";
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.Location = new System.Drawing.Point(141, 155);
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(133, 20);
            this.Txt_direccion.TabIndex = 2;
            // 
            // Btn_lista
            // 
            this.Btn_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_lista.Location = new System.Drawing.Point(458, 53);
            this.Btn_lista.Name = "Btn_lista";
            this.Btn_lista.Size = new System.Drawing.Size(84, 51);
            this.Btn_lista.TabIndex = 3;
            this.Btn_lista.Text = "Lista";
            this.Btn_lista.UseVisualStyleBackColor = true;
            this.Btn_lista.Click += new System.EventHandler(this.Btn_lista_Click);
            // 
            // DGV_listaPersonas
            // 
            this.DGV_listaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_listaPersonas.Location = new System.Drawing.Point(58, 276);
            this.DGV_listaPersonas.Name = "DGV_listaPersonas";
            this.DGV_listaPersonas.Size = new System.Drawing.Size(417, 145);
            this.DGV_listaPersonas.TabIndex = 4;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar.Location = new System.Drawing.Point(340, 126);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(84, 51);
            this.Btn_agregar.TabIndex = 5;
            this.Btn_agregar.Text = "Agregar Data";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lista ";
            // 
            // POOClaseUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.DGV_listaPersonas);
            this.Controls.Add(this.Btn_lista);
            this.Controls.Add(this.Txt_direccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_edad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_probar);
            this.Name = "POOClaseUno";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_listaPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_probar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_edad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.Button Btn_lista;
        private System.Windows.Forms.DataGridView DGV_listaPersonas;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Label label5;
    }
}

