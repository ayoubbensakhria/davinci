public class Solution {
    public int MaxSubArray(int[] nums) {
        // initialize the maxSum (returned)
        int maxSum = nums[0];
        // initialize currentSum
        int currentSum = nums[0];
        
        for(int i=1; i<nums.Length; i++){
            // compute the current sum
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            // compare and take the maxSum
            maxSum = Math.Max(maxSum, currentSum);
        }
        return maxSum;
    }
}