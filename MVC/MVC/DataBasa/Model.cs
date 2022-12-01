namespace MVC
{
    internal class Model
    {
        public string GetAnser(string order, string nameData)
        {
            return DataBase.GetAnser(order, nameData);
        }

        public void GetData(string nameData)
        {
            DataBase.GetData(nameData);
        }
    }
}