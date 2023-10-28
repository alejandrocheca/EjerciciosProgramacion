using System;

// Definición de una interfaz para calcular el costo de alquiler
public interface IAlquiler
{
    double CalcularCostoAlquiler(int dias);
}

// Clase base para Vehículo
public abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }

    public Vehiculo(string marca, string modelo, int anio)
    {
        Marca = marca;
        Modelo = modelo;
        Anio = anio;
    }

    public abstract void MostrarInformacion();
}

// Clases derivadas de Vehiculo
public class Coche : Vehiculo, IAlquiler
{
    public int Pasajeros { get; set; }

    public Coche(string marca, string modelo, int anio, int pasajeros) : base(marca, modelo, anio)
    {
        Pasajeros = pasajeros;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Coche: {Marca} {Modelo} ({Anio}), {Pasajeros} pasajeros");
    }

    public double CalcularCostoAlquiler(int dias)
    {
        return 50.0 * dias;
    }
}

public class Camion : Vehiculo, IAlquiler
{
    public double CapacidadCarga { get; set; }

    public Camion(string marca, string modelo, int anio, double capacidadCarga) : base(marca, modelo, anio)
    {
        CapacidadCarga = capacidadCarga;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Camión: {Marca} {Modelo} ({Anio}), Capacidad de carga: {CapacidadCarga} toneladas");
    }

    public double CalcularCostoAlquiler(int dias)
    {
        return 100.0 * dias;
    }
}

class Program
{
    static void Main()
    {
        Coche coche = new Coche("Toyota", "Corolla", 2022, 5);
        Camion camion = new Camion("Volvo", "VNL", 2020, 10.0);

        Vehiculo[] vehiculos = { coche, camion };

        foreach (var vehiculo in vehiculos)
        {
            vehiculo.MostrarInformacion();
            Console.WriteLine($"Costo de alquiler por 7 días: {vehiculo.CalcularCostoAlquiler(7):C}\n");
        }
    }
}
