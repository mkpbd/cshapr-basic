namespace TypeBasics
{

    public class Arrays
    {

        public void CharVowels()
        {
            char[] vowels = new char[5]; // Declare an array of 5 characters
            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';
            Console.WriteLine(vowels[1]); // e
            for (int i = 0; i < vowels.Length; i++)
                Console.Write(vowels[i]); // aeiou

            char[] vowels1 = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] vowels2 = { 'a', 'e', 'i', 'o', 'u' };
            int[] a = new int[1000];
            Console.Write(a[123]);

            Point[] aa = new Point[1000];
            int x = aa[500].X; // 0
        }


        public void IndicesAndRanges()
        {
            /**
            Indices
Indices let you refer to elements relative to the end of an array, with the ^
operator. ^1 refers to the last element, ^2 refers to the second-to-last
element, and so on:
            */
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char lastElement = vowels[^1]; // 'u'
            char secondToLast = vowels[^2]; // 'o'
            Index first = 0;
            Index last = ^1;
            char firstElement = vowels[first]; // 'a'
            char lastElement1 = vowels[last]; // 'u'

            //=========== Ranges ======
            //   Ranges let you “slice” an array by using the .. operator:
            char[] firstTwo = vowels[..2]; // 'a', 'e'
            char[] lastThree = vowels[2..]; // 'i', 'o', 'u'
            char[] middleOne = vowels[2..3]; // 'i'
            Range firstTwoRange = 0..2;
            char[] firstTwo2 = vowels[firstTwoRange]; // 'a', 'e'
        }

        public void MultidimensionalArrays()
        {
            /**

            Multidimensional arrays come in two varieties: rectangular and jagged.
            Rectangular arrays represent an n-dimensional block of memory, and jagged
            arrays are arrays of arrays.
*/
            int[,] matrix = new int[3, 3];
            //The GetLength method of an array returns the length for a given dimension
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i * 3 + j;
                }
            }

            int[,] matrix2 = new int[,]
            {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };

        }


        public void JaggedArrays()
        {
            int[][] matrix = new int[3][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[3]; // Create inner array
                for (int j = 0; j < matrix[i].Length; j++)
                    matrix[i][j] = i * 3 + j;
            }

            int[][] matrix2 = new int[][]
            {
                new int[] {0,1,2},
                new int[] {3,4,5},
                new int[] {6,7,8,9}
            };
        }

        public void SimplifiedArrayInitializationExpressions()
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int[,] rectangularMatrix =
            {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };
            int[][] jaggedMatrix =
            {
                new int[] {0,1,2},
                new int[] {3,4,5},
                new int[] {6,7,8,9}
             };
        }

    }
}