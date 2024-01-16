using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Homework_Class_Inheritance_app
{
    internal class Library
    {
        public Book[] Books = new Book[0];
        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length-1] = book;
        }
        public void ShowBook()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Console.WriteLine($"                     {i+1}.  Adi: {Books[i].Name} Qiymeti: {Books[i].Price} Genre: {Books[i].Genre}");
            }
        }
        public Book FindBookByName(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (name == Books[i].Name)
                {
                    return Books[i];
                }
            }
            return null;
        }
        public void FindTheBookByLetter(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name.Contains(name))
                {
                    Console.WriteLine($"                 Adi: {Books[i].Name} - Qiymeti: {Books[i].Price} - Genre: {Books[i].Genre}");
                }
            }
        }
        public void RemoveBookName(string name)
        {
            int count = 0;
            for (int i = 0; i < Books.Length; i++)
            {
                if (name == Books[i].Name)
                {
                    Console.WriteLine("                  Silindi:" + Books[i].Name);
                }
                else
                {
                    count++;
                }
            }
            Book[] books = new Book[count];
            int index = 0;
            for (int i = 0; i < Books.Length; i++)
            {
                if (name != Books[i].Name)
                {
                    books[index++] = Books[i];
                }
            }
            Books = books;

            //int wantedIndex = FindBookByName(name);

            //if (wantedIndex == -1) return false;

            //for (int i = wantedIndex; i < Books.Length - 1; i++)
            //{
            //    var temp = Books[i];
            //    Books[i] = Books[i + 1];
            //    Books[i + 1] = temp;
            //}

            //Array.Resize(ref Books, Books.Length - 1);
            //return true;
        }

    }
}
