public class Solution {

    public string Encode(IList<string> strs) {
        // string encoded_string = "";
        StringBuilder encoded_string = new StringBuilder();
        foreach(string str in strs) {
            encoded_string.Append(str.Length).Append("#").Append(str);
        }
        Console.WriteLine(encoded_string);
        return encoded_string.ToString();
    }

    public List<string> Decode(string s) {
        List<string> decode = new List<string>();
        int i=0, j=0;
        while(i<s.Length) {
            j = i;
            while(s[j]!='#') {
                j++;
            }
            int length = 0;
            length = int.Parse(s.Substring(i, j-i));
            i = j+1;
            decode.Add(s.Substring(i, length));
            i += length;
        }
        return decode;
   }

}
