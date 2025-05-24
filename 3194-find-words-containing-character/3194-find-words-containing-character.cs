public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        var res = new List<int>();

        for(int j = 0; j < words.Length; j++){
            char[] c = words[j].ToCharArray();
            for(int i = 0; i < c.Length; i++){
                if(c[i] == x){
                    res.Add(j);
                    break;
                }
            }
        }
            
        return res;
    }
}