namespace EjercicioAbstraccion
{
    class ConvertirKilometrosaMillas : FormulaMatematica
    {
        private double kilometros;
        private double millas;

        public ConvertirKilometrosaMillas(double kilometros)
        {
            this.kilometros = kilometros;

        }

        public override void Calcular()
        {
            millas = kilometros / 0.621371;
        }

        public override void Imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine("La distancia en millas es: " + millas);
        }

    }

}
