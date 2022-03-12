namespace Exercises;
public class PossibleChanges
{
    private static List<string> Solution(List<string> usernames)
    {
        List<string> result = new List<string>();
        foreach (var username in usernames)
        {
            short minCharacterValue = 200;
            for (int letterIndex = 0; letterIndex < username.Length; letterIndex++)
            {
                if (username[letterIndex] < minCharacterValue)
                {
                    minCharacterValue = (short)username[letterIndex];
                }
            }
            result.Add(minCharacterValue < username[0] ? "YES" : "NO");
        }
        return result;
    }
    public static void Run()
    {
        Solution(new List<string> { "hydra" }).ForEach(Console.WriteLine);
        Console.WriteLine("--");
        Solution(new List<string> { "foo", "bar", "baz" }).ForEach(Console.WriteLine);
        Console.WriteLine("--");
        Solution(new List<string> { "bee", "superhero", "ace" }).ForEach(Console.WriteLine);
        Console.WriteLine("--");
        Solution(new List<string> { "hydra", "andres", "jimena", "bigfish" }).ForEach(Console.WriteLine);
        Console.WriteLine("--");
    }
}