public class Solution {
    public void MoveZeroes(int[] nums) {
        // Shift non-zero values as far forward as possible
        // Fill the remaining space with zeros
        int pos = 0;
        for(int i=0; i<nums.Length; i++){
            if(nums[i] != 0){
                if(i != pos){
                    nums[pos] = nums[i];
                    nums[i] = 0;
                }
                pos ++;
            }
        }
    }
}