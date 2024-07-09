namespace BracketChecker;

public static class BracketChecker
{
    public static bool Check(string input)
    {
        return CheckCounts(input) && CheckOrder(input);
    }

    private static bool CheckOrder(string input)
    {
        var strippedInput = input.Where(x => x is '<' or '>').ToArray();
        return strippedInput is [] || strippedInput.First() != '>';
    }

    private static bool CheckCounts(string input)
    {
        var openBrackets = input.Count(x => x == '<');
        var closeBrackets = input.Count(x => x == '>');
        
        return openBrackets == closeBrackets;
    }
}