namespace Test_task_1
{
    public static class StringExtensions
    {
        public static int GetLenghtOfMaxSubsequence(this string stringToSearch, char charToFind)
        {
            int counter = 0;
            int max = 0;
            int i = 0;

            while (i < stringToSearch.Length)
            {
                if (stringToSearch[i] == charToFind)
                {
                    counter = 0;

                    while (i < stringToSearch.Length && stringToSearch[i] == charToFind)
                    {
                        counter++;
                        i++;
                    }

                    if (max < counter)
                    {
                        max = counter;
                    }
                }

                i++;
            }

            return max;
        }
    }
}
