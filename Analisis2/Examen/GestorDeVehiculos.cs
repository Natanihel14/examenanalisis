// Clase GestorDeVehiculos que gestiona los vehículos
public class GestorDeVehiculos
{
    private List<IVehiculo> vehiculos = new List<IVehiculo>();  // Lista para almacenar vehículos

    // Método para registrar un vehículo
    public void RegistrarVehiculo(IVehiculo vehiculo)
    {
        vehiculos.Add(vehiculo);
    }

    // Método para mostrar el menú e interactuar con el usuario
    public void MostrarMenu()
    {
        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Iniciar un vehículo específico");
            Console.WriteLine("2. Detener un vehículo específico");
            Console.WriteLine("3. Iniciar todos los vehículos");
            Console.WriteLine("4. Detener todos los vehículos");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    IniciarVehiculoEspecifico();
                    break;
                case 2:
                    DetenerVehiculoEspecifico();
                    break;
                case 3:
                    IniciarTodosLosVehiculos();
                    break;
                case 4:
                    DetenerTodosLosVehiculos();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine(); // Espacio en blanco entre operaciones
        }
    }

    // Método para iniciar un vehículo específico
    private void IniciarVehiculoEspecifico()
    {
        int indice = SeleccionarVehiculo();
        if (indice >= 0 && indice < vehiculos.Count)
        {
            vehiculos[indice].Iniciar();
        }
        else
        {
            Console.WriteLine("Vehículo no válido.");
        }
    }

    // Método para detener un vehículo específico
    private void DetenerVehiculoEspecifico()
    {
        int indice = SeleccionarVehiculo();
        if (indice >= 0 && indice < vehiculos.Count)
        {
            vehiculos[indice].Detener();
        }
        else
        {
            Console.WriteLine("Vehículo no válido.");
        }
    }

    // Método para iniciar todos los vehículos registrados
    private void IniciarTodosLosVehiculos()
    {
        foreach (var vehiculo in vehiculos)
        {
            vehiculo.Iniciar();
        }
    }

    // Método para detener todos los vehículos registrados
    private void DetenerTodosLosVehiculos()
    {
        foreach (var vehiculo in vehiculos)
        {
            vehiculo.Detener();
        }
    }

    // Método para seleccionar un vehículo
    private int SeleccionarVehiculo()
    {
        Console.WriteLine("Seleccione el vehículo:");
        for (int i = 0; i < vehiculos.Count; i++)
        {
            Console.WriteLine($"{i}. {vehiculos[i].GetType().Name}");
        }
        Console.Write("Ingrese el número del vehículo: ");
        int indice = int.Parse(Console.ReadLine());
        return indice;
    }
}