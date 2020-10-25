using System;

namespace HashTableDemo
{
    class Program
    {
        static MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
        static void Main(string[] args)
        {
  
                hash.Add("0", "To");
               // hash.Add("1", "be");
                hash.Add("2", "or");
                //hash.Add("3", "not");
               //hash.Add("4", "to");
                //hash.Add("5", "be");

                string second = hash.Get("2");
                Console.WriteLine("2nd index value :" + second);
                hash.Remove("1");

            
        }
    }
}
