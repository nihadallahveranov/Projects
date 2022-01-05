using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace McDonalds
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        public void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void panellocation1()
        {
            try
            {
                panel6.Location = new Point(0, 11);
                pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\beverages\t-mcdonalds-Coca-Cola-Classic-Small.jpg");
                label1.Text = "Coca-Cola\n0.99$";
                pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\beverages\t-mcdonalds-Sprite-Small.jpg");
                label2.Text = "Sprite\n0.99$";
                pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\beverages\t-mcdonalds-Dr-Pepper-Small.jpg");
                label3.Text = "Dr Pepper\n1.09$";
                pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\beverages\t-mcdonalds-Diet-Coke-Small.jpg"); ;
                label4.Text = "Diet Coke\n1.09$";
                pictureBox14.Image = Image.FromFile( Application.StartupPath + @"\beverages\t-mcdonalds-fanta-orange.jpg");
                label12.Text = "Fanta\n0.99$";
                pictureBox12.Image = Image.FromFile(Application.StartupPath + @"\beverages\t-mcdonalds-hi-c-lavaburst.jpg");
                label10.Text = "Hi-C\n1.19$";
                pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\beverages\t-mcdonalds-Iced-Tea-Large-drink.jpg");
                label5.Text = "Sweet Tea\n1.09$";
                pictureBox16.Image = Image.FromFile(Application.StartupPath + @"\beverages\t-mcdonalds-Iced-Tea-Large-unsweetened.jpg");
                label21.Text = "Unsweetened Iced Tea\n1.19$";
                pictureBox15.Image = Image.FromFile(Application.StartupPath + @"\beverages\t-mcdonalds-Dasani-Water.jpg");
                label13.Text = "DASANI Water\n0.69$";
                pictureBox21.Image = Image.FromFile(Application.StartupPath + @"\beverages\t-mcdonalds-Minute-Maid-Orange-Juice-Medium.jpg");
                label17.Text = "Minute Maid Premium Orange Juice\n1.59$";
                pictureBox17.Image = Image.FromFile(Application.StartupPath + @"\beverages\t-mcdonalds-Strawberry-Banana-Smoothie-Medium.jpg");
                label15.Text = "Strawberry Banana Smoothie\n1.99$";
                pictureBox24.Image = Image.FromFile(Application.StartupPath + @"\beverages\t-mcdonalds-Mango-Pineapple-Smoothie-Small.jpg");
                label23.Text = "Mango Pineapple Smoothie\n1.99$";
                pictureBox5.Visible = true;
                label3.Visible = true;
                pictureBox6.Visible = true;
                label4.Visible = true;
                pictureBox14.Visible = true;
                label12.Visible = true;
                pictureBox12.Visible = true;
                label10.Visible = true;
                pictureBox7.Visible = true;
                label5.Visible = true;
                pictureBox16.Visible = true;
                label21.Visible = true;
                pictureBox15.Visible = true;
                label13.Visible = true;
                pictureBox21.Visible = true;
                label17.Visible = true;
                pictureBox16.Visible = true;
                label21.Visible = true;
                pictureBox15.Visible = true;
                label13.Visible = true;
                pictureBox21.Visible = true;
                label17.Visible = true;
                pictureBox17.Visible = true;
                label15.Visible = true;
                pictureBox24.Visible = true;
                label23.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "McDonalds");
            }
        }
        public void panellocation2()
        {
            try
            {
                pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\burgers\t-mcdonalds-Big-Mac.jpg");
                label1.Text = "Big Mac®\n3.99$";
                pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\burgers\t-mcdonalds-Quarter-Pounder-with-Cheese.jpg");
                label2.Text = "Quarter Pounder®* with Cheese\n3.79$";
                pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\burgers\t-mcdonalds-Double-Quarter-Pounder-with-Cheese.jpg");
                label3.Text = "Double Quarter Pounder®* with Cheese 4.79$";
                pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\burgers\t-mcdonalds-qpc-deluxe-burger.jpg");
                label4.Text = "Quarter Pounder®* with Cheese Deluxe 6.69$";
                pictureBox14.Image = Image.FromFile(Application.StartupPath + @"\burgers\t-mcdonalds-McDouble.jpg");
                label12.Text = "McDouble®\n1.39$";
                pictureBox12.Image = Image.FromFile(Application.StartupPath + @"\burgers\t-mcdonalds-qpc-bacon.jpg");
                label10.Text = "Quarter Pounder®* with Cheese Bacon 5.39$";
                pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\burgers\t-mcdonalds-Cheeseburger.jpg");
                label5.Text = "Cheeseburger\n1.00$";
                pictureBox16.Image = Image.FromFile(Application.StartupPath + @"\burgers\t-mcdonalds-Double-Cheeseburger.jpg");
                label21.Text = "Double Cheeseburger\n1.69$";
                pictureBox15.Image = Image.FromFile(Application.StartupPath + @"\burgers\t-mcdonalds-Hamburger.jpg");
                label13.Text = "Hamburger\n0.89$";
                pictureBox5.Visible = true;
                label3.Visible = true;
                pictureBox6.Visible = true;
                label4.Visible = true;
                pictureBox14.Visible = true;
                label12.Visible = true;
                pictureBox12.Visible = true;
                label10.Visible = true;
                pictureBox7.Visible = true;
                label5.Visible = true;
                pictureBox16.Visible = true;
                label21.Visible = true;
                pictureBox15.Visible = true;
                label13.Visible = true;
                pictureBox21.Visible = true;
                label17.Visible = true;
                pictureBox16.Visible = true;
                label21.Visible = true;
                pictureBox15.Visible = true;
                label13.Visible = true;
                pictureBox21.Visible = false;
                label17.Visible = false;
                pictureBox17.Visible = false;
                label15.Visible = false;
                pictureBox24.Visible = false;
                label23.Visible = false;
                panel6.Location = new Point(0, 87);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "McDonalds");
            }
            
        }
        public void panellocation3()
        {
            try
            {
                pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\breakfast\t-mcdonalds-Bacon-Egg-Cheese-Biscuit-Regular-Size-Biscuit.jpg");
                label1.Text = "Bacon, Egg and Cheese Biscuit 3.19$";
                pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\breakfast\t-mcdonalds-Egg-McMuffin.jpg");
                label2.Text = "Egg McMuffin®\n2.79$";
                pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\breakfast\t-mcdonalds-Sausage-McMuffin.jpg");
                label3.Text = "Sausage McMuffin®\n2.99$";
                pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\breakfast\t-mcdonalds-Sausage-McMuffin-with-Egg.jpg");
                label4.Text = "Sausage McMuffin® with Egg 4.19$";
                pictureBox14.Image = Image.FromFile(Application.StartupPath + @"\breakfast\t-mcdonalds-Sausage-Biscuit-with-Egg-Regular-Size-Biscuit.jpg");
                label12.Text = "Sausage Biscuit with Egg\n2.79$";
                pictureBox12.Image = Image.FromFile(Application.StartupPath + @"\breakfast\t-mcdonalds-Bacon-Egg-Cheese-McGriddles.jpg");
                label10.Text = "Bacon, Egg & Cheese McGriddles® 3.29$";
                pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\breakfast\t-mcdonalds-Sausage-Egg-Cheese-McGriddles.jpg");
                label5.Text = "Sausage, Egg & Cheese McGriddles® 4.49$";
                pictureBox16.Image = Image.FromFile(Application.StartupPath + @"\breakfast\s-mcdonalds-Big-Breakfast-Regular-Size-Biscuit.jpg");
                label21.Text = "Big Breakfast®\n3.69$";
                pictureBox15.Image = Image.FromFile(Application.StartupPath + @"\breakfast\t-mcdonalds-Big-Breakfast-with-Hotcakes-Regular-Size-Biscuit.jpg");
                label13.Text = "Big Breakfast® with Hotcakes 5.49$";
                pictureBox21.Image = Image.FromFile(Application.StartupPath + @"\breakfast\t-mcdonalds-Hotcakes.jpg");
                label17.Text = "Hotcakes\n2.49$";
                pictureBox17.Image = Image.FromFile(Application.StartupPath + @"\breakfast\t-mcdonalds-Sausage-Burrito.jpg");
                label15.Text = "Sausage Burrito\n1.29$";
                pictureBox24.Image = Image.FromFile(Application.StartupPath + @"\breakfast\t-mcdonalds-Fruit-Maple-Oatmeal.jpg");
                label23.Text = "Fruit and Maple Oatmeal\n1.99$";
                pictureBox5.Visible = true;
                label3.Visible = true;
                pictureBox6.Visible = true;
                label4.Visible = true;
                pictureBox14.Visible = true;
                label12.Visible = true;
                pictureBox12.Visible = true;
                label10.Visible = true;
                pictureBox7.Visible = true;
                label5.Visible = true;
                pictureBox16.Visible = true;
                label21.Visible = true;
                pictureBox15.Visible = true;
                label13.Visible = true;
                pictureBox21.Visible = true;
                label17.Visible = true;
                pictureBox16.Visible = true;
                label21.Visible = true;
                pictureBox15.Visible = true;
                label13.Visible = true;
                pictureBox21.Visible = true;
                label17.Visible = true;
                pictureBox17.Visible = true;
                label15.Visible = true;
                pictureBox24.Visible = true;
                label23.Visible = true;
                panel6.Location = new Point(0, 163);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "McDonalds");
            }
        }
        public void panellocation4()
        {
            try
            {
                pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\chicken\t-mcdonalds-spicy-deluxe-crispy-chicken-sandwich.jpg");
                label1.Text = "Spicy Deluxe Crispy Chicken Sandwich 4.60$";
                pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\chicken\t-mcdonalds-crispy-chicken-sandwich.jpg");
                label2.Text = "Crispy Chicken Sandwich\n3.90$";
                pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\chicken\t-mcdonalds-spicy-crispy-chicken-sandwich.jpg");
                label3.Text = "Spicy Crispy Chicken Sandwich\n3.99$";
                pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\chicken\t-mcdonalds-deluxe-crispy-chicken-sandwich.jpg");
                label4.Text = "Deluxe Crispy Chicken Sandwich\n4.50$";
                pictureBox14.Image = Image.FromFile(Application.StartupPath + @"\chicken\t-mcdonalds-Chicken-McNuggets-4pc.jpg");
                label12.Text = "Chicken McNuggets® 10Pc\n4.49$";
                pictureBox12.Image = Image.FromFile(Application.StartupPath + @"\chicken\t-mcdonalds-McChicken.jpg");
                label10.Text = "McChicken®\n1.29$";
                pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\chicken\t-mcdonalds-Filet-O-Fish.jpg");
                label5.Text = "Filet-O-Fish®\n3.79$";
                pictureBox5.Visible = true;
                label3.Visible = true;
                pictureBox6.Visible = true;
                label4.Visible = true;
                pictureBox14.Visible = true;
                label12.Visible = true;
                pictureBox12.Visible = true;
                label10.Visible = true;
                pictureBox7.Visible = true;
                label5.Visible = true;
                pictureBox16.Visible = true;
                label21.Visible = true;
                pictureBox15.Visible = true;
                label13.Visible = true;
                pictureBox21.Visible = true;
                label17.Visible = true;
                pictureBox16.Visible = false;
                label21.Visible = false;
                pictureBox15.Visible = false;
                label13.Visible = false;
                pictureBox21.Visible = false;
                label17.Visible = false;
                pictureBox17.Visible = false;
                label15.Visible = false;
                pictureBox24.Visible = false;
                label23.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "McDonalds");
            }
            panel6.Location = new Point(0, 239);
        }
        public void panellocation5()
        {
            try
            {
                panel6.Location = new Point(0, 315);
                pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\combo\h-mcdonalds-Big-Mac-Extra-Value-Meals.jpg");
                label1.Text = "Big Mac® Combo Meal\n7.70$";
                pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\combo\h-mcdonalds-2-Cheeseburger-Extra-Value-Meals.jpg");
                label2.Text = "Cheeseburger Combo Meal\n5.40$";
                pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\combo\h-mcdonalds-Quarter-Pounder-with-Cheese-Extra-Value-Meals.jpg");
                label3.Text = "Quarter Pounder®* with Cheese Meal 5.79$";
                pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\combo\h-mcdonalds-Double-Quarter-Pounder-with-Cheese-Extra-Value-Meals-combo.jpg"); ;
                label4.Text = "Double Quarter Pounder®* with Cheese Meal 6.69$";
                pictureBox14.Image = Image.FromFile(Application.StartupPath + @"\combo\h-crispy-chicken-sandwich-meal.jpg");
                label12.Text = "Crispy Chicken Sandwich Combo Meal 3.89$";
                pictureBox12.Image = Image.FromFile(Application.StartupPath + @"\combo\h-spicy-crispy-chicken-sandwich-meal-combo.jpg");
                label10.Text = "Spicy Crispy Chicken Sandwich Combo 4.00$";
                pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\combo\h-deluxe-crispy-chicken-sandwich-meal.jpg");
                label5.Text = "Deluxe Crispy Chicken Sandwich Combo 4.50$";
                pictureBox16.Image = Image.FromFile(Application.StartupPath + @"\combo\h-mcdonalds-Chicken-McNuggets-10-piece-Extra-Value-Meals.jpg");
                label21.Text = "10 piece Chicken McNuggets® Meal 6.49$";
                pictureBox15.Image = Image.FromFile(Application.StartupPath + @"\combo\h-mcdonalds-Filet-O-Fish-Extra-Value-Meals.jpg");
                label13.Text = "Filet-O-Fish® combo Meal\n5.79$";
                pictureBox21.Image = Image.FromFile(Application.StartupPath + @"\combo\h-mcdonalds-Egg-McMuffin-Extra-Value-Meals.jpg");
                label17.Text = "Egg McMuffin® Meal\n3.99$";
                pictureBox17.Image = Image.FromFile(Application.StartupPath + @"\combo\h-mcdonalds-Sausage-McMuffin-with-Egg-Extra-Value-Meals.jpg");
                label15.Text = "Sausage McMuffin® with Egg Meal 4.19$";
                pictureBox24.Image = Image.FromFile(Application.StartupPath + @"\combo\h-mcdonalds-Sausage-Biscuit-with-Egg-Extra-Value-Meals.jpg");
                label23.Text = "Sausage Biscuit with Egg Meal 3.99$";
                pictureBox5.Visible = true;
                label3.Visible = true;
                pictureBox6.Visible = true;
                label4.Visible = true;
                pictureBox14.Visible = true;
                label12.Visible = true;
                pictureBox12.Visible = true;
                label10.Visible = true;
                pictureBox7.Visible = true;
                label5.Visible = true;
                pictureBox16.Visible = true;
                label21.Visible = true;
                pictureBox15.Visible = true;
                label13.Visible = true;
                pictureBox21.Visible = true;
                label17.Visible = true;
                pictureBox16.Visible = true;
                label21.Visible = true;
                pictureBox15.Visible = true;
                label13.Visible = true;
                pictureBox21.Visible = true;
                label17.Visible = true;
                pictureBox17.Visible = true;
                label15.Visible = true;
                pictureBox24.Visible = true;
                label23.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "McDonalds");
            }
        }
        public void panellocation6()
        {
            try
            {
                panel6.Location = new Point(0, 391);
                pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\desserts\t-oreo-mcflurry-snack.jpg");
                label1.Text = "McFlurry® with OREO® cookies\n$2.39";
                pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\desserts\t-mm-mcflurry-snack.jpg");
                label2.Text = "McFlurry® with M&M'S® Candies\n2.39$";
                pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\desserts\t-mcdonalds-Vanilla-Reduced-Fat-Ice-Cream-Cone.jpg");
                label3.Text = "Vanilla Cone\n0.99$";
                pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\desserts\t-mcdonalds-Chocolate-McCafe-Shake-Medium.jpg"); ;
                label4.Text = "Chocolate Shake\n2.19$";
                pictureBox14.Image = Image.FromFile(Application.StartupPath + @"\desserts\t-mcdonalds-Vanilla-McCafe-Shake-Medium.jpg");
                label12.Text = "Vanilla Shake\n2.19$";
                pictureBox12.Image = Image.FromFile(Application.StartupPath + @"\desserts\t-mcdonalds-Strawberry-McCafe-Shake-Medium.jpg");
                label10.Text = "Strawberry Shake\n2.19$";
                pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\desserts\t-mcdonalds-Hot-Fudge-Sundae.jpg");
                label5.Text = "Hot Fudge Sundae\n1.29$";
                pictureBox16.Image = Image.FromFile(Application.StartupPath + @"\desserts\t-mcdonalds-Hot-Caramel-Sundae.jpg");
                label21.Text = "Hot Caramel Sundae\n1.29$";
                pictureBox15.Image = Image.FromFile(Application.StartupPath + @"\desserts\t-mcdonalds-Baked-Hot-Apple-Pie.jpg");
                label13.Text = "Baked Apple Pie\n0.99$";
                pictureBox21.Image = Image.FromFile(Application.StartupPath + @"\desserts\t-mcdonalds-Chocolate-Chip-Cookie-mcd.jpg");
                label17.Text = "Chocolate Chip Cookie\n0.39$";
                pictureBox5.Visible = true;
                label3.Visible = true;
                pictureBox6.Visible = true;
                label4.Visible = true;
                pictureBox14.Visible = true;
                label12.Visible = true;
                pictureBox12.Visible = true;
                label10.Visible = true;
                pictureBox7.Visible = true;
                label5.Visible = true;
                pictureBox16.Visible = true;
                label21.Visible = true;
                pictureBox15.Visible = true;
                label13.Visible = true;
                pictureBox21.Visible = true;
                label17.Visible = true;
                pictureBox16.Visible = true;
                label21.Visible = true;
                pictureBox15.Visible = true;
                label13.Visible = true;
                pictureBox21.Visible = true;
                label17.Visible = true;
                pictureBox17.Visible = false;
                label15.Visible = false;
                pictureBox24.Visible = false;
                label23.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "McDonalds");
            }
        }
        public void panellocation7()
        {
            try
            {
                pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\happy\h-mcdonalds-Hamburger.jpg");
                label1.Text = "Hamburger Happy Meal®\n$2.49";
                pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\happy\h-mcdonalds-Chicken-McNuggets.jpg");
                label2.Text = "4 Piece Chicken McNuggets® Happy Meal\n3.29$";
                pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\happy\mcdonalds-Chicken-McNuggets-Mighty-Kids-Meals.jpg");
                label3.Text = "6 Piece Chicken McNuggets® Happy Meal\n3.99$";
                pictureBox5.Visible = true;
                label3.Visible = true;
                pictureBox6.Visible = false;
                label4.Visible = false;
                pictureBox14.Visible = false;
                label12.Visible = false;
                pictureBox12.Visible = false;
                label10.Visible = false;
                pictureBox7.Visible = false;
                label5.Visible = false;
                pictureBox16.Visible = false;
                label21.Visible = false;
                pictureBox15.Visible = false;
                label13.Visible = false;
                pictureBox21.Visible = false;
                label17.Visible = false;
                pictureBox16.Visible = false;
                label21.Visible = false;
                pictureBox15.Visible = false;
                label13.Visible = false;
                pictureBox21.Visible = false;
                label17.Visible = false;
                pictureBox17.Visible = false;
                label15.Visible = false;
                pictureBox24.Visible = false;
                label23.Visible = false;
                panel6.Location = new Point(0, 467);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public void panellocation8()
        {
            try
            {
                pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\coffee\t-mcdonalds-caramel-macchiato.jpg");
                label1.Text = "Caramel Macchiato\n2.39$";
                pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\coffee\t-mcdonalds-iced-caramel-macchiato.jpg");
                label2.Text = "Iced Caramel Macchiato\n2.39$";
                pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\coffee\t-mcdonalds-cappuccino.jpg");
                label3.Text = "Cappuccino\n2.39$";
                pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\coffee\t-mcdonalds-caramel-cappuccino.jpg"); ;
                label4.Text = "Caramel Cappuccino\n2.39$";
                pictureBox14.Image = Image.FromFile(Application.StartupPath + @"\coffee\t-mcdonalds-vanilla-cappuccino.jpg");
                label12.Text = "French Vanilla Cappuccino\n2.39$";
                pictureBox12.Image = Image.FromFile(Application.StartupPath + @"\coffee\t-mcdonalds-McCafe-Mocha-Medium.jpg");
                label10.Text = "Mocha\n2.39$";
                pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\coffee\t-mcdonalds-McCafe-Iced-Mocha-Medium.jpg");
                label5.Text = "Iced Mocha\n2.39$";
                pictureBox16.Image = Image.FromFile(Application.StartupPath + @"\coffee\t-mcdonalds-McCafe-Latte-Medium.jpg");
                label21.Text = "Latte\n2.39$";
                pictureBox15.Image = Image.FromFile(Application.StartupPath + @"\coffee\t-mcdonalds-iced-latte.jpg");
                label13.Text = "Iced Latte\n2.39$";
                pictureBox21.Image = Image.FromFile(Application.StartupPath + @"\coffee\t-mcdonalds-americano.jpg");
                label17.Text = "Americano\n2.29$";
                pictureBox17.Image = Image.FromFile(Application.StartupPath + @"\coffee\t-mcdonalds-Frappe-Caramel-Medium.jpg");
                label15.Text = "Caramel Frappé\n2.39$";
                pictureBox24.Image = Image.FromFile(Application.StartupPath + @"\coffee\t-mcdonalds-Frappe-Mocha-Medium.jpg");
                label23.Text = "Mocha Frappé\n2.39$";
                pictureBox5.Visible = true;
                label3.Visible = true;
                pictureBox6.Visible = true;
                label4.Visible = true;
                pictureBox14.Visible = true;
                label12.Visible = true;
                pictureBox12.Visible = true;
                label10.Visible = true;
                pictureBox7.Visible = true;
                label5.Visible = true;
                pictureBox16.Visible = true;
                label21.Visible = true;
                pictureBox15.Visible = true;
                label13.Visible = true;
                pictureBox21.Visible = true;
                label17.Visible = true;
                pictureBox16.Visible = true;
                label21.Visible = true;
                pictureBox15.Visible = true;
                label13.Visible = true;
                pictureBox21.Visible = true;
                label17.Visible = true;
                pictureBox17.Visible = true;
                label15.Visible = true;
                pictureBox24.Visible = true;
                label23.Visible = true;
                panel6.Location = new Point(0, 543);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "McDonalds");
            }
        }
        public void panellocation9()
        {
            try
            {
                pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\bakery\t-apple-fritter-bakery.jpg");
                label1.Text = "Apple Fritter\n$1.75$";
                pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\bakery\t-blueberry-muffin-bakery-mcd.jpg");
                label2.Text = "Blueberry Muffin\n1.69$";
                pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\bakery\t-cinnamon-roll-mcbakery.jpg");
                label3.Text = "Cinnamon Roll\n2.69$";
                pictureBox5.Visible = true;
                label3.Visible = true;
                pictureBox6.Visible = false;
                label4.Visible = false;
                pictureBox14.Visible = false;
                label12.Visible = false;
                pictureBox12.Visible = false;
                label10.Visible = false;
                pictureBox7.Visible = false;
                label5.Visible = false;
                pictureBox16.Visible = false;
                label21.Visible = false;
                pictureBox15.Visible = false;
                label13.Visible = false;
                pictureBox21.Visible = false;
                label17.Visible = false;
                pictureBox16.Visible = false;
                label21.Visible = false;
                pictureBox15.Visible = false;
                label13.Visible = false;
                pictureBox21.Visible = false;
                label17.Visible = false;
                pictureBox17.Visible = false;
                label15.Visible = false;
                pictureBox24.Visible = false;
                label23.Visible = false;
                panel6.Location = new Point(0, 619);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "McDonalds");
            }
        }
        public void panellocation10()
        {
            try
            {
                pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\snacks\t-mcdonalds-fries-small.jpg");
                label1.Text = "World Famous Fries®";
                pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\snacks\t-mcdonalds-Apple-Slices.jpg");
                label2.Text = "Apple Slices";
                pictureBox5.Visible = false;
                label3.Visible = false;
                pictureBox6.Visible = false;
                label4.Visible = false;
                pictureBox14.Visible = false;
                label12.Visible = false;
                pictureBox12.Visible = false;
                label10.Visible = false;
                pictureBox7.Visible = false;
                label5.Visible = false;
                pictureBox16.Visible = false;
                label21.Visible = false;
                pictureBox15.Visible = false;
                label13.Visible = false;
                pictureBox21.Visible = false;
                label17.Visible = false;
                pictureBox16.Visible = false;
                label21.Visible = false;
                pictureBox15.Visible = false;
                label13.Visible = false;
                pictureBox21.Visible = false;
                label17.Visible = false;
                pictureBox17.Visible = false;
                label15.Visible = false;
                pictureBox24.Visible = false;
                label23.Visible = false;
                panel6.Location = new Point(0, 695);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "McDonalds");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panellocation1();
            menu_lbl.Text = "Beverages";
        }

        private void breakfast_img_Click(object sender, EventArgs e)
        {
            panellocation3();
            menu_lbl.Text = "Breakfast";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            chicken_lbl.Text = "Chicken and\nSandwiches";
            desserts_lbl.Text = "Desserts and \nShakes";
            cafe_lbl.Text = "McCafe\nDrinks";
            bakery_lbl.Text = "McCafe\nBakery";
            snacks_lbl.Text = "Snacks\nSides";
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void happy_img_Click(object sender, EventArgs e)
        {
            panellocation7();
            menu_lbl.Text = "Happy Meal";
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            panellocation2();
            menu_lbl.Text = "Burgers";
        }

        private void burger_img_Click(object sender, EventArgs e)
        {
            panellocation2();
            menu_lbl.Text = "Burgers";
        }

        private void burger_lbl_Click(object sender, EventArgs e)
        {
            panellocation2();
            menu_lbl.Text = "Burgers";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void beverages_lbl_Click(object sender, EventArgs e)
        {
            panellocation1();
            menu_lbl.Text = "Beverages";
        }

        private void breakfast_lbl_Click(object sender, EventArgs e)
        {
            panellocation3();
            menu_lbl.Text = "Breakfast";
        }

        private void chicken_img_Click(object sender, EventArgs e)
        {
            panellocation4();
            menu_lbl.Text = "Chicken and Sandwiches";
        }

        private void chicken_lbl_Click(object sender, EventArgs e)
        {
            panellocation4();
            menu_lbl.Text = "Chicken and Sandwiches";
        }

        private void combomeal_img_Click(object sender, EventArgs e)
        {
            panellocation5();
            menu_lbl.Text = "Combo Meal";
        }

        private void combomeal_lbl_Click(object sender, EventArgs e)
        {
            menu_lbl.Text = "Combo Meal";
            panellocation5();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void desserts_img_Click(object sender, EventArgs e)
        {
            panellocation6();
            menu_lbl.Text = "Desserts and Shakes";
        }

        private void desserts_lbl_Click(object sender, EventArgs e)
        {
            panellocation6();
            menu_lbl.Text = "Desserts and Shakes";

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            panellocation1();
            menu_lbl.Text = "Beverages";
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panellocation3();
            menu_lbl.Text = "Breakfast";
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            panellocation4();        
            menu_lbl.Text = "Chicken and Sandwiches";
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            panellocation5();
            menu_lbl.Text = "Combo Meal";
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            panellocation6();
            menu_lbl.Text = "Desserts and Shakes";
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            panellocation7();
            menu_lbl.Text = "Happy Meal";
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            panellocation8();
            menu_lbl.Text = "McCafe Drinks";
        }

        private void happy_lbl_Click(object sender, EventArgs e)
        {
            panellocation7();
            menu_lbl.Text = "Happy Meal";

        }

        private void cafe_lbl_Click(object sender, EventArgs e)
        {
            panellocation8();
            menu_lbl.Text = "McCafe Drinks";
        }

        private void cafe_img_Click(object sender, EventArgs e)
        {
            panellocation8();
            menu_lbl.Text = "McCafe Drinks";
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bakery_img_Click(object sender, EventArgs e)
        {
            panellocation9();
            menu_lbl.Text = "McCafe Bakery";
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            panellocation9();
            menu_lbl.Text = "McCafe Bakery";
        }

        private void bakery_lbl_Click(object sender, EventArgs e)
        {
            panellocation9();
            menu_lbl.Text = "McCafe Bakery";
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Click(object sender, EventArgs e)
        {
            panellocation10();
            menu_lbl.Text = "Snacks Sides";
        }

        private void snacks_img_Click(object sender, EventArgs e)
        {
            panellocation10();
            menu_lbl.Text = "Snacks Sides";
        }

        private void snacks_lbl_Click(object sender, EventArgs e)
        {
            panellocation10();
            menu_lbl.Text = "Snacks Sides";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void menu_lbl_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
