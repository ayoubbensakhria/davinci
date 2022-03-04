public class Solution {
    public void backtrack(IList<IList<int>> result, List<int> tempList, int [] nums, int start) {
        result.Add(new List<int>(tempList));            
        for(int i=start; i<nums.Length; i++){
            if(tempList.Contains(nums[i])) continue;
            tempList.Add(nums[i]);
            backtrack(result, tempList, nums, i+1);
            // remove at the last item
            tempList.RemoveAt(tempList.Count - 1);
        }
    }
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        backtrack(result, new List<int>(), nums, 0);
        return result;
    }
}