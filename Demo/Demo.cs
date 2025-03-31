using System;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Demo : Form
    {
        private System.Windows.Forms.Timer timer; // �w�ɾ��ӨC���s
        private DateTime currentTime = DateTime.Now; // �O����e���ɶ�

        public Demo()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // �C 1000 �@��Ĳ�o�@���]�Y 1 ��^
            timer.Tick += new EventHandler(Timer_Tick); // ���U�w�ɾ�Ĳ�o�ƥ�
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

            lblDateTime.Text = currentTime.ToString("yyyy/MM/dd HH:mm:ss");

            // �Ұʩw�ɾ�
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            // �C���s��e�ɶ�
            currentTime = currentTime.AddSeconds(1); // �W�[ 1 ��
            lblDateTime.Text = currentTime.ToString("yyyy/MM/dd HH:mm:ss");
        }

    }
}