public class Solution {
    public int MaxSubArray(int[] nums) {
        // contiguous subarry with condition
        // sliding window 
        // max_sum = max(sum[j] - sum[i]) = max(sum[j]) - min(sum[i]) where i>j
        // so we try to find i such that sum[j] i.e total+sum[i] is max       
        int sum = 0;
        int min_sum = 0;
        int result = nums[0]; // default result in case of array length = 1
               
        for (int i=0; i<nums.Length; i++){
            // min sum deals with a pointer j which must be < i
            min_sum = i>0 ? Math.Min(min_sum, sum): 0;
            sum += nums[i]; 
            result = Math.Max(sum-min_sum, result);
        }               
        return result;
    }
}