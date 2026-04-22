using Models;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Hosting;

namespace DAL
{
    public sealed class DB
    {
        #region singleton setup
        private static readonly DB instance = new DB();
        public static DB Instance { get { return instance; } }
        #endregion

        static public UsersRepository Users { get; set; } = new UsersRepository();
        static public LoginsRepository Logins { get; set; } = new LoginsRepository();
        public static StudentsRepository Students { get; set; } = new StudentsRepository();
        public static AllocationsRepository Allocations { get; set; } = new AllocationsRepository();
        public static CoursesRepository Courses { get; set; } = new CoursesRepository();
        public static TeachersRepository Teachers { get; set; } = new TeachersRepository();
        public static RegistrationsRepository Registrations { get; set; } = new RegistrationsRepository();

    }
}