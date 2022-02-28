class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        start_window = 0
        max_length = 0
        dict = {}
        
        for i in range(len(s)):
            ch = s[i]
            if ch in dict:
                start_window = max(start_window, dict[ch] + 1)
            dict[ch] = i
            max_length = max (max_length, i-start_window+1)
        return max_length