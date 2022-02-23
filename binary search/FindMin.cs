public class Solution {
    public int FindMin(int[] nums) {
        // binary search
        // nums.Length is always > 0
        int lowest = 0, highest = nums.Length - 1;
        while(lowest<highest){
            // define progressive middle
            int middle = (highest + lowest)/2;
            if(nums[middle] > nums[highest]){
                lowest = middle + 1;                
            } else {
                highest = middle;
            }
        }
        return nums[lowest];   
    }
}