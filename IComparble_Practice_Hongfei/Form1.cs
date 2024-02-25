using System.Runtime.Intrinsics.X86;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace IComparble_Practice_Hongfei
{
    //IComparable_Sorting
    //Week7
    //Hongfei
    public partial class Form1 : Form
    {
        List<Student> _Students = new List<Student>();
        public Form1()
        {
            InitializeComponent();

            _Students.Add(new Student("Sam", "Wang"));
            _Students.Add(new Student("Tian", "Zheng"));
            _Students.Add(new Student("Eva", "Lee"));
            _Students.Add(new Student("Bob", "Williams"));
            _Students.Add(new Student("Eva", "Brown"));


        }

        private void DisplayStudent()
        {
            listBox1.Items.Clear();
            foreach (var student in _Students)
            {
                listBox1.Items.Add(student);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayStudent();
            _Students.Sort();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentSortFistNameDsc ssf = new StudentSortFistNameDsc();
            DisplayStudent();
            _Students.Sort(ssf);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                StudentSortGenEdGrade grade = new StudentSortGenEdGrade();
                DisplayStudent();
                _Students.Sort(grade);
            }
            if (checkBox2.Checked)
            {
                StudentSortGenEdGrade grade = new StudentSortGenEdGrade(StudentSortGenEdGrade.Order.Descending);
                DisplayStudent();
                _Students.Sort(grade);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayStudent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentSortLastNameDsc ssl = new StudentSortLastNameDsc();
            DisplayStudent();
            _Students.Sort(ssl);
        }
    }





}
