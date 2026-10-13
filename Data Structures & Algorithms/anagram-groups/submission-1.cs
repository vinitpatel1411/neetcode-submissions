public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> strList = new Dictionary<string, List<string>>();
        foreach(string str in strs){
            int[] count = new int[26];
            foreach(char c in str){
                count[c - 'a']++;
            }
            string key = string.Join(',', count);
            if(!strList.ContainsKey(key))
                strList[key] = new List<string>();
            strList[key].Add(str);
        }
        return strList.Values.ToList();
    }
}
