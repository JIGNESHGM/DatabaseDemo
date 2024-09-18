using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeBonusCalculateWebApplication.BAL
{
    public class Employee
    {
        private string _Name;
        private int _Salary;
        private float _Bonus, _NetSalary;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }

        public void CalculateBonus()
        {
            _Bonus = 0;
            if (_Salary > 1000 && _Salary <= 5000)
            {
                _Bonus = _Salary * 0.10f;
            }
            else if(_Salary > 5000 && _Salary <= 10000)
            {
                _Bonus = _Salary * 0.075f;
            }
            else if(_Salary > 10000 && _Salary <= 50000)
            {
                _Bonus = _Salary * 0.05f;
            }
            else if (_Salary >50000 && _Salary <= 100000)
            {
                _Bonus = _Salary * 0.025f;
            }
        }

        public void NetSalaryCalculate()
        {
            _NetSalary = _Salary + _Bonus;
        }

        public Tuple<string,int,float,float> GetData()
        {
            return new Tuple<string, int, float, float>(_Name,_Salary,_Bonus,_NetSalary) ;
        }
    }
}