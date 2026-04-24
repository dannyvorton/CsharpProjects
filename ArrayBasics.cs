using System;

class ArrayBasics
{
    public static void Run()
    {
/*
        string[] fraudulentOrderIDs = new string[3];
        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";
        //    fraudulentOrderIDs[3] = "D000";
*/
        string[] fraudulentOrderIDs = ["A123", "B456", "C789"];
        Console.WriteLine($"First item: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second item: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third item: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reassign First item: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"There are {fraudulentOrderIDs.Length} items in the array");
    }
}
