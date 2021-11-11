namespace KeLi.TrainAnimation.Models
{
    public class TrainFeature
    {
        public int Interval { get; set; } = 250;

        public int YStep { get; set; } = 1;

        public int MaxY { get; set; } = 3;

        public int YPosition { get; set; }
    }
}