public class Solution {
    public bool IsValid(string s) {
        // understand the problem
        // declare en empty char stack
        // traverse the array of chars s[]
        // if ch = the pair of stack.Peek() --> the top element
        // else push
        // finally if stack is empty then return true 
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> pairs = new Dictionary<char, char>(); 
        pairs['('] = ')';
        pairs['['] = ']';
        pairs['{'] = '}';
        pairs[')'] = '-';
        pairs[']'] = '-';
        pairs['}'] = '-';
        
        foreach (char ch in s){
            // check if stack is not empty (Count is faster)
            if(stack.Count > 0){
                if(pairs[stack.Peek()] == ch){
                    stack.Pop();
                } else {
                    stack.Push(ch);
                }                
            } else {
                // if stack is empty then just push ch
                stack.Push(ch);
            }
        }  
        return stack.Count == 0;              
    }
}