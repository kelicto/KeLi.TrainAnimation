using System;
using System.Drawing;
using System.Windows.Forms;

using KeLi.TrainAnimation.Models;
using KeLi.TrainAnimation.Properties;

namespace KeLi.TrainAnimation.Controls
{
    public partial class TrainControl : UserControl
    {
        private BackFeature _back;

        private Bitmap _bitmap;

        private CloudFeature _cloud;

        private Graphics _drawing;

        private Graphics _graphics;

        private int _interval;

        private TrainFeature _train;

        private WindFeature _wind;

        public TrainControl()
        {
            InitializeComponent();

            Initial();
        }

        private void Initial()
        {
            _graphics = CreateGraphics();
            _bitmap = new Bitmap(Width, Height);
            _drawing = Graphics.FromImage(_bitmap);

            _train = new TrainFeature();
            _wind = new WindFeature(Width);
            _cloud = new CloudFeature(Width);
            _back = new BackFeature(Width);
        }

        private void DrawTrain()
        {
            if (_interval % _train.Interval == 0)
            {
                _train.YPosition += _train.YStep;

                if (_train.YPosition >= _train.MaxY || _train.YPosition <= 0)
                    _train.YStep *= -1;
            }

            DrawElement(Resources.Train_Body, 0, 0);
            DrawElement(Resources.Train_Wheel, 0, _train.YPosition);
        }

        private void DrawCloud()
        {
            if (_interval % _cloud.Interval == 0)
            {
                // To left.
                _cloud.XPosition -= _cloud.XStep;

                if (_cloud.XPosition <= _cloud.MinX)
                    _cloud.XPosition = Width;
            }

            DrawElement(Resources.Cloud, _cloud.XPosition, 0);
        }

        private void DrawWind()
        {
            if (_interval % _wind.Interval == 0)
            {
                // To left.
                _wind.XPosition -= _wind.XStep;

                if (_wind.XPosition <= _wind.MinX)
                    _wind.XPosition = Width;
            }

            DrawElement(Resources.Wind, _wind.XPosition, 0);
            DrawElement(Resources.Wind, _wind.XPosition > 0 ? _wind.XPosition - Width : _wind.XPosition + Width, 0);
        }

        private void DrawBack()
        {
            if (_interval % _back.Interval == 0)
            {
                // To left.
                _back.XPosition -= _back.XStep;

                if (_back.XPosition <= _back.MinX)
                    _back.XPosition = Width;
            }

            DrawElement(Resources.Back, _back.XPosition, 0);
            DrawElement(Resources.Back, _back.XPosition > 0 ? _back.XPosition - Width : _back.XPosition + Width, 0);
        }

        private void DrawElement(Bitmap elementBitmap, int x, int y)
        {
            _drawing.DrawImage(elementBitmap, x, y, Width, Height);
        }

        private void TmrTrain_Tick(object sender, EventArgs e)
        {
            _interval += tmrTrain.Interval;
            _drawing.FillRectangle(Brushes.White, 0, 0, Width, Height);

            DrawTrain();
            DrawCloud();
            DrawWind();
            DrawBack();

            _graphics.DrawImage(_bitmap, 0, 0, Width, Height);
        }
    }
}