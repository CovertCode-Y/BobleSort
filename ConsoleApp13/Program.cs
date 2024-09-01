namespace Boble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 55, 11, 50, 77, 69, 70, 20, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int ar in arr)
            {
                Console.Write("  {0}", ar);
            }
            Console.Read();
        }

    }
}
