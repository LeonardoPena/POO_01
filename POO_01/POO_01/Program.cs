using System;

namespace POO_01
{
    class mostrarVehiculo
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Vehiculo Carro1 = new Vehiculo();
            Vehiculo Carro2 = new Vehiculo();

            string marca, modelo;
            Console.Write("Vehiculo1: \n\n\nIngrese la Marca del vehiculo:");
            marca = Console.ReadLine();
            Console.Write("Ingrese el Modelo del vehiculo:");
            modelo = Console.ReadLine();

            Carro1.SetVehiculo(marca, modelo);
            Console.Clear();

            Console.Write("Vehiculo 2: \n\n\nIngrese la Marca del vehiculo:");
            marca = Console.ReadLine();
            Console.Write("Ingrese el Modelo del vehiculo:");
            modelo = Console.ReadLine();

            Carro2.SetVehiculo(marca, modelo);

            Console.ReadKey();

            Console.Clear();
            Carro1.verVehiculo();
            Carro2.verVehiculo();

            
        }
    }
}
