using System;
using System.Collections.Generic;
using System.Text;

namespace POO_01
{
    class Vehiculo
    {
        private string marca;
        private string modelo;
        
        public void SetVehiculo(string marc, string model)
        {
            marca = marc;
            modelo = model;
        }
        public void verVehiculo()
        {
            Console.WriteLine("El Vehiculo es:  "+marca+"\n Modelo: "+modelo);
            Console.ReadKey();
        }
    }
}
