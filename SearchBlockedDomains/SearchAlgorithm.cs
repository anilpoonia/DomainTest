namespace SearchBlockedDomains;
internal class SearchAlgorithm
{
    internal static int BinarySearch(string[] items, string keyToFind)
    {
        int left = 0;
        int right = items.Length - 1;
        int middle;

        while (left <= right)
        {
            middle = (left + right) / 2;
            var item = items[middle];

            if (keyToFind.Contains(item))
            {
                return middle;
            }
            else
            {
                if (keyToFind.CompareTo(item) > 0)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
        }

        return -1;
    }
}
