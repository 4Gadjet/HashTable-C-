
namespace Hash_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) //�������
        {
            MessageBox.Show("��������� ������� � ������ ��������� ��������������" +
                " ��������� ������ �����-21\n��� ������������ ��������� �.�." +
                "\n����������� �����������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button2_Click(object sender, EventArgs e) //������������
        {
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = "C://Users//vladi//OneDrive//������� ����//�������� 4 �������//html � ������//hash-demo.mp4";
            System.Diagnostics.Process.Start(psi);

        }

        private void button3_Click(object sender, EventArgs e) //������������
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e) //������
        {

            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = "C://Users//vladi//OneDrive//������� ����//�������� 4 �������//html � ������//Title.html";
            System.Diagnostics.Process.Start(psi);
        }
    }
}