using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Records
{
    public class PointClass
    {
        enum Season { Spring, Summer, Fall, Winter };
        public PointClass(double x, double y) => (X, Y) = (x, y);
        public double X { get; init; }
        public double Y { get; init; }
        protected PointClass(PointClass original) // “Copy constructor”
        {
            this.X = original.X; this.Y = original.Y
        }
        // This method has a strange compiler-generated name:
        // public virtual PointClass <Clone>$() => new PointClass (this); // Clone method
        // Additional code to override Equals, ==, !=, GetHashCode, ToString()

        public string GetWeightCategory(decimal bmi) => bmi switch
        {
            < 18.5m => "underweight",
            < 25m => "normal",
            < 30m => "overweight",
            _ => "obese"
        };

        bool IsJanetOrJohn(string name) => name.ToUpper() is "JANET" or "JOHN";
        bool IsVowel(char c) => c is 'a' or 'e' or 'i' or 'o' or 'u';
        bool Between1And9(int n) => n is >= 1 and <= 9;
        bool IsLetter(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        int AverageCelsiusTemperature(Season season, bool daytime) => (season, daytime) switch
        {
            (Season.Spring, true) => 20,
            (Season.Spring, false) => 16,
            (Season.Summer, true) => 27,
            (Season.Summer, false) => 22,
            (Season.Fall, true) => 18,
            (Season.Fall, false) => 12,
            (Season.Winter, true) => 10,
            (Season.Winter, false) => -2,
            _ => throw new Exception("Unexpected combination")
        };

        bool ShouldAllow(Uri uri) => uri switch
        {
            { Scheme: "http", Port: 80, Host: var host } => host.Length < 1000,
            { Scheme: "https", Port: 443 } => true,
            { Scheme: "ftp", Port: 21 } => true,
            { IsLoopback: true } => true,
            _ => false
        };

    }
}