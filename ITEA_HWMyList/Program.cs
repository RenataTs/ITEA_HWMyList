using ITEA_HWMyList;
using System;

namespace ListExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            myList.AddBack(-1);
            myList.AddBack(-2);
            myList.AddBack(-3);
            myList.AddBack(-4);
            myList.AddBack(-5);
            myList.AddBack(-6);

            //myList.ItemDeleteByIndex(2);

            //myList.FirstItemDelete();

            //Console.WriteLine(myList.RetutnIndexByValue(-3));

            //Console.WriteLine(myList.ArrayLength());

            //Console.WriteLine(myList.RetutnByIndex(2));

            myList.NItemsDeleteByIndex(2, 3);

            //myList.LastNItemsDelete(9);

            //myList.FirstNItemsDelete(3);

            //myList.LastItemDelete();

            //myList.FirstItemDelete();

            //myList.ItemDeleteByIndex(1);

            for (int i = 0; i < myList.Length; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
