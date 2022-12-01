namespace MVC
{
    internal abstract class View : IView
    {
        protected string inputCommand = "";
        protected bool isEmpty = true;

        public string CheckCommandIsNull
        {
            get
            {
                return inputCommand;
            }
            set
            {
                if (inputCommand is null || inputCommand.Length == 0)
                {
                    Console.WriteLine("Input text is empty!");
                    isEmpty = true;
                    return;
                }
                isEmpty = false;
                inputCommand = value;
            }
        }

        public abstract void SendCommand();
    }
}