public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> count = new Dictionary<int,int>();
        int test = nums.Length / 2;
        foreach(var num in nums){
            if(!count.ContainsKey(num)) count[num] = 1;
            else count[num]++;
            if(count[num] > test) return num;
        }
        return -1;
        
    }
}