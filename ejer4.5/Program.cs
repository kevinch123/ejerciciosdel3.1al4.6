namespace ejercicio
{
    public class program
    {
        public static void Main()
        {
            double su = 0;
            double i = 1;
            double estatura = 1;
            double promedio = 0;

            Console.WriteLine("Cuando quiera terminar con la suma de estaturas , escribe 0 como una estatura y le da el promedio");

            while (estatura>0)
            {
                su = su + estatura;
                Console.WriteLine("digite las estaturas");
                estatura=Convert.ToDouble(Console.ReadLine());

                if (estatura>0)
                {
                    i++;
                    su=su+ estatura;
                    promedio=su/i;
                }

              

            }
            Console.WriteLine($"El promedio es :{promedio}");
        }
    }

}