namespace ejercicios
{
    public class program
    {
        public static void Main()
        {
            int citas = 0;
            int pago = 0;
            int citas2=200 ;
            int citas34=150 ;
            int citas567=100 ;
            int citasS=50 ;
            int total = 0;

            Console.WriteLine("Consultorio Doctor Lorenzo");

            Console.WriteLine("Digite la cita en la que va");
            citas = Convert.ToInt32(Console.ReadLine());

            if (citas <=3)
            {
                citas2 = 200;
                total = citas * citas2;
                Console.WriteLine($"El total que ha pagado por el tratamiendo sera:{total}");
                Console.WriteLine($"El valor de la cita sera de :{citas2}");
            }
            else
            {
                if (citas <= 5)
                {
                    citas34 = 150;
                    total = ((citas - 3) * citas34) + 600;
                    Console.WriteLine($"El total que ha pagado por el tratamiendo sera:{total}");
                    Console.WriteLine($"El valor de la cita sera de :{citas34}");

                }
                else
                {
                    if(citas<=8)
                    {
                        citas567 = 100;
                        total =((citas-5) * citas567) + 900;
                        Console.WriteLine($"El total que ha pagado por el tratamiendo sera:{total}");
                        Console.WriteLine($"El valor de la cita sera de :{citas567}");
                    }
                    else if (citas>8)

                    {
                        citasS = 50;
                        total = ((citas - 8) * citasS) + 1200;
                        Console.WriteLine($"El total que ha pagado por el tratamiendo sera:{total}");
                        Console.WriteLine($"El valor de la cita sera de :{citasS}");
                    }
                }

            }

            





        }
    }
}
