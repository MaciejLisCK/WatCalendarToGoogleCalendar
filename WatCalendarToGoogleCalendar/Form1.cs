using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatCalendarToGoogleCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxInput_TextChanged(object sender, EventArgs e)
        {
            var dataLines = uxInput.Lines.Skip(1).Take(uxInput.Lines.Length-2);

            var result = "";
            foreach (var line in dataLines)
            {
                var values = line.Split(',');

                var courseNameShortcut = GetCourseShortcut(values[0]);
                var labNumber = GetLabNumber(values[0]);
                var groups = GetGroups(values[0]);
                var location = values[1];
                var startDateTime = GetDateTime(values[2], values[3]);
                var endDateTime = GetDateTime(values[4], values[5]);
                var mainLocation = "Wojskowa Akademia Techniczna im. Jarosława Dąbrowskiego, gen. Sylwestra Kaliskiego, Warszawa, Polska";

                result += $"{courseNameShortcut} [{labNumber}] [{location}] {groups}\t{startDateTime}\t{endDateTime}\t\t{mainLocation}\r\n";
            }
            uxOutput.Text = result;
        }

        private string GetDateTime(string date, string time)
        {
            var dateValues = date.Split('-');

            return dateValues[2] + "/" + dateValues[1] + "/" + dateValues[0] + " " + time + ":00";
        }

        private object GetGroups(string value)
        {
            return value.SkipWhile(c => c != ']').Skip(1).AsString().Trim();
        }

        private string GetLabNumber(string value)
        {
            return value.SkipWhile(c => c != '[').Skip(1).TakeWhile(c => c != ']').AsString();
        }

        private object GetCourseShortcut(string value)
        {
            var courseName = value.TakeWhile(v => v != '(').AsString().Trim();
            var courseNameValues = courseName.Split(' ');
            var courseInitials = courseNameValues.Select(cnv => cnv.First().ToUpper());
            return courseInitials.AsString();
        }



        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }

    public static class MyClass
    {
        public static char ToUpper(this char character)
        {
            return char.ToUpper(character);
        }

        public static string AsString(this IEnumerable<char> charSequence)
        {
            return new String(charSequence.ToArray());
        }
    }
}
