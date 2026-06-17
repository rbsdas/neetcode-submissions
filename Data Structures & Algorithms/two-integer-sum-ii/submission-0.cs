public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        /* two pointers, from each side
            while l<r ...
        */      
        
        int l=0;
        int r=numbers.Length-1;
        while (l < r){
            int interimSum = numbers[l]+numbers[r] ;
            if (interimSum == target)
                break;
            if (interimSum < target)
                l++;
            else 
                r--;

        }
        int[] result = new int[]{l+1, r+1};
        return result;
    }
}
