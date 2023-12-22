




var numbers = new List<int>();
numbers.Add(5);
numbers.Add(23);
numbers.Add(27);
numbers.Add(63);
numbers.Add(43);
numbers.Add(65);
numbers.Add(62);

var BinarySearch = numbers.BinarySearch(65);
var Indexof = numbers.IndexOf(62);

Console.WriteLine(Indexof);
Console.WriteLine(BinarySearch);






//var numbers = new List<int>();
//numbers.Add(222);
//numbers.Add(222);
//numbers.Add(222);
//numbers.Add(222);
//numbers.Add(222);
//Console.WriteLine(numbers.Count());




//var ArrayList = new int[] { 55, 55, 5, 55, };
//numbers.AddRange(ArrayList);

//Console.WriteLine(numbers.Capacity);

//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}






//Console.Write("Plase Enter Yout Blance : ");
//int Number =Convert.ToInt32( Console.ReadLine());
//int count = 0;
//int IceCream = 20;
//while (Number >= IceCream)
//{
//    Console.WriteLine("You Buy {0} Ice Cream",++count);
//    Number -= IceCream;
//}








//int[] NumberS = { 12, 32, 12, 34, 45, 56, 7, 54, 3, 53, };
//for (int i = NumberS.Length -1 ; i >=0 ; i--)
//{
//    Console.WriteLine(NumberS[i]);
//}


//string[] TextNumber = {"Firoz","Sonnet","Shuroz","Pias"};
//Array.Sort(TextNumber);
//foreach (var textNumber in TextNumber)
//{
//    Console.WriteLine(textNumber +",");
//}

//int[] SimpleArray = { 23, 3, 43, 4, 54, 5, 23 };
//Array.Sort(SimpleArray);
//Array.Reverse(SimpleArray);
//foreach (var item in SimpleArray)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("Bresk");
//int[] DataStore = new int[12];

//Array.Copy(SimpleArray, DataStore, 4);
//foreach (var item in DataStore)
//{
//    Console.WriteLine(item);
//}











//start:
//Console.Write("Plase Enter A Day : ");
//string StorData = Console.ReadLine();
//switch (StorData)
//{
//	case "Sun":
//        Console.WriteLine("This Is day Full Name Sunday ");
//        break;
//    case "Mon":
//        Console.WriteLine("this Day Full Name Monday");
//        break;

//    default:
//        Console.WriteLine("Wrong Input ");
//        goto start;
//}


//string[,] MyArray = new string[3, 4]
//{
//    {"One","two","three","four" },
//    {"five","six","seven","enght" },
//    {"nine","ten","eleven","twelve" }
//};

//Console.WriteLine(MyArray[0,2]);





//start:
//Console.Write("Please Write a Day Name : ");
//string data = Console.ReadLine();
//if (data == "Sun")
//{
//    Console.WriteLine("This is Sunday");
//}
//else if (data == "Mon")
//{
//    Console.WriteLine("This Is Monday");
//}
//else
//{
//    Console.WriteLine("Worng Input");
//    goto start;
//}




//Console.Write("How Much You Want to Number : ");
//int IntNumber = Convert.ToInt32( Console.ReadLine());


//int[] StoreArray= new int[IntNumber];

//for (int i=0; i<IntNumber; i++)
//{
//    Console.Write("Plase Array Number : ");
//    int StorInput= Convert.ToInt32(Console.ReadLine());
//    StoreArray[i]= StorInput;
//}

//for (int i = 0; i < StoreArray.Length; i++)
//{
//    for (int j=0; j< StoreArray.Length; j++)
//    {
//        var data = 0;
//        if (StoreArray[i] < StoreArray[j])
//        {
//            data = StoreArray[i];
//            StoreArray[i] = StoreArray[j];
//            StoreArray[j] = data;

//        }
//    }  
//}

//foreach (int i in StoreArray)
//{
//    Console.Write(i+",");
//}









//Console.WriteLine("Plase Enter Your Name: ");
//string data  = Console.ReadLine();
//Console.WriteLine("Your Name : "+data);
//Console.ReadLine();


//Object Number = 23;
//Console.WriteLine(Number.GetType());
//Number = "Firoz";
//Console.WriteLine(Number.GetType());


//int? data = null;
//int SecondData;
//SecondData = data ?? 12;

//Console.WriteLine("My Number : "+SecondData);





