using System;
using System.Collections.Generic;

namespace Key_Value_Store
{
    // Collaborated with Phillip, Angel, Jenny and Roscoe. We did our best to complete the assignment
    // however we were unable to get the code to compile against the provided 'Main'. If possible could we cover Key-Values in 
    // class.


    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
        }



    }
}
