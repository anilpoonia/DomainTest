namespace SearchBlockedDomains.Tests;

using System.Collections;

public class DomainSearchTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
           new string[] {"unlock.microservice.md", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us" },
           new string[] { "microservice.md", "visitwar.de", "piratebay.co.uk", "list.stolen.credit.card.us" },
           new int[] { 1, 3, 4, 5 }
        };
        yield return new object[]
        {
            new string[] { "images.adult.hb", "ringo.adult.hb", "video.ringo.adult.hb" },
            new string[] { "adult.hb" },
            new int[] { }
        };
        yield return new object[]
        {
            new string[] {  },
            new string[] { "adult.hb" },
            new int[] { }
        };
        yield return new object[]
        {
            new string[] { "images.adult.hb", "ringo.adult.hb", "video.ringo.adult.hb" },
            new string[] {  },
            new int[] { 0, 1, 2 }
        };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}