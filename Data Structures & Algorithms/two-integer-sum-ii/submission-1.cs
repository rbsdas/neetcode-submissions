public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l=0;
        int r=numbers.Length-1;

        while (l<r){
            int curSum = numbers[l]+numbers[r];
            if (curSum == target)                
                break;
            if (curSum < target)
                l++;
            else
                r--;
        }

        return new int[]{l+1,r+1};

    }
}
