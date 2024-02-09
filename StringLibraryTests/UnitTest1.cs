using UtilityLibraries;

namespace StringLibraryTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void ShouldReturnTrueWhenFirstLetterisUpperCase()
    {
        string[] words = new[]{"Apple","Banana","Cherry"};

        foreach (var word in words)
        {
            var result = word.StartsWithUpper();

            Assert.IsTrue(result, $"The result of {result} should have been false for {word}.");
        }
    }

 [TestMethod]
    public void ShouldReturnFalseWhenFirstLetterisUpperCase()
    {
        string[] words = new[]{"apple","banana","cherry"};

        foreach (var word in words)
        {
            var result = word.StartsWithUpper();

            Assert.IsFalse(result, $"The result of {result} should have been false for {word}.");
        }
    }
}