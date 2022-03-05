using _20220219_ENTERPRISE_MANAGEMENT.com.logic.member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220219_ENTERPRISE_MANAGEMENT.com.logic.interfaceManagement
{
    public interface MemberManagement
    {
        //CRUD
        public abstract void AddMember(Member member);
        public abstract void RemoveMember(Member member);
        //public abstract void RemoveMember(Member memeber);
        public abstract void ReplaceMemberInformation(Member oldMember, Member newMember);
        public abstract void FindMember(Member member);
        //public abstract void FindMember(string name);
    }

    public interface MemberManagementVariants : MemberManagement
    {
        public abstract void RemoveMember(int id);
        public abstract Member FindMember(int id);
        public abstract Member FindMember(string name);
    }
}
