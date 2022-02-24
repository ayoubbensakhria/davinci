public class Solution {
    public int Search(int[] nums, int target) {
        int lowest = 0, highest = nums.Length - 1;
        while(lowest<highest){
            // define progressive middle
            int middle = (highest + lowest)/2;
            if(nums[middle] > nums[highest]){
                if(target > nums[middle] || target <= nums[highest]){
                    lowest = middle + 1;                 
                } else {
                    highest = middle;
                }
            } else {
                if(target > nums[middle] && target <= nums[highest]){
                    lowest = middle + 1;                 
                } else {
                    highest = middle;
                }
            }
        }
        if(lowest == highest && nums[lowest] != target)
            return -1;
        return lowest; 
    }
}