using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeersApp.Model
{
    internal class Requistion
    {
        string Adress; // Куда вызов
        string Number; // Номер телефона для обращения 
        string FIO;
        DateTime dateForGo;
        string CommentForGo;
        Worker Worker; // назначенный работник
    }
}
