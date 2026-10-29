using Zilean.Scraper.Features.LzString;

namespace Zilean.Tests.Tests;

public class DecompressorTests
{
    // Canonical lz-string 1.4.4 vectors, independent of the decoder under test.
    [Theory]
    [InlineData("IYlA", "aaaaa")]
    [InlineData("IYI16A", "abababa")]
    [InlineData("IY1-EA", "aaaaaaaaaaaaaaaa")]
    [InlineData("JclA", "ééééé")]
    [InlineData(
        "NobwRAZglgNgpgOwIYFs5gFxiTnYA0YARgJ4AucAzpgKyEAWSl9m2RS77YAvgLpA",
        """[{"filename":"aaaaa","bytes":5,"hash":"abababa"}]""")]
    public void FromEncodedUriComponentExpandsNextDictionaryEntry(string encoded, string expected)
    {
        Decompressor.FromEncodedUriComponent(encoded).Should().Be(expected);
    }
}
