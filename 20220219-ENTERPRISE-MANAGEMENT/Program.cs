// See https://aka.ms/new-console-template for more information
using _20220219_ENTERPRISE_MANAGEMENT.com.logic.enterprise;
using _20220219_ENTERPRISE_MANAGEMENT.com.logic.member;

//Member member = new Member();
//Console.WriteLine(member.Id);
Console.WriteLine(Member.memberIDCounter);

Member mem1 = new Member(1, "Juan", "Operador");
Member mem2 = new Member(1, "Andres", "Admin");
Member mem3 = new Member(1, "Sebas", "Operador");
Member Example = new Member(123, null, "Operador");

List<Member> members = new List<Member>();

members.Add(mem1);
members.Add(mem2);
members.Add(mem3);
members.Add(Example);

members.ForEach(x => Console.WriteLine( x.Id + " " + x.Name + " " + x.Role));
Console.WriteLine(Member.memberIDCounter);


/// <summary>
///  ERROR PORQUE LA LISTA DEL FOR SE ALTERA y LA TOMA COMO DIFERENTE
/// </summary>
//foreach (Member mem in members)
//{
//    if (mem.Id == 0)
//    {
//        members.Remove(mem);
//    }
//}


Console.WriteLine("LIMPIEZA DE LA LISTA");


members.RemoveAll(x => x.Id == 0);
members.ForEach(x => Console.WriteLine(x.Id + " " + x.Name + " " + x.Role));





//foreach (Member mem in members)
//{
//    Console.WriteLine(mem.Name);
//}

//for (int i = 0; i < members.Count; i++)
//{
//    Console.WriteLine(members[i].Name);
//}

//Console.WriteLine(mem1.ToString());

//Member member = new Member(true);

//string id = "";

Enterprise enterprise = new Enterprise(1, "Microsoft");
//enterprise.AddMember(mem1);

// NO SE USA EN DOTNET  PORQUE ES IMPLICITO
//public static void main(string[] args)
//{
//}