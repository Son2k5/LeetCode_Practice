function majorityElement(nums: number[]): number {
    const map = new Map<number, number>();
    const n = nums.length;
    for(let num of nums){
        const count = (map.get(num) || 0) +1;
        map.set(num, count);
        if(count > Math.floor(n/2)) return num;
    }
    return -1;

};