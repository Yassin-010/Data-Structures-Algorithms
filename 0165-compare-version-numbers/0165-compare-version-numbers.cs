
public class Solution {
    public int CompareVersion(string version1, string version2) {
        // Split the versions into individual revisions
        string[] rev1 = version1.Split('.');
        string[] rev2 = version2.Split('.');
        
        int maxLength = Math.Max(rev1.Length, rev2.Length);
        
        for (int i = 0; i < maxLength; i++) {
            int v1 = i < rev1.Length ? int.Parse(rev1[i]) : 0;
            int v2 = i < rev2.Length ? int.Parse(rev2[i]) : 0;
            
            if (v1 > v2) {
                return 1;
            } else if (v1 < v2) {
                return -1;
            }
        }
        
        return 0;
    }
}
