public class Solution {
    public int NumIslands(char[][] grid) {
        int count = 0;
        for(int i=0; i<grid.Length; i++){
            for(int j=0; j<grid[i].Length; j++){
                // count successfully processed islands
                count += sink(grid, i, j);
            }
        }
        return count;
    }
    // DFS
    // sink = turn island to water or mark as visited ('0')
    int sink(char[][] grid, int i, int j){
        // if we are outside the grid i<0 || j<0 
        // or the current cell is visited  grid[i][j] == '0'
        // or we are at the bottom of the grid j == grid[i].Length
        // Not processed skip and return count 0 
        if(i<0 || j<0 || i == grid.Length || j == grid[i].Length || grid[i][j] == '0')
            return 0;
        // else process
        grid[i][j] = '0';  // sink current or turn current to visited
        sink(grid, i+1, j); // sink right, do recursion as current
        sink(grid, i-1, j); // sink left, do recursion as current
        sink(grid, i, j+1); // sink down, do recursion as current
        sink(grid, i, j-1); // sink up, do recursion as current
        // if all processed --> an island was found
        return 1;
    }
}