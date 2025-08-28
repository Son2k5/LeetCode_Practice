/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[]}
 */
var nextGreaterElement = function(nums1, nums2) {
    var result = [];
    for(let i = 0; i< nums1.length; i++){
        var m = nums1[i];
        var index = nums2.indexOf(m);
        var nextGreater = -1;
        for(let j = index +1; j < nums2.length; j++){
            if(nums2[j] > m){
                nextGreater = nums2[j];
                break;
            }
        }
        result[i] = nextGreater;
    }
    return result;
};