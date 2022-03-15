// BFS Solution 
public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        // GRAPH + BFS
        // Time Complexity O(N^2 * w) 
        //      N = word Length, N = String Comparison, w word Count
        // construct a wordSet from the wordList
        HashSet<string> wordSet = new HashSet<string>(wordList);
        // initialize a queue with the beginWord 
        Queue<string> q = new Queue<string>();
        q.Enqueue(beginWord);
        //set the counter step = 0 the wordList is empty or contains only 1 words
        // return 0
        int step = 0;

        while(q.Any()){
            // get queue size
            int size = q.Count;
            for (int k=0; k<size; k++){
                // get the word on the top of the queue
                string word = q.Dequeue();
                for (int i=0; i<endWord.Length; i++){
                    for(char ch='a'; ch<='z'; ch++){
                        StringBuilder nword = new StringBuilder(word);
                        // do swaps from the alphabet on position i 
                        nword[i] = ch;
                        if(wordSet.Contains(nword.ToString())){
                            // as soone as we reach end word we return step+1
                            if(nword.ToString() == endWord) return step + 1;
                            // else remove that word from wordSet
                            wordSet.Remove(nword.ToString());
                            // Enqueue the new word nword (found in the wordSet)
                            q.Enqueue(nword.ToString());
                        }
                    }
                }
            }
            // increment steps by 1
            step++;
        }
        return step;
    }
}
