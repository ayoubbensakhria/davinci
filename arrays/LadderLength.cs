// BFS Solution 
public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        // the end word must be in the List
        // All the words in wordList are unique
        // difference in one letter (one single letter)
        // if no word in the list return the number of sequences
        // BFS
        // Steps: 
        // (1) construct a wordSet from the wordList
        // (2) initialize a queue with the beginWord 
        // (3) set the counter step = 1 (in case no words BFS returns 0)
        // (4) dequeue > replace the current word letters with the alphabet letters > compare
        //     if the word exists in the set remove it from the set and enqueue it increment step
        // (5) if endWord is reached return step+1 
        HashSet<string> wordSet = new HashSet<string>(wordList);
        Queue<string> q = new Queue<string>();
        q.Enqueue(beginWord);
        
        int step = 0;

        while(q.Any()){
            // get queue size
            int size = q.Count;
            for (int k=0; k<size; k++){
                string word = q.Dequeue();
                for (int i=0; i<endWord.Length; i++){
                    for(char ch='a'; ch<='z'; ch++){
                        StringBuilder nword = new StringBuilder(word);
                        nword[i] = ch;
                        if(wordSet.Contains(nword.ToString())){
                            if(nword.ToString() == endWord) return step + 1;
                            wordSet.Remove(nword.ToString());
                            q.Enqueue(nword.ToString());
                        }
                    }
                }
            }
            step++;
        }
        return step;
    }
}
