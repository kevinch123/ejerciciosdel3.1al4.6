namespace ejercicios
{
    public class program
    {
        public static void Main()
        {
            int PrecioN1 = 9500;
            int PrecioD1= 8500;
            int PrecioD2= 7500;
            int NumPla = 0;//Numero platillos
            int Cuenta = 0;
            

            Console.WriteLine("El precio noraml del platillo es de 9500, si el numero de platillos asciende a 200 pero menor o igual a 300 el precio sera 8500 ");
            Console.WriteLine("Si el numero el numero de personas asciendo de 300 el valor sera 7500 ");
            Console.WriteLine("Digite el numero de platillos");
            NumPla= Convert.ToInt32(Console.ReadLine());

            if (NumPla<200)
            {
                Cuenta = NumPla * PrecioN1;
                Console.WriteLine($"La taria de la cuenta es:{Cuenta}");
            }

            if(NumPla>200 && NumPla<=300)
            {
                Cuenta=PrecioD1*NumPla;
                Console.WriteLine($"La tarifa de la cuenta sera:{Cuenta}");
            }
            else if (NumPla > 300)
            {
                Cuenta = PrecioD2 * NumPla;

                Console.WriteLine($"La tarifa de la cuenta sera esta:{Cuenta}");
            }
            








        }
    }
}
