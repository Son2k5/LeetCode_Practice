/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function(nums) {
    let n = nums.length;
    let set = new Set();
    for(let i = 0 ; i< n; i++){
        if(set.has(nums[i])) return true;
        set.add(nums[i]);
    }
    return false;
};