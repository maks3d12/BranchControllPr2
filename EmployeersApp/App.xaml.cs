using EmployeersApp.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Npgsql;
using System.Diagnostics;

namespace EmployeersApp
{

    public partial class App : Application
    {

        public static MainWindow mainWindow;
        public string LinkActivation;
        public NpgsqlConnection con;
        public bool ServerActivated;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            LinkActivation = LinkConnectInDatabase();
            mainWindow = new MainWindow();
            GetNpgsqlConnection();
            TestConnect();
            mainWindow.Show();
        }
        private void TestConnect()
        {
            using( con)
            {
                try
                {
                    con.Open();
                    ServerActivated = true;
                }
                catch(Exception ex)
                {
                    ServerActivated = false; 
                    MessageBox.Show("Ошибка в подключении бд = "  + ex.Message);
                }

                
                if(con.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connected");
                }
            }
        }
        private string LinkConnectInDatabase()
        {
            return @"Server=localhost;Port=8080;User Id=postgres;Password=123321Qaz;Database=CompanyInformationSystem";
        }
        private void GetNpgsqlConnection()
        {
            con = new NpgsqlConnection(LinkConnectInDatabase());
        }
    }



}
