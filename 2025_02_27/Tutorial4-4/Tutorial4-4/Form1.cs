namespace Tutorial4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            double distance, gas, average; //宣告區域變數


            if (double.TryParse(distextBox.Text, out distance))
            {
                if (double.TryParse(gastextBox.Text, out gas))
                {
                    average = distance / gas;
                    averagelabel.Text = "平均油耗：" + average.ToString("f2") + " km/L";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
                distextBox.Focus(); //將游標移至distextBox
                distextBox.Text = "";   //清空distextBox

            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}