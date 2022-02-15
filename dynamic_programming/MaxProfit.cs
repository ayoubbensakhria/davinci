public class Solution {
    public int MaxProfit(int[] prices) {
        //Kadane's Algorithm
        int max = 0, min = Int32.MaxValue;
        foreach(int price in prices) {
            min = Math.Min(price, min);
            max = Math.Max(price-min, max);
        }
        return max;
    }
}