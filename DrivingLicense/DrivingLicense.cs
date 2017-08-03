using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrivingLicense
{
    [TestClass]
    public class DrivingLicense
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string[] data = new string[] { "John", "James", "Smith", "01-Jan-2000", "M" };

            //Action
            var actual = LicenceCreater.Create(data);
            var expected = "SMITH001010JJ9AA";

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string[] data = new string[] { "Johanna", "", "Gibbs", "13-Dec-1981", "F" };

            //Action
            var actual = LicenceCreater.Create(data);
            var expected = "GIBBS862131J99AA";

            //assert
            Assert.AreEqual(expected, actual);
        }
    }

    public class LicenceCreater
    {
        public static string Create(string[] data)
        {
            bool isMale = data[4] == "Male" || data[4] == "M";
            var license = GetSurname(data[2]).ToUpper() +
             Get3rdDigitOfYear(data[3])
            + GetMonthInNumber(data[3], isMale)
            + GetDayofBirthday(data[3])
            + Get4thDigitOfYear(data[3])
            + GetInitialOfName(data[0], data[1])
            + "9AA";
            return license;
        }

        private static string GetInitialOfName(string firstName, string middleName)
        {
            var initialOfFirstName = String.IsNullOrEmpty(firstName) ? "9" : firstName.Substring(0, 1);
            var initialOfMiddleName = String.IsNullOrEmpty(middleName) ? "9" : middleName.Substring(0, 1); ;
            return String.Concat(initialOfFirstName + initialOfMiddleName);
        }


        private static string Get4thDigitOfYear(string date)
        {
            var datetime = date.Split('-');
            var year = datetime[2];
            return year.Substring(3, 1);
        }

        private static string GetDayofBirthday(string date)
        {
            var datetime = date.Split('-');
            return datetime[0];
        }

        private static object GetMonthInNumber(string date, bool isMale)
        {
            var datetime = date.Split('-');
            var month = datetime[1];

            return MonthInNumber(month, isMale);
        }

        private static string MonthInNumber(string month, bool isMale)
        {
            var result = "";
            switch (month)
            {
                case "Jan":
                case "January":
                    result = isMale ? "01" : "51";
                    break;
                case "Feb":
                case "February":
                    result = isMale ? "02" : "52";
                    break;
                case "Mar":
                case "March":
                    result = isMale ? "03" : "53";
                    break;
                case "Apr":
                case "April":
                    result = isMale ? "04" : "54";
                    break;
                case "May":
                    result = isMale ? "05" : "55";
                    break;
                case "Jun":
                case "June":
                    result = isMale ? "06" : "56";
                    break;
                case "Jul":
                case "July":
                    result = isMale ? "07" : "57";
                    break;
                case "Aug":
                case "August":
                    result = isMale ? "08" : "58";
                    break;
                case "Sep":
                case "September":
                    result = isMale ? "09" : "59";
                    break;
                case "Oct":
                case "October":
                    result = isMale ? "10" : "60";
                    break;
                case "Nov":
                case "November":
                    result = isMale ? "11" : "61";
                    break;
                case "Dec":
                case "December":
                    result = isMale ? "12" : "62";
                    break;

            }
            return result;
        }

        private static string Get3rdDigitOfYear(string date)
        {
            var datetime = date.Split('-');
            var year = datetime[2];

            return year.Substring(2, 1);
        }

        private static string GetSurname(string surname)
        {
            if (surname.Length >= 5) return surname.Substring(0, 5);
            var result = surname;
            for (int i = 0; i < 5 - surname.Length; i++)
            {
                result += '9';
            }
            return result;
        }
    }
}
