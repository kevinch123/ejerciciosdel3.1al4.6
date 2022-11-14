namespace ejercicios
{
    public class program
    {
        public static void Main()
        {
            int i=1;
            int suma=0;
            int num=0;
            Console.WriteLine(" se sumaran 10 numeros digitados por teclado");

            while(i<=10)
            {
                Console.WriteLine("Ingrese los numeros");
                num=Convert.ToInt32(Console.ReadLine());

                suma=suma+num;
                i++;

                
            }
            Console.WriteLine($"la suma de los sumeros sera{suma}");

            

        }
    }

}
    

