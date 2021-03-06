namespace CSharp_Inheritance
{
    class MediaLibrary
    {
        private MediaType[] _items;

        public MediaLibrary(MediaType[] items)
        {
            _items = items;
        }

        public int NumberOfItems => _items.Length;
            

        public MediaType GetItemAt(int index)
        {
             if(index < _items.Length){
                 return _items[index];
             }else{
                 System.Console.WriteLine("An element at index " + index + " doesn't exist in the media library.");
                 return null;
             }  

            //  return index < _items.Length ? _items[index] : null;      
        }
    }
}
