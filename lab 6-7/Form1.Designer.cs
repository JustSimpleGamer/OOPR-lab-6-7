namespace lab_6_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TabControl_MainTabs = new TabControl();
            Tab_SignIn = new TabPage();
            Tab_SignIn_Button_EnterTemplate = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            Tab_SignIn_Button_SignIn = new Button();
            Tab_SignIn_TextBox_ClientPassword = new TextBox();
            Tab_SignIn_TextBox_ClientSurname = new TextBox();
            Tab_SignIn_TextBox_ClientPatronymic = new TextBox();
            Tab_SignIn_TextBox_ClientName = new TextBox();
            Tab_SignUp = new TabPage();
            Tab_SignUp_Button_EnterTemplate = new Button();
            panel11 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            Tab_SignUp_ComboBox_ClientStatus = new ComboBox();
            Tab_SignUp_Button_SignUp = new Button();
            Tab_SignUp_TextBox_ClientPasswordСonfirmation = new TextBox();
            Tab_SignUp_TextBox_ClientPassword = new TextBox();
            Tab_SignUp_TextBox_ClientSurname = new TextBox();
            Tab_SignUp_TextBox_ClientPatronymic = new TextBox();
            Tab_SignUp_TextBox_ClientPhoneNumber = new TextBox();
            Tab_SignUp_TextBox_ClientName = new TextBox();
            Tab_Aministrator = new TabPage();
            Tab_Administrator_Panel_RequesList = new Panel();
            Tab_Administrator_Label_RequestState = new Label();
            Tab_Administrator_LabelText_RequestState = new Label();
            Tab_Administrator_Label_StayTime = new Label();
            Tab_Administrator_LabelText_StayTime = new Label();
            Tab_Administrator_Label_ApartmentСlass = new Label();
            Tab_Administrator_LabelText_ApartmentСlass = new Label();
            Tab_Administrator_Label_SleepingPlacesNumber = new Label();
            Tab_Administrator_LabelText_SleepingPlacesNumber = new Label();
            Tab_Administrator_Label_ClientPhoneNumber = new Label();
            Tab_Administrator_LabelText_ClientPhoneNumber = new Label();
            Tab_Administrator_Label_ClientPatronymic = new Label();
            Tab_Administrator_LabelText_ClientPatronymic = new Label();
            Tab_Administrator_Label_ClientSurname = new Label();
            Tab_Administrator_LabelText_ClientSurname = new Label();
            Tab_Administrator_Label_ClientName = new Label();
            Tab_Administrator_LabelText_ClientName = new Label();
            Tab_Administrator_Button_DeclineRequest = new Button();
            Tab_Administrator_Button_NextRequest = new Button();
            Tab_Administrator_Button_ConfirmRequest = new Button();
            Tab_Administrator_Button_PrevRequest = new Button();
            Tab_Administrator_Button_MoveToSignIn = new Button();
            label1 = new Label();
            Tab_Client = new TabPage();
            Tab_Client_Button_MoveToRequest = new Button();
            Tab_Client_Button_MoveToSignIn = new Button();
            Tab_Client_Panel_RequesForm = new Panel();
            Tab_Client_Button_Pay = new Button();
            Tab_Client_Label_RequestState = new Label();
            Tab_Client_LabelText_RequestState = new Label();
            Tab_Client_Label_StayTime = new Label();
            Tab_Client_LabelText_StayTime = new Label();
            Tab_Client_Label_ApartmentСlass = new Label();
            Tab_Client_LabelText_ApartmentСlass = new Label();
            Tab_Client_Label_SleepingPlacesNumber = new Label();
            Tab_Client_LabelText_SleepingPlacesNumber = new Label();
            Tab_Client_Label_ClientPhoneNumber = new Label();
            Tab_Client_LabelText_ClientPhoneNumber = new Label();
            Tab_Client_Label_ClientPatronymic = new Label();
            Tab_Client_LabelText_ClientPatronymic = new Label();
            Tab_Client_Label_ClientSurname = new Label();
            Tab_Client_LabelText_ClientSurname = new Label();
            Tab_Client_Label_ClientName = new Label();
            Tab_Client_LabelText_ClientName = new Label();
            label2 = new Label();
            Tab_Request = new TabPage();
            label4 = new Label();
            Tab_Request_LabelText_StayTime = new Label();
            Tab_Request_LabelText_Minutes = new Label();
            Tab_Request_LabelText_Hours = new Label();
            Tab_Request_LabelText_Days = new Label();
            Tab_Request_Label_MinutesCount = new Label();
            Tab_Request_Label_HoursCount = new Label();
            Tab_Request_Label_DaysCount = new Label();
            Tab_Request_ComboBox_ApartmentСlass = new ComboBox();
            Tab_Request_ComboBox_SleepingPlacesNumber = new ComboBox();
            Tab_Request_Button_MinutesDown = new Button();
            Tab_Request_Button_MinutesUp = new Button();
            Tab_Request_Button_HoursDown = new Button();
            Tab_Request_Button_HoursUp = new Button();
            Tab_Request_Button_DaysUp = new Button();
            Tab_Request_Button_DaysDown = new Button();
            Tab_Request_Buttonn_SendRequest = new Button();
            Tab_Request_Button_MoveToClient = new Button();
            label3 = new Label();
            Tab_TestZone = new TabPage();
            TabControl_MainTabs.SuspendLayout();
            Tab_SignIn.SuspendLayout();
            Tab_SignUp.SuspendLayout();
            Tab_Aministrator.SuspendLayout();
            Tab_Administrator_Panel_RequesList.SuspendLayout();
            Tab_Client.SuspendLayout();
            Tab_Client_Panel_RequesForm.SuspendLayout();
            Tab_Request.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl_MainTabs
            // 
            TabControl_MainTabs.Controls.Add(Tab_SignIn);
            TabControl_MainTabs.Controls.Add(Tab_SignUp);
            TabControl_MainTabs.Controls.Add(Tab_Aministrator);
            TabControl_MainTabs.Controls.Add(Tab_Client);
            TabControl_MainTabs.Controls.Add(Tab_Request);
            TabControl_MainTabs.Controls.Add(Tab_TestZone);
            TabControl_MainTabs.Location = new Point(-7, -2);
            TabControl_MainTabs.Name = "TabControl_MainTabs";
            TabControl_MainTabs.SelectedIndex = 0;
            TabControl_MainTabs.Size = new Size(798, 670);
            TabControl_MainTabs.TabIndex = 0;
            TabControl_MainTabs.Selected += TabControl_MainTabs_Selected;
            // 
            // Tab_SignIn
            // 
            Tab_SignIn.BackColor = Color.FromArgb(50, 50, 50);
            Tab_SignIn.Controls.Add(Tab_SignIn_Button_EnterTemplate);
            Tab_SignIn.Controls.Add(panel4);
            Tab_SignIn.Controls.Add(panel3);
            Tab_SignIn.Controls.Add(panel2);
            Tab_SignIn.Controls.Add(panel1);
            Tab_SignIn.Controls.Add(Tab_SignIn_Button_SignIn);
            Tab_SignIn.Controls.Add(Tab_SignIn_TextBox_ClientPassword);
            Tab_SignIn.Controls.Add(Tab_SignIn_TextBox_ClientSurname);
            Tab_SignIn.Controls.Add(Tab_SignIn_TextBox_ClientPatronymic);
            Tab_SignIn.Controls.Add(Tab_SignIn_TextBox_ClientName);
            Tab_SignIn.Location = new Point(4, 24);
            Tab_SignIn.Name = "Tab_SignIn";
            Tab_SignIn.Padding = new Padding(3);
            Tab_SignIn.Size = new Size(790, 642);
            Tab_SignIn.TabIndex = 0;
            Tab_SignIn.Text = "Авторизація";
            // 
            // Tab_SignIn_Button_EnterTemplate
            // 
            Tab_SignIn_Button_EnterTemplate.Location = new Point(357, 155);
            Tab_SignIn_Button_EnterTemplate.Name = "Tab_SignIn_Button_EnterTemplate";
            Tab_SignIn_Button_EnterTemplate.Size = new Size(75, 23);
            Tab_SignIn_Button_EnterTemplate.TabIndex = 11;
            Tab_SignIn_Button_EnterTemplate.Text = "Шаблон";
            Tab_SignIn_Button_EnterTemplate.UseVisualStyleBackColor = true;
            Tab_SignIn_Button_EnterTemplate.Click += Tab_SignIn_Button_EnterTemplate_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(230, 230, 230);
            panel4.Location = new Point(406, 234);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 1);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(230, 230, 230);
            panel3.Location = new Point(409, 304);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 1);
            panel3.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(230, 230, 230);
            panel2.Location = new Point(187, 304);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 230, 230);
            panel1.Location = new Point(187, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 1);
            panel1.TabIndex = 5;
            // 
            // Tab_SignIn_Button_SignIn
            // 
            Tab_SignIn_Button_SignIn.BackColor = Color.FromArgb(60, 60, 60);
            Tab_SignIn_Button_SignIn.BackgroundImageLayout = ImageLayout.Zoom;
            Tab_SignIn_Button_SignIn.FlatAppearance.BorderSize = 2;
            Tab_SignIn_Button_SignIn.FlatStyle = FlatStyle.Flat;
            Tab_SignIn_Button_SignIn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tab_SignIn_Button_SignIn.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_SignIn_Button_SignIn.Location = new Point(290, 394);
            Tab_SignIn_Button_SignIn.Name = "Tab_SignIn_Button_SignIn";
            Tab_SignIn_Button_SignIn.Size = new Size(210, 48);
            Tab_SignIn_Button_SignIn.TabIndex = 4;
            Tab_SignIn_Button_SignIn.Text = "Авторизуватися";
            Tab_SignIn_Button_SignIn.UseVisualStyleBackColor = false;
            Tab_SignIn_Button_SignIn.Click += Tab_SignIn_Button_SignIn_Click;
            // 
            // Tab_SignIn_TextBox_ClientPassword
            // 
            Tab_SignIn_TextBox_ClientPassword.BackColor = Color.FromArgb(60, 60, 60);
            Tab_SignIn_TextBox_ClientPassword.BorderStyle = BorderStyle.None;
            Tab_SignIn_TextBox_ClientPassword.Font = new Font("Segoe UI", 18F);
            Tab_SignIn_TextBox_ClientPassword.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_SignIn_TextBox_ClientPassword.Location = new Point(409, 270);
            Tab_SignIn_TextBox_ClientPassword.Name = "Tab_SignIn_TextBox_ClientPassword";
            Tab_SignIn_TextBox_ClientPassword.PlaceholderText = "Пароль";
            Tab_SignIn_TextBox_ClientPassword.Size = new Size(200, 32);
            Tab_SignIn_TextBox_ClientPassword.TabIndex = 3;
            // 
            // Tab_SignIn_TextBox_ClientSurname
            // 
            Tab_SignIn_TextBox_ClientSurname.BackColor = Color.FromArgb(60, 60, 60);
            Tab_SignIn_TextBox_ClientSurname.BorderStyle = BorderStyle.None;
            Tab_SignIn_TextBox_ClientSurname.Font = new Font("Segoe UI", 18F);
            Tab_SignIn_TextBox_ClientSurname.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_SignIn_TextBox_ClientSurname.Location = new Point(187, 270);
            Tab_SignIn_TextBox_ClientSurname.Name = "Tab_SignIn_TextBox_ClientSurname";
            Tab_SignIn_TextBox_ClientSurname.PlaceholderText = "Прізвище";
            Tab_SignIn_TextBox_ClientSurname.Size = new Size(200, 32);
            Tab_SignIn_TextBox_ClientSurname.TabIndex = 2;
            // 
            // Tab_SignIn_TextBox_ClientPatronymic
            // 
            Tab_SignIn_TextBox_ClientPatronymic.BackColor = Color.FromArgb(60, 60, 60);
            Tab_SignIn_TextBox_ClientPatronymic.BorderStyle = BorderStyle.None;
            Tab_SignIn_TextBox_ClientPatronymic.Font = new Font("Segoe UI", 18F);
            Tab_SignIn_TextBox_ClientPatronymic.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_SignIn_TextBox_ClientPatronymic.Location = new Point(406, 200);
            Tab_SignIn_TextBox_ClientPatronymic.Name = "Tab_SignIn_TextBox_ClientPatronymic";
            Tab_SignIn_TextBox_ClientPatronymic.PlaceholderText = "По батькові";
            Tab_SignIn_TextBox_ClientPatronymic.Size = new Size(200, 32);
            Tab_SignIn_TextBox_ClientPatronymic.TabIndex = 1;
            // 
            // Tab_SignIn_TextBox_ClientName
            // 
            Tab_SignIn_TextBox_ClientName.BackColor = Color.FromArgb(60, 60, 60);
            Tab_SignIn_TextBox_ClientName.BorderStyle = BorderStyle.None;
            Tab_SignIn_TextBox_ClientName.Font = new Font("Segoe UI", 18F);
            Tab_SignIn_TextBox_ClientName.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_SignIn_TextBox_ClientName.Location = new Point(187, 200);
            Tab_SignIn_TextBox_ClientName.Name = "Tab_SignIn_TextBox_ClientName";
            Tab_SignIn_TextBox_ClientName.PlaceholderText = "Ім'я";
            Tab_SignIn_TextBox_ClientName.Size = new Size(200, 32);
            Tab_SignIn_TextBox_ClientName.TabIndex = 0;
            // 
            // Tab_SignUp
            // 
            Tab_SignUp.BackColor = Color.FromArgb(50, 50, 50);
            Tab_SignUp.Controls.Add(Tab_SignUp_Button_EnterTemplate);
            Tab_SignUp.Controls.Add(panel11);
            Tab_SignUp.Controls.Add(panel10);
            Tab_SignUp.Controls.Add(panel9);
            Tab_SignUp.Controls.Add(panel8);
            Tab_SignUp.Controls.Add(panel7);
            Tab_SignUp.Controls.Add(panel6);
            Tab_SignUp.Controls.Add(Tab_SignUp_ComboBox_ClientStatus);
            Tab_SignUp.Controls.Add(Tab_SignUp_Button_SignUp);
            Tab_SignUp.Controls.Add(Tab_SignUp_TextBox_ClientPasswordСonfirmation);
            Tab_SignUp.Controls.Add(Tab_SignUp_TextBox_ClientPassword);
            Tab_SignUp.Controls.Add(Tab_SignUp_TextBox_ClientSurname);
            Tab_SignUp.Controls.Add(Tab_SignUp_TextBox_ClientPatronymic);
            Tab_SignUp.Controls.Add(Tab_SignUp_TextBox_ClientPhoneNumber);
            Tab_SignUp.Controls.Add(Tab_SignUp_TextBox_ClientName);
            Tab_SignUp.Location = new Point(4, 24);
            Tab_SignUp.Name = "Tab_SignUp";
            Tab_SignUp.Padding = new Padding(3);
            Tab_SignUp.Size = new Size(790, 642);
            Tab_SignUp.TabIndex = 1;
            Tab_SignUp.Text = "Реєстрація";
            // 
            // Tab_SignUp_Button_EnterTemplate
            // 
            Tab_SignUp_Button_EnterTemplate.Location = new Point(357, 155);
            Tab_SignUp_Button_EnterTemplate.Name = "Tab_SignUp_Button_EnterTemplate";
            Tab_SignUp_Button_EnterTemplate.Size = new Size(75, 23);
            Tab_SignUp_Button_EnterTemplate.TabIndex = 10;
            Tab_SignUp_Button_EnterTemplate.Text = "Шаблон";
            Tab_SignUp_Button_EnterTemplate.UseVisualStyleBackColor = true;
            Tab_SignUp_Button_EnterTemplate.Click += Tab_SignUp_Button_EnterTemplate_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(230, 230, 230);
            panel11.Location = new Point(407, 325);
            panel11.Name = "panel11";
            panel11.Size = new Size(300, 1);
            panel11.TabIndex = 7;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(230, 230, 230);
            panel10.Location = new Point(91, 280);
            panel10.Name = "panel10";
            panel10.Size = new Size(300, 1);
            panel10.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(230, 230, 230);
            panel9.Location = new Point(407, 280);
            panel9.Name = "panel9";
            panel9.Size = new Size(300, 1);
            panel9.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(230, 230, 230);
            panel8.Location = new Point(507, 234);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 1);
            panel8.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(230, 230, 230);
            panel7.Location = new Point(299, 234);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 1);
            panel7.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(230, 230, 230);
            panel6.Location = new Point(91, 234);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 1);
            panel6.TabIndex = 9;
            // 
            // Tab_SignUp_ComboBox_ClientStatus
            // 
            Tab_SignUp_ComboBox_ClientStatus.BackColor = Color.FromArgb(60, 60, 60);
            Tab_SignUp_ComboBox_ClientStatus.FlatStyle = FlatStyle.Flat;
            Tab_SignUp_ComboBox_ClientStatus.Font = new Font("Segoe UI", 18F);
            Tab_SignUp_ComboBox_ClientStatus.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_SignUp_ComboBox_ClientStatus.FormattingEnabled = true;
            Tab_SignUp_ComboBox_ClientStatus.Items.AddRange(new object[] { "Гість", "Постійний клієнт", "VIP" });
            Tab_SignUp_ComboBox_ClientStatus.Location = new Point(91, 289);
            Tab_SignUp_ComboBox_ClientStatus.Name = "Tab_SignUp_ComboBox_ClientStatus";
            Tab_SignUp_ComboBox_ClientStatus.Size = new Size(300, 40);
            Tab_SignUp_ComboBox_ClientStatus.TabIndex = 8;
            // 
            // Tab_SignUp_Button_SignUp
            // 
            Tab_SignUp_Button_SignUp.BackColor = Color.FromArgb(60, 60, 60);
            Tab_SignUp_Button_SignUp.FlatAppearance.BorderSize = 2;
            Tab_SignUp_Button_SignUp.FlatStyle = FlatStyle.Flat;
            Tab_SignUp_Button_SignUp.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tab_SignUp_Button_SignUp.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_SignUp_Button_SignUp.Location = new Point(283, 394);
            Tab_SignUp_Button_SignUp.Name = "Tab_SignUp_Button_SignUp";
            Tab_SignUp_Button_SignUp.Size = new Size(224, 48);
            Tab_SignUp_Button_SignUp.TabIndex = 7;
            Tab_SignUp_Button_SignUp.Text = "Зареєструватися";
            Tab_SignUp_Button_SignUp.UseVisualStyleBackColor = false;
            Tab_SignUp_Button_SignUp.Click += Tab_SignUp_Button_SignUp_Click;
            // 
            // Tab_SignUp_TextBox_ClientPasswordСonfirmation
            // 
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.BackColor = Color.FromArgb(60, 60, 60);
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.BorderStyle = BorderStyle.None;
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.Font = new Font("Segoe UI", 18F);
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.Location = new Point(407, 291);
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.Name = "Tab_SignUp_TextBox_ClientPasswordСonfirmation";
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.PlaceholderText = "Підтверждження паролю";
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.Size = new Size(300, 32);
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.TabIndex = 6;
            // 
            // Tab_SignUp_TextBox_ClientPassword
            // 
            Tab_SignUp_TextBox_ClientPassword.BackColor = Color.FromArgb(60, 60, 60);
            Tab_SignUp_TextBox_ClientPassword.BorderStyle = BorderStyle.None;
            Tab_SignUp_TextBox_ClientPassword.Font = new Font("Segoe UI", 18F);
            Tab_SignUp_TextBox_ClientPassword.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_SignUp_TextBox_ClientPassword.Location = new Point(407, 246);
            Tab_SignUp_TextBox_ClientPassword.Name = "Tab_SignUp_TextBox_ClientPassword";
            Tab_SignUp_TextBox_ClientPassword.PlaceholderText = "Пароль";
            Tab_SignUp_TextBox_ClientPassword.Size = new Size(300, 32);
            Tab_SignUp_TextBox_ClientPassword.TabIndex = 5;
            // 
            // Tab_SignUp_TextBox_ClientSurname
            // 
            Tab_SignUp_TextBox_ClientSurname.BackColor = Color.FromArgb(60, 60, 60);
            Tab_SignUp_TextBox_ClientSurname.BorderStyle = BorderStyle.None;
            Tab_SignUp_TextBox_ClientSurname.Font = new Font("Segoe UI", 18F);
            Tab_SignUp_TextBox_ClientSurname.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_SignUp_TextBox_ClientSurname.Location = new Point(299, 200);
            Tab_SignUp_TextBox_ClientSurname.Name = "Tab_SignUp_TextBox_ClientSurname";
            Tab_SignUp_TextBox_ClientSurname.PlaceholderText = "Прізвище";
            Tab_SignUp_TextBox_ClientSurname.Size = new Size(200, 32);
            Tab_SignUp_TextBox_ClientSurname.TabIndex = 3;
            // 
            // Tab_SignUp_TextBox_ClientPatronymic
            // 
            Tab_SignUp_TextBox_ClientPatronymic.BackColor = Color.FromArgb(60, 60, 60);
            Tab_SignUp_TextBox_ClientPatronymic.BorderStyle = BorderStyle.None;
            Tab_SignUp_TextBox_ClientPatronymic.Font = new Font("Segoe UI", 18F);
            Tab_SignUp_TextBox_ClientPatronymic.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_SignUp_TextBox_ClientPatronymic.Location = new Point(507, 200);
            Tab_SignUp_TextBox_ClientPatronymic.Name = "Tab_SignUp_TextBox_ClientPatronymic";
            Tab_SignUp_TextBox_ClientPatronymic.PlaceholderText = "По батькові";
            Tab_SignUp_TextBox_ClientPatronymic.Size = new Size(200, 32);
            Tab_SignUp_TextBox_ClientPatronymic.TabIndex = 3;
            // 
            // Tab_SignUp_TextBox_ClientPhoneNumber
            // 
            Tab_SignUp_TextBox_ClientPhoneNumber.BackColor = Color.FromArgb(60, 60, 60);
            Tab_SignUp_TextBox_ClientPhoneNumber.BorderStyle = BorderStyle.None;
            Tab_SignUp_TextBox_ClientPhoneNumber.Font = new Font("Segoe UI", 18F);
            Tab_SignUp_TextBox_ClientPhoneNumber.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_SignUp_TextBox_ClientPhoneNumber.Location = new Point(91, 246);
            Tab_SignUp_TextBox_ClientPhoneNumber.Name = "Tab_SignUp_TextBox_ClientPhoneNumber";
            Tab_SignUp_TextBox_ClientPhoneNumber.PlaceholderText = "Номер телефону";
            Tab_SignUp_TextBox_ClientPhoneNumber.Size = new Size(300, 32);
            Tab_SignUp_TextBox_ClientPhoneNumber.TabIndex = 2;
            Tab_SignUp_TextBox_ClientPhoneNumber.TextChanged += Tab_SignUp_TextBox_ClientPhoneNumber_TextChanged;
            // 
            // Tab_SignUp_TextBox_ClientName
            // 
            Tab_SignUp_TextBox_ClientName.BackColor = Color.FromArgb(60, 60, 60);
            Tab_SignUp_TextBox_ClientName.BorderStyle = BorderStyle.None;
            Tab_SignUp_TextBox_ClientName.Font = new Font("Segoe UI", 18F);
            Tab_SignUp_TextBox_ClientName.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_SignUp_TextBox_ClientName.Location = new Point(91, 200);
            Tab_SignUp_TextBox_ClientName.Name = "Tab_SignUp_TextBox_ClientName";
            Tab_SignUp_TextBox_ClientName.PlaceholderText = "Ім'я";
            Tab_SignUp_TextBox_ClientName.Size = new Size(200, 32);
            Tab_SignUp_TextBox_ClientName.TabIndex = 1;
            // 
            // Tab_Aministrator
            // 
            Tab_Aministrator.BackColor = Color.FromArgb(50, 50, 50);
            Tab_Aministrator.Controls.Add(Tab_Administrator_Panel_RequesList);
            Tab_Aministrator.Controls.Add(Tab_Administrator_Button_MoveToSignIn);
            Tab_Aministrator.Controls.Add(label1);
            Tab_Aministrator.Location = new Point(4, 24);
            Tab_Aministrator.Name = "Tab_Aministrator";
            Tab_Aministrator.Size = new Size(790, 642);
            Tab_Aministrator.TabIndex = 2;
            Tab_Aministrator.Text = "Адміністратор";
            // 
            // Tab_Administrator_Panel_RequesList
            // 
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_RequestState);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_RequestState);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_StayTime);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_StayTime);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_ApartmentСlass);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_ApartmentСlass);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_SleepingPlacesNumber);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_SleepingPlacesNumber);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_ClientPhoneNumber);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_ClientPhoneNumber);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_ClientPatronymic);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_ClientPatronymic);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_ClientSurname);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_ClientSurname);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_ClientName);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_ClientName);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Button_DeclineRequest);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Button_NextRequest);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Button_ConfirmRequest);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Button_PrevRequest);
            Tab_Administrator_Panel_RequesList.Location = new Point(33, 120);
            Tab_Administrator_Panel_RequesList.Name = "Tab_Administrator_Panel_RequesList";
            Tab_Administrator_Panel_RequesList.Size = new Size(724, 482);
            Tab_Administrator_Panel_RequesList.TabIndex = 6;
            // 
            // Tab_Administrator_Label_RequestState
            // 
            Tab_Administrator_Label_RequestState.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_Label_RequestState.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_Label_RequestState.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_Label_RequestState.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_Label_RequestState.Location = new Point(364, 362);
            Tab_Administrator_Label_RequestState.Name = "Tab_Administrator_Label_RequestState";
            Tab_Administrator_Label_RequestState.Size = new Size(360, 40);
            Tab_Administrator_Label_RequestState.TabIndex = 21;
            Tab_Administrator_Label_RequestState.Text = "---";
            Tab_Administrator_Label_RequestState.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_LabelText_RequestState
            // 
            Tab_Administrator_LabelText_RequestState.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_LabelText_RequestState.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_LabelText_RequestState.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_LabelText_RequestState.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_LabelText_RequestState.Location = new Point(0, 362);
            Tab_Administrator_LabelText_RequestState.Name = "Tab_Administrator_LabelText_RequestState";
            Tab_Administrator_LabelText_RequestState.Size = new Size(360, 40);
            Tab_Administrator_LabelText_RequestState.TabIndex = 20;
            Tab_Administrator_LabelText_RequestState.Text = "Стан зявки";
            Tab_Administrator_LabelText_RequestState.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_Label_StayTime
            // 
            Tab_Administrator_Label_StayTime.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_Label_StayTime.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_Label_StayTime.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_Label_StayTime.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_Label_StayTime.Location = new Point(364, 316);
            Tab_Administrator_Label_StayTime.Name = "Tab_Administrator_Label_StayTime";
            Tab_Administrator_Label_StayTime.Size = new Size(360, 40);
            Tab_Administrator_Label_StayTime.TabIndex = 19;
            Tab_Administrator_Label_StayTime.Text = "-- -- --";
            Tab_Administrator_Label_StayTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_LabelText_StayTime
            // 
            Tab_Administrator_LabelText_StayTime.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_LabelText_StayTime.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_LabelText_StayTime.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_LabelText_StayTime.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_LabelText_StayTime.Location = new Point(0, 316);
            Tab_Administrator_LabelText_StayTime.Name = "Tab_Administrator_LabelText_StayTime";
            Tab_Administrator_LabelText_StayTime.Size = new Size(360, 40);
            Tab_Administrator_LabelText_StayTime.TabIndex = 18;
            Tab_Administrator_LabelText_StayTime.Text = "Час перебування";
            Tab_Administrator_LabelText_StayTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_Label_ApartmentСlass
            // 
            Tab_Administrator_Label_ApartmentСlass.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_Label_ApartmentСlass.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_Label_ApartmentСlass.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_Label_ApartmentСlass.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_Label_ApartmentСlass.Location = new Point(364, 270);
            Tab_Administrator_Label_ApartmentСlass.Name = "Tab_Administrator_Label_ApartmentСlass";
            Tab_Administrator_Label_ApartmentСlass.Size = new Size(360, 40);
            Tab_Administrator_Label_ApartmentСlass.TabIndex = 17;
            Tab_Administrator_Label_ApartmentСlass.Text = "---";
            Tab_Administrator_Label_ApartmentСlass.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_LabelText_ApartmentСlass
            // 
            Tab_Administrator_LabelText_ApartmentСlass.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_LabelText_ApartmentСlass.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_LabelText_ApartmentСlass.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_LabelText_ApartmentСlass.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_LabelText_ApartmentСlass.Location = new Point(0, 270);
            Tab_Administrator_LabelText_ApartmentСlass.Name = "Tab_Administrator_LabelText_ApartmentСlass";
            Tab_Administrator_LabelText_ApartmentСlass.Size = new Size(360, 40);
            Tab_Administrator_LabelText_ApartmentСlass.TabIndex = 16;
            Tab_Administrator_LabelText_ApartmentСlass.Text = "Клас апартаментів";
            Tab_Administrator_LabelText_ApartmentСlass.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_Label_SleepingPlacesNumber
            // 
            Tab_Administrator_Label_SleepingPlacesNumber.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_Label_SleepingPlacesNumber.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_Label_SleepingPlacesNumber.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_Label_SleepingPlacesNumber.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_Label_SleepingPlacesNumber.Location = new Point(364, 184);
            Tab_Administrator_Label_SleepingPlacesNumber.Name = "Tab_Administrator_Label_SleepingPlacesNumber";
            Tab_Administrator_Label_SleepingPlacesNumber.Size = new Size(360, 80);
            Tab_Administrator_Label_SleepingPlacesNumber.TabIndex = 15;
            Tab_Administrator_Label_SleepingPlacesNumber.Text = "---";
            Tab_Administrator_Label_SleepingPlacesNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_LabelText_SleepingPlacesNumber
            // 
            Tab_Administrator_LabelText_SleepingPlacesNumber.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_LabelText_SleepingPlacesNumber.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_LabelText_SleepingPlacesNumber.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_LabelText_SleepingPlacesNumber.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_LabelText_SleepingPlacesNumber.Location = new Point(0, 184);
            Tab_Administrator_LabelText_SleepingPlacesNumber.Name = "Tab_Administrator_LabelText_SleepingPlacesNumber";
            Tab_Administrator_LabelText_SleepingPlacesNumber.Size = new Size(360, 80);
            Tab_Administrator_LabelText_SleepingPlacesNumber.TabIndex = 14;
            Tab_Administrator_LabelText_SleepingPlacesNumber.Text = "Кількість місць у номері";
            Tab_Administrator_LabelText_SleepingPlacesNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_Label_ClientPhoneNumber
            // 
            Tab_Administrator_Label_ClientPhoneNumber.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_Label_ClientPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_Label_ClientPhoneNumber.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_Label_ClientPhoneNumber.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_Label_ClientPhoneNumber.Location = new Point(364, 138);
            Tab_Administrator_Label_ClientPhoneNumber.Name = "Tab_Administrator_Label_ClientPhoneNumber";
            Tab_Administrator_Label_ClientPhoneNumber.Size = new Size(360, 40);
            Tab_Administrator_Label_ClientPhoneNumber.TabIndex = 13;
            Tab_Administrator_Label_ClientPhoneNumber.Text = "---";
            Tab_Administrator_Label_ClientPhoneNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_LabelText_ClientPhoneNumber
            // 
            Tab_Administrator_LabelText_ClientPhoneNumber.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_LabelText_ClientPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_LabelText_ClientPhoneNumber.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_LabelText_ClientPhoneNumber.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_LabelText_ClientPhoneNumber.Location = new Point(0, 138);
            Tab_Administrator_LabelText_ClientPhoneNumber.Name = "Tab_Administrator_LabelText_ClientPhoneNumber";
            Tab_Administrator_LabelText_ClientPhoneNumber.Size = new Size(360, 40);
            Tab_Administrator_LabelText_ClientPhoneNumber.TabIndex = 12;
            Tab_Administrator_LabelText_ClientPhoneNumber.Text = "Номер телефону";
            Tab_Administrator_LabelText_ClientPhoneNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_Label_ClientPatronymic
            // 
            Tab_Administrator_Label_ClientPatronymic.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_Label_ClientPatronymic.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_Label_ClientPatronymic.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_Label_ClientPatronymic.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_Label_ClientPatronymic.Location = new Point(364, 92);
            Tab_Administrator_Label_ClientPatronymic.Name = "Tab_Administrator_Label_ClientPatronymic";
            Tab_Administrator_Label_ClientPatronymic.Size = new Size(360, 40);
            Tab_Administrator_Label_ClientPatronymic.TabIndex = 11;
            Tab_Administrator_Label_ClientPatronymic.Text = "---";
            Tab_Administrator_Label_ClientPatronymic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_LabelText_ClientPatronymic
            // 
            Tab_Administrator_LabelText_ClientPatronymic.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_LabelText_ClientPatronymic.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_LabelText_ClientPatronymic.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_LabelText_ClientPatronymic.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_LabelText_ClientPatronymic.Location = new Point(0, 92);
            Tab_Administrator_LabelText_ClientPatronymic.Name = "Tab_Administrator_LabelText_ClientPatronymic";
            Tab_Administrator_LabelText_ClientPatronymic.Size = new Size(360, 40);
            Tab_Administrator_LabelText_ClientPatronymic.TabIndex = 10;
            Tab_Administrator_LabelText_ClientPatronymic.Text = "По батькові";
            Tab_Administrator_LabelText_ClientPatronymic.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_Label_ClientSurname
            // 
            Tab_Administrator_Label_ClientSurname.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_Label_ClientSurname.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_Label_ClientSurname.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_Label_ClientSurname.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_Label_ClientSurname.Location = new Point(364, 46);
            Tab_Administrator_Label_ClientSurname.Name = "Tab_Administrator_Label_ClientSurname";
            Tab_Administrator_Label_ClientSurname.Size = new Size(360, 40);
            Tab_Administrator_Label_ClientSurname.TabIndex = 9;
            Tab_Administrator_Label_ClientSurname.Text = "---";
            Tab_Administrator_Label_ClientSurname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_LabelText_ClientSurname
            // 
            Tab_Administrator_LabelText_ClientSurname.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_LabelText_ClientSurname.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_LabelText_ClientSurname.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_LabelText_ClientSurname.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_LabelText_ClientSurname.Location = new Point(0, 46);
            Tab_Administrator_LabelText_ClientSurname.Name = "Tab_Administrator_LabelText_ClientSurname";
            Tab_Administrator_LabelText_ClientSurname.Size = new Size(360, 40);
            Tab_Administrator_LabelText_ClientSurname.TabIndex = 8;
            Tab_Administrator_LabelText_ClientSurname.Text = "Прізвище";
            Tab_Administrator_LabelText_ClientSurname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_Label_ClientName
            // 
            Tab_Administrator_Label_ClientName.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_Label_ClientName.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_Label_ClientName.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_Label_ClientName.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_Label_ClientName.Location = new Point(364, 0);
            Tab_Administrator_Label_ClientName.Name = "Tab_Administrator_Label_ClientName";
            Tab_Administrator_Label_ClientName.Size = new Size(360, 40);
            Tab_Administrator_Label_ClientName.TabIndex = 7;
            Tab_Administrator_Label_ClientName.Text = "---";
            Tab_Administrator_Label_ClientName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_LabelText_ClientName
            // 
            Tab_Administrator_LabelText_ClientName.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_LabelText_ClientName.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_LabelText_ClientName.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_LabelText_ClientName.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_LabelText_ClientName.Location = new Point(0, 0);
            Tab_Administrator_LabelText_ClientName.Name = "Tab_Administrator_LabelText_ClientName";
            Tab_Administrator_LabelText_ClientName.Size = new Size(360, 40);
            Tab_Administrator_LabelText_ClientName.TabIndex = 6;
            Tab_Administrator_LabelText_ClientName.Text = "Ім'я";
            Tab_Administrator_LabelText_ClientName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_Button_DeclineRequest
            // 
            Tab_Administrator_Button_DeclineRequest.BackColor = Color.Transparent;
            Tab_Administrator_Button_DeclineRequest.BackgroundImage = (Image)resources.GetObject("Tab_Administrator_Button_DeclineRequest.BackgroundImage");
            Tab_Administrator_Button_DeclineRequest.BackgroundImageLayout = ImageLayout.Zoom;
            Tab_Administrator_Button_DeclineRequest.FlatAppearance.BorderSize = 0;
            Tab_Administrator_Button_DeclineRequest.FlatStyle = FlatStyle.Flat;
            Tab_Administrator_Button_DeclineRequest.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_Button_DeclineRequest.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_Button_DeclineRequest.Location = new Point(288, 412);
            Tab_Administrator_Button_DeclineRequest.Name = "Tab_Administrator_Button_DeclineRequest";
            Tab_Administrator_Button_DeclineRequest.Size = new Size(60, 60);
            Tab_Administrator_Button_DeclineRequest.TabIndex = 4;
            Tab_Administrator_Button_DeclineRequest.UseVisualStyleBackColor = false;
            Tab_Administrator_Button_DeclineRequest.Click += Tab_Administrator_Button_DeclineRequest_Click;
            // 
            // Tab_Administrator_Button_NextRequest
            // 
            Tab_Administrator_Button_NextRequest.BackColor = Color.Transparent;
            Tab_Administrator_Button_NextRequest.BackgroundImage = (Image)resources.GetObject("Tab_Administrator_Button_NextRequest.BackgroundImage");
            Tab_Administrator_Button_NextRequest.BackgroundImageLayout = ImageLayout.Zoom;
            Tab_Administrator_Button_NextRequest.FlatAppearance.BorderSize = 0;
            Tab_Administrator_Button_NextRequest.FlatStyle = FlatStyle.Flat;
            Tab_Administrator_Button_NextRequest.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_Button_NextRequest.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_Button_NextRequest.Location = new Point(642, 412);
            Tab_Administrator_Button_NextRequest.Name = "Tab_Administrator_Button_NextRequest";
            Tab_Administrator_Button_NextRequest.Size = new Size(60, 60);
            Tab_Administrator_Button_NextRequest.TabIndex = 3;
            Tab_Administrator_Button_NextRequest.UseVisualStyleBackColor = false;
            Tab_Administrator_Button_NextRequest.Click += Tab_Administrator_Button_NextRequest_Click;
            // 
            // Tab_Administrator_Button_ConfirmRequest
            // 
            Tab_Administrator_Button_ConfirmRequest.BackColor = Color.Transparent;
            Tab_Administrator_Button_ConfirmRequest.BackgroundImage = (Image)resources.GetObject("Tab_Administrator_Button_ConfirmRequest.BackgroundImage");
            Tab_Administrator_Button_ConfirmRequest.BackgroundImageLayout = ImageLayout.Zoom;
            Tab_Administrator_Button_ConfirmRequest.FlatAppearance.BorderSize = 0;
            Tab_Administrator_Button_ConfirmRequest.FlatStyle = FlatStyle.Flat;
            Tab_Administrator_Button_ConfirmRequest.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_Button_ConfirmRequest.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_Button_ConfirmRequest.Location = new Point(376, 412);
            Tab_Administrator_Button_ConfirmRequest.Name = "Tab_Administrator_Button_ConfirmRequest";
            Tab_Administrator_Button_ConfirmRequest.Size = new Size(60, 60);
            Tab_Administrator_Button_ConfirmRequest.TabIndex = 5;
            Tab_Administrator_Button_ConfirmRequest.UseVisualStyleBackColor = false;
            Tab_Administrator_Button_ConfirmRequest.Click += Tab_Administrator_Button_ConfirmRequest_Click;
            // 
            // Tab_Administrator_Button_PrevRequest
            // 
            Tab_Administrator_Button_PrevRequest.BackColor = Color.Transparent;
            Tab_Administrator_Button_PrevRequest.BackgroundImage = (Image)resources.GetObject("Tab_Administrator_Button_PrevRequest.BackgroundImage");
            Tab_Administrator_Button_PrevRequest.BackgroundImageLayout = ImageLayout.Zoom;
            Tab_Administrator_Button_PrevRequest.Enabled = false;
            Tab_Administrator_Button_PrevRequest.FlatAppearance.BorderSize = 0;
            Tab_Administrator_Button_PrevRequest.FlatStyle = FlatStyle.Flat;
            Tab_Administrator_Button_PrevRequest.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_Button_PrevRequest.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_Button_PrevRequest.Location = new Point(24, 412);
            Tab_Administrator_Button_PrevRequest.Name = "Tab_Administrator_Button_PrevRequest";
            Tab_Administrator_Button_PrevRequest.Size = new Size(60, 60);
            Tab_Administrator_Button_PrevRequest.TabIndex = 2;
            Tab_Administrator_Button_PrevRequest.UseVisualStyleBackColor = false;
            Tab_Administrator_Button_PrevRequest.Click += Tab_Administrator_Button_PrevRequest_Click;
            // 
            // Tab_Administrator_Button_MoveToSignIn
            // 
            Tab_Administrator_Button_MoveToSignIn.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Administrator_Button_MoveToSignIn.FlatAppearance.BorderSize = 2;
            Tab_Administrator_Button_MoveToSignIn.FlatStyle = FlatStyle.Flat;
            Tab_Administrator_Button_MoveToSignIn.Font = new Font("Segoe UI", 18F);
            Tab_Administrator_Button_MoveToSignIn.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Administrator_Button_MoveToSignIn.Location = new Point(33, 33);
            Tab_Administrator_Button_MoveToSignIn.Name = "Tab_Administrator_Button_MoveToSignIn";
            Tab_Administrator_Button_MoveToSignIn.Size = new Size(230, 48);
            Tab_Administrator_Button_MoveToSignIn.TabIndex = 1;
            Tab_Administrator_Button_MoveToSignIn.Text = "Меню авторизацї";
            Tab_Administrator_Button_MoveToSignIn.UseVisualStyleBackColor = false;
            Tab_Administrator_Button_MoveToSignIn.Click += Tab_Administrator_Button_MoveToSignIn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.FromArgb(230, 230, 230);
            label1.Location = new Point(186, 83);
            label1.Name = "label1";
            label1.Size = new Size(400, 100);
            label1.TabIndex = 0;
            label1.Text = "Перелік залишених заявок:\r\n\r\nНа даний момент, заявок немає\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Client
            // 
            Tab_Client.BackColor = Color.FromArgb(50, 50, 50);
            Tab_Client.Controls.Add(Tab_Client_Button_MoveToRequest);
            Tab_Client.Controls.Add(Tab_Client_Button_MoveToSignIn);
            Tab_Client.Controls.Add(Tab_Client_Panel_RequesForm);
            Tab_Client.Controls.Add(label2);
            Tab_Client.Location = new Point(4, 24);
            Tab_Client.Name = "Tab_Client";
            Tab_Client.Size = new Size(790, 642);
            Tab_Client.TabIndex = 3;
            Tab_Client.Text = "Клієнт";
            // 
            // Tab_Client_Button_MoveToRequest
            // 
            Tab_Client_Button_MoveToRequest.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_Button_MoveToRequest.FlatAppearance.BorderSize = 2;
            Tab_Client_Button_MoveToRequest.FlatStyle = FlatStyle.Flat;
            Tab_Client_Button_MoveToRequest.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tab_Client_Button_MoveToRequest.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_Button_MoveToRequest.Location = new Point(496, 33);
            Tab_Client_Button_MoveToRequest.Name = "Tab_Client_Button_MoveToRequest";
            Tab_Client_Button_MoveToRequest.Size = new Size(261, 48);
            Tab_Client_Button_MoveToRequest.TabIndex = 8;
            Tab_Client_Button_MoveToRequest.Text = "Оформлення заявки";
            Tab_Client_Button_MoveToRequest.UseVisualStyleBackColor = false;
            Tab_Client_Button_MoveToRequest.Click += Tab_Client_Button_MoveToRequest_Click;
            // 
            // Tab_Client_Button_MoveToSignIn
            // 
            Tab_Client_Button_MoveToSignIn.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_Button_MoveToSignIn.FlatAppearance.BorderSize = 2;
            Tab_Client_Button_MoveToSignIn.FlatStyle = FlatStyle.Flat;
            Tab_Client_Button_MoveToSignIn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tab_Client_Button_MoveToSignIn.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_Button_MoveToSignIn.Location = new Point(33, 33);
            Tab_Client_Button_MoveToSignIn.Name = "Tab_Client_Button_MoveToSignIn";
            Tab_Client_Button_MoveToSignIn.Size = new Size(230, 48);
            Tab_Client_Button_MoveToSignIn.TabIndex = 5;
            Tab_Client_Button_MoveToSignIn.Text = "Меню авторизацї";
            Tab_Client_Button_MoveToSignIn.UseVisualStyleBackColor = false;
            Tab_Client_Button_MoveToSignIn.Click += Tab_Client_Button_MoveToSignIn_Click;
            // 
            // Tab_Client_Panel_RequesForm
            // 
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Button_Pay);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_RequestState);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_RequestState);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_StayTime);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_StayTime);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_ApartmentСlass);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_ApartmentСlass);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_SleepingPlacesNumber);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_SleepingPlacesNumber);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_ClientPhoneNumber);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_ClientPhoneNumber);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_ClientPatronymic);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_ClientPatronymic);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_ClientSurname);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_ClientSurname);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_ClientName);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_ClientName);
            Tab_Client_Panel_RequesForm.Location = new Point(33, 120);
            Tab_Client_Panel_RequesForm.Name = "Tab_Client_Panel_RequesForm";
            Tab_Client_Panel_RequesForm.Size = new Size(724, 482);
            Tab_Client_Panel_RequesForm.TabIndex = 7;
            // 
            // Tab_Client_Button_Pay
            // 
            Tab_Client_Button_Pay.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_Button_Pay.FlatAppearance.BorderSize = 2;
            Tab_Client_Button_Pay.FlatStyle = FlatStyle.Flat;
            Tab_Client_Button_Pay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tab_Client_Button_Pay.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_Button_Pay.Location = new Point(252, 418);
            Tab_Client_Button_Pay.Name = "Tab_Client_Button_Pay";
            Tab_Client_Button_Pay.Size = new Size(220, 48);
            Tab_Client_Button_Pay.TabIndex = 4;
            Tab_Client_Button_Pay.Text = "Сплатити заявку";
            Tab_Client_Button_Pay.UseVisualStyleBackColor = false;
            Tab_Client_Button_Pay.Click += Tab_Client_Button_Pay_Click;
            // 
            // Tab_Client_Label_RequestState
            // 
            Tab_Client_Label_RequestState.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_Label_RequestState.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_Label_RequestState.Font = new Font("Segoe UI", 18F);
            Tab_Client_Label_RequestState.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_Label_RequestState.Location = new Point(364, 362);
            Tab_Client_Label_RequestState.Name = "Tab_Client_Label_RequestState";
            Tab_Client_Label_RequestState.Size = new Size(360, 40);
            Tab_Client_Label_RequestState.TabIndex = 37;
            Tab_Client_Label_RequestState.Text = "---";
            Tab_Client_Label_RequestState.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_LabelText_RequestState
            // 
            Tab_Client_LabelText_RequestState.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_LabelText_RequestState.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_LabelText_RequestState.Font = new Font("Segoe UI", 18F);
            Tab_Client_LabelText_RequestState.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_LabelText_RequestState.Location = new Point(0, 362);
            Tab_Client_LabelText_RequestState.Name = "Tab_Client_LabelText_RequestState";
            Tab_Client_LabelText_RequestState.Size = new Size(360, 40);
            Tab_Client_LabelText_RequestState.TabIndex = 36;
            Tab_Client_LabelText_RequestState.Text = "Стан зявки";
            Tab_Client_LabelText_RequestState.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Client_Label_StayTime
            // 
            Tab_Client_Label_StayTime.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_Label_StayTime.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_Label_StayTime.Font = new Font("Segoe UI", 18F);
            Tab_Client_Label_StayTime.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_Label_StayTime.Location = new Point(364, 316);
            Tab_Client_Label_StayTime.Name = "Tab_Client_Label_StayTime";
            Tab_Client_Label_StayTime.Size = new Size(360, 40);
            Tab_Client_Label_StayTime.TabIndex = 35;
            Tab_Client_Label_StayTime.Text = "-- -- --";
            Tab_Client_Label_StayTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_LabelText_StayTime
            // 
            Tab_Client_LabelText_StayTime.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_LabelText_StayTime.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_LabelText_StayTime.Font = new Font("Segoe UI", 18F);
            Tab_Client_LabelText_StayTime.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_LabelText_StayTime.Location = new Point(0, 316);
            Tab_Client_LabelText_StayTime.Name = "Tab_Client_LabelText_StayTime";
            Tab_Client_LabelText_StayTime.Size = new Size(360, 40);
            Tab_Client_LabelText_StayTime.TabIndex = 34;
            Tab_Client_LabelText_StayTime.Text = "Час перебування";
            Tab_Client_LabelText_StayTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Client_Label_ApartmentСlass
            // 
            Tab_Client_Label_ApartmentСlass.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_Label_ApartmentСlass.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_Label_ApartmentСlass.Font = new Font("Segoe UI", 18F);
            Tab_Client_Label_ApartmentСlass.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_Label_ApartmentСlass.Location = new Point(364, 270);
            Tab_Client_Label_ApartmentСlass.Name = "Tab_Client_Label_ApartmentСlass";
            Tab_Client_Label_ApartmentСlass.Size = new Size(360, 40);
            Tab_Client_Label_ApartmentСlass.TabIndex = 33;
            Tab_Client_Label_ApartmentСlass.Text = "---";
            Tab_Client_Label_ApartmentСlass.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_LabelText_ApartmentСlass
            // 
            Tab_Client_LabelText_ApartmentСlass.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_LabelText_ApartmentСlass.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_LabelText_ApartmentСlass.Font = new Font("Segoe UI", 18F);
            Tab_Client_LabelText_ApartmentСlass.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_LabelText_ApartmentСlass.Location = new Point(0, 270);
            Tab_Client_LabelText_ApartmentСlass.Name = "Tab_Client_LabelText_ApartmentСlass";
            Tab_Client_LabelText_ApartmentСlass.Size = new Size(360, 40);
            Tab_Client_LabelText_ApartmentСlass.TabIndex = 32;
            Tab_Client_LabelText_ApartmentСlass.Text = "Клас апартаментів";
            Tab_Client_LabelText_ApartmentСlass.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Client_Label_SleepingPlacesNumber
            // 
            Tab_Client_Label_SleepingPlacesNumber.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_Label_SleepingPlacesNumber.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_Label_SleepingPlacesNumber.Font = new Font("Segoe UI", 18F);
            Tab_Client_Label_SleepingPlacesNumber.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_Label_SleepingPlacesNumber.Location = new Point(364, 184);
            Tab_Client_Label_SleepingPlacesNumber.Name = "Tab_Client_Label_SleepingPlacesNumber";
            Tab_Client_Label_SleepingPlacesNumber.Size = new Size(360, 80);
            Tab_Client_Label_SleepingPlacesNumber.TabIndex = 31;
            Tab_Client_Label_SleepingPlacesNumber.Text = "---";
            Tab_Client_Label_SleepingPlacesNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_LabelText_SleepingPlacesNumber
            // 
            Tab_Client_LabelText_SleepingPlacesNumber.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_LabelText_SleepingPlacesNumber.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_LabelText_SleepingPlacesNumber.Font = new Font("Segoe UI", 18F);
            Tab_Client_LabelText_SleepingPlacesNumber.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_LabelText_SleepingPlacesNumber.Location = new Point(0, 184);
            Tab_Client_LabelText_SleepingPlacesNumber.Name = "Tab_Client_LabelText_SleepingPlacesNumber";
            Tab_Client_LabelText_SleepingPlacesNumber.Size = new Size(360, 80);
            Tab_Client_LabelText_SleepingPlacesNumber.TabIndex = 30;
            Tab_Client_LabelText_SleepingPlacesNumber.Text = "Кількість місць у номері";
            Tab_Client_LabelText_SleepingPlacesNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Client_Label_ClientPhoneNumber
            // 
            Tab_Client_Label_ClientPhoneNumber.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_Label_ClientPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_Label_ClientPhoneNumber.Font = new Font("Segoe UI", 18F);
            Tab_Client_Label_ClientPhoneNumber.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_Label_ClientPhoneNumber.Location = new Point(364, 92);
            Tab_Client_Label_ClientPhoneNumber.Name = "Tab_Client_Label_ClientPhoneNumber";
            Tab_Client_Label_ClientPhoneNumber.Size = new Size(360, 40);
            Tab_Client_Label_ClientPhoneNumber.TabIndex = 29;
            Tab_Client_Label_ClientPhoneNumber.Text = "---";
            Tab_Client_Label_ClientPhoneNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_LabelText_ClientPhoneNumber
            // 
            Tab_Client_LabelText_ClientPhoneNumber.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_LabelText_ClientPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_LabelText_ClientPhoneNumber.Font = new Font("Segoe UI", 18F);
            Tab_Client_LabelText_ClientPhoneNumber.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_LabelText_ClientPhoneNumber.Location = new Point(0, 138);
            Tab_Client_LabelText_ClientPhoneNumber.Name = "Tab_Client_LabelText_ClientPhoneNumber";
            Tab_Client_LabelText_ClientPhoneNumber.Size = new Size(360, 40);
            Tab_Client_LabelText_ClientPhoneNumber.TabIndex = 28;
            Tab_Client_LabelText_ClientPhoneNumber.Text = "Номер телефону";
            Tab_Client_LabelText_ClientPhoneNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Client_Label_ClientPatronymic
            // 
            Tab_Client_Label_ClientPatronymic.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_Label_ClientPatronymic.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_Label_ClientPatronymic.Font = new Font("Segoe UI", 18F);
            Tab_Client_Label_ClientPatronymic.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_Label_ClientPatronymic.Location = new Point(364, 138);
            Tab_Client_Label_ClientPatronymic.Name = "Tab_Client_Label_ClientPatronymic";
            Tab_Client_Label_ClientPatronymic.Size = new Size(360, 40);
            Tab_Client_Label_ClientPatronymic.TabIndex = 27;
            Tab_Client_Label_ClientPatronymic.Text = "---";
            Tab_Client_Label_ClientPatronymic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_LabelText_ClientPatronymic
            // 
            Tab_Client_LabelText_ClientPatronymic.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_LabelText_ClientPatronymic.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_LabelText_ClientPatronymic.Font = new Font("Segoe UI", 18F);
            Tab_Client_LabelText_ClientPatronymic.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_LabelText_ClientPatronymic.Location = new Point(0, 92);
            Tab_Client_LabelText_ClientPatronymic.Name = "Tab_Client_LabelText_ClientPatronymic";
            Tab_Client_LabelText_ClientPatronymic.Size = new Size(360, 40);
            Tab_Client_LabelText_ClientPatronymic.TabIndex = 26;
            Tab_Client_LabelText_ClientPatronymic.Text = "По батькові";
            Tab_Client_LabelText_ClientPatronymic.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Client_Label_ClientSurname
            // 
            Tab_Client_Label_ClientSurname.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_Label_ClientSurname.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_Label_ClientSurname.Font = new Font("Segoe UI", 18F);
            Tab_Client_Label_ClientSurname.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_Label_ClientSurname.Location = new Point(364, 46);
            Tab_Client_Label_ClientSurname.Name = "Tab_Client_Label_ClientSurname";
            Tab_Client_Label_ClientSurname.Size = new Size(360, 40);
            Tab_Client_Label_ClientSurname.TabIndex = 25;
            Tab_Client_Label_ClientSurname.Text = "---";
            Tab_Client_Label_ClientSurname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_LabelText_ClientSurname
            // 
            Tab_Client_LabelText_ClientSurname.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_LabelText_ClientSurname.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_LabelText_ClientSurname.Font = new Font("Segoe UI", 18F);
            Tab_Client_LabelText_ClientSurname.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_LabelText_ClientSurname.Location = new Point(0, 46);
            Tab_Client_LabelText_ClientSurname.Name = "Tab_Client_LabelText_ClientSurname";
            Tab_Client_LabelText_ClientSurname.Size = new Size(360, 40);
            Tab_Client_LabelText_ClientSurname.TabIndex = 24;
            Tab_Client_LabelText_ClientSurname.Text = "Прізвище";
            Tab_Client_LabelText_ClientSurname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Client_Label_ClientName
            // 
            Tab_Client_Label_ClientName.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_Label_ClientName.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_Label_ClientName.Font = new Font("Segoe UI", 18F);
            Tab_Client_Label_ClientName.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_Label_ClientName.Location = new Point(364, 0);
            Tab_Client_Label_ClientName.Name = "Tab_Client_Label_ClientName";
            Tab_Client_Label_ClientName.Size = new Size(360, 40);
            Tab_Client_Label_ClientName.TabIndex = 23;
            Tab_Client_Label_ClientName.Text = "---";
            Tab_Client_Label_ClientName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_LabelText_ClientName
            // 
            Tab_Client_LabelText_ClientName.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Client_LabelText_ClientName.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_LabelText_ClientName.Font = new Font("Segoe UI", 18F);
            Tab_Client_LabelText_ClientName.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Client_LabelText_ClientName.Location = new Point(0, 0);
            Tab_Client_LabelText_ClientName.Name = "Tab_Client_LabelText_ClientName";
            Tab_Client_LabelText_ClientName.Size = new Size(360, 40);
            Tab_Client_LabelText_ClientName.TabIndex = 22;
            Tab_Client_LabelText_ClientName.Text = "Ім'я";
            Tab_Client_LabelText_ClientName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(230, 230, 230);
            label2.Location = new Point(257, 200);
            label2.Name = "label2";
            label2.Size = new Size(292, 212);
            label2.TabIndex = 9;
            label2.Text = "У вас ще немає створеної заявки. Перейдіть у меню оформлення заявки для створення заявки";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request
            // 
            Tab_Request.BackColor = Color.FromArgb(50, 50, 50);
            Tab_Request.Controls.Add(label4);
            Tab_Request.Controls.Add(Tab_Request_LabelText_StayTime);
            Tab_Request.Controls.Add(Tab_Request_LabelText_Minutes);
            Tab_Request.Controls.Add(Tab_Request_LabelText_Hours);
            Tab_Request.Controls.Add(Tab_Request_LabelText_Days);
            Tab_Request.Controls.Add(Tab_Request_Label_MinutesCount);
            Tab_Request.Controls.Add(Tab_Request_Label_HoursCount);
            Tab_Request.Controls.Add(Tab_Request_Label_DaysCount);
            Tab_Request.Controls.Add(Tab_Request_ComboBox_ApartmentСlass);
            Tab_Request.Controls.Add(Tab_Request_ComboBox_SleepingPlacesNumber);
            Tab_Request.Controls.Add(Tab_Request_Button_MinutesDown);
            Tab_Request.Controls.Add(Tab_Request_Button_MinutesUp);
            Tab_Request.Controls.Add(Tab_Request_Button_HoursDown);
            Tab_Request.Controls.Add(Tab_Request_Button_HoursUp);
            Tab_Request.Controls.Add(Tab_Request_Button_DaysUp);
            Tab_Request.Controls.Add(Tab_Request_Button_DaysDown);
            Tab_Request.Controls.Add(Tab_Request_Buttonn_SendRequest);
            Tab_Request.Controls.Add(Tab_Request_Button_MoveToClient);
            Tab_Request.Controls.Add(label3);
            Tab_Request.Location = new Point(4, 24);
            Tab_Request.Name = "Tab_Request";
            Tab_Request.Size = new Size(790, 642);
            Tab_Request.TabIndex = 4;
            Tab_Request.Text = "Заявка";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.FromArgb(230, 230, 230);
            label4.Location = new Point(95, 140);
            label4.Name = "label4";
            label4.Size = new Size(600, 39);
            label4.TabIndex = 24;
            label4.Text = "Клас апартаментів";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_LabelText_StayTime
            // 
            Tab_Request_LabelText_StayTime.Font = new Font("Microsoft Sans Serif", 18F);
            Tab_Request_LabelText_StayTime.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_LabelText_StayTime.Location = new Point(24, 345);
            Tab_Request_LabelText_StayTime.Name = "Tab_Request_LabelText_StayTime";
            Tab_Request_LabelText_StayTime.Size = new Size(230, 79);
            Tab_Request_LabelText_StayTime.TabIndex = 22;
            Tab_Request_LabelText_StayTime.Text = "Час перебування:";
            Tab_Request_LabelText_StayTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_LabelText_Minutes
            // 
            Tab_Request_LabelText_Minutes.Font = new Font("Microsoft Sans Serif", 14.25F);
            Tab_Request_LabelText_Minutes.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_LabelText_Minutes.Location = new Point(451, 345);
            Tab_Request_LabelText_Minutes.Name = "Tab_Request_LabelText_Minutes";
            Tab_Request_LabelText_Minutes.Size = new Size(78, 30);
            Tab_Request_LabelText_Minutes.TabIndex = 21;
            Tab_Request_LabelText_Minutes.Text = "Хвилин";
            Tab_Request_LabelText_Minutes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_LabelText_Hours
            // 
            Tab_Request_LabelText_Hours.Font = new Font("Microsoft Sans Serif", 14.25F);
            Tab_Request_LabelText_Hours.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_LabelText_Hours.Location = new Point(356, 345);
            Tab_Request_LabelText_Hours.Name = "Tab_Request_LabelText_Hours";
            Tab_Request_LabelText_Hours.Size = new Size(78, 30);
            Tab_Request_LabelText_Hours.TabIndex = 20;
            Tab_Request_LabelText_Hours.Text = "Годин";
            Tab_Request_LabelText_Hours.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_LabelText_Days
            // 
            Tab_Request_LabelText_Days.Font = new Font("Microsoft Sans Serif", 14.25F);
            Tab_Request_LabelText_Days.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_LabelText_Days.Location = new Point(261, 345);
            Tab_Request_LabelText_Days.Name = "Tab_Request_LabelText_Days";
            Tab_Request_LabelText_Days.Size = new Size(78, 30);
            Tab_Request_LabelText_Days.TabIndex = 19;
            Tab_Request_LabelText_Days.Text = "Днів";
            Tab_Request_LabelText_Days.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_Label_MinutesCount
            // 
            Tab_Request_Label_MinutesCount.BorderStyle = BorderStyle.FixedSingle;
            Tab_Request_Label_MinutesCount.Font = new Font("Microsoft Sans Serif", 18F);
            Tab_Request_Label_MinutesCount.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_Label_MinutesCount.Location = new Point(450, 344);
            Tab_Request_Label_MinutesCount.Name = "Tab_Request_Label_MinutesCount";
            Tab_Request_Label_MinutesCount.Size = new Size(80, 80);
            Tab_Request_Label_MinutesCount.TabIndex = 18;
            Tab_Request_Label_MinutesCount.Text = "num";
            Tab_Request_Label_MinutesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_Label_HoursCount
            // 
            Tab_Request_Label_HoursCount.BorderStyle = BorderStyle.FixedSingle;
            Tab_Request_Label_HoursCount.Font = new Font("Microsoft Sans Serif", 18F);
            Tab_Request_Label_HoursCount.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_Label_HoursCount.Location = new Point(355, 344);
            Tab_Request_Label_HoursCount.Name = "Tab_Request_Label_HoursCount";
            Tab_Request_Label_HoursCount.Size = new Size(80, 80);
            Tab_Request_Label_HoursCount.TabIndex = 17;
            Tab_Request_Label_HoursCount.Text = "num";
            Tab_Request_Label_HoursCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_Label_DaysCount
            // 
            Tab_Request_Label_DaysCount.BorderStyle = BorderStyle.FixedSingle;
            Tab_Request_Label_DaysCount.FlatStyle = FlatStyle.Flat;
            Tab_Request_Label_DaysCount.Font = new Font("Microsoft Sans Serif", 18F);
            Tab_Request_Label_DaysCount.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_Label_DaysCount.Location = new Point(260, 344);
            Tab_Request_Label_DaysCount.Name = "Tab_Request_Label_DaysCount";
            Tab_Request_Label_DaysCount.Size = new Size(80, 80);
            Tab_Request_Label_DaysCount.TabIndex = 16;
            Tab_Request_Label_DaysCount.Text = "num";
            Tab_Request_Label_DaysCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_ComboBox_ApartmentСlass
            // 
            Tab_Request_ComboBox_ApartmentСlass.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Request_ComboBox_ApartmentСlass.Font = new Font("Microsoft Sans Serif", 18F);
            Tab_Request_ComboBox_ApartmentСlass.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_ComboBox_ApartmentСlass.FormattingEnabled = true;
            Tab_Request_ComboBox_ApartmentСlass.Items.AddRange(new object[] { "Економ", "Економ+", "Бізнес", "Люкс", "Преміум" });
            Tab_Request_ComboBox_ApartmentСlass.Location = new Point(295, 182);
            Tab_Request_ComboBox_ApartmentСlass.Name = "Tab_Request_ComboBox_ApartmentСlass";
            Tab_Request_ComboBox_ApartmentСlass.Size = new Size(200, 37);
            Tab_Request_ComboBox_ApartmentСlass.TabIndex = 15;
            // 
            // Tab_Request_ComboBox_SleepingPlacesNumber
            // 
            Tab_Request_ComboBox_SleepingPlacesNumber.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Request_ComboBox_SleepingPlacesNumber.Font = new Font("Microsoft Sans Serif", 18F);
            Tab_Request_ComboBox_SleepingPlacesNumber.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_ComboBox_SleepingPlacesNumber.FormattingEnabled = true;
            Tab_Request_ComboBox_SleepingPlacesNumber.Items.AddRange(new object[] { "Одномісний з одномісним ліжком", "Одноміснйи з двомісним ліжком", "Двомісний з одним двухмісним ліжком", "Двомісний з двома одномісними ліжками", "Трьохмісний з трьома одномісними ліжками", "Трьохмісний з одномісним та двохмісним ліжком", "Чотирьохмісний з двома двомісними ліжками" });
            Tab_Request_ComboBox_SleepingPlacesNumber.Location = new Point(95, 100);
            Tab_Request_ComboBox_SleepingPlacesNumber.Name = "Tab_Request_ComboBox_SleepingPlacesNumber";
            Tab_Request_ComboBox_SleepingPlacesNumber.Size = new Size(600, 37);
            Tab_Request_ComboBox_SleepingPlacesNumber.TabIndex = 14;
            // 
            // Tab_Request_Button_MinutesDown
            // 
            Tab_Request_Button_MinutesDown.BackgroundImage = (Image)resources.GetObject("Tab_Request_Button_MinutesDown.BackgroundImage");
            Tab_Request_Button_MinutesDown.BackgroundImageLayout = ImageLayout.Zoom;
            Tab_Request_Button_MinutesDown.FlatAppearance.BorderSize = 0;
            Tab_Request_Button_MinutesDown.FlatStyle = FlatStyle.Flat;
            Tab_Request_Button_MinutesDown.Font = new Font("Microsoft Sans Serif", 18F);
            Tab_Request_Button_MinutesDown.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_Button_MinutesDown.Location = new Point(460, 440);
            Tab_Request_Button_MinutesDown.Name = "Tab_Request_Button_MinutesDown";
            Tab_Request_Button_MinutesDown.Size = new Size(60, 60);
            Tab_Request_Button_MinutesDown.TabIndex = 13;
            Tab_Request_Button_MinutesDown.UseVisualStyleBackColor = true;
            Tab_Request_Button_MinutesDown.Click += Tab_Request_Button_MinutesDown_Click;
            // 
            // Tab_Request_Button_MinutesUp
            // 
            Tab_Request_Button_MinutesUp.BackColor = Color.Transparent;
            Tab_Request_Button_MinutesUp.BackgroundImage = (Image)resources.GetObject("Tab_Request_Button_MinutesUp.BackgroundImage");
            Tab_Request_Button_MinutesUp.BackgroundImageLayout = ImageLayout.Zoom;
            Tab_Request_Button_MinutesUp.FlatAppearance.BorderSize = 0;
            Tab_Request_Button_MinutesUp.FlatStyle = FlatStyle.Flat;
            Tab_Request_Button_MinutesUp.Font = new Font("Microsoft Sans Serif", 18F);
            Tab_Request_Button_MinutesUp.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_Button_MinutesUp.Location = new Point(460, 270);
            Tab_Request_Button_MinutesUp.Name = "Tab_Request_Button_MinutesUp";
            Tab_Request_Button_MinutesUp.Size = new Size(60, 60);
            Tab_Request_Button_MinutesUp.TabIndex = 12;
            Tab_Request_Button_MinutesUp.UseVisualStyleBackColor = false;
            Tab_Request_Button_MinutesUp.Click += Tab_Request_Button_MinutesUp_Click;
            // 
            // Tab_Request_Button_HoursDown
            // 
            Tab_Request_Button_HoursDown.BackgroundImage = (Image)resources.GetObject("Tab_Request_Button_HoursDown.BackgroundImage");
            Tab_Request_Button_HoursDown.BackgroundImageLayout = ImageLayout.Zoom;
            Tab_Request_Button_HoursDown.FlatAppearance.BorderSize = 0;
            Tab_Request_Button_HoursDown.FlatStyle = FlatStyle.Flat;
            Tab_Request_Button_HoursDown.Font = new Font("Microsoft Sans Serif", 18F);
            Tab_Request_Button_HoursDown.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_Button_HoursDown.Location = new Point(365, 440);
            Tab_Request_Button_HoursDown.Name = "Tab_Request_Button_HoursDown";
            Tab_Request_Button_HoursDown.Size = new Size(60, 60);
            Tab_Request_Button_HoursDown.TabIndex = 11;
            Tab_Request_Button_HoursDown.UseVisualStyleBackColor = true;
            Tab_Request_Button_HoursDown.Click += Tab_Request_Button_HoursDown_Click;
            // 
            // Tab_Request_Button_HoursUp
            // 
            Tab_Request_Button_HoursUp.BackColor = Color.Transparent;
            Tab_Request_Button_HoursUp.BackgroundImage = (Image)resources.GetObject("Tab_Request_Button_HoursUp.BackgroundImage");
            Tab_Request_Button_HoursUp.BackgroundImageLayout = ImageLayout.Zoom;
            Tab_Request_Button_HoursUp.FlatAppearance.BorderSize = 0;
            Tab_Request_Button_HoursUp.FlatStyle = FlatStyle.Flat;
            Tab_Request_Button_HoursUp.Font = new Font("Microsoft Sans Serif", 18F);
            Tab_Request_Button_HoursUp.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_Button_HoursUp.Location = new Point(365, 270);
            Tab_Request_Button_HoursUp.Name = "Tab_Request_Button_HoursUp";
            Tab_Request_Button_HoursUp.Size = new Size(60, 60);
            Tab_Request_Button_HoursUp.TabIndex = 10;
            Tab_Request_Button_HoursUp.UseVisualStyleBackColor = false;
            Tab_Request_Button_HoursUp.Click += Tab_Request_Button_HoursUp_Click;
            // 
            // Tab_Request_Button_DaysUp
            // 
            Tab_Request_Button_DaysUp.BackColor = Color.Transparent;
            Tab_Request_Button_DaysUp.BackgroundImage = (Image)resources.GetObject("Tab_Request_Button_DaysUp.BackgroundImage");
            Tab_Request_Button_DaysUp.BackgroundImageLayout = ImageLayout.Zoom;
            Tab_Request_Button_DaysUp.FlatAppearance.BorderSize = 0;
            Tab_Request_Button_DaysUp.FlatStyle = FlatStyle.Flat;
            Tab_Request_Button_DaysUp.Font = new Font("Microsoft Sans Serif", 18F);
            Tab_Request_Button_DaysUp.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_Button_DaysUp.Location = new Point(270, 270);
            Tab_Request_Button_DaysUp.Name = "Tab_Request_Button_DaysUp";
            Tab_Request_Button_DaysUp.Size = new Size(60, 60);
            Tab_Request_Button_DaysUp.TabIndex = 9;
            Tab_Request_Button_DaysUp.UseVisualStyleBackColor = false;
            Tab_Request_Button_DaysUp.Click += Tab_Request_Button_DaysUp_Click;
            // 
            // Tab_Request_Button_DaysDown
            // 
            Tab_Request_Button_DaysDown.BackgroundImage = (Image)resources.GetObject("Tab_Request_Button_DaysDown.BackgroundImage");
            Tab_Request_Button_DaysDown.BackgroundImageLayout = ImageLayout.Zoom;
            Tab_Request_Button_DaysDown.FlatAppearance.BorderSize = 0;
            Tab_Request_Button_DaysDown.FlatStyle = FlatStyle.Flat;
            Tab_Request_Button_DaysDown.Font = new Font("Microsoft Sans Serif", 18F);
            Tab_Request_Button_DaysDown.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_Button_DaysDown.Location = new Point(270, 440);
            Tab_Request_Button_DaysDown.Name = "Tab_Request_Button_DaysDown";
            Tab_Request_Button_DaysDown.Size = new Size(60, 60);
            Tab_Request_Button_DaysDown.TabIndex = 8;
            Tab_Request_Button_DaysDown.UseVisualStyleBackColor = true;
            Tab_Request_Button_DaysDown.Click += Tab_Request_Button_DaysDown_Click;
            // 
            // Tab_Request_Buttonn_SendRequest
            // 
            Tab_Request_Buttonn_SendRequest.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Request_Buttonn_SendRequest.FlatAppearance.BorderSize = 2;
            Tab_Request_Buttonn_SendRequest.FlatStyle = FlatStyle.Flat;
            Tab_Request_Buttonn_SendRequest.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tab_Request_Buttonn_SendRequest.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_Buttonn_SendRequest.Location = new Point(270, 538);
            Tab_Request_Buttonn_SendRequest.Name = "Tab_Request_Buttonn_SendRequest";
            Tab_Request_Buttonn_SendRequest.Size = new Size(250, 48);
            Tab_Request_Buttonn_SendRequest.TabIndex = 7;
            Tab_Request_Buttonn_SendRequest.Text = "Відправити заявку";
            Tab_Request_Buttonn_SendRequest.UseVisualStyleBackColor = false;
            Tab_Request_Buttonn_SendRequest.Click += Tab_Request_Buttonn_SendRequest_Click;
            // 
            // Tab_Request_Button_MoveToClient
            // 
            Tab_Request_Button_MoveToClient.BackColor = Color.FromArgb(60, 60, 60);
            Tab_Request_Button_MoveToClient.FlatAppearance.BorderSize = 2;
            Tab_Request_Button_MoveToClient.FlatStyle = FlatStyle.Flat;
            Tab_Request_Button_MoveToClient.Font = new Font("Segoe UI", 18F);
            Tab_Request_Button_MoveToClient.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_Button_MoveToClient.Location = new Point(33, 33);
            Tab_Request_Button_MoveToClient.Name = "Tab_Request_Button_MoveToClient";
            Tab_Request_Button_MoveToClient.Size = new Size(120, 48);
            Tab_Request_Button_MoveToClient.TabIndex = 6;
            Tab_Request_Button_MoveToClient.Text = "Кабінет";
            Tab_Request_Button_MoveToClient.UseVisualStyleBackColor = false;
            Tab_Request_Button_MoveToClient.Click += Tab_Request_Button_MoveToClient_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(230, 230, 230);
            label3.Location = new Point(95, 58);
            label3.Name = "label3";
            label3.Size = new Size(600, 39);
            label3.TabIndex = 23;
            label3.Text = "Склад апартаментів";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_TestZone
            // 
            Tab_TestZone.Location = new Point(4, 24);
            Tab_TestZone.Name = "Tab_TestZone";
            Tab_TestZone.Size = new Size(790, 642);
            Tab_TestZone.TabIndex = 5;
            Tab_TestZone.Text = "Зона тестів";
            Tab_TestZone.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 661);
            Controls.Add(TabControl_MainTabs);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Система замовлення готелю";
            TabControl_MainTabs.ResumeLayout(false);
            Tab_SignIn.ResumeLayout(false);
            Tab_SignIn.PerformLayout();
            Tab_SignUp.ResumeLayout(false);
            Tab_SignUp.PerformLayout();
            Tab_Aministrator.ResumeLayout(false);
            Tab_Administrator_Panel_RequesList.ResumeLayout(false);
            Tab_Client.ResumeLayout(false);
            Tab_Client_Panel_RequesForm.ResumeLayout(false);
            Tab_Request.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl_MainTabs;
        private TabPage Tab_SignIn;
        private Button Tab_SignIn_Button_SignIn;
        private TextBox Tab_SignIn_TextBox_ClientPassword;
        private TextBox Tab_SignIn_TextBox_ClientSurname;
        private TextBox Tab_SignIn_TextBox_ClientPatronymic;
        private TextBox Tab_SignIn_TextBox_ClientName;
        private TabPage Tab_SignUp;
        private TabPage Tab_Aministrator;
        private TabPage Tab_Client;
        private TabPage Tab_Request;
        private TabPage Tab_TestZone;
        private Button Tab_SignUp_Button_SignUp;
        private TextBox Tab_SignUp_TextBox_ClientPasswordСonfirmation;
        private TextBox Tab_SignUp_TextBox_ClientPassword;
        private TextBox Tab_SignUp_TextBox_ClientSurname;
        private TextBox Tab_SignUp_TextBox_ClientPatronymic;
        private TextBox Tab_SignUp_TextBox_ClientPhoneNumber;
        private TextBox Tab_SignUp_TextBox_ClientName;
        private Button Tab_Administrator_Button_ConfirmRequest;
        private Button Tab_Administrator_Button_DeclineRequest;
        private Button Tab_Administrator_Button_NextRequest;
        private Button Tab_Administrator_Button_PrevRequest;
        private Button Tab_Administrator_Button_MoveToSignIn;
        private Label label1;
        private Panel Tab_Administrator_Panel_RequesList;
        private Button Tab_Client_Button_MoveToSignIn;
        private Panel Tab_Client_Panel_RequesForm;
        private Button Tab_Client_Button_Pay;
        private Button Tab_Request_Button_MinutesDown;
        private Button Tab_Request_Button_MinutesUp;
        private Button Tab_Request_Button_HoursDown;
        private Button Tab_Request_Button_HoursUp;
        private Button Tab_Request_Button_DaysUp;
        private Button Tab_Request_Button_DaysDown;
        private Button Tab_Request_Buttonn_SendRequest;
        private Button Tab_Request_Button_MoveToClient;
        private ComboBox Tab_SignUp_ComboBox_ClientStatus;
        private Label Tab_Request_LabelText_Days;
        private Label Tab_Request_Label_MinutesCount;
        private Label Tab_Request_Label_HoursCount;
        private Label Tab_Request_Label_DaysCount;
        private ComboBox Tab_Request_ComboBox_ApartmentСlass;
        private ComboBox Tab_Request_ComboBox_SleepingPlacesNumber;
        private Label Tab_Request_LabelText_Minutes;
        private Label Tab_Request_LabelText_Hours;
        private Label Tab_Request_LabelText_StayTime;
        private Button Tab_Client_Button_MoveToRequest;
        private Label label2;
        private Label Tab_Administrator_Label_RequestState;
        private Label Tab_Administrator_LabelText_RequestState;
        private Label Tab_Administrator_Label_StayTime;
        private Label Tab_Administrator_LabelText_StayTime;
        private Label Tab_Administrator_Label_ApartmentСlass;
        private Label Tab_Administrator_LabelText_ApartmentСlass;
        private Label Tab_Administrator_Label_SleepingPlacesNumber;
        private Label Tab_Administrator_LabelText_SleepingPlacesNumber;
        private Label Tab_Administrator_Label_ClientPhoneNumber;
        private Label Tab_Administrator_LabelText_ClientPhoneNumber;
        private Label Tab_Administrator_Label_ClientPatronymic;
        private Label Tab_Administrator_LabelText_ClientPatronymic;
        private Label Tab_Administrator_Label_ClientSurname;
        private Label Tab_Administrator_LabelText_ClientSurname;
        private Label Tab_Administrator_Label_ClientName;
        private Label Tab_Administrator_LabelText_ClientName;
        private Label Tab_Client_Label_RequestState;
        private Label Tab_Client_LabelText_RequestState;
        private Label Tab_Client_Label_StayTime;
        private Label Tab_Client_LabelText_StayTime;
        private Label Tab_Client_Label_ApartmentСlass;
        private Label Tab_Client_LabelText_ApartmentСlass;
        private Label Tab_Client_Label_SleepingPlacesNumber;
        private Label Tab_Client_LabelText_SleepingPlacesNumber;
        private Label Tab_Client_Label_ClientPhoneNumber;
        private Label Tab_Client_LabelText_ClientPhoneNumber;
        private Label Tab_Client_Label_ClientPatronymic;
        private Label Tab_Client_LabelText_ClientPatronymic;
        private Label Tab_Client_Label_ClientSurname;
        private Label Tab_Client_LabelText_ClientSurname;
        private Label Tab_Client_Label_ClientName;
        private Label Tab_Client_LabelText_ClientName;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Button Tab_SignUp_Button_EnterTemplate;
        private Button Tab_SignIn_Button_EnterTemplate;
        private Label label4;
        private Label label3;
    }
}
