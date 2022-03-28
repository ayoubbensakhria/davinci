public class Solution {
    public int SearchInsert(int[] nums, int target) {
        // binary search
        // Worst-case performance: O(log n)
        // define lowest and highest
        int lowest = 0, highest = nums.Length;
        while(lowest<highest){
            // since the max complexity is O(log n)
            // define progressive middle and jump to lowest
            int middle = lowest + (highest-lowest)/2;
            if(nums[middle] >= target){
                // move highest to middle
                highest = middle;                
            } else {
                // mover lowest towards highest
                lowest = middle + 1;
            }
        }
        return lowest;      
    }
}