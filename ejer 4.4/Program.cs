namespace ejercicios
{
    public class program
    {
        public static void Main()
        {
            int suma = 0;
            int promedio = 0;
            int i = 1;
            int NumE = 0;
            int edad = 0;

            Console.WriteLine("Sacaremos el promedio de la edad de los estudiantes ");
            Console.WriteLine("Digite el numero de estudiantes ");
            NumE=Convert.ToInt32(Console.ReadLine());

            while(i<=NumE)
            {
                Console.WriteLine("Digite las edades de los estudiantes ");
                edad = Convert.ToInt32(Console.ReadLine());

                suma = suma + edad;
                i++;

            }
            promedio=suma/NumE;
            Console.WriteLine($"El promedio de las edades es:{promedio} ");
   



        }
    }

}
