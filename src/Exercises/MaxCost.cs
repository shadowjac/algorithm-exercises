namespace Exercises;

public class MaxCost
{
    private static int Solution(List<int> cost, List<string> labels, int dailyCount)
    {
        int costPerDay = 0, laptopManufactured = 0, maxCostPerDay = 0;
        for (int i = 0; i < labels.Count; i++)
        {
            costPerDay += cost[i];
            if (labels[i] == "legal")
            {
                laptopManufactured++;
            }
            else
            {
                continue;
            }

            if (laptopManufactured == dailyCount)
            {
                if (maxCostPerDay < costPerDay) maxCostPerDay = costPerDay;
                laptopManufactured = 0;
                costPerDay = 0;
            }
        }

        return maxCostPerDay;
    }

    public static void Run()
    {
        Console.WriteLine(Solution(new List<int> { 2 }, new List<string> { "illegal" }, 1));
        Console.WriteLine(Solution(new List<int> { 2, 3, 5, 11, 1 }, new List<string> { "legal", "illegal", "legal", "illegal", "legal" }, 2));
        Console.WriteLine(Solution(new List<int> { 0, 3, 2, 3, 4 }, new List<string> { "legal", "legal", "illegal", "legal", "legal" }, 1));
    }
}