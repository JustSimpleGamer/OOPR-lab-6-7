using lab_4_5.Enums;
using lab_4_5.Models;
using Microsoft.EntityFrameworkCore;

namespace lab_6_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TabControl_MainTabs.SelectTab((int)Tabs.SignUp);
        }

        private void TabControl_MainTabs_Selected(object sender, TabControlEventArgs e)
        {
            //Administrator
            if (TabControl_MainTabs.SelectedIndex == (int)Tabs.Administrator)
            {
                Administrator = new AdministratorVm();

                using (ApplicationContext db = new ApplicationContext())
                {
                    List<ClientVm> clients = db.Clients.Include(x => x.Request).Include(y => y.Request.Apartment).ToList();
                    for (int i = 0; i < clients.Count; i++)
                    {
                        ClientManagerVm temp = new ClientManagerVm(clients[i]);
                        Administrator.ClientsManagers.Add(temp);
                    }
                }

                if (Administrator.ClientsManagers.Count == 0)
                {
                    Tab_Administrator_Panel_RequesList.Visible = false;
                    Tab_Administrator_Button_NextRequest.Enabled = false;
                    return;
                }
                Tab_Administrator_Panel_RequesList.Visible = true;
                if (Administrator.ClientsManagers.Count == 1)
                {
                    Tab_Administrator_Button_NextRequest.Enabled = false;
                }
                else
                {
                    Tab_Administrator_Button_NextRequest.Enabled = true;
                }
                Administrator.ShowRequest(Tab_Administrator_Label_ClientName, Tab_Administrator_Label_ClientSurname, Tab_Administrator_Label_ClientPatronymic, Tab_Administrator_Label_ClientPhoneNumber, Tab_Administrator_Label_SleepingPlacesNumber, Tab_Administrator_Label_ApartmentÑlass, Tab_Administrator_Label_StayTime, Tab_Administrator_Label_RequestState, Tab_Administrator_Button_ConfirmRequest, Tab_Administrator_Button_DeclineRequest);
            }

            //Client
            if (TabControl_MainTabs.SelectedIndex == (int)Tabs.Client)
            {
                AuthorizedClientManager.Client = AuthorizedClientFileManager.LoadClient();

                if (AuthorizedClientManager.Client.Request == null)
                {
                    Tab_Client_Panel_RequesForm.Visible = false;
                    return;
                }
                Tab_Client_Panel_RequesForm.Visible = true;

                if (AuthorizedClientManager.Client.Request.State == RequestStates.Ðîçëÿäàºòüñÿ || AuthorizedClientManager.Client.Request.State == RequestStates.Â³äõèëåíî)
                {
                    Tab_Client_Button_Pay.Enabled = false;
                }
                else
                {
                    Tab_Client_Button_Pay.Enabled = true;
                }

                Tab_Client_Label_ClientName.Text = AuthorizedClientManager.Client.Name;
                Tab_Client_Label_ClientSurname.Text = AuthorizedClientManager.Client.Surname;
                Tab_Client_Label_ClientPatronymic.Text = AuthorizedClientManager.Client.Patronymic;
                Tab_Client_Label_ClientPhoneNumber.Text = AuthorizedClientManager.Client.PhoneNumber;
                Tab_Client_Label_SleepingPlacesNumber.Text = AuthorizedClientManager.Client.Request.Apartment.SleepingPlacesNumber;
                Tab_Client_Label_ApartmentÑlass.Text = AuthorizedClientManager.Client.Request.Apartment.ApartmentÑlass;
                Tab_Client_Label_StayTime.Text = AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Days].ToString() + " Äí³â " + AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Hours].ToString() + " Ãîäèí " + AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Minutes].ToString() + " Õâèëèí";
                Tab_Client_Label_RequestState.Text = AuthorizedClientManager.Client.Request.State.ToString();
            }

            //Request
            if (TabControl_MainTabs.SelectedIndex == (int)Tabs.Request)
            {
                RequestStayTimeDays = 0;
                Tab_Request_Label_DaysCount.Text = RequestStayTimeDays.ToString();
                RequestStayTimeHours = 0;
                Tab_Request_Label_HoursCount.Text = RequestStayTimeHours.ToString();
                RequestStayTimeMinutes = 0;
                Tab_Request_Label_MinutesCount.Text = RequestStayTimeMinutes.ToString();

                Tab_Request_Button_DaysUp.Enabled = true;
                Tab_Request_Button_DaysDown.Enabled = false;
                Tab_Request_Button_HoursUp.Enabled = true;
                Tab_Request_Button_HoursDown.Enabled = false;
                Tab_Request_Button_MinutesUp.Enabled = true;
                Tab_Request_Button_MinutesDown.Enabled = false;
            }
        }
        //Administrator
        public AdministratorVm Administrator;

        private void Tab_Administrator_Button_NextRequest_Click(object sender, EventArgs e)
        {
            Administrator.Index++;

            try
            {
                ClientManagerVm IsException = Administrator[Administrator.Index + 1];
            }
            catch (Exception)
            {
                Tab_Administrator_Button_NextRequest.Enabled = false;
                Tab_Administrator_Button_PrevRequest.Enabled = true;
                Administrator.ShowRequest(Tab_Administrator_Label_ClientName, Tab_Administrator_Label_ClientSurname, Tab_Administrator_Label_ClientPatronymic, Tab_Administrator_Label_ClientPhoneNumber, Tab_Administrator_Label_SleepingPlacesNumber, Tab_Administrator_Label_ApartmentÑlass, Tab_Administrator_Label_StayTime, Tab_Administrator_Label_RequestState, Tab_Administrator_Button_ConfirmRequest, Tab_Administrator_Button_DeclineRequest);
                return;
            }
            Tab_Administrator_Button_PrevRequest.Enabled = true;
            Administrator.ShowRequest(Tab_Administrator_Label_ClientName, Tab_Administrator_Label_ClientSurname, Tab_Administrator_Label_ClientPatronymic, Tab_Administrator_Label_ClientPhoneNumber, Tab_Administrator_Label_SleepingPlacesNumber, Tab_Administrator_Label_ApartmentÑlass, Tab_Administrator_Label_StayTime, Tab_Administrator_Label_RequestState, Tab_Administrator_Button_ConfirmRequest, Tab_Administrator_Button_DeclineRequest);
        }

        private void Tab_Administrator_Button_PrevRequest_Click(object sender, EventArgs e)
        {
            Administrator.Index--;
            try
            {
                ClientManagerVm IsException = Administrator[Administrator.Index - 1];
            }
            catch (Exception)
            {
                Tab_Administrator_Button_NextRequest.Enabled = true;
                Tab_Administrator_Button_PrevRequest.Enabled = false;
                Administrator.ShowRequest(Tab_Administrator_Label_ClientName, Tab_Administrator_Label_ClientSurname, Tab_Administrator_Label_ClientPatronymic, Tab_Administrator_Label_ClientPhoneNumber, Tab_Administrator_Label_SleepingPlacesNumber, Tab_Administrator_Label_ApartmentÑlass, Tab_Administrator_Label_StayTime, Tab_Administrator_Label_RequestState, Tab_Administrator_Button_ConfirmRequest, Tab_Administrator_Button_DeclineRequest);
                return;
            }
            Tab_Administrator_Button_NextRequest.Enabled = true;
            Administrator.ShowRequest(Tab_Administrator_Label_ClientName, Tab_Administrator_Label_ClientSurname, Tab_Administrator_Label_ClientPatronymic, Tab_Administrator_Label_ClientPhoneNumber, Tab_Administrator_Label_SleepingPlacesNumber, Tab_Administrator_Label_ApartmentÑlass, Tab_Administrator_Label_StayTime, Tab_Administrator_Label_RequestState, Tab_Administrator_Button_ConfirmRequest, Tab_Administrator_Button_DeclineRequest);
        }

        private void Tab_Administrator_Button_ConfirmRequest_Click(object sender, EventArgs e)
        {
            Administrator[Administrator.Index].Client.Request.State = RequestStates.Ñâàëåíî;
            Tab_Administrator_Label_RequestState.Text = "Ñâàëåíî";
            ClientManagerVm currentAdminisatrorClientManager = new ClientManagerVm(Administrator[Administrator.Index].Client);
            ClientFileManagerVm currentAdminisatrorClientFileManager = new ClientFileManagerVm(ref currentAdminisatrorClientManager);
            currentAdminisatrorClientFileManager.SaveClient();
        }

        private void Tab_Administrator_Button_DeclineRequest_Click(object sender, EventArgs e)
        {
            Administrator[Administrator.Index].Client.Request.State = RequestStates.Â³äõèëåíî;
            Tab_Administrator_Label_RequestState.Text = "Â³äõèëåíî";
            ClientManagerVm currentAdminisatrorClientManager = new ClientManagerVm(Administrator[Administrator.Index].Client);
            ClientFileManagerVm currentAdminisatrorClientFileManager = new ClientFileManagerVm(ref currentAdminisatrorClientManager);
            currentAdminisatrorClientFileManager.SaveClient();
        }

        private void Tab_Administrator_Button_MoveToSignIn_Click(object sender, EventArgs e)
        {
            TabControl_MainTabs.SelectTab((int)Tabs.SignUp);
        }

        //Client
        public ClientManagerVm AuthorizedClientManager;
        public ClientFileManagerVm AuthorizedClientFileManager;

        private void Tab_Client_Button_MoveToRequest_Click(object sender, EventArgs e)
        {
            TabControl_MainTabs.SelectTab((int)Tabs.Request);
        }
        private void Tab_Client_Button_MoveToSignIn_Click(object sender, EventArgs e)
        {
            TabControl_MainTabs.SelectTab((int)Tabs.SignUp);
        }
        private void Tab_Client_Button_Pay_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Apartments.Remove(AuthorizedClientManager.Client.Request.Apartment);
                db.Requests.Remove(AuthorizedClientManager.Client.Request);
                AuthorizedClientManager.Client.Request = null;
                AuthorizedClientManager.Client.RequestId = null;
                db.Update(AuthorizedClientManager.Client);
                db.SaveChanges();
            }
            Tab_Client_Panel_RequesForm.Visible = false;
        }

        //SignIn
        private void Tab_SignIn_Button_SignIn_Click(object sender, EventArgs e)
        {
            string ClinetName = Tab_SignIn_TextBox_ClientName.Text;
            string ClientSurname = Tab_SignIn_TextBox_ClientSurname.Text;
            string ClientPatronymic = Tab_SignIn_TextBox_ClientPatronymic.Text;
            string ClientPassword = Tab_SignIn_TextBox_ClientPassword.Text;

            if (ClinetName == "" || ClientSurname == "" || ClientPatronymic == "" || ClientPassword == "")
            {
                MessageBox.Show("Áóäü-ëàñêà, çàïîâí³ñòü óñ³ ïîëÿ", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            AuthorizedClientManager = new ClientManagerVm(ClinetName, ClientSurname, ClientPatronymic, ClientPassword);
            AuthorizedClientFileManager = new ClientFileManagerVm(ref AuthorizedClientManager);

            if (AuthorizedClientFileManager.IsAllClientAuthorizationDataCorrect() == true)
            {
                ClientVm AuthorizedClient = AuthorizedClientFileManager.LoadClient();
                AuthorizedClientManager = new ClientManagerVm(AuthorizedClient);
                AuthorizedClientFileManager = new ClientFileManagerVm(ref AuthorizedClientManager);

                MessageBox.Show("Àâòîðèçàö³ÿ ïðîéøëà óñï³øíî", "Óñ³ïõ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                TabControl_MainTabs.SelectTab((int)Tabs.Client);
                return;
            }

            MessageBox.Show("Âè íåïðàâèëüíî ââåëè ³í³ö³àëè àáî ïàðîëü", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        //SignUp
        private void Tab_SignUp_Button_SignUp_Click(object sender, EventArgs e)
        {
            string ClinetName = Tab_SignUp_TextBox_ClientName.Text;
            string ClientSurname = Tab_SignUp_TextBox_ClientSurname.Text;
            string ClientPatronymic = Tab_SignUp_TextBox_ClientPatronymic.Text;
            string ClientPhoneNumber = Tab_SignUp_TextBox_ClientPhoneNumber.Text;
            string ClientStatus = Tab_SignUp_ComboBox_ClientStatus.Text;
            string ClientPassword = Tab_SignUp_TextBox_ClientPassword.Text;
            string ClientPasswordÑonfirmation = Tab_SignUp_TextBox_ClientPasswordÑonfirmation.Text;

            if (ClinetName == "" || ClientSurname == "" || ClientPatronymic == "" || ClientPhoneNumber == "" || ClientStatus == "" || ClientPassword == "" || ClientPasswordÑonfirmation == "")
            {
                MessageBox.Show("Áóäü-ëàñêà, çàïîâí³ñòü óñ³ ïîëÿ", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            if (ClientPassword != ClientPasswordÑonfirmation)
            {
                MessageBox.Show("Áóäü-ëàñêà, ââåäåí³ ïàðîëü ³ ï³äòâåðäæåííÿ ïàðîëþ ïîâèíí³ áóòè îäàêîâèìè", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            ClientVm newClient = new ClientVm(ClinetName, ClientSurname, ClientPatronymic, ClientPhoneNumber, ClientStatus, ClientPassword);
            ClientManagerVm newClientManager = new ClientManagerVm(newClient);
            ClientFileManagerVm newClientFileManagerVm = new ClientFileManagerVm(ref newClientManager);
            if (newClientFileManagerVm.CreateProfile() == false)
            {
                MessageBox.Show("Êë³ºíò ç äàíèìè ³í³ö³àëàìè âæå ³ñíóº", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            MessageBox.Show("Ïðîô³ëü áóëî óñï³øíî ñòâîðåíî", "Óñï³õ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void Tab_SignUp_TextBox_ClientPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tab_SignUp_TextBox_ClientPhoneNumber.TextLength; i++)
            {
                if (Tab_SignUp_TextBox_ClientPhoneNumber.Text[i] < '0' || Tab_SignUp_TextBox_ClientPhoneNumber.Text[i] > '9')
                {
                    Tab_SignUp_TextBox_ClientPhoneNumber.Text = Tab_SignUp_TextBox_ClientPhoneNumber.Text.Remove(i, 1);
                    return;
                }
            }
        }

        //Request
        public int RequestStayTimeDays = 0;
        public int RequestStayTimeHours = 0;
        public int RequestStayTimeMinutes = 0;

        private void Tab_Request_Buttonn_SendRequest_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeDays == 0 && RequestStayTimeHours == 0 && RequestStayTimeMinutes == 0)
            {
                MessageBox.Show("Áóäü-ëàñêà, çàãàëüíèé ÷àñ ïåðåáóâàííÿ ó íîìåð³ íå ïîâèíåí äîð³âíþâàòè íóëþ", "Ïîìèëêà", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            if(AuthorizedClientManager.Client.Request != null)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    db.Apartments.Remove(AuthorizedClientManager.Client.Request.Apartment);
                    db.Requests.Remove(AuthorizedClientManager.Client.Request);
                    AuthorizedClientManager.Client.Request = null;
                    AuthorizedClientManager.Client.RequestId = null;
                    db.Update(AuthorizedClientManager.Client);
                    db.SaveChanges();
                }
            }

            AuthorizedClientManager.Client.Request = new RequestVm();

            AuthorizedClientManager.Client.Request.Apartment.SleepingPlacesNumber = Tab_Request_ComboBox_SleepingPlacesNumber.Text;
            AuthorizedClientManager.Client.Request.Apartment.ApartmentÑlass = Tab_Request_ComboBox_ApartmentÑlass.Text;
            AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Days] = RequestStayTimeDays;
            AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Hours] = RequestStayTimeHours;
            AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Minutes] = RequestStayTimeMinutes;

            AuthorizedClientManager.Client.RequestId = AuthorizedClientManager.Client.Request.Id;

            AuthorizedClientFileManager.SaveClient();

            MessageBox.Show("Çàÿâêà áóëà óñï³øíî ïîäàíà íà ðîçãëÿäàííÿ", "Óñï³õ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            TabControl_MainTabs.SelectTab((int)Tabs.Client);
        }

        private void Tab_Request_Button_MoveToClient_Click(object sender, EventArgs e)
        {
            TabControl_MainTabs.SelectTab((int)Tabs.Client);
        }

        private void Tab_Request_Button_DaysUp_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeDays >= 364)
            {
                Tab_Request_Button_DaysUp.Enabled = false;
            }
            Tab_Request_Button_DaysDown.Enabled = true;
            RequestStayTimeDays++;
            Tab_Request_Label_DaysCount.Text = RequestStayTimeDays.ToString();
        }
        private void Tab_Request_Button_DaysDown_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeDays <= 1)
            {
                Tab_Request_Button_DaysDown.Enabled = false;
            }
            Tab_Request_Button_DaysUp.Enabled = true;
            RequestStayTimeDays--;
            Tab_Request_Label_DaysCount.Text = RequestStayTimeDays.ToString();
        }
        private void Tab_Request_Button_HoursUp_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeHours >= 23)
            {
                Tab_Request_Button_HoursUp.Enabled = false;
            }
            Tab_Request_Button_HoursDown.Enabled = true;
            RequestStayTimeHours++;
            Tab_Request_Label_HoursCount.Text = RequestStayTimeHours.ToString();
        }
        private void Tab_Request_Button_HoursDown_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeHours <= 1)
            {
                Tab_Request_Button_HoursDown.Enabled = false;
            }
            Tab_Request_Button_HoursUp.Enabled = true;
            RequestStayTimeHours--;
            Tab_Request_Label_HoursCount.Text = RequestStayTimeHours.ToString();
        }
        private void Tab_Request_Button_MinutesUp_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeMinutes >= 59)
            {
                Tab_Request_Button_MinutesUp.Enabled = false;
            }
            Tab_Request_Button_MinutesDown.Enabled = true;
            RequestStayTimeMinutes++;
            Tab_Request_Label_MinutesCount.Text = RequestStayTimeMinutes.ToString();
        }
        private void Tab_Request_Button_MinutesDown_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeMinutes <= 1)
            {
                Tab_Request_Button_MinutesDown.Enabled = false;
            }
            Tab_Request_Button_MinutesUp.Enabled = true;
            RequestStayTimeMinutes--;
            Tab_Request_Label_MinutesCount.Text = RequestStayTimeMinutes.ToString();
        }

        //Other
        private void Tab_SignIn_Button_EnterTemplate_Click(object sender, EventArgs e)
        {
            Tab_SignIn_TextBox_ClientName.Text = "Ìàêñèì";
            Tab_SignIn_TextBox_ClientSurname.Text = "Øóíåâè÷";
            Tab_SignIn_TextBox_ClientPatronymic.Text = "Îëåêñ³éîâè÷";
            Tab_SignIn_TextBox_ClientPassword.Text = "Password";
        }
        private void Tab_SignUp_Button_EnterTemplate_Click(object sender, EventArgs e)
        {
            Tab_SignUp_TextBox_ClientName.Text = "Ìàêñèì";
            Tab_SignUp_TextBox_ClientSurname.Text = "Øóíåâè÷";
            Tab_SignUp_TextBox_ClientPatronymic.Text = "Îëåêñ³éîâè÷";
            Tab_SignUp_TextBox_ClientPhoneNumber.Text = "0673802728";
            Tab_SignUp_ComboBox_ClientStatus.Text = "VIP";
            Tab_SignUp_TextBox_ClientPassword.Text = "Password";
            Tab_SignUp_TextBox_ClientPasswordÑonfirmation.Text = "Password";
        }
    }
}
