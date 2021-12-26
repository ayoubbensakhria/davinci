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