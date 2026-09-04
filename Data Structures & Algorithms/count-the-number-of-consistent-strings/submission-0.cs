public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        HashSet<char> allowedSet = new HashSet<char>(allowed);
        int res = words.Length;
        foreach(string word in words) {
            foreach(char c in word) {
                if(!allowedSet.Contains(c)) {
                    res--;
                    break;
                }
            }
        }
        return res;
    }
}