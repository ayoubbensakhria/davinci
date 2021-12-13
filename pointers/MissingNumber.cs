public class Solution {
    public int MissingNumber(int[] nums) {
        // suffled array
        // the sum of an arithmetic progression = n/2[2a+(n-1) d]
        // a = 0, d=1 => sum = n/2 (n-1)
        // if k is the number of terms : sum = k*(k+1)/2
        // since there is only one missing term
        // missing_int = sum - current_sum  
        // one pointer with linear relationship
        int sum = 0;
        for (int i=0; i<nums.Length; i++){
            sum += nums[i];
        }
        return (nums.Length * (nums.Length+1))/2 - sum ;
    }
}