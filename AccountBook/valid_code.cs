using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBook
{
    class valid_code
    {
        #region Private Fields
        //验证码的长度
        private const int iVerifyCodeLength = 4;
        //验证码
        private String strVerifyCode = "";
        //匹配字符的临时变量
        string strTemp = "";
        #endregion

        #region Public Property
        public string StrTemp
        {
            get
            {
                return strTemp;
            }
        }
        #endregion

        #region Constructors
        public valid_code()
        {
        }
        #endregion

        #region Private Methods

        //生成验证码字符串
        private string CreateRandomCode(int iLength)
        {
            int rand;
            char code;
            string randomCode = String.Empty;
            //生成一定长度的验证码
            System.Random random = new Random();
            for (int i = 0; i < iLength; i++)
            {
                rand = random.Next();
                if (rand % 3 == 0)
                {
                    code = (char)('A' + (char)(rand % 26));
                }
                else if (rand % 3 == 1)
                {
                    code = (char)('a' + (char)(rand % 26));
                }
                else
                {
                    code = (char)('0' + (char)(rand % 10));
                }
                randomCode += code.ToString();
            }
            return randomCode;
        }
        #endregion

        #region Public Methods
        //更新验证码 
        public string UpdateVerifyCode()
        {
            strVerifyCode = CreateRandomCode(iVerifyCodeLength);
            if (strVerifyCode == "")
            {
                return "";
            }
            strTemp = strVerifyCode;
            return strTemp;
        }
        //创建验证码图片
        public Bitmap CreateImage(string strVerifyCode)
        {
            try
            {
                int iRandAngle = 45;    //随机转动角度
                int iMapWidth = (int)(strVerifyCode.Length * 20);
                Bitmap map = new Bitmap(iMapWidth, 25);    //创建图片背景
                Graphics graph = Graphics.FromImage(map);
                graph.Clear(Color.AliceBlue);//清除画面，填充背景
                graph.DrawRectangle(new Pen(Color.Black, 0), 0, 0, map.Width - 1, map.Height - 1);//画一个边框
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//模式
                Random rand = new Random();
                //背景噪点生成
                Pen blackPen = new Pen(Color.LightGray, 0);
                for (int i = 0; i < 50; i++)
                {
                    int x = rand.Next(0, map.Width);
                    int y = rand.Next(0, map.Height);
                    graph.DrawRectangle(blackPen, x, y, 1, 1);
                }
                char[] chars = strVerifyCode.ToCharArray();//拆散字符串成单字符数组
                //文字居中
                StringFormat format = new StringFormat(StringFormatFlags.NoClip);
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                //定义颜色
                Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };
                //定义字体
                string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };
                for (int i = 0; i < chars.Length; i++)
                {
                    int cindex = rand.Next(8);
                    int findex = rand.Next(5);
                    Font f = new System.Drawing.Font(font[findex], 14, System.Drawing.FontStyle.Bold); //字体样式
                    Brush brush = new System.Drawing.SolidBrush(c[cindex]); //笔刷颜色
                    Point dot = new Point(16, 16);
                    float angle = rand.Next(-iRandAngle, iRandAngle); //转动的度数
                    graph.TranslateTransform(dot.X, dot.Y); //平移
                    graph.RotateTransform(angle); //旋转，防止机器识别
                    graph.DrawString(chars[i].ToString(), f, brush, 1, 1, format);
                    graph.RotateTransform(-angle);//转回去
                    graph.TranslateTransform(2, -dot.Y);//移动光标到指定位置
                }
                return map;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("创建图片错误。");
                return null;
            }
        }
        //验证输入验证码
        public bool CheckCode(string txt_code)
        {
            char[] in_code = txt_code.ToCharArray();
            char[] gen_code = strTemp.ToCharArray();
            int nCount = 0; //记录输入验证码与生成验证码对应相同的字符个数
            for (int i = 0; i < txt_code.Length; i++)
            {
                //不区分大小写
                if ((in_code[i] >= 'a' && in_code[i] <= 'z') || (in_code[i] >= 'A' && in_code[i] <= 'Z'))
                {
                    if (in_code[i] - 32 == gen_code[i] || in_code[i] + 32 == gen_code[i])
                    {
                        nCount++;
                    }
                    else if (in_code[i] == gen_code[i])
                    {
                        nCount++;
                    }
                }
                //字符相同
                else
                {
                    if (in_code[i] == gen_code[i])
                    {
                        nCount++;
                    }
                }
            }
            //验证成功
            if (nCount == strTemp.Length)
            {
                return true;
            }
            //验证失败
            else
            {
                return false;
            }
        }
        #endregion
    }
}
