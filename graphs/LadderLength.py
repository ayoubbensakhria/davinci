class Solution:
    def ladderLength(self, beginWord: str, endWord: str, wordList: List[str]) -> int:
        wordList = set(wordList)
        # Deques are a generalization of stacks and queues 
        # (the name is pronounced “deck” and is short for “double-ended queue”)
        # operations are thread-safe with time complexity O(1)
        q = collections.deque([[beginWord, 1]])
        while q:
            word, size  = q.popleft()
            if word == endWord:
                return size
            for i in range (len(word)):
                for ch in string.ascii_lowercase:
                    nword = word[:i] + ch + word[i+1:]
                    if nword in wordList:                       
                        wordList.remove(nword)
                        q.append([nword, size + 1])
        return 0