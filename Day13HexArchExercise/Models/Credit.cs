namespace Day13HexArchExercise.Models;

public sealed record Credit(int Id, int CustomerId, decimal Amount)
{
    public static readonly Credit Empty = new(0, 0, 0);
}