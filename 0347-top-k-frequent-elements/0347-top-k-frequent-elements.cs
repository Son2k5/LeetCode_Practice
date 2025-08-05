public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int,int>();
        foreach(int num in nums){
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
        }
        var heap = new PriorityQueue<int, int>();
        foreach(var pair in freqMap){
            heap.Enqueue(pair.Key, pair.Value);
            if(heap.Count > k){
                heap.Dequeue();
            }
        }
        var result = new List<int>();
        while(heap.Count > 0){
            result.Add(heap.Dequeue());
        }
        return result.ToArray();
    }
}