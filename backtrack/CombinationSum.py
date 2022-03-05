class Solution:
    def combinationSum(self, candidates: List[int], target: int) -> List[List[int]]:
        def backtrack(candidates: List[int], target: int, tempList: List[int], result: List[List[List[int]]]):
            if target < 0:
                return
            if target == 0:
                result.append(tempList)
                return
            for i, num in enumerate(candidates):
                backtrack(candidates[i:], target - num, tempList + [num], result)
        
        result = []
        backtrack (candidates, target, [], result)
        return result