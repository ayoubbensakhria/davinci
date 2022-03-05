class Solution:
    def generateParenthesis(self, n: int) -> List[str]:
        def backtrack(leftRemain, rightRemain, path, result):
            if leftRemain > rightRemain or leftRemain < 0 or rightRemain < 0:
                return  # backtracking
            if leftRemain == 0 and rightRemain == 0:
                result.append(path)
                return 
            backtrack(leftRemain-1, rightRemain, path+"(", result)
            backtrack(leftRemain, rightRemain-1, path+")", result)
        result = []
        backtrack (n, n, "", result)
        return result