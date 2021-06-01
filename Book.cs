namespace CSharp_Inheritance
{
    class Book : MediaType
    {
        public string Author  { get; private set; }

        public string DisplayText => 
            "Book: " + Title + " by " + Author + OnLoanDisplayText;        
        
        public Book(string title, string author)
            : base(title)
        {
            Author = author;
        }


    }
}