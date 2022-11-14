namespace ejercicio
{
    public class program
    {
        public static void Main()
        {
            int precioN = 90;
            int precioD = 85;
            int CantidadL = 0;
            int PrecioP = 0;

            Console.WriteLine("Si compra mas de 1000 lapices el valor sera 85$ pero si compra menos de mil sera de 90$");

            Console.WriteLine("Digite el numero de lapices que desea comprar");
            CantidadL = Convert.ToInt32(Console.ReadLine());

            if(CantidadL>1000)
            {
                PrecioP=CantidadL*precioD;

                Console.WriteLine($"El total a pagar es :{PrecioP}");
            }
            else
            {
                PrecioP = CantidadL*precioN;
                Console.WriteLine($"El total a pagar sera:{PrecioP}");
            }



        }
    }
}