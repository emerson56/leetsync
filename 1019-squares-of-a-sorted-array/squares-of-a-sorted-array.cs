public class Solution {
    public int[] SortedSquares(int[] nums) {
        // start from the end to ensure the resulting array is also sorted
        int i = nums.Length - 1; 
        int left = 0; 
        int right = i; 
        var res = new int[nums.Length];

        /*
        Key insight: numbers at the of array will produce bigger number because input array is 
        sorted and we only focu on numbers. 
        */
        while (i >= 0)
        {
            if(Math.Abs(nums[left]) > Math.Abs(nums[right])){
                res[i] = nums[left] * nums[left];
                left++;
            }
            else{
               res[i] = nums[right] * nums[right];
               right--; 
            }

            i--;
        }

        return res; 
    }
}