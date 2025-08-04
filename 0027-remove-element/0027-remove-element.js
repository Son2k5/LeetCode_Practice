/**
 * @param {number[]} nums
 * @param {number} val
 * @return {number}
 */
var removeElement = function(nums, val) {
    let k = 0;
    for(let i of nums){
        if(i != val) nums[k++] = i;
    }
    return k;
};