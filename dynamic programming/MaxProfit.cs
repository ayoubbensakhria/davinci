public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0, min = Int32.MaxValue;
        foreach(int price in prices) {
            // find the min price
            min = Math.Min(price, min);
            // find max profit (gap)
            max = Math.Max(price-min, max);
        }
        return max;
    }
}