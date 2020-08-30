namespace GradeBookProject{

    using System;
    using System.Collections.Generic;

    public class Book{

        public string Name;
        private string id;
        private List<double> grades;
        

        public Book(string nome){
            Name = nome;
            grades = new List<double>();
        }

        public string getName(){
            return this.Name;
        }
        public void addGrade(double grade){
            grades.Add(grade);
        }

        public Statistics getStatistics(){
            var result = new Statistics();
            
            result.average = 0.0;
            result.lowGrade = double.MaxValue;
            result.highGrade = double.MinValue;

            foreach (var grade in grades)
            {
                result.average += grade;
                result.lowGrade = Math.Min(grade,result.lowGrade);
                result.highGrade = Math.Max(grade,result.highGrade);
            }
            result.average = result.average/grades.Count;
            
            return result;
        }
        public double average(){
            double avg = 0 ;

            foreach (var grade in grades)
            {
                avg+= grade;
            }

            return avg/grades.Count;
        }
        
    }
}