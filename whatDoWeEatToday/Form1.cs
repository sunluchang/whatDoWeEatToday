using System;
using System.Windows.Forms;

namespace whatDoWeEatToday
{
    public partial class 今天吃什么 : Form
    {
        string date;
        string[] md = new string[16];
        string[] food = new string[] { "黄焖鸡米饭", "九旦拉面", "海南鸡饭", "包子", "麻辣香锅", "麻辣烫", "约泡", "炒饭", "炒面", "叫外卖吧", "辣婆婆", "石锅拌饭", "自己想办法" };
        string[] foodE = new string[] { "HuangMJ", "JiuDanLM", "HaiNanJF", "BaoZi", "MaLaZM", "MaLaTang", "YuePao", "ChaoFan", "ChaoMian", "BaiduWM", "LaPoPo", "ShiGuoBanFan", "YOURSELF" };
        public 今天吃什么()
        {
            InitializeComponent();
            date = System.DateTime.Now.ToLongDateString().ToString();
            label1.Text = date;
            int DateX = (300 - label1.Text.Length * 18) / 2;
            int DateY = 20;
            label1.Location = new System.Drawing.Point(DateX, DateY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(300, 235);
            Random sel = new Random();
            int i = sel.Next(food.Length);

            fooddd.Text = food[i];
            label2.Text = foodE[i];

            fooddd.Location = new System.Drawing.Point(10, 120);
            label2.Location = new System.Drawing.Point(10, 155);
            this.Text = "今天吃什么？" + "-" + food[i];
        }
    }
}
