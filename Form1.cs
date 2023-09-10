namespace switchWinForm
{
    public partial class Form1 : Form
    {

        private Form2 form2 = new Form2();
        private Form3 form3 = new Form3();
        private Form4 form4 = new Form4();
        private Form5 form5 = new Form5();
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerUpdateForF2;
        private int nextForm = 3;

        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timerUpdateForF2 = new System.Windows.Forms.Timer();
            timer.Interval = 60000;
            timerUpdateForF2.Interval = 30000;
            timer.Enabled = true;
            timerUpdateForF2.Enabled = true;
            timer.Tick += Timer_Tick;
            timerUpdateForF2.Tick += timerUpdateForF2_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            //form2 = new Form2();
            form2.Show();
            form2.WindowState = FormWindowState.Maximized;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 10;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            //this.Hide();
            panel1.Visible = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (nextForm == 2)
            {
                form2 = new Form2();
                form2.WindowState = FormWindowState.Maximized;
                form2.Show();
                form5.Hide();
                nextForm = 3;
            }
            else if (nextForm == 3)
            {
                form3 = new Form3();
                form3.WindowState = FormWindowState.Maximized;
                form3.Show();
                form2.Hide();
                nextForm = 4;
            }
            else if (nextForm == 4)
            {
                form4 = new Form4();
                form4.WindowState = FormWindowState.Maximized;
                form4.Show();
                form3.Hide();
                nextForm = 5;
            }
            else if (nextForm == 5)
            {
                form5 = new Form5();
                form5.WindowState = FormWindowState.Maximized;
                form5.Show();
                form4.Hide();
                nextForm = 2;
            }
        }

        private void InitialData()
        {
            Thread.Sleep(100000);
        }

        private void timerUpdateForF2_Tick(object sender, EventArgs e)
        {
            form2.UpdateData();
        }

    }
}