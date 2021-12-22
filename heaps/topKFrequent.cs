public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // declare dict
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int num in nums){
            if(dict.ContainsKey(num)){
                dict[num] ++;
            } else {
                dict[num] = 1;
            }
        }
        // use Link to get the most frequent values then return the keys
        return dict.OrderByDescending(x=>x.Value).Take(k)
                .ToDictionary(x=>x.Key, y=>y.Value).Keys.ToArray();
    }
}