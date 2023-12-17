using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int number = 0;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);
        Dictionary<int, int> expected = new();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int number = 4;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);
        Dictionary<int, int> expected = new()
        {
            [4] = 1
        };

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = 353535326;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);
        Dictionary<int, int> expected = new()
        {
            [3] = 4,
            [5] = 3,
            [2] = 1,
            [6] = 1,
        };

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = -23232331;

        // Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);
        Dictionary<int, int> expected = new()
        {
            [2] = 3,
            [3] = 4,
            [1] = 1
        };

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
