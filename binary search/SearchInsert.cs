public class Solution {
    public int SearchInsert(int[] nums, int target) {
        // binary search
        // Worst-case performance: O(log n)
        // define lowest and highest
        int lowest = 0, highest = nums.Length;
        while(lowest<highest){
            // define progressive middle
            int middle = lowest + (highest-lowest)/2;
            if(nums[middle] >= target){
                highest = middle;                
            } else {
                lowest = middle + 1;
            }
        }
        return lowest;      
    }
}