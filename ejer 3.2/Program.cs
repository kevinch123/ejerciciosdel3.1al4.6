namespace ejercicio
{
    public class program
    {
        public static void Main()
        {
            int numb;

            Console.WriteLine("Digite un numero y le diremos si es negativo o positivo");

            Console.WriteLine("Digite el  numero");
            numb = Convert.ToInt32(Console.ReadLine());

            if (numb < 0)
            {
                Console.WriteLine($"El numero es negativo:{numb}");
            }
            else
            {
                Console.WriteLine($"El numero es positivo:{numb}");
            }
        }
    }
}
