public class Solution {
    public int MaximumDifference(int[] nums) {
        int result = -1;
        int minDiff = nums[0];
        for(int i = 1; i < nums.Length;i++){
            if(nums[i] > minDiff){
                result = Math.Max(result, nums[i] - minDiff);
            }
            else{
                minDiff = nums[i];
            }
        }
        return result;
    }
}