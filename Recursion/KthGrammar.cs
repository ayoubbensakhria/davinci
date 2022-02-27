public class Solution {
    public int KthGrammar(int n, int k) {
        // recursion solution
        // n is already >= 1
        // Getting the ceiling position of the parent, 
        // hence adding quotient and remainder
        if(n==1)
            return 0;
        int parent = KthGrammar(n-1, (k/2 + k%2));
        bool isOdd = (k%2 == 1);
        if(parent == 1){
            return isOdd ? 1:0;            
        } else {
            return isOdd ? 0:1;                        
        }       
    }
}