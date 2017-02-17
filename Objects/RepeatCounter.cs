using System;
using System.Collections.Generic;

 namespace RepeatCounterApp.Objects
 {
     public class RepeatCounter {
         private string _givenWord;
         private string _givenString;
         private string[] _sentenceSplitArray;
         char[] delimiterChars = { ' ', ',', '.', ':', '?', '\t' };

         public RepeatCounter(string givenWord, string givenString)
         {
           _givenWord = givenWord;
           _givenString = givenString;
           _sentenceSplitArray = givenString.Split(delimiterChars);
         }

         public string GetWord()
         {
             return _givenWord;
         }

         public string GetString()
         {
             return _givenString;
         }


         public string ReturnInput()
         {
            return "Your chosen word: \"" + _givenWord + "\". Your sentence: \"" + _givenString + "\"";
         }

         public string[] MakeArray()
         {
             return _sentenceSplitArray;
         }

         public int CountRepeats()
         {
             int counter = 0;
             foreach(string word in _sentenceSplitArray)
             {
                 if(word.ToLower() == _givenWord.ToLower())
                 {
                     counter += 1;
                 }
             }
             return counter;
         }
     }
 }
