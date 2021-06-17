namespace Treehouse.MediaLibrary
{
    class Movie : MediaType
    {
        public string Director { get; private set; }
         
        public Movie(string title, string director) 
        : base(title)
        {
            Director = director;
        }

        public string DisplayText => 
            "Movie: " + Title + " by " + Director + OnLoanDisplayText;  

    }
}
