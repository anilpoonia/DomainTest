namespace SearchBlockedDomains.Tests;

using Xunit;

public class DomainSearchTests
{
    [Theory(DisplayName = "Get index of domains that can be visited")]
    [ClassData(typeof(DomainSearchTestData))]
    public void DomainsThatCanBeVisited(string[] availableDomains, string[] blockedDomains, int[] expectedResult)
    {
        //Arrange
        var domainSearch = new DomainSearch();

        //Act
        var result = domainSearch.ListIndexesOfDomainsThatCanBeVisited(availableDomains, blockedDomains);

        //Assert
        Assert.Equal(expectedResult, result);
    }
}