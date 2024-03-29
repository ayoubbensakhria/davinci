
public class Solution {
    public int LengthOfLIS(int[] nums) {
        // Dynamic programming
        if (nums.Length == 0)
            return 0;
        int size = nums.Length;
        // create a list with length = size instances of 1 
        // which is the minimum possible increasing sequence length
        var list = Enumerable.Repeat(1,size).ToArray();

        for (int i=1; i<size; i++){
            // look back!
            for (int j=0; j<i; j++){
                if(nums[i]>nums[j]){
                    // in list
                    // increment j then
                    // take the max between list[i], list[j]+1
                    list[i] = Math.Max(list[i], list[j]+1);
                }
            }
        }
        // return the max value in list
        return list.Max();
    }
}
//----------------------------------------------------------------
// solution 2 ----------------------------------------------------
//----------------------------------------------------------------

public class Solution {
    public int LengthOfLIS(int[] nums) {
        // Dynamic programming
        int [] list = new int[nums.Length];
        int size = 0;
        foreach(int num in nums){
            int start = 0;
            int end = size;
            while(start != end){
                // get the middle point
                int middle = (start + end)/2;
                if (list[middle]<num){
                    start = middle + 1;                    
                } else {
                    end = middle;
                }       
            } // end while
            list[start] = num;
            if(start == size)
                size++;
        }
        return size; 
    }
}