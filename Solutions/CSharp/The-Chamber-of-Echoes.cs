public class ChamberOfEchoes
{
    // Document what this code is doing
    // This code is predicting the next number in the sequence by finding the difference 
    // between the first two numbers and adding that difference to the last number in the sequence.
    static int PredictNext(List<int> echoes)
    {
        int difference = echoes[1] - echoes[0];
        return echoes[echoes.Count - 1] + difference;
    }

    public static void Run()
    {
        var echoes = new List<int> { 3, 6, 9, 12 };
        Console.WriteLine(PredictNext(echoes));
    }
}