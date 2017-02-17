using Xunit;
using RepeatCounterApp.Objects;
using System;
using System.Collections.Generic;

namespace RepeatCounterApp
{
    public class RepeatCounterTest
    {
        [Fact]
        public void ReturnInput_ReturnTwoInputtedStrings_Strings()
        {
            //arrange
            string expectedOutput = "Your chosen word: \"the\". Your sentence: \"When the baby grows up to be an old man, they bury his body in the ground.\"";
            string givenWord = "the";
            string givenString = "When the baby grows up to be an old man, they bury his body in the ground.";
            //act
            RepeatCounter testCounter = new RepeatCounter(givenWord, givenString);
            //assert
            Assert.Equal(expectedOutput, testCounter.ReturnInput());
        }

        [Fact]
        public void MakeArray_ReturnGivenStringAsArray_Array()
        {
            //arrange
            string[] expectedOutputArray = new string[] {"Here", "rests", "the", "old", "oak", "tree"};
            string givenWord = "the";
            string givenString = "Here rests the old oak tree";
            //act
            RepeatCounter testCounter = new RepeatCounter(givenWord, givenString);
            //assert
            Assert.Equal(expectedOutputArray, testCounter.MakeArray());
        }

        [Fact]
        public void CountRepeats_ReturnNumberOfTimesWordAppears_Int()
        {
            //arrange
            int expectedOutput = 1;
            string givenWord = "the";
            string givenString = "Here rests the old oak tree";
            //act
            RepeatCounter testCounter = new RepeatCounter(givenWord, givenString);
            //assert
            Assert.Equal(expectedOutput, testCounter.CountRepeats());
        }
    }
}
