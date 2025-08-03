function isAnagram(s: string, t: string): boolean {
     if(s.length != t.length) return false;
    const count = new Map();
    for(let i of s){
        count.set(i,(count.get(i)||0) + 1 );
    }
    for(let j of t){
        if(!count.has(j)) return false;
        count.set(j,count.get(j) - 1);
        if(count.get(j) < 0) return false;
    }
    return true;
};