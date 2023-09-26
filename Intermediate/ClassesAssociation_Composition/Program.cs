using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAssociation_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new Logger());    // Directly create new Logger Object in the constructor 

            Logger logger = new Logger();                           // Logger Object created outside and assign in the constructor
            Installer installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();
        }
    }
}
