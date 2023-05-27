using Tamacotchi_v2._0;

Console.WriteLine("¡Bienvenido a tu Tamagotchi!");

Console.Write("Ingresa el nombre de tu Tamagotchi: ");
string nombre = Console.ReadLine();

Tamagotchi miTamagotchi = new Tamagotchi(nombre);
miTamagotchi.MostrarAnimacionPlayer();

bool salir = false;

while (!salir)
{
    Console.WriteLine("\nElige una acción:");
    Console.WriteLine("1. Alimentar");
    Console.WriteLine("2. Dar de beber");
    Console.WriteLine("3. Jugar");
    Console.WriteLine("4. Dormir");
    Console.WriteLine("5. Mostrar estado");
    Console.WriteLine("6. Salir");

    Console.Write("Opción: ");
    string opcion = Console.ReadLine();

    Console.WriteLine();

    switch (opcion)
    {
        case "1":
            miTamagotchi.Alimentar();
            miTamagotchi.MostrarAnimacionComer();
            break;
        case "2":
            miTamagotchi.DarDeBeber();
            miTamagotchi.MostrarAnimacionSediento();
            break;

        case "3":
            miTamagotchi.Jugar();
            miTamagotchi.MostrarAnimacionJugando();
            break;
        case "4":
            miTamagotchi.Dormir();
            miTamagotchi.MostrarAnimacionDormir();
            break;
        case "5":
            miTamagotchi.MostrarEstado();
            break;
        case "6":
            salir = true;
            Console.WriteLine("¡Hasta luego!");
            break;
        default:
            Console.WriteLine("Opción inválida. Intenta de nuevo.");
            break;
    }

    miTamagotchi.PasarTiempo();
}
    