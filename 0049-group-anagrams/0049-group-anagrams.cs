public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary <string, List<string>> map = new Dictionary<string, List<string>>();
        foreach(var str in strs){
            char[] arr = str.ToCharArray();
            for( int i = 0 ; i< arr.Length - 1; i++){
            bool  swapped = false;
                for(int j = 0; j < arr.Length - i - 1; j ++ ){
                    if(arr[j] > arr[j+1]){
                        char temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
            if(!swapped ) break;
            }

            string key = new string(arr);
            if(!map.ContainsKey(key)) map[key] = new List<string>();
            map[key].Add(str);
        }

           return map.Values.Select(x => (IList<string>)x).ToList();
    }
}













        // var map = new Dictionary<string, List<string>>();
        // foreach(string word in strs){
        //     char[] chars= word.ToCharArray();
        //     Array.Sort(chars);
        //     string key = new string(chars);

        //     if(!map.ContainsKey(key)) map[key] = new  List<string>();
        //     map[key].Add(word);
        // }
        // return map.Values.Select(group => (IList<string>)group).ToList();