using _20220219_ENTERPRISE_MANAGEMENT.com.logic.member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220219_ENTERPRISE_MANAGEMENT.com.logic.enterprise
{
    internal class ExampleEnterprise
    {
        private int id;
        private string name;
        private List<Member> members;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public ExampleEnterprise(int id, string name)
        {
            this.id = id;
            this.name = name ?? String.Empty;
            this.members = new List<Member>();
        }

        /// <summary>
        /// Add members to the member list
        /// </summary>
        /// <param name="member"></param>
        public void AddMember(Member member)
        {
            members.Add(member);
        }

        /// <summary>
        /// Remove members from the member list
        /// </summary>
        /// <param name="member"></param>
        public void RemoveMember(Member member)
        {
            members.Remove(member);
        }

        /// <summary>
        /// Replace old member information with the new information contained into the data
        /// </summary>
        /// <param name="oldMember"></param>
        /// <param name="newMember"></param>
        public void EditMember(Member oldMember, Member newMember)
        {
            if (oldMember == null || newMember == null)
            {
                return;
            }
            else
            {
                members.Remove(FindMember(oldMember));
                members.Add(newMember);
            }
        }

        /// <summary>
        /// Allows the user to find an especific member form the list
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public Member FindMember(Member member)
        {
            Member temporalMember = new Member();
            if (member != null)
            {
                //members.Find(mem => mem == member);
                foreach (Member mem in members)
                {
                    if (mem.Id == member.Id)
                    {
                        temporalMember = mem;
                    }
                }
            }

            return temporalMember;

            //return (member != null) ? members.Find(mem => mem == member) : new Member();
        }
    }
}
