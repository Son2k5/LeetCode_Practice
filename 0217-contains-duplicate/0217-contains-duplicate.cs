public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        //Solution 1
        // Su dung sort va kiem tra
        int n = nums.Length;
        for(int i = 0 ; i< n; i++){
            int temp = nums[i];
            int j = i - 1;
            while(j >= 0 && nums[j] > temp){
                nums[j+1] = nums[j];
                nums[j] = temp;
                j--;
            
        }
        nums[j + 1] = temp;

            if (j >= 0 && nums[j] == nums[j + 1])
        return true;
        }
        return false;
       
       
       
       
       
       
       
       
        // Solution 2
        //su dung hashset
        // HashSet<int> ans = new HashSet<int>();
        // int n = nums.Length;
        // for(int i =0; i < n; i++){
        //     if(ans.Contains(nums[i])){
        //         return true;
        //     }
        //     ans.Add(nums[i]);
        // }
        // return false;
    }
}