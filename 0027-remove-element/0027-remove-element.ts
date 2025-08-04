function removeElement(nums: number[], val: number): number {
    let k = 0;
    for(let i of nums){
        if(i != val) nums[k++] = i;
    }
    return k;
};