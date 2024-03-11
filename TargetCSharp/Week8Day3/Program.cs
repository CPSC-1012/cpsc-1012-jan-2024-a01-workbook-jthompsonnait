    int[] array = new int[] { 1, 2, 3 };
    int num = 27;
    DemonstrateRefVsValue(array, ref num);

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
        // 99, 2, 3
    }
    Console.WriteLine(num); // 27




static void DemonstrateRefVsValue(int[] arrayParam, ref int intValue)
{
    arrayParam[0] = 99; // Changes reflect outside the method // 99, 2, 3
    intValue += 10; // Changes do not reflect outside the method // 37 inside the method, 27 outside
}
