
namespace EjemploPOO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCrearCarro = new System.Windows.Forms.Button();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.buttonFrenar = new System.Windows.Forms.Button();
            this.labelDato = new System.Windows.Forms.Label();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelvelocidad = new System.Windows.Forms.Label();
            this.labelCambio = new System.Windows.Forms.Label();
            this.buttonAumentar = new System.Windows.Forms.Button();
            this.labelRevoluciones = new System.Windows.Forms.Label();
            this.buttonCancion = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCrearCarro
            // 
            this.buttonCrearCarro.BackColor = System.Drawing.Color.Lavender;
            this.buttonCrearCarro.FlatAppearance.BorderSize = 0;
            this.buttonCrearCarro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCrearCarro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCrearCarro.Location = new System.Drawing.Point(190, 62);
            this.buttonCrearCarro.Name = "buttonCrearCarro";
            this.buttonCrearCarro.Size = new System.Drawing.Size(115, 31);
            this.buttonCrearCarro.TabIndex = 0;
            this.buttonCrearCarro.Text = "Crear Carro";
            this.buttonCrearCarro.UseVisualStyleBackColor = false;
            this.buttonCrearCarro.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.Color.Lavender;
            this.buttonEncender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEncender.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEncender.Location = new System.Drawing.Point(42, 105);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(126, 29);
            this.buttonEncender.TabIndex = 2;
            this.buttonEncender.Text = "Encender Carro";
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.BackColor = System.Drawing.Color.Lavender;
            this.buttonAcelerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAcelerar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAcelerar.Location = new System.Drawing.Point(136, 299);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(78, 32);
            this.buttonAcelerar.TabIndex = 3;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // buttonFrenar
            // 
            this.buttonFrenar.BackColor = System.Drawing.Color.Lavender;
            this.buttonFrenar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFrenar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFrenar.Location = new System.Drawing.Point(42, 299);
            this.buttonFrenar.Name = "buttonFrenar";
            this.buttonFrenar.Size = new System.Drawing.Size(78, 32);
            this.buttonFrenar.TabIndex = 4;
            this.buttonFrenar.Text = "Frenar";
            this.buttonFrenar.UseVisualStyleBackColor = false;
            this.buttonFrenar.Click += new System.EventHandler(this.buttonFrenar_Click);
            // 
            // labelDato
            // 
            this.labelDato.AutoSize = true;
            this.labelDato.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDato.ForeColor = System.Drawing.Color.White;
            this.labelDato.Location = new System.Drawing.Point(0, 21);
            this.labelDato.Name = "labelDato";
            this.labelDato.Size = new System.Drawing.Size(41, 16);
            this.labelDato.TabIndex = 5;
            this.labelDato.Text = "Datos";
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.Color.Lavender;
            this.buttonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonApagar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApagar.Location = new System.Drawing.Point(320, 106);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(123, 28);
            this.buttonApagar.TabIndex = 6;
            this.buttonApagar.Text = "Apagar Carro";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelvelocidad
            // 
            this.labelvelocidad.AutoSize = true;
            this.labelvelocidad.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelvelocidad.ForeColor = System.Drawing.Color.White;
            this.labelvelocidad.Location = new System.Drawing.Point(0, 49);
            this.labelvelocidad.Name = "labelvelocidad";
            this.labelvelocidad.Size = new System.Drawing.Size(61, 16);
            this.labelvelocidad.TabIndex = 7;
            this.labelvelocidad.Text = "Velocidad";
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCambio.ForeColor = System.Drawing.Color.White;
            this.labelCambio.Location = new System.Drawing.Point(0, 107);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(46, 16);
            this.labelCambio.TabIndex = 8;
            this.labelCambio.Text = "Cambio";
            // 
            // buttonAumentar
            // 
            this.buttonAumentar.BackColor = System.Drawing.Color.Lavender;
            this.buttonAumentar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAumentar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAumentar.ForeColor = System.Drawing.Color.Black;
            this.buttonAumentar.Location = new System.Drawing.Point(0, 250);
            this.buttonAumentar.Name = "buttonAumentar";
            this.buttonAumentar.Size = new System.Drawing.Size(36, 27);
            this.buttonAumentar.TabIndex = 9;
            this.buttonAumentar.Text = ">>";
            this.buttonAumentar.UseVisualStyleBackColor = false;
            this.buttonAumentar.Click += new System.EventHandler(this.buttonAumentar_Click);
            // 
            // labelRevoluciones
            // 
            this.labelRevoluciones.AutoSize = true;
            this.labelRevoluciones.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRevoluciones.ForeColor = System.Drawing.Color.White;
            this.labelRevoluciones.Location = new System.Drawing.Point(0, 79);
            this.labelRevoluciones.Name = "labelRevoluciones";
            this.labelRevoluciones.Size = new System.Drawing.Size(36, 16);
            this.labelRevoluciones.TabIndex = 11;
            this.labelRevoluciones.Text = "Rp/m";
            // 
            // buttonCancion
            // 
            this.buttonCancion.FlatAppearance.BorderSize = 0;
            this.buttonCancion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancion.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancion.Image")));
            this.buttonCancion.Location = new System.Drawing.Point(538, 140);
            this.buttonCancion.Name = "buttonCancion";
            this.buttonCancion.Size = new System.Drawing.Size(122, 95);
            this.buttonCancion.TabIndex = 12;
            this.buttonCancion.UseVisualStyleBackColor = true;
            this.buttonCancion.Click += new System.EventHandler(this.buttonCancion_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.Location = new System.Drawing.Point(528, 62);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(63, 72);
            this.buttonPlay.TabIndex = 14;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Image = ((System.Drawing.Image)(resources.GetObject("buttonStop.Image")));
            this.buttonStop.Location = new System.Drawing.Point(613, 66);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(66, 64);
            this.buttonStop.TabIndex = 15;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(509, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Reproductor MP3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.buttonEnd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 56);
            this.panel1.TabIndex = 17;
            // 
            // buttonEnd
            // 
            this.buttonEnd.BackColor = System.Drawing.Color.Lavender;
            this.buttonEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnd.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEnd.Location = new System.Drawing.Point(738, 0);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(82, 40);
            this.buttonEnd.TabIndex = 18;
            this.buttonEnd.Text = "SALIR";
            this.buttonEnd.UseVisualStyleBackColor = false;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "C# Tarea";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.labelRevoluciones);
            this.panel2.Controls.Add(this.labelvelocidad);
            this.panel2.Controls.Add(this.labelDato);
            this.panel2.Controls.Add(this.labelCambio);
            this.panel2.Location = new System.Drawing.Point(42, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 144);
            this.panel2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonCancion);
            this.Controls.Add(this.buttonAumentar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonFrenar);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.buttonCrearCarro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCrearCarro;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Button buttonFrenar;
        private System.Windows.Forms.Label labelDato;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Label labelvelocidad;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.Button buttonAumentar;
        private System.Windows.Forms.Label labelRevoluciones;
        private System.Windows.Forms.Button buttonCancion;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Panel panel2;
    }
}

