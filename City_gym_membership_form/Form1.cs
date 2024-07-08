namespace City_gym_membership_form
{/*student name: Jayden Fidow
  * student id:2024000873
  * I declare that this is my own work */
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            // Variable declarations
            string Fname;
            string Lname;
            string Address;
            string MobNum;
            double membershipFee; // Corrected variable name


            // Get Data from text box;
            Fname = TextBoxFname.Text;
            Lname = TextBoxLname.Text;
            Address = TextBoxAdr.Text;
            MobNum = TextBoxMobno.Text;
            // check radio buttons
            bool threemo = RadioButton3mo.Checked;
            bool twelvemo = RadioButton12mo.Checked;
            bool Bas = RadioButtonBas.Checked;
            bool Reg = RadioButtonReg.Checked;
            // check checkboxes
            bool Acc = CheckBoxAccess.Checked;
            bool Ptr = CheckBoxPt.Checked;
            bool Dt = CheckBoxDiet.Checked;
            bool Onl = CheckBoxOnline.Checked;


            // Calculate membership fee
            double basicFee = Logic.memDetLog(threemo, twelvemo, Bas, Reg, Acc, Ptr, Dt, Onl);

            double discount = 0.0;
            if (RadioButtonYes.Checked)
            {
                // Apply discount if the "Yes" radio button is checked
                discount = basicFee * 0.01; //  1% discount
            }

            // Calculate additional fees for extras
            double extraFees = 0.0;

            if (Ptr) // Personal Trainer
            {
                extraFees += 20.00; // Fixed fee for personal trainer
            }

            if (Dt) // Dietitian
            {
                extraFees += 20.00; // Fixed fee for dietitian
            }

            if (Onl) // Online Workouts
            {
                extraFees += 2.00; // Fixed fee for online workouts
            }

            if (Acc) //24hr Access
            {
                extraFees += 1.00; // Fixed fee for 24hr Access
            }

            // Add extra fees to the total membership fee as well as minus the discount
            membershipFee = basicFee + extraFees - discount;

            // Convert membership fee to string
            string Membership = Convert.ToString(membershipFee);

            // Display membership details including extra fees
            MessageBox.Show($"Full name: {Fname} {Lname}" +
                            $"\nAddress: {Address}" +
                            $"\nExtra Fees: {extraFees} nzd" +
                            $"\nBasic Fees: {basicFee}" +
                            $"\nDiscount: {discount}" +
                            $"\nMembership: {Membership} nzd");

            // feedback if textboxes or radio buttons aren't filled
            if (string.IsNullOrWhiteSpace(TextBoxFname.Text))
            {
                MessageBox.Show("Please fill in all the text boxes.");
                return;
            }
            if (string.IsNullOrWhiteSpace(TextBoxLname.Text))
            {
                MessageBox.Show("Please fill in all the text boxes.");
                return;
            }
            if (string.IsNullOrWhiteSpace(TextBoxAdr.Text))
            {
                MessageBox.Show("Please fill in all the text boxes.");
                return;
            }
            if (string.IsNullOrWhiteSpace(TextBoxMobno.Text))
            {
                MessageBox.Show("Please fill in all the text boxes.");
                return;
            }

            if (!RadioButtonYes.Checked && !RadioButtonNo.Checked)
            {
                MessageBox.Show("Please select a radio button.");
                return;
            }
            if (!RadioButtonBas.Checked && !RadioButtonReg.Checked && !RadioButtonPrem.Checked)
            {
                MessageBox.Show("Please select a radio button.");
                return;
            }
            if (!RadioButton3mo.Checked && !RadioButton12mo.Checked && !RadioButton24mo.Checked)
            {
                MessageBox.Show("Please select a radio button.");
                return;
            }
            if (!RadioButtonWek.Checked && !RadioButtonMo.Checked)
            {
                MessageBox.Show("Please select a radio button.");
                return;
            }

            
        }
    }
}



