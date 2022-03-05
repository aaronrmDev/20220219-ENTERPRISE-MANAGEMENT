using _20220219_ENTERPRISE_MANAGEMENT.com.logic.member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220219_ENTERPRISE_MANAGEMENT.com.logic.interfaceManagement
{
    public abstract class AbstracMemberManagement : MemberManagement
    {
        private List<Member> members = new List<Member>();
        public List<Member> Members { get => members; set => members = value; }

        public void AddMember(Member member)
        {
            members.Add(member);
        }

        public void FindMember(Member member)
        {
            members.Find(mem => mem.Equals(member));
        }

        public void RemoveMember(Member member)
        {
           members.Remove(member);
        }

        public void ReplaceMemberInformation(Member oldMember, Member newMember)
        {
            members.Remove(oldMember);
            members.Add(newMember);
        }
    }
}
