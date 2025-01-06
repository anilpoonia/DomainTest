// See https://aka.ms/new-console-template for more information
//using BenchmarkDotNet.Running;
using SearchBlockedDomains;

Console.WriteLine("Search Blocked Domains");

var availableDomains = new[] { "unlock.microservice.md", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us" };
var blockedDomains = new[] { "microservice.md", "visitwar.de", "piratebay.co.uk", "list.stolen.credit.card.us" };

var domainSearch = new DomainSearch();
var result = domainSearch.ListIndexesOfDomainsThatCanBeVisited(availableDomains, blockedDomains);
Console.WriteLine(String.Join(",", result));

//In order to view benchmark result, Please follow these steps:
//1. Change "Debug" to "Release"
//2. Uncomment line number 2.
//3. Uncomment below line 

//var summary = BenchmarkRunner.Run<DomainSearchBenchmarks>();
