namespace BlazorServerSQLite.Data
{
    public class Province
    {
        public string Name { get; set; }
        public int Code { get; set; }


        public static List<Province> Provinces = new List<Province>
    {
        new Province (){Name = "Albacete", Code = 02},
        new Province (){Name = "Alicante", Code = 03},
        new Province (){Name = "Almería", Code = 04},
        new Province (){Name = "Álava", Code = 01},
        new Province (){Name = "Asturias", Code = 33},
        new Province (){Name = "Ávila", Code = 05},
        new Province (){Name = "Badajoz", Code = 06},
        new Province (){Name = "Balears, Illes", Code = 07},
        new Province (){Name = "Barcelona", Code = 08},
        new Province (){Name = "Bizkaia", Code = 48},
        new Province (){Name = "Burgos", Code = 09},
        new Province (){Name = "Cáceres", Code = 10},
        new Province (){Name = "Cádiz", Code = 11},
        new Province (){Name = "Cantabria", Code = 39},
        new Province (){Name = "Castellón", Code = 12},
        new Province (){Name = "Ciudad Real", Code = 13},
        new Province (){Name = "Córdoba", Code = 14},
        new Province (){Name = "A Coruña", Code = 15},
        new Province (){Name = "Cuenca", Code = 16},
        new Province (){Name = "Gipuzkoa", Code = 20},
        new Province (){Name = "Girona", Code = 17},
        new Province (){Name = "Granada", Code = 18},
        new Province (){Name = "Guadalajara", Code = 19},
        new Province (){Name = "Huelva", Code = 21},
        new Province (){Name = "Huesca", Code = 22},
        new Province (){Name = "Jaén", Code = 23},
        new Province (){Name = "León", Code = 24},
        new Province (){Name = "Lleida", Code = 25},
        new Province (){Name = "Lugo", Code = 27},
        new Province (){Name = "Madrid", Code = 28},
        new Province (){Name = "Málaga", Code = 29},
        new Province (){Name = "Murcia", Code = 30},
        new Province (){Name = "Navarra", Code = 31},
        new Province (){Name = "Ourense", Code = 32},
        new Province (){Name = "Palencia", Code = 34},
        new Province (){Name = "Las Palmas", Code = 35},
        new Province (){Name = "Pontevedra", Code = 36},
        new Province (){Name = "La Rioja", Code = 26},
        new Province (){Name = "Salamanca", Code = 37},
        new Province (){Name = "Santa Cruz de Tenerife", Code = 38},
        new Province (){Name = "Segovia", Code = 40},
        new Province (){Name = "Sevilla", Code = 41},
        new Province (){Name = "Soria", Code = 42},
        new Province (){Name = "Tarragona", Code = 43},
        new Province (){Name = "Teruel", Code = 44},
        new Province (){Name = "Toledo", Code = 45},
        new Province (){Name = "Valencia", Code = 46},
        new Province (){Name = "Valladolid", Code = 47},
        new Province (){Name = "Zamora", Code = 49},
        new Province (){Name = "Zaragoza", Code = 50},
        new Province (){Name = "Ceuta", Code = 51},
        new Province (){Name = "Melilla", Code = 52},
    };
    }
}