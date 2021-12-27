public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        // give that char is an unsigned 16-bit value.
        // algorithm: sort letters and compare using a dictionary.
        // return the dictionary values
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
        foreach(string str in strs){
            // Sort Array and Return string is O(nlogn + 2*n) = O(1)
            string sorted = new string (str.OrderBy(c => c).ToArray());
            if(dict.ContainsKey(sorted)){
                dict[sorted].Add(str);
            } else {
                dict[sorted] = new List<string>{str};
            }
        }
        return dict.Values.ToList();
    }
}