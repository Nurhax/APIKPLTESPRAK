namespace TesprakKPL
{
    public class SingletonMain
    {
        public static void Main(string[] args)
        {
            Database data1 = Database.GetInstance();
            Database data2 = Database.GetInstance();    

            if(data1.getDataPrime().Count == data2.getDataPrime().Count)
            {
                Console.WriteLine("Instance yang sama, sehingga singleton");
            }
            else
            {
                Console.WriteLine("Singleton gagal, terjadi kesalahan");
            }

        }
    }
}
