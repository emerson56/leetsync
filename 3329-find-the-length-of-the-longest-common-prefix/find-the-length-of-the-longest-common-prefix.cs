public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        // Add all possible prefixes from first array to a hashset
        var set = new HashSet<int>();
        foreach(int num in arr1)
        {
            var temp = num; 
            while (temp > 0)
            {
                set.Add(temp);
                temp/=10; 
            }
        }

        // Compare each element of array2 with the hashset
            // if matches as is, we have a 
        int maxLength = 0;
        foreach(int num in arr2)
        {
            var temp = num; 
            while (temp > 0)
            {
                if(set.Contains(temp))
                {
                    maxLength = Math.Max(temp.ToString().Length, maxLength);
                    break;
                }
                temp /=10;
            }
        }

        return maxLength;
    }
}