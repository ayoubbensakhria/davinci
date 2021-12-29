class Solution:
    def firstUniqChar(self, s: str) -> int:
        dict = collections.Counter(s)
        for i, ch in enumerate(s):
            if dict[ch] == 1:
                return i
        return -1