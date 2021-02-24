using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(21, "Picture");
            myDictionary.Add(25, "Pillow");
            myDictionary.Add(28, "Pink");

            myDictionary.ToList();


        }
    }
}