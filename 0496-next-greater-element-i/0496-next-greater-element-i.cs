public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] result = new int[nums1.Length];
        for(int i = 0 ;i < nums1.Length; i++){
            int m = nums1[i];
            int index = Array.IndexOf(nums2,m);
            int nextGreater = -1;
            for(int j = index +1 ; j< nums2.Length;j++){
                if(nums2[j] > m ){
                    nextGreater = nums2[j];
                    break;
                }
            }
            result[i] = nextGreater;

        } 
        return result;
    }
}