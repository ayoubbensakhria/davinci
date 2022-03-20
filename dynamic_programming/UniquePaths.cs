public class Solution {
    public int UniquePaths(int m, int n) {
        // the robot can either move right or down
        // a dynamic programming problem
        var list = Enumerable.Repeat(1, n).ToArray();
        //loop vertically
        for (int i=1; i<m; i++){
            // loop horizontally
            for(int j=1; j<n; j++){
                list[j] = list[j-1] + list[j];
            }
        }
        return list.Last();
    }
}