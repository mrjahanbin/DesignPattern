using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<User> _UserList = new List<User>();
            _UserList.Add(new User() { Id = 1, UserName = "User1", Password = "12345", FirstName = "UserOne", LastName = "UserOneVand" });
            _UserList.Add(new User() { Id = 2, UserName = "User3", Password = "12345", FirstName = "UserTwo", LastName = "UserTwoVand" });
            _UserList.Add(new User() { Id = 3, UserName = "User4", Password = "12345", FirstName = "UserThree", LastName = "UserThreeVand" });
            _UserList.Add(new User() { Id = 4, UserName = "User5", Password = "12345", FirstName = "UserFore", LastName = "UserForeVand" });
            _UserList.Add(new User() { Id = 5, UserName = "User6", Password = "12345", FirstName = "UserFive", LastName = "UserFiveVand" });



            #region NOT OK

            //var filename = "d:/singleTest.txt";
            //string _List = "";

            //foreach (var item in _UserList)
            //{
            //    _List += $"Name : { item.FirstName } { item.LastName }  \n";
            //}

            //File.WriteAllText(filename, _List);
            //Process.Start("notepad.exe", filename);

            #endregion

            #region OK
            var filename = "d:/singleTest.txt";
            string _List = UserList.ListToString(_UserList);

            SaveFile.Save(filename,_List);
            OpenFile.Open(filename);
            #endregion
        }




    }
    public static class UserList
    {
        public static string ListToString(List<User> _UserList)
        {
            var _List = "";
            foreach (var item in _UserList)
            {
                _List += $"Name : { item.FirstName } { item.LastName }  \n";
            }
            return _List;
        }
    }
    public static class SaveFile
    {
        public static void Save(string filename, string _List)
        {
            File.WriteAllText(filename, _List);
        }
    }
    public static class OpenFile
    {
        public static void Open(string filename)
        {
            Process.Start("notepad.exe", filename);
        }
    }

}
