﻿using System;

namespace BusinessObject
{
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return MemberID + " " + MemberName + " " + Email + " " + Password + " " + City + " " + Country;
        }
    }
}
