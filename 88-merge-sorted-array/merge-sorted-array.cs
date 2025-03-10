public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // initialize 2 pointers at the end of each array
        // helps to not shift elements
        int i = m - 1; 
        int j = n - 1;
        int k = m + n -1;

        while (i>=0 && j>=0){
            // compare value
            if (nums1[i] > nums2[j]){
                nums1[k--] = nums1[i--];
            }
            else{
                nums1[k--] = nums2[j--];
            }
        }

        // Copy rest of array
        while (j>=0){
            nums1[k--] = nums2[j--];
        }

        return ;


    }
}