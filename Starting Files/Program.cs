using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        // static void Main()
        // {
        //     try
        //     {
        //         var mediaLibrary = new MediaLibrary(new MediaType[]
        //         {
        //             new Album("Yellow Submarine", "The Beatles"),
        //             new Album("The Wall", "Pink Floyd"),
        //             new Album("Pet Sounds", "The Beach Boys"),
        //             new Book("Moby-Dick", "Herman Melville"),
        //             new Movie("Lawrence of Arabia", "David Lean")
        //         });
                
        //         DetectMediaType(mediaLibrary.GetItemAt(0));
        //         DetectMediaType(mediaLibrary.GetItemAt(1));
        //         DetectMediaType(mediaLibrary.GetItemAt(2));
        //         DetectMediaType(mediaLibrary.GetItemAt(3));
        //         DetectMediaType(mediaLibrary.GetItemAt(4));
                
        //         Display(mediaLibrary.GetItemAt(0));
        //         Display(mediaLibrary.GetItemAt(1));
        //         Display(mediaLibrary.GetItemAt(2));
        //         Display(mediaLibrary.GetItemAt(3));
        //         Display(mediaLibrary.GetItemAt(4));                                
        //     }
        //     catch (Exception ex)
        //     {
        //         Console.WriteLine("Exception: " + ex.Message);
        //     }            
        // }

        static void Display(MediaType item) 
        {
            if (item == null)
            {
                return;
            }
            
            if (item is Album)
            {
                Console.WriteLine(((Album)item).GetDisplayText());
            }
            else if (item is Book)
            {
                Console.WriteLine(((Book)item).GetDisplayText());
            }
            else if (item is Movie)
            {
                Console.WriteLine(((Movie)item).GetDisplayText());
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }
        
        static void DetectMediaType(MediaType item) 
        {
            if (item == null)
            {
                return;
            }

            if (item is Album)
            {
                Console.WriteLine(item.Title + " is an album!");
            }
            else if (item is Book)
            {
                Console.WriteLine(item.Title + " is a book!");
            }
            else if (item is Movie)
            {
                Console.WriteLine(item.Title + " is a movie!");
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }
    }
}
