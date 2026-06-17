public class Solution {
    public int Search(int[] nums, int target) {
        int l=0;
        int r = nums.Length-1;

        while (l<=r){
            int midPoint= (l+r)/2;
            int midValue=nums[midPoint];
            if (midValue==target)
                return midPoint;
            else if (midValue < target)
                l = midPoint+1;
            else if (midValue > target)
                r = midPoint-1;
        }

        return -1; 
    }
}
