namespace Presentacion
{
    partial class FormPresentacion
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
            this.Empleos = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Empleos
            // 
            this.Empleos.Location = new System.Drawing.Point(40, 33);
            this.Empleos.Name = "Empleos";
            this.Empleos.Size = new System.Drawing.Size(207, 43);
            this.Empleos.TabIndex = 0;
            this.Empleos.Text = "Empleos";
            this.Empleos.UseVisualStyleBackColor = true;
            this.Empleos.Click += new System.EventHandler(this.Empleos_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(40, 82);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(207, 43);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // FormPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 142);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Empleos);
            this.Name = "FormPresentacion";
            this.Text = "FormPresentacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Empleos;
        private System.Windows.Forms.Button Salir;
    }
}