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

       int[] values = [1,2,3,4,5,6,7,8,9];
       Console.WriteLine("Value in position 6 is : " + values[6]);
    }
}