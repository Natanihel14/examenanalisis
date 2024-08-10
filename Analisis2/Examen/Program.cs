// Clase principal del programa
public class Program
{
    public static void Main()
    {
        // Crear instancias de Automovil y Bicicleta
        IVehiculo vehiculo1 = new Automovil();
        IVehiculo vehiculo2 = new Bicicleta();

        // Crear una instancia del gestor de vehículos
        GestorDeVehiculos gestor = new GestorDeVehiculos();

        // Registrar los vehículos en el gestor
        gestor.RegistrarVehiculo(vehiculo1);
        gestor.RegistrarVehiculo(vehiculo2);

        // Mostrar el menú al usuario
        gestor.MostrarMenu();
    }
}