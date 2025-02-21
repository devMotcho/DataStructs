namespace DataStructs;


public class Program
{
    public static void BinarySearch(int[] arr, int target)
    {
        int min, max, med;
        bool same = false;
        min = 0; max = arr.Length - 1;

        do
        {
            med = ( min + max ) / 2;
            if (arr[med] < target)
                min = med + 1;
            else
                max = med - 1;

        }while(arr[med] != target & min <= max);

        same = (arr[med] == target);
        if (same) Console.WriteLine($"Target found at index {med} with value of {arr[med]}");
        else Console.WriteLine("Value not found");

        
    }
    public static void Main(string[] args)
    {
        int[] nums = { 5, 9, 12, 291, 238, 1983, 19831, 298123};
        int target = 1983;
        BinarySearch(nums, target);
    }
}