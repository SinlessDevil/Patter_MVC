namespace MVC
{
    internal interface IView
    {
        string CheckCommandIsNull { get; set; }
        abstract void SendCommand();
    }
}