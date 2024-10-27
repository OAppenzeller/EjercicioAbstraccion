namespace EjercicioAbstraccion
{
    class AreadeTriangulo : FormulaMatematica
    {
        private double baseTriangulo;
        private double alturaTriangulo;
        private double area;

        public void AreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
        }

        public override void Calcular()
        {
            area = (baseTriangulo * alturaTriangulo) / 2;
           
        }

        public override void Imprimir()
        {
            Console.WriteLine("El area del triangulo es: " + area);
        }
    }
}
