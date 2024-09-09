
namespace Hash_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) //Справка
        {
            MessageBox.Show("Программа создана в рамках курсового проектирования" +
                " студентом группы ДИНРБ-21\nПод руководством Садчикова П.Н." +
                "\nКамоликовым Владиславом", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button2_Click(object sender, EventArgs e) //Демонстрация
        {
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = "C://Users//vladi//OneDrive//Рабочий стол//Курсовая 4 семестр//html и теория//hash-demo.mp4";
            System.Diagnostics.Process.Start(psi);

        }

        private void button3_Click(object sender, EventArgs e) //Тестирование
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e) //Теория
        {

            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = "C://Users//vladi//OneDrive//Рабочий стол//Курсовая 4 семестр//html и теория//Title.html";
            System.Diagnostics.Process.Start(psi);
        }
    }
}