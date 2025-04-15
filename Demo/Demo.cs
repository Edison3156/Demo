using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Demo
{
    public partial class Demo : Form
    {

        private bool isRunning = true;

        public Demo()
        {
            InitializeComponent();
            StartClockAsync(); // 在表單啟動時啟動時鐘
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World";
        }

        private void Demo_Load(object sender, EventArgs e)
        {
            lblHelloWorld.Text = string.Empty;
            lblCount.Text = string.Empty;
            btnCount.Text = "開始計數";
        }

        private bool isCounting = false;
        private int intCount = 0;
        private CancellationTokenSource cts =new CancellationTokenSource();

        private async void btnCount_Click(object sender, EventArgs e)
        {

            if (lblCount.Text == "10") intCount = 0;
            if (isCounting)
            {
                cts?.Cancel();
                isCounting = false;
                btnCount.Text = "繼續計數";
            }
            else
            {
                // 開始新的計數
                isCounting = true;
                btnCount.Text = "停止計數";

                cts = new CancellationTokenSource();
                CancellationToken token = cts.Token;

                for (int i = intCount; i < 11; i++)
                {
                    if (token.IsCancellationRequested) break;

                    if (i != 0) await Task.Delay(750);

                    if (lblCount.InvokeRequired)
                    {
                        lblCount.Invoke(new Action(() => lblCount.Text = i.ToString()));
                        intCount += 1;
                    }
                    else
                    {
                        if (!token.IsCancellationRequested)
                        {
                            lblCount.Text = i.ToString();
                            intCount += 1;
                        }
                    }

                    if (i == 10)
                    {
                        btnCount.Text = "開始計數";
                        isCounting = false;
                    }
                }
            }
        }

        private async void StartClockAsync()
        {
            while (isRunning)
            {
                lblDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                await Task.Delay(1000); // 每秒更新一次
            }
        }
    }
}