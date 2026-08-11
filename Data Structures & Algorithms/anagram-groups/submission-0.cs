public class Solution {

    public Boolean isAnagram(string a, string b) {
        return (String.Concat(a.OrderBy(c => c)) == String.Concat(b.OrderBy(c => c)));
    }

    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> res = new List<List<string>>();
        bool[] visited = new bool[strs.Length];
        for(int i=0;i<strs.Length;i++) {
            if(visited[i]) continue;
            visited[i] = true;
            List<string> inner = new List<string>();
            inner.Add(strs[i]);
            for(int j=i+1;j<strs.Length;j++) {
                if(!visited[j] && isAnagram(strs[i], strs[j])) {
                    inner.Add(strs[j]);
                    visited[j] = true;
                }
            }
            res.Add(inner);
        }
        return res;

    }
}
