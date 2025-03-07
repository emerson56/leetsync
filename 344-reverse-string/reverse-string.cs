public class Solution {
    public void ReverseString(char[] s) {
        int left= 0, right = s.Length - 1; 
        
        while (left < right)
        {
            char leftVal = s[left];
            s[left] = s[right];
            s[right] = leftVal;
            left++; 
            right--;  
        }
    }
}