namespace SearchBlockedDomains;
public class DomainSearch
{
    public int[] ListIndexesOfDomainsThatCanBeVisited(string[] availableDomains, string[] blockedDomains)
    {
        if (availableDomains.Length == 0) return [];

        Array.Sort(blockedDomains);

        return availableDomains
            .Select((availableDomain, index) => new { AvailableDomain = availableDomain, Index = index })
            .Where(x => SearchAlgorithm.BinarySearch(blockedDomains, x.AvailableDomain) < 0)
            .Select(x => x.Index)
            .ToArray();
    }
}
