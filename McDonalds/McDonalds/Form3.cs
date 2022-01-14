using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDonalds
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
        private void check()
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            switch (foodname_lbl.Text)
            {
                case "Coca-Cola®":
                    cal_lbl.Text = "110 Cal.";
                    break;
                case "Sprite®":
                    cal_lbl.Text = "90 Cal.";
                    break;
                case "McFlurry® with OREO® cookies":
                    cal_lbl.Text = "510 Cal.";
                    break;
                case "McFlurry® with M&M'S® Candies":
                    cal_lbl.Text = "640 Cal.";
                    break;
                case "Caramel Macchiato":
                    cal_lbl.Text = "260 Cal.";
                    break;
                case "World Famous Fries®":
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add1.10\t-mcdonalds-fries-kids.jpg");
                    cal_lbl.Text = "110 Cal.";
                    break;
                case "Iced Caramel Macchiato":
                    cal_lbl.Text = "210 Cal.";
                    break;
                case "Dr Pepper®":
                    cal_lbl.Text = "100 Cal.";
                    break;
                case "Cappuccino":
                    cal_lbl.Text = "120 Cal.";
                    break;
                case "Chocolate Shake":
                    cal_lbl.Text = "520 Cal.";
                    break;
                case "Caramel Cappuccino":
                    cal_lbl.Text = "210 Cal.";
                    break;
                case "Fanta® Orange":
                    cal_lbl.Text = "150 Cal.";
                    break;
                case "Chicken McNuggets®":
                    cal_lbl.Text = "170 Cal.";
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add5.4\t-mcdonalds-Chicken-McNuggets-4pc.jpg");
                    break;
                case "Vanilla Shake":
                    cal_lbl.Text = "510 Cal.";
                    break;
                case "French Vanilla Cappuccino":
                    cal_lbl.Text = "210 Cal.";
                    break;
                case "Hi-C Orange Lavaburst":
                    cal_lbl.Text = "110 Cal.";
                    break;
                case "Strawberry Shake":
                    cal_lbl.Text = "530 Cal.";
                    break;
                case "Mocha":
                    cal_lbl.Text = "300 Cal.";
                    break;
                case "Sweet Tea":
                    cal_lbl.Text = "70 Cal.";
                    break;
                case "Iced Mocha":
                    cal_lbl.Text = "280 Cal.";
                    break;
                case "Latte":
                    cal_lbl.Text = "140 Cal.";
                    break;
                case "Iced Latte":
                    cal_lbl.Text = "90 Cal.";
                    break;
                case "Minute Maid® Premium Orange Juice":
                    cal_lbl.Text = "150 Cal.";
                    break;
                case "Strawberry Banana Smoothie":
                    cal_lbl.Text = "190 Cal.";
                    break;
                case "Caramel Frappé":
                    cal_lbl.Text = "420 Cal.";
                    break;
                case "Mocha Frappé":
                    cal_lbl.Text = "420 Cal.";
                    break;
            }
            radioButton1.FlatAppearance.BorderColor = Color.OrangeRed;
            radioButton2.FlatAppearance.BorderColor = Color.White;
            radioButton3.FlatAppearance.BorderColor = Color.White;
            radioButton4.FlatAppearance.BorderColor = Color.White;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            switch (foodname_lbl.Text)
            {
                case "Coca-Cola®":
                    cal_lbl.Text = "150 Cal.";
                    break;
                case "Sprite®":
                    cal_lbl.Text = "140 Cal.";
                    break;
                case "McFlurry® with OREO® cookies":
                    cal_lbl.Text = "340 Cal.";
                    break;
                case "McFlurry® with M&M'S® Candies":
                    cal_lbl.Text = "420 Cal.";
                    break;
                case "Caramel Macchiato":
                    cal_lbl.Text = "320 Cal.";
                    break;
                case "World Famous Fries®":
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add1.10\t-mcdonalds-fries-small.jpg");
                    cal_lbl.Text = "220 Cal.";
                    break;
                case "Iced Caramel Macchiato":
                    cal_lbl.Text = "310 Cal.";
                    break;
                case "Dr Pepper®":
                    cal_lbl.Text = "140 Cal.";
                    break;
                case "Cappuccino":
                    cal_lbl.Text = "160 Cal.";
                    break;
                case "Chocolate Shake":
                    cal_lbl.Text = "620 Cal.";
                    break;
                case "Caramel Cappuccino":
                    cal_lbl.Text = "260 Cal.";
                    break;
                case "Fanta® Orange":
                    cal_lbl.Text = "210 Cal.";
                    break;
                case "Chicken McNuggets®":
                    cal_lbl.Text = "250 Cal.";
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add5.4\t-mcdonalds-Chicken-McNuggets-6pc.jpg");
                    break;
                case "Vanilla Shake":
                    cal_lbl.Text = "610 Cal.";
                    break;
                case "French Vanilla Cappuccino":
                    cal_lbl.Text = "230 Cal.";
                    break;
                case "Hi-C Orange Lavaburst":
                    cal_lbl.Text = "160 Cal.";
                    break;
                case "Strawberry Shake":
                    cal_lbl.Text = "620 Cal.";
                    break;
                case "Mocha":
                    cal_lbl.Text = "380 Cal.";
                    break;
                case "Sweet Tea":
                    cal_lbl.Text = "100 Cal.";
                    break;
                case "Iced Mocha":
                    cal_lbl.Text = "320 Cal.";
                    break;
                case "Latte":
                    cal_lbl.Text = "190 Cal.";
                    break;
                case "Iced Latte":
                    cal_lbl.Text = "120 Cal.";
                    break;
                case "Minute Maid® Premium Orange Juice":
                    cal_lbl.Text = "190 Cal.";
                    break;
                case "Strawberry Banana Smoothie":
                    cal_lbl.Text = "240 Cal.";
                    break;
                case "Caramel Frappé":
                    cal_lbl.Text = "510 Cal.";
                    break;
                case "Mocha Frappé":
                    cal_lbl.Text = "500 Cal.";
                    break;
            }
            radioButton1.FlatAppearance.BorderColor = Color.White;
            radioButton2.FlatAppearance.BorderColor = Color.OrangeRed;
            radioButton3.FlatAppearance.BorderColor = Color.White;
            radioButton4.FlatAppearance.BorderColor = Color.White;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            switch (foodname_lbl.Text)
            {
                case "Coca-Cola®":
                    cal_lbl.Text = "210 Cal.";
                    break;
                case "Sprite®":
                    cal_lbl.Text = "200 Cal.";
                    break;
                case "Caramel Macchiato":
                    cal_lbl.Text = "400 Cal.";
                    break;
                case "World Famous Fries®":
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add1.10\t-mcdonalds-fries-medium.jpg");
                    cal_lbl.Text = "320 Cal.";
                    break;
                case "Iced Caramel Macchiato":
                    cal_lbl.Text = "370 Cal.";
                    break;
                case "Dr Pepper®":
                    cal_lbl.Text = "200 Cal.";
                    break;
                case "Cappuccino":
                    cal_lbl.Text = "210 Cal.";
                    break;
                case "Chocolate Shake":
                    cal_lbl.Text = "830 Cal.";
                    break;
                case "Caramel Cappuccino":
                    cal_lbl.Text = "340 Cal.";
                    break;
                case "Fanta® Orange":
                    cal_lbl.Text = "300 Cal.";
                    break;
                case "Chicken McNuggets®":
                    cal_lbl.Text = "420 Cal.";
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add5.4\t-mcdonalds-Chicken-McNuggets-10pc.jpg");
                    break;
                case "Vanilla Shake":
                    cal_lbl.Text = "820 Cal.";
                    break;
                case "French Vanilla Cappuccino":
                    cal_lbl.Text = "310 Cal.";
                    break;
                case "Hi-C Orange Lavaburst":
                    cal_lbl.Text = "230 Cal.";
                    break;
                case "Strawberry Shake":
                    cal_lbl.Text = "840 Cal.";
                    break;
                case "Mocha":
                    cal_lbl.Text = "470 Cal.";
                    break;
                case "Sweet Tea":
                    cal_lbl.Text = "130 Cal.";
                    break;
                case "Iced Mocha":
                    cal_lbl.Text = "450 Cal.";
                    break;
                case "Latte":
                    cal_lbl.Text = "250 Cal.";
                    break;
                case "Iced Latte":
                    cal_lbl.Text = "170 Cal.";
                    break;
                case "Minute Maid® Premium Orange Juice":
                    cal_lbl.Text = "270 Cal.";
                    break;
                case "Strawberry Banana Smoothie":
                    cal_lbl.Text = "330 Cal.";
                    break;
                case "Caramel Frappé":
                    cal_lbl.Text = "670 Cal.";
                    break;
                case "Mocha Frappé":
                    cal_lbl.Text = "670 Cal.";
                    break;
            }
            radioButton1.FlatAppearance.BorderColor = Color.White;
            radioButton2.FlatAppearance.BorderColor = Color.White;
            radioButton3.FlatAppearance.BorderColor = Color.OrangeRed;
            radioButton4.FlatAppearance.BorderColor = Color.White;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            switch (foodname_lbl.Text)
            {
                case "Coca-Cola®":
                    cal_lbl.Text = "290 Cal.";
                    break;
                case "Sprite®":
                    cal_lbl.Text = "230 Cal.";
                    break;
                case "World Famous Fries®":
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add1.10\t-mcdonalds-fries-large.jpg");
                    cal_lbl.Text = "490 Cal.";
                    break;
                case "Dr Pepper®":
                    cal_lbl.Text = "280 Cal.";
                    break;
                case "Chicken McNuggets®":
                    cal_lbl.Text = "830 Cal.";
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add5.4\t-mcdonalds-Chicken-McNuggets-20pc.jpg");
                    break;
                case "Hi-C Orange Lavaburst":
                    cal_lbl.Text = "310 Cal.";
                    break;
                case "Sweet Tea":
                    cal_lbl.Text = "170 Cal.";
                    break;
            }
            radioButton1.FlatAppearance.BorderColor = Color.White;
            radioButton2.FlatAppearance.BorderColor = Color.White;
            radioButton3.FlatAppearance.BorderColor = Color.White;
            radioButton4.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        public void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        public static void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void foodname_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
