namespace WinFormMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("�Թ�յ�͹�Ѻ", "��������ͺ������ǹ���");
            clearForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //��������� ����͡��Ѻ���Ť�ԡ
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //�����ӹǳ BMI
            //input �Ѻ��� textbox
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //double height = Convert.ToDouble(txtHeight.Text);
            //double weight = Convert.ToDouble(txtWeight.Text);

            /*double height = 0;
            if (double.TryParse(txtHeight.Text,out height)==false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Error");
                return;//��Ҥ��� if �繨�ԧ��騺��÷ӧҹ
            }
            double weight = 0;
            if (double.TryParse(txtWeight.Text, out weight) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Error");
                MessageBox.Show("��͡���������١��ͧ", "Error");
                return;//��Ҥ��� if �繨�ԧ��騺��÷ӧҹ
            }*/

            double height = 0;
            double weight = 0;
            if (CheckDouble(txtHeight, txtWeight)) //���¡�� method Ẻ�׹����� T / F
            {
                height = Convert.ToDouble(txtHeight.Text);
                weight = Convert.ToDouble(txtWeight.Text);
            }

            //process �ӹǳ��� BMI
            double bmi = BMI(height, weight);//���¡��method bmi
            //double bmi = weight / Math.Pow(height / 100, 2);//  �����

            //output �ż� ��
            lblResult.Text = bmi.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            txtName.Text = "";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeight.Text = "0";
            lblResult.Text = "";
            txtName.Focus();

        }

        private void InputDatavalid(TextBox name, TextBox age)
        {
            if (name.Text.Length != 0)
            {
                name.ForeColor = Color.Yellow;
            }
            else
            {
                name.ForeColor = Color.DarkBlue;
            }
            if (Convert.ToInt32(age.Text) > 0)
            {
                age.ForeColor = Color.Yellow;
            }
            else
            {
                age.ForeColor = Color.DarkBlue;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            InputDatavalid(txtName, txtAge);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            InputDatavalid(txtName, txtAge);
        }

        private double BMI(double h, double w)//�ӹǳ��� bmi �觤������� 2 ��Ҥ�͹�. ��.
        {
            double bmi = w/Math.Pow(h, 2);
            return bmi;
        }

        private bool CheckDouble(TextBox txtH, TextBox txtW) //��Ǩ�ͺ������
        {
            double h = 0;
            double w = 0;
            if ((double.TryParse(txtH.Text, out h)==false) || (double.TryParse(txtW.Text, out w) == false))
            {
                MessageBox.Show("��͡���������١��ͧ", "Error");
                return false;
            }
            return true;
        }
    }
}
