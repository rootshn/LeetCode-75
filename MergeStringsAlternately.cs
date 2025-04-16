public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var result = new System.Text.StringBuilder();
        int i = 0, j = 0;
        int len1 = word1.Length, len2 = word2.Length;

        while (i < len1 || j < len2) {
            if (i < len1) {
                result.Append(word1[i]);
                i++;
            }
            if (j < len2) {
                result.Append(word2[j]);
                j++;
            }
        }

        return result.ToString();
    }
}