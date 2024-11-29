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
            MessageBox.Show("ยินดีต้อนรับ", "โปรแกรมทดสอบความอ้วนผอม");
            clearForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //ไม่มีอะไร ผมเผลอกดดับเบิ้ลคลิก
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //ปุ่มคำนวณ BMI
            //input รับค่า textbox
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //double height = Convert.ToDouble(txtHeight.Text);
            //double weight = Convert.ToDouble(txtWeight.Text);

            /*double height = 0;
            if (double.TryParse(txtHeight.Text,out height)==false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Error");
                return;//ถ้าค่าใน if เป็นจริงให้จบการทำงาน
            }
            double weight = 0;
            if (double.TryParse(txtWeight.Text, out weight) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Error");
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Error");
                return;//ถ้าค่าใน if เป็นจริงให้จบการทำงาน
            }*/

            double height = 0;
            double weight = 0;
            if (CheckDouble(txtHeight, txtWeight)) //เรียกใช้ method แบบคืนค่าเป็น T / F
            {
                height = Convert.ToDouble(txtHeight.Text);
                weight = Convert.ToDouble(txtWeight.Text);
            }

            //process คำนวณค่า BMI
            double bmi = BMI(height, weight);//เรียกใช้method bmi
            //double bmi = weight / Math.Pow(height / 100, 2);//  จำไว้

            //output แปลผล โดย
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

        private double BMI(double h, double w)//คำนวณค่า bmi ส่งค่าเข้ามา 2 ค่าคือนน. สส.
        {
            double bmi = w/Math.Pow(h, 2);
            return bmi;
        }

        private bool CheckDouble(TextBox txtH, TextBox txtW) //ตรวจสอบข้อมูล
        {
            double h = 0;
            double w = 0;
            if ((double.TryParse(txtH.Text, out h)==false) || (double.TryParse(txtW.Text, out w) == false))
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Error");
                return false;
            }
            return true;
        }
    }
}
