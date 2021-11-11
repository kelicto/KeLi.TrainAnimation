namespace KeLi.TrainAnimation.Models
{
    public class BackFeature
    {
        public BackFeature(int width)
        {
            MinX = -width;
        }

        public int Interval { get; set; } = 100;

        public int XStep { get; set; } = 1;

        public int MinX { get; set; }

        public int XPosition { get; set; }
    }
}