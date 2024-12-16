namespace selection_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word1 = "abc";
            string word2 = "pqr";

            string res = Merge(word1 , word2);
            Console.WriteLine(res);

        }


        static string Merge(string word1, string word2)
        {
            int i = 0, j = 0;

            var merged = new System.Text.StringBuilder();

            while (i < word1.Length && j < word2.Length)
            {
                merged.Append(word1[i++]);
                merged.Append(word2[j++]);
            }
            while (i < word1.Length)
            {
                merged.Append(word1[i++]);
            }
            while (j < word2.Length)
            {
                merged.Append(word2[j++]);
            }

            return merged.ToString();



        }

    }

}

