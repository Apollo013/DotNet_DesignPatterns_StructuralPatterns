using System;
using System.Windows.Forms;

namespace FlyweightPattern
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for (int i = 0; i < 5; i++)
            {
                IShape redShape = ShapeFactory.GetShape("Red");
                redShape.Draw(e.Graphics, GetRandomNumber(), GetRandomNumber(), GetRandomNumber(), GetRandomNumber());
            }

            for (int i = 0; i < 5; i++)
            {
                IShape blueShape = ShapeFactory.GetShape("Blue");
                blueShape.Draw(e.Graphics, GetRandomNumber(), GetRandomNumber(), GetRandomNumber(), GetRandomNumber());
            }

        }

        private int GetRandomNumber()
        {
            return (int)(random.Next(200));
        }
    }
}
