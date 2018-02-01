namespace Prueba
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonElegirArchivos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.comboBoxMunicipio = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(31, 70);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(340, 20);
            this.textBoxCedula.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(31, 129);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(340, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(31, 186);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(340, 20);
            this.textBoxMail.TabIndex = 2;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(31, 239);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(340, 20);
            this.textBoxTelefono.TabIndex = 3;
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Location = new System.Drawing.Point(31, 407);
            this.textBoxComentario.Multiline = true;
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(340, 83);
            this.textBoxComentario.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(28, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tamaño máximo total: 4mb";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Provincias";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Municipio";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(160, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Represento a una institución";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(31, 538);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 8;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "FORMULARIO";
            // 
            // buttonElegirArchivos
            // 
            this.buttonElegirArchivos.Location = new System.Drawing.Point(31, 498);
            this.buttonElegirArchivos.Name = "buttonElegirArchivos";
            this.buttonElegirArchivos.Size = new System.Drawing.Size(110, 23);
            this.buttonElegirArchivos.TabIndex = 7;
            this.buttonElegirArchivos.Text = "Elegir Archivos";
            this.buttonElegirArchivos.UseVisualStyleBackColor = true;
            this.buttonElegirArchivos.Click += new System.EventHandler(this.buttonElegirArchivos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Comentario y/o Sugerencia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 503);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "No se eligió archivo";
           // this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.AllowDrop = true;
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Location = new System.Drawing.Point(31, 296);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(340, 21);
            this.comboBoxProvincia.TabIndex = 4;
            this.comboBoxProvincia.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvincia_SelectedIndexChanged);
            // 
            // comboBoxMunicipio
            // 
            this.comboBoxMunicipio.FormattingEnabled = true;
            this.comboBoxMunicipio.Location = new System.Drawing.Point(31, 346);
            this.comboBoxMunicipio.Name = "comboBoxMunicipio";
            this.comboBoxMunicipio.Size = new System.Drawing.Size(340, 21);
            this.comboBoxMunicipio.TabIndex = 5;
            this.comboBoxMunicipio.SelectedIndexChanged += new System.EventHandler(this.comboBoxMunicipio_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(377, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(287, 420);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 573);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBoxMunicipio);
            this.Controls.Add(this.comboBoxProvincia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonElegirArchivos);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCedula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxComentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonElegirArchivos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.ComboBox comboBoxMunicipio;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
    }
}

