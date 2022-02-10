using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainScreen.Image = new Bitmap(MainScreen.Width, MainScreen.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sets colors for all the little lines on buttons
            treeButtonAccent.BackColor = TreeFractalButton.FlatAppearance.MouseOverBackColor;
            carpetButtonAccent.BackColor = CarpetFractalButton.FlatAppearance.MouseOverBackColor;
            triangleButtonAccent.BackColor = TriangleFractalButton.FlatAppearance.MouseOverBackColor;
            kochButtonAccent.BackColor = KochFractalButton.FlatAppearance.MouseOverBackColor;
            cantorButtonAccent.BackColor = CantorFractalButton.FlatAppearance.MouseOverBackColor;


        }
        /// <summary>
        /// Resets all buttons.
        /// </summary>
        private void ResetAllButtons()
        {
            TreeFractalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            CarpetFractalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            TriangleFractalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            KochFractalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            CantorFractalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
        }
        /// <summary>
        /// Resets all sliders.
        /// </summary>
        private void ResetAllSliders()
        {
            IterationSlider.Visible = false;
            TreeLengthSlider.Visible = false;
            TreeFristAngleSlider.Visible = false;
            TreeSecondAngleSlider.Visible = false;
            CantorDistanceSlider.Visible = false;
        }


        // So, this long array of private voids is all about the correct work of buttons (and their design). Go straight to line 165 if you are not into this crap.
        private void CantorFractalButton_MouseUp(object sender, MouseEventArgs e)
        {
            cantorButtonAccent.BackColor = CantorFractalButton.FlatAppearance.MouseOverBackColor;
        }

        private void CantorFractalButton_MouseDown(object sender, MouseEventArgs e)
        {
            cantorButtonAccent.BackColor = CantorFractalButton.FlatAppearance.MouseDownBackColor;
        }
        private void CantorFractalButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetAllButtons();
            ResetAllSliders();
            IterationSlider.Visible = true;
            CantorDistanceSlider.Visible = true;
            CantorFractalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(237)))));
            Graphics.FromImage(MainScreen.Image).Clear(System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38))))));
            DrawCantor(IterationSlider.Value, MainScreen.Width / 6, 360, MainScreen.Width / 6 * 5, 360, (CantorDistanceSlider.Value - 5) * -10);
            MainScreen.Refresh();
        }

        private void KochFractalButton_MouseUp(object sender, MouseEventArgs e)
        {
            kochButtonAccent.BackColor = KochFractalButton.FlatAppearance.MouseOverBackColor;
        }

        private void KochFractalButton_MouseDown(object sender, MouseEventArgs e)
        {
            kochButtonAccent.BackColor = KochFractalButton.FlatAppearance.MouseDownBackColor;
        }
        private void KochFractalButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetAllButtons();
            ResetAllSliders();
            IterationSlider.Visible = true;
            KochFractalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(237)))), ((int)(((byte)(181)))));
            Graphics.FromImage(MainScreen.Image).Clear(System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38))))));
            DrawKoch(IterationSlider.Value > 5 ? 5 : IterationSlider.Value, MainScreen.Width / 6, 430, MainScreen.Width / 6 * 5, 430);
            MainScreen.Refresh();
        }

        private void TriangleFractalButton_MouseUp(object sender, MouseEventArgs e)
        {
            triangleButtonAccent.BackColor = TriangleFractalButton.FlatAppearance.MouseOverBackColor;
        }

        private void TriangleFractalButton_MouseDown(object sender, MouseEventArgs e)
        {
            triangleButtonAccent.BackColor = TriangleFractalButton.FlatAppearance.MouseDownBackColor;
        }

        private void TriangleFractalButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetAllButtons();
            ResetAllSliders();
            IterationSlider.Visible = true;
            TriangleFractalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(240)))), ((int)(((byte)(118)))));
            Graphics.FromImage(MainScreen.Image).Clear(System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38))))));
            DrawTriangle(IterationSlider.Value, MainScreen.Width / 3, MainScreen.Height / 3 * 2, MainScreen.Width / 3 * 2, MainScreen.Height / 3 * 2, MainScreen.Width / 2, (int)(MainScreen.Height / 3 * 2 - Math.Sqrt(3) / 2 * MainScreen.Width / 3));
            MainScreen.Refresh();

        }

        private void CarpetFractalButton_MouseUp(object sender, MouseEventArgs e)
        {
            carpetButtonAccent.BackColor = CarpetFractalButton.FlatAppearance.MouseOverBackColor;
        }
        private void CarpetFractalButton_MouseDown(object sender, MouseEventArgs e)
        {
            carpetButtonAccent.BackColor = CarpetFractalButton.FlatAppearance.MouseDownBackColor;
        }

        private void CarpetFractalButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetAllButtons();
            ResetAllSliders();
            IterationSlider.Visible = true;
            CarpetFractalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(78)))), ((int)(((byte)(237)))));
            Graphics.FromImage(MainScreen.Image).Clear(System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38))))));
            DrawCarpet(IterationSlider.Value > 5 ? 5 : IterationSlider.Value, 320, 200, 300, 300);
            MainScreen.Refresh();

        }

        private void TreeFractalButton_MouseUp(object sender, MouseEventArgs e)
        {
            treeButtonAccent.BackColor = TreeFractalButton.FlatAppearance.MouseOverBackColor;
        }

        private void TreeFractalButton_MouseDown(object sender, MouseEventArgs e)
        {
            treeButtonAccent.BackColor = TreeFractalButton.FlatAppearance.MouseDownBackColor;
        }

        private void TreeFractalButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetAllButtons();
            ResetAllSliders();
            IterationSlider.Visible = true;
            TreeFristAngleSlider.Visible = true;
            TreeSecondAngleSlider.Visible = true;
            TreeLengthSlider.Visible = true;
            Graphics.FromImage(MainScreen.Image).Clear(System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38))))));
            TreeFractalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(146)))));
            DrawTree(IterationSlider.Value, MainScreen.Width / 2, 550, MainScreen.Width / 2, 350, 1.6 + TreeLengthSlider.Value / 20.0, -Math.PI / 2 + TreeFristAngleSlider.Value * Math.PI / 20, Math.PI / 2 - TreeSecondAngleSlider.Value * Math.PI / 20);
            MainScreen.Refresh();
        }

        // Interesting stuff starts here.

        /// <summary>
        /// Rotates X-coordinate of a right point around the left point. Spits X-coordinate.
        /// </summary>
        /// <param name="LeftX"></param>
        /// <param name="LeftY"></param>
        /// <param name="RightX"></param>
        /// <param name="RightY"></param>
        /// <param name="Angle"></param>
        /// <returns></returns>
        public int RotateX(int LeftX, int LeftY, int RightX, int RightY, double Angle)
        {
            return (int)(LeftX + Math.Cos(Angle) * (RightX - LeftX) - Math.Sin(Angle) * (RightY - LeftY));
        }
        /// <summary>
        /// Rotates Y-coordinate of a right point around the left point. Spits Y-coordinate.
        /// </summary>
        /// <param name="LeftX"></param>
        /// <param name="LeftY"></param>
        /// <param name="RightX"></param>
        /// <param name="RightY"></param>
        /// <param name="Angle"></param>
        /// <returns></returns>
        public int RotateY(int LeftX, int LeftY, int RightX, int RightY, double Angle)
        {
            return (int)(LeftY + Math.Sin(Angle) * (RightX - LeftX) + Math.Cos(Angle) * (RightY - LeftY));
        }
        /// <summary>
        /// Draws Cantor set.
        /// </summary>
        /// <param name="iteration"></param>
        /// <param name="LeftX"></param>
        /// <param name="LeftY"></param>
        /// <param name="RightX"></param>
        /// <param name="RightY"></param>
        /// <param name="Distance"></param>
        public void DrawCantor(int iteration, int LeftX, int LeftY, int RightX, int RightY, int Distance)
        {
            using (var EditableGraphics = Graphics.FromImage(MainScreen.Image))
            {
                EditableGraphics.DrawLine(
                    new Pen(CantorFractalButton.FlatAppearance.MouseOverBackColor, 4f),
                    new Point(LeftX, LeftY),
                    new Point(RightX, RightY));
                if (iteration != 0)
                {
                    DrawCantor(iteration - 1, LeftX, LeftY + Distance, LeftX + (RightX - LeftX) / 3, LeftY + Distance, Distance);
                    DrawCantor(iteration - 1, LeftX + (RightX - LeftX) / 3 * 2, LeftY + Distance, RightX, RightY + Distance, Distance);
                }
            }
        }
        /// <summary>
        /// Draws Koch Curve.
        /// </summary>
        /// <param name="iteration"></param>
        /// <param name="LeftX"></param>
        /// <param name="LeftY"></param>
        /// <param name="RightX"></param>
        /// <param name="RightY"></param>
        public void DrawKoch(int iteration, int LeftX, int LeftY, int RightX, int RightY)
        {
            using (var EditableGraphics = Graphics.FromImage(MainScreen.Image))
            {

                if (iteration != 0)
                {
                    DrawKoch(iteration - 1, LeftX, LeftY, LeftX + (RightX - LeftX) / 3, LeftY + (RightY - LeftY) / 3);
                    DrawKoch(iteration - 1, LeftX + (RightX - LeftX) / 3, LeftY + (RightY - LeftY) / 3,
                        RotateX(LeftX + (RightX - LeftX) / 3, LeftY + (RightY - LeftY) / 3, LeftX + (RightX - LeftX) / 3 * 2, LeftY + (RightY - LeftY) / 3 * 2, -Math.PI / 3),
                        RotateY(LeftX + (RightX - LeftX) / 3, LeftY + (RightY - LeftY) / 3, LeftX + (RightX - LeftX) / 3 * 2, LeftY + (RightY - LeftY) / 3 * 2, -Math.PI / 3));
                    DrawKoch(iteration - 1,
                        RotateX(RightX - (RightX - LeftX) / 3 * 2, RightY - (RightY - LeftY) / 3 * 2, RightX - (RightX - LeftX) / 3, RightY - (RightY - LeftY) / 3, -Math.PI / 3),
                        RotateY(RightX - (RightX - LeftX) / 3 * 2, RightY - (RightY - LeftY) / 3 * 2, RightX - (RightX - LeftX) / 3, RightY - (RightY - LeftY) / 3, -Math.PI / 3),
                        RightX - (RightX - LeftX) / 3, RightY - (RightY - LeftY) / 3);
                    DrawKoch(iteration - 1, RightX - (RightX - LeftX) / 3, RightY - (RightY - LeftY) / 3, RightX, RightY);
                }
                else
                {
                    EditableGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    EditableGraphics.DrawLine(
                    new Pen(System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(237)))), ((int)(((byte)(181))))), 4f),
                    new Point(LeftX, LeftY),
                    new Point(RightX, RightY));
                }
            }
        }
        /// <summary>
        /// Draws Sierpinsky's triangle.
        /// </summary>
        /// <param name="iteration"></param>
        /// <param name="LeftX"></param>
        /// <param name="LeftY"></param>
        /// <param name="RightX"></param>
        /// <param name="RightY"></param>
        /// <param name="MiddleX"></param>
        /// <param name="MiddleY"></param>
        public void DrawTriangle(int iteration, int LeftX, int LeftY, int RightX, int RightY, int MiddleX, int MiddleY)
        {
            using (var EditableGraphics = Graphics.FromImage(MainScreen.Image))
            {
                if (iteration != 0)
                {
                    DrawTriangle(iteration - 1, LeftX, LeftY, LeftX + (MiddleX - LeftX) / 2, LeftY + (MiddleY - LeftY) / 2, LeftX + (RightX - LeftX) / 2, LeftY + (RightY - LeftY) / 2);
                    DrawTriangle(iteration - 1, LeftX + (RightX - LeftX) / 2, LeftY + (RightY - LeftY) / 2, RightX + (MiddleX - RightX) / 2, RightY + (MiddleY - RightY) / 2, RightX, RightY);
                    DrawTriangle(iteration - 1, LeftX + (MiddleX - LeftX) / 2, LeftY + (MiddleY - LeftY) / 2, RightX + (MiddleX - RightX) / 2, RightY + (MiddleY - RightY) / 2, MiddleX, MiddleY);
                }
                else
                {
                    EditableGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    EditableGraphics.DrawLine(
                    new Pen(System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(240)))), ((int)(((byte)(118))))), 4f),
                    new Point(LeftX, LeftY),
                    new Point(RightX, RightY));
                    EditableGraphics.DrawLine(
                    new Pen(System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(240)))), ((int)(((byte)(118))))), 4f),
                    new Point(LeftX, LeftY),
                    new Point(MiddleX, MiddleY));
                    EditableGraphics.DrawLine(
                    new Pen(System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(240)))), ((int)(((byte)(118))))), 4f),
                    new Point(MiddleX, MiddleY),
                    new Point(RightX, RightY));

                }
            }
        }
        /// <summary>
        /// Draws Sierpinsky's carpet.
        /// </summary>
        /// <param name="iteration"></param>
        /// <param name="LeftX"></param>
        /// <param name="LeftY"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        public void DrawCarpet(int iteration, int LeftX, int LeftY, int Width, int Height)
        {
            using (var EditableGraphics = Graphics.FromImage(MainScreen.Image))
            {
                if (iteration != 0)
                {
                    DrawCarpet(iteration - 1, LeftX, LeftY, Width / 3, Height / 3);
                    DrawCarpet(iteration - 1, LeftX + Width / 3, LeftY, Width / 3, Height / 3);
                    DrawCarpet(iteration - 1, LeftX + Width / 3 * 2, LeftY, Width / 3, Height / 3);
                    DrawCarpet(iteration - 1, LeftX, LeftY + Height / 3, Width / 3, Height / 3);
                    DrawCarpet(iteration - 1, LeftX + Width / 3 * 2, LeftY + Height / 3, Width / 3, Height / 3);
                    DrawCarpet(iteration - 1, LeftX, LeftY + Height / 3 * 2, Width / 3, Height / 3);
                    DrawCarpet(iteration - 1, LeftX + Width / 3, LeftY + Height / 3 * 2, Width / 3, Height / 3);
                    DrawCarpet(iteration - 1, LeftX + Width / 3 * 2, LeftY + Height / 3 * 2, Width / 3, Height / 3);
                }
                else
                {

                    EditableGraphics.FillRectangle(new SolidBrush(Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(78)))), ((int)(((byte)(237)))))), LeftX, LeftY, Width, Height);
                }
            }
        }
        /// <summary>
        /// Draws Pythagorean tree (spelled this one wrong 10000%)
        /// </summary>
        /// <param name="iteration"></param>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        /// <param name="endX"></param>
        /// <param name="endY"></param>
        /// <param name="LengthFactor"></param>
        /// <param name="FirstAngle"></param>
        /// <param name="SecondAngle"></param>
        public void DrawTree(int iteration, int startX, int startY, int endX, int endY, double LengthFactor, double FirstAngle, double SecondAngle)
        {
            using (var EditableGraphics = Graphics.FromImage(MainScreen.Image))
            {
                if (iteration != 0)
                {
                    DrawTree(iteration - 1, endX, endY,
                        RotateX(endX, endY, (int)(endX + (endX - startX) / LengthFactor), (int)(endY + (endY - startY) / LengthFactor), FirstAngle),
                        RotateY(endX, endY, (int)(endX + (endX - startX) / LengthFactor), (int)(endY + (endY - startY) / LengthFactor), FirstAngle), LengthFactor, FirstAngle, SecondAngle);
                    DrawTree(iteration - 1, endX, endY,
                        RotateX(endX, endY, (int)(endX + (endX - startX) / LengthFactor), (int)(endY + (endY - startY) / LengthFactor), SecondAngle),
                        RotateY(endX, endY, (int)(endX + (endX - startX) / LengthFactor), (int)(endY + (endY - startY) / LengthFactor), SecondAngle), LengthFactor, FirstAngle, SecondAngle);
                }
                EditableGraphics.DrawLine(
                new Pen(System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(240)))), ((int)(((byte)(118))))), 4f),
                new Point(startX, startY),
                new Point(endX, endY));
            }
        }

        // All the sliders are tweaked to provide you the best visual expirience. Enjoy!
        private void CantorDistanceSlider_ValueChanged(object sender, EventArgs e)
        {
            Graphics.FromImage(MainScreen.Image).Clear(System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38))))));
            DrawCantor(IterationSlider.Value, MainScreen.Width / 6, 360, MainScreen.Width / 6 * 5, 360, (CantorDistanceSlider.Value - 5) * -10);
            MainScreen.Refresh();
        }

        private void IterationSlider_Scroll(object sender, EventArgs e)
        {
            Graphics.FromImage(MainScreen.Image).Clear(System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38))))));
            if (CantorFractalButton.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(237))))))
            {
                DrawCantor(IterationSlider.Value, MainScreen.Width / 6, 360, MainScreen.Width / 6 * 5, 360, (CantorDistanceSlider.Value - 5) * -10);
                MainScreen.Refresh();
            }
            else if (KochFractalButton.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(237)))), ((int)(((byte)(181))))))
            {
                DrawKoch(IterationSlider.Value > 5 ? 5 : IterationSlider.Value, MainScreen.Width / 6, 430, MainScreen.Width / 6 * 5, 430);
                MainScreen.Refresh();
            }
            else if (TriangleFractalButton.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(240)))), ((int)(((byte)(118))))))
            {
                DrawTriangle(IterationSlider.Value, MainScreen.Width / 3, MainScreen.Height / 3 * 2, MainScreen.Width / 3 * 2, MainScreen.Height / 3 * 2, MainScreen.Width / 2, (int)(MainScreen.Height / 3 * 2 - Math.Sqrt(3) / 2 * MainScreen.Width / 3));
                MainScreen.Refresh();
            }
            else if (CarpetFractalButton.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(78)))), ((int)(((byte)(237))))))
            {
                DrawCarpet(IterationSlider.Value > 5 ? 5 : IterationSlider.Value, 320, 200, 300, 300);
                MainScreen.Refresh();
            }
            else if (TreeFractalButton.BackColor == System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(208)))), ((int)(((byte)(146))))))
            {
                DrawTree(IterationSlider.Value, MainScreen.Width / 2, 550, MainScreen.Width / 2, 350, 1.6 + TreeLengthSlider.Value / 20.0, -Math.PI / 2 + TreeFristAngleSlider.Value * Math.PI / 20, Math.PI / 2 - TreeSecondAngleSlider.Value * Math.PI / 20);
                MainScreen.Refresh();
            }
        }

        private void TreeLengthSlider_ValueChanged(object sender, EventArgs e)
        {
            Graphics.FromImage(MainScreen.Image).Clear(System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38))))));
            DrawTree(IterationSlider.Value, MainScreen.Width / 2, 550, MainScreen.Width / 2, 350, 1.6 + TreeLengthSlider.Value / 20.0, -Math.PI / 2 + TreeFristAngleSlider.Value * Math.PI / 20, Math.PI / 2 - TreeSecondAngleSlider.Value * Math.PI / 20);
            MainScreen.Refresh();
        }

        private void TreeFristAngleSlider_ValueChanged(object sender, EventArgs e)
        {
            Graphics.FromImage(MainScreen.Image).Clear(System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38))))));
            DrawTree(IterationSlider.Value, MainScreen.Width / 2, 550, MainScreen.Width / 2, 350, 1.6 + TreeLengthSlider.Value / 20.0, -Math.PI / 2 + TreeFristAngleSlider.Value * Math.PI / 20, Math.PI / 2 - TreeSecondAngleSlider.Value * Math.PI / 20);
            MainScreen.Refresh();
        }

        private void TreeSecondAngleSlider_ValueChanged(object sender, EventArgs e)
        {
            Graphics.FromImage(MainScreen.Image).Clear(System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(38))))));
            DrawTree(IterationSlider.Value, MainScreen.Width / 2, 550, MainScreen.Width / 2, 350, 1.6 + TreeLengthSlider.Value / 20.0, -Math.PI / 2 + TreeFristAngleSlider.Value * Math.PI / 20, Math.PI / 2 - TreeSecondAngleSlider.Value * Math.PI / 20);
            MainScreen.Refresh();
        }
    }

}
