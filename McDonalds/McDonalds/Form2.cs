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
        Form3 f3 = new Form3();
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
                pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\beverages\mcdonalds-sprite.jpg");
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
                panel6.Location = new Point(0, 239);
                pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\chicken\t-mcdonalds-spicy-deluxe-crispy-chicken-sandwich.jpg");
                label1.Text = "Spicy Deluxe Crispy Chicken Sandwich 4.60$";
                pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\chicken\t-mcdonalds-crispy-chicken-sandwich.jpg");
                label2.Text = "Crispy Chicken Sandwich\n3.90$";
                pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\chicken\t-mcdonalds-spicy-crispy-chicken-sandwich.jpg");
                label3.Text = "Spicy Crispy Chicken Sandwich 3.99$";
                pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\chicken\t-mcdonalds-deluxe-crispy-chicken-sandwich.jpg");
                label4.Text = "Deluxe Crispy Chicken Sandwich 4.50$";
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
                label1.Text = "McFlurry® with OREO® cookies $2.39";
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
                label3.Text = "6 Piece Chicken McNuggets Happy Meal 3.99$";
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
            add1();
            form3open();
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
            add1();
            form3open();
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            add6();
            form3open();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            add5();
            form3open();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            add2();
            form3open();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            add2();
            form3open();
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            add5();
            form3open();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            add6();
            form3open();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            add7();
            form3open();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            add7();
            form3open();
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
            add8();
            form3open();
        }

        public void form3open()
        {
            f3.Hide();
            f3.Show();
            f3.radioButton2.Checked = true;
            f3.radioButton2.FlatAppearance.BorderColor = Color.OrangeRed;
        }
        public void add1()
        {
            try
            {
                if (panel6.Location == new Point(0, 11))//1.1
                {
                    f3.about_lbl.Height = 157;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add1.1\t-mcdonalds-Coca-Cola-Classic-Small.jpg");
                    f3.foodname_lbl.Text = "Coca-Cola®";
                    f3.cal_lbl.Text = "150 Cal.";
                    f3.about_lbl.Text = "Coca-Cola® is a refreshing McDonald's soda option that complements all of your menu favorites. " +
                    "Have you ever wondered, is Coke® at McDonald’s different? Visit our Why Does McDonalds Coca Cola Taste So Good FAQ " +
                    "to find out. Enjoy a refreshing Coke® at McDonald’s in extra small, small, medium and large for $1 on the $1 $2 $3 " +
                    "Dollar Menu.";
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\Cola\coca_cola.png");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                    f3.label1.Text = "Ingredients in the Coca-Cola®";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "Coca-Cola";
                    f3.label5.Text = "Ice";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Text = "XS";
                    f3.radioButton2.Text = "S";
                    f3.radioButton3.Text = "M";
                    f3.radioButton4.Text = "L";
                    f3.radioButton1.Visible = true;
                    f3.radioButton2.Visible = true;
                    f3.radioButton3.Visible = true;
                    f3.radioButton4.Visible = true;
                    f3.size_lbl.Visible = true;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 87))//1.2
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\bigmac\t-mcdonalds-Big-Mac.jpg");
                    f3.foodname_lbl.Text = "Big Mac®";
                    f3.cal_lbl.Text = "550 Cal.";
                    f3.about_lbl.Text = "Mouthwatering perfection starts with two 100% pure beef patties and Big Mac® sauce sandwiched "  +
                    "between a sesame seed bun. It’s topped off with pickles, crisp shredded lettuce, finely chopped onion and American " +
                    "cheese for a 100% beef burger with a taste like no other. It contains no artificial flavors, preservatives or added "+
                    "colors from artificial sources.* Our pickle contains an artificial preservative, so skip it if you like. There are " +
                    "550 calories in a Big Mac®. Order one today using the McDonald's App to Mobile Order & Pay! Download the McDonald’s "+
                    "app and earn points on every order with MyMcDonald's Rewards to redeem for a free Big Mac®.^";
                    f3.label1.Text = "Ingredients in the Big Mac®";
                    f3.label2.Text = "Big Mac Bun";
                    f3.label3.Text = "100% Beef Patty";
                    f3.label4.Text = "Shredded Lettuce";
                    f3.label5.Text = "Big Mac Sauce";
                    f3.label6.Text = "Pasteurized Process American Cheese";
                    f3.label7.Text = "Pickle Slices";
                    f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\bigmac\big_mac_bun.png");
                    f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\bigmac\10_1_patty.png");
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\bigmac\shredded_lettuce.png");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\bigmac\big_mac_sauce.png");
                    f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                    f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\bigmac\pickles.png");
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = true;
                    f3.pictureBox3.Visible = true;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = true;
                    f3.pictureBox7.Visible = true;
                }
                else if (panel6.Location == new Point(0, 163))//1.3
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add1.3\t-mcdonalds-Bacon-Egg-Cheese-Biscuit-Regular-Size-Biscuit.jpg");
                    f3.foodname_lbl.Text = "Bacon, Egg & Cheese Biscuit";
                    f3.cal_lbl.Text = "460 Cal.";
                    f3.about_lbl.Text = "The McDonald's Bacon, Egg & Cheese Biscuit breakfast sandwich features a warm, buttermilk " +
                    "biscuit brushed with real butter, thick cut Applewood smoked bacon, a fluffy folded egg, and a slice of melty " +
                    "American cheese. There are 460 calories in a Bacon, Egg & Cheese Biscuit at McDonald's. Try one today with a "  +
                    "Premium Roast Coffee and order with Mobile Order & Pay on the McDonald's App!";
                    f3.label1.Text = "Ingredients in the Bacon, Egg & Cheese Biscuit";
                    f3.label2.Text = "Biscuit";
                    f3.label3.Text = "Folded Egg";
                    f3.label4.Text = "Pasteurized Process American Cheese";
                    f3.label5.Text = "Thick Cut Applewood Smoked Bacon";
                    f3.label6.Text = "Salted Butter";
                    f3.label7.Text = "Clarified Butter";
                    f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add1.3\biscuit.png");
                    f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.3\folded_egg.png");
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add1.3\applewood_bacon.png");
                    f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.3\butter_salted.png");
                    f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add1.3\clarified_butter.png");
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = true;
                    f3.pictureBox3.Visible = true;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = true;
                    f3.pictureBox7.Visible = true;
                }
                else if (panel6.Location == new Point(0, 239))//1.4
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add1.4\t-mcdonalds-spicy-deluxe-crispy-chicken-sandwich.jpg");
                    f3.foodname_lbl.Text = "Spicy Deluxe Crispy Chicken Sandwich";
                    f3.cal_lbl.Text = "540 Cal.";
                    f3.about_lbl.Text = "The Spicy Deluxe Crispy Chicken is big on everything, including heat. Our southern-style fried " +
                    "chicken fillet on a potato roll, topped with shredded lettuce, Roma tomatoes and Spicy Pepper Sauce kicks crispy, "  +
                    "juicy and tender up to the highest level. The Spicy Deluxe Crispy Chicken sandwich has 540 calories. Check out all " +
                    "the Crispy Chicken Sandwiches. Order one today in the McDonald’s app.";
                    f3.label1.Text = "Ingredients in the Spicy Deluxe Crispy Chicken Sandwich";
                    f3.label2.Text = "Crispy Chicken Fillet";
                    f3.label3.Text = "Potato Roll";
                    f3.label4.Text = "Roma Tomato";
                    f3.label5.Text = "Spicy Pepper Sauce";
                    f3.label6.Text = "Shredded Lettuce";
                    f3.label7.Text = "";
                    f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add1.4\t-crispy-chicken-fillet.jpg");
                    f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.4\t-potato-roll.jpg");
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add1.4\Ingredients_Tomato_180x180.png");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add1.4\t-original-spicy-sauce.jpg");
                    f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\bigmac\shredded_lettuce.png");
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = true;
                    f3.pictureBox3.Visible = true;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = true;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 315))//1.5
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add1.5\h-mcdonalds-Big-Mac-Extra-Value-Meals.jpg");
                    f3.foodname_lbl.Text = "Big Mac® Combo Meal";
                    f3.cal_lbl.Text = "1080 Cal.";
                    f3.about_lbl.Text = "The one and only McDonald’s Big Mac® Combo Meal. Big Mac Ingredients include a classic sesame "  +
                    "hamburger bun, Big Mac Sauce, American cheese and sliced pickles. McDonald's Big Mac meal is served with our World " +
                    "Famous Fries® and your choice of an icy Coca-Cola® or other fountain drink. There are 1,080 calories in a Big Mac® " +
                    "Combo Meal with a medium Coca-Cola® and medium fries. Get one today using Mobile Order & Pay or get it straight to " +
                    "your door with McDelivery®!";
                    f3.label1.Text = "";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "";
                    f3.label5.Text = "";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = false;
                    f3.pictureBox5.Visible = false;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 391))//1.6
                {
                    f3.about_lbl.Height = 157;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add1.6\t-oreo-mcflurry-snack.jpg");
                    f3.foodname_lbl.Text = "McFlurry® with OREO® cookies";
                    f3.cal_lbl.Text = "340 Cal.";
                    f3.about_lbl.Text = "The McDonald’s McFlurry® with OREO® Cookies is an popular combination of OREO® pieces and " +
                    "vanilla soft serve! Available in Regular Size and Snack Size on the McDonald's Desserts & Shakes menu.";
                    f3.label1.Text = "";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "";
                    f3.label5.Text = "";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = true;
                    f3.radioButton2.Visible = true;
                    f3.radioButton1.Text = "R";
                    f3.radioButton2.Text = "SN";
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = true;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = false;
                    f3.pictureBox5.Visible = false;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 467))//1.7
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add1.7\h-mcdonalds-Hamburger.jpg");
                    f3.foodname_lbl.Text = "Hamburger Happy Meal®";
                    f3.cal_lbl.Text = "475 Cal.";
                    f3.about_lbl.Text = "McDonald's Hamburger Happy Meal includes a juicy hamburger with kid-sized World Famous Fries " +
                    "and apple slices. Then pick a kid’s drink: 1% Low Fat Milk Jug, reduced sugar* chocolate milk, DASANI® Water or "  +
                    "Honest Kids® Appley Ever After® Organic Juice Drink. There are 475 calories in a Hamburger Happy Meal® with kids " +
                    "fries, 1% milk, and apple slices. Order it today using the McDonald's App to Mobile Order & Pay!";
                    f3.label1.Text = "";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "";
                    f3.label5.Text = "";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = false;
                    f3.pictureBox5.Visible = false;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 543))//1.8
                {
                    f3.about_lbl.Height = 157;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add1.8\t-mcdonalds-caramel-macchiato.jpg");
                    f3.foodname_lbl.Text = "Caramel Macchiato";
                    f3.cal_lbl.Text = "320 Cal.";
                    f3.about_lbl.Text = "Our McCafé® Caramel Macchiato recipe features rich, dark-roast espresso served with steamed "    +
                    "whole milk, mixed with sweet caramel syrup, and topped with ribbons of buttery caramel. Available in small, medium " +
                    "and large. There are 260 calories in a small Caramel Macchiato with whole milk from McDonald's. Try it today when "  +
                    "you order with Mobile Order & Pay or get it delivered with McDelivery®!";
                    f3.label1.Text = "Ingredients in the Caramel Macchiato";
                    f3.label2.Text = "Whole Milk";
                    f3.label3.Text = "Caramel Syrup";
                    f3.label4.Text = "Water";
                    f3.label5.Text = "Espresso";
                    f3.label6.Text = "Caramel Drizzle";
                    f3.label7.Text = "";
                    f3.radioButton1.Text = "S";
                    f3.radioButton2.Text = "M";
                    f3.radioButton3.Text = "L";
                    f3.radioButton1.Visible = true;
                    f3.radioButton2.Visible = true;
                    f3.radioButton3.Visible = true;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = true;
                    f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add1.8\Whole-Milk.jpg");
                    f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.8\caramel_syrup.png");
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add1.8\water.png");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add1.8\espresso.png");
                    f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.8\caramel_drizzle.png");
                    f3.pictureBox2.Visible = true;
                    f3.pictureBox3.Visible = true;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = true;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 619))//1.9
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add1.9\t-apple-fritter-bakery.jpg");
                    f3.foodname_lbl.Text = "Apple Fritter";
                    f3.cal_lbl.Text = "510 Cal.";
                    f3.about_lbl.Text = "A classic fritter made with cinnamon and apples fried to a golden brown and covered with a "  +
                    "sweet glaze icing. There are 510 calories in McDonald's Apple Fritter. Our Apple Fritter pairs perfectly with a " +
                    "Premium Roast Coffee. Get it in the App with Mobile Order & Pay!";
                    f3.label1.Text = "";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "";
                    f3.label5.Text = "";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = false;
                    f3.pictureBox5.Visible = false;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 695))//1.10
                {
                    f3.about_lbl.Height = 157;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add1.10\t-mcdonalds-fries-small.jpg");
                    f3.foodname_lbl.Text = "World Famous Fries®";
                    f3.cal_lbl.Text = "220 Cal.";
                    f3.about_lbl.Text = "McDonald's World Famous Fries® are made with premium potatoes such as the Russet Burbank and "   +
                    "the Shepody. With 0g of trans fat per labeled serving, these epic fries are crispy and golden on the outside and "   +
                    "fluffy on the inside. Best of all, you can get medium Fries for free every Friday with any $1 purchase, exclusively" +
                    " in the McDonald’s App. Grab our World Famous Fries® and pair with one of our classic McDonald’s Burgers today! "    +
                    "There are 220 calories in a small McDonald's fries. Order your fries today with McDelivery® or get them with "       +
                    "curbside pickup using Mobile Order & Pay!";
                    f3.label1.Text = "";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "";
                    f3.label5.Text = "";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Text = "K";
                    f3.radioButton2.Text = "S";
                    f3.radioButton3.Text = "M";
                    f3.radioButton4.Text = "L";
                    f3.radioButton1.Visible = true;
                    f3.radioButton2.Visible = true;
                    f3.radioButton3.Visible = true;
                    f3.radioButton4.Visible = true;
                    f3.size_lbl.Visible = true;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = false;
                    f3.pictureBox5.Visible = false;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "McDonalds");
            }
        }
        public void add2()
        {
            try
            {
                if (panel6.Location == new Point(0, 11))//2.1
                {
                    f3.about_lbl.Height = 157;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\beverages\mcdonalds-sprite.jpg");
                    f3.foodname_lbl.Text = "Sprite®";
                    f3.cal_lbl.Text = "140 Cal.";
                    f3.about_lbl.Text = "Sprite® is a delicious lemon-lime fountain drink and is available in sizes extra small, small, "  +
                    "medium, and large. Sprite® is a caffeine-free soda that makes the perfect addition to any McDonald’s Combo Meal"      +
                    "There are 140 calories in a Small Sprite® at McDonald's. Get one today with McDelivery® or get it with curbside "     +
                    "pickup using Mobile Order & Pay!";
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\sprite\sprite.png");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                    f3.label1.Text = "Ingredients in the Sprite®";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "Sprite";
                    f3.label5.Text = "Ice";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Text = "XS";
                    f3.radioButton2.Text = "S";
                    f3.radioButton3.Text = "M";
                    f3.radioButton4.Text = "L";
                    f3.radioButton1.Visible = true;
                    f3.radioButton2.Visible = true;
                    f3.radioButton3.Visible = true;
                    f3.radioButton4.Visible = true;
                    f3.size_lbl.Visible = true;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 87))//2.2
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add2.2\t-mcdonalds-Quarter-Pounder-with-Cheese.jpg");
                    f3.foodname_lbl.Text = "Quarter Pounder®* with Cheese";
                    f3.cal_lbl.Text = "520 Cal.";
                    f3.about_lbl.Text = "Each Quarter Pounder® with Cheese burger features a ¼ lb.* of 100% fresh beef that’s hot, "       +
                    "deliciously juicy and cooked when you order. It’s seasoned with just a pinch of salt and pepper, sizzled on a flat"   +
                    "iron grill, then topped with slivered onions, tangy pickles and two slices of melty American cheese on a sesame seed "+
                    "bun. Our QPC® contains no artificial flavors, preservatives or added colors from artificial sources. **Our pickle "   +
                    "contains an artificial preservative, so skip it if you like. A Quarter Pounder® with Cheese has 520 Calories. "       +
                    "Order one today with Mobile Order & Pay!";
                    f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add2.2\quarter_pounder_bun.png");
                    f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add2.2\ketchup.png");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\bigmac\pickles.png");
                    f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add2.2\slivered_onions.png");
                    f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add2.2\mustard.png");
                    f3.label1.Text = "Ingredients in the Quarter Pounder®* with Cheese";
                    f3.label2.Text = "Quarter Pound Bun";
                    f3.label3.Text = "Pasteurized Process American Cheese";
                    f3.label4.Text = "Ketchup";
                    f3.label5.Text = "Pickle Slices";
                    f3.label6.Text = "Onions";
                    f3.label7.Text = "Mustard";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = true;
                    f3.pictureBox3.Visible = true;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = true;
                    f3.pictureBox7.Visible = true;
                }
                else if (panel6.Location == new Point(0, 163))//2.3
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add2.3\t-mcdonalds-Egg-McMuffin.jpg");
                    f3.foodname_lbl.Text = "Egg McMuffin®";
                    f3.cal_lbl.Text = "310 Cal.";
                    f3.about_lbl.Text = "Our Egg McMuffin® breakfast sandwich is an excellent source of protein and oh so delicious. We place a freshly cracked Grade" +
                    " A egg on a toasted English Muffin topped with real butter and add lean Canadian bacon and melty American cheese. There are 300 calories in an "  +
                    "Egg McMuffin®. Pair it with a Premium Roast Coffee and pass the line when you use Mobile Order & Pay, only on the McDonald’s App!";
                    f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add2.3\english_muffin.png");
                    f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add2.3\round_egg.png");
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add2.3\canadian_bacon.png");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                    f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.3\butter_salted.png");
                    f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add1.3\clarified_butter.png");
                    f3.label1.Text = "Ingredients in the Egg McMuffin®";
                    f3.label2.Text = "English Muffin";
                    f3.label3.Text = "Egg";
                    f3.label4.Text = "Canadian Bacon";
                    f3.label5.Text = "Pasteurized Process American Cheese";
                    f3.label6.Text = "Salted Butter";
                    f3.label7.Text = "Clarified Butter";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = true;
                    f3.pictureBox3.Visible = true;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = true;
                    f3.pictureBox7.Visible = true;
                }
                else if (panel6.Location == new Point(0, 239))//2.4
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add2.4\t-mcdonalds-crispy-chicken-sandwich.jpg");
                    f3.foodname_lbl.Text = "Crispy Chicken Sandwich";
                    f3.cal_lbl.Text = "470 Cal.";
                    f3.about_lbl.Text = "McDonald's Crispy Chicken Sandwich is a southern style fried chicken sandwich that's crispy, juicy and tender perfection. " +
                    "It’s topped with crinkle-cut pickles and served on a toasted, buttered potato roll. The Crispy Chicken sandwich has 470 calories. Check out "   +
                    "all the Crispy Chicken Sandwiches. Order one today in the McDonald’s app.";
                    f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.4\t-crispy-chicken-fillet.jpg");
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add1.4\t-potato-roll.jpg");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add2.4\t-crinkle-cut-pickle.jpg");
                    f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.3\butter_salted.png");
                    f3.label1.Text = "Ingredients in the Crispy Chicken Sandwich";
                    f3.label2.Text = "";
                    f3.label3.Text = "Crispy Chicken Fillet";
                    f3.label4.Text = "Potato Roll";
                    f3.label5.Text = "Crinkle Cut Pickle";
                    f3.label6.Text = "Salted Butter";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = true;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = true;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 315))//2.5
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add2.5\h-mcdonalds-2-Cheeseburger-Extra-Value-Meals.jpg");
                    f3.foodname_lbl.Text = "Cheeseburger Combo Meal";
                    f3.cal_lbl.Text = "830 Cal.";
                    f3.about_lbl.Text = "McDonald's Cheeseburger Meal is 2 simple, satisfying classic 100% beef burgers, served with our World Famous Fries® and your" +
                    " choice of a medium McDonald’s soda or soft drink. There are 1,130 calories in a Cheeseburger Combo Meal with a medium Coca-Cola® and medium "    +
                    "fries. Get a cheeseburger combo meal today with Mobile Order & Pay or McDelivery®!";
                    f3.label1.Text = "";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "";
                    f3.label5.Text = "";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = false;
                    f3.pictureBox5.Visible = false;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 391))//2.6
                {
                    f3.about_lbl.Height = 157;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add2.6\t-mm-mcflurry-snack.jpg");
                    f3.foodname_lbl.Text = "McFlurry® with M&M'S® Candies";
                    f3.cal_lbl.Text = "420 Cal.";
                    f3.about_lbl.Text = "The McDonald’s M&M ® McFlurry® is a sweet, creamy M&M’S® dessert of vanilla soft serve with M&M’S® chocolate candies swirled" +
                    " in. Available in Regular Size and Snack Size. Check out all of McDonald's McFlurry® Flavors.";
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add2.6\vanilla_reduced_fat_cream.png");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add2.6\mm-topping.jpg");
                    f3.label1.Text = "";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "Vanilla Reduced Fat Ice Cream";
                    f3.label5.Text = "M&M Mini Milk Chocolate Candies";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = true;
                    f3.radioButton2.Visible = true;
                    f3.radioButton1.Text = "R";
                    f3.radioButton2.Text = "SN";
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = true;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 467))//2.7
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add2.7\h-mcdonalds-Chicken-McNuggets.jpg");
                    f3.foodname_lbl.Text = "4 Piece Chicken McNuggets® Happy Meal";
                    f3.cal_lbl.Text = "395 Cal.";
                    f3.about_lbl.Text = "Grab a McDonald’s Happy Meal® and get four tender Chicken McNuggets® made with white meat with kid-sized World Famous Fries" +
                    " and a side of Apple Slices. Then pick a kids’ drink: 1% Low Fat Milk Jug, Reduced Sugar Low Fat Chocolate Milk Jug, DASANI® Water or Honest "   +
                    "Kids® Appley Ever After® Organic Juice Drink plus, a fun toy completes every McDonald's kid's meal. There are 395 calories in a 4 piece Chicken" +
                    " McNuggets® Happy Meal with kids fries, 1% milk, and apple slices.";
                    f3.label1.Text = "";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "";
                    f3.label5.Text = "";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = false;
                    f3.pictureBox5.Visible = false;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 543))//2.8
                {
                    f3.about_lbl.Height = 157;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add2.8\t-mcdonalds-iced-caramel-macchiato.jpg");
                    f3.foodname_lbl.Text = "Iced Caramel Macchiato";
                    f3.cal_lbl.Text = "210 Cal.";
                    f3.about_lbl.Text = "The Iced Caramel Macchiato is made with our rich, dark-roasted roasted McCafe espresso and is served with whole milk, " +
                    "mixed with sweet caramel syrup. Then, it's topped off with buttery caramel drizzle. There are 210 calories in a McDonald's Iced Caramel "   +
                    "Macchiato. Pick up on your terms through the drive thru or with McDonald's curbside pickup when you Mobile Order & Pay! McDonald's App "    +
                    "download and registration required.";
                    f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add1.8\Whole-Milk.jpg");
                    f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add1.8\caramel_syrup.png");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add1.8\water.png");
                    f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.8\espresso.png");
                    f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add1.8\caramel_drizzle.png");
                    f3.label1.Text = "Ingredients in the Iced Caramel Macchiato";
                    f3.label2.Text = "Whole Milk";
                    f3.label3.Text = "Ice";
                    f3.label4.Text = "Caramel Syrup";
                    f3.label5.Text = "Water";
                    f3.label6.Text = "Espresso";
                    f3.label7.Text = "Caramel Drizzle";
                    f3.radioButton1.Text = "S";
                    f3.radioButton2.Text = "M";
                    f3.radioButton3.Text = "L";
                    f3.radioButton1.Visible = true;
                    f3.radioButton2.Visible = true;
                    f3.radioButton3.Visible = true;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = true;
                    f3.pictureBox2.Visible = true;
                    f3.pictureBox3.Visible = true;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = true;
                    f3.pictureBox7.Visible = true;
                }
                else if (panel6.Location == new Point(0, 619))//2.9
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add2.9\t-blueberry-muffin-bakery-mcd.jpg");
                    f3.foodname_lbl.Text = "Blueberry Muffin";
                    f3.cal_lbl.Text = "470 Cal.";
                    f3.about_lbl.Text = "A soft and fluffy muffin baked with real blueberries and topped with a streusel crumb topping that goes wonderfully with a" +
                    " Premium Roast Coffee. There are 470 calories in a McDonald's blueberry muffin. Grab a McDonald's blueberry muffin for breakfast using Mobile"  +
                    " Order & Pay in the App.";
                    f3.label1.Text = "";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "";
                    f3.label5.Text = "";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = false;
                    f3.pictureBox5.Visible = false;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 695))//2.10
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add2.10\t-mcdonalds-Apple-Slices.jpg");
                    f3.foodname_lbl.Text = "Apple Slices";
                    f3.cal_lbl.Text = "15 Cal.";
                    f3.about_lbl.Text = "McDonald’s Apple Slices are a wholesome, tasty side made from real apples. Specially selected varieties mean our apple" +
                    " slices are always crisp and juicy, making for a tasty snack with 15 calories per labelled serving. Enjoy it as a Snack or Side to your meal!";
                    f3.label1.Text = "";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "";
                    f3.label5.Text = "";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = false;
                    f3.pictureBox5.Visible = false;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "McDonalds");
            }
        }






        public void add3()
        {
            try
            {
                if (panel6.Location == new Point(0, 11))//3.1
                {
                    f3.about_lbl.Height = 157;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add3.1\t-mcdonalds-Dr-Pepper-Small.jpg");
                    f3.foodname_lbl.Text = "Dr Pepper®";
                    f3.cal_lbl.Text = "140 Cal.";
                    f3.about_lbl.Text = "McDonald's serves Dr Pepper®, the classic and refreshing fountain drink with a unique blend of 23 flavors. Dr Pepper®"    +
                    " pairs perfectly with any of your favorite menu items. There are 140 calories in a small Dr Pepper at McDonald's. Available in extra small, " +
                    "small, medium and large for $1 on our $1 $2 $3 Dollar Menu. Get it today in the App with Mobile Order & Pay!";
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add3.1\dr_pepper.png");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                    f3.label1.Text = "Ingredients in the Dr Pepper®";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "Dr Pepper";
                    f3.label5.Text = "Ice";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Text = "XS";
                    f3.radioButton2.Text = "S";
                    f3.radioButton3.Text = "M";
                    f3.radioButton4.Text = "L";
                    f3.radioButton1.Visible = true;
                    f3.radioButton2.Visible = true;
                    f3.radioButton3.Visible = true;
                    f3.radioButton4.Visible = true;
                    f3.size_lbl.Visible = true;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 87))//3.2
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add3.2\t-mcdonalds-Double-Quarter-Pounder-with-Cheese.jpg");
                    f3.foodname_lbl.Text = "Double Quarter Pounder®* with Cheese";
                    f3.cal_lbl.Text = "740 Cal.";
                    f3.about_lbl.Text = "Each Double Quarter Pounder with Cheese features two quarter pound* 100% fresh beef burger patties that are hot, "     +
                    "deliciously juicy and cooked when you order. McDonald’s beef patties are seasoned with just a pinch of salt and pepper, sizzled on a flat" +
                    " iron grill, then topped with slivered onions, tangy pickles and two slices of melty cheese on a sesame seed bun. It contains no "         +
                    "artificial flavors, preservatives or added colors from artificial sources.** Our pickle contains an artificial preservative, so skip it "  +
                    "if you like.";
                    f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add2.2\quarter_pounder_bun.png");
                    f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add2.2\ketchup.png");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\bigmac\pickles.png");
                    f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add2.2\slivered_onions.png");
                    f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add2.2\mustard.png");
                    f3.label1.Text = "Ingredients in the Quarter Pounder®* with Cheese";
                    f3.label2.Text = "Quarter Pound Bun";
                    f3.label3.Text = "Pasteurized Process American Cheese";
                    f3.label4.Text = "Ketchup";
                    f3.label5.Text = "Pickle Slices";
                    f3.label6.Text = "Onions";
                    f3.label7.Text = "Mustard";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = true;
                    f3.pictureBox3.Visible = true;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = true;
                    f3.pictureBox7.Visible = true;
                }
                else if (panel6.Location == new Point(0, 163))//3.3
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add3.3\t-mcdonalds-Sausage-McMuffin.jpg");
                    f3.foodname_lbl.Text = "Sausage McMuffin®";
                    f3.cal_lbl.Text = "400 Cal.";
                    f3.about_lbl.Text = "McDonald's Sausage McMuffin® recipe features a warm, freshly toasted English muffin, topped with a savory hot sausage" +
                    " patty and a slice of melty American cheese. There are 400 calories in a Sausage McMuffin® at McDonald's. Try this McDonald's breakfast"   +
                    " sandwich today with a Premium Roast Coffee and order with Mobile Order & Pay on the McDonald's App!";
                    f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add2.3\english_muffin.png");
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add3.3\sausage.png");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                    f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.3\butter_salted.png");
                    f3.label1.Text = "Ingredients in the Sausage McMuffin®";
                    f3.label2.Text = "";
                    f3.label3.Text = "English Muffin";
                    f3.label4.Text = "Sausage Patty";
                    f3.label5.Text = "Pasteurized Process American Cheese";
                    f3.label6.Text = "Salted Butter";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = true;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = true;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 239))//3.4
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add3.4\t-mcdonalds-spicy-crispy-chicken-sandwich.jpg");
                    f3.foodname_lbl.Text = "Spicy Crispy Chicken Sandwich";
                    f3.cal_lbl.Text = "530 Cal.";
                    f3.about_lbl.Text = "With our Spicy Pepper Sauce topping the southern style fried chicken fillet on a toasted potato roll, this sandwich was" +
                    " made for those who like it crispy, juicy, tender and hot. The Spicy Crispy Chicken sandwich has 530 calories. Check out all the Crispy"     +
                    " Chicken Sandwiches. Order one today in the McDonald’s app.";
                    f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.4\t-crispy-chicken-fillet.jpg");
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add1.4\t-potato-roll.jpg");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add1.4\t-original-spicy-sauce.jpg");
                    f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add2.4\t-crinkle-cut-pickle.jpg");
                    f3.label1.Text = "Ingredients in the Sausage McMuffin®";
                    f3.label2.Text = "";
                    f3.label3.Text = "Crispy Chicken Fillet";
                    f3.label4.Text = "Potato Roll";
                    f3.label5.Text = "Spicy Pepper Sauce";
                    f3.label6.Text = "Crinkle Cut Pickle";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = true;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = true;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 315))//3.5
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add3.5\h-mcdonalds-Quarter-Pounder-with-Cheese-Extra-Value-Meals.jpg");
                    f3.foodname_lbl.Text = "Quarter Pounder®*with Cheese Meal";
                    f3.cal_lbl.Text = "1050 Cal.";
                    f3.about_lbl.Text = "Refuel with a Quarter Pounder® with Cheese made with fresh beef** that’s cooked when you order. The Quarter Pounder® with" +
                    " Cheese Combo Meal is served with our World Famous Fries® and your choice of an icy medium fountain drink.";
                    f3.label1.Text = "";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "";
                    f3.label5.Text = "";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = false;
                    f3.pictureBox5.Visible = false;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 391))//3.6
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add3.6\t-mcdonalds-Vanilla-Reduced-Fat-Ice-Cream-Cone.jpg");
                    f3.foodname_lbl.Text = "Vanilla Cone";
                    f3.cal_lbl.Text = "200 Cal.";
                    f3.about_lbl.Text = "Enjoy our creamy vanilla soft serve in a crispy cone! It's the perfect sweet treat in addition to any McDonald's meal"  +
                    " or on its own! There are 200 calories in McDonald's soft serve cones! Order one today with Mobile Order & Pay, only on the McDonald's App!";
                    f3.label1.Text = "";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "";
                    f3.label5.Text = "";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = false;
                    f3.pictureBox5.Visible = false;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 467))//3.7
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add3.7\mcdonalds-Chicken-McNuggets-Mighty-Kids-Meals.jpg");
                    f3.foodname_lbl.Text = "6 Piece Chicken McNuggets® Happy Meal";
                    f3.cal_lbl.Text = "475 Cal.";
                    f3.about_lbl.Text = "Enjoy a McDonald’s Happy Meal® and get six tender Chicken McNuggets® made with white meat with kid-sized World Famous Fries"  +
                    " and a side of Apple Slices. Then pick a kids’ drink: 1% Low Fat Milk Jug, Reduced Sugar Low Fat Chocolate Milk Jug, DASANI® Water or Honest"     +
                    " Kids® Appley Ever After® Organic Juice Drink. Plus, every McDonald’s kids’ meal comes with a McDonald’s Happy Meal® toy! There are 475 calories" +
                    " in a 6 piece Chicken McNuggets® Happy Meal with kids fries, 1% milk, and apple slices.";
                    f3.label1.Text = "";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "";
                    f3.label5.Text = "";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = false;
                    f3.pictureBox5.Visible = false;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 543))//3.8
                {
                    f3.about_lbl.Height = 157;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add3.8\t-mcdonalds-cappuccino.jpg");
                    f3.foodname_lbl.Text = "Cappuccino";
                    f3.cal_lbl.Text = "160 Cal.";
                    f3.about_lbl.Text = "McCafé® Cappuccino is made with whole or nonfat steamed milk, bold espresso made from sustainably sourced beans, foamed milk," +
                    " and your choice of flavor. There are 120 calories in a small McDonald's Cappuccino with whole milk. Pick up your food whatever way you like "     +
                    "whether it's the drive thru or with McDonald's curbside pickup when you Mobile Order & Pay! McDonald's App download and registration required.";
                    f3.label1.Text = "Ingredients in the Caramel Macchiato";
                    f3.label2.Text = "";
                    f3.label3.Text = "Whole Milk";
                    f3.label4.Text = "Water";
                    f3.label5.Text = "Espresso";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Text = "S";
                    f3.radioButton2.Text = "M";
                    f3.radioButton3.Text = "L";
                    f3.radioButton1.Visible = true;
                    f3.radioButton2.Visible = true;
                    f3.radioButton3.Visible = true;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = true;
                    f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.8\Whole-Milk.jpg");
                    f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add1.8\water.png");
                    f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add1.8\espresso.png");
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = true;
                    f3.pictureBox4.Visible = true;
                    f3.pictureBox5.Visible = true;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
                else if (panel6.Location == new Point(0, 619))//3.9
                {
                    f3.about_lbl.Height = 235;
                    f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add3.9\t-cinnamon-roll-mcbakery.jpg");
                    f3.foodname_lbl.Text = "Cinnamon Roll";
                    f3.cal_lbl.Text = "560 Cal.";
                    f3.about_lbl.Text = "McDonald's cinnamon roll is served warm and loaded with cinnamon layered between buttery, flaky pastry dough that is drizzled" +
                    " with a delicious cream cheese icing. There are 560 calories in a McDonald's cinnamon roll. This treat pairs best with a Premium Roast Coffee. "   +
                    "Order a cinnamon roll using Mobile Order & Pay in the McDonald's App.";
                    f3.label1.Text = "";
                    f3.label2.Text = "";
                    f3.label3.Text = "";
                    f3.label4.Text = "";
                    f3.label5.Text = "";
                    f3.label6.Text = "";
                    f3.label7.Text = "";
                    f3.radioButton1.Visible = false;
                    f3.radioButton2.Visible = false;
                    f3.radioButton3.Visible = false;
                    f3.radioButton4.Visible = false;
                    f3.size_lbl.Visible = false;
                    f3.pictureBox2.Visible = false;
                    f3.pictureBox3.Visible = false;
                    f3.pictureBox4.Visible = false;
                    f3.pictureBox5.Visible = false;
                    f3.pictureBox6.Visible = false;
                    f3.pictureBox7.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "McDonalds");
            }
        }









        public void add4()
        {
            if (panel6.Location == new Point(0, 11))//4.1
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add4.1\t-mcdonalds-Diet-Coke-Small.jpg");
                f3.foodname_lbl.Text = "Diet Coke®";
                f3.cal_lbl.Text = "0 Cal.";
                f3.about_lbl.Text = "Try an icy cold Diet Coke®, with zero calories. It’s a staple to any McDonald's meal available on the $1 $2 $3 Dollar Menu. "     +
                "Wondering why Diet Coke® at McDonald’s tastes so good? We ensure our Coke® products are fresh and always tasting the way they should by following "   +
                "the guidelines set by Coca-Cola®, using a ratio of syrup that allows ice to melt, and pre chilling the Coca-Cola® syrup and water before they enter " +
                "our soda fountain! Diet Coke® is available in extra small, small, medium and large fountain drink sizes.";
                f3.label1.Text = "Ingredients in the Diet Coke®";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "Diet Coke";
                f3.label5.Text = "Ice";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Text = "XS";
                f3.radioButton2.Text = "S";
                f3.radioButton3.Text = "M";
                f3.radioButton4.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = true;
                f3.size_lbl.Visible = true;
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add4.1\diet_coke.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 87))//4.2
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add4.2\t-mcdonalds-qpc-deluxe-burger.jpg");
                f3.foodname_lbl.Text = "Quarter Pounder®* with Cheese Deluxe";
                f3.cal_lbl.Text = "630 Cal.";
                f3.about_lbl.Text = "McDonald's Quarter Pounder® with Cheese Deluxe is a fresh take on a Quarter Pounder® classic burger. Crisp shredded lettuce and" +
                " three Roma tomato slices top a ¼ lb.* of 100% McDonald’s fresh beef that’s hot, deliciously juicy and cooked when you order. Seasoned with just a"  +
                " pinch of salt and pepper and sizzled on our flat iron grill. Layered with two slices of melty American cheese, creamy mayo, slivered onions and "   +
                "tangy pickles on a soft, fluffy sesame seed hamburger bun. There are 630 calories in a Quarter Pounder with Cheese Deluxe. Grab your QPC Deluxe "    +
                "through the drive thru or with McDonald's curbside pickup when you Mobile Order & Pay! McDonald's App download and registration required.";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add2.2\quarter_pounder_bun.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add2.2\ketchup.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add4.2\Ingredients_Tomato_180x180.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\bigmac\shredded_lettuce.png");
                f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add4.2\mayonnaise.png");
                f3.label1.Text = "Ingredients in the Quarter Pounder®* with Cheese Deluxe";
                f3.label2.Text = "Quarter Pound Bun";
                f3.label3.Text = "Pasteurized Process American Cheese";
                f3.label4.Text = "Roma Tomato";
                f3.label5.Text = "Ketchup";
                f3.label6.Text = "Shredded Lettuce";
                f3.label7.Text = "Mayonnaise";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = true;
            }
            else if (panel6.Location == new Point(0, 163))//4.3
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add4.3\t-mcdonalds-Sausage-McMuffin-with-Egg.jpg");
                f3.foodname_lbl.Text = "Sausage McMuffin® with Egg";
                f3.cal_lbl.Text = "480 Cal.";
                f3.about_lbl.Text = "McDonald’s Sausage McMuffin® with Egg features a savory hot sausage, a slice of melty American cheese, and a delicious freshly" +
                " cracked egg all on a freshly toasted English muffin. There are 480 calories in Sausage McMuffin® with Egg at McDonald's. Use Mobile Order & Pay"   +
                " to pass the line, only on the McDonald’s App!";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add2.3\english_muffin.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add2.3\round_egg.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add3.3\sausage.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.3\butter_salted.png");
                f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add1.3\clarified_butter.png");
                f3.label1.Text = "Ingredients in the Sausage McMuffin® with Egg";
                f3.label2.Text = "English Muffin";
                f3.label3.Text = "Egg";
                f3.label4.Text = "Sausage Patty";
                f3.label5.Text = "Pasteurized Process American Cheese";
                f3.label6.Text = "Salted Butter";
                f3.label7.Text = "Clarified Butter";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = true;
            }
            else if (panel6.Location == new Point(0, 239))//4.4
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add4.4\t-mcdonalds-deluxe-crispy-chicken-sandwich.jpg");
                f3.foodname_lbl.Text = "Deluxe Crispy Chicken Sandwich";
                f3.cal_lbl.Text = "530 Cal.";
                f3.about_lbl.Text = "Get a little extra with toppings. Go deluxe with shredded lettuce, Roma tomatoes and mayo to take crispy, juicy and tender to"    +
                " the next level. The Deluxe Crispy Chicken sandwich has 530 calories. Check out all the Crispy Chicken Sandwiches. Order one today in the McDonald’s" +
                " app.";
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.4\t-crispy-chicken-fillet.jpg");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add1.4\t-potato-roll.jpg");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add4.2\Ingredients_Tomato_180x180.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\bigmac\shredded_lettuce.png");
                f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add4.2\mayonnaise.png");
                f3.label1.Text = "Ingredients in the Deluxe Crispy Chicken Sandwich";
                f3.label2.Text = "";
                f3.label3.Text = "Crispy Chicken Fillet";
                f3.label4.Text = "Potato Roll";
                f3.label5.Text = "Roma Tomato";
                f3.label6.Text = "Shredded Lettuce";
                f3.label7.Text = "Mayonnaise";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = true;
            }
            else if (panel6.Location == new Point(0, 315))//4.5
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add4.5\h-mcdonalds-Double-Quarter-Pounder-with-Cheese-Extra-Value-Meals-combo.jpg");
                f3.foodname_lbl.Text = "Double Quarter Pounder®*with Cheese Meal";
                f3.cal_lbl.Text = "1260 Cal.";
                f3.about_lbl.Text = "Get double the fresh beef** flavor with a Double Quarter Pounder® with Cheese made with fresh beef that’s cooked when you order." +
                " Served with our World Famous Fries® and your choice of an icy soft drink. There are 1,260 calories in a Double Quarter Pounder® with Cheese Meal "   +
                "with a Medium Dr Pepper and Medium French Fries from McDonald's. Order one today using Mobile Order & Pay and pick it up with curbside pickup or at"  +
                " the McDonald's drive thru. Looking for McDonald's delivery? Order your Double QPC® Meal with McDelivery® on Uber Eats or DoorDash!";
                f3.label1.Text = "";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = false;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 391))//4.6
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add4.6\t-mcdonalds-Chocolate-McCafe-Shake-Medium.jpg");
                f3.foodname_lbl.Text = "Chocolate Shake";
                f3.cal_lbl.Text = "620 Cal.";
                f3.about_lbl.Text = "Try the McDonald’s Chocolate Shake, the perfect sweet treat for any time of the day. Our chocolate shake is made with delicious" +
                " soft serve, chocolate syrup and finished off with a creamy whipped topping. McDonald's Chocolate Shake is available in small, medium and large. "   +
                "Explore other delicious desserts on the McDonald’s Desserts & Shakes Menu.";
                f3.label1.Text = "Ingredients in the Chocolate Shake";
                f3.label2.Text = "";
                f3.label3.Text = "Vanilla Reduced Fat Ice Cream";
                f3.label4.Text = "Chocolate Shake Syrup";
                f3.label5.Text = "Whipped Light Cream";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add4.6\vanilla_reduced_fat_cream.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add4.6\chocolate_shake_syrup.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add4.6\whipped_cream.png");
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 543))//4.8
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add4.8\t-mcdonalds-caramel-cappuccino.jpg");
                f3.foodname_lbl.Text = "Caramel Cappuccino";
                f3.cal_lbl.Text = "260 Cal.";
                f3.about_lbl.Text = "Our McCafé® Caramel Cappuccino recipe features whole or nonfat steamed milk, bold espresso made from sustainably-sourced beans," +
                " fluffy foam, and buttery caramel flavor. There are 210 calories in a small caramel cappuccino with whole milk at McDonald's. Order one today with"  +
                " Mobile Order & Pay and pick it up at the drive thru or with curbside pickup! Want your McDonald's delivered? Order McDelivery® through Uber Eats "  +
                "or DoorDash!";
                f3.label1.Text = "Ingredients in the Caramel Cappuccino";
                f3.label2.Text = "";
                f3.label3.Text = "Whole Milk";
                f3.label4.Text = "Caramel Syrup";
                f3.label5.Text = "Water";
                f3.label6.Text = "Espresso";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.8\Whole-Milk.jpg");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add1.8\caramel_syrup.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add1.8\water.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.8\espresso.png");
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = false;
            }
        }
        



        public void add5()
        {
            if (panel6.Location == new Point(0, 11))//5.1
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add5.1\t-mcdonalds-fanta-orange.jpg");
                f3.foodname_lbl.Text = "Fanta® Orange";
                f3.cal_lbl.Text = "210 Cal.";
                f3.about_lbl.Text = "McDonald’s Fanta® Orange is a caffeine-free soft drink full of bubbly, refreshing orange flavor. There are 210 calories in a"   +
                " medium Fanta® Orange. Fanta® Orange soda is part of McDonald’s $1 Any Size Soft Drinks on the $1 on our $1 $2 $3 Dollar Menu. Available in small," +
                " medium, and large fountain drink sizes. Get it today in the App with Mobile Order & Pay!";
                f3.label1.Text = "Ingredients in the Fanta® Orange";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "Fanta Orange";
                f3.label5.Text = "Ice";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add5.1\images.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 87))//5.2
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add5.2\t-mcdonalds-McDouble.jpg");
                f3.foodname_lbl.Text = "McDouble®";
                f3.cal_lbl.Text = "400 Cal.";
                f3.about_lbl.Text = "The classic McDouble® burger stacks two 100% pure beef patties seasoned with just a pinch of salt and pepper. Wondering what"    +
                " the difference is between a McDouble® and a Double Cheeseburger? A slice of cheese! It’s topped with tangy pickles, chopped onions, ketchup, "      +
                "mustard and a melty slice of American cheese. The McDouble® contains no artificial flavors, preservatives or added colors from artificial sources.*" +
                " Our pickle contains an artificial preservative, so skip it if you like.";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\bigmac\10_1_patty.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add5.2\regular_bun.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\bigmac\pickles.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add2.2\ketchup.png");
                f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add2.2\slivered_onions.png");
                f3.label1.Text = "Ingredients in the McDouble®";
                f3.label2.Text = "100% Beef Patty";
                f3.label3.Text = "Regular Bun";
                f3.label4.Text = "Pasteurized Process American Cheese";
                f3.label5.Text = "Pickle Slices";
                f3.label6.Text = "Ketchup";
                f3.label7.Text = "Onions";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = true;
            }
            else if (panel6.Location == new Point(0, 163))//5.3
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add5.3\t-mcdonalds-Sausage-Biscuit-with-Egg-Regular-Size-Biscuit.jpg");
                f3.foodname_lbl.Text = "Sausage Biscuit with Egg";
                f3.cal_lbl.Text = "530 Cal.";
                f3.about_lbl.Text = "McDonald's Sausage and Egg Biscuit features a warm, flaky biscuit brushed with real butter, a sizzling hot pork sausage patty,"   +
                " and a classic McDonald's folded egg. It's the perfect savory breakfast sandwich when you're looking for a quick, easy breakfast. Pair it with small" +
                " McCafé® Premium Roast Coffee to complete your meal!";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add1.3\biscuit.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.3\folded_egg.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add3.3\sausage.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add1.3\butter_salted.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.3\clarified_butter.png");
                f3.label1.Text = "Ingredients in the Sausage Biscuit with Egg";
                f3.label2.Text = "Biscuit";
                f3.label3.Text = "Folded Egg";
                f3.label4.Text = "Sausage Patty";
                f3.label5.Text = "Salted Butter";
                f3.label6.Text = "Clarified Butter";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 239))//5.4
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add5.4\t-mcdonalds-Chicken-McNuggets-6pc.jpg");
                f3.foodname_lbl.Text = "Chicken McNuggets®";
                f3.cal_lbl.Text = "250 Cal.";
                f3.about_lbl.Text = "Our tender, juicy Chicken McNuggets® are made with 100% white meat chicken and no artificial colors, flavors or preservatives." +
                " There are 170 calories in a 4 piece Chicken McNuggets®. Pair them with your favorite dipping sauces when you Mobile Order & Pay!";
                f3.label1.Text = "";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Text = "4";
                f3.radioButton2.Text = "6";
                f3.radioButton3.Text = "10";
                f3.radioButton4.Text = "20";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = true;
                f3.size_lbl.Visible = true;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = false;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 315))//5.5
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add5.5\h-crispy-chicken-sandwich-meal.jpg");
                f3.foodname_lbl.Text = "Crispy Chicken Sandwich Combo Meal";
                f3.cal_lbl.Text = "990 Cal.";
                f3.about_lbl.Text = "The McDonald’s Crispy Chicken Sandwich combo meal is crispy, juicy and tender perfection. Southern style fried chicken on a "    +
                "toasted, buttered potato roll, topped with crinkle-cut pickles and served with our World Famous Fries® and your choice of an icy soft drink. There " +
                "are 990 calories in a Crispy Chicken Sandwich meal with a medium Sprite® and medium fries.";
                f3.label1.Text = "";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = false;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 391))//5.6
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add5.6\t-mcdonalds-Vanilla-McCafe-Shake-Medium.jpg");
                f3.foodname_lbl.Text = "Vanilla Shake";
                f3.cal_lbl.Text = "610 Cal.";
                f3.about_lbl.Text = "McDonald's vanilla shake is made with our creamy vanilla soft serve and topped with whipped topping for a cool, tasty treat." +
                " Available in small, medium, and large. There are 610 calories in a medium vanilla shake at McDonald's. Check out all of McDonald’s Shakes and "  +
                "Desserts. Get a vanilla shake delivered with McDelivery® or get it with curbside pickup using Mobile Order & Pay!";
                f3.label1.Text = "Ingredients in the Vanilla Shake";
                f3.label2.Text = "";
                f3.label3.Text = "Vanilla Reduced Fat Ice Cream";
                f3.label4.Text = "Vanilla  Shake Syrup";
                f3.label5.Text = "Whipped Light Cream";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add4.6\vanilla_reduced_fat_cream.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add5.6\sf_french_vanilla_syrup.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add4.6\whipped_cream.png");
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 543))//5.8
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add5.8\t-mcdonalds-vanilla-cappuccino.jpg");
                f3.foodname_lbl.Text = "French Vanilla Cappuccino";
                f3.cal_lbl.Text = "230 Cal.";
                f3.about_lbl.Text = "Our McCafé® French Vanilla Cappuccino recipe features whole or nonfat steamed milk, bold espresso made from sustainably-sourced" +
                " beans, fluffy foam, and rich French Vanilla flavor. There are 190 calories in a small French Vanilla Cappuccino with whole milk at McDonald's. Try" +
                " it today when you Mobile Order & Pay and pickup at the drive thru or with curbside pickup! Looking for McDonald's delivery? Order McDelivery® "     +
                "through Uber Eats or DoorDash!";
                f3.label1.Text = "Ingredients in the French Vanilla Cappuccino";
                f3.label2.Text = "";
                f3.label3.Text = "Whole Milk";
                f3.label4.Text = "Vanilla  Shake Syrup";
                f3.label5.Text = "Water";
                f3.label6.Text = "Espresso";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.8\Whole-Milk.jpg");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add5.6\sf_french_vanilla_syrup.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add1.8\water.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.8\espresso.png");
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = false;
            }
        }



        public void add6()
        {
            if (panel6.Location == new Point(0, 11))//6.1
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add6.1\t-mcdonalds-hi-c-lavaburst.jpg");
                f3.foodname_lbl.Text = "Hi-C Orange Lavaburst";
                f3.cal_lbl.Text = "160 Cal.";
                f3.about_lbl.Text = "You asked for it, you got it—Hi-C Orange at McDonald’s is back! With a fruity flavor that teases your tastebuds it’s the perfect" +
                " addition to any McDonald’s meal. You can use the Hi-C Orange Finder which will be updated weekly as Hi-C Orange is rolled out across the country to" +
                " find the closest McDonald’s near you already offering the beverage. There are 160 calories in a small Hi-C Orange.";
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add6.1\hi_c_orange_lavaburst.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                f3.label1.Text = "Ingredients in the Hi-C® Orange Lavaburst®";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "Hi - C Orange Lavaburst";
                f3.label5.Text = "Ice";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Text = "XS";
                f3.radioButton2.Text = "S";
                f3.radioButton3.Text = "M";
                f3.radioButton4.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = true;
                f3.size_lbl.Visible = true;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 87))//6.2
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add6.2\t-mcdonalds-qpc-bacon.jpg");
                f3.foodname_lbl.Text = "Quarter Pounder®* with Cheese Bacon";
                f3.cal_lbl.Text = "630 Cal.";
                f3.about_lbl.Text = "Each Quarter Pounder® with Cheese Bacon burger features thick-cut applewood smoked bacon atop a ¼ lb.* of 100% McDonald's fresh" +
                " beef that's cooked when you order. It's a hot, deliciously juicy bacon cheeseburger, seasoned with just a pinch of salt and pepper and sizzled on " +
                "our flat iron grill. Layered with two slices of melty American cheese, slivered onions and tangy pickles on a soft, fluffy sesame seed hamburger "   +
                "bun. There are 630 calories in a Bacon Quarter Pounder with Cheese. Pick up your Bacon QPC in the drive thru or with McDonald's curbside pickup "    +
                "when you Mobile Order & Pay! McDonald's App download and registration required.";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add2.2\quarter_pounder_bun.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add1.3\applewood_bacon.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add2.2\ketchup.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\bigmac\pickles.png");
                f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add2.2\slivered_onions.png");
                f3.label1.Text = "Ingredients in the Quarter Pounder®* with Cheese Bacon";
                f3.label2.Text = "Quarter Pound Bun";
                f3.label3.Text = "Pasteurized Process American Cheese";
                f3.label4.Text = "Thick Cut Applewood Smoked Bacon";
                f3.label5.Text = "Ketchup";
                f3.label6.Text = "Pickle Slices";
                f3.label7.Text = "Onions";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = true;
            }
            else if (panel6.Location == new Point(0, 163))//6.3
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add6.3\t-mcdonalds-Bacon-Egg-Cheese-McGriddles.jpg");
                f3.foodname_lbl.Text = "Bacon, Egg & Cheese McGriddles®";
                f3.cal_lbl.Text = "430 Cal.";
                f3.about_lbl.Text = "Bacon, Egg & Cheese McGriddles® feature soft, warm griddle cakes with the sweet taste of maple. McDonald's McGriddles® recipe" +
                " features thick-cut Applewood smoked bacon, a fluffy folded egg, and a slice of melty American cheese. McGriddles® cakes have no artificial"       +
                " preservatives or flavors and no colors from artificial sources. The Bacon, Egg, & Cheese McGriddles® is 430 calories. Pick up on your terms "     +
                "through the drive thru or with McDonald's curbside pickup when you Mobile Order & Pay! McDonald's App download and registration required.";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add6.3\McGriddles_top.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.3\folded_egg.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add1.3\applewood_bacon.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.3\clarified_butter.png");
                f3.label1.Text = "Ingredients in the Bacon, Egg & Cheese McGriddles®";
                f3.label2.Text = "Griddle Cakes";
                f3.label3.Text = "Folded Egg";
                f3.label4.Text = "Pasteurized Process American Cheese";
                f3.label5.Text = "Thick Cut Applewood Smoked Bacon";
                f3.label6.Text = "Clarified Butter";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 239))//6.4
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add6.4\t-mcdonalds-McChicken.jpg");
                f3.foodname_lbl.Text = "McChicken®";
                f3.cal_lbl.Text = "400 Cal.";
                f3.about_lbl.Text = "It’s a classic for a reason. Savor the satisfying crunch of our juicy chicken patty, topped with shredded lettuce and just "  +
                "the right amount of creamy mayonnaise, all served on a perfectly toasted bun.* The McChicken® has 400 calories. Get your McChicken® at the drive" +
                " thru or with McDonald's Curbside pickup when you Mobile Order & Pay! McDonald's App download and registration required.";
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add6.4\mcchicken.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add5.2\regular_bun.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\bigmac\shredded_lettuce.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add4.2\mayonnaise.png");
                f3.label1.Text = "Ingredients in the McChicken®";
                f3.label2.Text = "";
                f3.label3.Text = "McChicken Patty";
                f3.label4.Text = "Regular Bun";
                f3.label5.Text = "Shredded Lettuce";
                f3.label6.Text = "Mayonnaise";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 315))//6.5
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add6.5\h-spicy-crispy-chicken-sandwich-meal-combo.jpg");
                f3.foodname_lbl.Text = "Spicy Crispy Chicken Sandwich Combo Meal";
                f3.cal_lbl.Text = "980 Cal.";
                f3.about_lbl.Text = "Our new combo meal is for those who like it crispy, juicy, tender and hot. McDonald’s new Spicy Crispy Chicken Sandwich features" +
                " southern style fried chicken served on a new toasted potato roll and topped with a spicy pepper sauce for those who crave a lil’ heat. Get the "     +
                "combo meal with our World Famous Fries® and a medium Sweet Tea. There are 1010 calories in a Spicy Crispy Chicken Sandwich meal with a medium "       +
                "Sweet Tea and medium Fries.";
                f3.label1.Text = "";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = false;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 391))//6.6
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add6.6\t-mcdonalds-Strawberry-McCafe-Shake-Medium.jpg");
                f3.foodname_lbl.Text = "Strawberry Shake";
                f3.cal_lbl.Text = "620 Cal.";
                f3.about_lbl.Text = "McDonald's Strawberry Shake is made with creamy vanilla soft serve, blended with strawberry syrup and topped with whipped "       +
                "topping. There are 530 calories in a small Strawberry Shake at McDonald's. Available in small, medium, and large. Get your Strawberry Shake through " +
                "the drive thru or with McDonald's curbside pickup when you Mobile Order & Pay! McDonald's App download and registration required.";
                f3.label1.Text = "Ingredients in the Strawberry Shake";
                f3.label2.Text = "";
                f3.label3.Text = "Vanilla Reduced Fat Ice Cream";
                f3.label4.Text = "Strawberry Shake Syrup";
                f3.label5.Text = "Whipped Light Cream";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add4.6\vanilla_reduced_fat_cream.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add6.6\t-mcdonalds-strawberry-syrup.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add4.6\whipped_cream.png");
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 543))//6.8
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add6.8\t-mcdonalds-McCafe-Mocha-Medium.jpg");
                f3.foodname_lbl.Text = "Mocha";
                f3.cal_lbl.Text = "380 Cal.";
                f3.about_lbl.Text = "Our McCafé® Mocha latte recipe is made with espresso beans that are sustainably sourced from Rainforest Alliance Certified™ " +
                "farms, steamed whole milk, chocolate syrup, and topped with whipped topping and chocolate drizzle. Enjoy this hot mocha treat, full of earthy "   +
                "chocolaty flavor and rich creaminess. Available in small, medium and large. There are 300 calories in a small McDonald's Mocha latte with whole " +
                "milk. Try one today with Mobile Order & Pay or get it with McDelivery®!";
                f3.label1.Text = "";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = false;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
        }



        public void add7()
        {
            if (panel6.Location == new Point(0, 11))//7.1
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add7.1\t-mcdonalds-Iced-Tea-Large-drink.jpg");
                f3.foodname_lbl.Text = "Sweet Tea";
                f3.cal_lbl.Text = "100 Cal.";
                f3.about_lbl.Text = "McDonald’s Sweet Tea is made from a briskly refreshing blend of orange pekoe and pekoe cut black tea, sweetened to perfection." +
                " Sweet Tea from McDonald’s is part of the Beverages Menu. Available in extra small, small, medium and large.";
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add7.1\default.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add7.1\default.png");
                f3.label1.Text = "Ingredients in the Sweet Tea";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "Brewed Tea";
                f3.label5.Text = "Ice";
                f3.label6.Text = "Medium Invert Sugar";
                f3.label7.Text = "";
                f3.radioButton1.Text = "XS";
                f3.radioButton2.Text = "S";
                f3.radioButton3.Text = "M";
                f3.radioButton4.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = true;
                f3.size_lbl.Visible = true;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 87))//7.2
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add7.2\t-mcdonalds-Cheeseburger.jpg");
                f3.foodname_lbl.Text = "Cheeseburger";
                f3.cal_lbl.Text = "300 Cal.";
                f3.about_lbl.Text = "Our simple, classic cheeseburger begins with a 100% pure beef burger seasoned with just a pinch of salt and pepper. The "   +
                "McDonald’s Cheeseburger is topped with a tangy pickle, chopped onions, ketchup, mustard, and a slice of melty American cheese. It contains no " +
                "artificial flavors, preservatives or added colors from artificial sources.* Our pickle contains an artificial preservative, so skip it if you " +
                "like. For more delicious burger variations explore the McDonald’s burger menu.";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add5.2\regular_bun.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\bigmac\10_1_patty.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\bigmac\pickles.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add2.2\ketchup.png");
                f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add2.2\slivered_onions.png");
                f3.label1.Text = "Ingredients in the Cheeseburger";
                f3.label2.Text = "Regular Bun";
                f3.label3.Text = "100% Beef Patty";
                f3.label4.Text = "Pasteurized Process American Cheese";
                f3.label5.Text = "Pickle Slices";
                f3.label6.Text = "Ketchup";
                f3.label7.Text = "Onions";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = true;
            }
            else if (panel6.Location == new Point(0, 163))//7.3
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add7.3\t-mcdonalds-Sausage-Egg-Cheese-McGriddles.jpg");
                f3.foodname_lbl.Text = "Sausage, Egg & Cheese McGriddles®";
                f3.cal_lbl.Text = "550 Cal.";
                f3.about_lbl.Text = "Sausage, Egg & Cheese McGriddles® feature soft, warm griddle cakes—with the sweet taste of maple—that hold a fluffy folded egg," +
                " savory sausage, and melty American cheese. McGriddles® cakes have no artificial preservatives or flavors and no colors from artificial sources. "   +
                "There are 550 calories in a Sausage, Egg, and Cheese McGriddles®. Pick up on your terms through the drive thru or with McDonald's curbside pickup"   +
                " when you Mobile Order & Pay! McDonald's App download and registration required.";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add6.3\McGriddles_top.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.3\folded_egg.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add3.3\sausage.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.3\clarified_butter.png");
                f3.label1.Text = "Ingredients in the Sausage, Egg & Cheese McGriddles®";
                f3.label2.Text = "Griddle Cakes";
                f3.label3.Text = "Folded Egg";
                f3.label4.Text = "Sausage Patty";
                f3.label5.Text = "Pasteurized Process American Cheese";
                f3.label6.Text = "Clarified Butter";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 239))//add7.4
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add7.4\t-mcdonalds-Filet-O-Fish.jpg");
                f3.foodname_lbl.Text = "Filet-O-Fish®";
                f3.cal_lbl.Text = "380 Cal.";
                f3.about_lbl.Text = "Dive into our wild-caught Filet-O-Fish®! This McDonald’s fish sandwich has fish sourced from sustainably managed fisheries,"   +
                " on melty American cheese and topped with creamy McDonald’s tartar sauce, all served on a soft, steamed bun. There are 380 calories in McDonald's" +
                " Filet-O-Fish. Learn what kind of fish is in Filet-O-Fish®!";
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add7.4\fish.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add5.2\regular_bun.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add7.4\tartar_sauce.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add7.4\american_cheese_half.png");
                f3.label1.Text = "Ingredients in the Filet-O-Fish®";
                f3.label2.Text = "";
                f3.label3.Text = "Fish Filet Patty";
                f3.label4.Text = "Regular Bun";
                f3.label5.Text = "Tartar Sauce";
                f3.label6.Text = "Pasteurized Process American Cheese Half Slice";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 315))//7.5
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add7.5\h-deluxe-crispy-chicken-sandwich-meal.jpg");
                f3.foodname_lbl.Text = "Deluxe Crispy Chicken Sandwich Combo Meal";
                f3.cal_lbl.Text = "1050 Cal.";
                f3.about_lbl.Text = "Take crispy, juicy and tender to the next level with our Deluxe Crispy Chicken Sandwich combo meal. Part of McDonald’s chicken"   +
                " sandwich lineup, it features shredded lettuce, Roma tomatoes and mayo topping southern style fried chicken. The combo meal is served with our World" +
                " Famous Fries® and your choice of an icy soft drink. There are 1050 calories in a Deluxe Crispy Chicken Sandwich meal with a medium Sprite® and "     +
                "medium Fries.";
                f3.label1.Text = "";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = false;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 391))//7.6
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add7.6\t-mcdonalds-Hot-Fudge-Sundae.jpg");
                f3.foodname_lbl.Text = "Hot Fudge Sundae";
                f3.cal_lbl.Text = "330 Cal.";
                f3.about_lbl.Text = "Our classic hot fudge sundae is made with creamy vanilla soft serve and smothered in chocolaty hot fudge topping. There are 330" +
                " calories in a Hot Fudge Sundae at McDonald's. Order one today with Mobile Order & Pay!";
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add2.6\vanilla_reduced_fat_cream.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add7.6\chocolate_sauce.png");
                f3.label1.Text = "Ingredients in the Hot Fudge Sundae";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "Vanilla Reduced Fat Ice Cream";
                f3.label5.Text = "Hot Fudge Topping";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 543))//7.8
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add7.8\t-mcdonalds-McCafe-Iced-Mocha-Medium.jpg");
                f3.foodname_lbl.Text = "Iced Mocha";
                f3.cal_lbl.Text = "320 Cal.";
                f3.about_lbl.Text = "Made with sustainably sourced espresso beans from Rainforest Alliance Certified™ farms, our refreshingly cool Iced Mocha "   +
                "latte is made with whole milk, chocolate syrup, and topped with whipped topping and chocolate drizzle. Refresh and relax with this iced mocha "  +
                "treat full of chocolaty flavor and rich creaminess. Available in small, medium and large. Pick up on your terms through the drive thru or with " +
                "McDonald's curbside pickup when you Mobile Order & Pay! McDonald's App download and registration required.";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add1.8\Whole-Milk.jpg");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add4.6\chocolate_shake_syrup.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add1.8\water.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add4.6\whipped_cream.png");
                f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add1.8\espresso.png");
                f3.label1.Text = "Ingredients in the Iced Mocha";
                f3.label2.Text = "Whole Milk";
                f3.label3.Text = "Ice";
                f3.label4.Text = "Chocolate Syrup";
                f3.label5.Text = "Water";
                f3.label6.Text = "Whipped Light Cream";
                f3.label7.Text = "Espresso";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = true;
            }
        }



        public void add8()
        {
            if (panel6.Location == new Point (0, 11))//8.1
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add8.1\t-mcdonalds-Iced-Tea-Large-unsweetened.jpg");
                f3.foodname_lbl.Text = "Unsweetened Iced Tea";
                f3.cal_lbl.Text = "0 Cal.";
                f3.about_lbl.Text = "McDonald’s Iced Tea is made with a brisk blend of orange pekoe black tea, freshly brewed and served ice cold. McDonald’s " +
                "Unsweet Iced Tea is available in extra small, small, medium and large on the McDonald’s drinks menu.";
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add7.1\default.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                f3.label1.Text = "Ingredients in the Unsweetened Iced Tea";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "Brewed Tea";
                f3.label5.Text = "Ice";
                f3.label7.Text = "";
                f3.radioButton1.Text = "XS";
                f3.radioButton2.Text = "S";
                f3.radioButton3.Text = "M";
                f3.radioButton4.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = true;
                f3.size_lbl.Visible = true;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 87))//8.2
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add8.2\t-mcdonalds-Double-Cheeseburger.jpg");
                f3.foodname_lbl.Text = "Double Cheeseburger";
                f3.cal_lbl.Text = "450 Cal.";
                f3.about_lbl.Text = "The McDonald's Double Cheeseburger features two 100% pure beef burger patties seasoned with just a pinch of salt and pepper. "   +
                "It's topped with tangy pickles, chopped onions, ketchup, mustard and two slices of melty American cheese. There are 450 calories in a McDonald's"    +
                " Double Cheeseburger. It contains no artificial flavors, preservatives or added colors from artificial sources.* Our pickle contains an artificial"  +
                " preservative, so skip it if you like. Pick up on your terms through the drive thru or with McDonald's curbside pickup when you Mobile Order & Pay!" +
                " McDonald's App download and registration required.";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add5.2\regular_bun.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\bigmac\10_1_patty.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\bigmac\pickles.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add2.2\ketchup.png");
                f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add2.2\slivered_onions.png");
                f3.label1.Text = "Ingredients in the Double Cheeseburger";
                f3.label2.Text = "Regular Bun";
                f3.label3.Text = "100% Beef Patty";
                f3.label4.Text = "Pasteurized Process American Cheese";
                f3.label5.Text = "Pickle Slices";
                f3.label6.Text = "Ketchup";
                f3.label7.Text = "Onions";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = true;
            }
            else if (panel6.Location == new Point(0, 163))//8.3
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add8.3\s-mcdonalds-Big-Breakfast-Regular-Size-Biscuit.jpg");
                f3.foodname_lbl.Text = "Big Breakfast®";
                f3.cal_lbl.Text = "760 Cal.";
                f3.about_lbl.Text = "Our full, satisfying Big Breakfast® is perfect for any morning. Wake up to a breakfast meal with a warm biscuit, fluffy "      +
                "scrambled eggs, savory McDonald's sausage, and crispy golden hash browns. There are 750 calories in Big Breakfast® at McDonald's. Want it quick? " +
                "Use the McDonald’s App to Mobile Order & Pay!";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add8.3\scrambled_eggs.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.3\biscuit.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add8.3\hash_brown.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add3.3\sausage.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.3\clarified_butter.png");
                f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add1.3\butter_salted.png");
                f3.label1.Text = "Ingredients in the Big Breakfast®";
                f3.label2.Text = "Scrambled Eggs";
                f3.label3.Text = "Biscuit";
                f3.label4.Text = "Hash Browns";
                f3.label5.Text = "Sausage Patty";
                f3.label6.Text = "Clarified Butter";
                f3.label7.Text = "Salted Butter";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = true;
            }
            else if (panel6.Location == new Point(0, 315))//8.5
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add8.5\h-mcdonalds-Chicken-McNuggets-10-piece-Extra-Value-Meals.jpg");
                f3.foodname_lbl.Text = "10 piece Chicken McNuggets® Meal";
                f3.cal_lbl.Text = "950 Cal.";
                f3.about_lbl.Text = "The McDonald's 10 piece Chicken McNuggets® Combo Meal features 10 tender and delicious Chicken McNuggets® made with all "  +
                "white meat chicken—plus our World Famous Fries® and your choice of a Medium McDonald’s drink. There are 950 calories in a Chicken McNuggets® " +
                "Combo Meal with medium Fries and a medium Coca-Cola®. Get it today when you Mobile Order &Pay or get it delivered with McDelivery®.";
                f3.label1.Text = "";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = false;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 391))//8.6
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add8.6\t-mcdonalds-Hot-Caramel-Sundae.jpg");
                f3.foodname_lbl.Text = "Hot Caramel Sundae";
                f3.cal_lbl.Text = "330 Cal.";
                f3.about_lbl.Text = "Treat yourself to a Hot Caramel Sundae at McDonald's! This Caramel Sundae combines creamy vanilla soft serve and warm, " +
                "buttery caramel topping. Order it to complete your McDonald's meal using Mobile Order & Pay!";
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add2.6\vanilla_reduced_fat_cream.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add8.6\caramel_sauce.png");
                f3.label1.Text = "Ingredients in the Hot Caramel Sundae";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "Vanilla Reduced Fat Ice Cream";
                f3.label5.Text = "Caramel Topping";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 543))//8.8
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add8.8\t-mcdonalds-McCafe-Latte-Medium.jpg");
                f3.foodname_lbl.Text = "Latte";
                f3.cal_lbl.Text = "190 Cal.";
                f3.about_lbl.Text = "Our McCafé® Latte is made from Rainforest Alliance Certified™ espresso and steamed milk. Customize the Latte that’s made " +
                "fresh just for you with whole or nonfat milk, mixed with your choice of flavor at certain locations. Available in small, medium and large. "   +
                "There are 140 calories in a small latte with whole milk at McDonald's. Enjoy one today using Mobile Order & Pay or get it delivered with McDelivery®!";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add1.8\Whole-Milk.jpg");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.8\water.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add1.8\espresso.png");
                f3.label1.Text = "";
                f3.label2.Text = "Whole Milk";
                f3.label3.Text = "Water";
                f3.label4.Text = "Espresso";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
        }



        public void add9()
        {
            if (panel6.Location == new Point(0, 11))//9.1
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add9.1\t-mcdonalds-Dasani-Water.jpg");
                f3.foodname_lbl.Text = "DASANI® Water";
                f3.cal_lbl.Text = "0 Cal.";
                f3.about_lbl.Text = "DASANI is purified water enhanced with minerals for a pure, fresh taste.";
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add7.1\default.png");
                f3.label1.Text = "Ingredients in the DASANI® Water";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "Dasani Water";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 87))//9.2
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add9.2\t-mcdonalds-Hamburger.jpg");
                f3.foodname_lbl.Text = "Hamburger";
                f3.cal_lbl.Text = "250 Cal.";
                f3.about_lbl.Text = "The original burger starts with a 100% pure beef burger seasoned with just a pinch of salt and pepper. Then, the McDonald’s"   +
                " burger is topped with a tangy pickle, chopped onions, ketchup and mustard. McDonald’s hamburger contains no artificial flavors, preservatives or" +
                " added colors from artificial sources.* Our pickle contains an artificial preservative, so skip it if you like.";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add5.2\regular_bun.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\bigmac\10_1_patty.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add2.2\ketchup.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\bigmac\pickles.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add2.2\slivered_onions.png");
                f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add2.2\mustard.png");
                f3.label1.Text = "Ingredients in the Hamburger";
                f3.label2.Text = "Regular Bun";
                f3.label3.Text = "100% Beef Patty";
                f3.label4.Text = "Ketchup";
                f3.label5.Text = "Pickle Slices";
                f3.label6.Text = "Onions";
                f3.label7.Text = "Mustard";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = true;
            }
            else if (panel6.Location == new Point(0, 163))//9.3
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add9.3\t-mcdonalds-Big-Breakfast-with-Hotcakes-Regular-Size-Biscuit.jpg");
                f3.foodname_lbl.Text = "Big Breakfast® with Hotcakes";
                f3.cal_lbl.Text = "1340 Cal.";
                f3.about_lbl.Text = "McDonald’s Big Breakfast® with Hotcakes satisfies with both sweet and savory breakfast favorites. Fill up with a warm biscuit,"  +
                " savory hot sausage, fluffy scrambled eggs, crispy hash browns, and golden brown hotcakes with a side of real butter and the sweet flavor of maple." +
                " There are 1,340 calories in McDonald's Big Breakfast with Hotcakes. Want to pass the line? Use the McDonald’s App to Mobile Order & Pay! Looking"   +
                " for McDonald's delivery? Order a McDonald's Big Breakfast® with Hotcakes using McDelivery®!";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add9.3\hotcake.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add8.3\scrambled_eggs.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add1.3\biscuit.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add9.3\hotcake_syrup.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add8.3\hash_brown.png");
                f3.pictureBox7.Image = Image.FromFile(Application.StartupPath + @"\add3.3\sausage.png");
                f3.label1.Text = "Ingredients in the Big Breakfast® with Hotcakes";
                f3.label2.Text = "Hotcakes";
                f3.label3.Text = "Scrambled Eggs";
                f3.label4.Text = "Biscuit";
                f3.label5.Text = "Hotcake Syrup";
                f3.label6.Text = "Hash Browns";
                f3.label7.Text = "Sausage Patty";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = true;
            }
            else if (panel6.Location == new Point(0, 315))//9.5
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add9.5\h-mcdonalds-Filet-O-Fish-Extra-Value-Meals.jpg");
                f3.foodname_lbl.Text = "Filet-O-Fish® Meal";
                f3.cal_lbl.Text = "900 Cal.";
                f3.about_lbl.Text = "Our Filet-O-Fish combo meal is a classic fish sandwich meal made with wild-caught Alaskan Pollock on a regular McDonald’s bun,"   +
                " served with our World Famous Fries® and your choice of an icy soft drink. There are 900 calories in a Filet-O-Fish Meal at McDonald’s with a medium" +
                " Sprite® and medium French Fries. Enjoy a Filet-O-Fish® Meal today using Mobile Order & Pay or get it delivered with McDelivery®!";
                f3.label1.Text = "";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = false;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 391))//9.6
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add9.6\t-mcdonalds-Baked-Hot-Apple-Pie.jpg");
                f3.foodname_lbl.Text = "Baked Apple Pie";
                f3.cal_lbl.Text = "230 Cal.";
                f3.about_lbl.Text = "McDonald's Baked Apple Pie recipe features 100% American-grown apples, and a lattice crust baked to perfection and topped "     +
                "with sprinkled sugar. There are 240 calories in McDonald's apple pie. Pair it with a Hot Caramel Sundae for your own twist on Apple Pie A-La-Mode!" +
                " Order a Baked Apple Pie today and get it curbside with Mobile Order & Pay! Get it delivered with McDelivery®!";
                f3.label1.Text = "";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = false;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 543))//9.8
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add9.8\t-mcdonalds-iced-latte.jpg");
                f3.foodname_lbl.Text = "Iced Latte";
                f3.cal_lbl.Text = "120 Cal.";
                f3.about_lbl.Text = "Cool down with a cold McCafé® Iced Latte, made from Rainforest Alliance Certified™ espresso. Customize an Iced Latte that’s " +
                "made fresh just for you with cold whole or nonfat milk, mixed with your choice of flavor at certain locations. Available in small, medium, and "  +
                "large. There are 120 calories in a medium McCafé® Iced Latte with whole milk. Get one today with McDelivery® or get it with curbside pickup "     +
                "using Mobile Order & Pay!";
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add1.8\Whole-Milk.jpg");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add1.8\water.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.8\espresso.png");
                f3.label1.Text = "Ingredients in the McCafé® Iced Latte";
                f3.label2.Text = "";
                f3.label3.Text = "Whole Milk";
                f3.label4.Text = "Ice";
                f3.label5.Text = "Water";
                f3.label6.Text = "Espresso";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = false;
            } 
        }



        public void add10()
        {
            if (panel6.Location == new Point(0, 11))//10.1
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add10.1\t-mcdonalds-Minute-Maid-Orange-Juice-Medium.jpg");
                f3.foodname_lbl.Text = "Minute Maid® Premium Orange Juice";
                f3.cal_lbl.Text = "190 Cal.";
                f3.about_lbl.Text = "100% orange juice, packed with Vitamin C. Available in Small, Medium and Large.";
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add7.1\default.png");
                f3.label1.Text = "Ingredients in the Minute Maid® Premium Orange Juice";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "Minute Maid 100% Orange Juice";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 163))//10.3
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add10.3\t-mcdonalds-Hotcakes.jpg");
                f3.foodname_lbl.Text = "Big Breakfast® with Hotcakes";
                f3.cal_lbl.Text = "1340 Cal.";
                f3.about_lbl.Text = "McDonald’s Big Breakfast® with Hotcakes satisfies with both sweet and savory breakfast favorites. Fill up with a warm biscuit,"  +
                " savory hot sausage, fluffy scrambled eggs, crispy hash browns, and golden brown hotcakes with a side of real butter and the sweet flavor of maple." +
                " There are 1,340 calories in McDonald's Big Breakfast with Hotcakes. Want to pass the line? Use the McDonald’s App to Mobile Order & Pay! Looking "  +
                "for McDonald's delivery? Order a McDonald's Big Breakfast® with Hotcakes using McDelivery®!";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add9.3\hotcake.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add9.3\hotcake_syrup.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add1.3\butter_salted.png");
                f3.label1.Text = "Ingredients in the Hotcakes";
                f3.label2.Text = "Hotcakes";
                f3.label3.Text = "Hotcake Syrup";
                f3.label4.Text = "Salted Whipped Butter";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 315))//10.5
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add10.5\h-mcdonalds-Egg-McMuffin-Extra-Value-Meals.jpg");
                f3.foodname_lbl.Text = "Egg McMuffin® Meal";
                f3.cal_lbl.Text = "450 Cal.";
                f3.about_lbl.Text = "Get more for breakfast with the McDonald’s Egg McMuffin® Meal. This McDonald’s breakfast meal features an Egg McMuffin®, "    +
                "crispy McDonald’s hash browns, and a small McCafé® Premium Roast Coffee– everything you need to start the day off right! There are 450 calories"  +
                " in an Egg McMuffin Meal at McDonald's with a small Coffee and Hash Browns. Get this McDonald's breakfast meal today with McDelivery® or get it " +
                "curbside using Mobile Order & Pay!";
                f3.label1.Text = "";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = false;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 391))//10.6
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add10.6\t-mcdonalds-Chocolate-Chip-Cookie-mcd.jpg");
                f3.foodname_lbl.Text = "Chocolate Chip Cookie";
                f3.cal_lbl.Text = "170 Cal.";
                f3.about_lbl.Text = "McDonald's classic chocolate chip cookie, loaded with chocolate chips. It's a soft baked cookie and warmed to perfection. " +
                "Treat yourself today using Mobile Order & Pay.";
                f3.label1.Text = "";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = false;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 543))//10.8
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add10.8\t-mcdonalds-americano.jpg");
                f3.foodname_lbl.Text = "Americano";
                f3.cal_lbl.Text = "0 Cal.";
                f3.about_lbl.Text = "A simple, satisfying Americano made with hot water poured over our Rainforest Alliance Certified™ espresso.";
                f3.label1.Text = "";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = false;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
        }


        public void add11()
        {
            if (panel6.Location == new Point(0, 11))//11.1
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add11.1\t-mcdonalds-Strawberry-Banana-Smoothie-Medium.jpg");
                f3.foodname_lbl.Text = "Strawberry Banana Smoothie";
                f3.cal_lbl.Text = "240 Cal.";
                f3.about_lbl.Text = "The McCafé® Strawberry Banana Smoothie recipe features the perfect combination of fruit purees and fruit juices, such as " +
                "strawberry and banana, blended with creamy low fat yogurt and ice. Our Strawberry Banana Smoothie is available in small, medium and large. "   +
                "There are 240 calories in a medium McDonald's strawberry banana smoothie. Order one today using Mobile Order & Pay!";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add11.1\strawberry_fruit_base.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add11.1\lowfat_smoothie_yogurt.png");
                f3.label1.Text = "Ingredients in the Strawberry Banana Smoothie";
                f3.label2.Text = "Strawberry Banana Fruit Base";
                f3.label3.Text = "Ice";
                f3.label4.Text = "Lowfat Smoothie Yogurt";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 163))//11.3
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add11.3\t-mcdonalds-Sausage-Burrito.jpg");
                f3.foodname_lbl.Text = "Sausage Burrito";
                f3.cal_lbl.Text = "310 Cal.";
                f3.about_lbl.Text = "The Sausage Burrito is McDonald's Breakfast Burrito and is loaded with fluffy scrambled egg, pork sausage, melty cheese,"  +
                " green chiles and onion! It's wrapped in a soft tortilla, making it the perfect grab and go breakfast. There are 310 calories in a McDonald's" +
                " sausage burrito. Order a McDonald's Sausage Burrito using the McDonald's App to Mobile Order & Pay! Download the McDonald’s app and earn "    +
                "points on every order with MyMcDonald's Rewards to redeem for a free Sausage Burrito.^";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add11.3\scrambled_egg_mix.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add11.3\tortilla.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\bigmac\ingredient_american_cheese_180x180.png");
                f3.label1.Text = "Ingredients in the Sausage Burrito";
                f3.label2.Text = "Scrambled Egg Sausage And Vegetable Mix";
                f3.label3.Text = "Flour Tortilla";
                f3.label4.Text = "Pasteurized Process American Cheese";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 315))//11.5
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add11.5\h-mcdonalds-Sausage-McMuffin-with-Egg-Extra-Value-Meals.jpg");
                f3.foodname_lbl.Text = "Sausage McMuffin® with Egg Meal";
                f3.cal_lbl.Text = "620 Cal.";
                f3.about_lbl.Text = "Wake up to a Sausage McMuffin® with Egg Meal for breakfast, served with crispy golden Hash Browns and a small Premium " +
                "Roast Coffee. There are 620 calories in a Sausage McMuffin® with Egg Meal at McDonald's. Order it today with Mobile Order & Pay on the "    +
                "McDonald's App!";
                f3.label1.Text = "";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = false;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 543))//11.8
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add11.8\t-mcdonalds-Frappe-Caramel-Medium.jpg");
                f3.foodname_lbl.Text = "Caramel Frappé";
                f3.cal_lbl.Text = "510 Cal.";
                f3.about_lbl.Text = "McDonald's Caramel Frappé recipe is made with rich caramel flavor and a hint of coffee, blended with ice, and topped "   +
                "with whipped topping and caramel drizzle. Available in Small, Medium, and Large. There are 420 calories in a small Caramel Frappé. Order a " +
                "Caramel Frappé using Mobile Order & Pay!";
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add11.8\caramel_frappe_base.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add4.6\whipped_cream.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add1.8\caramel_drizzle.png");
                f3.label1.Text = "Ingredients in the Caramel Frappé";
                f3.label2.Text = "";
                f3.label3.Text = "Ice";
                f3.label4.Text = "Caramel Coffee Frappe Base";
                f3.label5.Text = "Whipped Light Cream";
                f3.label6.Text = "Caramel Drizzle";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = false;
            }
        }


        public void add12()
        {
            if (panel6.Location == new Point(0, 11))//12.1
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add12.1\t-mcdonalds-Mango-Pineapple-Smoothie-Small.jpg");
                f3.foodname_lbl.Text = "Mango Pineapple Smoothie";
                f3.cal_lbl.Text = "250 Cal.";
                f3.about_lbl.Text = "The McDonald’s Mango Pineapple Smoothie recipe features the sweet combination of fruit juices and purees such as mango and" +
                " pineapple, blended with creamy low fat yogurt and ice. Find all our smoothies on the McCafé® Menu in small, medium and large. There are 250 "  +
                "calories in a small mango pineapple smoothie at McDonald's. Get one today with Mobile Order & Pay!";
                f3.pictureBox2.Image = Image.FromFile(Application.StartupPath + @"\add12.1\mango_fruit_base.png");
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add11.1\lowfat_smoothie_yogurt.png");
                f3.label1.Text = "Ingredients in the Mango Pineapple Smoothie";
                f3.label2.Text = "Mango Pineapple Fruit Base";
                f3.label3.Text = "Ice";
                f3.label4.Text = "Lowfat Smoothie Yogurt";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox2.Visible = true;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 163))//12.3
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add12.3\t-mcdonalds-Fruit-Maple-Oatmeal.jpg");
                f3.foodname_lbl.Text = "Fruit & Maple Oatmeal";
                f3.cal_lbl.Text = "320 Cal.";
                f3.about_lbl.Text = "Our Fruit and Maple Oatmeal has two full servings of whole-grain oats with a touch of cream and brown sugar. Loaded with red" +
                " and green apples, cranberries and two varieties of raisins, our oatmeal makes for a hearty, wholesome breakfast of whole grains and fruit. "     +
                "There are 320 calories in a McDonald's Fruit and Maple Oatmeal. Pair it with a McCafé® Premium Roast Coffee to complete your meal. Enjoy oatmeal" +
                " for breakfast with Mobile Order & Pay or get it delivered with McDelivery®!";
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add12.3\oatmeal.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\add12.3\diced_apples.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add12.3\cranberry_raisin.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add12.3\light_cream.png");
                f3.label1.Text = "Ingredients in the Fruit & Maple Oatmeal";
                f3.label2.Text = "";
                f3.label3.Text = "Oatmeal";
                f3.label4.Text = "Diced Apples";
                f3.label5.Text = "Cranberry Raisin Blend";
                f3.label6.Text = "Light Cream";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 315))//12.5
            {
                f3.about_lbl.Height = 235;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add12.5\h-mcdonalds-Sausage-Biscuit-with-Egg-Extra-Value-Meals.jpg");
                f3.foodname_lbl.Text = "Sausage Biscuit with Egg Meal";
                f3.cal_lbl.Text = "670 Cal.";
                f3.about_lbl.Text = "McDonald's Sausage Biscuit with Egg Meal includes a flaky biscuit sandwich with McDonald's folded egg and a pork sausage "   +
                "patty. There are 670 calories in a Sausage Biscuit with Egg Meal with crispy McDonald's hash browns and a small McCafé® Premium Roast Coffee at" +
                " McDonald's. Start your day with this McDonald's breakfast meal and satisfy your morning hunger! Get one today with Mobile Order & Pay or get"   +
                " it delivered with McDelivery®!";
                f3.label1.Text = "";
                f3.label2.Text = "";
                f3.label3.Text = "";
                f3.label4.Text = "";
                f3.label5.Text = "";
                f3.label6.Text = "";
                f3.label7.Text = "";
                f3.radioButton1.Visible = false;
                f3.radioButton2.Visible = false;
                f3.radioButton3.Visible = false;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = false;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = false;
                f3.pictureBox4.Visible = false;
                f3.pictureBox5.Visible = false;
                f3.pictureBox6.Visible = false;
                f3.pictureBox7.Visible = false;
            }
            else if (panel6.Location == new Point(0, 543))//12.8
            {
                f3.about_lbl.Height = 157;
                f3.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\add12.8\t-mcdonalds-Frappe-Mocha-Medium.jpg");
                f3.foodname_lbl.Text = "Mocha Frappé";
                f3.cal_lbl.Text = "500 Cal.";
                f3.about_lbl.Text = "Made with rich chocolate flavor and a hint of coffee, our Mocha Frappé recipe is blended with ice and covered with whipped" +
                " topping and chocolatey drizzle. Available in small, medium and large. There are 500 calories in a small Mocha Frappé. Order a McDonald's "    +
                "Frappé today and pick up on your terms through the drive thru or with McDonald's curbside pickup when you Mobile Order & Pay! McDonald's App"  +
                " download and registration required.";
                f3.pictureBox3.Image = Image.FromFile(Application.StartupPath + @"\add4.6\chocolate_shake_syrup.png");
                f3.pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\Cola\t-mcdonalds-ice.png");
                f3.pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\add4.6\whipped_cream.png");
                f3.pictureBox6.Image = Image.FromFile(Application.StartupPath + @"\add12.8\chocolate_drizzle.png");
                f3.label1.Text = "Ingredients in the Mocha Frappé";
                f3.label2.Text = "";
                f3.label3.Text = "Mocha Coffee Frappe Base";
                f3.label4.Text = "Ice";
                f3.label5.Text = "Whipped Light Cream";
                f3.label6.Text = "Chocolate Drizzle";
                f3.label7.Text = "";
                f3.radioButton1.Text = "S";
                f3.radioButton2.Text = "M";
                f3.radioButton3.Text = "L";
                f3.radioButton1.Visible = true;
                f3.radioButton2.Visible = true;
                f3.radioButton3.Visible = true;
                f3.radioButton4.Visible = false;
                f3.size_lbl.Visible = true;
                f3.pictureBox2.Visible = false;
                f3.pictureBox3.Visible = true;
                f3.pictureBox4.Visible = true;
                f3.pictureBox5.Visible = true;
                f3.pictureBox6.Visible = true;
                f3.pictureBox7.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            add3();
            form3open();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            add3();
            form3open();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            add4();
            form3open();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            add4();
            form3open();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            add8();
            form3open();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            add9();
            form3open();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            add9();
            form3open();
        }

        private void pictureBox21_Click_1(object sender, EventArgs e)
        {
            add10();
            form3open();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            add10();
            form3open();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            add11();
            form3open();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            add11();
            form3open();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            add12();
            form3open();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            add12();
            form3open();
        }
    }
}
