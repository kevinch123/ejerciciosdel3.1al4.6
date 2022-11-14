namespace ejercicios
{
    public class program
    {
        public static void Main()
        {
            double minutos = 0;
            string turno;
            string dia;
            double precio=0;
            double precio2 = 0;
            double precio3 = 0;


            Console.WriteLine("CHIMEFON-chismea +*- ");
            Console.WriteLine("Los minutos se empezaran a contar despues de los 5 minutos");
            Console.WriteLine("los cinco primeros minutos equivalen a 1.00$ los siguientes 3 80$ los siguientes dos 70$ y despes de los 10 50$");
            Console.WriteLine("Impuestos cuando es domingo 3% turno matutino 15% y en turno vesperino 10%");

            Console.WriteLine("Digite los minutos de la llamada");
            minutos = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el tipo de turno matutino,vesperino");
            turno = Console.ReadLine();

            Console.WriteLine("Digite el dia ");
            dia = Console.ReadLine();

            if(minutos==5||minutos==6||minutos==7)
            {
                if(dia=="lunes"||dia=="martes"||dia=="miercoles"||dia=="jueves"||dia== "vierenes"||dia=="LUNES"||dia=="MARTES"||dia=="MIERCOLES"||dia=="JUEVES"||dia=="VIERNES")
                {
                    if(turno=="matutino")
                    {
                        precio = minutos*1.00;
                        precio2 = precio * 0.15;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                    if(turno=="vesperino")
                    {
                        precio = minutos * 1.00;
                        precio2 = precio * 0.10;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                }
                if (dia=="domingo")
                {
                    if (turno == "matutino")
                    {
                        precio = minutos * 1.00;
                        precio2 = precio * 0.18;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                    if (turno == "vesperino")
                    {
                        precio = minutos * 1.00;
                        precio2 = precio * 0.13;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                }
            }
            if (minutos == 8||minutos==9)
            {
                if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "vierenes" || dia == "LUNES" || dia == "MARTES" || dia == "MIERCOLES" || dia == "JUEVES" || dia == "VIERNES")
                {
                    if (turno == "matutino")
                    {
                        precio = minutos * 80;
                        precio2 = precio * 0.15;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                    if (turno == "vesperino")
                    {
                        precio = minutos * 1.00;
                        precio2 = precio * 0.10;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                }
                if (dia == "domingo")
                {
                    if (turno == "matutino")
                    {
                        precio = minutos * 1.00;
                        precio2 = precio * 0.18;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                    if (turno == "vesperino")
                    {
                        precio = minutos * 1.00;
                        precio2 = precio * 0.13;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                }
            }
            if (minutos ==10)
            {
                if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "vierenes" || dia == "LUNES" || dia == "MARTES" || dia == "MIERCOLES" || dia == "JUEVES" || dia == "VIERNES")
                {
                    if (turno == "matutino")
                    {
                        precio = minutos * 70;
                        precio2 = precio * 0.15;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                    if (turno == "vesperino")
                    {
                        precio = minutos * 1.00;
                        precio2 = precio * 0.10;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                }
                if (dia == "domingo")
                {
                    if (turno == "matutino")
                    {
                        precio = minutos * 1.00;
                        precio2 = precio * 0.18;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                    if (turno == "vesperino")
                    {
                        precio = minutos * 1.00;
                        precio2 = precio * 0.13;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                }
            }
            if (minutos >10)
            {
                if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "vierenes" || dia == "LUNES" || dia == "MARTES" || dia == "MIERCOLES" || dia == "JUEVES" || dia == "VIERNES")
                {
                    if (turno == "matutino")
                    {
                        precio = minutos * 50;
                        precio2 = precio * 0.15;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                    if (turno == "vesperino")
                    {
                        precio = minutos * 1.00;
                        precio2 = precio * 0.10;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                }
                if (dia == "domingo")
                {
                    if (turno == "matutino")
                    {
                        precio = minutos * 1.00;
                        precio2 = precio * 0.18;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                    if (turno == "vesperino")
                    {
                        precio = minutos * 1.00;
                        precio2 = precio * 0.13;
                        precio3 = precio2 + precio;

                        Console.WriteLine($"El total a pagar sera :{precio3}");

                    }
                }
            }



        }
    }
}
