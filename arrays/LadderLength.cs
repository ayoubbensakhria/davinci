// BFS Solution 
public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        // BFS
        // Steps: 
        // (3) set the counter step = 1 (in case no words BFS returns 0)
        // (4) dequeue > replace the current word letters with the alphabet letters > compare
        //     if the word exists in the set remove it from the set and enqueue it increment step
        // (5) if endWord is reached return step+1 
        // construct a wordSet from the wordList
        HashSet<string> wordSet = new HashSet<string>(wordList);
        // initialize a queue with the beginWord 
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
