namespace AllAboutBoxing.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using AllAboutBoxing.Data.Models;

    public class WeightClassesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.WeightClasses.Any())
            {
                return;
            }

            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Heavyweight",
                WeightLimit = "Unlimited",
                Established = 1738,
                Description = "Heavyweight - Boxing’s glamour division was first created by Jack Broughton in 1738, with fighters weighing in at 160+ lb / 72.57+ kg. Since the division has no weight limit, fighters could theoretically weigh as much as they want and fight at heavyweight. The weight at which a fighter is considered a heavyweight would be modified a few times in the following years, namely in 1920 by the New York Walker Law to 175+ lb, 190+ lb by the WBC in 1979 and finally by the WBC, WBA and IBF together to the present day weight of 200+ lb. The inaugural heavyweight champion was legendary John L. Sullivan, who defeated Jim Corbett on September 7, 1892. The modern version of the title was first won in 1962 by Floyd Patterson as the WBA world heavyweight championship. The WBC sanctioned their first heavyweight world title fight the following year, the IBF in 1983, and the WBO in 1989. American boxer Joe Louis holds the longest title reign with 25 title defenses. Notable heavyweight champions throughout history: John L. Sullivan, Bob Fitzsimmons, Jack Johnson, Jack Dempsey, Joe Louis, Rocky Marciano, Muhammad Ali, Joe Fraizer, Larry Holmes, George Foreman, Larry Holmes, Mike Tyson, Evander Holyfield, Lennox Lewis, Vitali Klitschko, Wladimir Klitschko, Tyson Fury, Deontay Wilder, Anthony Joshua.",
            });

            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Cruiserweight",
                WeightLimit = "200 lb / 90.72 kg / 14 st 4 lb",
                Established = 1979,
                Description = "Cruiserweight or Junior Heavyweight - First established by the WBC in 1979 with a limit of 190 lb / 86.18 kg, to fit smaller heavyweights who couldn’t compete with the growing size of the other fighters in the division. The first sanctioned cruiserweight world champion fight was between Marvin Camel and Mate Parlov for the new WBC Cruiserweight belt. However, with the first bout ending in a draw, it was the rematch in which Camel emerged victorious to become the first cruiserweight world champion. Later on, in 2003, the WBC and then subsequently, the other three sanctioning bodies decided for a new limit in the division of 200 lb / 90.71 kg. The longest title reign is jointly held by Johnny Nelson and Marco Huck with 13 title defenses. Notable cruiserweight champions throughout history: Carlos de Leon, Evander Holyfield, O’Neil Bell, Anaclet Wamba, David Haye, Oleksandr Usyk",
            });
            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Light Heavyweight",
                WeightLimit = "175 lb / 79.38 kg / 12 st 7lb",
                Established = 1903, 
                Description = "Credit for creating the light heavyweight division goes to Chicago journalist and promoter Lou Houseman. He matched his fighter Jack Root against Kid McCoy for the inaugural light heavyweight championship. Root ended up victorious while becoming the first light heavyweight champion of the world. Officially it was established in 1909 by the National Sporting Club of London, with the present weight limit of 175 lb / 79.37 kg. During the 1980s, some historians found that Joe Choynski had fought against Jimmy Ryan in 1899 for the world light heavyweight championship. However, this claim is disputed. German-Polish boxer Dariusz Michalczewski holds the longest title reign with 23 title defenses. Notable light heavyweight champions throughout history: Georges Carpentier, Tommy Loughran, Billy Conn, Archie Moore, Bob Foster, Michael Spinks, Dariusz Michalczewski, Roy Jones Jr., Antonio Tarver, Joe Calzaghe, Bernard Hopkins.",
            });
            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Super Middleweight",
                WeightLimit = "168 lb / 76.2 kg / 12 st",
                Established = 1967,
                Description = "Interest for a division between light heavyweight and middleweight appeared in the 1960s. The origin of the title traces back to the ‘junior light heavyweight champion’, a title briefly recognized by a few states at 167 lb / 75.75 kg. On the 3rd April 1967, Don Fullmer challenged Jon Hopkins for the vacant junior light heavyweight championship, and with his TKO win became the inaugural champion of the world at this weight.  After that, the super middleweight championship was re-established a few more times. Notably, in 1974, when Billy Douglas won the Ohio State Commission version of the belt and in 1982 when Jerry Halstead captured the World Athletic Association version of it. Out of the four major sanctioning bodies, the IBF was the first to introduce the belt in 1984, with the others following suit in 1987 (WBA) and 1988 (WBC). The longest title reign is jointly held by British and German boxers Joe Calzaghe and Sven Ottke with 21 title defenses. Notable super-middleweight champions throughout history: Nigel Benn, Chris Eubank, James Toney, Roy Jones Jr., Joe Calzaghe, Mikkel Kessler, Andre Ward",
            });
            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Middleweight",
                WeightLimit = "160 lb / 72.57 kg / 11 st 6 lb",
                Established = 1840,
                Description = "The middleweight division is deemed to have begun in the bare-knuckle era, around the 1840s. The first middleweight championship in that form would be awarded to Tom Chandler in 1867, after beating Dooney Harris. The first middleweight fight with gloves is believed to be between George Fulljames and Jack (Nonpareil) Dempsey. In that sense, Jack Dempsey can be considered the inaugural world middleweight champion. The beginnings of the current version of the belt were initially created by the Amateur Boxing Association of England in 1889. It was then modified and officially established by the NSC in 1909 at the weight limit of 160 lbs / 72.57 kg. The longest title reign is held by American boxer Bernard Hopkins with 20 title defenses. Notable middleweight champions throughout history: Jack (Nonpareil) Dempsey, Stanley Ketchel, Freddie Steele, Tony Zale, Jake LaMotta, Sugar Ray Robinson, Emilie Griffith, Marvin Hagler, Carlos Monzon, James Toney, Roy Jones Jr., Bernard Hopkins",
            });
            dbContext.WeightClasses.Add(new WeightClass
            { 
                Division = "Super Welterweight",
                WeightLimit = "154 lb / 69.85 kg / 11 st",
                Established = 1920,
                Description = "This division is considered first to have emerged in 1920 by the New York Walker Law, one of the most important American boxing legislation at that time. Subsequently, it was recognized by the Austrian Boxing Board of Control along with the European Boxing Union in 1962. The first sanctioned bout for the light-middleweight championship of the world was between Emile Griffith and Ted Wright on 17th October 1962, in Vienna, Austria. Griffith won the fight via 15 round unanimous decision to become the inaugural world light middleweight champion of the belt in this form. Out of the four major sanctioning bodies, the WBA was the first to sanction a super welterweight championship fight three days after the fight in Vienna. The title, also recognized by the WBC, was claimed by Denny Moyer in his win against Joey Giambra. The IBF crowned their first champion in the division after Mark Medal defeated Earl Hargrove in 1984. The WBO awarded their inaugural version of the belt to John David Jackson after he beat Lupe Aquino in 1988. Italian boxer Gianfranco Rosi holds the longest title reign with 11 title defenses. Notable super welterweight champions throughout history: Nino Benvenuti, Emile Griffith, Wilfred Benitez, Thomas Hearns, Julian Jackson, Mike McCallum, Gianfranco Rosi, Sugar Ray Leonard, Roberto Duran, Felix Trinidad, Winky Wright, Miguel Cotto, Oscar De La Joya, Floyd Mayweather Jr.",
            });
            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Welterweight",
                WeightLimit = "147 lb / 66.68 kg / 10 st 7 lb",
                Established = 1909,
                Description = "The beginnings of the division trace back to England, 1889, when the first created weight limit is believed to have been 145 lb / 65.77 kg. Officially it was established in 1909 by the NSC at 147 lb / 66.68 kg and consequently accepted by the New York State Athletic Commission and National Boxing Association in 1920. American Paddy Duffy defeated Tom Meadows on the 29th March 1889 and became what is believed to be the first welterweight champion of the world. The WBA and WBC both recognized only one welterweight champion for a few years. The first holder being Emile Griffith after he beat Argentinian Jorge Fernandez on 8th December 1962. American boxer Henry Armstrong holds the longest title reign with 19 title defenses. Notable welterweight champions throughout history: Ted Lewis Jack Britton, Henry Armstrong, Fritzie Zivic, Sugar Ray Robinson, Emile Griffith, Sugar Ray Leonard, Tommy Hearns, Marlon Starling, Buddy McGirt, Pernell Whitaker, Felix Trinidad, Oscar De La Joya, Shane Mosley",
            });
            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Super Lightweight",
                WeightLimit = "140 lb / 63.5 kg / 10 st",
                Established = 1962,
                Description = "Also created first by the New York Walker Law in 1920, the NBA officially recognized the super lightweight division in 1922. In the same year, boxing magazine Boxing Blade held a contest for the best fighter in this division, with readers choosing Pinky Mitchell. He would then be crowned the light-welterweight champion and is considered to be the first official champion in the division.  The modern beginnings of the belt were in 1959 when the NBA sanctioned a fight between Carlos Ortiz and Kenny Lane for the vacant world light welterweight championship. The WBC and the NBA/WBA recognized the same champion up until 1967. The WBC then stripped Paul Fuji of their belt and crowned Pedro Adigue as their new champ, after his win against Adolph Pruitt. The IBF’s first junior welterweight champion was Aaron Pryor in 1984. The longest title reign is held by Mexican boxer Julio Cesar Chavez with 12 title defenses. Notable super lightweight champions throughout history: Tony Canzoneri, Barney Ross, Carlos Ortiz, Nicolino Locche, Aaron Pryor, Julio Cesar Chavez, Pernell Whitaker, Kosta Tszyu",
            });
            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Lightweight",
                WeightLimit = "135 lb / 61.23 kg / 9 st 9 lb",
                Established = 1738,
                Description = "The beginnings of the lightweight division can be traced back to 1738 when introduced by the father of English boxing, Jack Broughton. Any fighter weighing less than 160 lb / 72.57 was considered a lightweight. After that, it was modified by the ABA as ten stone in 1889. It was finally established at the present weight limit of 135 lb / 61.23 kg by the NSC in 1909. The world’s first lightweight champion could have been Englishman John Moneghan in 1850. The WBA was the first of the modern sanctioning bodies to give the belt to Carlos Ortiz after he beat Joe Brown in 1962. The WBC would sanction his contest against Doug Vaillant one year after as their inaugural world lightweight championship fight. The IBF followed suit with their own champion in 1984, with the WBO following in 1989. The longest title reign of the modern era is held by Panamanian boxer Roberto Duran with 12 title defenses, if you discount Artur Grigorian’s lightly regarded WBO run of 17. Notable lightweight champions throughout history: Jack McAuliffe, Benny Leonard, Joe Gans, Ike Williams, Carlos Ortiz, Roberto Duran, Hector Camacho, Artur Grigorian, Julio Cesar Chavez, Pernell Whitaker, Juan Manuel Marquez, Oscar De La Hoya, Shane Mosley, Manny Pacquiao, Floyd Mayweather Jr.",
            });
            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Super Featherweight",
                WeightLimit = "130 lb / 58.97 kg / 9 st 4 lb",
                Established = 1920,
                Description = "This division was initially created by the New York Walker Law in 1920. However, some records state that it first appeared in Europe around 1914. Johnny Dundee beat George Chaney at Madison Square Garden on 11th November 1921 to become the first junior lightweight champion. After disappearing and reappearing in the following decades, the modern version of the belt was officially introduced by the NBA on 20th July 1959. Harold Gomes defeated Paul Jorgensen for the vacant world super featherweight title. The WBC established its version of the belt in 1968, the IBF in 1984, and the WBO in 1989. South African boxer Brian Mitchell holds the longest title reign with 12 title defenses. Notable super featherweight champions throughout history: Flash Elorde, Alexis Arguello, Julio Cesar Chavez, Diego Corrales, Marco Antonio Barrera, Azumah Nelson, Erik Morales, Juan Manuel Marquez, Oscar De La Hoya, Manny Pacquiao, Floyd Mayweather Jr.",
            });
            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Featherweight",
                WeightLimit = "126 lb / 57.15 kg / 9 st",
                Established = 1860,
                Description = "The featherweight division originated in 1860 under the London Prize Ring Rules, with a set weight limit of 118 lb / 53.52 kg. The English ABA then established it at 126 lb / 57.15 kg, followed by a couple of more changes until the NSC officially modified it back in America to 126 lb. The first featherweight champion in the world is considered Irishman Ike Weir, who defeated Frank Murphy on 13th January 1890 to gain featherweight honors. The inaugural champion of the modern WBA and WBC belts was Sugar Ramos in 1963, who defeated Davey Moore for the crown. Davey Moore died two days after the fight, after suffering an in-ring injury. The longest title reign of the modern era is held by Panamanian boxer Eusebio Pedroza with 19 title defenses. Notable featherweight champions throughout history: George Dixon, Kid Chocolate, Willie Pep, Eusebio Pedroza, Salvador Sanchez, Jeff Fenech, Jorge Paez, Rafael Marquez, Steven Luevano, Naseem Hamed, Marco Antonio Barrera, Manny Pacquiao.",
            });
            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Super Bantamweight",
                WeightLimit = "122 lb / 55.34 kg / 8 st 10 lb",
                Established = 1920,
                Description = "Super Bantam was created in 1920 by the New York Walker Law at a weight limit of 122 lb / 55.34 kg. In 1922, Jack Wolfe beat Joe Lynch in what was billed as the first junior featherweight championship, though the NYSAC would not recognize this fight. An influential boxing organization would not fully establish the division until 1976. The WBC recognized Rigoberto Riazco as the world super bantamweight champion, after defeating Waruinge Nakayama in eight rounds. The WBA followed suit in recognition of this division in 1977, the IBF in 1983, and the WBO in 1989. Puerto Rican boxer Wilfredo Gomez holds the longest title reign with 18 title defenses. Notable super-bantamweight champions throughout history: Wilfredo Gomez, Jeff Fenech, Erik Morales, Marco Antonio Barrera, Fabrice Benichou, Daniel Zaragoza, Kennedy McKinney, Rafael Marquez, Toshiaki Nishioka, Israel Vazquez, Guillermo Rigondeaux, Manny Pacquiao.",
            });
            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Bantamweight",
                WeightLimit = "118 lb / 53.52 kg / 8 st 6 lb",
                Established = 1890,
                Description = "The division was first established by the ABA in the 1890s. It would subsequently appear under other rules, such as the London Prize Ring Rules and The Queensberry Rules, in which the weight limit fluctuated between 105 lb and 116 lb. The NSC officially sanctioned it in 1909 at the current limit of 118 lb / 53.52 kg. The first title fight at bantamweight could have been between Chappie Moran and Tommy Kelly in New Jersey 1988, when Tommy Kelly came out victorious in a 4 round points decision. Brazilian knockout artist Eder Jofre is considered the inaugural modern bantamweight champion. He would win the WBA and WBC versions of the belt in 1963 against Katsutoshi Aoki. The IBF and WBO followed suit with their own versions in 1984 and 1989, respectively. The longest title reign is held by American boxer Orlando Canizalez with 16 title defenses. Notable bantamweight champions throughout history: Tommy Kelly, Panama Al Brown, Orlando Canizalez, George Dixon, Sixto Escobar, Eder Jofre, Carlos Zarate, Ruben Olivares, Tim Austin, Rafael Marquez, Hozumi Hasegawa.",
            });
            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Super Flyweight",
                WeightLimit = "115 lb / 52.16 / 8 st 3 lb",
                Established = 1920,
                Description = "Super Fly, like many of the other divisions, is considered to be created in 1920 by the New York Walker Law. It was first named as junior bantamweight, at a weight limit of 115 lb / 52.16 kg. However, there are no records of any titles held in this division until 1980. In 1980 the WBC re-introduced the division and called it super flyweight. Rafael Orono would become the inaugural champion of the modern version of the title, after beating Seung-Hoon Lee in a 15-round split decision. The WBA presented their own version of the belt in 1981, the IBF two years later, and the WBO in 1989. The longest title reign is held by Thai boxer Khaosai Galaxy with 19 title defenses. Notable super flyweight champions throughout history: Ellyas Pical, Gilberto Roman, Jiro Watanabe, Mark Johnson, Johnny Tapua, Danny Romero, Khaosai Galaxy, Fernando Montiel, Roman Gonzalez.",
            });
            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Flyweight",
                WeightLimit = "112 lb / 50.8 kg / 8 st",
                Established = 1909,
                Description = "First established by the NSC in 1909, at a limit of 112 lb / 50.80 kg, it was also officially a part of the Walker Law set up in 1920. Subsequently, it was also recognized by the NBA and the NYSAC in 1927. In 1911 English boxer Sid Smith became the first champion in this division, with Jimmy Wilde, who won it in 1914, was also recognized in the United States. The first flyweight champion in modern times is Masahiko Harada, who won the crown by defeating Pone Kingpetch in 1962 for the WBA world flyweight title. The WBC introduced a flyweight version of their title one year after, with the IBF following suit in 1983 and the WBO like for most of their titles, in 1989. Thai boxer Pongsaklek Wongjongkam holds the longest title reign with 17 title defenses. Notable flyweight champions throughout history: Jimmy Wilde, Pancho Villa, Masahiko Karada, Miguel Canto, Charlie Magri, Gabriel Bernal, Hilaria Zapata, Mark Johnson, Yuri Darchinyan, Roman Gonzalez.",
            });
            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Light Flyweight",
                WeightLimit = "108 lb / 48.99 kg / 7 st 10 lb",
                Established = 1975,
                Description = "First established in 1920 by the New York Walker Law as 'junior flyweight', at a weight limit of 108 lb / 48.99 kg. The division would soon be abolished, with no champion being given the title during that time. In the modern era, it was re-introduced by the WBC in 1975 as light flyweight. The inaugural champion was Francisco Udella, after a DQ win against Valentin Martinez. Just four months after that fight, Jaime Rios defeated Rigoberto Marcano to become WBA’s first light flyweight world champion. The IBF followed in 1983 and the WBO in 1989. The longest title reign is held by South Korean boxer Myung Woo Yuh with 17 title defenses. Notable light flyweight champions throughout history: Yoko Gushiken, Jung-Koo Chang, Michael Carbajal, Humberto Gonzalez, Myung Woo Yuh.",
            });
            dbContext.WeightClasses.Add(new WeightClass
            {
                Division = "Minimumweight",
                WeightLimit = "105 lb / 47.7 kg / 7 st 7 lb",
                Established = 1968,
                Description = "The division was first introduced in 1968 at the Summer Olympics in Mexico as light flyweight, with a weight limit of 105 lb / 47.63 kg. However, in professional boxing, the division is relatively young. The first world minimum title fight was sanctioned by the IBF between Kyung-Yun Lee and Masaharu Kawakami in June 1987. Lee would win to become the first minimum weight champion of the world. The WBC held its first fight in the division in 1987, the WBA in 1988, and finally, the WBO in 1989. The longest title reign is held by Mexican boxer Ricardo Lopez with 21 title defenses. Notable minimumweight champions throughout history: Ricardo Lopez, Ivan Calderon, Chana Porpaoin.",
            });

            await dbContext.SaveChangesAsync();
        }
    }
}
