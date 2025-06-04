public class Solution {
    public IList<string> LetterCombinations(string digits) {
            var digitDictionary = new Dictionary<char, string>()
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        var result = new List<string>();

        if (digits.Length == 0 || string.IsNullOrEmpty(digits)) return result;
        result.Add("");
        for (var i = 0; i < digits.Length; i++)
            result = result
                .SelectMany(x => digitDictionary[digits[i]].Select(y => x + y.ToString()))
                .ToList();
        return result;
    }
}