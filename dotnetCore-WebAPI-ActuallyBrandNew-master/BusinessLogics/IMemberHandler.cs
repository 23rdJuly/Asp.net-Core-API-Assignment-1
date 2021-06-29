using System.Collections.Generic;
using dotnetCore_WebAPI_ActuallyBrandNew.Models;

namespace dotnetCore_WebAPI_ActuallyBrandNew.BusinessLogics
{
    public interface IMemberHandler
    {
        List<Member> FilterMemberByGender(char gender);
        Member GetOldestMember();
        List<string> GetFullNamesOnlyList();
        List<Member> FilterMembersWithBirthYearLessThan(int year);
        List<Member> FilterMembersWithBirthYearIn(int year);
        List<Member> FilterMembersWithBirthYearGreaterThan(int year);
        List<Member> FilterMembersByBirthPlace(string birthPlace);

        List<Member> AddNewMember(Member member);        
    }
}