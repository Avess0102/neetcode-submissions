public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0, j = s.Length - 1;
        while (i < j) {
            while(i<j && !AlphaNum(s[i])) i++;
            while(j>i && !AlphaNum(s[j])) j--;

            if(char.ToLower(s[i]) !=char.ToLower(s[j])) return false;
            i++;
            j--;
        }
        return true;
    }

    
    public bool AlphaNum(char c) {
        return (c >= 'A' && c <= 'Z' ||
                c >= 'a' && c <= 'z' ||
                c >= '0' && c <= '9');
    }
}
