namespace MVC
{
    internal class ShopController
    {
        public Model model;
        public ShopController(Model model)
        {
            this.model = model;
        }

        public string Question(string order, string nameData)
        {
            return "At the moment we have the product : "
                + model.GetAnser(order,nameData);
        }

        public void ReadDataFile(string nameData)
        {
            model.GetData(nameData);
        }
    }
}