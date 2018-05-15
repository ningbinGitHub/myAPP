using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_Ef_MySql
{
    class Program
    {
        static void Main(string[] args)
        {
            var entityModel = new dmmusicteachingEntities();
            var list = entityModel.mag_user.ToList();



            var sUser = list.OrderByDescending(u => u.id).FirstOrDefault();
            sUser.realName = "lalala";

            DbEntityEntry<mag_user> entityEntry = entityModel.Entry(sUser);
            entityEntry.State = EntityState.Modified;
            entityModel.SaveChanges();

            update(entityModel, list);
            Console.WriteLine("添加成功");
        }

        private static Boolean update(dmmusicteachingEntities entityModel, List<mag_user> list)
        {
            var lUser = list.LastOrDefault();
            lUser.realName = "lululu";

            DbEntityEntry<mag_user> entityEntry = entityModel.Entry(lUser);
            entityEntry.State = EntityState.Modified;
            return entityModel.SaveChanges() > 0;

        }
    }
}
