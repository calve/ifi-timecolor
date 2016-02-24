using System.ComponentModel.DataAnnotations;
using System;

namespace MvcSample.Web.Models
{
    public class Timecolor
    {
        [Required]
        public int Timestamp { get; set; }
        public string Hexcolor { get
                {
                    int red = 10 * int.Parse(this.Datetime.ToString("HH"));
                    int green = 4 * int.Parse(this.Datetime.ToString("MM"));
                    int blue = 4 * int.Parse(this.Datetime.ToString("ss"));
                    return String.Format("#{0,2:X2}{1,2:X2}{2,2:X2}", red, green, blue);
                }
        }

        public DateTime Datetime{
            get {
                // Unix timestamp is seconds past epoch
                System.DateTime dtDateTime = new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds( this.Timestamp ).ToLocalTime();
                return dtDateTime;
            }
        }
    }
}
    