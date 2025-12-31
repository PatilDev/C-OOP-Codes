public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter how many num you want in Array:-\t");
        int num =Convert.ToInt32(Console.ReadLine());

        int [] arr= new int[num];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("enter {0}th element of Array",i," ");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }

        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n________________________________________________________");

        Console.WriteLine("Sorted array");

        //bubble sort
        /*https://app.napkin.ai/page/CgoiCHByb2Qtb25lEiwKBFBhZ2UaJGI5NDczM2NiLTk2MGQtNDQ5MS05NjAwLTBkOTE0ODI5NTdmNQ?s=1*/
        for (int i=0;i<arr.Length-1;i++)
        {
            for(int j=0;j<arr.Length-i-1;j++)
            {
                if (arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }

        //selection algorithm
        for (int i = 0; i < arr.Length; i++)
        {
            int selection = i;   // index of smallest element

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[selection] > arr[j])
                {
                    selection = j;  // store index, NOT value
                }
            }

            // swap arr[i] and arr[selection]
            int temp = arr[selection];
            arr[selection] = arr[i];
            arr[i] = temp;
        }


        foreach (int item in arr)
        {
            Console.Write("\t"+item + " ");
        }



    }
}