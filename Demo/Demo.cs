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
            StartClockAsync(); // �b���ҰʮɱҰʮ���
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World";
        }

        private void Demo_Load(object sender, EventArgs e)
        {
            lblHelloWorld.Text = string.Empty;
            lblCount.Text = string.Empty;
            btnCount.Text = "�}�l�p��";
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
                btnCount.Text = "�~��p��";
            }
            else
            {
                // �}�l�s���p��
                isCounting = true;
                btnCount.Text = "����p��";

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
                        btnCount.Text = "�}�l�p��";
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
                await Task.Delay(1000); // �C���s�@��
            }
        }
    }
}