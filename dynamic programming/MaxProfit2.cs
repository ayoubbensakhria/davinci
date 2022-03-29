public class Solution {
    public int MaxProfit(int[] prices) {
        // Since it is impossible to sell stock on first day, 
        // set -infinity as initial value for currentHold
        int currentHold = Int32.MinValue, currentNotHold = 0;
        foreach (int price in prices){
            int previousHold = currentHold;
            int previousNotHold = currentNotHold;
            // either keep hold, or buy in stock today at stock price
            currentHold = Math.Max(previousHold, previousNotHold - price);
            // either keep not-hold, or sell out stock today at stock price
            currentNotHold = Math.Max(previousNotHold, previousHold + price);
        }
        return prices.Any() ? currentNotHold : 0; 
    }
}