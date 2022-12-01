namespace MVC
{
    internal class ProductsViewShop : View
    {
        const string NAME_DEPARTMENT = " - Produce department  ";
        const string DATA_PRODUCT = "C:\\Users\\User\\source\\repos\\MVC\\MVC\\DataBasa\\Data\\ProductsData.txt";
        public ProductsViewShop()
        {
            Console.WriteLine(NAME_DEPARTMENT);
        }
        public override void SendCommand()
        {
            ShopController controller = new(new Model());
            controller.ReadDataFile(DATA_PRODUCT);
            while (isEmpty)
            {
                Console.Write("Enter Product : ");
                inputCommand = Console.ReadLine();

                CheckCommandIsNull = inputCommand;

                if (isEmpty) return;
                Console.WriteLine(controller.Question(inputCommand, DATA_PRODUCT));
            }
        }
    }
}