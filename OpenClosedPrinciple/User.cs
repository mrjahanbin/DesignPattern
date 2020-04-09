using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    //  public class User
    //  {

    #region FirstCode

    //public int Id { get; set; }
    //public string Name { get; set; }
    //public decimal Salary { get; set; }

    //public User(int id, string name, decimal salary)
    //{
    //    Id = id;
    //    Name = name;
    //    Salary = salary;
    //}

    //public decimal CalculateBouns()
    //{
    //    return Salary * .1M;
    //}

    //public override string ToString()
    //{
    //    return $"{nameof(Id)} : {Id} , {nameof(Name)} : {Name} , Bouns : {CalculateBouns()}";
    //}

    #endregion

    #region SecondCode

    //public enum UserType
    //{
    //    Gold,
    //    Silver
    //}

    //public int Id { get; set; }
    //public string Name { get; set; }
    //public decimal Salary { get; set; }
    //public UserType Usertype { get; set; }

    //public User(int id, string name, decimal salary, UserType usertype)
    //{
    //    Id = id;
    //    Name = name;
    //    Salary = salary;
    //    Usertype = usertype;
    //}



    //public decimal CalculateBouns()
    //{
    //    if (Usertype == UserType.Gold)
    //    {
    //        return Salary * .1M;
    //    }
    //    return Salary * .05M;
    //}
    //public override string ToString()
    //{
    //    return $"{nameof(Id)} : {Id} , {nameof(Name)} : {Name} , Bouns : {CalculateBouns()}";
    //}
    #endregion

    //  }

    #region ThirdCode
    public abstract class User
    {
        public enum UserType
        {
            Gold,
            Silver
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        //  public UserType Usertype { get; set; }

        protected User(int id, string name, decimal salary/*, UserType usertype*/)
        {
            Id = id;
            Name = name;
            Salary = salary;
            // Usertype = usertype;
        }

        public abstract decimal CalculateBouns();
        public override string ToString()
        {
            return $"{nameof(Id)} : {Id} , {nameof(Name)} : {Name} , Bouns : {CalculateBouns()}";
        }

    }

    public class GoldUser : User
    {
        public GoldUser(int id, string name, decimal salary) : base(id, name, salary)
        {

        }
        public override decimal CalculateBouns()
        {
            return Salary * .1M;
        }
    }

    public class SilverUser : User
    {
        public SilverUser(int id, string name, decimal salary) : base(id, name, salary)
        {

        }
        public override decimal CalculateBouns()
        {
            return Salary * .05M;
        }
    }

    #endregion
}
