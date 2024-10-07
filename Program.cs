
namespace ArrSum
{
    public class ArraySum
    {

        static void Main(string[] args)            //main method
        {

            Console.WriteLine("enter the size of the array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("enter array elements:");
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) //taking array elements
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum = sum + arr[i];
            }
            Console.WriteLine("array sum is:" + sum);   //sum of array elements

        }
    }
}
