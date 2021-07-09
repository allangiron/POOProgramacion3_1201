
namespace POOProgramacion3_1201
{
    partial class LINQ
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
            this.CB_valores = new System.Windows.Forms.ComboBox();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.btn_sumaLINQ = new System.Windows.Forms.Button();
            this.btn_NumPares = new System.Windows.Forms.Button();
            this.btn_NumParesLINQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valores:";
            // 
            // CB_valores
            // 
            this.CB_valores.FormattingEnabled = true;
            this.CB_valores.Location = new System.Drawing.Point(112, 89);
            this.CB_valores.Name = "CB_valores";
            this.CB_valores.Size = new System.Drawing.Size(127, 21);
            this.CB_valores.TabIndex = 1;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar.Location = new System.Drawing.Point(292, 43);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(75, 45);
            this.Btn_agregar.TabIndex = 2;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // btn_sumaLINQ
            // 
            this.btn_sumaLINQ.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sumaLINQ.Location = new System.Drawing.Point(396, 43);
            this.btn_sumaLINQ.Name = "btn_sumaLINQ";
            this.btn_sumaLINQ.Size = new System.Drawing.Size(75, 45);
            this.btn_sumaLINQ.TabIndex = 3;
            this.btn_sumaLINQ.Text = "Suma LINQ";
            this.btn_sumaLINQ.UseVisualStyleBackColor = true;
            this.btn_sumaLINQ.Click += new System.EventHandler(this.btn_sumaLINQ_Click);
            // 
            // btn_NumPares
            // 
            this.btn_NumPares.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NumPares.Location = new System.Drawing.Point(292, 115);
            this.btn_NumPares.Name = "btn_NumPares";
            this.btn_NumPares.Size = new System.Drawing.Size(75, 45);
            this.btn_NumPares.TabIndex = 4;
            this.btn_NumPares.Text = "Num Pares";
            this.btn_NumPares.UseVisualStyleBackColor = true;
            this.btn_NumPares.Click += new System.EventHandler(this.btn_NumPares_Click);
            // 
            // btn_NumParesLINQ
            // 
            this.btn_NumParesLINQ.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NumParesLINQ.Location = new System.Drawing.Point(396, 115);
            this.btn_NumParesLINQ.Name = "btn_NumParesLINQ";
            this.btn_NumParesLINQ.Size = new System.Drawing.Size(75, 45);
            this.btn_NumParesLINQ.TabIndex = 5;
            this.btn_NumParesLINQ.Text = "Pares LINQ";
            this.btn_NumParesLINQ.UseVisualStyleBackColor = true;
            this.btn_NumParesLINQ.Click += new System.EventHandler(this.btn_NumParesLINQ_Click);
            // 
            // LINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 324);
            this.Controls.Add(this.btn_NumParesLINQ);
            this.Controls.Add(this.btn_NumPares);
            this.Controls.Add(this.btn_sumaLINQ);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.CB_valores);
            this.Controls.Add(this.label1);
            this.Name = "LINQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LINQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_valores;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button btn_sumaLINQ;
        private System.Windows.Forms.Button btn_NumPares;
        private System.Windows.Forms.Button btn_NumParesLINQ;
    }
}