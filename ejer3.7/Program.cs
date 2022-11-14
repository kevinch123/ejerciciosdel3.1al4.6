namespace ejercicio
{
    public class program
    {
        public static void Main()
        {
            String Tipo;//Tipo de uva
            int PrecioD;//Precio dado
            int T1;//Tamaño uva
            int Precio;//precio final



            Console.WriteLine("Si  la uva es de tipo A y tamaño 1 se le aumentara 20$  al precio si es de tamaño 2 30$ al precio");
            Console.WriteLine("Si  la uva es de tipo B y tamaño 1 se le reducira  30$ al precio  si es de tamaño 2 50$ al precio ");

            Console.WriteLine("Digite el Precio de la uva por kilo");
            PrecioD = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el tipo de uva A o B");
            Tipo =Console.ReadLine();



            if (Tipo=="A" || Tipo=="a")
            {
                Console.WriteLine("Digite el tamaño de uva 1 o 2");
                T1 = Convert.ToInt32(Console.ReadLine());

                if (T1==1)
                {
                    Precio = PrecioD + 20;
                    Console.WriteLine($"El total con el aumento por el tipo de uva y su tamaño sera:{Precio}");

                }
                else if (T1==2)
                {
                    Precio = PrecioD + 30;
                    Console.WriteLine($"El total con el aumento por el tipo de uva y su tamaño sera:{Precio}");
                }


            }

            if (Tipo =="B"|| Tipo=="b")
            {
                Console.WriteLine("Digite el tamaño de uva 1 o 2");
                T1 = Convert.ToInt32(Console.ReadLine());

                if (T1 == 1)
                {
                    Precio = PrecioD -30 ;
                    Console.WriteLine($"El total con el aumento por el tipo de uva y su tamaño sera:{Precio}");

                }
                else if (T1 == 2)
                {
                    Precio = PrecioD -50 ;
                    Console.WriteLine($"El total con el aumento por el tipo de uva y su tamaño sera:{Precio}");
                }


            }


        }
    }
}
