using System;
using System.Drawing;
using System.Windows.Forms;

using KeLi.TrainAnimation.App.Models;
using KeLi.TrainAnimation.App.Properties;

namespace KeLi.TrainAnimation.App.Controls
{
    public partial class TrainControl : UserControl
    {
        private Graphics graphics;

        private Bitmap bitmap;

        private Graphics drawing;

        private TrainFeature train;

        private WindFeature wind;

        private CloudFeature cloud;

        private BackFeature back;

        private int interval;

        public TrainControl()
        {
            InitializeComponent();

            Initial();
        }

        private void Initial()
        {
            graphics = CreateGraphics();
            bitmap = new Bitmap(Width, Height);
            drawing = Graphics.FromImage(bitmap);

            train = new TrainFeature();
            wind = new WindFeature(Width);
            cloud = new CloudFeature(Width);
            back = new BackFeature(Width);
        }

        private void DrawTrain()
        {
            if (interval % train.Interval == 0)
            {
                train.YPosition += train.YStep;

                if (train.YPosition >= train.MaxY || train.YPosition <= 0)
                    train.YStep *= -1;
            }

            DrawElement(Resources.Train_Body, 0, 0);
            DrawElement(Resources.Train_Wheel, 0, train.YPosition);
        }

        private void DrawCloud()
        {
            if (interval % cloud.Interval == 0)
            {
                // To left.
                cloud.XPosition -= cloud.XStep;

                if (cloud.XPosition <= cloud.MinX)
                    cloud.XPosition = Width;
            }

            DrawElement(Resources.Cloud, cloud.XPosition, 0);
        }

        private void DrawWind()
        {
            if (interval % wind.Interval == 0)
            {
                // To left.
                wind.XPosition -= wind.XStep;

                if (wind.XPosition <= wind.MinX)
                    wind.XPosition = Width;
            }

            DrawElement(Resources.Wind, wind.XPosition, 0);
            DrawElement(Resources.Wind, wind.XPosition > 0 ? wind.XPosition - Width : wind.XPosition + Width, 0);
        }

        private void DrawBack()
        {
            if (interval % back.Interval == 0)
            {
                // To left.
                back.XPosition -= back.XStep;

                if (back.XPosition <= back.MinX)
                    back.XPosition = Width;
            }

            DrawElement(Resources.Back, back.XPosition, 0);
            DrawElement(Resources.Back, back.XPosition > 0 ? back.XPosition - Width : back.XPosition + Width, 0);
        }

        private void DrawElement(Bitmap elementBitmap, int x, int y)
        {
            drawing.DrawImage(elementBitmap, x, y, Width, Height);
        }

        private void TimerTrain_Tick(object sender, EventArgs e)
        {
            interval += timerTrain.Interval;
            
            drawing.FillRectangle(Brushes.White, 0, 0, Width, Height);

            DrawTrain();
            DrawCloud();
            DrawWind();
            DrawBack();

            graphics.DrawImage(bitmap, 0, 0, Width, Height);
        }
    }
}
