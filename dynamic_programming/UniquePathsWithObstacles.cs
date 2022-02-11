public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        // define the width
        int width = obstacleGrid[0].Length;
        int [] list = new int[width];
        // robot position
        list[0] = 1;
        foreach (int[] row in obstacleGrid){
            for(int i=0; i<width; i++){
                // if the rock is at index i
                if(row[i] == 1)
                    list[i] = 0;
                // else and if i>0
                else if(i>0)
                    list[i] += list[i-1];
            }
        }
        return list[width-1];
    }
}