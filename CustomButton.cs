using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Launcher
{
    public class CustomButton : Control
    {
        #region [ Переменные ]
        private readonly StringFormat SF = new StringFormat();
        private Color backColor = Color.Green;
        private Color foreColor = Color.White;
        private Color clickColor = Color.Red;
        private Color activeColor = Color.Green;
        private Font font = new Font("Microsoft Sans Serif", 8);
        private string text = "Кнопка";
        bool mouseClick = false;
        bool mouseEnter = false;
        public enum TextAlignStyle
        {
            //
            // Сводка:
            //     Задает выравнивание текст по центру (по горизонтали).
            Center = StringAlignment.Center,
            //
            // Сводка:
            //     Задает выравнивание текст слева (по горизонтали).
            Left = StringAlignment.Near,
            //
            // Сводка:
            //    Задает выравнивание текст спрап(по горизонтали).
            Right = StringAlignment.Far,
        }

        #endregion

        #region [ Свойства ]
        /// <summary>
        /// Фон элемента
        /// </summary>
        public new Color BackColor
        {
            get { return backColor; }
            set { backColor = value; }
        }

        public Color ClickColor
        {
            get { return clickColor; }
            set { clickColor = value; }
        }
        public Color ActiveColor
        {
            get { return activeColor; }
            set { activeColor = value; }
        }

        public new  Font Font
        {
            get { return font; }
            set { font = value; }
        }
        /// <summary>
        /// Цвет текста
        /// </summary>
        public new Color ForeColor
        {
            get { return foreColor; }
            set { foreColor = value; }
        }
        /// <summary>
        /// Текст
        /// </summary>
        public new string Text
        {
            get { return text; }
            set { text = value; }
        }
        /// <summary>
        /// Выравнивание текста по горизонтали
        /// </summary>
        public StringAlignment TextAlign
        {
            set
            {
                SF.Alignment = value;
            }
        }

        #endregion

        #region [ Методы ]

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            Rectangle rectangle = new Rectangle(0, 0, Width, Height);
            Rectangle rectangleString = new Rectangle(10, 0, Width - 10, Height);
            Rectangle rectangleMouseEnter = new Rectangle(0, 0, Width - 20, Height);


            if (SF.Alignment == StringAlignment.Center)
            {
                graphics.DrawRectangle(new Pen(backColor, 2), rectangle);
                graphics.FillRectangle(new SolidBrush(backColor), rectangle);
                graphics.DrawString(text, font, new SolidBrush(foreColor), rectangle, SF);
            }
            else
            {
                graphics.DrawRectangle(new Pen(backColor, 2), rectangle);
                graphics.FillRectangle(new SolidBrush(backColor), rectangle);
                graphics.DrawString(text, font, new SolidBrush(foreColor), rectangleString, SF);
            }


            if (mouseClick)
            {
                if (SF.Alignment == StringAlignment.Center)
                {
                    graphics.FillRectangle(new SolidBrush(clickColor), rectangle);
                    graphics.DrawString(text, font, new SolidBrush(foreColor), rectangle, SF);
                }
                else
                {
                    graphics.FillRectangle(new SolidBrush(clickColor), rectangleMouseEnter);
                    graphics.DrawString(text, font, new SolidBrush(foreColor), rectangleString, SF);
                }
            }
            else
            {
                if (SF.Alignment == StringAlignment.Center)
                {
                    graphics.FillRectangle(new SolidBrush(backColor), rectangle);
                    graphics.DrawString(text, font, new SolidBrush(foreColor), rectangle, SF);
                }
                else
                {
                    graphics.FillRectangle(new SolidBrush(backColor), rectangle);
                    graphics.DrawString(text, font, new SolidBrush(foreColor), rectangleString, SF);
                }
            }

            if (mouseEnter)
            {
                if (SF.Alignment == StringAlignment.Center)
                {
                    graphics.FillRectangle(new SolidBrush(activeColor), rectangle);
                    graphics.DrawString(text, font, new SolidBrush(Color.FromArgb(255 - activeColor.R, 255 - activeColor.G, 255 - activeColor.B)), rectangle, SF);
                }
                else
                {
                    graphics.FillRectangle(new SolidBrush(activeColor), rectangleMouseEnter);
                    graphics.DrawString(text, font, new SolidBrush(Color.FromArgb(255 - activeColor.R, 255 - activeColor.G, 255 - activeColor.B)), rectangleString, SF);
                }
            }
            else
            {
                if (SF.Alignment == StringAlignment.Center)
                {
                    graphics.FillRectangle(new SolidBrush(backColor), rectangle);
                    graphics.DrawString(text, font, new SolidBrush(foreColor), rectangle, SF);
                }
                else
                {
                    graphics.FillRectangle(new SolidBrush(backColor), rectangle);
                    graphics.DrawString(text, font, new SolidBrush(foreColor), rectangleString, SF);
                }
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            mouseEnter = true;
            Invalidate();

        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouseEnter = false;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            mouseClick = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            mouseClick = true;
            Invalidate();
        }

        #endregion

        #region [ Конструкторы ]
        public CustomButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(100, 30);
            ForeColor = foreColor;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }
        #endregion}
    }
}
