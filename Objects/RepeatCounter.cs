using System;
using System.Collections.Generic;

 namespace RepeatCounterApp.Objects
 {
     public class RepeatCounter {
         private string _givenWord;
         private string _givenString;

         public RepeatCounter(string givenWord, string givenString)
         {
           _givenWord = givenWord;
           _givenString = givenString;
         }

         public string ReturnInput()
         {
            return "Your chosen word: \"" + _givenWord + "\". Your sentence: \"" + _givenString + "\"";
         }
     }
 }
