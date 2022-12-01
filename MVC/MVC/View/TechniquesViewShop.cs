namespace MVC
{
    internal class TechniquesViewShop : View
    {
        const string NAME_DEPARTMENT = " - Technology department  ";
        const string DATA_PRODUCT = "C:\\Users\\User\\source\\repos\\MVC\\MVC\\DataBasa\\Data\\TechniquesData.txt";
        public TechniquesViewShop()
        {
            Console.WriteLine(NAME_DEPARTMENT);
        }
        public override void SendCommand()
        {
            ShopController controller = new(new Model());
            controller.ReadDataFile(DATA_PRODUCT);
            while (isEmpty)
            {
                Console.Write("Enter Techique : ");
                inputCommand = Console.ReadLine();

                CheckCommandIsNull = inputCommand;

                if (isEmpty) return;
                Console.WriteLine(controller.Question(inputCommand, DATA_PRODUCT));
            }
        }
    }
}