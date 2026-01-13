/**
 * @param {number[]} arr
 * @param {number} k
 * @param {number} x
 * @return {number[]}
 */
var findClosestElements = function(arr, k, x) {
    let left = 0;
    let right  = arr.length - 1;
    while(right - left  +1 > k){
        if(Math.abs(arr[left] - x) > Math.abs(arr[right] - x)){
            left ++;
        }else{
            right --;
        }
    }
    let result = [];
    for(let i = left ; i<= right ;i++){
        result.push(arr[i]);
    }
    return result;
};