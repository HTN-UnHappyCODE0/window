namespace pheptinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int.TryParse(textBox1.Text, out a);
            int.TryParse(textBox2.Text, out b);
            textBox3.Text = (a - b).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int.TryParse(textBox1.Text, out a);
            int.TryParse(textBox2.Text, out b);
            textBox3.Text = (a + b).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int.TryParse(textBox1.Text, out a);
            int.TryParse(textBox2.Text, out b);
            textBox3.Text = (a * b).ToString();

        }


        private void radioButton4_Click(object sender, EventArgs e) { 
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);

            if (b == 0){
                MessageBox.Show("nhap so khac 0");
               
                }
            else
                {
                if(radioButton4.Checked && !isChecked){
                    radioButton4.Checked = false;
                    float c = a / b;
                    textBox3.Text = c.ToString();
                }
                else
                {
                    radioButton4.Checked = true;
                    isChecked = false;
                }
                }
        }
        bool isChecked = false;

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radioButton4.Checked;
        }
    }
}