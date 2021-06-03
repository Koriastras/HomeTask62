using Microsoft.VisualBasic.FileIO;
using System.Linq;

namespace HomeTask62.Framework.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }




        public static User User1()
        {
            TextFieldParser tfp = new TextFieldParser("table.csv");
            tfp.TextFieldType = FieldType.Delimited;
            tfp.SetDelimiters(",");
            string[] fields;
            fields = tfp.ReadFields();

            return new User { Username = fields[0], Password = fields[1], FirstName = fields[2], LastName = fields[3] };
        }

        //public static User User2()
        //{
        //    TextFieldParser tfp = new TextFieldParser("table.csv");
        //    tfp.TextFieldType = FieldType.Delimited;
        //    tfp.SetDelimiters(",");
        //    string[] fields;
        //    fields = tfp.ReadFields();

        //    return new User { Username = fields[4], Password = fields[5], FirstName = fields[6], LastName = fields[7] };
        //}
        //public static User User3()
        //{
        //    TextFieldParser tfp = new TextFieldParser("table.csv");
        //    tfp.TextFieldType = FieldType.Delimited;
        //    tfp.SetDelimiters(",");
        //    string[] fields;
        //    fields = tfp.ReadFields();

        //    return new User { Username = fields[8], Password = fields[9], FirstName = fields[10], LastName = fields[11] };

        //}
        //public static User User4()
        //{
        //    TextFieldParser tfp = new TextFieldParser("table.csv");
        //    tfp.TextFieldType = FieldType.Delimited;
        //    tfp.SetDelimiters(",");
        //    string[] fields;
        //    fields = tfp.ReadFields();

        //    return new User { Username = fields[12], Password = fields[13], FirstName = fields[14], LastName = fields[15] };
        //}
        //public static User User5()
        //{
        //    TextFieldParser tfp = new TextFieldParser("table.csv");
        //    tfp.TextFieldType = FieldType.Delimited;
        //    tfp.SetDelimiters(",");
        //    string[] fields;
        //    fields = tfp.ReadFields();

        //    return new User { Username = fields[16], Password = fields[17], FirstName = fields[18], LastName = fields[19] };
        //}
    }
}