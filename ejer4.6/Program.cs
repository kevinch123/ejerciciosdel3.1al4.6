namespace ejercicio
{
    public class program
    {
        public static void Main()
        {
            int Ahorros=0;
            double promedio = 0;
            int i=1;
            int cantidadD = 0;

            while (i<=12)
            {
                Console.WriteLine("digite la cantidad de ahorrara");
                cantidadD = Convert.ToInt32(Console.ReadLine());
                
                Ahorros=Ahorros+cantidadD;
                i++;

                Console.WriteLine($"El ahorro del mes es {i},es :{Ahorros}");

            }
            Console.WriteLine($"El ahorro final es :{Ahorros}");

        }
    }
}
