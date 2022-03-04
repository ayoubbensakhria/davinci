class Solution:
    def subsets(self, nums: List[int]) -> List[List[int]]:
        def backtrack(result:List[List[int]], chosen:List[int], remaining:List[int]):
            if not remaining:  
                result.append(chosen[:])
                return
            d = remaining.pop(0)
            # choose
            chosen.append(d)
            # explore
            backtrack(result, chosen, remaining)
            chosen.pop()
            backtrack(result, chosen, remaining)
            # unchoose
            remaining.insert(0, d)
        result = []
        chosen = []
        backtrack(result, chosen, nums)
        return result