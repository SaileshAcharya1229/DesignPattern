namespace Enum.Generic_Task_1;

public class Animal<A>
{
    public void displayMe(A[] a)
    {
       // Console.WriteLine(a[0]);
       /*for (int i = 0; i < a.Length; i++)
       {
           Console.WriteLine(a[i]);
       }*/

       foreach (var b in a)
       {
           Console.WriteLine(b);
       }
        
    }

    
}

