// Implementación de la interfaz IVehiculo en la clase Automovil
public class Automovil : IVehiculo
{
    public void Iniciar()
    {
        Console.WriteLine("El automóvil ha iniciado.");
    }

    public void Detener()
    {
        Console.WriteLine("El automóvil se ha detenido.");
    }
}