public class Solution {
    public void MoveZeroes(int[] nums) {
        // set 2 pointers
        int fast = 0, nextPtr = 0;
        // iterate through the array
        // goal move all the non-zeroes to the left
        while (fast < nums.Length)
        {
            /*
                non-zero goes to the left
                0 1 3
            */
            if(nums[fast]!=0)
            {
                nums[nextPtr++] = nums[fast];
            }
            fast++;
        }

        // fill the rest of the elements with 0
        for(int i = nextPtr; i < nums.Length; i++)
        {
            nums[i] = 0; 
        }
    }
}