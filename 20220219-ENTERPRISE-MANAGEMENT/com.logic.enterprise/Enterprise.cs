using _20220219_ENTERPRISE_MANAGEMENT.com.logic.member;
using _20220219_ENTERPRISE_MANAGEMENT.com.logic.interfaceManagement;
using _20220219_ENTERPRISE_MANAGEMENT.com.logic.utils;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// CLASS MODIFICATION TEST
/// </summary>
namespace _20220219_ENTERPRISE_MANAGEMENT.com.logic.enterprise
{
    public class Enterprise: AbstracMemberManagement
    { 
        private int id;
        private string name;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Enterprise(int id, string name)
        {
            if (id > IdentifierManagementCounter.EnterpriseIDManagement)
            {
                this.id = id;
                this.name = name ?? String.Empty;
                IdentifierManagementCounter.EnterpriseIDManagement++;
            }
        }
    }
}
