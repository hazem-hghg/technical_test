namespace DEMO;

public static class Solution
{
    public static  void findMissingNumbers(int n, int[] t)
    {
        // using the hashset. so checking uf element is in collection will be O(1)
        HashSet<int> numbersHashSet = new HashSet<int>(t);
        for (int i = 1; i <= n; i++)
        {
            if (!numbersHashSet.Contains(i))
            {
                Console.WriteLine(i);
            }
        }

    }

   
}