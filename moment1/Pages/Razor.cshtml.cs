using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace moment1.Pages
{
    public class RazorModel : PageModel
    {
        public List<string> Courses
        {
            get; set;
        }
        public string Message
        {
            get; set;
        }
        public void OnGet()
        {
            Courses = new List<string>
            {
                "DT057G - Webbutveckling I (50%) - HT19",
                "HT19 DT084G Datateknik GR (A) Introduktion till programmering i JavaScript, 7,5 hp",
                "HT19 DT163G Datateknik GR (A), Digital bildbehandling för webb, 7,5 hp",
                "HT19 GD008G Grafisk design GR (A), Typografi och form för webb, 7,5 hp",
                "FT162G Datateknik GR (B), JavaScriptbaserad webbutveckling, 7,5 hp VT20",
                "VT20 DT003G Datateknik GR (A), Databaser, 7,5 hp",
                "VT2020 DT093G Datateknik GR (B), Webbutveckling II, 7,5 hp",
                "VT2020 DT152G Datateknik GR (B), Webbdesign för CMS, 7,5 hp (distans)",
                "HT20 IK060G Informatik GR (A), Projektledning, 7,5 hp (distans)",
                "HT2020 DT068G Datateknik GR (B), Webbanvändbarhet, 7,5 hp (distans)",
                "HT2020 DT071G Datateknik GR (A), Programmering i C#.NET, 7,5 hp (distans)",
                "HT2020 DT084G Datateknik GR (A), Introduktion till programmering i JavaScript, 7,5 hp (distans)",
                "HT2020 DT163G Datateknik GR (A), Digital bildbehandling för webb, 7,5 hp (distans)",
                "HT2020 DT173G Datateknik GR (B), Webbutveckling III, 7,5 hp (distans)",
                "VT2021 DT102G Datateknik GR (B), ASP.NET med C#, 7,5 hp (distans)",
                "VT21 IG021G Industriell organisation och ekonomi GR (A), Affärsplaner och kommersialisering, 7,5 hp",
            };
            var date = DateTime.Now;
            
            if (date.DayOfWeek == DayOfWeek.Monday)
            {
                Message = "Idag är det måndag";
            }
            else
            {
                Message = "Idag är det inte måndag";
            }
        }
    }
}
