using System;
					
public class Program
{
	public static void Main()
	{
		
           string x = "your string mine is";
           string [] myarray = x.Split(' ');
	   int l = myarray.Length;
		
           string x1 = "";
  
           for (int i= l -1; i>=0; i--)
	   x1 += myarray[j] + " ";
		
	   Console.WriteLine("The reverse of the string is:\n{0}", x1);
	}
} 
