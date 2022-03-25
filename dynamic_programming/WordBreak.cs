public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        int size = s.Length;
        var list = Enumerable.Repeat(false,size+1).ToArray();
        list[0] = true;
        
        for(int i=0; i<= s.Length; i++){
            if(list[i])
                for (int j=i+1; j<= s.Length; j++){
                    if(wordDict.Contains(s[i..j]))
                        list[j] = true;
                }
        }
        return list.Last();
    }
}