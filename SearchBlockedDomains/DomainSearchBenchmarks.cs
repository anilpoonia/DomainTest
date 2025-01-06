// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using SearchBlockedDomains;

[MemoryDiagnoser]
public class DomainSearchBenchmarks
{
    //"BlockedDomains.txt" have all domains that are available in "AvailableDomains.txt" except google.com, mail.google.com, maps.google.com, onedrive.google.com, etc.
    private readonly string[] availableDomains = File.ReadAllLines(@"AvailableDomains.txt");
    private readonly string[] blockedDomains = File.ReadAllLines(@"BlockedDomains.txt");

    [Benchmark(Baseline = true)]
    public void ListIndexesOfDomainsThatCanBeVisited()
    {
        var domainSearch = new DomainSearch();

        domainSearch.ListIndexesOfDomainsThatCanBeVisited(availableDomains, blockedDomains);
    }
}