namespace RegistrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int exCounterOfUserNameAndPasswdValidation = 0;

        private void mailTxtIsEmpty()
        {
            /*
             * Əgər mailTxt empty olarkən click edilərsə,
             * mailTxt default text'i göstərəcək.
             */

            if (mailTxt.Text == "")
            {
                mailTxt.ForeColor = Color.Silver;
                mailTxt.Text = "E-mail Address";
            }
        }

        private void mailTxtIsNotEmpty()
        {
            /*
             * Əgər mailTxt default text'i göstərərkən click edilərsə,
             * mailTxt clear olunacaq və text color'i black olacaq.
             */

            if (mailTxt.Text == "E-mail Address")
            {
                mailTxt.ForeColor = Color.Black;
                mailTxt.Clear();
            }
        }

        private void userNameTxtIsEmpty()
        {
            // mailTxtIsEmpty'də ki process'in userNameTxt'ə görə yerinə yetirilir.

            if (userNameTxt.Text == "")
            {
                userNameTxt.ForeColor = Color.Silver;
                userNameTxt.Text = "Username";
            }
        }

        private void userNameTxtIsNotEmpty()
        {
            if (userNameTxt.Text == "Username")
            {
                userNameTxt.ForeColor = Color.Black;
                userNameTxt.Clear();
            }
        }

        private void passwdTxtIsEmpty()
        {
            if (passwdTxt.Text == "")
            {
                passwdTxt.ForeColor = Color.Silver;
                passwdTxt.PasswordChar = '\0';
                passwdTxt.Text = "Password";
            }
        }

        private void passwdTxtIsNotEmpty()
        {
            if (passwdTxt.Text == "Password")
            {
                passwdTxt.ForeColor = Color.Black;
                if (confirmPasswdTxt.ForeColor == Color.Black)
                    passwdTxt.PasswordChar = confirmPasswdTxt.PasswordChar;
                else
                    passwdTxt.PasswordChar = '*';
                passwdTxt.Clear();
            }
        }

        private void confirmPasswdTxtIsEmpty()
        {
            if (confirmPasswdTxt.Text == "")
            {
                confirmPasswdTxt.ForeColor = Color.Silver;
                confirmPasswdTxt.PasswordChar = '\0';
                confirmPasswdTxt.Text = "Confirm Password";
            }
        }

        private void confirmPasswdTxtIsNotEmpty()
        {
            if (confirmPasswdTxt.Text == "Confirm Password")
            {
                confirmPasswdTxt.ForeColor = Color.Black;
                if (passwdTxt.ForeColor == Color.Black)
                    confirmPasswdTxt.PasswordChar = passwdTxt.PasswordChar;
                else
                    confirmPasswdTxt.PasswordChar = '*';
                confirmPasswdTxt.Clear();
            }
        }

        private void showPasswdImgToDefault()
        {
            capsLockImg.Visible = false;
            showPasswdImg.Visible = false;
        }

        private void mailTxt_Click(object sender, EventArgs e)
        {
            mailTxtIsNotEmpty();
            userNameTxtIsEmpty();
            passwdTxtIsEmpty();
            confirmPasswdTxtIsEmpty();
            showPasswdImgToDefault();
        }

        private void userNameTxt_Click(object sender, EventArgs e)
        {
            mailTxtIsEmpty();
            userNameTxtIsNotEmpty();
            passwdTxtIsEmpty();
            confirmPasswdTxtIsEmpty();
            userNameAndPasswdValidation(userNameTxt, "username");
            showPasswdImgToDefault();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * Default Colors: Silver
             * Default mailTxt: E-mail Address
             * Default userNameTxt: Username
             * Default passwdTxt: Password
             * Default confirmPasswdTxt: Confirm Password
             */
            mailTxt.ForeColor = Color.Silver;
            userNameTxt.ForeColor = Color.Silver;
            passwdTxt.ForeColor = Color.Silver;
            confirmPasswdTxt.ForeColor = Color.Silver;
            label1.Select();
            capsLockImg.Visible = false;
            showPasswdImg.Visible = false;
        }

        private void passwdTxt_Click(object sender, EventArgs e)
        {
            mailTxtIsEmpty();
            userNameTxtIsEmpty();
            passwdTxtIsNotEmpty();
            confirmPasswdTxtIsEmpty();
            userNameAndPasswdValidation(passwdTxt, "password");
            capsLockKeyOnOff();
            capsLockImg.Location = new Point(375, 243);
            showPasswdImg.Location = new Point(455, 243);
            showPasswdImg.Visible = true;
        }

        private void confirmPasswdTxt_Click(object sender, EventArgs e)
        {
            mailTxtIsEmpty();
            userNameTxtIsEmpty();
            passwdTxtIsEmpty();
            confirmPasswdTxtIsNotEmpty();
            capsLockKeyOnOff();
            capsLockImg.Location = new Point(375, 343);
            showPasswdImg.Location = new Point(455, 343);
            showPasswdImg.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                if (mailTxt.Text == "" || mailTxt.Text == "E-mail Address" || userNameTxt.Text == "" || userNameTxt.Text == "Username" ||
                    passwdTxt.Text == "" || passwdTxt.Text == "Password" || confirmPasswdTxt.Text == "" || confirmPasswdTxt.Text == "Confirm Password")
                {
                    MessageBox.Show("Please fill in all fields", "RegistrationApp");
                    return;
                }
                mailValidation();
                exCounterOfUserNameAndPasswdValidation = 0;
                userNameAndPasswdValidation(userNameTxt, "username");
                if (exCounterOfUserNameAndPasswdValidation != 0)
                {
                    MessageBox.Show("Username is wrong", "RegistrationApp");
                    return;
                }
                exCounterOfUserNameAndPasswdValidation = 0;
                userNameAndPasswdValidation(passwdTxt, "password");
                if (exCounterOfUserNameAndPasswdValidation != 0)
                {
                    MessageBox.Show("Password is wrong", "RegistrationApp");
                    return;
                }
                if (passwdTxt.Text == confirmPasswdTxt.Text)
                    MessageBox.Show("You have successfully registered", "RegistrationApp");
                else
                    MessageBox.Show("Passwords are different", "RegistrationApp");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RegistrationApp");
            }
        }

        private void mailValidation()
        {
            try
            {
                String mailStr = mailTxt.Text;
                if (mailStr.Contains('@') == false)
                {
                    /*
                     * Əgər mailTxt'də at simvolu yoxdursa mail səhvdir.
                     * Bunu istifadəçiyə bildirikdən sonra return ilə null döndürürük.
                     */

                    MessageBox.Show("Please edit your email address\nNo At sign found in the mail", "RegistrationApp");
                    return;
                }
                int atSignCounter = 0, mailStrLength = mailStr.Length, pointCounter = 0;
                for (int i = 0; i < mailStrLength; i++)
                {
                    if (mailStr[i] == '@')
                        atSignCounter++;
                    if (atSignCounter > 0 && mailStr[i] == '.')
                        pointCounter++;
                }
                if (atSignCounter != 1)
                {
                    /*
                     * Əgər mailTxt'də at simvolu birdən çoxdursa mail səhvdir.
                     */

                    MessageBox.Show("Please edit your email address\nYour email address cannot contain more than one At sign", "RegistrationApp");
                    return;
                }
                if (mailStr.Contains('.') == false)
                {
                    /*
                     * Əgər mailTxt'də nöqtə simvolu at simvolundan sonra yoxdursa mail səhvdir.
                     */

                    MessageBox.Show("Please edit your email address\nNo Point found in the mail", "RegistrationApp");
                    return;
                }
                if (pointCounter != 1)
                {
                    /*
                     * Əgər mailTxt'də nöqtə simvolu at simvolundan sonra birdən çoxdursa mail səhvdir.
                     */

                    MessageBox.Show("Please edit your email address\nYour email address cannot contain more than one Point", "RegistrationApp");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RegistrationApp");
            }
        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {
            userNameAndPasswdValidation(userNameTxt, "username");
        }

        private void userNameAndPasswdValidation(TextBox textbox, String componentFieldName)
        {
            try
            {
                if (textbox.ForeColor == Color.Black)
                {
                    String fieldNameStr = textbox.Text;
                    infoList.Items.Clear();
                    exCounterOfUserNameAndPasswdValidation = 0;
                    int upperCaseCounter = 0, lowerCaseCounter = 0, numCaseCounter = 0, signCaseCounter = 0, fieldNameStrLength = fieldNameStr.Length;
                    for (int i = 0; i < fieldNameStrLength; i++)
                    {
                        if (fieldNameStr[i] > 64 && fieldNameStr[i] < 90)
                            upperCaseCounter++;
                        if (fieldNameStr[i] > 96 && fieldNameStr[i] < 123)
                            lowerCaseCounter++;
                        if (fieldNameStr[i] > 47 && fieldNameStr[i] < 58)
                            numCaseCounter++;
                        if ((fieldNameStr[i] > 32 && fieldNameStr[i] < 48) || (fieldNameStr[i] > 57 && fieldNameStr[i] < 64) ||
                            (fieldNameStr[i] > 90 && fieldNameStr[i] < 97) || (fieldNameStr[i] > 122 && fieldNameStr[i] < 127))
                            signCaseCounter++;
                    }
                    if (fieldNameStrLength > 16 || fieldNameStrLength < 8)
                    {
                        infoList.Items.Add("The " + componentFieldName + " must be between 8-16 characters. ");
                        exCounterOfUserNameAndPasswdValidation++;
                        return;
                    }
                    if (upperCaseCounter == 0)
                    {
                        infoList.Items.Add("The " + componentFieldName + " must contain uppercase letters. ");
                        exCounterOfUserNameAndPasswdValidation++;
                    }
                    if (lowerCaseCounter == 0)
                    {
                        infoList.Items.Add("The " + componentFieldName + " must contain lowercase letters. ");
                        exCounterOfUserNameAndPasswdValidation++;
                    }
                    if (numCaseCounter == 0)
                    {
                        infoList.Items.Add("The " + componentFieldName + " must contain a digit. ");
                        exCounterOfUserNameAndPasswdValidation++;
                    }
                    if (signCaseCounter == 0)
                    {
                        infoList.Items.Add("The " + componentFieldName + " must contain a character. ");
                        exCounterOfUserNameAndPasswdValidation++;
                    }
                }
                else
                    infoList.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RegistrationApp");
            }
        }

        private void passwdTxt_TextChanged(object sender, EventArgs e)
        {
            userNameAndPasswdValidation(passwdTxt, "password");
        }

        private void confirmPasswdTxt_TextChanged(object sender, EventArgs e)
        {
            infoList.Items.Clear();
            if (confirmPasswdTxt.Text != passwdTxt.Text)
                infoList.Items.Add("Passwords are different.");
        }

        private void capsLockKeyOnOff()
        {
            /*
             * Əgər CapsLock klavişi sıxılarsa capsLockImg istifədəçiyə əks etdirələcək.
             */
             
            if (Control.IsKeyLocked(Keys.CapsLock))
                capsLockImg.Visible = true;
            else
                capsLockImg.Visible = false;
        }

        private void passwdTxt_KeyDown(object sender, KeyEventArgs e)
        {
            capsLockKeyOnOff();
            if (e.KeyCode == Keys.Enter)
                label1_Click(1, e);
        }

        private void confirmPasswdTxt_KeyDown(object sender, KeyEventArgs e)
        {
            capsLockKeyOnOff();
            if (e.KeyCode == Keys.Enter)
                label1_Click(1, e);
        }

        private void mailTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                label1_Click(1, e);
        }
        
        private void showPasswdImg_Click(object sender, EventArgs e)
        {
            if (passwdTxt.PasswordChar == '*' || confirmPasswdTxt.PasswordChar == '*')  //Show password
            {
                if (passwdTxt.ForeColor == Color.Silver)
                {
                    passwdTxt.Clear();
                    passwdTxt.ForeColor = Color.Black;
                }
                if (confirmPasswdTxt.ForeColor == Color.Silver)
                {
                    confirmPasswdTxt.Clear();
                    confirmPasswdTxt.ForeColor = Color.Black;
                }
                passwdTxt.PasswordChar = '\0';
                confirmPasswdTxt.PasswordChar = '\0';
            }
            else    // Hide password
            {
                if (passwdTxt.ForeColor == Color.Silver)
                    passwdTxt.Text = "Password";
                else
                    passwdTxt.PasswordChar = '*';
                if (confirmPasswdTxt.ForeColor == Color.Silver)
                    confirmPasswdTxt.Text = "Confirm Password";
                else
                    confirmPasswdTxt.PasswordChar = '*';
            }
        }
    }
}