//Measure how much memory specific action use.
public class MemoryCheck
{
    var memory = GC.GetTotalMemroy(true);
    // ..
    var memoryAfter = GC.GetTotalMemroy(true);
    Console.WriteLine() // In order to avoid garbage collector to remove previous actions, add additional 
    Console.WriteLine(memoryAfter - memory);
}


// dotTrace performance profiling

