using EjercicioAbstraccion;

class Program
{
    static void Main(string[] args)
    {
        while (true) {
            Console.WriteLine("");
            Console.WriteLine("Menu de opciones:");
            Console.WriteLine("1. Calcular area de triangulo");
            Console.WriteLine("2. Convertir Kilometros a Millas");
            Console.WriteLine("3. Calcular volumen de cilindro");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Seleccione una opcion: ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            FormulaMatematica formula = null;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la base del triangulo: ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triangulo: ");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    formula = new AreaTriangulo(baseTriangulo, altura);
                    break;

                case 2:
                    Console.WriteLine("Ingrese la distancia en kilometros: ");
                    double kilometros = Convert.ToDouble(Console.ReadLine());
                    formula = new ConvertirKilometrosaMillas(kilometros);
                    break;

                case 3:
                    Console.WriteLine("Ingrese el radio del cilindro: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del cilindro: ");
                    double alturaCilindro = Convert.ToDouble(Console.ReadLine());
                    formula = new VolumenCilindro(radio, alturaCilindro);
                    break;

                case 4:
                    Console.WriteLine("Saliendo del Programa....");
                    return;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

            formula.Calcular();
            formula.Imprimir();

        }
    }
}
