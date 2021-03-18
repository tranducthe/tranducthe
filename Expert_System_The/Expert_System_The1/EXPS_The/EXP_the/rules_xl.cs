using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ExpertSystem_The;

namespace ExpertSystem_The
{
    class rules_xl
    {
        Connectionss kn = new Connectionss();
        public void them(rules l)
        {
            String sql = "insert into tblluat values('" + l.Maluat + "',N'" + l.Noidung + "')";
            kn.thuchien(sql);

        }
        public void sua(rules l)
        {
            String sql = "update tblluat set noidung = N'" + l.Noidung + "' where maluat = '" + l.Maluat + "' ";
            kn.thuchien(sql);
        }
        public void xoa(String mal)
        {
            String sql = "delete from tblluat where maluat ='" + mal + "'";
            kn.thuchien(sql);


        }
        public DataTable timkiem(String mal)
        {
            String sql = "select * from tblluat where maluat ='" + mal + "'";
            return kn.getTable(sql);
        }
        public DataTable loadluat()
        {
            String sql = "select * from tblluat";
            return kn.getTable(sql);
        }
    }
}
