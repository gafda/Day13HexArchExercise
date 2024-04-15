namespace Day13HexArchExercise.Models;

public sealed record Customer(int Id, bool IsVip, ICollection<int> Credits)
{
    public static readonly Customer Empty = new(0, false, []);
}