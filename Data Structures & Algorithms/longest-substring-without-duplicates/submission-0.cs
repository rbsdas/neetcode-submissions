public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> uniqueCharsInString= new();

        int left=0;
        int maxLength = 0;
        for (int right=0; right < s.Length; right++){
            while (uniqueCharsInString.Contains(s[right])){
                uniqueCharsInString.Remove(s[left]);
                left++;
            } 

            uniqueCharsInString.Add(s[right]);
            maxLength = Math.Max(maxLength, uniqueCharsInString.Count());
       
        }
        return maxLength;
    }
}
