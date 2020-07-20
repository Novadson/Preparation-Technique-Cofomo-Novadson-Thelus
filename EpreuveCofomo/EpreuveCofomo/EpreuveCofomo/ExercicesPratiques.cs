namespace EpreuveCofomo
{
    #region STATIC CLASS

//public class ProblemesResolus STATIC CLASS
//{
//    /*DÉCRIVEZ LES DIFFÉRENTES CLASSES C # EN DÉTAIL.*/
//    static void Main(string[] args)
//    {
//        Console.Write("Informez le type de Convetion (1) Celsius pour Fahrenheit, (2)Fahrenheit pour Celsius:");
//        string typConvertion = Console.ReadLine();
//        Console.Write("Quelle est la quantité que vous voulez convertir?:");
//        string nombre = Console.ReadLine();
//        double resultTemparature = 0;

//        switch (typConvertion)
//        {
//            case "1":
//                resultTemparature = ExempleClassStatic.CelsiusToFahrenheit(nombre);
//                Console.WriteLine($"La temperature de  Celsius para Fahrenheit:{resultTemparature:F2}");
//                break;
//            case "2":
//                resultTemparature = ExempleClassStatic.FahrenheitToCelsius(nombre);
//                Console.WriteLine($"La temperature de  Fahrenheit pour Celsius:{resultTemparature:F2}");
//                break;
//        }

//        Console.ReadKey();
//    }
//}
//public static class ExempleClassStatic
//{
//    public static double CelsiusToFahrenheit(string TemperatureCelsuis)
//    {
//        double celsuis = double.Parse(TemperatureCelsuis);
//        double fah = (celsuis * 9 / 5) + 32;
//        return fah;
//    }

//    public static double FahrenheitToCelsius(string TemperatureFahrenheit)
//    {
//        double fahrenheit = double.Parse(TemperatureFahrenheit);
//        double celsius = (fahrenheit - 32) * 5 / 9;
//        return celsius;
//    }
//}  
#endregion STATIC CLASS

#region ABSTRACTCLASS
//abstract class Shape
//{
//    public abstract int GetArea();
//}

//class Square : Shape
//{
//    public readonly int nombre;
//    public Square(int n)
//    {
//        nombre = n;
//    }

//    public override int GetArea() => nombre * nombre;

//    static void Main()
//    {
//        var sq = new Square(12);
//        Console.WriteLine($"Area of the square = {sq.GetArea()}");
//        Console.ReadLine();
//    }
//}
#endregion ABSTRACTCLASS

#region SEALEDCLASS
//    /*DÉCRIVEZ LES DIFFÉRENTES CLASSES C # EN DÉTAIL.SEALEDCLASS*/
//    static void Main(string[] args)
//    {
//        SealedClass sealedClass = new SealedClass()
//        {
//            Valuer1 = 110,
//            Valuer2 = 150
//        };

//        Console.Write($"Valeur de x:{sealedClass.Valuer1}" + "\n" + $"Valeur y:{sealedClass.Valuer2}");
//        Console.ReadKey();
//    }
//}

//sealed class SealedClass
//{
//    public int Valuer1 { get; set; }
//    public int Valuer2 { get; set; }
//}
#endregion SEALEDCLASS

#region ARMSTRONG
/*SPLIT SPLIT INT VALUE ARMSTRONG*/
/* var value = new List<int>();
 int Armstrong = 0;

 Console.Write("Enter the Number= ");
         string str = Console.ReadLine();

 string[] values = str.Select(s => new string(s, 1)).ToArray();
 int nombres = Convert.ToInt32(str);

         foreach (var item in values)
             value.Add((int) Math.Pow(Convert.ToInt32(item), 3));

         Armstrong = value.Sum();
         if (nombres.Equals(Armstrong))
             Console.WriteLine($"Is Armstrong number:{Armstrong}");
         else
             Console.WriteLine($"Is not Armstrong number:{Armstrong}");*/
#endregion ARMSTRONG

#region WITHANDWITHOUTDELEGAT
/*static void Main(string[] args)
{
    new Program().GetArea(23.45, 67.89);
    new Program().GetPerimetre(23.45, 67.89);

    Console.ReadKey();
}
public void GetArea(double width, double heigth)
{
    Console.WriteLine($"L´aire de cet Rectangle est:{ Math.Round(width * heigth, 2)}");
}
public void GetPerimetre(double width, double heigth)
{
    Console.WriteLine($"L´aire de cet Périmètre  est:{Math.Round(2 * (width + heigth), 2)}");
}*/
/*WITH DELEGATE
   static void Main(string[] args)
    {

        RectangleDelegate rectDelegate = new RectangleDelegate(new Program().GetArea);

        rectDelegate += new Program().GetPerimetre;

        rectDelegate(23.45, 67.89);

        Console.WriteLine();

        rectDelegate.Invoke(13.45, 76.89);

        Console.WriteLine();

        Console.ReadKey();
    }
    public void GetArea(double width, double heigth)
    {
        Console.WriteLine($"L´aire de cet Rectangle est:{ Math.Round(width * heigth, 2)}");
    }
    public void GetPerimetre(double width, double heigth)
    {
        Console.WriteLine($"L´aire de cet Périmètre  est:{Math.Round(2 * (width + heigth), 2)}");
    }

 */
#endregion WITHANDWITHOUTDELEGAT

#region COLLECTIONCLASSES
/*ARRAY LIST*
  ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        arrayList.Reverse();
        foreach (var item in arrayList)
        {
            if ((int)item < 7)
                continue;
            Console.WriteLine(item);
        }

 */
/*
 * HASHTABLE
   Hashtable hashtable = new Hashtable();
       hashtable.Add(1, "notepad.exe");
       hashtable.Add(2, "notepad.exe");
       hashtable.Add(3, "notepad.exe");
       hashtable.Add(4, "notepad.exe");
       hashtable.Add(5, "notepad.exe");
       hashtable.Add(6, "notepad.exe");

       foreach (DictionaryEntry item in hashtable)
       {
           Console.WriteLine(" Key:{0},Value:{1}", item.Key, item.Value);
       }
  */
/*O exemplo a seguir mostra como criar e adicionar valores a uma pilha e como exibir seus valores.STACK

 Stack stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        stack.Push(6);
        stack.Push(7);
        stack.Push(8);

        foreach (var item in stack)
        {
            Console.WriteLine($"Stack result:{item}");
        }
 */
/*Representa uma coleção de pares chave/valor que são classificados pelas chaves e são acessíveis por chave e por índice.*LIST ORDONÉ*
        SortedList list = new SortedList();
        list.Add(5, "Cinq");
                list.Add(4, "Quatre");
                list.Add(3, "Trois");
                list.Add(2, "Deux");
                list.Add(1, "Un");
                foreach (DictionaryEntry item in list)
                {
                    Console.WriteLine("Key:{0},Value:{1}", item.Key, item.Value);
                }
    Console.ReadKey();
    */
/*CONCEPT OF FIRST-IN AND FIRST-OUT COLLECTION
   Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        foreach (var item in queue)
            Console.WriteLine(item);    
 */
#endregion COLLECTIONCLASSES

#region 	FILESTREAM_WRITE_AND_READ_FILES
/*This stream read from and write to any location within a file
  const string path = "C:\\Users\\novad\\OneDrive\\Documentos\\EpreuveCofomo\\FileStream\\MyTest.txt";
    static void Main(string[] args)
    {
        if (File.Exists(path))
            File.Delete(path);
        using (FileStream fs = File.Create(path))
        {
            WriteText(fs, "This is some text\n");
            WriteText(fs, "This is some more text\n");
            WriteText(fs, "and this is on a new line\n");
            WriteText(fs, "The following is a subset of characters");
        }

        using (FileStream fs = File.OpenRead(path))
        {
            byte[] bytes = new byte[1024];
            UTF8Encoding encoding = new UTF8Encoding(true);
            while (fs.Read(bytes, 0, bytes.Length) > 0)
            {
                Console.WriteLine(encoding.GetString(bytes));
            }
        }
        Console.ReadKey();
    }

    private static void WriteText(FileStream fs, string value)
    {
        byte[] info = new UTF8Encoding(true).GetBytes(value);
        fs.Write(info, 0, info.Length);
    }

 */

#endregion FILESTREAM_WRITE_AND_READ_FILES   

#region DIRECTORYINFO

//DirectoryInfo directory = new DirectoryInfo("C:\\Users\\novad\\OneDrive\\Documentos\\EpreuveCofomo\\FileStream");
//        if (directory.Exists)
//        {
//            foreach (FileInfo file in directory.GetFiles())
//                file.Delete(); /*EXCLURE LES FICHIERS INTERNES*/
//            directory.Delete(true); /*EXCLURE LES FICHIER PRINCIPAL*/
//        }
//        else
//            directory.Create();/*CREATE LES FICHIER PRINCIPAL

#endregion DIRECTORYINFO

#region USINGIMPORTANTSEPREUVECOFOMO
/*using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;*/
#endregion USINGIMPORTANTSEPREUVECOFOMO

#region ALL CONSULT LINQ

/*  
 *  USING SELECT WITH ARRAY AND LIST*
 *  
    int[] numbersArray = new int[]{1,2,3,4,5};	
    List<int> numbersList = new List<int>();
    numbersList.Add(1);
    numbersList.Add(2);
    numbersList.Add(3);
    numbersList.Add(4);
    numbersList.Add(5);
    var numbersArraySelct = numbersArray.Select(x => x);
    var numbersListSelct = numbersArray.Select(x => x);

    Console.WriteLine("Item Array:");
    foreach(var itemArry in numbersArraySelct)
        Console.Write(itemArry+"\n");
    Console.WriteLine("Item List:");
    foreach(var itemList in numbersListSelct)
        Console.Write(itemList);
 */


/*
*USING ALL WITH ARRAY AND LIST*
* 
   string[] names = new string[]{"Jovadson","Jodalus","Jonelson","Javidson","Jadiana"};
var result= names.All(x => x.StartsWith("J"));
   Console.WriteLine(result); //RESULT TRUE
string[] names2 = new string[]{"Novadson","Jodalus","Jonelson","Davidson","Cadiana"};
var results = names2.All(x => x.StartsWith("J"));
   Console.WriteLine(results); //RESULT FALSE;
*/

/* USING ANY WITH ARRAY AND LIST*
 string[] names = new string[]{"Jovadson","Jodalus","Jonelson","Davidson","Jadiana"};
 var result= names.Any(x => x.StartsWith("J"));
 var results= names.Select(x => x).Where(x => x.StartsWith("J")).ToList();
    foreach(var item in results)	
       Console.WriteLine(item); //OUTPUT Jovadson Jodalus Jonelson Jadiana 

 */

/*USING CONTAINS
 * 
  string[] names = new string[]{"Jovadson","Jodalus","Jonelson","Davidson","Jadiana"};

var result= names.Select(x => x.Contains("J")).ToList();
foreach(var item in result)	
      Console.WriteLine(item); //OUTPUT True True True False True*/

/*USING WHERE WITH ARRAY E LIST
    /*Array
        int[] valuesArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var resultArray = valuesArray.Where(x => x > 2 && x < 9);
        /*List INT
        List<int> valuesList = new List<int>();	
            for(int i =1;i <=9;i++){
               valuesList.Add(i);
               }
    var resultList = valuesList.Where(x => x > 2 && x < 9);
         foreach(var item in resultArray)
             Console.WriteLine("valuesArray:"+item); //3 4 5 6 7 8
            Console.WriteLine("*************");
         foreach(var item in resultList)
             Console.WriteLine("valuesList:"+item); //3 4 5 6 7 8valuesList
 */

/* USING EXCEPT WITH ARRAY AND LIST
 * /
  int[] numbers1 = { 1, 2, 3 };
 int[] numbers2 = { 3, 4, 5 };
 var result = numbers1.Except(numbers2);

foreach (int number in result)
    Console.WriteLine(number);//OUTPUT 1 2
 */

/*USING INTERCECT WITH ARRAY AND LIST
 * 
 *  int[] numbers1 = { 1, 2, 3 };
 int[] numbers2 = { 3, 4, 5 };
 var result = numbers1.Intersect(numbers2);

foreach (int number in result)
    Console.WriteLine(number);//OUTPUT 3
 */

/*USING UNION WITH ARRAY AND LIST
 * 
 * 	 int[] numbers1 = { 1, 2, 3 };
 int[] numbers2 = { 3, 4, 5 };
 var result = numbers1.Union(numbers2);

foreach (int number in result)
    Console.WriteLine(number);//OUTPUT 1 2 3 4 5

 */


/*//USING  SKIP WITH ARRAAY TO IGNORE ALL FIRST ELEMENTS
 * USING SKIP WITH ARRAY LIST(IGNORE)
 * string[] words = { "one", "two", "three", "four", "five", "six" };
   var result = words.Skip(4);

   Console.WriteLine("Skips the first 4 words:");
   foreach (string word in result)
       Console.WriteLine(word);//Ignora as 4 primeiras palavras(Saute les 4 premiers mots)
   Console.ReadKey();
 * 
 /*
  	 List<int> grades = new List<int>{ 59, 82, 70, 56, 92, 98, 85 };
	 List<int>  lowerGrades = grades.OrderByDescending(grade => grade).SkipWhile(grade => grade >= 80).ToList();

		Console.WriteLine("All grades below 80:");
		foreach (int grade in lowerGrades)
		{
			Console.WriteLine(grade);
		}
		/*59
		82
		70
		56
		92
		98
		85
     */
#endregion ALLCONSULTELINQ

