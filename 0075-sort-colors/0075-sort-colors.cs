public class Solution {
    public void SortColors(int[] nums) {
        // Use  Dutch National Flag Algorithm
        // viec su dung thuat toan nay giup tan dugn duoc mang bao gom 012
        //  co the su dung sort thong thuong nhung khong duoc toi uu khi xu li
        int left = 0;
        int mid = 0;
        int right = nums.Length -1;
        while(mid <= right){
            if(nums[mid] == 0){
                (nums[left], nums[mid]) = (nums[mid], nums[left]);
                left++;
                mid++;
            }
            else if(nums[mid] == 2){
                (nums[mid],nums[right]) = (nums[right], nums[mid]);
                right--;
            }
            else{
                mid++;
            }
        }
    }
}