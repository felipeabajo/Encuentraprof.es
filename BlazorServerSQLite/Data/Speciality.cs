namespace BlazorServerSQLite.Data
{
    public class Speciality
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public static List<Speciality> Specialities = new List<Speciality>
        {
        new Speciality (){Name = "French", Code = 01},
        new Speciality (){Name = "English", Code = 02},
        new Speciality (){Name = "Spanish", Code = 03}
        };
    }
}