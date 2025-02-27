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
            double distance, gas, average; //�ŧi�ϰ��ܼ�


            if (double.TryParse(distextBox.Text, out distance))
            {
                if (double.TryParse(gastextBox.Text, out gas))
                {
                    average = distance / gas;
                    averagelabel.Text = "�����o�ӡG" + average.ToString("f2") + " km/L";
                }
            }
            else
            {
                MessageBox.Show("�п�J�Ʀr");
                distextBox.Focus(); //�N��в���distextBox
                distextBox.Text = "";   //�M��distextBox

            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}