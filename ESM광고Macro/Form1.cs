using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Timers;
using ESM광고Macro.Service;
using ESM광고Macro.Resources;


namespace ESM광고Macro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScheduledWork.ConfigureTimeOnly(dateTimePicker1);
            ScheduledWork.ConfigureTimeOnly(dateTimePicker2);
            ReadCSV readCSV = new ReadCSV();
            readCSV.FindFilePath(dataGridView1, Userdata.GetAllUserdatas());
            LoadConfig.LC("config.csv");
            LoadConfig.LoadConfigToTextBoxes(textBox7, textBox6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ESMLogin esmLogin = new ESMLogin();
            esmLogin.AutoLoginOut(Config.driver, dataGridView1, Config.timer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ESMLogin esmLogin = new ESMLogin();
            esmLogin.AutoLoginOut(Config.driver, dataGridView1, Config.timer);
            ESM_OnOffManage.OnList(Config.driver, dataGridView1, Config.timer);
            ESM_OnOffManage.CheckGridOn(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ESMLogin esmLogin = new ESMLogin();
            esmLogin.AutoLoginOut(Config.driver, dataGridView1, Config.timer);
            ESM_OnOffManage.OffList(Config.driver, dataGridView1, Config.timer);
            ESM_OnOffManage.CheckGridOff(dataGridView1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await ScheduledWork.RunAtAsync(
                dateTimePicker1.Value,
                textBox1,
                () => ESM_OnOffManage.AllOn(Config.driver, dataGridView1, Config.timer)
            );
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            await ScheduledWork.RunAtAsync(
                dateTimePicker2.Value,
                textBox2,
                () => ESM_OnOffManage.Alloff(Config.driver, dataGridView1, Config.timer)
            );
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            IdManage.IDPWDinput(textBox4, textBox3, dataGridView1);

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV 파일 (*.csv)|*.csv";
                sfd.FileName = "아이디비번.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    IdManage.SaveUserListToCsv(Userdata.GetAllUserdatas(), sfd.FileName);
                    MessageBox.Show("저장 완료!");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //ReadCSV readCSV = new ReadCSV();
            //readCSV.FindFilePath(dataGridView1, Userdata.userdatas);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ESM_OnOffManage.AllOn(Config.driver, dataGridView1, Config.timer);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ESM_OnOffManage.Alloff(Config.driver, dataGridView1, Config.timer);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int setTime = int.Parse(textBox6.Text);
            Config.timer = setTime;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int setTime = int.Parse(textBox7.Text);
            Config.listsearchtimer = 1000 * setTime;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SaveConfig.SC("config.csv");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LoadConfig.LC("config.csv");
        }
    }
}
