public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        // num1 and num2 sorted in ascending order [n1, n2] [m1, m2]       
        Dictionary<IList<int>, int> dict = new Dictionary<IList<int>, int>();

        for (int n = 0; n< Math.Min(k, nums1.Length); n++){
            for (int m = 0; m<Math.Min(k, nums2.Length); m++){
                    dict[new List<int>{nums1[n], nums2[m]}] = nums1[n]+nums2[m]; 
            }          
        }        
        return dict.OrderBy(q=>q.Value)
                    .ToDictionary(x => x.Key, x => x.Value)
                    .Keys.Take(k).ToList();
    }
}