using System;
using Xunit;
using EasyQuestions;
using LeetCodeQuestions;
using System.Numerics;

namespace EasyQuestions.Test
{
    public class UnitTest1
    {
        [Fact]
        public void MultipleNums()
        {
            //arrange 
            Random rnd = new Random();

            int num1 = rnd.Next();
            int num2 = rnd.Next();
            BigInteger expected =  BigInteger.Parse(num1.ToString()) * BigInteger.Parse(num2.ToString());
            //act
            IEasyQuestions easyQuestionsMultiplyStrings = new  LeetCodeQuestions.EasyQuestions();
            var act = easyQuestionsMultiplyStrings.Multiply(num1.ToString(), num2.ToString());

            //Assert
            Assert.Equal(expected.ToString(), act);
        }


        [Fact]
        public void NextGreatestLetter() {
            //arrage
            char[] letters = new char[] { 'c', 'f', 'j' };

            char target = 'c';
            //act 
            IEasyQuestions easyQuestions = new LeetCodeQuestions.EasyQuestions();


            var expected = "f";
            //assert
            Assert.Equal(expected, easyQuestions.NextGreatestLetter(letters, target).ToString());
        }



        [Fact]
        public void MaxProfit()
        {
            //arrage
            //TODO: make random input not predefined 
            int[] prices = new int[] {7, 1, 5, 3, 6, 4 };

            //act 
            IEasyQuestions easyQuestions = new LeetCodeQuestions.EasyQuestions();
            var expected = "5";
            //assert
            Assert.Equal(expected, easyQuestions.MaxProfit(prices).ToString());
        }
    }
}
