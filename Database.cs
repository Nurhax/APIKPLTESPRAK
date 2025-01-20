namespace TesprakKPL
{
    public class Database
    {
        private Database() { }

        private static Database _instance;

        public static Database GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Database();
            }
            return _instance;
        }

        public List<int> getDataPrime()
        {
            List<int> listPrime = new List<int>
            {
                2,3,5,7,9,11,13
            };

            return listPrime;
        }
    }
}
