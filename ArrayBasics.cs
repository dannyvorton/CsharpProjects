using System;

class ArrayBasics
{
    public static void Run()
    {
        string[] fraudulentOrderIDs = ["A123", "B456", "C789"];
        Console.WriteLine($"First item: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second item: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third item: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reassign First item: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"There are {fraudulentOrderIDs.Length} items in the array");
    }
}
