namespace studycase1213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PILIH PROGRAM");

            Console.WriteLine("1. Program mencari nilai terbesar dan terkecil");
            Console.WriteLine("1. Program mencari akar");

            Console.Write("pilih 1 atau 2 : ");
            double pilih = Convert.ToDouble(Console.ReadLine());


            if (pilih == 1)
            {

                Console.Write("Masukan nilai 1: ");
                double nilai1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukan nilai 2: ");
                double nilai2 = Convert.ToDouble(Console.ReadLine());

                if (nilai1 < nilai2)
                {
                    Console.WriteLine($"{nilai1} lebih kecil dari {nilai2}");
                }
                else
                {
                    Console.WriteLine($"{nilai2} lebih besar dari {nilai1}");
                }
            }

            else if (pilih == 2) 
            {
                Console.WriteLine("PROGRAM MENCARI AKAR");
                Console.Write("Masukan nilai : ");
                double nialii = Convert.ToDouble(Console.ReadLine());
             
                double result = Math.Sqrt(nialii);
                double bulat = Math.Round(result);
                Console.Write($"Akar dari {nialii} adalah {bulat}");
            }

            else
            {

            }

            
        }
    }
}