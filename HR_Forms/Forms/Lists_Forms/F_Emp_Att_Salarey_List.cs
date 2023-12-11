using HR_DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Forms.Forms.Lists_Forms
{
    public partial class F_Emp_Att_Salarey_List : F_Master_Report_List
    {
        public F_Emp_Att_Salarey_List()
        {
            InitializeComponent();
        }
        ClsCommander<T_Attend_Month> cmdAttMonth = new ClsCommander<T_Attend_Month>();
        ClsCommander<T_Attend> cmdAtt = new ClsCommander<T_Attend>();
        ClsCommander<T_Attend_Day> cmdAttDay = new ClsCommander<T_Attend_Day>();
        ClsCommander<T_Employee_Social> cmdEmpSocial = new ClsCommander<T_Employee_Social>();
        ClsCommander<T_Emploee> cmdEmpolee = new ClsCommander<T_Emploee>();
        ClsCommander<T_Salary_Master> cmdSalarey = new ClsCommander<T_Salary_Master>();
        ClsCommander<T_Salarey_Month> cmdSalareyMonth = new ClsCommander<T_Salarey_Month>();
        ClsCommander<V_Emp_Month_Atend_Salarey> cmdCurentSalery = new ClsCommander<V_Emp_Month_Atend_Salarey>();

        T_Attend_Month TF_Att_Month = new T_Attend_Month();
        T_Emploee TF_Emploee =new T_Emploee();
        T_Employee_Social TF_Employee_Social = new T_Employee_Social();
        T_Salary_Master TF_Salary_Master = new T_Salary_Master();
        T_Salarey_Month TF_Salarey_Month = new T_Salarey_Month();
        V_Emp_Month_Atend_Salarey curent_Salaery = new V_Emp_Month_Atend_Salarey();

        public override void Get_Data()
        {
            if (Convert.ToString(Mont_searchLookUpEdit1.EditValue) != "" && Mont_searchLookUpEdit1.EditValue != null)
            {
                gc.DataSource = (from AttMon in cmdCurentSalery.Get_All().Where
                                 (es => es.Emp_Att_M_Id == Convert.ToInt64(Mont_searchLookUpEdit1.EditValue) 
                                 && ((es.emp_name).Contains(txt_emp_name.Text) 
                                 || (es.Emp_Id).ToString().Contains(txt_emp_name.Text)))
                                 select new
                                 {
                                     id = AttMon.Emp_Att_M_Id,
                                    date = AttMon.Emp_Att_M_Month_Name,
                                     year = AttMon.yeaar,
                                     houres = AttMon.Emp_Att_M_Day_Count,
                                     emp_Id = AttMon.Emp_Id,
                                     Emp_Name = AttMon.emp_name,
                                     Emp_Work_houres= AttMon.total_hours,

                                 }).OrderBy(id => id.emp_Id);
                gv.Columns[0].Caption = "رقم الشهر";
                gv.Columns[1].Caption = "الشهر";
                gv.Columns[2].Caption = "السنة";
                gv.Columns[3].Caption = "ساعات عمل الشهر ";
                gv.Columns[4].Caption = "رقم الموظف ";
                gv.Columns[5].Caption = "اسم الموظف ";
                gv.Columns[6].Caption = "رقم الموظف ";
                gv.Columns[7].Caption = "ساعات عمل الموظق ";
                gv.BestFitColumns();
            }
            else
            {
                gc.DataSource = null;
                gc.Refresh();
            }
            base.Get_Data();
        }
        public void month_list()
        {
            var m_list = (from emp_M in cmdAttMonth.Get_All()
                          select new
                          {
                              id=emp_M.Emp_Att_M_Id,
                              name=emp_M.Emp_Att_M_Month_Name,
                              date =emp_M.Emp_Att_M_Date

                          }).OrderBy(x=>x.id).ToList();
            Mont_searchLookUpEdit1.slkp_iniatalize_data(m_list,"name","id");
            Mont_searchLookUpEdit1.Properties.PopulateViewColumns();
            Mont_searchLookUpEdit1.Properties.View.Columns[0].Caption = "الرقم";
            Mont_searchLookUpEdit1.Properties.View.Columns[1].Caption = "الشهر";
            Mont_searchLookUpEdit1.Properties.View.Columns[2].Caption = "التاريخ";

        }

        private void Mont_searchLookUpEdit1_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty)
            {
                long e_id = Convert.ToInt64(e.Value);
                DateTime date1 = Convert.ToDateTime(cmdAttMonth.Get_By(id => id.Emp_Att_M_Id == e_id).FirstOrDefault().Emp_Att_M_Date);
                e.DisplayText = date1.ToString("MM/yyyy");

            }
            else
                e.DisplayText = "";
        }
        //SELECT dbo.T_Attend_Month.Emp_Att_M_Id, dbo.T_Attend_Month.Emp_Att_M_Month_Name, dbo.T_Attend_Month.Emp_Att_M_Date,
        //                      dbo.T_Attend_Month.Emp_Att_M_Day_Count, dbo.T_Emploee.Emp_Id, dbo.T_Emploee.Emp_F_Name + ' ' + dbo.T_Emploee.Emp_L_Name AS emp_name,
        //                      SUM(dbo.T_Attend.Emp_Att_Houer) AS total_hours
        //FROM         dbo.T_Attend_Month INNER JOIN
        //                      dbo.T_Attend_Day ON dbo.T_Attend_Month.Emp_Att_M_Id = dbo.T_Attend_Day.Emp_Att_M_Id INNER JOIN


        //                      dbo.T_Attend ON dbo.T_Attend_Day.Emp_Att_D_Id = dbo.T_Attend.Emp_Att_D_Id INNER JOIN


        //                      dbo.T_Emploee ON dbo.T_Attend.Emp_Id = dbo.T_Emploee.Emp_Id
        //GROUP BY dbo.T_Attend_Month.Emp_Att_M_Id, dbo.T_Attend_Month.Emp_Att_M_Month_Name, dbo.T_Attend_Month.Emp_Att_M_Date,
        //                      dbo.T_Attend_Month.Emp_Att_M_Day_Count, dbo.T_Emploee.Emp_Id, dbo.T_Emploee.Emp_F_Name + ' ' + dbo.T_Emploee.Emp_L_Name

        //V_Emp_Month_Atend_Salarey
        private void btn_salarey_Click(object sender, EventArgs e)
        {
            try
            {     
            if (gv.RowCount>0)
            {
                T_Attend att_day = new T_Attend();
                T_Attend_Month att_month = new T_Attend_Month();
                //collect month count
                att_month = cmdAttMonth.Get_All().Where(x => x.Emp_Att_M_Id == Convert.ToInt64(Mont_searchLookUpEdit1.EditValue)).FirstOrDefault();
              //كم يوم في هذا الشهر
                int count_Att_Day = Convert.ToInt32(cmdAttDay.Get_All().Where(x=> x.Emp_Att_M_Id ==att_month.Emp_Att_M_Id).Count());
                int year = Convert.ToInt32(Convert.ToDateTime(att_month.Emp_Att_M_Date).ToString("yyyy"));
                int month = Convert.ToInt32(Convert.ToDateTime(att_month.Emp_Att_M_Date).ToString("MM"));

                if (count_Att_Day < DateTime.DaysInMonth(year , month))//عدد الأيام في الشهر الحالي
                {
                    MessageBox.Show("لم يتم تسجيل أيام الشهر كاملة!!"+"\n" + "لا يمكن اتمام الرواتب لهذا الشهر");
                    return;
                }
                for (int i = 0; i < gv.DataRowCount; i++)
                {


                }
                MessageBox.Show("تم احتساب الرواتب لهذا الشهر " + "\n" + "يمكنك طباعة كشف رواتب الموظفين !!");

            }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Emp_Sal_Func( long S_Emp_Id , string S_Month , string S_Year)
        {           
             TF_Emploee = new T_Emploee();
             TF_Employee_Social = new T_Employee_Social();
             TF_Salary_Master = new T_Salary_Master();
             TF_Salarey_Month = new T_Salarey_Month();
             curent_Salaery = new V_Emp_Month_Atend_Salarey();

            //get emp date by id

            TF_Emploee = cmdEmpolee.Get_All().Where(x => x.Emp_Id == S_Emp_Id).FirstOrDefault();
            if (TF_Emploee != null)
            {
                TF_Salary_Master = cmdSalarey.Get_All().Where(xs => xs.Emp_Mp_Id==TF_Emploee.Emp_Mp_Id).FirstOrDefault();
                TF_Employee_Social = cmdEmpSocial.Get_All().Where(x => x.Emp_Id == TF_Emploee.Emp_Id).FirstOrDefault();
                curent_Salaery = cmdCurentSalery.Get_All().Where(x => x.Emp_Id == TF_Emploee.Emp_Id 
                                               && x.Emp_Att_M_Month_Name == S_Month 
                                               && x.yeaar == Convert.ToInt64( S_Year) ).FirstOrDefault();

            }

            //emp sal func
            int tottal_month_hours, emp_month_hours, sum_total_hours;
            decimal day_price = 0;
            decimal minus_hours = 0;
            decimal bonas_hours = 0;
            // يعني ساعة الالموظف تختلف من شهر لشهر حساب راتب الشهر كل شهر لوحده
            tottal_month_hours = Convert.ToInt32(curent_Salaery.Emp_Att_M_Day_Count);
            emp_month_hours = Convert.ToInt32(curent_Salaery.total_hours);
            day_price = Convert.ToDecimal(TF_Salary_Master.Emp_Sal_Salary / (tottal_month_hours/8));

            if (tottal_month_hours ==emp_month_hours)
            {
                sum_total_hours = tottal_month_hours;
                minus_hours = 0;
                bonas_hours = 0;
            }
            else if (tottal_month_hours > emp_month_hours)
            {
                sum_total_hours = tottal_month_hours - emp_month_hours;
                minus_hours = (sum_total_hours /8 ) *day_price;
                bonas_hours = 0;
            }
            else if (tottal_month_hours < emp_month_hours)
            {
                sum_total_hours =( emp_month_hours - tottal_month_hours) + emp_month_hours;
                minus_hours = 0;
                bonas_hours = ((sum_total_hours -tottal_month_hours) / 8) * day_price; ;
            }
            //insert emp sal
            var m_sal_id =cmdSalareyMonth.Get_All().Where(x=>x.Emp_Sal_Id ==cmdSalareyMonth.Get_All().Max(Max => Max.id)).fir 
        }
        private void F_Emp_Att_Salarey_List_Load(object sender, EventArgs e)
        {
           // btn_clear_Click(sender, e);
            Title("ساعات عمل الموظفين و احتساب الرواتب");
            Get_Data();
            month_list();
        }
    }
}
