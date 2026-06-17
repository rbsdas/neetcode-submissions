public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hSet = new HashSet<int>();

        for(int i =0; i<nums.Length; i++){
            if (hSet.Count() >0 && hSet.Contains(nums[i]))
                return true;
            else
                hSet.Add(nums[i]);
        }
        
        return false;
    }
}