
namespace PRN292_Lab2M_1_2_Book
{
    //Describes the general interface for books
    interface IBook
    {
        string this[int index] { get; set; }
        string title { get; set; }
        string author { get; set; }
        string publisher { get; set; }
        string ISBN { get; set; }
        int year { get; set; }
        void Show();
    }
}
