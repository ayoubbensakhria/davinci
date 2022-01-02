public class Solution {
    public int NumIslands(char[][] grid) {
        // m x n 2D grid
        // traverse each n array
        //// if current cell = 1 explore left right up un down
        ////// if left right up or down is 1 turn to 0
        ////// else increment count
        //// else continue 
        int count = 0;
        for(int i=0; i<grid.Length; i++){
            for(int j=0; j<grid[i].Length; j++){
                count += sink(grid, i, j);
            }
        }
        return count;
    }
    // BFS
    // sink = turn island to water
    int sink(char[][] grid, int i, int j){
        // recursion base case : till the end of the grid or out of range (i-1 | j-1) or water
        if(i<0 || j<0 || i == grid.Length || j == grid[i].Length || grid[i][j] == '0')
            return 0;
        // turn current to visited
        grid[i][j] = '0';
        
        sink(grid, i+1, j); // sink right
        sink(grid, i-1, j); // sink left
        sink(grid, i, j+1); // sink down
        sink(grid, i, j-1); // sink up
        
        return 1;
    }
}