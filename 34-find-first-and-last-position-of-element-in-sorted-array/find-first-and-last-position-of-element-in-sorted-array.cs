public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        
        int left = BinarySearch(nums, target, true);
        int right = BinarySearch(nums, target, false);
        return new int[] {left, right };
    }

    private int BinarySearch(int[] nums, int target, bool leftSearch)
    {
        int low = 0; 
        int high = nums.Length - 1; 
        int boundary = -1;

        while (low <= high)
        {
            int mid = (low + high)/2;
            if(nums[mid] == target)
            {
                boundary = mid; 
                if(leftSearch)
                high = mid-1; // move left
                else
                low = mid + 1; // move right

            }

            else if (nums[mid] > target)
            {
                // move left
                high = mid -1; 
            }
            else
            { 
                low = mid + 1;
            }

        }

        return boundary;
    }
}