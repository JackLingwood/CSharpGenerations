using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7
{
    public class Tuples
    {

        #region Declaration of tuples
        public void DeclarationOfTupleBefore()
        {
            Tuple<string, string> letters = new Tuple<string, string>("a", "b");
            string a = letters.Item1;
            string b = letters.Item2;
        }

        public void DeclarationOfTupleNow()
        {
            var letters = ("a", "b");
            string a = letters.Item1;
            string b = letters.Item2;
        }

        public void DeclarationOfTupleNow2()
        {
            (string Alpha, string Beta) namedLetters = ("a", "b");
            string a = namedLetters.Alpha;
            string b = namedLetters.Beta;
        }
        #endregion

        #region Assignment of tuples
        
        public void AssignmentOfTupleNow()
        {
            var alphabetStart = (Alpha: "a", Beta: "b");
            string a = alphabetStart.Alpha;
            string b = alphabetStart.Beta;
        }

        /// <summary>
        /// Names can be assigned on the left and right, but the left will override the right.
        /// Unnamed elements will default to Item1,Item2, etc.
        /// </summary>
        public void AssignmentOfTupleNow2()
        {
            // This produces Warning: CS8123: The tuple element name 'Alpha' is ignored because a different name is
            // specified by the target type '(string First, string Second)'.CSharp7 
            (string First, string Second) firstLetters = (Alpha: "a", Beta: "b");
            string a = firstLetters.First;
            string b = firstLetters.Second;

            (string First, string) firstLetters2 = (Alpha: "a", Beta: "b");
            string a2 = firstLetters2.First;
            string b2 = firstLetters2.Item2;

            (string, string) firstLetters3 = (Alpha: "a", Beta: "b");
            string a3 = firstLetters3.Item1;
            string b3 = firstLetters3.Item2;

            var firstLetters4 = ("a","b");
            string a4 = firstLetters4.Item1;
            string b4 = firstLetters4.Item2;

            (string First, string, string Third) firstLetters5 = (Alpha: "a", Beta: "b",Gamma:"g");
            string a5 = firstLetters5.First;
            string b5 = firstLetters5.Item2;
            string c5 = firstLetters5.Third;
        }

        #endregion

        #region Tuple as function return type

        public static Tuple<int, int> BeforeSortBySize(int numberA, int numberB)
        {
            if (numberA > numberB)
            {
                return Tuple.Create(numberA, numberB);
            }

            return Tuple.Create(numberB, numberA);
        }

        private static (int Max, int Min) NowSortBySize(int numberA, int numberB)
        {
            if (numberA > numberB)
            {
                return (numberA, numberB);
            }
            return (numberB, numberA);
        }

        private void TestSortBySize()
        {
            var resultBefore = BeforeSortBySize(10, 5);
            var maxBefore = resultBefore.Item1;
            var minBefore = resultBefore.Item2;

            var resultNow = NowSortBySize(10, 5);
            var maxNow = resultNow.Max;
            var minNow = resultNow.Min;
        }

        private void TestSortBySizeWithDeconstruction()
        {
            (int max9, int min8) = BeforeSortBySize(10, 5);
            int maxBefore = max9;
            int minBefore = min8;
            
            (int maxNowadays, int minNowadays) = NowSortBySize(10, 5);
            int maxNow = maxNowadays;
            int minNow = minNowadays;            
        }

        #endregion
    }
}
