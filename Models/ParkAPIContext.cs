using Microsoft.EntityFrameworkCore;

namespace NationalParkAPI.Models
{
    public class ParkAPIContext : DbContext
    {
        public ParkAPIContext(DbContextOptions<ParkAPIContext> options)
            : base(options)
            {
            }
            public DbSet<Park> Parks { get; set; }
            public DbSet<State> States { get; set; }
            
            public virtual DbSet<StatePark> StatePark { get; set; }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                builder.Entity<Park>()
                    .HasData(
                        new Park 
                        { 
                            ParkId = 1, 
                            ParkName = "Acadia National Park", 
                            ParkLocation = "Maine", 
                            ParkDescription = " Acadia National Park is an American national park located in the state of Maine, southwest of Bar Harbor. The park preserves about half of Mount Desert Island, many adjacent smaller islands, and part of the Schoodic Peninsula on the coast of Maine. Acadia was initially designated Sieur de Monts National Monument by proclamation of President Woodrow Wilson in 1916. Sieur de Monts was renamed and redesignated Lafayette National Park by Congress in 1919—the first national park in the United States east of the Mississippi River and the only one in the Northeastern United States. The park was renamed Acadia National Park in 1929. More than 3.4 million people visited the park in 2019. ", 
                            ParkFauna = " Black Bear, Coyote, Fox, Raccoon, River Otters and  many more!! ", 
                            ParkFlora = "Balsam Fir, Eastern Hemlock, Red Pine, White spruce, Canada Mayflower, and lots more!! "
                        },
                        
                        new Park 
                        { 
                            ParkId = 2, 
                            ParkName = "Zion National Park", 
                            ParkLocation = "Utah", 
                            ParkDescription = " Zion National Park is an American national park located in southwestern Utah near the town of Springdale. A prominent feature of the 229-square-mile (590 km sq) park is Zion Canyon, which is 15 miles (24 km) long and up to 2,640 ft (800 m) deep. The canyon walls are reddish and tan-colored Navajo Sandstone eroded by the North Fork of the Virgin River. The lowest point in the park is 3,666 ft (1,117 m) at Coalpits Wash and the highest peak is 8,726 ft (2,660 m) at Horse Ranch Mountain. Located at the junction of the Colorado Plateau, Great Basin, and Mojave Desert regions, the park has a unique geography and a variety of life zones that allow for unusual plant and animal diversity. Numerous plant species as well as 289 species of birds, 75 mammals (including 19 species of bat), and 32 reptiles inhabit the park's four life zones: desert, riparian, woodland, and coniferous forest. Zion National Park includes mountains, canyons, buttes, mesas, monoliths, rivers, slot canyons, and natural arches.", 
                            ParkFauna = " Golden Eagles, Red Tailed Hawks, Cougars, Bobcats, Collared Lizards and many more animals to see!", 
                            ParkFlora = "Boxelder, Fremont CottonWoord, Maple Tree, Willows, and lots more to see!! "
                        },
                        
                        new Park 
                        { 
                            ParkId = 3, 
                            ParkName = "BadLands National Park", 
                            ParkLocation = "South Dakota", 
                            ParkDescription = " Badlands National Park is an American national park located in southwestern South Dakota. The park protects 242,756 acres (379.3 sq mi; 982.4 km sq) of sharply eroded buttes and pinnacles, along with the largest undisturbed mixed grass prairie in the United States. The National Park Service manages the park, with the South Unit being co-managed with the Oglala Lakota tribe.The Badlands Wilderness protects 64,144 acres (100.2 sq mi; 259.6 km sq) of the park as a designated wilderness area, and is one site where the black-footed ferret, one of the most endangered mammals in the world, was reintroduced to the wild. The South Unit, or Stronghold District, includes sites of 1890s Ghost Dances, a former United States Air Force bomb and gunnery range, and Red Shirt Table, the park's highest point at 3,340 feet (1,020 m).Authorized as Badlands National Monument on March 4, 1929, it was not established until January 25, 1939. Badlands was redesignated a national park on November 10, 1978. Under the Mission 66 plan, the Ben Reifel Visitor Center was constructed for the monument in 1957–58. The park also administers the nearby Minuteman Missile National Historic Site. Movies such as Dances with Wolves (1990) and Thunderheart (1992) were partially filmed in Badlands National Park.", 
                            ParkFauna = " Prairie Dogs, Bighorn Sheep, Bison Bull and many  more!! ", 
                            ParkFlora = "White Milkwort, Praire Dropseed, Prairie Coneflower, and lots more!! "
                        },
                        
                        new Park 
                        { 
                            ParkId = 4, 
                            ParkName = "Grand Canyon National Park", 
                            ParkLocation = "Arizona", 
                            ParkDescription = " Grand Canyon National Park, located in northwestern Arizona, is the 15th site in the United States to have been named a national park. The park's central feature is the Grand Canyon, a gorge of the Colorado River, which is often considered one of the Wonders of the World. The park, which covers 1,217,262 acres (1,901.972 sq mi; 4,926.08 km sq) of unincorporated area in Coconino and Mohave counties, received more than six million recreational visitors in 2017, which is the second highest count of all American national parks after Great Smoky Mountains National Park. The Grand Canyon was designated a World Heritage Site by UNESCO in 1979. The park celebrated its 100th anniversary on February 26, 2019. ", 
                            ParkFauna = " Bison, Elk, Mountain Lion, Mule Deer, Ringtail and many more!! ", 
                            ParkFlora = "Seep Willow, Four-Wing Saltbush, Lupines, Douglas Fir, and lots more!! "
                        },
                        
                        new Park 
                        { 
                            ParkId = 5, 
                            ParkName = "Great Basin National Park", 
                            ParkLocation = "Nevada", 
                            ParkDescription = " Great Basin National Park is an American national park located in White Pine County in east-central Nevada, near the Utah border, established in 1986. The park is most commonly entered by way of Nevada State Route 488, which is connected to U.S. Routes 6 and 50 by Nevada State Route 487 via the small town of Baker, the closest settlement.The park derives its name from the Great Basin, the dry and mountainous region between the Sierra Nevada and the Wasatch Mountains. Topographically, this area is known as the Basin and Range Province. The park is located about 290 miles (470 km) north of Las Vegas and protects 77,180 acres (31,230 ha).The park is notable for its groves of ancient bristlecone pines, the oldest known nonclonal organisms, and for the Lehman Caves at the base of 13,063-foot (3,982 m) Wheeler Peak, as well as Wheeler Peak Glacier.President Warren G. Harding created Lehman Caves National Monument by presidential proclamation on January 24, 1922. The monument was redesignated a national park on October 27, 1986. A number of developed campsites are within the park, as well as excellent backcountry camping opportunities. The Highland Ridge Wilderness lies adjacent to Great Basin National Park. These two protected areas provide contiguous wildlife habitat and protection to 227.8 square miles (590.0 km sq) of eastern Nevada's basin lands ", 
                            ParkFauna = " Pronghorns, Coyotes, Kit Foxes, Badgers and Lot more!! ", 
                            ParkFlora = "Sagebrush, Bristlecone Pine, Saltbush, Utah Juniper and lots more!! "
                        },
                        
                        new Park 
                        { 
                            ParkId = 6, 
                            ParkName = "King Canyon National Park", 
                            ParkLocation = "Californ", 
                            ParkDescription = "Kings Canyon National Park is an American national park in the southern Sierra Nevada, in Fresno and Tulare Counties, California. Originally established in 1890 as General Grant National Park, the park was greatly expanded and renamed to Kings Canyon National Park on March 4, 1940. The park's namesake, Kings Canyon, is a rugged glacier-carved valley more than a mile (1,600 m) deep. Other natural features include multiple 14,000-foot (4,300 m) peaks, high mountain meadows, swift-flowing rivers, and some of the world's largest stands of giant sequoia trees. Kings Canyon is north of and contiguous with Sequoia National Park, and both parks are jointly administered by the National Park Service as the Sequoia and Kings Canyon National Parks. The majority of the 461,901-acre (186,925 ha) park, drained by the Middle and South Forks of the Kings River and many smaller streams, is designated wilderness. Tourist facilities are concentrated in two areas: Grant Grove, home to General Grant (the second largest tree in the world, measured by trunk volume) and Cedar Grove, located in the heart of Kings Canyon. Overnight hiking is required to access most of the park's backcountry, or high country, which for much of the year is covered in deep snow. The combined Pacific Crest Trail/John Muir Trail, a backpacking route, traverses the entire length of the park from north to south. General Grant National Park was initially created to protect a small area of giant sequoias from logging. Although John Muir's visits brought public attention to the huge wilderness area to the east, it took more than fifty years for the rest of Kings Canyon to be designated a national park. Environmental groups, park visitors and many local politicians wanted to see the area preserved; however, development interests wanted to build hydroelectric dams in the canyon. Even after President Franklin D. Roosevelt expanded the park in 1940, the fight continued until 1965, when the Cedar Grove and Tehipite Valley dam sites were finally annexed into the park.  As visitation rose post–World War II, further debate took place over whether the park should be developed as a tourist resort, or retained as a more natural environment restricted to simpler recreation such as hiking and camping. Ultimately, the preservation lobby prevailed and today, the park has only limited services and lodgings despite its size. Due to this and the lack of road access to most of the park, Kings Canyon remains the least visited of the major Sierra parks, with just under 700,000 visitors in 2017compared to 1.3 million visitors at Sequoia and over 4 million at Yosemite.", 
                            ParkFauna = "Black Bear, Grizzly Bear, Bighorns, Mountain Lions and many many more!! ", 
                            ParkFlora = "Whitebark Pine, Red Fir, Lodgepole Pine, Foxtail Pine, and lots more!! "
                        },
                        
                        new Park 
                        { 
                            ParkId = 7, 
                            ParkName = "Olympic National Forest", 
                            ParkLocation = "Washington", 
                            ParkDescription = " Olympic National Park is an American national park located in the State of Washington, on the Olympic Peninsula. The park has four regions: the Pacific coastline, alpine areas, the west side temperate rainforest and the forests of the drier east side. Within the park there are three distinct ecosystems which are subalpine forest and wildflower meadow, temperate forest, and the rugged Pacific coast. President Theodore Roosevelt originally designated Mount Olympus National Monument on 2 March 1909.The monument was redesignated as a national park by Congress and President Franklin Roosevelt on June 29, 1938. In 1976, Olympic National Park was designated by UNESCO as an International Biosphere Reserve, and in 1981 as a World Heritage Site. In 1988, Congress designated 95 percent of the park as the Olympic Wilderness. ", 
                            ParkFauna = " Shrews, Squirrels, Bald Eagle, Red Crossbill, Black Bear, and many many more!! ", 
                            ParkFlora = "Sitka Spruce, Douglas Fir, Black Cottonwood, Huckleberry, Salmonberry, Lungwort, and lots more!! "
                        },
                        
                        new Park 
                        { 
                            ParkId = 8, 
                            ParkName = "Acadia", 
                            ParkLocation = "Maine", 
                            ParkDescription = " Acadia National Park is an American national park located in the state of Maine, southwest of Bar Harbor. The park preserves about half of Mount Desert Island, many adjacent smaller islands, and part of the Schoodic Peninsula on the coast of Maine. Acadia was initially designated Sieur de Monts National Monument by proclamation of President Woodrow Wilson in 1916. Sieur de Monts was renamed and redesignated Lafayette National Park by Congress in 1919—the first national park in the United States east of the Mississippi River and the only one in the Northeastern United States. The park was renamed Acadia National Park in 1929. More than 3.4 million people visited the park in 2019. ", 
                            ParkFauna = " Carnivores: Black Bear, Coyote, Fox, Raccoon, River Otters and many many more!! ", 
                            ParkFlora = "Balsam Fir, Eastern Hemlock, Red Pine, White spruce, Canada Mayflower, and lots more!! "
                        },
                        
                        new Park 
                        { 
                            ParkId = 9, 
                            ParkName = "Rocky Mountain National Park", 
                            ParkLocation = "Colorado", 
                            ParkDescription = " Rocky Mountain National Park is an American national park located approximately 76 mi (122 km) northwest of Denver International Airport in north-central Colorado, within the Front Range of the Rocky Mountains. The park is situated between the towns of Estes Park to the east and Grand Lake to the west. The eastern and western slopes of the Continental Divide run directly through the center of the park with the headwaters of the Colorado River located in the park's northwestern region. The main features of the park include mountains, alpine lakes and a wide variety of wildlife within various climates and environments, from wooded forests to mountain tundra. The Rocky Mountain National Park Act was signed by President Woodrow Wilson on January 26, 1915, establishing the park boundaries and protecting the area for future generations.The Civilian Conservation Corps built the main automobile route, Trail Ridge Road, in the 1930s. In 1976, UNESCO designated the park as one of the first World Biosphere Reserves. In 2018, more than 4.5 million recreational visitors entered the park. The park is one of the most visited in the National Park System, ranking as the third most visited national park in 2015. In 2019, the park saw record attendance yet again with 4,678,804 visitors, a 44% increase since 2012. The park has a total of five visitor centers with park headquarters located at the Beaver Meadows Visitor Center—a National Historic Landmark designed by the Frank Lloyd Wright School of Architecture at Taliesin West. National Forest lands surround the park including Roosevelt National Forest to the north and east, Routt National Forest to the north and west, and Arapaho National Forest to the west and south, with the Indian Peaks Wilderness area located directly south of the park.", 
                            ParkFauna = "Wolverines, Wolf, American Bison, Elk, Grizzly Bear and many many more!! ", 
                            ParkFlora = "Coniferious Forests, Ponderosa Pine, Apline Meadows, Douglas Fir, Arkansas Rose, Bindweed, Appache Plumes, , and lots more!! "
                        },
                        
                        new Park 
                        { 
                            ParkId = 10, 
                            ParkName = "Wrangell-St. Elias National Park and Preserve", 
                            ParkLocation = "Alaska", 
                            ParkDescription = "Wrangell–St. Elias National Park and Preserve is an American national park and preserve managed by the National Park Service in south central Alaska. The park and preserve were established in 1980 by the Alaska National Interest Lands Conservation Act. The protected areas are included in an International Biosphere Reserve and are part of the Kluane/Wrangell–St. Elias/Glacier Bay/Tatshenshini-Alsek UNESCO World Heritage Site. The park and preserve form the largest area managed by the National Park Service with a total of 13,175,799 acres (20,587.186 sq mi; 53,320.57 km sq), an expanse that could encapsulate a total of six Yellowstone National Parks. The park includes a large portion of the Saint Elias Mountains, which include most of the highest peaks in the United States and Canada, yet are within 10 miles (16 km) of tidewater, one of the highest reliefs in the world. Wrangell–St. Elias borders on Canada's Kluane National Park and Reserve to the east and approaches another American national park to the south, Glacier Bay. The chief distinction between park and preserve lands is that sport hunting is prohibited in the park and permitted in the preserve. In addition, 9,078,675 acres (3,674,009 ha) of the park and preserve are designated as the largest single wilderness in the United States.Wrangell–St. Elias National Monument was designated on December 1, 1978, by President Jimmy Carter using the Antiquities Act, pending final legislation to resolve the allotment of public lands in Alaska. Establishment as a national park and preserve followed the passage of the Alaska National Interest Lands Conservation Act in 1980. The park has long, extremely cold winters and a short summer season. Plate tectonics are responsible for the uplift of the mountain ranges that cross the park. The park's extreme high point is Mount Saint Elias at 18,008 feet (5,489 m), the second tallest mountain in both the United States and Canada. The park has been shaped by the competing forces of volcanism and glaciation. Mount Wrangell is an active volcano, one of several volcanoes in the western Wrangell Mountains. In the St. Elias Range, Mount Churchill has erupted explosively within the past 2,000 years. The park's glacial features include Malaspina Glacier, the largest piedmont glacier in North America, Hubbard Glacier, the longest tidewater glacier in Alaska, and Nabesna Glacier, the world's longest valley glacier. The Bagley Icefield covers much of the park's interior, which includes 60% of the permanently ice-covered terrain in Alaska. At the center of the park, the boomtown of Kennecott exploited one of the world's richest deposits of copper from 1903 to 1938, exposed by and in part incorporated into Kennicott Glacier. The abandoned mine buildings and mills comprise a National Historic Landmark district. ", 
                            ParkFauna = " Cougars, Wolfs, Moose, Beavers, Canadian Lynxe, Red Fox, Coyote and many many more!! ", 
                            ParkFlora = "Black Spuce, Blueberry, Dwarf Birch, Arctagrostis Latifolia, and lots more!! "
                        }

                    );

                    builder.Entity<State>()
                        .HasData(

                            new State
                            {
                                StateId = 1,
                                StateName = "Alabama"
                            },
                            new State
                            {
                                StateId = 2,
                                StateName = "Alaska"
                            },
                            new State
                            {
                                StateId = 3,
                                StateName = "Arizona"
                            },
                            new State
                            {
                                StateId = 4,
                                StateName = "Arkansas"
                            },
                            new State
                            {
                                StateId = 5,
                                StateName = "California"
                            },
                            new State
                            {
                                StateId = 6,
                                StateName = "Colorado"
                            },
                            new State
                            {
                                StateId = 7,
                                StateName = "Conneticut"
                            },
                            new State
                            {
                                StateId = 8,
                                StateName = "Delaware"
                            },
                            new State
                            {
                                StateId = 9,
                                StateName = "Florida"
                            },
                            new State
                            {
                                StateId = 10,
                                StateName = "Georgia"
                            },
                            new State
                            {
                                StateId = 11,
                                StateName = "Hawaii"
                            },
                            new State
                            {
                                StateId = 12,
                                StateName = "Idaho"
                            },
                            new State
                            {
                                StateId = 13,
                                StateName = "Illinois"
                            },
                            new State
                            {
                                StateId = 14,
                                StateName = "Indiana"
                            },
                            new State
                            {
                                StateId = 15,
                                StateName = "Iowa"
                            },
                            new State
                            {
                                StateId = 16,
                                StateName = "Kentucky"
                            },
                            new State
                            {
                                StateId = 17,
                                StateName = "Louisiana"
                            },
                            new State
                            {
                                StateId = 18,
                                StateName = "Maine"
                            },
                            new State
                            {
                                StateId = 19,
                                StateName = "Maryland"
                            },
                            new State
                            {
                                StateId = 20,
                                StateName = "Massachusetts"
                            },
                            new State
                            {
                                StateId = 21,
                                StateName = "Michigan"
                            },
                            new State
                            {
                                StateId = 22,
                                StateName = "Minnesota"
                            },
                            new State
                            {
                                StateId = 23,
                                StateName = "Mississippi"
                            },
                            new State
                            {
                                StateId = 24,
                                StateName = "Missouri"
                            },
                            new State
                            {
                                StateId = 25,
                                StateName = "Montana"
                            },
                            new State
                            {
                                StateId = 26,
                                StateName = "Nebraska"
                            },
                            new State
                            {
                                StateId = 27,
                                StateName = "Nevada"
                            },
                            new State
                            {
                                StateId = 28,
                                StateName = "New Hampshire"
                            },
                            new State
                            {
                                StateId = 29,
                                StateName = "New Jersey"
                            },
                            new State
                            {
                                StateId = 30,
                                StateName = "New Mexico"
                            },
                            new State
                            {
                                StateId = 31,
                                StateName = "New York"
                            },
                            new State
                            {
                                StateId = 32,
                                StateName = "North Carolina"
                            },
                            new State
                            {
                                StateId = 33,
                                StateName = "North Dakota"
                            },
                            new State
                            {
                                StateId = 34,
                                StateName = "Ohio"
                            },
                            new State
                            {
                                StateId = 35,
                                StateName = "Oklahoma"
                            },
                            new State
                            {
                                StateId = 36,
                                StateName = "Oregon"
                            },
                            new State
                            {
                                StateId = 37,
                                StateName = "Pennsylvania"
                            },
                            new State
                            {
                                StateId = 38,
                                StateName = "Rhode Island"
                            },
                            new State
                            {
                                StateId = 39,
                                StateName = "South Carolina"
                            },
                            new State
                            {
                                StateId = 40,
                                StateName = "South Dakota"
                            },
                            new State
                            {
                                StateId = 41,
                                StateName = "Tennessee"
                            },
                            new State
                            {
                                StateId = 42,
                                StateName = "Texas"
                            },
                            new State
                            {
                                StateId = 43,
                                StateName = "Utah"
                            },
                            new State
                            {
                                StateId = 44,
                                StateName = "Vermont"
                            },
                            new State
                            {
                                StateId = 45,
                                StateName = "Virginia"
                            },
                            new State
                            {
                                StateId = 46,
                                StateName = "Washington"
                            },
                            new State
                            {
                                StateId = 47,
                                StateName = "West Virginia"
                            },
                            new State
                            {
                                StateId = 48,
                                StateName = "Wisconsin"
                            },
                            new State
                            {
                                StateId = 49,
                                StateName = "Wyoming"
                            },
                             new State
                            {
                                StateId = 50,
                                StateName = "Kansas"
                            }
                        );
            }
    }
}