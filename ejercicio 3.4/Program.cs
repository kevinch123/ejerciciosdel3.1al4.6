namespace ejercicio
{
    public class program
    {
        public static void Main()
        {
            Double descuentoP = 0.15;
            double descuentoS = 0.08;
            double itemDescuento = 0;
            double PrecioF = 0;
            int valorD = 0;

            Console.WriteLine("El descuento del traje es :si  el valor es mayor a 250000 se le aplicara un descuento del 15% de lo contrario solo sera de 8%");

            Console.WriteLine("Digite el valor del traje");
             valorD= Convert.ToInt32(Console.ReadLine());

            if (valorD>250000)
            {
                itemDescuento= valorD*descuentoP;
                PrecioF= valorD-itemDescuento;
                
                Console.WriteLine($"El precio final con el descuento aplicado sera:{PrecioF}");
            }
            else if (valorD<250000)
            {
                itemDescuento = valorD * descuentoS;
                PrecioF = valorD - itemDescuento;
                Console.WriteLine($"El precio final con el descuento aplicado sera:{PrecioF}");
            }


        }
    }
}