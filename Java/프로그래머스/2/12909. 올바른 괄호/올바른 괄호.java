import java.util.Stack;

class Solution {
    Stack<Character> stack = new Stack<>();
    
    boolean solution(String s) {
        boolean answer = true;
        
        for(char ch : s.toCharArray())
        {
            if(ch == '(')
                stack.push(ch);
            else
                answer = pop();
            
            if(!answer)
                break;
        }
        
        if(!stack.isEmpty())
            answer = false;
        
        return answer;
    }
    
    boolean pop()
    {
        if(!stack.isEmpty())
        {
            if(stack.pop() == ')')
                pop();
        }
        else
        {
            return false;
        }
        
        return true;
    }
}