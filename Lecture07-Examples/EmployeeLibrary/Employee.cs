using System;

namespace EmployeeLibrary
{
    public class Employee
    {
        #region 欄位與屬性的定義

        public string Id { get; set; }
        public string Name { get; set; }

        public int BaseSalary  //封裝
        {
            get => baseSalary;
            set
            {
                if (value < 25000)
                    baseSalary = 25000;
                else if (value > 60000)
                    baseSalary = 60000;
                else
                    baseSalary = value;
            }
        }

        public int Benefit
        {
            get => benefit;
            set
            {
                benefit = value < 0 ? 0 : value;
            }
        }

        public int Salary
        {
            get
            {
                return baseSalary + benefit;
            }
        }

        private int baseSalary;
        private int benefit;

        #endregion 欄位與屬性的定義

        #region 建構式

        public Employee()
            : this("無名氏", 0, 0)
        {
        }

        public Employee(string name, int baseSalary, int benefit)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.Benefit = benefit;
        }

        #endregion 建構式
    }
}

/*類別功能
建立Empolyee 類別
類別中含有BaseSalary、Salary 及Benefit屬性
BaseSalary 屬性必須大於等於0
Salary 為唯讀屬性，其值為BaseSalary 加上Benefit
程式功能
主程式中請使用者輸入底薪及獎金值
列印出類別salary 屬性值*/