using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Class_Inheritance_app
{
    internal class Book:Product
    {

        public Book(string name,double price,string genre):base(name,price)
        {
            Genre = genre;
        }
        public string Genre;


    }
}
