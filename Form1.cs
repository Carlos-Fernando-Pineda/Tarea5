using EjemploPOO.NewFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploPOO
{
    public partial class Form1 : Form
    {
        private Mp3Player mp3Player = new Mp3Player();
        ClsAutomovil carrito;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crear el carro
            carrito = new ClsAutomovil("Honda",180,7000);
            carrito.color = "Azul";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            string respuesta = carrito.EncenderMotor();
            labelDato.Text = respuesta;
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelvelocidad.Text = carrito.Acelerar();
                labelRevoluciones.Text = carrito.AcelerarB();
            }
            else
            {
                MessageBox.Show($"Lo lamento el carro {carrito.marca} esta apagado");
            }
        }

        private void buttonFrenar_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelvelocidad.Text = carrito.Frenar();
                labelRevoluciones.Text = "";
            }
            else
            {
                MessageBox.Show($"Lo lamento el carro {carrito.marca} no se esta moviendo");
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            string respuesta = carrito.ApagarMotor();
            labelDato.Text = respuesta;
            labelvelocidad.Text = carrito.Frenar();
            labelRevoluciones.Text = "";
        }

        private void buttonAumentar_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                labelCambio.Text = carrito.Cambio();
            }else
            {
                MessageBox.Show($"Lo lamento, el carro {carrito.marca} esta apagado");
            }
                
        }

        private void buttonCancion_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd.FileName);
                }
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        { 
                mp3Player.play();  
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
                mp3Player.stop();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
