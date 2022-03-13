public class Solution {
    
    public int max_count = 0;
    public int current_areas = 0;
    
    public int MaxAreaOfIsland(int[][] grid) {
        // island count
        int count = 0;
        for (int i=0; i<grid.Length; i++){
            for (int j=0; j<grid[i].Length; j++){
                count += sink(grid, i, j);
                // take the max_count
                max_count = Math.Max(max_count, current_areas);
                // reset current_areas
                current_areas = 0;
            }
        }
        return max_count;
    }
    // recursion (DFS)
    int sink(int[][] grid, int i, int j){
        if (i<0 || j<0 || i==grid.Length || j==grid[i].Length || grid[i][j]==0)
            return 0;
        // while recursion count areas
        current_areas = grid[i][j] == 1 ? current_areas + 1 : current_areas;
        // else process
        grid[i][j] = '0';  // sink current or turn current to visited
        sink(grid, i+1, j); // sink right, do recursion as current
        sink(grid, i-1, j); // sink left, do recursion as current
        sink(grid, i, j+1); // sink down, do recursion as current
        sink(grid, i, j-1); // sink up, do recursion as current
        // if all processed --> an island has been found
        return 1;
    }
}