namespace Exercises;
public class CompleteABGroups
{
    private static int Solution(string S)
    {
        if (string.IsNullOrWhiteSpace(S))
            return 0;

        var blockList = new List<string>();
        char currentChar = S[0];
        string currentBlock = string.Empty;
        int maxBlockLength = 0;

        for (int currentLetterIndex = 0; currentLetterIndex < S.Length;)
        {
            //if a character is different, a new block is started
            if (currentChar == S[currentLetterIndex])
            {
                currentBlock += S[currentLetterIndex++];
            }

            else
            {
                blockList.Add(currentBlock);
                maxBlockLength = CalculateMax(currentBlock, maxBlockLength);

                currentChar = S[currentLetterIndex];
                currentBlock = string.Empty; //Cleaning the current block helper
            }
        }

        //Adding last block if any remains
        if (!string.IsNullOrWhiteSpace(currentBlock))
        {
            blockList.Add(currentBlock);
            maxBlockLength = CalculateMax(currentBlock, maxBlockLength);
        }

        var result = 0;

        //Here we are calculating the number of letters to complete the entire block taking into account the max length of the blocks
        foreach (var item in blockList)
        {
            result += Math.Abs(maxBlockLength - item.Length);
        }

        return result;
    }

    //Count the minimum number of additional letters needed to obtain a string with blocks of equal lengths
    private static int CalculateMax(string currentBlock, int maxBlockLength)
    {
        if (maxBlockLength < currentBlock.Length)
            maxBlockLength = currentBlock.Length;
        return maxBlockLength;
    }

    public static void Run()
    {
        Console.WriteLine(Solution("babaa"));
        Console.WriteLine(Solution("bbbab"));
        Console.WriteLine(Solution("bbbaaabbb"));
        Console.WriteLine(Solution("baaabab"));
        Console.WriteLine(Solution("aabbaa"));
        Console.WriteLine(Solution("ababaa"));
    }
}
