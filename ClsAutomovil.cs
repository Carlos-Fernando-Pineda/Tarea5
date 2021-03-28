using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploPOO.NewFolder
{
    class ClsAutomovil
    {
        public String marca { get; }
        public int vel_max { get; }
        public int rev_max { get; }
        private int revolucionesActuales { get; set; }
        private int Cambios { get; set; }
        private int velocidadActual { get; set; }
        private bool encendido = false;
        public String color { get; set; }

       


        public string Frenar()
        {
            velocidadActual = 0;
            revolucionesActuales = 0;
            Cambios = 1;
            return $"El carrito frenó";
        }

        public string Cambio()
        {
            Cambios = Cambios + 1;
            revolucionesActuales = revolucionesActuales - 2500;
            if (Cambios > 6)
            {
                return "Lo lamento, tu vehículo solo tiene 6 cambios";
            }else
            {
                return $"{Cambios}";
            }
        }
       
        public string Acelerar()
        {
            velocidadActual = velocidadActual + 10;
            if (velocidadActual > vel_max)
            {
                return "Lo lamento, llegaste a la velocidad máxima";
            }
            else
            {
                return $"Vas a {velocidadActual} KPH";
            }
        }
        
        public string AcelerarB()
        {
            revolucionesActuales = revolucionesActuales + 1000;
            if (revolucionesActuales > rev_max)
            {
                encendido = false;
                return "Lo lamento, llegaste a las RPM máxima, el carrito se apagará";
            }
            else if (revolucionesActuales > 2500)
            {
                return $"Vas a {revolucionesActuales} RPM, ya deberías de hacer un cambio";
            }
            else if (revolucionesActuales < 0)
            {
                revolucionesActuales = 0;
                return $"Estas en {revolucionesActuales} RPM, sigue acelerando!";
            }else
            {
                return $"Vas a {revolucionesActuales} RPM";
            }
        }

        public bool EstaEncendido()
        {
            return encendido;
        }


        public ClsAutomovil(string marcaCarro,int velocidadMx, int RevMx) 
        {
            this.marca = marcaCarro;
            this.vel_max = velocidadMx;
            this.rev_max = RevMx;
        }


        public String ApagarMotor()
        {
            if (encendido)
            {
                encendido = false;
                velocidadActual = 0;
                revolucionesActuales = 0;
                Cambios = 0;
                return "El carro se ha apagado";
            }
            else
            {
                return "El carro ya está apagado";
            }
        }


        public String EncenderMotor()
        {
            if (encendido)
            {
                return "El carro ya esta encendido";
            }
            else
            {
                encendido = true;
                velocidadActual = 0;
                revolucionesActuales = 0;
                Cambios = 1;
                return "Listo!!! Carro Encendido";
            }
            
        }
    }
}
