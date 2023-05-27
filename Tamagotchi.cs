

namespace Tamacotchi_v2._0
{
    internal class Tamagotchi
    {
        private const int DURACION = 400;
        private string nombre;
        private int hambre;
        private int sed;
        private int energia;
        private int aburrimiento;
        private int estadoAnimo;
        

        public Tamagotchi(string nombre)
        {
            this.nombre = nombre;
            hambre = 0;
            sed = 0;
            energia = 100;
            aburrimiento = 0;
            estadoAnimo = 100;
            
        }

        public void Alimentar()
        {
            
            hambre -= 20;
            if (hambre < 0)
                hambre = 0;
            ActualizarEstadoAnimo();
        }

        public void DarDeBeber()
        {
            
            Console.WriteLine(nombre + " ha sido hidratado.");
            sed -= 20;
            if (sed < 0)
                sed = 0;
            ActualizarEstadoAnimo();
        }

       

        public void Jugar()
        {
            
            Console.WriteLine("Has jugado con " + nombre + ".");
            
            hambre += 20;
            sed += 20;
            energia -= 20;
            aburrimiento -= 10;
            ActualizarEstadoAnimo();
        }

        public void Dormir()
        {
            energia = 100;
            Console.WriteLine(nombre + " ha dormido y ahora está descansado.");
            ActualizarEstadoAnimo();
        }

        private void ActualizarEstadoAnimo()
        {
            estadoAnimo = 100 - hambre - sed + energia - aburrimiento;
            if (estadoAnimo < 0)
                estadoAnimo = 0;
            else if (estadoAnimo > 100)
                estadoAnimo = 100;
        }

        public void MostrarEstado()
        {
            Console.Clear();
            Console.WriteLine("Estado de " + nombre + ":");
            Console.WriteLine("Hambre: " + hambre);
            Console.WriteLine("Sed: " + sed);
            Console.WriteLine("Energía: " + energia);
            Console.WriteLine("Aburrimiento: " + aburrimiento);
            Console.WriteLine("Estado de ánimo: " + estadoAnimo);
        }

        public void PasarTiempo()
        {
            hambre += 10;
            sed += 10;
            energia -= 10;
            aburrimiento += 10;

            ActualizarEstadoAnimo();

            Console.WriteLine(nombre + " ha pasado el tiempo.");

            if (estadoAnimo < 30)
            {
                Console.WriteLine(nombre + " se siente triste y enojado.");
                MostrarAnimacionTriste();
            }

            else if (hambre >= 50)
            {
                Console.WriteLine(nombre + " tiene hambre. ¡Dale de comer!");
                MostrarAnimacionHambriento();
            }

            else if (sed >= 50)
            {
                Console.WriteLine(nombre + " tiene sed. ¡Dale de beber!");
                MostrarAnimacionSediento();
            }

            else if (energia < 20)
            {
                Console.WriteLine(nombre + " está agotado. ¡Déjalo dormir!");
                MostrarAnimacionAgotado();
            }

            else if (aburrimiento >= 70)
            {
                Console.WriteLine(nombre + " está aburrido. ¡Juega con él!");
                MostrarAnimacionAburrido();
            }
        }

        public void MostrarAnimacionTriste()
        {
            Console.Clear();
            Console.WriteLine("        /\\_/\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("       ( T.T )");
            Thread.Sleep(DURACION);
            Console.WriteLine("      /  -  \\");
            Thread.Sleep(DURACION);
            Console.WriteLine("     /  `---'\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("    |    ( )  |");
            Thread.Sleep(DURACION);
            Console.WriteLine("     \\. ..  /");
            Thread.Sleep(DURACION);
            Console.WriteLine("      `\"\"\"\"\"\"`");
        }

        public void MostrarAnimacionHambriento()
        {
            Console.Clear();
            Console.WriteLine("        /\\_/\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("       ( >.< )");
            Thread.Sleep(DURACION);
            Console.WriteLine("      /  v  \\");
            Thread.Sleep(DURACION);
            Console.WriteLine("     /  `---'\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("    |   (x_x) |");
            Thread.Sleep(DURACION);
            Console.WriteLine("     \\. ..  /");
            Thread.Sleep(DURACION);
            Console.WriteLine("      `\"\"\"\"\"\"`");
           
        }

        public void MostrarAnimacionSediento()
        {
            Console.Clear();
            Console.WriteLine("        /\\_/\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("       ( >v< )");
            Thread.Sleep(DURACION);
            Console.WriteLine("      /  v  \\");
            Thread.Sleep(DURACION);
            Console.WriteLine("     /  `---'\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("    |   (x_x) |");
            Thread.Sleep(DURACION);
            Console.WriteLine("     \\. ..  /");
            Thread.Sleep(DURACION);
            Console.WriteLine("      `\"\"\"\"\"\"`");
           
        }

        public void MostrarAnimacionAgotado()
        {
            Console.Clear();
            Console.WriteLine("        /\\_/\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("       ( '>.< )");
            Thread.Sleep(DURACION);
            Console.WriteLine("      /  v  \\");
            Thread.Sleep(DURACION);
            Console.WriteLine("     /  `---'\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("    |   (x_x) |");
            Thread.Sleep(DURACION);
            Console.WriteLine("     \\. ..  /");
            Thread.Sleep(DURACION);
            Console.WriteLine("      `\"\"\"\"\"\"`");
        }

        public void MostrarAnimacionAburrido()
        {
            Console.Clear();
            Console.WriteLine("        /\\_/\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("       ( >.< )");
            Thread.Sleep(DURACION);
            Console.WriteLine("      /  v  \\");
            Thread.Sleep(DURACION);
            Console.WriteLine("     /  `---'\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("    |   (x_x) |");
            Thread.Sleep(DURACION);
            Console.WriteLine("     \\. ..  /");
            Thread.Sleep(DURACION);
            Console.WriteLine("      `\"\"\"\"\"\"`");
            
        }
        public void MostrarAnimacionDormir()
        {
            Console.Clear();
            Console.WriteLine("        /\\_/\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("       (-.- )");
            Thread.Sleep(DURACION);
            Console.WriteLine("      /  v  \\");
            Thread.Sleep(DURACION);
            Console.WriteLine("     /  `---'\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("    |   ( z ) |");
            Thread.Sleep(DURACION);
            Console.WriteLine("     \\. ..  /");
            Thread.Sleep(DURACION);
            Console.WriteLine("      `\"\"\"\"\"\"`");
        }
        public void MostrarAnimacionComer()
        {
            Console.Clear();
            Console.WriteLine("        /\\_/\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("       ( o.o )");
            Thread.Sleep(DURACION);
            Console.WriteLine("      /  v  \\");
            Thread.Sleep(DURACION);
            Console.WriteLine("     /  `---'\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("    |   (Y)  |");
            Thread.Sleep(DURACION);
            Console.WriteLine("     \\. ..  /");
            Thread.Sleep(DURACION);
            Console.WriteLine("      `\"\"\"\"\"\"`");
        }

        public void MostrarAnimacionJugando()
        {
            Console.Clear();
            Console.WriteLine("        /\\_/\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("       ( ^_^ )");
            Thread.Sleep(DURACION);
            Console.WriteLine("      /  -  \\");
            Thread.Sleep(DURACION);
            Console.WriteLine("     /  `---'\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("    |    (o)  |");
            Thread.Sleep(DURACION);
            Console.WriteLine("     \\. ..  /");
            Thread.Sleep(DURACION);
            Console.WriteLine("      `\"\"\"\"\"\"`");
        }

        public void MostrarAnimacionPlayer()
        {
            Console.Clear();
            Console.WriteLine("        /\\_/\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("       ( ^_^ )");
            Thread.Sleep(DURACION);
            Console.WriteLine("      /  -  \\");
            Thread.Sleep(DURACION);
            Console.WriteLine("     /  `---'\\");
            Thread.Sleep(DURACION);
            Console.WriteLine("    |    (o)  |");
            Thread.Sleep(DURACION);
            Console.WriteLine("     \\. ..  /");
            Thread.Sleep(DURACION);
            Console.WriteLine("      `\"\"\"\"\"\"`");
        }
    }
}


