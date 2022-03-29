public class Solution {
    public int Rob(int[] nums) {
        // previous be maximum gain we can get, using last i-1
        // current be maximum gain we can get, using last i
        int previous = 0, current = 0;
        foreach(int num in nums){
            int temp = Math.Max(previous+num, current);
            // set previous to current
            previous = current;
            // set current to temp
            current = temp;
        }
        return current;
    }
}