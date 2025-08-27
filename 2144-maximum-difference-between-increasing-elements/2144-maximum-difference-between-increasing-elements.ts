function maximumDifference(nums: number[]): number {
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