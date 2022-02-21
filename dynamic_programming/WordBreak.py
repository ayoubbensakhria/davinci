class Solution:
    def wordBreak(self, s: str, wordDict: List[str]) -> bool:
        size = len(s)
        list = [False] * (size + 1)
        list[0] = True
        
        for i in range(size+1):
            if list[i]:
                for j in range (i+1, size+1):
                    if s[i:j] in wordDict:
                        list[j] = True
        return list[-1]