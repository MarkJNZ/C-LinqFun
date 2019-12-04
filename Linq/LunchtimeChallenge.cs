using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace Linq
{
    public class LunchtimeChallenge
    {
        public LunchtimeChallenge()
        {

        }



        /// <summary>
        /// http://mark-dot-net.blogspot.com/2013/06/lunchtime-linq-challenge.html
        /// 1. Take the following string "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert" and give each player a shirt number, starting from 1, to create a string of the form: "1. Davis, 2. Clyne, 3. Fonte" etc
        /// </summary>
        public static void Execute_1()
        {
            var names = "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert";
            int i = 1;
            var players = names.Split(',').Select(p => $"{p} {i++}").ToList();
            players.ForEach(Console.Write);
            Console.ReadLine();
        }

        /// <summary>
        /// 2. Take the following string "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988" and turn it into an IEnumerable of players in order of age(bonus to show the age in the output)    
        /// https://ideone.com/FrcODC
        /// </summary>
        public static void Execute_2()
        {
            var names = "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988";

            var currentYear = DateTime.Now.Year;
            var players = names.Split(';')
                .Select(p =>
                {
                    var pa = p.Split(',');
                    return new
                    {
                        name = pa[0],
                        dob = pa[1].Trim(),
                        age = currentYear - DateTime.ParseExact(pa[1].Trim(),"dd/MM/yyyy",CultureInfo.InvariantCulture).Year
                    };
                })
                .OrderBy(a => a.age)
                .ToList();

                players.ForEach(Console.WriteLine);
                Console.ReadLine();
        }



        /// <summary>
        /// http://mark-dot-net.blogspot.com/2013/06/lunchtime-linq-challenge.html
        /// 3. Take the following string "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27" which represents the durations of songs in minutes and seconds, and calculate the total duration of the whole album
        /// http://ideone.com/jaZpOD
        /// </summary>
        public static void Execute_3()
        {
            var songs = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";

            var album = songs.Split(',')
                .Aggregate((int result, string song) => 
                {
                    result = result ++;
                    

                })




            var currentYear = DateTime.Now.Year;
            var players = names.Split(';')
                .Select(p =>
                {
                    var pa = p.Split(',');
                    return new
                    {
                        name = pa[0],
                        dob = pa[1].Trim(),
                        age = currentYear - DateTime.ParseExact(pa[1].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture).Year
                    };
                })
                .OrderBy(a => a.age)
                .ToList();

            players.ForEach(Console.WriteLine);
            Console.ReadLine();
        }



    }
}
