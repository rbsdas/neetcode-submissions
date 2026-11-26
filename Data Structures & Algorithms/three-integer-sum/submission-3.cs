public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> outList = new();

        Array.Sort(nums);

        for (int i=0; i<nums.Length; i++){

                if (nums[i] > 0)  // can't sum to zero anymore
                    break;

                if (i>0 && nums[i]==nums[i-1])
                    continue; // avoid dups

                int l = i+1;
                int r = nums.Length-1;
                while (l<r){
                    int currentSum = nums[i]+nums[l]+nums[r];
                    if (currentSum < 0)
                        l++;
                    else if (currentSum > 0 )
                        r--;
                    else{
                       List<int> match = new(){nums[i],nums[l],nums[r]};
                       outList.Add(match);
                       l++;  // move ahead 1, to check rest of the array
                       r--; 
                        // check for dups, this avoids inserting same tuple next time.
                        while(l<r && nums[l]==nums[l-1])
                            l++;
                    }
                }
        }

        return outList;
    }
}
