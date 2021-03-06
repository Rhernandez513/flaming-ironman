﻿using System;
using System.IO;


namespace IntroCS
{
  class GradeFiles
  {
    /// Process grade files based on a class abbreviation
    /// on the command line, or provided interactively.
    public static void Main(string[] args)
    {
      // TEMPORARY line to get oriented to the file system:
      Console.WriteLine("Current directory: " +
      Directory.GetCurrentDirectory());
    }
    // codeIndex chunk
    /// Take the first letter code for a catagory, and
    /// return the index of that category in categories.
    static int codeIndex(string code, string[] categories)
    {
      for (int i = 0; i < categories.Length; i++)
      {
        if (categories[i].Trim().StartsWith(code))
        {
          return i;
        }
      }
      return -1; //required by compiler: shouldn't reach
    }
  } // end codeIndex chunk
}


// The below is the old version Luis copied from book
// if anything here is usefull, put it in above code
// anything this line will eventually be deleted



//namespace IntroCS
//{
//  class GradeFile
//  {

//    public static void Main(string[] args)
//    {
//      {
//        string categoryFileName = "sample.txt";
//        string output = "output.txt";
//        Console.WriteLine("Directory of {0}: {1}",
//            categoryFileName, FIO.GetLocation(categoryFileName));
//        Console.WriteLine("Path to {0}: {1}",
//            categoryFileName, FIO.GetPath(categoryFileName));
//        StreamReader reader1 = FIO.OpenReader(categoryFileName);
//        if (reader1 != null)
//        {
//          Console.Write(reader1.ReadToEnd());
//          Console.WriteLine("First reader test passed.");
//          reader1.Close();
//        }
//        StreamReader reader2 = FIO.OpenReader(FIO.GetLocation(categoryFileName),
//            categoryFileName);
//        if (reader2 != null)
//        {
//          Console.WriteLine("Second reader test passed.");
//          reader2.Close();
//        }
//        StreamWriter writer1 = FIO.OpenWriter(FIO.GetLocation(categoryFileName),
//            output);
//        writer1.WriteLine("File in the same directory as {0}.", categoryFileName);
//        writer1.Close();
//        Console.WriteLine("Writer test passed; file written at \n {0}",
//            FIO.GetPath(output));
//      }
//    }
//    static int codeIndex(string code, string[] categories)
//    {
//      for (int i = 0; i < categories.Length; i++)
//      {
//        if (categories[i].Trim().StartsWith(code))
//        {
//          return i;
//        }
//      }
//      return -1;
//    }
//    static string[] getStringArray(string input)
//    {
//      string[] code = input.Split(',');
//      return code;
//    }
//    static int[] getIntArray(string input)
//    {
//      string[] code = input.Split(',');
//      int[] intparts = new int[code.Length];
//      for (int i = 0; i < code.Length; i++)
//        intparts[i] = int.Parse(code[i]);
//      return intparts;
//    }
//    static string[] getClassCategories(string categoryFileName)
//    {
//      var reader = new StreamReader(categoryFileName);
//      string categories = reader.ReadLine();
//      string[] catNames = getStringArray(categories);
//      for (int i = 0; i < catNames.Length; i++)
//      {
//        string firstLetters = catNames[i];
//        string first_letter = firstLetters.Substring(0, 1);
//      }
//      return catNames;
//    }
//    static int[] weightValues(string categoryFileName)
//    {
//      int targetLine = 2;
//      int counter = 1;
//      int[] weight_values = new int[0];
//      var reader = new StreamReader(categoryFileName);
//      while (!reader.EndOfStream)
//      {
//        string weights = reader.ReadLine();
//        if (counter == targetLine)
//        {
//          weight_values = getIntArray(weights);
//        }
//        counter++;
//      }
//      //for (int i = 0; i < weight_values.Length; i++)
//      //{


//      //}

//      return weight_values;
//    }
//    static int[] numberscat(string categoryFileName)
//    {
//      int targetLine = 3;
//      int counter = 1;
//      int[] item_values = new int[0];
//      var reader = new StreamReader(categoryFileName);
//      while (!reader.EndOfStream)
//      {
//        string items = reader.ReadLine();
//        if (counter == targetLine)
//        {
//          item_values = getIntArray(items);
//        }
//        counter++;
//      }
//      //for (int i = 0; i < item_values.Length; i++)
//      //{
//      //
//      //}
//      return item_values;
//    }
//    static string[] getRoster(string studentFileName, int targetLine)
//    {
//      int counter = 1;
//      string[] next_Student = new string[0];
//      var reader = FIO.OpenReader(studentFileName);
//      while (!reader.EndOfStream)
//      {
//        string item = reader.ReadLine();
//        if (counter == targetLine)
//        {
//          next_Student = getStringArray(item);
//        }
//        counter++;
//      }
//      //for (int i=0; i < next_Student.Length; i++)
//      //{

//      //}
//      Console.ReadLine();
//      return next_Student;
//    }
//  }
//}
