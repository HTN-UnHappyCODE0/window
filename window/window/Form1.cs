namespace window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
                this.errorProvider1.SetError(textBox2, "This is not invalid number");
            else
                this.errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int age = DateTime.Now.Year - Convert.ToInt32(textBox2.Text);
            string s = "my name is: " + textBox1 + "\n" + age.ToString();
            MessageBox.Show(s);
        
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            Control ctr =(Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(textBox1, "you must enter Your name");
            else 
                this.errorProvider1.Clear();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender,FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
}

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}