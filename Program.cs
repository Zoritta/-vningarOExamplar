using System;

namespace simpleArrays;

class Program
{
    static void Main()
    {
       int[] numbers = new int[5];

       numbers[0]= 1;
       numbers[1]= 3;
       numbers[2]= 5;
       numbers[3]= 7;
       numbers[4]= 9;

       Console.WriteLine("Value in the position 2 is " + numbers[2]);

       int[] values = new int [] {1,2,3,4,5,6,7,8,9};
       Console.WriteLine("Value in position 6 is : " + values[6]);

       string[] vehicles = new string [5];
       vehicles[0]= "Volvo";
       vehicles[1]= "Ford";
       vehicles[2]= "Toyota";
       vehicles[3]= "Fiat";
       vehicles[4]= "BMW";


       object[] queries = new object[]
       {
        new {query= "fquery 1", answer = "answer to query 1"},
        new {query= "query 2", answer = "answer to query 2"},
        new {query= "query 1", answer = "answer to query 1"}
       };

       Console.WriteLine("Number of queries in the array is: " + queries.Length);
    }
}