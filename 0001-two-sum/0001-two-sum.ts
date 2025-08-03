function twoSum(nums: number[], target: number): number[] {
     const n = nums.length;
    const map = new Map();
    for(let i = 0; i < n ; i++){
        const com = target - nums[i];
        if(map.has(com)){
            return [map.get(com),i]
        }
        map.set(nums[i],i);
    }
    return [];





    // let n = nums.length;
    // for(let i = 0 ; i < n -1;i++){
    //     for(let j = i+1; j < n;j++){
    //         if(nums[i] + nums[j] === target ){
    //             return [i,j]
    //         }
    //     }
    // }
    // return [];
};