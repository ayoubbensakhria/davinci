public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // there is exactly one solution
        int [] indexes = new int [2];
        
        for (int i=0; i<nums.Length-1; i++){
            for(int j=i+1; j<nums.Length; j++){
                if(nums[i] + nums[j] == target){
                    indexes[0] = i;
                    indexes[1] = j;
                    return indexes;
                }
            }
        }
        return indexes;
    }
}

//-------------------------------
// Faster solution using dictionary
//-------------------------------
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // there is exactly one solution
        // dict[target - i] = i example: dict[9-2] = 0
        // if (exists) dict[i] 
        // the pair is {dict[nums[i]], i}  example dict[7], and nums[0] = 2
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i=0; i<nums.Length; i++){
            if(dict.ContainsKey(nums[i])){
                return new int[] {dict[nums[i]], i};
            } else {
                dict[target-nums[i]] = i;
            }
        }
    // if no pairs
    return new int []{};
    }
}