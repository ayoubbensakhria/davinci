public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        // define the width
        int width = obstacleGrid[0].Length;
        var list = Enumerable.Repeat(0, width).ToArray();
        // robot position
        list[0] = 1;
        foreach (int[] row in obstacleGrid){
            for(int i=0; i<width; i++){
                // if the rock is at index i
                if(row[i] == 1)
                    list[i] = 0;
                // make sure i is not 0
                else if(i>0)
                    list[i] += list[i-1];
            }
        }
        return list.Last();
    }
}