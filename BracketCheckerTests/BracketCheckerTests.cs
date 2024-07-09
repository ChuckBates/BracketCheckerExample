namespace BracketCheckerTests;

using BracketChecker;

public class Tests
{
    [Test]
    public void ShouldReturnTrueOnEmptyString()
    {
        var input = "";
        var result = BracketChecker.Check(input);
        
        Assert.That(result, Is.True);
    }

    [Test]
    public void ShouldReturnTrueOnStringWithNoBrackets()
    {
        var input = "asdf";
        var result = BracketChecker.Check(input);
        
        Assert.That(result, Is.True);
    }

    [Test]
    public void ShouldReturnTrueOnStringWithSingleBracketsAndInnerContent()
    {
        var input = "<asdf>";
        var result = BracketChecker.Check(input);
        
        Assert.That(result, Is.True);
    }

    [Test]
    public void ShouldReturnTrueOnStringWithSingleBracketsAndOuterContent()
    {
        var input = "as<>df";
        var result = BracketChecker.Check(input);

        Assert.That(result, Is.True);
    }

    [Test]
    public void ShouldReturnFalseOnStringWithSingleOpenBracket()
    {
        var input = "<";
        var result = BracketChecker.Check(input);
        
        Assert.That(result, Is.False);
    }

    [Test]
    public void ShouldReturnFalseOnStringWithSingleCloseBracket()
    {
        var input = ">";
        var result = BracketChecker.Check(input);
        
        Assert.That(result, Is.False);
    }

    [Test]
    public void ShouldReturnTrueOnStringWithSingleMatchingBrackets()
    {
        var input = "<>";
        var result = BracketChecker.Check(input);
        
        Assert.That(result, Is.True);
    }

    [Test]
    public void ShouldReturnFalseOnStringWithSingleMisMatchingBrackets()
    {
        var input = "><";
        var result = BracketChecker.Check(input);
        
        Assert.That(result, Is.False);
    }

    [Test]
    public void ShouldReturnFalseOnStringWithOuterBracketUnClosed()
    {
        var input = "<<>";
        var result = BracketChecker.Check(input);
        
        Assert.That(result, Is.False);
    }

    [Test]
    public void ShouldReturnFalseOnStringWithMultipleLayeredBracketsNotClosed()
    {
        var input = "<<>><<<>><>";
        var result = BracketChecker.Check(input);
        
        Assert.That(result, Is.False);
    }

    [Test]
    public void ShouldReturnFalseOnStringWithTrailingOpenBracket()
    {
        var input = "<<>><";
        var result = BracketChecker.Check(input);
        
        Assert.That(result, Is.False);
    }

    [Test]
    public void ShouldReturnFalseOnStringWithTrailingCloseBracket()
    {
        var input = "<<>>>";
        var result = BracketChecker.Check(input);
        
        Assert.That(result, Is.False);
    }

    [Test]
    public void ShouldReturnFalseOnStringWithMissingInnerOpenBracket()
    {
        var input = "<<>><<>><>>";
        var result = BracketChecker.Check(input);
        
        Assert.That(result, Is.False);
    }

    [Test]
    public void ShouldReturnTrueOnStringWithDeepMatchingBrackets()
    {
        var input = "<<<<><>><<<>><<<>>>>><<>>>";
        var result = BracketChecker.Check(input);
        
        Assert.That(result, Is.True);
    }

    [Test]
    public void ShouldReturnFalseOnStringWithDeepBracketsMissingInnerOpenBracket()
    {
        var input = "<<<<><>><<>><<<>>>>><<>>>";
        var result = BracketChecker.Check(input);
        
        Assert.That(result, Is.False);
    }
}