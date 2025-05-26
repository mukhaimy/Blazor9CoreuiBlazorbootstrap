using System.ComponentModel.DataAnnotations;

namespace Blazor9CoreuiBlazorbootstrap.Models
{
    public class DemoPerson
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        public int BirthYear { get; set; } = 1950;


        public static List<DemoPerson> SampleSet()
        {
            int ix = 1;
            List<DemoPerson> hsl = new List<DemoPerson>();
            hsl.Add(new DemoPerson { Id = ix++, Name = "Masahide Akagi", BirthYear = 1989 });
            hsl.Add(new DemoPerson { Id = ix++, Name = "Rosemary Thompson", BirthYear = 1997 });
            hsl.Add(new DemoPerson { Id = ix++, Name = "Nikki Fox", BirthYear = 1990 });
            hsl.Add(new DemoPerson { Id = ix++, Name = "Nick Vincent", BirthYear = 2004 });
            hsl.Add(new DemoPerson { Id = ix++, Name = "Gerald Frye", BirthYear = 1993 });
            hsl.Add(new DemoPerson { Id = ix++, Name = "Tadashi Uehara", BirthYear = 2001 });
            hsl.Add(new DemoPerson { Id = ix++, Name = "Ricardo Glass", BirthYear = 2001 });
            hsl.Add(new DemoPerson { Id = ix++, Name = "Gavin Richardson", BirthYear = 1988 });
            hsl.Add(new DemoPerson { Id = ix++, Name = "Lily Gomez", BirthYear = 1994 });
            hsl.Add(new DemoPerson { Id = ix++, Name = "Dina Murillo", BirthYear = 1997 });
            hsl.Add(new DemoPerson { Id = ix++, Name = "Tara Phillips", BirthYear = 2000 });
            hsl.Add(new DemoPerson { Id = ix++, Name = "Laura Lynn", BirthYear = 2001 });
            hsl.Add(new DemoPerson { Id = ix++, Name = "Audrey Williams", BirthYear = 2002 });
            hsl.Add(new DemoPerson { Id = ix++, Name = "Frank Stubbs", BirthYear = 1997 });

            return hsl;
        }
    }
}
