using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            rect1 = new Rectangle(new Point(50, 50), 100, 80);
            rect2 = new Rectangle(new Point(150, 100), 120, 60);

            UpdateTextBoxes();

            textBoxRect1X.TextChanged += textBoxRect1X_TextChanged;
            textBoxRect1Y.TextChanged += textBoxRect1Y_TextChanged;
            textBoxRect1Width.TextChanged += textBoxRect1Width_TextChanged;
            textBoxRect1Height.TextChanged += textBoxRect1Height_TextChanged;

            textBoxRect2X.TextChanged += textBoxRect2X_TextChanged;
            textBoxRect2Y.TextChanged += textBoxRect2Y_TextChanged;
            textBoxRect2Width.TextChanged += textBoxRect2Width_TextChanged;
            textBoxRect2Height.TextChanged += textBoxRect2Height_TextChanged;
        }
        private Rectangle rect1;
        private Rectangle rect2;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawRectangle(Pens.Red, rect1.TopLeft.X, rect1.TopLeft.Y, rect1.Width, rect1.Height);
            g.DrawRectangle(Pens.Blue, rect2.TopLeft.X, rect2.TopLeft.Y, rect2.Width, rect2.Height);

            // Малюємо найменший прямокутник, що містить обидва прямокутники (bounding rectangle)
            Rectangle boundingRect = rect1.GetBoundingRectangle(rect2);
            if (boundingRect != null)
            {
                g.DrawRectangle(Pens.Green, boundingRect.TopLeft.X, boundingRect.TopLeft.Y, boundingRect.Width, boundingRect.Height);
            }

            // Малюємо прямокутник, що є спільною частиною двох прямокутників (intersection)
            Rectangle intersectionRect = rect1.GetIntersection(rect2);
            if (intersectionRect != null)
            {
                g.DrawRectangle(Pens.Purple, intersectionRect.TopLeft.X, intersectionRect.TopLeft.Y, intersectionRect.Width, intersectionRect.Height);
            }
        }

        private void UpdateRectangles()
        {
            // Оновлюємо значення прямокутника rect1
            rect1.TopLeft = new Point(int.Parse(textBoxRect1X.Text), int.Parse(textBoxRect1Y.Text));
            rect1.Width = int.Parse(textBoxRect1Width.Text);
            rect1.Height = int.Parse(textBoxRect1Height.Text);

            // Оновлюємо значення прямокутника rect2
            rect2.TopLeft = new Point(int.Parse(textBoxRect2X.Text), int.Parse(textBoxRect2Y.Text));
            rect2.Width = int.Parse(textBoxRect2Width.Text);
            rect2.Height = int.Parse(textBoxRect2Height.Text);

            pictureBox1.Invalidate();
        }

        private void UpdateTextBoxes()
        {
            // Оновлюємо значення текстових полів для rect1
            textBoxRect1X.Text = rect1.TopLeft.X.ToString();
            textBoxRect1Y.Text = rect1.TopLeft.Y.ToString();
            textBoxRect1Width.Text = rect1.Width.ToString();
            textBoxRect1Height.Text = rect1.Height.ToString();

            // Оновлюємо значення текстових полів для rect2
            textBoxRect2X.Text = rect2.TopLeft.X.ToString();
            textBoxRect2Y.Text = rect2.TopLeft.Y.ToString();
            textBoxRect2Width.Text = rect2.Width.ToString();
            textBoxRect2Height.Text = rect2.Height.ToString();
        }

      

        private void textBoxRect1X_TextChanged(object sender, EventArgs e)
        {
            UpdateRectangles();
        }

        private void textBoxRect1Y_TextChanged(object sender, EventArgs e)
        {
            UpdateRectangles();
        }

        private void textBoxRect1Width_TextChanged(object sender, EventArgs e)
        {
            UpdateRectangles();
        }

        private void textBoxRect1Height_TextChanged(object sender, EventArgs e)
        {
            UpdateRectangles();
        }

        private void textBoxRect2X_TextChanged(object sender, EventArgs e)
        {
            UpdateRectangles();
        }

        private void textBoxRect2Y_TextChanged(object sender, EventArgs e)
        {
            UpdateRectangles();
        }

        private void textBoxRect2Width_TextChanged(object sender, EventArgs e)
        {
            UpdateRectangles();
        }

        private void textBoxRect2Height_TextChanged(object sender, EventArgs e)
        {
            UpdateRectangles();
        }
    }
}
