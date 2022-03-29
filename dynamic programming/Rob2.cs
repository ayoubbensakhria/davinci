public class Solution {
    public int Rob(int[] nums) {
        // special cases
        if(nums.Length == 0) return 0;
        if(nums.Length == 1) return nums[0];

        int previousRobbed = 0, currentRobbed = 0, 
        previousNotRobbed = 0, currentNotRobbed = 0;
        // we will excluse the last house
        for(int i=0; i<nums.Length-1; i++){
            int tempNotRobbed = previousNotRobbed;
            // set previous to current
            previousNotRobbed = currentNotRobbed;
            // set current to temp
            currentNotRobbed = Math.Max(tempNotRobbed + nums[i], previousNotRobbed);
            // same for robbed
            int tempRobbed = previousRobbed;
            // set previous to current
            previousRobbed = currentRobbed;
            // set current to temp
            currentRobbed = Math.Max(tempRobbed + nums[i+1], previousRobbed);   
        }
        // since there are two possibilities of shifting
        // we return the max value between currentRobbed and currentNotRobbed
        return Math.Max(currentRobbed, currentNotRobbed);
    }
}