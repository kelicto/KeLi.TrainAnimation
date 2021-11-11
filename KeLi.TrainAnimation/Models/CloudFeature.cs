namespace KeLi.TrainAnimation.Models
{
    public class CloudFeature
    {
        public CloudFeature(int width)
        {
            MinX = -width;
        }

        public int Interval { get; set; } = 50;

        public int XStep { get; set; } = 1;

        public int MinX { get; set; }

        public int XPosition { get; set; }
    }
}