using System;
using System.Windows.Forms;
using System.IO;

namespace TKCD_Save_Editor
{
    public partial class TKCD_Save_Editor : Form
    {

        public TKCD_Save_Editor()
        {
            InitializeComponent();
        }

        public class Data
        {
            public static byte[] data;
            public static int length;
            public static byte GetData(int n)
            {
                return data[n];
            }
            public static UInt16 GetInt16Data(int n)
            {
                int i;
                UInt16 value = 0;
                for (i = 1; i > -1; i--)
                {
                    value <<= 8;
                    value += data[n + i];
                }
                return value;
            }
            public static UInt32 GetInt24Data(int n)
            {
                int i;
                UInt32 value = 0;
                for (i = 2; i > -1; i--)
                {
                    value <<= 8;
                    value += data[n + i];
                }
                return value;
            }
            public static UInt32 GetInt32Data(int n)
            {
                int i;
                UInt32 value = 0;
                for (i = 3; i > -1; i--)
                {
                    value <<= 8;
                    value += data[n + i];
                }
                return value;
            }
            public static string GetStringData(int n, int len)
            {
                char[] value = new char[len + 1];
                int i;
                for(i = 0; i < len; i++)
                {
                    value[i] = (char)(data[n + i * 2] + (data[n + i * 2 + 1] << 8));
                }
                return new string(value);
            }

            public static void SetData(int n, byte val)
            {
                data[n] = val;
            }
            public static void SetInt16Data(int n, UInt16 value)
            {
                int i;
                for (i = 0; i < 2; i++)
                {
                    data[n + i] = (byte)(value % 256);
                    value >>= 8;
                }
            }
            public static void SetInt24Data(int n, UInt32 value)
            {
                int i;
                for (i = 0; i < 3; i++)
                {
                    data[n + i] = (byte)(value % 256);
                    value >>= 8;
                }
            }
            public static void SetInt32Data(int n, UInt32 value)
            {
                int i;
                for (i = 0; i < 4; i++)
                {
                    data[n + i] = (byte)(value % 256);
                    value >>= 8;
                }
            }
            public static void SetStringData(int n, int len, string value)
            {
                int i;
                for (i = 0; i < len && i < value.Length; i++)
                {
                    data[n + i * 2] = (byte)(value[i] % 256);
                    data[n + i * 2 + 1] = (byte)(value[i] >> 8);
                }
                data[n + i * 2] = (byte)0;
                data[n + i * 2 + 1] = (byte)0;
            } 
        }

        private void OpenFile(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName == "") return;

            FileInfo fi = new FileInfo(openFileDialog.FileName);
            if (fi.Length != 8464)
            {
                MessageBox.Show("存档文件大小错误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byte[] buff = new byte[fi.Length];
            FileStream fs = fi.OpenRead();
            fs.Read(buff, 0, Convert.ToInt32(fs.Length));
            Data.data = buff;
            Data.length = (int)fi.Length;
            fs.Close();

            appleBox.Value = Data.GetInt16Data(0x199C);
            boughtBox.Value = Data.GetInt16Data(0x19B8);
            fireShardBox.Value = Data.GetInt16Data(0x19BC);
            waterShardBox.Value = Data.GetInt16Data(0x19C0);
            lightShardBox.Value = Data.GetInt16Data(0x19C4);
            rareShardBox.Value = Data.GetInt16Data(0x19C8);

            messageBox.Text = Data.GetStringData(0x1BB4, 16);
            timeBox.Value = Data.GetInt32Data(0x1B74);
            encounterBox.Value = Data.GetInt16Data(0x1B64);
            multiBox.Value = Data.GetInt16Data(0x1B94);
            expBox.Value = Data.GetInt24Data(0x0D54);
            vigourBox.Value = Data.GetData(0x1B98);

            ReadMissionData();

            resourceGroup.Enabled = true;
            profileBox.Enabled = true;
            missionGroup.Enabled = true;
            saveItem.Enabled = true;
        }
        
        private void SaveFile(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName == "") return;

            Data.SetInt16Data(0x199C, (UInt16)appleBox.Value);
            Data.SetInt16Data(0x19B8, (UInt16)boughtBox.Value);
            Data.SetInt16Data(0x19BC, (UInt16)fireShardBox.Value);
            Data.SetInt16Data(0x19C0, (UInt16)waterShardBox.Value);
            Data.SetInt16Data(0x19C4, (UInt16)lightShardBox.Value);
            Data.SetInt16Data(0x19C8, (UInt16)rareShardBox.Value);

            Data.SetStringData(0x1BB4, 16, messageBox.Text);
            Data.SetInt32Data(0x1B74, (UInt32)timeBox.Value);
            Data.SetInt16Data(0x1B64, (UInt16)encounterBox.Value);
            Data.SetInt16Data(0x1B94, (UInt16)multiBox.Value);
            Data.SetInt24Data(0x0D54, (UInt32)expBox.Value);
            Data.SetInt24Data(0x0D60, (UInt32)expBox.Value);
            Data.SetInt24Data(0x0D6C, (UInt32)expBox.Value);
            Data.SetInt24Data(0x0D78, (UInt32)expBox.Value);
            Data.SetData(0x1B98, (byte)vigourBox.Value);

            WriteMissionData();

            FileStream fs = new FileStream(saveFileDialog.FileName, File.Exists(saveFileDialog.FileName) ? FileMode.Truncate : FileMode.CreateNew);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(Data.data, 0, Data.length);

            bw.Close();
            fs.Close();

            MessageBox.Show("保存文件成功。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AboutClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Xzonn/Team_Kirby_Clash_Deluxe_Save_Editor");
        }

        private void ReadMissionData()
        {
            string mission = missionBox.Text;
            int pos = (mission[0] - '0') * 0xA0 + (mission[2] - '0') * 0x10 + 0x0CDC;

            switch (Data.GetInt24Data(pos))
            {
                case 0x01:
                    missionStatusBox.Text = (string)missionStatusBox.Items[0];
                    break;
                case 0x0103:
                    missionStatusBox.Text = (string)missionStatusBox.Items[1];
                    break;
                case 0x0105:
                    missionStatusBox.Text = (string)missionStatusBox.Items[2];
                    break;
                case 0x010005:
                    missionStatusBox.Text = (string)missionStatusBox.Items[3];
                    break;
                default:
                    missionStatusBox.Text = (string)missionStatusBox.Items[4];
                    break;
            }
            scoreBox.Value = Data.GetInt24Data(pos + 4) ;
            medalBox.Text = (string)medalBox.Items[Data.GetData(pos + 8)];
            bestTimeBox.Value = ((decimal)Data.GetInt16Data(pos + 12)) / 100;
        }

        private void WriteMissionData()
        {
            string lastMission = lastMissionLabel.Text;
            int lastPos = (lastMission[0] - '0') * 0xA0 + (lastMission[2] - '0') * 0x10 + 0x0CDC;

            switch (missionStatusBox.SelectedIndex)
            {
                case 0:
                    Data.SetInt24Data(lastPos, 0x01);
                    break;
                case 1:
                    Data.SetInt24Data(lastPos, 0x0103);
                    break;
                case 2:
                    Data.SetInt24Data(lastPos, 0x0105);
                    break;
                case 3:
                    Data.SetInt24Data(lastPos, 0x010005);
                    break;
            }
            Data.SetInt24Data(lastPos + 4, (uint)scoreBox.Value);
            Data.SetData(lastPos + 8, (byte)medalBox.SelectedIndex);
            Data.SetInt16Data(lastPos + 12, (UInt16)(bestTimeBox.Value * 100));
        }

        private void MissionChange(object sender, EventArgs e)
        {
            missionBox.Focus();
            WriteMissionData();
            ReadMissionData();
            lastMissionLabel.Text = missionBox.Text;
        }
    }
}
