namespace Day13HexArchExercise.Models;

public sealed record PortabilityInfo(int CustomerId, ICollection<Credit> Credits);
