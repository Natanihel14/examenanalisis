// Implementación de la interfaz IVehiculo en la clase Bicicleta
public class Bicicleta : IVehiculo
{
    public void Iniciar()
    {
        Console.WriteLine("La bicicleta ha comenzado a moverse.");
    }

    public void Detener()
    {
        Console.WriteLine("La bicicleta se ha detenido.");
    }
}