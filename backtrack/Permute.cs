public class Solution {
    // backtrack function
    public void backtrack(IList<IList<int>> result, List<int> tempList, int [] nums) {
        if(tempList.Count == nums.Length){
            result.Add(new List<int>(tempList));            
        } else {
            for(int i=0; i<nums.Length; i++){
                if(tempList.Contains(nums[i])) continue;
                tempList.Add(nums[i]);
                backtrack(result, tempList, nums);
                // remove at the last item
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        backtrack(result, new List<int>(), nums, 0);
        return result;
    }
}