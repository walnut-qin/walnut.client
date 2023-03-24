using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace walnut.client.ui.helper
{
    public partial class Switch : UserControl
    {
        public Switch()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        /// <summary>
        /// 是否被选中
        /// </summary>
        private Boolean m_checked = false;
        public Boolean Checked
        {
            get
            {
                return this.m_checked;
            }
            set
            {
                this.m_checked = value;
                Refresh();
            }
        }

        /// <summary>
        /// true的文本
        /// </summary>
        /// <value></value>
        public String TrueText { get; set; } = String.Empty;

        /// <summary>
        /// false的文本
        /// </summary>
        /// <value></value>
        public String FalseText { get; set; } = String.Empty;

        /// <summary>
        /// true颜色
        /// </summary>
        /// <returns></returns>
        public Color TrueColor { get; set; } = Color.FromArgb(34, 163, 169);

        /// <summary>
        /// false颜色
        /// </summary>
        /// <returns></returns>
        public Color FalseColor { get; set; } = Color.FromArgb(189, 189, 189);

        /// <summary>
        /// 开关样式
        /// </summary>
        /// <value></value>
        public SwitchTypeEnum SwitchType { get; set; } = SwitchTypeEnum.Ellipse;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (this.SwitchType == SwitchTypeEnum.Ellipse)
            {
                this.paintEllipse(e.Graphics);
            }
            else if (this.SwitchType == SwitchTypeEnum.Quadrilateral)
            {
                this.paintQuadrilateral(e.Graphics);
            }
            else
            {
                this.paintLine(e.Graphics);
            }
        }

        private void paintEllipse(Graphics g)
        {
            var fillColor = this.Checked ? this.TrueColor : this.FalseColor;
            GraphicsPath path = new GraphicsPath();
            path.AddLine(new Point(this.Height / 2, 1), new Point(this.Width - this.Height / 2, 1));
            path.AddArc(new Rectangle(this.Width - this.Height - 1, 1, this.Height - 2, this.Height - 2), -90, 180);
            path.AddLine(new Point(this.Width - this.Height / 2, this.Height - 1), new Point(this.Height / 2, this.Height - 1));
            path.AddArc(new Rectangle(1, 1, this.Height - 2, this.Height - 2), 90, 180);
            g.FillPath(new SolidBrush(fillColor), path);

            // 确定文本内容
            string strText = this.m_checked ? this.TrueText : this.FalseText;

            // 绘制图案
            if (this.Checked)
            {
                g.FillEllipse(Brushes.White, new Rectangle(this.Width - this.Height - 1 + 2, 1 + 2, this.Height - 2 - 4, this.Height - 2 - 4));
                if (string.IsNullOrEmpty(strText))
                {
                    g.DrawEllipse(new Pen(Color.White, 2), new Rectangle((this.Height - 2 - 4) / 2 - ((this.Height - 2 - 4) / 2) / 2, (this.Height - 2 - (this.Height - 2 - 4) / 2) / 2 + 1, (this.Height - 2 - 4) / 2, (this.Height - 2 - 4) / 2));
                }
                else
                {
                    System.Drawing.SizeF sizeF = g.MeasureString(strText.Replace(" ", "A"), Font);
                    int intTextY = (this.Height - (int)sizeF.Height) / 2 + 2;
                    g.DrawString(strText, Font, new SolidBrush(Color.White), new Point((this.Height - 2 - 4) / 2, intTextY));
                }
            }
            else
            {
                g.FillEllipse(Brushes.White, new Rectangle(1 + 2, 1 + 2, this.Height - 2 - 4, this.Height - 2 - 4));
                if (string.IsNullOrEmpty(strText))
                {
                    g.DrawEllipse(new Pen(Color.White, 2), new Rectangle(this.Width - 2 - (this.Height - 2 - 4) / 2 - ((this.Height - 2 - 4) / 2) / 2, (this.Height - 2 - (this.Height - 2 - 4) / 2) / 2 + 1, (this.Height - 2 - 4) / 2, (this.Height - 2 - 4) / 2));
                }
                else
                {
                    System.Drawing.SizeF sizeF = g.MeasureString(strText.Replace(" ", "A"), Font);
                    int intTextY = (this.Height - (int)sizeF.Height) / 2 + 2;
                    g.DrawString(strText, Font, new SolidBrush(Color.White), new Point(this.Width - 2 - (this.Height - 2 - 4) / 2 - ((this.Height - 2 - 4) / 2) / 2 - (int)sizeF.Width / 2, intTextY));
                }
            }
        }

        private void paintQuadrilateral(Graphics g)
        {
            var fillColor = this.Checked ? this.TrueColor : this.FalseColor;
            GraphicsPath path = new GraphicsPath();
            int intRadius = 5;
            path.AddArc(0, 0, intRadius, intRadius, 180f, 90f);
            path.AddArc(this.Width - intRadius - 1, 0, intRadius, intRadius, 270f, 90f);
            path.AddArc(this.Width - intRadius - 1, this.Height - intRadius - 1, intRadius, intRadius, 0f, 90f);
            path.AddArc(0, this.Height - intRadius - 1, intRadius, intRadius, 90f, 90f);
            g.FillPath(new SolidBrush(fillColor), path);

            // 确定文本内容
            string strText = this.m_checked ? this.TrueText : this.FalseText;

            // 绘制图案
            GraphicsPath path2 = new GraphicsPath();
            if (this.Checked)
            {
                path2.AddArc(this.Width - this.Height - 1 + 2, 1 + 2, intRadius, intRadius, 180f, 90f);
                path2.AddArc(this.Width - 1 - 2 - intRadius, 1 + 2, intRadius, intRadius, 270f, 90f);
                path2.AddArc(this.Width - 1 - 2 - intRadius, this.Height - 2 - intRadius - 1, intRadius, intRadius, 0f, 90f);
                path2.AddArc(this.Width - this.Height - 1 + 2, this.Height - 2 - intRadius - 1, intRadius, intRadius, 90f, 90f);
                g.FillPath(Brushes.White, path2);

                if (string.IsNullOrEmpty(strText))
                {
                    g.DrawEllipse(new Pen(Color.White, 2), new Rectangle((this.Height - 2 - 4) / 2 - ((this.Height - 2 - 4) / 2) / 2, (this.Height - 2 - (this.Height - 2 - 4) / 2) / 2 + 1, (this.Height - 2 - 4) / 2, (this.Height - 2 - 4) / 2));
                }
                else
                {
                    System.Drawing.SizeF sizeF = g.MeasureString(strText.Replace(" ", "A"), Font);
                    int intTextY = (this.Height - (int)sizeF.Height) / 2 + 2;
                    g.DrawString(strText, Font, new SolidBrush(Color.White), new Point((this.Height - 2 - 4) / 2, intTextY));
                }
            }
            else
            {
                path2.AddArc(1 + 2, 1 + 2, intRadius, intRadius, 180f, 90f);
                path2.AddArc(this.Height - 2 - intRadius, 1 + 2, intRadius, intRadius, 270f, 90f);
                path2.AddArc(this.Height - 2 - intRadius, this.Height - 2 - intRadius - 1, intRadius, intRadius, 0f, 90f);
                path2.AddArc(1 + 2, this.Height - 2 - intRadius - 1, intRadius, intRadius, 90f, 90f);
                g.FillPath(Brushes.White, path2);

                //g.FillEllipse(Brushes.White, new Rectangle(1 + 2, 1 + 2, this.Height - 2 - 4, this.Height - 2 - 4));
                if (string.IsNullOrEmpty(strText))
                {
                    g.DrawEllipse(new Pen(Color.White, 2), new Rectangle(this.Width - 2 - (this.Height - 2 - 4) / 2 - ((this.Height - 2 - 4) / 2) / 2, (this.Height - 2 - (this.Height - 2 - 4) / 2) / 2 + 1, (this.Height - 2 - 4) / 2, (this.Height - 2 - 4) / 2));
                }
                else
                {
                    System.Drawing.SizeF sizeF = g.MeasureString(strText.Replace(" ", "A"), Font);
                    int intTextY = (this.Height - (int)sizeF.Height) / 2 + 2;
                    g.DrawString(strText, Font, new SolidBrush(Color.White), new Point(this.Width - 2 - (this.Height - 2 - 4) / 2 - ((this.Height - 2 - 4) / 2) / 2 - (int)sizeF.Width / 2, intTextY));
                }
            }
        }

        private void paintLine(Graphics g)
        {
            var fillColor = this.Checked ? this.TrueColor : this.FalseColor;
            int intLineHeight = (this.Height - 2 - 4) / 2;

            GraphicsPath path = new GraphicsPath();
            path.AddLine(new Point(this.Height / 2, (this.Height - intLineHeight) / 2), new Point(this.Width - this.Height / 2, (this.Height - intLineHeight) / 2));
            path.AddArc(new Rectangle(this.Width - this.Height / 2 - intLineHeight - 1, (this.Height - intLineHeight) / 2, intLineHeight, intLineHeight), -90, 180);
            path.AddLine(new Point(this.Width - this.Height / 2, (this.Height - intLineHeight) / 2 + intLineHeight), new Point(this.Width - this.Height / 2, (this.Height - intLineHeight) / 2 + intLineHeight));
            path.AddArc(new Rectangle(this.Height / 2, (this.Height - intLineHeight) / 2, intLineHeight, intLineHeight), 90, 180);
            g.FillPath(new SolidBrush(fillColor), path);

            if (this.Checked)
            {
                g.FillEllipse(new SolidBrush(fillColor), new Rectangle(this.Width - this.Height - 1 + 2, 1 + 2, this.Height - 2 - 4, this.Height - 2 - 4));
                g.FillEllipse(Brushes.White, new Rectangle(this.Width - 2 - (this.Height - 2 - 4) / 2 - ((this.Height - 2 - 4) / 2) / 2 - 4, (this.Height - 2 - (this.Height - 2 - 4) / 2) / 2 + 1, (this.Height - 2 - 4) / 2, (this.Height - 2 - 4) / 2));
            }
            else
            {
                g.FillEllipse(new SolidBrush(fillColor), new Rectangle(1 + 2, 1 + 2, this.Height - 2 - 4, this.Height - 2 - 4));
                g.FillEllipse(Brushes.White, new Rectangle((this.Height - 2 - 4) / 2 - ((this.Height - 2 - 4) / 2) / 2 + 4, (this.Height - 2 - (this.Height - 2 - 4) / 2) / 2 + 1, (this.Height - 2 - 4) / 2, (this.Height - 2 - 4) / 2));
            }
        }

        /// <summary>
        /// Enum SwitchType
        /// </summary>
        public enum SwitchTypeEnum
        {
            /// <summary>
            /// 椭圆
            /// </summary>
            Ellipse,
            /// <summary>
            /// 四边形
            /// </summary>
            Quadrilateral,
            /// <summary>
            /// 横线
            /// </summary>
            Line
        }

        private void Switch_Click(object sender, EventArgs e)
        {
            this.Checked = !this.Checked;
        }
    }
}
