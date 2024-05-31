using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPerson
{
    public class Student : AbstractPerson
    {
        public static new string DataSeparator { get; set; } = "/";
        public static new string TextDataSample { get; set; }
        = $"<year>{DataSeparator}<class> eg. 4{DataSeparator}E8";
        protected byte _year;
        protected string _cls = "";
        public byte Year { get { return _year; } set { _year = value; Notify(); } }
        public string Class { get { return _cls; } set { _cls = value; Notify(); } }
        #region Overriding operations
        public override string Info => $"year:{_year}, class:{_cls}";
        public override bool SetTextData(string data)
        {
            var arr = data.Split(DataSeparator);
            if (arr.Length < 5) return false;
            if (byte.TryParse(arr[2], out byte age) == false) return false;
            if (byte.TryParse(arr[3], out byte year) == false) return false;
            _name = arr[0].Trim();
            _gender = arr[1].Trim();
            this._age = age;
            this._year = year;
            _cls = arr[4];
            Notify();
            return true;
        }
        public override string GetTextData() => $"{_year}{DataSeparator}{_cls}";
        #endregion
    }


    public class Teacher : AbstractPerson
    {
        public static new string DataSeparator { get; set; } = "/";
        public static new string TextDataSample { get; set; }
        = $"<school>{DataSeparator}<classes> eg. RUPP{DataSeparator}M1, A1, E2";
        protected string _school = "";
        protected string _classes = "";
        public string School { get { return _school; } set { _school = value; Notify(); } }
        public string Classes { get { return _classes; } set { _classes = value; Notify(); } }
        #region Overriding operations
        public override string Info => $"school:{_school}, classes:{_classes}";
        public override bool SetTextData(string data)
        {
            var arr = data.Split(DataSeparator);
            if (arr.Length < 5) return false;
            if (byte.TryParse(arr[2], out byte age) == false) return false;
            this._name = arr[0];
            this._gender = arr[1];
            this._age = age;
            this._school = arr[3];
            this._classes = arr[4];
            Notify();
            return true;
        }
        public override string GetTextData() => $"{_school}{DataSeparator}{_classes}";
        #endregion
    }
    public class Employee : AbstractPerson
    {
        public static new string DataSeparator { get; set; } = "/";
        public static new string TextDataSample { get; set; }
        = $"<workingplace>{DataSeparator}<salary> eg. RUPP{DataSeparator}2500";
        protected string _place = "";
        protected double _salary = 0.0;
        public string WorkingPlace { get { return _place; } set { _place = value; Notify(); } }
        public double Salary { get { return _salary; } set { _salary = value; Notify(); } }
        #region Overriding operations
        public override string Info => $"working place:{_place}, salary:{_salary}";
        public override bool SetTextData(string data)
        {
            var arr = data.Split(DataSeparator);
            if (arr.Length < 5) return false;
            if (byte.TryParse(arr[2], out byte age) == false) return false;
            if (double.TryParse(arr[4], out double salary) == false) return false;
            _name = arr[0];
            _gender = arr[1];
            _age = age;
            _place = arr[3];
            _salary = salary;
            Notify();
            return true;
        }
        public override string GetTextData() => $"{_place}{DataSeparator}{_salary}";
        #endregion
    }
}
