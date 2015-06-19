using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using AxGrFingerXLib;
using GrFingerXLib;
using System.Runtime.InteropServices;


namespace Medcine_ManagmentSystem
{
    public partial class frmLogin : Form
    {
        [DllImport("user32.dll", EntryPoint = "GetDC")]
        public static extern IntPtr GetDC(IntPtr ptr);

        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);

        public TRawImage raw;
        TTemplate tpt = new TTemplate();
        


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Byte[] temp = new Byte[10000];
            System.Array.Copy(tpt._tpt, 0, temp, 0, 10000);
               if(UserLogin.Insert(txtid.Text,txtpassword.Text,temp))
            {
                MessageBox.Show("Saved Success");
                gettable();

            }
            else
            {
                gettable();
                MessageBox.Show("Not Saved");

            }
        }

        private void axGrFingerXCtrl1_SensorPlug(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEvent e)
        {
            axGrFingerXCtrl1.CapStartCapture(e.idSensor);
        }

        private void axGrFingerXCtrl1_SensorUnplug(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEvent e)
        {
            axGrFingerXCtrl1.CapStopCapture(e.idSensor);
        }

        private void axGrFingerXCtrl1_ImageAcquired(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEvent e)
        {
            raw.img = e.rawImage;
            raw.height = (int)e.height;
            raw.width = (int)e.width;
            raw.Res = e.res;

            tpt._size = (int)GRConstants.GR_MAX_SIZE_TEMPLATE;
            IntPtr hdc = GetDC(System.IntPtr.Zero);
            Image handle = null;
            axGrFingerXCtrl1.CapRawImageToHandle(ref e.rawImage, e.width, e.height, hdc.ToInt32(), ref handle);
            if (handle != null)
            {
                axGrFingerXCtrl1.Extract(ref raw.img, raw.width, raw.height, raw.Res, ref tpt._tpt, ref tpt._size, (int)GRConstants.GR_DEFAULT_CONTEXT);
                axGrFingerXCtrl1.BiometricDisplay(ref tpt._tpt, ref raw.img, raw.width, raw.height, raw.Res, hdc.ToInt32(), ref handle, (int)GRConstants.GR_NO_CONTEXT);
                pictureBox1.Image = handle;
                pictureBox1.Update();
            }
            int id;
            int score = 0;

            GRConstants result;
            int val;
            TTemplate reftpt = new TTemplate();
            reftpt._size = 0;
            //TTemplate tptblob = new TTemplate();
            SqlDataReader rd;
            Byte[] temp;
            result = (GRConstants)axGrFingerXCtrl1.IdentifyPrepare(ref tpt._tpt, (int)GRConstants.GR_DEFAULT_CONTEXT);
            if (result < 0)
            {
                MessageBox.Show("identify prepae error");
            }

            // here is my sql connection .....

            SqlConnection con = new SqlConnection(Connection.connectionstring);
            con.Open();
            SqlCommand select = new SqlCommand("SELECT * FROM UserLogin", con);
            rd = select.ExecuteReader();

            while (rd.Read())
            {
                long readbytes;
                reftpt._size = 0;
                temp = new System.Byte[(int)GRConstants.GR_MAX_SIZE_TEMPLATE];
                readbytes = rd.GetBytes(2, 0, temp, 0, temp.Length);
                System.Array.Copy(temp, 0, reftpt._tpt, 0, (int)readbytes);
                reftpt._size = (int)readbytes;
                result = (GRConstants)axGrFingerXCtrl1.Identify(ref reftpt._tpt, ref score, (int)GRConstants.GR_DEFAULT_CONTEXT);
                if (result == GRConstants.GR_MATCH)
                {
                   
                    txtid.Text = rd[0].ToString();
                    txtpassword.Text = rd[1].ToString();

                }
            }
            rd.Close();
            con.Close();

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            axGrFingerXCtrl1.CapFinalize();
            axGrFingerXCtrl1.Finalize();
        }
        public void gettable()
        {
            dataGridView1.DataSource = UserLogin.gettable();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            axGrFingerXCtrl1.Initialize();
            axGrFingerXCtrl1.CapInitialize();
            gettable();
        }
    }
}
