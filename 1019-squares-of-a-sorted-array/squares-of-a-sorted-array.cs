public class Solution {
    public int[] SortedSquares(int[] nums) {
        // key insights: 
        // the largest elements are at the edges
        // 

        int left = 0, right = nums.Length - 1; 
        var res = new int[nums.Length];

        for(int i = res.Length -1; i >=0; i--)
        {
            if(Math.Abs(nums[right]) > Math.Abs(nums[left]))
            {
                res[i] = nums[right] * nums[right];
                right--;
            }
            else
            {
                res[i] = nums[left] * nums[left];
                left++;
            }
        }

        return res; 
    }
}