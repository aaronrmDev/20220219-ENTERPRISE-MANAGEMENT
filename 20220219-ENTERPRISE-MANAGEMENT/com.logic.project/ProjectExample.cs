using _20220219_ENTERPRISE_MANAGEMENT.com.logic.member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220219_ENTERPRISE_MANAGEMENT.com.logic.project
{
    public abstract  class ProjectExample
    {
        private int id;
        private string name;
        private DateTime date;
        private List<Member> members;

        protected int Id { get => id; set => id = value; }
        protected string Name { get => name; set => name = value; }
        protected DateTime Date { get => date; set => date = value; }
        public List<Member> Members { get => members; set => members = value; }

        /// <summary>
        /// Construct Projects
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public ProjectExample(int id, string name, DateTime date)
        {
            this.id = id;
            this.name = name ?? String.Empty;
            this.date = date;
            this.Members = new List<Member>();
        }

        public abstract void CalculateCost();
        public void AddMember(Member member)
        {
            Members?.Add(member);
        }

        public void RemoveMember(int id)
        {
            //foreach (Member member in members)
            //{
            //    if (member.Id.Equals(id))
            //    {
            //        members.Remove(member);
            //    }
            //}

            //members?.Remove(FindMember(id));

            //members?.ForEach(m => (m.Id == id ? members.Remove ));

            Members?.Remove(FindMember(id));
        }

        public Member FindMember(int id)
        {
            //if (members != null && members.Count > 0)
            //{
            //    return members[id];
            //}
            //return null;

            return (Members != null && Members.Count > 0) ? Members[id] : new Member();
        }

    }
}
