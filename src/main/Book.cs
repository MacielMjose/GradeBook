namespace GradeBookProject{

    using System;
    using System.Collections.Generic;

    public class Book{

        private string nome;
        private string id;
        private double grade;
        

        public Book(string nome){
            this.nome = nome;
        }

        public string getName(){
            return this.nome;
        }
        public void addGrade(double grade){
            this.grade = grade;
            grades.Add(this.grade);
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
        List<double>grades = new List<double>();
    }
}