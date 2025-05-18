public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int a = 0,b = 0, max = 0;

        HashSet<char> c = new HashSet<char>();
        char[] z = s.ToCharArray();

        while(b < z.Length){
            if(!c.Contains(z[b])){
                c.Add(z[b]);
                b++;
                max = Math.Max(c.Count,max);
            }else{
                c.Remove(z[a]);
                a++;
            }
        }
        return max;
    }
}