/**
 * @param {number[]} nums
 * @return {number}
 */
var maximumDifference = function(nums) {
    let minDiff = nums[0];
    let result = -1;
    for(var i = 0; i < nums.length; i++){
        if(nums[i] > minDiff){
            result = Math.max(result, nums[i] - minDiff);
        }
        else{
            minDiff = nums[i];
        }
    }
    return result;
};