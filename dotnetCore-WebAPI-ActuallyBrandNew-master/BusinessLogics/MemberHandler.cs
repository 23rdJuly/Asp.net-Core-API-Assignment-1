using System;
using System.Collections.Generic;
using System.Linq;
using dotnetCore_WebAPI_ActuallyBrandNew.Models;

namespace dotnetCore_WebAPI_ActuallyBrandNew.BusinessLogics
{
    public class MemberHandler : IMemberHandler
    {
        private List<Member> _membersList;

        public MemberHandler()
        {
            SeedingData();
        }

        public List<Member> FilterMemberByGender(char gender)
        {
            return _membersList
                .Where(s => s.Gender == gender)
                .ToList();
        }

        public List<Member> FilterMembersByBirthPlace(string birthPlace)
        {
            return _membersList
                .Where(s => s.BirthPlace == birthPlace)
                .ToList();
        }

        public List<Member> FilterMembersWithBirthYearGreaterThan(int year)
        {            
            return _membersList
                .Where(s => s.DOB.Year > year)
                .ToList();
        }

        public List<Member> FilterMembersWithBirthYearIn(int year)
        {
            return _membersList
                .Where(s => s.DOB.Year == year)
                .ToList();
        }

        public List<Member> FilterMembersWithBirthYearLessThan(int year)
        {
            return _membersList
                .Where(s => s.DOB.Year < year)
                .ToList();
        }

        public List<string> GetFullNamesOnlyList()
        {
            return _membersList
                .Select(s => $"{s.LastName} {s.FirstName}")
                .ToList();
        }

        public Member GetOldestMember()
        {
            return _membersList
                .OrderBy(s => s.DOB)
                .FirstOrDefault();
        }

        public List<Member> AddNewMember(Member member)
        {
            _membersList.Add(member);
            return _membersList;
        }

        private void SeedingData()
        {
            _membersList = new List<Member>
            {
                new Member
            {
                FirstName = "Van A",
                LastName = "Nguyen",
                Gender = 'M',
                DOB = new DateTime(1993, 10, 15),
                PhoneNumber = "0986667777",
                BirthPlace = "Ha Noi",
                StartDate = new DateTime(2015, 8, 12),
                EndDate = new DateTime(2020, 3, 1)
            },
            new Member
            {
                FirstName = "Van B",
                LastName = "Nguyen",
                Gender = 'M',
                DOB = new DateTime(1997, 10, 8),
                PhoneNumber = "0961112222",
                BirthPlace = "Ha Noi",
                StartDate = new DateTime(2019, 05, 05),
                EndDate = new DateTime(2020, 01, 01)
            },
            new Member
            {
                FirstName = "Van B",
                LastName = "Tran",
                Gender = 'F',
                DOB = new DateTime(1989, 5, 25),
                PhoneNumber = "0982223333",
                BirthPlace = "TP HCM",
                StartDate = new DateTime(2017, 06, 30),
                EndDate = new DateTime(2020, 02, 10)
            }
            };
        }
    }
}