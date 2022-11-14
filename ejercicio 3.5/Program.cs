namespace ejercicio
{
    public class program
    {
        public static void Main()
        {
            int num1=0;
            int num2=0;
            int num3=0;

            Console.WriteLine("Estas 3 cantidades se comparan y sabremos cual es la mayor ");

            Console.WriteLine("Digite a primera cantidad");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite la segunda cantidad");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite la tercera cantidad");
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2 && num1>num3)
            {
                Console.WriteLine($"la cantidad mayor sera:{num1}");
            }
            if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine($"la cantidad mayor sera:{num2}");
            }
            if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"la cantidad mayor sera:{num3}");
            }




        }
    }
}