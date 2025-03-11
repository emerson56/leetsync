public class Solution {
    public void MoveZeroes(int[] nums) {
        // initialize 2 pointers 
        int fast = 0;
        int nextP = 0; // points to the next location of the last seen non-zero

        while (fast < nums.Length)
        {
            if(nums[fast]!=0)
            {
                nums[nextP] = nums[fast];
                nextP++;
            }
            fast++;
        }

        // Fill in the rest
        for(int i = nextP; i < nums.Length; i++)
        {
            nums[i] = 0; 
        }
    }
}