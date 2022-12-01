namespace MVC
{
    internal class ToysViewShop : View
    {    
        const string NAME_DEPARTMENT = " - Toy department  ";
        const string DATA_PRODUCT = "C:\\Users\\User\\source\\repos\\MVC\\MVC\\DataBasa\\Data\\ToysData.txt";
        public ToysViewShop()
        {
            Console.WriteLine(NAME_DEPARTMENT);
        }
        public override void SendCommand()
        {
            ShopController controller = new(new Model());
            controller.ReadDataFile(DATA_PRODUCT);
            while (isEmpty)
            {
                Console.Write("Enter Toys : ");
                inputCommand = Console.ReadLine();

                CheckCommandIsNull = inputCommand;

                if (isEmpty) return;
                Console.WriteLine(controller.Question(inputCommand, DATA_PRODUCT));
            }
        }
    }
}