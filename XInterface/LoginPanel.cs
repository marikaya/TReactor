using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XReactor.XSockets;
using GalaSoft.MvvmLight.Messaging;
using System.Threading;
using XReactor;

namespace ConsoleApplication1.XInterface
{
    public partial class LoginPanel : Form
    {
         XReactorSockets MySokcets;
        public LoginPanel(XReactorSockets xrs)
        {
            
            InitializeComponent();
            label1.Visible = false;
            this.MySokcets = xrs;
            Messenger.Default.Register<string>(this, "loginform", new Action<string>(OnMessengerReceive));
            MySokcets.OnLoginRequestResponse += new OnReceivedLoginResponse(LoginResponseProcess);
        }
        void LoginResponseProcess(LoginRequestResponse Lr)
        {
            if (Lr.Logincode == LoginCode.LOGIN_SUCCESS)
            {
                MessageBox.Show("Giriş Başarılı");
                this.Close();
            }
            else
            {
                MessageBox.Show(LoginCode.PASSWORD_INCORRECT.ToString());
            }
        }

        private void formuac(object sender, EventArgs e)
        {
            MySokcets.TryConnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.btn_login.Enabled = false;
            MySokcets.SendLoginRequest(txt_username.Text, txt_password.Text);

            this.btn_login.Enabled = true;
        }
        private void OnMessengerReceive(string d)
        {
            if (d.StartsWith("TRY_TO_CONNECT"))
            {
                label1.Text = "Bağlanmaya çalşıyor...";
                label1.Visible = true;
            }
            else if (d.StartsWith("CONNECTION_PROBLEM"))
            {
                label1.Text = "Servera Bağlanılamadı.";
                //label1.Visible = false;
            }
        }
    }
}
