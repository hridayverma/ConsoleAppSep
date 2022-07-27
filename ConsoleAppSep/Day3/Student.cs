using System;
namespace ConsoleAppSep.Day3
{
    class Student    {
        //data field
        int _RollNo;
        string _Name;
        int _Age;
        //Methods
       internal void SetStudentDetails(int _RollNo,string _Name,int _Age)        {
            this._RollNo = _RollNo;
            this._Name = _Name;
            this._Age = _Age;
            Console.WriteLine("Details Saved!!!");
        }
       protected internal void DisplayStudentDetails() {
            Console.WriteLine("Student Details are:");
            Console.WriteLine($"Roll No:{_RollNo}\tName:{_Name}\tAge:{_Age}");
        }
    }
}
