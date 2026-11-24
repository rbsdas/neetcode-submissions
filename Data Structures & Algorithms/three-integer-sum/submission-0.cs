public class Solution {

        public List<List<int>> ThreeSum(int[] nums)
        {
            List<List<int>> output = new();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    break;

                if (i>0 && nums[i] == nums[i - 1])
                    continue;

                int l = i + 1;
                int r = nums.Length-1;

                int threeSum = 0;
                while (l < r)
                {
                    threeSum = nums[i] + nums[l] + nums[r];
                    if (threeSum < 0)
                    {
                        l++;
                    }
                    else if (threeSum > 0)
                    {
                        r--;
                    }
                    else
                    {
                        output.Add(new List<int> { nums[i], nums[l], nums[r] });
                        l++;
                        r--;

                        while (l < r && nums[l] == nums[l-1])
                            l++;
                    }
                }
            }
            return output;
        }
}
