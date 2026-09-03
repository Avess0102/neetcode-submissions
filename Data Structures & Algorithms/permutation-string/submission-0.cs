public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int k = s1.Length;
        if(k > s2.Length) return false;
        Dictionary<char, int> count1 = new Dictionary<char, int>();
        foreach (char ch in s1) {
            if (count1.ContainsKey(ch)) {
                count1[ch]++;
            } else {
                count1[ch] = 1;
            }
        }
        
        int need = count1.Count;
        Console.WriteLine(need);
        for(int i=0;i<s2.Length;i++) {
            Dictionary<char, int> count2 = new Dictionary<char, int>();
            int cur = 0;
            for(int j=i;j<s2.Length;j++) {      
                char ch = s2[j];          
                if (count2.ContainsKey(ch)) {
                    count2[ch]++;
                } else {
                    count2[ch] = 1;
                }
                if(!count1.ContainsKey(ch) || count1[ch] < count2[ch]) {
                    break;
                }
                if(count1[ch] == count2[ch]) cur++;
                if(cur == need) return true; 
            }

        }
        return false;
    }
}
