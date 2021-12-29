public class Solution {
    public int FirstUniqChar(string s) {
        // if dict contains key ch --> ++ value
        // if dict doesnt contains ch --> add (ch, 1) as key val pair
        // find the first value of 1 and return it
        // return -1 otherwise
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (int i=0; i<s.Length; i++){
            char ch = s[i];
            if(dict.ContainsKey(ch)){
                dict[ch] ++;
            } else {
                dict[ch] = 1;
            }
        }
        for (int i=0; i<s.Length; i++){
            if(dict[s[i]] == 1)
                return i;
        }
        return -1;
    }
}
//-------------------------------
// solution 2
//-------------------------------
public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();
        for (int i=0; i<s.Length; i++){
            char ch = s[i];
            if(dict.ContainsKey(ch)){
                dict[ch][1] ++;
            } else {
                dict[ch] = new List<int>{i, 1};
            }
        }
        var result = dict.Where(q=>q.Value[1].Equals(1)).ToList();
        return result.Count > 0 ? result[0].Value[0] : -1;
    }
}