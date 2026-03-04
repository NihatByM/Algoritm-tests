//Console.Write("EDED 1: ");
//int a = int.Parse(Console.ReadLine());

//Console.Write("EDED 2: ");
//int b = int.Parse(Console.ReadLine());
//if (a > b)
//{
//    Console.WriteLine("Boyuk eded: " + a);

//}
//else if (b > a)
//{
//    Console.WriteLine("Boyuk eded: " + b);

//}
//else
//{
//    Console.WriteLine("Beraberdir");

//}

//_____________________________________________________________________________________________________________________________________________________________________________________________________________________


//Console.Write("EDED YAZ:");
//int x = int.Parse(Console.ReadLine());
//if (x % 2 == 0)
//{
//    Console.WriteLine("Qaliqsiz bolunur");
//}
//else
//{
//    Console.WriteLine("Qaliq qalir");
//}


//_____________________________________________________________________________________________________________________________________________________________________________________________________________________

//Console.Write("Eded yaz: ");
//int a = int.Parse(Console.ReadLine());
//if (a >= 100)
//{
//    Console.WriteLine("Boyukdur.");
//}
//else
//{
//    Console.WriteLine("Kicikdir");
//}



//_____________________________________________________________________________________________________________________________________________________________________________________________________________________


//Console.Write("Eded yaz: ");
//int x = int.Parse(Console.ReadLine());
//if (x >= 18)
//{
//    Console.WriteLine("Adult");
//}
//else
//{
//    Console.WriteLine("Child");
//}



//_____________________________________________________________________________________________________________________________________________________________________________________________________________________





//Console.Write("Eded daxil et: ");
//int a = int.Parse(Console.ReadLine());
//if (a > 0)
//{
//    Console.WriteLine("Musbet.");
//}
//else if (a < 0)
//{
//    Console.WriteLine("Menfi");
//}
//else
//{
//    Console.WriteLine("Eded 0 dir");
//}



//_____________________________________________________________________________________________________________________________________________________________________________________________________________________


//Console.Write("1 ile 7 arasinda eded daxil et: ");
//int gun = int.Parse(Console.ReadLine());
//switch (gun)
//{
//    case 1:
//        Console.WriteLine("Bazar ertesi");
//        break;

//    case 2:
//        Console.WriteLine("Cersenbe axsami");
//        break;

//    case 3:
//        Console.WriteLine("Cersenbe");
//        break;

//    case 4:
//        Console.WriteLine("Cume axsami");
//        break;

//    case 5:
//        Console.WriteLine("Cume");
//        break;

//    case 6:
//        Console.WriteLine("Senbe");
//        break;

//    case 7:
//        Console.WriteLine("Bazar");
//        break;

//    default:
//        Console.WriteLine("Yalnis eded daxil edildi.");
//        break;
//}



//_____________________________________________________________________________________________________________________________________________________________________________________________________________________




//Console.Write("Eded daxil et: ");
//double a = int.Parse(Console.ReadLine());
//double kub = Math.Pow(a, 3);
//Console.WriteLine("Eded kubu:" +kub);



//_____________________________________________________________________________________________________________________________________________________________________________________________________________________



//Console.Write("1 ile 12 arasinda eded daxil et: ");
//int day = int.Parse(Console.ReadLine());
//switch (day)
//{
//    case 1:
//    case 3:
//    case 5:
//    case 7:
//    case 8:
//    case 10:
//    case 12:
//        Console.WriteLine("31");
//        break;

//    case 2:
//        Console.WriteLine("28");
//        break;

//    case 4:
//    case 6:
//    case 9:
//    case 11:
//        Console.WriteLine("30");
//        break;

//    default:
//        Console.WriteLine("Yalnis eded daxil edildi.");
//        break;
//}




//_____________________________________________________________________________________________________________________________________________________________________________________________________________________



//string[] fruits = new string[7];

//Console.Write("1 ci meyve: ");
//fruits[0] = Console.ReadLine();

//Console.Write("2 ci meyve: ");
//fruits[1] = Console.ReadLine();

//Console.Write("3 ci meyve: ");
//fruits[2] = Console.ReadLine();

//Console.Write("4 ci meyve: ");
//fruits[3] = Console.ReadLine();

//Console.Write("5 ci meyve: ");
//fruits[4] = Console.ReadLine();

//Console.Write("6 ci meyve: ");
//fruits[5] = Console.ReadLine();

//Console.Write("7 ci meyve: ");
//fruits[6] = Console.ReadLine();

//Console.WriteLine("Daxil edilen meyveler:");
//Console.WriteLine(fruits[0]);
//Console.WriteLine(fruits[1]);
//Console.WriteLine(fruits[2]);
//Console.WriteLine(fruits[3]);
//Console.WriteLine(fruits[4]);
//Console.WriteLine(fruits[5]);
//Console.WriteLine(fruits[6]);





//_____________________________________________________________________________________________________________________________________________________________________________________________________________________





//string[] students = new string[10];

//Console.Write("student 1: ");
//students[0] = Console.ReadLine();

//Console.Write("student 2: ");
//students[1] = Console.ReadLine();

//Console.Write("student 3: ");
//students[2] = Console.ReadLine();

//Console.Write("student 4: ");
//students[3] = Console.ReadLine();

//Console.Write("student 5: ");
//students[4] = Console.ReadLine();

//Console.Write("student 6: ");
//students[5] = Console.ReadLine();

//Console.Write("student 7: ");
//students[6] = Console.ReadLine();

//Console.Write("student 8: ");
//students[7] = Console.ReadLine();

//Console.Write("student 9: ");
//students[8] = Console.ReadLine();

//Console.Write("student 10: ");
//students[9] = Console.ReadLine();

//Console.WriteLine("Daxil edilen meyveler:");
//Console.WriteLine(students[0]);
//Console.WriteLine(students[1]);
//Console.WriteLine(students[2]);
//Console.WriteLine(students[3]);
//Console.WriteLine(students[4]);
//Console.WriteLine(students[5]);
//Console.WriteLine(students[6]);
//Console.WriteLine(students[7]);
//Console.WriteLine(students[8]);
//Console.WriteLine(students[9]);


//_____________________________________________________________________________________________________________________________________________________________________________________________________________________

//5ci sagirdi capa cixarmaq ucun yalniz
//Console.WriteLine(students[5]);


//_____________________________________________________________________________________________________________________________________________________________________________________________________________________




//string[] travels = new string[10];

//Console.Write("seher 1: ");
//travels[0] = Console.ReadLine();

//Console.Write("seher 2: ");
//travels[1] = Console.ReadLine();

//Console.Write("seher 3: ");
//travels[2] = Console.ReadLine();

//Console.Write("seher 4: ");
//travels[3] = Console.ReadLine();

//Console.Write("seher 5: ");
//travels[4] = Console.ReadLine();

//Console.WriteLine("Daxil edilen seherler:");
//Console.WriteLine(seher[0]);
//Console.WriteLine(seher[1]);
//Console.WriteLine(seher[2]);
//Console.WriteLine(seher[3]);
//Console.WriteLine(seher[4]);





//int[] num = { 20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30 };
//Console.WriteLine("3 e bolunen ededler:");

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] % 3 == 0)
//    {
//        Console.WriteLine(num[i]);
//    }
//}


//int[] a = { 20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30 };
//Array.Sort(a);
//int min = a[0];
//int max = a[a.Length - 1];
//double orta = a.Average();
//Console.WriteLine("Min: " + min);
//Console.WriteLine("Max: " + max);
//Console.WriteLine("Orta: " + orta);

