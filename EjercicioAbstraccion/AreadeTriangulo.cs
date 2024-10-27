namespace EjercicioAbstraccion
{
    class AreaTriangulo : FormulaMatematica
    {
        private double baseTriangulo;
        private double altura;
        private double area;

        // Asegúrate de que el nombre del constructor sea idéntico al nombre de la clase
        public AreaTriangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public override void Calcular()
        {
            area = (baseTriangulo * altura) / 2;
        }

        public override void Imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine($"El área del triángulo con base {baseTriangulo} y altura {altura} es: {area}");
        }
    }

}
