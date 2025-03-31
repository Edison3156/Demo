using System;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Demo : Form
    {
        private System.Windows.Forms.Timer timer; // 定時器來每秒更新
        private DateTime currentTime = DateTime.Now; // 記錄當前的時間

        public Demo()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 每 1000 毫秒觸發一次（即 1 秒）
            timer.Tick += new EventHandler(Timer_Tick); // 註冊定時器觸發事件
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

            lblDateTime.Text = currentTime.ToString("yyyy/MM/dd HH:mm:ss");

            // 啟動定時器
            timer.Start();
        }

        private bool isCounting = false;
        private int intCount = 0;
        private CancellationTokenSource cts;

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

        private void Timer_Tick(object sender, EventArgs e)
        {
            // 每秒更新當前時間
            currentTime = currentTime.AddSeconds(1); // 增加 1 秒
            lblDateTime.Text = currentTime.ToString("yyyy/MM/dd HH:mm:ss");
        }

    }
}