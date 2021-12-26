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
        // [2,7,11,15] target = 9 EXPECTED [0,1]
        // dict[target - nums(i)] = i example: dict[9-2] = 0
        // if (exists) dict[nums(i)] 
        // the pair is {dict[nums[i]], i} 
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i=0; i<nums.Length; i++){
            if(dict.ContainsKey(nums[i])){
                return new int[] {dict[nums[i]], i};
            } else {
                dict[target-nums[i]] = i;
            }
        }
    // if no result 
    return new int []{};
    }
}