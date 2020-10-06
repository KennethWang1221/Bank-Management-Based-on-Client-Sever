using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace BankManage.query
{
    /// <summary>
    /// DayQuery.xaml 的交互逻辑
    /// 当日汇总
    /// </summary>
    public partial class CustomQuery : Page
    {
        BankEntities context = new BankEntities();
        public CustomQuery()
        {
            InitializeComponent();
            this.Unloaded += CustomQuery_Unloaded;
            
        }
        void CustomQuery_Unloaded(object sender, RoutedEventArgs e)
        {
            context.Dispose();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var query = from t in context.AccountInfo
                        where t.IdCard == txtID.Text
                        select t;
                    
            datagrid1.ItemsSource = query.ToList();
        }

       
    }
}
