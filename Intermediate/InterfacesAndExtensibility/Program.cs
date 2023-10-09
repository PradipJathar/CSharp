using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndExtensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();


            DbMigrator dbMigrator1 = new DbMigrator(new FileLogger("D:\\LogExemple\\log.txt"));
            dbMigrator1.Migrate();
        }
    }
}
