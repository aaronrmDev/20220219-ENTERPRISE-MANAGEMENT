using _20220219_ENTERPRISE_MANAGEMENT.com.logic.utils;

namespace _20220219_ENTERPRISE_MANAGEMENT.com.logic.member
{
    public class Member
    {
        /// <summary>
        /// STRUCTURE
        /// </summary>
        private int id;
        private string name;
        private string role;
        private string departmentName;

        /// <summary>
        /// PROPERTIES
        /// </summary>
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Role { get => role; set => role = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }


        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="role"></param>
        public Member(int id = 0, string name = "NULL", string role = "NULL")
        {
            if (id > IdentifierManagementCounter.MemberIDManagement)
            {
                Id = id;
                Name = name;
                Role = role;
                DepartmentName = string.Empty;
                IdentifierManagementCounter.MemberIDManagement++;
            }
            else
            {
                return;
            }
        }

        public Member(int id, string name, string role, string departmentName)
        {
            this.id = id;
            this.name = name;
            this.role = role;
            this.departmentName = departmentName;
        }

        //public Member()
        //{
        //    this.Id = 0;
        //    this.Name = String.Empty;
        //    this.Role = String.Empty;   
        //}

        //public Member(bool checkPrint)
        //{
        //    if (checkPrint.Equals(true))
        //    {
        //        Console.WriteLine("HELLO WORLD");
        //    }
        //}

        ///BEHAVIOR
        public override string ToString()
        {
            string msg = string.Empty;
            msg = string.Concat("ID: ", id +"\n", "NAME:", name+"\n");
            return msg;
        }
    }
}
