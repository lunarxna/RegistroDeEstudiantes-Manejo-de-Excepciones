namespace RegistroDeEstudiantes_ManejoExcepciones
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtNombreCompleto = new TextBox();
            label3 = new Label();
            txtEdad = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label5 = new Label();
            txtTelefono = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 94);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kids Cute - Demo Version", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(356, 23);
            label1.Name = "label1";
            label1.Size = new Size(494, 53);
            label1.TabIndex = 0;
            label1.Text = "Registro de Estudiantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kids Cute - Demo Version", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 161);
            label2.Name = "label2";
            label2.Size = new Size(345, 48);
            label2.TabIndex = 1;
            label2.Text = "Nombre completo:";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Font = new Font("Pinky Love", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCompleto.Location = new Point(462, 169);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(578, 40);
            txtNombreCompleto.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kids Cute - Demo Version", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 253);
            label3.Name = "label3";
            label3.Size = new Size(116, 48);
            label3.TabIndex = 3;
            label3.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Pinky Love", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdad.Location = new Point(462, 261);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(264, 40);
            txtEdad.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kids Cute - Demo Version", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 356);
            label4.Name = "label4";
            label4.Size = new Size(370, 48);
            label4.TabIndex = 5;
            label4.Text = "Correo electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Pinky Love", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(462, 364);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(578, 40);
            txtCorreo.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Pinky Love", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.Green;
            btnGuardar.Location = new Point(143, 567);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(181, 55);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Pinky Love", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Teal;
            btnLimpiar.Location = new Point(495, 567);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(188, 55);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Pinky Love", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Maroon;
            btnSalir.Location = new Point(843, 567);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(168, 55);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kids Cute - Demo Version", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(86, 450);
            label5.Name = "label5";
            label5.Size = new Size(178, 48);
            label5.TabIndex = 10;
            label5.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Pinky Love", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(462, 462);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(507, 40);
            txtTelefono.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1187, 667);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtNombreCompleto;
        private Label label3;
        private TextBox txtEdad;
        private Label label4;
        private TextBox txtCorreo;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label5;
        private TextBox txtTelefono;
    }
}
