using _20220219_ENTERPRISE_MANAGEMENT.com.logic.member;
using _20220219_ENTERPRISE_MANAGEMENT.com.logic.interfaceManagement;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220219_ENTERPRISE_MANAGEMENT.com.logic.project
    
{
    public abstract class Project: AbstracMemberManagement, MemberManagementVariants
    {
        private int id;
        private string name;
        private DateTime date;

        protected int Id { get => id; set => id = value; }
        protected string Name { get => name; set => name = value; }
        protected DateTime Date { get => date; set => date = value; }

        /// <summary>
        /// Construct Projects
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public Project(int id, string name, DateTime date)
        {
            this.id = id;
            this.name = name ?? String.Empty;
            this.date = date;
        }

        public abstract void CalculateCost();

        public void RemoveMember(int id)
        {
            Members.Remove(FindMember(id)); 
        }

        public Member? FindMember(int id)
        {
            return Members?.Find(member => member.Id == id);
        }

        public Member? FindMember(string name)
        {
            return Members?.Find(member => member.Name == name);
        }
    }
}
