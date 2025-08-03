public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> ans = new HashSet<int>();
        int n = nums.Length;
        for(int i =0; i < n; i++){
            if(ans.Contains(nums[i])){
                return true;
            }
            ans.Add(nums[i]);
        }
        return false;
    }
}