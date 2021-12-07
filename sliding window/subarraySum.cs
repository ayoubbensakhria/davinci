public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int counter = 0;
        //
        // Order + Subarray sum = sliding window (a very nice start)
        //
        // iterate and calculate the sum at the same time
        // increment the counter everytime the condition is satisfied
        for (int i = 0; i<nums.Length; i++){
            // rest the total
            int total = 0;
            for (int j=i; j<nums.Length; j++)   {
               total += nums[j];
                if(total == k) 
                    counter++;   
            }                   
        }       
        return counter;
    }
}

// ----------------------------------------------------------------
// Dictionary method
public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int counter = 0;
        int total = 0;
        Dictionary <int, int> dict = new Dictionary<int, int>();
        
        // for each item: add to the dictionnary as key and sum as a value
        // then just count the values that are equal to k
        // the mathematical relationship between two cumulative sums 
        // sum[i] - sum[j] = k => sum[j] = sum[i] - k
        //
        dict[0] = 1;
        
        for (int i = 0; i<nums.Length; i++){
            total += nums[i];
            // check if dict Contains sum[j] = total - k
            // 
            if(dict.ContainsKey(total - k)){
                // add instance of sum[j] 
                // if there are two points that have the same cumulative sum
                // so we have two subarrays that start or end wuth sum[i]
                counter += dict[total-k];
            }
            // save cumulative sums with the count of instances
            if(dict.ContainsKey(total)){
                dict[total] ++;
            } else {
                dict[total] = 1;
            }                     
        }       
        return counter;
    }
}