using System;
class Vin
{

public void Question1()
{
    int n;
    Console.WriteLine("Enter value of n");
    n=Convert.ToInt32(Console.ReadLine());
    for(int i=1;i<=n;i++)
    {
        for(int j=1;j<=i;j++)
        {
            Console.Write("*");
        }
        Console.WriteLine("");
    }

} 
public void Question2()
{
    int n;
    Console.WriteLine("Enter n value");
    n=Convert.ToInt32(Console.ReadLine());
    int c=n;
    for(int i=0;i<n;i++)
    {
        for(int j=c-1;j<n && j>0 ;j--)
        {
            Console.Write(" ");
        }
        for(int k=0;k<((2*i)+1);k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        c--;
    }
}
public void Question3()
{
    int n;
    Console.WriteLine("Enter n value");
    n=Convert.ToInt32(Console.ReadLine());
    int c=n;
    for(int i=0;i<n;i++)
    {
        for(int k=1;k<=n-c;k++)
        {
            Console.Write(" ");
        }
        for(int j=0;j<(((2*n)-1)-(2*i));j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        c--;
    }
}

public void Question4AndQuestion5()
{
    int n;
    Console.WriteLine("Enter n value");
    n=Convert.ToInt32(Console.ReadLine());
    int c=n;
    for(int i=0;i<n;i++)
    {
        for(int k=1;k<=n-c;k++)
        {
            Console.Write(" ");
        }
        for(int j=0;j<(((2*n)-1)-(2*i));j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        c--;
    }
    int c1=n;
    for(int i=1;i<=n-1;i++)
    {
       for(int j=c1-2;j<n && j>0 ;j--)
        {
            Console.Write(" ");
        }
        for(int k=0;k<((2*i)+1);k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        c1--; 
    }
}
public void Question6()
{
    int n;
    Console.WriteLine("Enter value of n:");
    n=Convert.ToInt32(Console.ReadLine());
    int count=n-1;
    for(int i=0;i<n;i++)
    {
        for(int a=1;a<=(n-count);a++)
        {
            Console.Write("*");
        }
        for(int b=0;b<count;b++)
        {
            Console.Write(" ");
        }
        for(int a=1;a<=n-count;a++)
        {
            Console.Write("*");  
        }
        Console.WriteLine();
        count--;
    }  
    Console.WriteLine("-------------");
    int c=n;
    for(int i=1;i<=n;i++)
    {
        for(int j=1;j<=i;j++)
        {
            Console.Write("*");
        }
        for(int k=0;k<(2*c-3) && c>0;k++)
        {
            Console.Write(" ");
        }
        if(c>1)
        {
        for(int j=1;j<=i;j++)
        {
            Console.Write("*");
        }
        }
        else
        {
            for(int j=1;j<i;j++)
        {
            Console.Write("*");
        }
        }
        c--;
        Console.WriteLine("");
    } 
}

public void Question7()
{

    string str;
    Console.WriteLine("Please Enter the string: ");
    str=Console.ReadLine();
    char[] ch=new char[str.Length];
    int k=0;
    for(int i=str.Length-1;i>=0;i--)
    {
        ch[k]=str[i];
        k++;
    }
    string str1=new string(ch);
    Console.Write($"Reverse of the given string {str} is: ");
    Console.WriteLine(str1);

}

public void Question8AndQuestion9()
{
    int n;
    Console.WriteLine("Enter size of array: ");
    n=Convert.ToInt32(Console.ReadLine());
    int[] a=new int[n];
    Console.WriteLine("Enter elements of array");
    for(int i=0;i<a.Length;i++)
    {
        a[i]=Convert.ToInt32(Console.ReadLine());
    }
    int temp,k;
    for(int i=0;i<2;i++)
    {

        int min=a[i];
        for(k=i+1;k<a.Length;k++)
        {
            if(min>a[k])
            { 
               temp=a[i];
               a[i]=a[k];
               a[k]=temp;
               min=a[i];
            }
           
        }
        

    }

    Console.WriteLine("Second smallest element is :"+a[1]);
    
}

public void Question10()
{
    int r1=1,r2=2;
    int n,sum=0;
    Console.WriteLine("Enter the value of n: ");
    n=Convert.ToInt32(Console.ReadLine());
    if(n==0)
    {
        Console.WriteLine("please enter value greater than 0");
    }
    else if(n==2)
    {
        Console.WriteLine(r1);
    }
    else if(n==2)
    {
        Console.WriteLine(r1+" "+r2);
    }
    else
    {
        Console.Write(r1+" "+r2+" ");
        for(int i=0;i<n-2;i++)
        {
          sum=r1+r2;
          Console.Write(sum+" ");
          r1=r2;
          r2=sum;
        }
    }
}
public void Question11()
{

    // string str="vinodh";
    Console.WriteLine("Please Enter the string: ");
     string str=Console.ReadLine();
    int strlength=str.Length;
    int strlength1=strlength;
    int count=0;
    for(int i=0;i<(strlength/2);i++)
    {
        if(str[i]==str[strlength1-1])
        {
            
            count++;
            strlength1--;
            continue;
        }
        else
        {
            Console.WriteLine($"[{str}] is not a palindrome");
            break;
        }
    }
    if(count==strlength/2)
    {
        Console.WriteLine($"[{str}] is palindrome");
    }

}
public void Question12()
{
    Console.WriteLine("Enter the value of n");
    int n=Convert.ToInt32(Console.ReadLine());
    int n1=n;
    int sum=0;
    int r;
    while(n1>0)
    {
        r=n1%10;
        sum=sum+r;
        n1/=10;
    }
    Console.WriteLine($"sum of the digits of number "+n+" is "+sum);
}
public void Question13()
{
    Console.WriteLine("Enter the value of n");
    int n=Convert.ToInt32(Console.ReadLine());
    int n1=n;
    int sum=0;
    int r;
    while(n1>0)
    {
        r=n1%10;
        sum=(sum*10)+r;
        n1/=10;
    }
    if(n==sum)
    {
        Console.WriteLine($"{n} is palindrome number");
    }
    else
    {
        Console.WriteLine($"{n} is not a palindrome number");
    }
}
public void Question14()
{
    int[] a1=new int[] {1, 2, 3, 4, 5, 6, 8};
    int[] a2=new int[] {-1, 5, 6, 7, 10, 11};
    // int[] a=new int[] {1, 2, 4, 8,- 9, 20};
    int temp,c=0;
    int[] a3=new int[a1.Length+a2.Length];
    for(int i=0;i<a1.Length;i++)
    {
        a3[i]=a1[i];
    }
    for(int i=a1.Length;i<a3.Length;i++)
    {
        a3[i]=a2[c];
        c++;
    }
    for(int i=0;i<a3.Length;i++)
    {
        Console.Write(a3[i]+" ");
    }
    Console.WriteLine("");
    for(int i=0;i<a3.Length-1;i++)
    {

        int min=a3[i];
        for(int k=i+1;k<a3.Length;k++)
        {
            if(min>a3[k])
            { 
               temp=a3[i];
               a3[i]=a3[k];
               a3[k]=temp;
               min=a3[i];
            }
           
        }
    }
    for(int i=0;i<a3.Length;i++)
    {
        Console.Write(a3[i]+" ");
    }    
}

public void Question15()
{
    string s1=Console.ReadLine();
    string s2=Console.ReadLine();
    //string s3=Console.ReadLine();
    string s4=null,s5=null;
    // int k=0;

    for(int i=2;i<s1.Length;i++)
    {
        s4=s4+s1[i];
    }
    s4=s4+s1[0]+s1[1];
    for(int i=0;i<s1.Length-2;i++)
    {
        s5=s5+s1[i];
    }
    s5=Convert.ToString(s1[s1.Length-2])+Convert.ToString(s1[s1.Length-1])+s5;
    if(s4.Equals(s2) || s5.Equals(s2))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

public void Question16() //Failing at one test case
{
    string s1="vinodh",s2="hdoniv";
    int found=0;
    if(!s1.Length.Equals(s2.Length))
    {
        Console.WriteLine("Not Anagram");
    }
    else
    {
       for(int i=0;i<s1.Length;i++)
       {
        found=0;
        for(int j=0;j<s2.Length;j++)
        {
            if(s1[i]==s2[j])
            {
                found=1;
                break;
            }
        }
        if(found==0)
        {
            Console.WriteLine("Not Anagram");
            break;
        }
       } 
       if(found==1)
       {
        Console.WriteLine("Anagram");
       }
    }
}

}
