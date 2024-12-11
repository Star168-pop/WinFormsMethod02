namespace WinFormsMethod02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            //double r = 0;
            //if (!double.TryParse(txtRadius.Text, out r))
            //{
            //    MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            //    return;
            //}
            //CircleArea(r);

            CircleArea(txtRadius, lblResult);
        }

        void CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            lblResult.Text = area.ToString();
        }

        void CircleArea(TextBox txt)
        {
            double r = 0;
            if (!double.TryParse(txt.Text, out r))
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return;
            }
            double area = Math.PI * r * r;
            lblResult.Text = area.ToString();
        }

        void CircleArea(TextBox txt, Label lbl)
        {
            double r = 0;
            if (!double.TryParse(txt.Text, out r))
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return;
            }
            double area = Math.PI * r * r;
            lbl.Text = area.ToString();
        }

        private void btnCircumference_Click(object sender, EventArgs e)
        {
            double r = 0;
            if (!double.TryParse(txtRadius.Text, out r))
            {
                MessageBox.Show("ข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
                return;
            }
            lblResult.Text = Circumference(r).ToString();
        }

        double Circumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        string triangle(string letter = "*", int size = 5)
        {
            string result = "";
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += letter;
                }
                result += Environment.NewLine;
            }
            return result;
        }

        private void btnTriangle01_Click(object sender, EventArgs e)
        {
            //txtOutput.Text = triangle();
            //txtOutput.Text = 
            txtOutput.Text = triangle(txtLetter.Text, 9);
        }

        void ImproveName(ref string name)
        {
            name = name.Trim();
            if (name.Length < 2)
            {
                MessageBox.Show("โปรดกรอกชื่อให้ถูกต้อง", "เกิดข้อผิดพลาด");
                return;
            }
            

        }
        string ImproveName2(ref string name)
        {
            name.Trim();
            if (name.Length < 2)
            {
                MessageBox.Show("โปรดกรอกชื่อให้ถูกต้อง", "เกิดข้อผิดพลาด");
            }
            return name;
        }

        private void btnRefParameter_Click(object sender, EventArgs e)
        {
            string FName = txtInput.Text;
            ImproveName(ref FName);
            txtInput.Text = FName;
        }

        Boolean improveName3(string name, out string x)
        {
            x = name.Trim();
            if (x.Length < 2)
            {
                x = "";
                return false;
            }
            return true;
        }

        private void btnOutputParameter_Click(object sender, EventArgs e)
        {
            string FName = "";
            if (improveName3(txtInput.Text, out FName))
            {
                txtInput.Text = FName;
            }
            else
            { 
                MessageBox.Show("ข้อมูลผิดพลาด", "โปรดกรอกข้อมูลให้ถูกต้อง");
            }
        }
    }
}
