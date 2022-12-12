
#region Task2

//2) Parametr olaraq string qebul eden metod yazmalisiz.
//Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin. 
//(Cavid gelirse , ekranda divaC gorsensin).


//Changed("Konul");

//static void Changed(string name)

//{
//    string res = string.Empty;

//    for (int i = name.Length - 1; i >= 0; i--)
//    {
//        res += name[i];
//    }

//    Console.WriteLine(res);

//}

#endregion

#region Heap-stack



//static int SumEvenNums(int n, int m)
//{
//    int sum = 0;
//	if (n % 2 == 0 && m % 2 == 0)
//	{
//		sum = n + m;
//	}
//	return sum;
//}

//static int SunOddNums(int n, int m)
//{
//    int sum = 0;
//    for (int i = n; i <=m ; i++)
//    {
//        if (1%2 == 1)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}

////int result = SunOddNums(2, 8);
////Console.WriteLine(result);




//var arr = GetArr();

//static int GetCountOfNumsOfArray(int[] nums)
//{
//    int count = 0;
//    foreach (var item in nums)
//    {
//        if (!NumIsZero(item))
//        {
//            if (IsDivided(item))
//            {
//                count++;
//            }
//        }

//    }
//    return count;

//}


//int[] arr = { 1,0,0, 2, 3, 4, 5, 6, 7, 8, 9 };

//var result = GetCountOfNumsOfArray(arr);

//Console.WriteLine(result);






//int num1 = 10;
//int num2 = 8;

//var result = SumEvenNums(num1, num2);

//Console.WriteLine(result);

//var arr = GetArr();

//static int[] GetArr()
//{
//    return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//}


//static bool IsDivided(int number)
//{
//    return number % 2 == 0;
//}


//static bool NumIsZero(int num)
//{
//    return num== 0;
//}

//internal class Class1
//{
//    public static void Test()
//    {
//        Console.WriteLine("BOSH");
//    }


//    public static void Test(int n)
//    {
//        Console.WriteLine(n);
//    }


//    public static void Test(string n)
//    {
//        Console.WriteLine(n);
//    }


//    public static void Test( string n, int m)
//    {
//        Console.WriteLine(n + m);
//    }
//}


//Class1.Test("tesjsdjchbvds ", 8);


//int a = 5;
//int b = a;
//b = 10;


//Console.WriteLine(a);
//Console.WriteLine(b);

// int[] arr1 = {1,2,3,4,5,6,7};

//int[] arr2 = arr1;

//arr2[0] = 100;

//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr1[0]);




//int n = 5;

//Test(ref n);

//Console.WriteLine(n);




//static void Test(ref int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}


//static void Test(out int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}






//Test(arr);

//Console.WriteLine(arr[0]);


//static void test(int[] arr)
//{
//    arr[0] = 200; 
//    Console.WriteLine(arr[0]);
//}


//int[] arr = { 2, 3, 4, 5, 6 };

#endregion

#region String

//string name = "pervin";
//string name2 = name;

//name2 = "Cavid";

//Console.WriteLine(name);
//Console.WriteLine(name2);


//string address = "Ehmedli";

//var res = address.Split();

//Console.WriteLine(res);






////int result = address.Length;

//Console.WriteLine( address.Length);


//Console.WriteLine(address.StartsWith("E"));

//Console.WriteLine(address.EndsWith("i"));

//for (int i = 0; i < address.Length; i++)
//{
//    Console.WriteLine(address[i]);
//}








//if (address.Contains("t"))
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}





//string address = "Roya";

//var letter = address[0].ToString().ToUpper();

//var arr = address.ToCharArray();

//arr[0] = char.Parse(letter);

//string result = " ";

//foreach (var item in collection)
//{
//    result += item;

//}


//Console.WriteLine(item);





//string name = "Jale";

//Console.WriteLine(name.ToUpper(1));

//Console.WriteLine(name.Substring(1).ToUpper);



//string name = "    Jale";
//string name2 = "Jale";

//Console.WriteLine(name = name2);
//Console.WriteLine(name.Trim());


//Console.WriteLine(name.Replace("J","T"));


//string name = "Jale";

//if (string.IsNullOrEmpty(name))
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}



//string name = " ";

//if (string.IsNullOrWhiteSpace(name))
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}

#endregion


