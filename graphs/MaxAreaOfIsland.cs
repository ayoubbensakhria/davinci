public class Solution {
    
    public int max_count = 0;
    public int current_areas = 0;
    
    public int MaxAreaOfIsland(int[][] grid) {
        // find the number of islands using recursive DFS
        // count the areas
        // return the max
        int islandCount = 0;
        for (int i=0; i<grid.Length; i++){
            for (int j=0; j<grid[i].Length; j++){
                islandCount += sink(grid, i, j);
                max_count = Math.Max(max_count, current_areas);
                current_areas = 0;
            }
        }
        return max_count;
    }
    // recursion (DFS)
    int sink(int[][] grid, int i, int j){
        if (i<0 || j<0 || i==grid.Length || j==grid[i].Length || grid[i][j]==0)
            return 0;
        // sink current
        current_areas = grid[i][j] == 1 ? current_areas + 1 : current_areas;
        grid[i][j] = 0;
        
        // sink adjacent cells
        sink(grid, i+1, j);
        sink(grid, i-1, j);
        sink(grid, i, j+1);
        sink(grid, i, j-1);
        return 1;
    }
}