public class Solution {
    public bool IsValid(string s) {
        Stack<char> pStack = new();
        string sOpenChars = "([{";
        string sCloseChars = ")]}";

        foreach(char c in s){
            if (sOpenChars.Contains(c)){
                pStack.Push(c);
                continue;
            }

            if (sCloseChars.Contains(c)){
                if (pStack.Count == 0)
                    return false; // closing with out opening.
                
                char top = pStack.Peek();

                if (sOpenChars.IndexOf(top) != sCloseChars.IndexOf(c))
                    return false;
                else {
                    pStack.Pop();
                    continue;
                }
            }
        }

        if (pStack.Count == 0)
            return true;

        return false;
    }
}
