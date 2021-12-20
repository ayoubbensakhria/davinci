class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        dict = {'(': ')', '{': '}', '[': ']', ')':'-', '}':'-', ']':'-'}
        for ch in s:
            if len(stack) > 0:
                if dict[stack[-1]] == ch:
                    stack.pop()
                else:
                    stack.append(ch)
            else:
                stack.append(ch)
        return len(stack) == 0