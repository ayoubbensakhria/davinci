public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        // sliding window solution
        int start_window = 0;
        int max_length = nums.Length;
        int result = max_length + 1;
        for(int i=0; i<max_length; i++){
            target -= nums[i];
            while(target<=0){
                result = Math.Min(result, i - start_window + 1);
                target += nums[start_window];
                start_window ++;
            }
        }
    return result % (max_length + 1);
    }
}