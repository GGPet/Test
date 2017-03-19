using System;
					
public class Program
{
	public static void Main()
	{
		
           string x = "your string mine is";
           string [] myarray = x.Split(' ');
	   int l = myarray.Length;
	   double k = l/2;
	   int loop = (int) Math.Round(k);
		
           string x1 = "";
  
           for (int i=0; i<= loop; i++)
	   {
	       string first = myarray[i];
	       myarray[i] = myarray[l-1];
	       myarray[l-1] = first;
	       loop--;
	   }
		
	   for (int j=0; j< l; j++)
	   x1 += myarray[j] + " ";
		
	   Console.WriteLine("The reverse of the string is:\n{0}", x1);
	}
} 
