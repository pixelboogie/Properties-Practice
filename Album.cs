namespace Treehouse.MediaLibrary
{
    class Album : MediaType
    {

        public string Artist { get; private set; }

        public string DisplayText => 
            "Album: " + Title + " by " + Artist + OnLoanDisplayText;
        
        public Album(string title, string artist) 
        : base(title)
        {
            Artist = artist;
        }
        

    }
}













