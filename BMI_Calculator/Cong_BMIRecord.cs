using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Cong_BMIRecord
    {   
        public static int _id = MainForm.table.Rows.Count;
        private string _name;
        private double _height;
        private double _weight;
        private double bmi;
        private string healthStatus;
        public static DateTime addTime;
        private string comment;
        public string Name
        {
            get;
            set;
        }

        public double Height
        {
            get;
            set;
        }

        public double Weight
        {
            get;
            set;
        }

        public Cong_BMIRecord(string name, double height, double weight)
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
            _id++;
        }

        /// <summary>
        /// Calculate the BMI
        /// </summary>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        public double CalculateBMI(double height, double weight)
        {
            bmi = weight / (height/100 * height/100);
            string tmp = String.Format("{0:F}", bmi);
            bmi = Convert.ToDouble(tmp);
            return bmi;
        }

        public string HealthStatus(double bmi)
        {
            //       Underweight Healthy Weight  Overweight     Obese
            //BMI     < 18.5      18.5≤BMI< 24   24≤BMI<28      28≤BMI
            if (bmi < 18.5)
            {
                comment = "Underweight";
            }else if(bmi>=18.5 && bmi < 24)
            {
                comment = "Healthy Weight";
            }else if(bmi>=24 && bmi < 28)
            {
                comment = "Overweight";
            }
            else
            {
                comment = "Obese";
            }

            return comment;
        }

        public override string ToString()
        {
            return $"Dear {this.Name}, your bmi is {bmi:0.00}. You are {comment}";
        }

    }
}
