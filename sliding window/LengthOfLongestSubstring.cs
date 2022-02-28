public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max_length = 0;
        int start_window = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        
        for (int i=0; i<s.Length; ++i){          
            char currentChar = s[i];
            if(dict.ContainsKey(currentChar))
                start_window = Math.Max(start_window, dict[currentChar] + 1);
            dict[currentChar] = i;
            max_length = Math.Max(max_length, i - start_window + 1);
        }
        return max_length;
    }
}