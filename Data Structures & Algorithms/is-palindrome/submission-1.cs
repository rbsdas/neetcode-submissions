public class Solution {
    public bool IsPalindrome(string s) {

        Console.WriteLine("string before prep: "+s);
        string t = PrepareString(s);
        Console.WriteLine("string after prep: "+t);

        int left = 0;
        int right = t.Length-1;
        while (left < right){

            if (t[left] != t[right])
                return false;
            else {
                left++;
                right--;
            }
        }
        return true;
    }

    private string PrepareString(string s){
    /* 
        check for non AlphaNumberic and remove spaces
        to lower
    */
        string t = Regex.Replace(s,@"[^A-Za-z0-9]","");

        return t.ToLower();
    }
}
