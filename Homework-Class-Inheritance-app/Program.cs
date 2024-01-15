using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace Homework_Class_Inheritance_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opt;

            Library library = new Library();
            do
            {
                Console.WriteLine("1 Kitab elave et");
                Console.WriteLine("2 Kitab sil");
                Console.WriteLine("3 Butun kitablara bax");
                Console.WriteLine("4 Secilmis kitaba bax (ada gore)");
                Console.WriteLine("5 Herife gore axtaris et");
                Console.WriteLine("6 cix");
                opt = Console.ReadLine();
                switch (opt) 
                {
                    case "1":
                        
                        string bookName;
                        bool check = false;
                        bool letter = false;
                        do
                        {
                            check = false;
                            letter = false;
                            
                            Console.WriteLine("Kitabin adi");
                            bookName = Console.ReadLine();
                            for (int i = 0; i < bookName.Length; i++)
                            {
                                if (char.IsDigit(bookName[i]))
                                {
                                    Console.WriteLine("                          Book heriflerden ibaretdir");
                                    letter = true;
                                    break;
                                }
                            }

                            for (int i = 0; i < library.Books.Length; i++)
                            {
                                if (library.Books[i].Name == bookName)
                                {
                                    Console.WriteLine("                          Eyni adda book olmaz");
                                    check = true;
                                    break;
                                }
                            }
                        } while (string.IsNullOrWhiteSpace(bookName) || bookName.Length < 3 || bookName.Length > 20 || check || letter);

                        string bookPriceStr;
                        double bookPrice;
                        do
                        {
                            Console.WriteLine("Kitabin qiymeti");
                            bookPriceStr = Console.ReadLine();

                        } while (!double.TryParse(bookPriceStr,out bookPrice) || bookPrice < 0);

                        Console.WriteLine("Kitabin Genre");
                        string genre = Console.ReadLine();

                        Book books = new Book(bookName, bookPrice, genre);
                        library.AddBook(books);
                        Console.WriteLine("Yaradildi");
                        break;
                    case "2":
                        Console.WriteLine("Adi secin");
                        string deleteBook = Console.ReadLine();
                        library.RemoveBookName(deleteBook);
                            break;
                    case "3":
                        library.ShowBook();
                        break;
                    case "4":
                        Console.WriteLine("Adi daxil edin");
                        string findName = Console.ReadLine();
                        Book findBook = library.FindBookByName(findName);
                        Console.WriteLine($"                               Adi: {findBook.Name} - Qiymeti: {findBook.Price} - Genre: {findBook.Genre}");
                        break; 
                    case "5":
                        Console.WriteLine("Adi daxil edin");
                        string findStr = Console.ReadLine();
                        library.FindTheBookByLetter(findStr);
                        break;
                }
            } while (opt != "0");
        }
    }
}
