using System.Numerics;

namespace MathLibrary.Models
{
    public class QuadraticEquationModel
    {
        public List<double>? RealRoots { get; set; }
        public double? Discriminator { get; set; }
        public int CountOfRoots { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
