using CustomAttributeExample;

namespace AttributeFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            s1.Name = nameBox.Text;
            s1.Surname = surnameBox.Text;
            s1.Department = departmentBox.Text;
            s1.DateOfBirth = dateOfBirthBox.Text;

            bool validateRequired = ReqiredControl.Validate(s1);

            if (!validateRequired)
            {
                MessageBox.Show("Reqiured Field cannot be empty");
            }
            else if (!DateFormatControl.Validate(s1))
            {
                MessageBox.Show("Date format is not valid. Must be 'dd/MM/yyyy'");
            }
            else
            {
                MessageBox.Show("Student has been registered.");
            }
        }
    }
}
