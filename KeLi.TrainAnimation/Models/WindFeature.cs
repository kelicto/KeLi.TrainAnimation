namespace KeLi.TrainAnimation.Models
{
    public class WindFeature
    {
        public WindFeature(int width)
        {
            MinX = -width;
            XPosition = width;
        }

        public int Interval { get; set; } = 50;

        public int XStep { get; set; } = 30;

        public int MinX { get; set; }

        public int XPosition { get; set; }
    }
}