public class Solution {
    public int CoinChange(int[] coins, int amount) {
        // DP
        int size = amount + 1;
        var list = Enumerable.Repeat(Single.PositiveInfinity, size).ToArray();
        list[0] = 0;     
        for (int i=1; i<amount+1; i++){
            foreach(int coin in coins){
                if(i-coin >= 0){
                    list[i] = Math.Min(list[i], list[i-coin] + 1);
                }
            }
        }
        if(list.Last() == Single.PositiveInfinity)
            return  -1;
        return Convert.ToInt32(list.Last());
    }
}