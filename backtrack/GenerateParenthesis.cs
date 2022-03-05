public class Solution {
     public void backtrack(IList<string> result, string str, int open, int close, int max) {
        if(str.Length == max*2){
            result.Add(str);
            return;
        }     
        if(open < max)
            backtrack(result, str+"(", open+1, close, max);
        if(close < open)
            backtrack(result, str+")", open, close+1, max);
    }
    public IList<string> GenerateParenthesis(int n) {
        IList<string> result = new List<string>();
        backtrack(result, "", 0, 0, n);
        return result;
    }
}