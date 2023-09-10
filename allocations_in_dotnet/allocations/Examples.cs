using System.Security.Cryptography.X509Certificates;

namespace allocations;

public static class Examples
{
    private static List<LargeObject> largeObjects = new List<LargeObject>();
    
    // To debug and see in any profiler heaps fragmentation
    public static void Allocate_On_LargeObjectHeap()
    {
        for (int index = 0; index < 200; index++)
        {
            largeObjects.Add(new LargeObject());

            if (index > 100)
            {
                var maxIndex = largeObjects.Count - 1;
                largeObjects.RemoveAt(Random.Shared.Next(0, maxIndex));
            }
        }
    }
}