public class Solution {
    public void backtrack(IList<IList<int>> result, List<int> tempList, int [] nums, int remain, int start) {
        if(remain<0){
            return;
        } else if(remain==0){
            result.Add(new List<int>(tempList));            
        } else {
            for(int i=start; i<nums.Length; i++){
                tempList.Add(nums[i]);
                backtrack(result, tempList, nums, remain - nums[i], i);
                // remove at the last item
                tempList.RemoveAt(tempList.Count - 1);
            } 
        }
    }
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        backtrack(result, new List<int>(), candidates, target, 0);
        return result;
    }
}