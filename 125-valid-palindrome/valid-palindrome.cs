public class Solution {
    public bool IsPalindrome(string s) {
        
        int start = 0, end = s.Length -1; 
        while(start < end)
        {
            // advance start pointer if encountered a non-alphanumeric character
            while(start<end && !Char.IsLetterOrDigit(s[start]))
            {
                start++;
            }
            // move left end pointer if encountered a non-alphanumeric character
            while(start < end && !Char.IsLetterOrDigit(s[end]))
            {
                end--;
            }

            if(Char.ToLower(s[start]) != Char.ToLower(s[end]))
            return false; 
            end--; 
            start++;
        }

        return true; 
    }
}