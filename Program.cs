using System;

namespace CSharp_Inheritance
{
    class Program
    {
        static void Main()
        {
            try
            {
                MediaLibrary myLibrary = new MediaLibrary(new MediaType[]
                {
                    new Album("Yellow Submarine", "The Beatles"),
                    new Book("On The Road", "Jack Kerouac"),
                    new Movie("Titanic", "James Cameron"),
                    new Movie("Moby-Dick", "Herman Melville"),
                    new Movie("Lawrence of Arabia", "David Lean")
                });

                for(int i=0; i<myLibrary.NumberOfItems; i++)
                    DetectMediaType(myLibrary.GetItemAt(i));

                    Console.WriteLine("Count: " + myLibrary.NumberOfItems);

                for(int i=0; i<myLibrary.NumberOfItems; i++)
                    Display(myLibrary.GetItemAt(i));


                    

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        static void Display(MediaType item)
        {
            if(item == null)
            {
                return;
            }

            if (item is Movie)
            {
                Console.WriteLine(((Movie)item).DisplayText);
            }
            else if (item is Album)
            {
                Console.WriteLine(((Album)item).DisplayText);
            }
            else if(item is Book){
                Console.WriteLine(((Book)item).DisplayText);
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }


       static void DetectMediaType(MediaType item)
        {
            if (item is Movie)
            {
                Console.WriteLine(item.Title + " is a Movie");
            }
            else if (item is Album)
            {
                Console.WriteLine(item.Title + " is a Album");
            }

            else if(item is Book){
                Console.WriteLine(item.Title + " is a Book");
            }

            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }



    }
}
