using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using NetFwTypeLib;

namespace DLAudioChat
{
    public partial class Form1 : Form
    {
        static string ip = "";
        static Thread recieve_thread;
        static Thread recieve_thread2;
        static Thread recieve_thread3;
        static UdpClient udpc;
        static IPEndPoint ipep;
        static UdpClient udpc2;
        static IPEndPoint ipep2;
        static UdpClient udpc3;
        static IPEndPoint ipep3;
        static Byte[] incoming;
        static MemoryStream sound;
        static WaveIn  waveIn;
        static WaveIn waveIn2;
        static WaveIn waveIn3;
        static WaveOut waveOut;
        static WaveFileWriter waveWriter;
        static WaveFileWriter waveWriter2;
        static WaveFileWriter waveWriter3;
        public int flag = 0;
        public int flag1 = 0;
        public int flag2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
        }

        //开始按钮一号
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                #region NAudio-staff
                waveIn = new WaveIn();
                waveIn.BufferMilliseconds = 100;
                waveIn.NumberOfBuffers = 10;
                waveOut = new WaveOut();

                //
                //选择记录设备（如果有多个麦克风）
                //
                waveIn.DeviceNumber = 0;

                //
                //将数据处理程序附加到可写数据事件
                //
                waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(waveIn_DataAvailable);

                //
                //WAV文件格式-接受参数-采样频率和通道数（此处为单声道）
                //
                waveIn.WaveFormat = new WaveFormat(44200, 2);
                waveIn.RecordingStopped += new EventHandler<StoppedEventArgs>(waveIn_RecordingStopped);

                sound = new MemoryStream();
                waveWriter = new WaveFileWriter(sound, waveIn.WaveFormat);
                #endregion

                label1.Text = "正在与" + textBox1.Text + "通讯";
                ip = textBox1.Text;
                udpc = new UdpClient(40016);
                ipep = new IPEndPoint(IPAddress.Parse(ip), 40016);

                udpc.Send(new Byte[1], 1, ipep);
                recieve_thread = new Thread(recv);
                recieve_thread.Start();

                waveIn.StartRecording();
                flag = 1;

                MICcheckBox1.Checked = true;
                SoundcheckBox1.Checked = true;
                buttonConnect.BackColor = System.Drawing.Color.MediumSpringGreen;

                if (flag1 == 1 && flag == 1 && flag2==1) { label1.Text = "正在与" + textBox1.Text + "\n和" + textBox2.Text + "\n和" + textBox3.Text + "通讯"; }
                else if(flag1==1) label1.Text = "正在与" + textBox1.Text + "\n和" + textBox2.Text + "通讯";
                else if (flag2 == 1) label1.Text = "正在与" + textBox1.Text + "\n和" + textBox3.Text + "通讯";
                else label1.Text = "正在与" + textBox1.Text + "通讯";
            }

        }
        //开始按钮二号
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag1 == 0)
            {
                #region NAudio-staff
                waveIn2 = new WaveIn();
                waveIn2.BufferMilliseconds = 100;
                waveIn2.NumberOfBuffers = 10;
                waveOut = new WaveOut();

                //
                //选择记录设备（如果有多个麦克风）
                //
                waveIn2.DeviceNumber = 0;

                //
                //将数据处理程序附加到可写数据事件
                //
                waveIn2.DataAvailable += new EventHandler<WaveInEventArgs>(waveIn_DataAvailable2);

                //
                //WAV文件格式-接受参数-采样频率和通道数（此处为单声道）
                //
                waveIn2.WaveFormat = new WaveFormat(44200, 2);
                waveIn2.RecordingStopped += new EventHandler<StoppedEventArgs>(waveIn_RecordingStopped2);

                sound = new MemoryStream();
                waveWriter2 = new WaveFileWriter(sound, waveIn2.WaveFormat);
                #endregion
                if (flag1 == 1 && flag == 1) { label1.Text = "正在与" + textBox2.Text + "通讯"; }
                ip = textBox2.Text;
                udpc2 = new UdpClient(40015);
                ipep2 = new IPEndPoint(IPAddress.Parse(ip), 40015);

                udpc2.Send(new Byte[1], 1, ipep2);
                recieve_thread2 = new Thread(recv2);
                recieve_thread2.Start();

                waveIn2.StartRecording();
                flag1 = 1;

                MICcheckBox2.Checked = true;
                SoundcheckBox2.Checked = true;
                Connect2.BackColor = System.Drawing.Color.MediumSpringGreen;

                if (flag1 == 1 && flag == 1 && flag2 == 1) { label1.Text = "正在与" + textBox1.Text + "\n和" + textBox2.Text + "\n和" + textBox3.Text + "通讯"; }
                else if (flag == 1) label1.Text = "正在与" + textBox1.Text + "\n和" + textBox2.Text + "通讯";
                else if (flag2 == 1) label1.Text = "正在与" + textBox2.Text + "\n和" + textBox3.Text + "通讯";
                else label1.Text = "正在与" + textBox2.Text + "通讯";
            }      
              
        }
        //开始按钮三号
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (flag2 == 0)
            {
                #region NAudio-staff
                waveIn3 = new WaveIn();
                waveIn3.BufferMilliseconds = 100;
                waveIn3.NumberOfBuffers = 10;
                waveOut = new WaveOut();

                //
                //选择记录设备（如果有多个麦克风）
                //
                waveIn3.DeviceNumber = 0;

                //
                //将数据处理程序附加到可写数据事件
                //
                waveIn3.DataAvailable += new EventHandler<WaveInEventArgs>(waveIn_DataAvailable3);

                //
                //WAV文件格式-接受参数-采样频率和通道数（此处为单声道）
                //
                waveIn3.WaveFormat = new WaveFormat(44200, 2);
                waveIn3.RecordingStopped += new EventHandler<StoppedEventArgs>(waveIn_RecordingStopped3);

                sound = new MemoryStream();
                waveWriter3 = new WaveFileWriter(sound, waveIn3.WaveFormat);
                #endregion
                if (flag1 == 1 && flag == 1) { label1.Text = "正在与" + textBox2.Text + "通讯"; }
                ip = textBox3.Text;
                udpc3 = new UdpClient(40014);
                ipep3 = new IPEndPoint(IPAddress.Parse(ip), 40014);

                udpc3.Send(new Byte[1], 1, ipep3);
                recieve_thread3 = new Thread(recv3);
                recieve_thread3.Start();

                waveIn3.StartRecording();
                flag2 = 1;

                MICcheckBox3.Checked = true;
                SoundcheckBox3.Checked = true;
                button2.BackColor = System.Drawing.Color.MediumSpringGreen;

                if (flag1 == 1 && flag == 1 && flag2 == 1) { label1.Text = "正在与" + textBox1.Text + "\n和" + textBox2.Text + "\n和" + textBox3.Text + "通讯"; }
                else if (flag1 == 1) label1.Text = "正在与" + textBox2.Text + "\n和" + textBox3.Text + "通讯";
                else if (flag == 1) label1.Text = "正在与" + textBox1.Text + "\n和" + textBox3.Text + "通讯";
                else label1.Text = "正在与" + textBox3.Text + "通讯";
            }
        }

        //停止按钮1号
        private void button2_Click(object sender, EventArgs e)
        {
            if(flag == 1)
            {
                waveIn.StopRecording();
                udpc.Close();
                recieve_thread.Abort();
                MICcheckBox1.Checked=false;
                SoundcheckBox1.Checked=false;
                flag = 0;
                buttonConnect.BackColor = System.Drawing.Color.White;
                if (flag1 == 1 && flag2 == 1) { label1.Text = "正在与" + textBox2.Text + "\n和" + textBox3.Text + "通讯"; }
                else if (flag1 == 1) label1.Text = "正在与" + textBox2.Text + "通讯";
                else if (flag2 == 1) label1.Text = "正在与" + textBox3.Text + "通讯";
                else label1.Text = "当前状态：空闲";

            }
        }
        //停止按钮二号
        private void Stop2_Click(object sender, EventArgs e)
        {
            if(flag1 == 1)
            {
                waveIn2.StopRecording();
                udpc2.Close();
                recieve_thread2.Abort();
                MICcheckBox2.Checked = false;
                SoundcheckBox2.Checked = false;
                flag1 = 0;
                Connect2.BackColor = System.Drawing.Color.White;
                if (flag == 1 && flag2 == 1) { label1.Text = "正在与" + textBox1.Text + "\n和" + textBox3.Text + "通讯"; }
                else if (flag == 1) label1.Text = "正在与" + textBox1.Text + "通讯";
                else if (flag2 == 1) label1.Text = "正在与" + textBox3.Text + "通讯";
                else label1.Text = "当前状态：空闲";
            }
            
        }
        //停止按钮三号
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (flag2 == 1)
            {
                waveIn3.StopRecording();
                udpc3.Close();
                recieve_thread3.Abort();
                MICcheckBox3.Checked = false;
                SoundcheckBox3.Checked = false;
                flag2 = 0;
                button2.BackColor = System.Drawing.Color.White;
                if (flag == 1 && flag1 == 1) { label1.Text = "正在与" + textBox1.Text + "\n和" + textBox2.Text + "通讯"; }
                else if (flag == 1) label1.Text = "正在与" + textBox1.Text + "通讯";
                else if (flag1 == 1) label1.Text = "正在与" + textBox2.Text + "通讯";
                else label1.Text = "当前状态：空闲";
            }
        }
        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            udpc.Send(e.Buffer, e.Buffer.Length, ipep);
        }
        void waveIn_DataAvailable2(object sender, WaveInEventArgs e)
        {
            udpc2.Send(e.Buffer, e.Buffer.Length, ipep2);
        }
        void waveIn_DataAvailable3(object sender, WaveInEventArgs e)
        {
            udpc3.Send(e.Buffer, e.Buffer.Length, ipep3);
        }

        void waveIn_RecordingStopped(object sender, EventArgs e)
        {
            waveIn.Dispose();
            waveIn = null;
        }
        void waveIn_RecordingStopped2(object sender, EventArgs e)
        {
            waveIn2.Dispose();
            waveIn2 = null;
        }
        void waveIn_RecordingStopped3(object sender, EventArgs e)
        {
            waveIn3.Dispose();
            waveIn3 = null;
        }

        private void Form1_Closing(object sender, EventArgs e)
        {
            if (waveIn == null)
                return;
            recieve_thread.Abort();
            waveIn.StopRecording();
            waveOut.Dispose();
            waveOut = null;
            udpc = null;
        }

        static void recv()
        {
            BufferedWaveProvider PlayBuffer = new BufferedWaveProvider(waveIn.WaveFormat);
            waveOut.Init(PlayBuffer);
            waveOut.Play();

            while (true)
            {
                incoming = udpc.Receive(ref ipep);
                PlayBuffer.AddSamples(incoming, 0, incoming.Length);
            }
        }
        static void recv2()
        {
            BufferedWaveProvider PlayBuffer = new BufferedWaveProvider(waveIn2.WaveFormat);
            waveOut.Init(PlayBuffer);
            waveOut.Play();

            while (true)
            {
                incoming = udpc2.Receive(ref ipep2);
                PlayBuffer.AddSamples(incoming, 0, incoming.Length);
            }
        }
        static void recv3()
        {
            BufferedWaveProvider PlayBuffer = new BufferedWaveProvider(waveIn3.WaveFormat);
            waveOut.Init(PlayBuffer);
            waveOut.Play();

            while (true)
            {
                incoming = udpc3.Receive(ref ipep3);
                PlayBuffer.AddSamples(incoming, 0, incoming.Length);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region 麦克风和静音开关
        //麦克风开关一号
        private void MICcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (flag == 0) { MICcheckBox1.Checked=false; return; }

            if (MICcheckBox1.Checked == false)
            {
                INetFwPolicy2 fwPolicy = GetFirewallPolicy();
                // 禁止本地向远程IP的40016端口的UDP上传通信
                AddAllowRule(fwPolicy, "MyUDPRule", textBox1.Text, "UDP", 40016);
            }
            else
            {
                INetFwPolicy2 fwPolicy = GetFirewallPolicy();
                // 允许本地向远程IP的40016端口的UDP上传通信
                AddBlockRule(fwPolicy, "MyUDPRule", textBox1.Text, "UDP", 40016);
            }
        }

        //接收音频开关一号
        private void SoundcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (flag == 0) {SoundcheckBox1.Checked=false; return; }
      
            if (SoundcheckBox1.Checked == false)
            {
                
            }
            else
            {
               
            }
        }

        //麦克风开关二号
        private void MICcheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (flag1 == 0) {MICcheckBox2.Checked=false; return; }

            if (MICcheckBox2.Checked == false)
            {
               
            }
            else
            {
                
            }
        }

        //接收音频开关二号
        private void SoundcheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (flag1 == 0) { SoundcheckBox2.Checked = false; return; }

            if (SoundcheckBox2.Checked == false)
            {

            }
            else
            {

            }
        }

        //麦克风开关三号
        private void MICcheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (flag2 == 0) {MICcheckBox3.Checked=false; return; }

            if (MICcheckBox3.Checked == false)
            {

            }
            else
            {

            }
        }

        //接受音频开关三号
        private void SoundcheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (flag2 == 0) {SoundcheckBox3.Checked=false; return; }

            if (SoundcheckBox3.Checked == false)
            {

            }
            else
            {

            }
        }
        #endregion


        //获取防火墙管理实例
        static INetFwPolicy2 GetFirewallPolicy()
        {
            Type type = Type.GetTypeFromProgID("HNetCfg.FwPolicy2", false);
            return (INetFwPolicy2)Activator.CreateInstance(type);
        }
        // 添加允许规则
        static void AddAllowRule(INetFwPolicy2 fwPolicy, string ruleName, string remoteIP, string protocol, int port)
        {
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));

            newRule.Name = ruleName;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.RemoteAddresses = remoteIP;
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = port.ToString();
            newRule.Enabled = true;

            fwPolicy.Rules.Add(newRule);
        }

        // 添加阻止规则
        static void AddBlockRule(INetFwPolicy2 fwPolicy, string ruleName, string remoteIP, string protocol, int port)
        {
            INetFwRule newRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));

            newRule.Name = ruleName;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.RemoteAddresses = remoteIP;
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            newRule.LocalPorts = port.ToString();
            newRule.Enabled = true;

            fwPolicy.Rules.Add(newRule);
        }
    }
}
