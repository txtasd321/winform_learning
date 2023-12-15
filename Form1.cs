namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(Showfrm2);
            thr.IsBackground = true;
            thr.Start();

            //Form2 frm = new Form2();
            //frm.Show();

        }

        private void Showfrm2()
        {
            Action action = Newfrm2;
            Invoke(action);
        }
        private void Newfrm2()
        {
            Form2 frm = new Form2();
            frm.Show();
            //Thread.Sleep(2000);        
        }
    }
}
