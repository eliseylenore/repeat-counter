using System;
using System.Collections.Generic;

 namespace RepeatCounterApp.Objects
 {
     public class RepeatCounter {
         private string _givenWord;
         private string _givenString;
         private string[] _sentenceSplitArray;

         public RepeatCounter(string givenWord, string givenString)
         {
           _givenWord = givenWord;
           _givenString = givenString;
           _sentenceSplitArray = givenString.Split(' ');
         }

         public string ReturnInput()
         {
            return "Your chosen word: \"" + _givenWord + "\". Your sentence: \"" + _givenString + "\"";
         }

         public string[] MakeArray()
         {
             return new string[] {"blah"};
         }
     }
 }
