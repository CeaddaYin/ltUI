using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LtUI
{
    /// <summary>
    /// 乐陶编辑框控件类
    /// </summary>
    [Description("乐陶编辑框")]
    public partial class LtTextBox : UserControl
    {
        #region 控件初始化代码
        /// <summary>
        /// 初始化方法
        /// </summary>
        /// <remarks></remarks>
        public LtTextBox()
        {
            InitializeComponent();
        }
        #endregion

        #region 编辑框尺寸调节
        /// <summary>
        /// 编辑框宽度设置
        /// </summary>
        [Description("指定编辑框的宽度"), Browsable(true), DisplayName("1.宽度"), Category("编辑框常用属性")]
        public int LtWidth
        {
            get
            {
                return this.Width;
            }
            set
            {
                this.Width = value;
            }
        }
        /// <summary>
        /// 编辑框高度设置
        /// </summary>
        [Description("指定编辑框的高度"), Browsable(true), DisplayName("2.高度"), Category("编辑框常用属性")]
        public int LtHeiget
        {
            get
            {
                return this.Height;
            }
            set
            {
                this.Height = value;
            }
        }
        #endregion

        #region 编辑框模式设置:单行文本或多行文本
        /// <summary>
        /// 设置编辑框是单行模式还是多行模式，默认为false单行模式
        /// </summary>
        [Description("设置编辑框是单行模式还是多行模式，默认为false单行模式"), Browsable(true), DisplayName("5.多行模式"), Category("编辑框常用属性")]
        public bool LtMulti_line
        {
            get { return textBox1.Multiline; }
            set
            {
                textBox1.Multiline = value;
                setTextBox();
            }
        }


        #endregion

        #region 编辑框背景颜色及字体颜色设置
        /// <summary>
        /// 编辑框控件的背景色设置
        /// </summary>
        [Description("编辑框背景色设置"), Browsable(true), DisplayName("3.背景颜色"), Category("编辑框常用属性")]
        public Color BC
        {
            get { return textBox1.BackColor; }
            set
            {
                if (value == Color.Transparent)
                {
                    textBox1.BackColor = Color.Black;
                    BackColor = Color.Black;
                }
                else
                {
                    textBox1.BackColor = value;
                    BackColor = value;
                }

            }
        }

        /// <summary>
        /// 编辑框控件的背景色设置
        /// </summary>
        [Description("编辑框字体色设置"), Browsable(true), DisplayName("4.字体颜色"), Category("编辑框常用属性")]
        public Color Fc
        {
            get { return textBox1.ForeColor; }
            set
            {
                textBox1.ForeColor = value;
                this.ForeColor = value;
            }
        }


        #endregion

        #region 触发事件

        /// <summary>
        /// 控件被加载时，执行设置控件内编辑框位置尺寸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LtTextBox_Load(object sender, EventArgs e)
        {
            setTextBox();
        }

        /// <summary>
        /// 设置控件内编辑框尺寸及位置的方法
        /// </summary>
        private void setTextBox()
        {
            if (LtMulti_line == true)
            {
                Point xy = new Point();
                xy.X = 0;
                xy.Y = 0;
                textBox1.Location = xy;
                textBox1.Width = this.Width;
                textBox1.Height = this.Height;
                //Console.WriteLine(xy);
            }
            else
            {
                Point xy = new Point();
                xy.X = 0;
                xy.Y = this.Height / 2 - textBox1.Height / 2;
                textBox1.Location = xy;
                textBox1.Width = this.Width;
                //Console.WriteLine(xy);
            }

        }

        /// <summary>
        /// 单击控件时定位焦点到控件内的编辑框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LtTextBox_Click(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        /// <summary>
        /// 当控件内编辑框字体被改变时，调整控件内编辑框位置尺寸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_FontChanged(object sender, EventArgs e)
        {
            setTextBox();
        }

        /// <summary>
        /// 当调整控件尺寸时，同步调整控件内编辑框的尺寸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LtTextBox_SizeChanged(object sender, EventArgs e)
        {
            setTextBox();
        }
        #endregion

        #region 重写旧属性，经常用到的


        #endregion

        #region 隐藏旧的，基本无用的属性
        [Browsable(false)]
        public new AutoScaleMode AutoScaleMode { get; set; }
        [Browsable(false)]
        public new AnchorStyles Anchor { get; set; }
        [Browsable(false)]
        public new bool AutoScroll { get; set; }
        [Browsable(false)]
        public new Size AutoScrollMargin { get; set; }
        [Browsable(false)]
        public new Size AutoScrollMinSize { get; set; }
        [Browsable(false)]
        public new bool AutoSize { get; set; }
        [Browsable(false)]
        public new AutoSizeMode AutoSizeMode { get; set; }
        [Browsable(false)]
        public new DockStyle Dock { get; set; }
        [Browsable(false)]
        public new Padding Padding { get; set; }
        [Browsable(false)]
        public new Size Size { get; set; }
        [Browsable(false)]
        public new bool CausesValidation { get; set; }
        [Browsable(false)]
        public new string AccessibleDescription { get; set; }
        [Browsable(false)]
        public new string AccessibleName { get; set; }
        [Browsable(false)]
        public new AccessibleRole AccessibleRole { get; set; }
        //[Browsable(false)]
        //public new ControlBindingsCollection DataBindings { get; set; }
        //[Browsable(false)]
        //public new object Tag { get; set; }
        [Browsable(false)]
        public new Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }
        [Browsable(false)]
        public new Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
            }
        }
        [Browsable(false)]
        public new Image BackgroundImage { get; set; }
        [Browsable(false)]
        public new ImageLayout BackgroundImageLayout { get; set; }
        [Browsable(false)]
        public new RightToLeft RightToLeft { get; set; }
        [Browsable(false)]
        public new bool UseWaitCursor { get; set; }
        public void Test()
        {
            
        }
        #endregion


    }
}
