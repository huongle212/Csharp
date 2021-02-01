namespace MyBookLibrary
{
    interface IBook
    {
        string this[int index] { get;set; }
        string id { get; set; }
        string title { get; set; }
        string publisher { get; set; }
        double price { get; set; }
    }
}
