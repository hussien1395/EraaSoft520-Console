namespace Session_009_Challenges_001
{
    abstract class Book
    {
        string Title { get; set; }
        string Author { get; set; }

        public abstract string Read();
    }

    interface IDownload
    {
        string Download();
    }

    class PhyBook : Book
    {
        public override string Read()
        {
            return "Reading Phy Book";
        }
    }

    class EBook : Book, IDownload
    {
        public string Download()
        {
            return "Download E-Book";
        }

        public override string Read()
        {
            return "Reading E-Book";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PhyBook book = new PhyBook();
            Console.WriteLine(book.Read());

            EBook ebook = new EBook();
            Console.WriteLine(ebook.Read());
            Console.WriteLine(ebook.Download());
        }
    }
}

// protected internal
// private protected


