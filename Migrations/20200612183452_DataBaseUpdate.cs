using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParkAPI.Migrations
{
    public partial class DataBaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                column: "ParkDescription",
                value: " Badlands National Park is an American national park located in southwestern South Dakota. The park protects 242,756 acres (379.3 sq mi; 982.4 km sq) of sharply eroded buttes and pinnacles, along with the largest undisturbed mixed grass prairie in the United States. The National Park Service manages the park, with the South Unit being co-managed with the Oglala Lakota tribe.The Badlands Wilderness protects 64,144 acres (100.2 sq mi; 259.6 km sq) of the park as a designated wilderness area, and is one site where the black-footed ferret, one of the most endangered mammals in the world, was reintroduced to the wild. The South Unit, or Stronghold District, includes sites of 1890s Ghost Dances, a former United States Air Force bomb and gunnery range, and Red Shirt Table, the park's highest point at 3,340 feet (1,020 m).Authorized as Badlands National Monument on March 4, 1929, it was not established until January 25, 1939. Badlands was redesignated a national park on November 10, 1978. Under the Mission 66 plan, the Ben Reifel Visitor Center was constructed for the monument in 1957–58. The park also administers the nearby Minuteman Missile National Historic Site. Movies such as Dances with Wolves (1990) and Thunderheart (1992) were partially filmed in Badlands National Park.");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                column: "ParkDescription",
                value: " Grand Canyon National Park, located in northwestern Arizona, is the 15th site in the United States to have been named a national park. The park's central feature is the Grand Canyon, a gorge of the Colorado River, which is often considered one of the Wonders of the World. The park, which covers 1,217,262 acres (1,901.972 sq mi; 4,926.08 km sq) of unincorporated area in Coconino and Mohave counties, received more than six million recreational visitors in 2017, which is the second highest count of all American national parks after Great Smoky Mountains National Park. The Grand Canyon was designated a World Heritage Site by UNESCO in 1979. The park celebrated its 100th anniversary on February 26, 2019. ");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "ParkDescription",
                value: "Kings Canyon National Park is an American national park in the southern Sierra Nevada, in Fresno and Tulare Counties, California. Originally established in 1890 as General Grant National Park, the park was greatly expanded and renamed to Kings Canyon National Park on March 4, 1940. The park's namesake, Kings Canyon, is a rugged glacier-carved valley more than a mile (1,600 m) deep. Other natural features include multiple 14,000-foot (4,300 m) peaks, high mountain meadows, swift-flowing rivers, and some of the world's largest stands of giant sequoia trees. Kings Canyon is north of and contiguous with Sequoia National Park, and both parks are jointly administered by the National Park Service as the Sequoia and Kings Canyon National Parks. The majority of the 461,901-acre (186,925 ha) park, drained by the Middle and South Forks of the Kings River and many smaller streams, is designated wilderness. Tourist facilities are concentrated in two areas: Grant Grove, home to General Grant (the second largest tree in the world, measured by trunk volume) and Cedar Grove, located in the heart of Kings Canyon. Overnight hiking is required to access most of the park's backcountry, or high country, which for much of the year is covered in deep snow. The combined Pacific Crest Trail/John Muir Trail, a backpacking route, traverses the entire length of the park from north to south. General Grant National Park was initially created to protect a small area of giant sequoias from logging. Although John Muir's visits brought public attention to the huge wilderness area to the east, it took more than fifty years for the rest of Kings Canyon to be designated a national park. Environmental groups, park visitors and many local politicians wanted to see the area preserved; however, development interests wanted to build hydroelectric dams in the canyon. Even after President Franklin D. Roosevelt expanded the park in 1940, the fight continued until 1965, when the Cedar Grove and Tehipite Valley dam sites were finally annexed into the park.  As visitation rose post–World War II, further debate took place over whether the park should be developed as a tourist resort, or retained as a more natural environment restricted to simpler recreation such as hiking and camping. Ultimately, the preservation lobby prevailed and today, the park has only limited services and lodgings despite its size. Due to this and the lack of road access to most of the park, Kings Canyon remains the least visited of the major Sierra parks, with just under 700,000 visitors in 2017compared to 1.3 million visitors at Sequoia and over 4 million at Yosemite.");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7,
                column: "ParkDescription",
                value: " Olympic National Park is an American national park located in the State of Washington, on the Olympic Peninsula. The park has four regions: the Pacific coastline, alpine areas, the west side temperate rainforest and the forests of the drier east side. Within the park there are three distinct ecosystems which are subalpine forest and wildflower meadow, temperate forest, and the rugged Pacific coast. President Theodore Roosevelt originally designated Mount Olympus National Monument on 2 March 1909.The monument was redesignated as a national park by Congress and President Franklin Roosevelt on June 29, 1938. In 1976, Olympic National Park was designated by UNESCO as an International Biosphere Reserve, and in 1981 as a World Heritage Site. In 1988, Congress designated 95 percent of the park as the Olympic Wilderness. ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                column: "ParkDescription",
                value: " Badlands National Park (Lakota: Makȟóšiča[3]) is an American national park located in southwestern South Dakota. The park protects 242,756 acres (379.3 sq mi; 982.4 km sq) of sharply eroded buttes and pinnacles, along with the largest undisturbed mixed grass prairie in the United States. The National Park Service manages the park, with the South Unit being co-managed with the Oglala Lakota tribe.The Badlands Wilderness protects 64,144 acres (100.2 sq mi; 259.6 km sq) of the park as a designated wilderness area, and is one site where the black-footed ferret, one of the most endangered mammals in the world, was reintroduced to the wild. The South Unit, or Stronghold District, includes sites of 1890s Ghost Dances, a former United States Air Force bomb and gunnery range, and Red Shirt Table, the park's highest point at 3,340 feet (1,020 m).Authorized as Badlands National Monument on March 4, 1929, it was not established until January 25, 1939. Badlands was redesignated a national park on November 10, 1978. Under the Mission 66 plan, the Ben Reifel Visitor Center was constructed for the monument in 1957–58. The park also administers the nearby Minuteman Missile National Historic Site. Movies such as Dances with Wolves (1990) and Thunderheart (1992) were partially filmed in Badlands National Park.");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                column: "ParkDescription",
                value: " Grand Canyon National Park, located in northwestern Arizona, is the 15th site in the United States to have been named a national park. The park's central feature is the Grand Canyon, a gorge of the Colorado River, which is often considered one of the Wonders of the World. The park, which covers 1,217,262 acres (1,901.972 sq mi; 4,926.08 km sq) of unincorporated area in Coconino and Mohave counties, received more than six million recreational visitors in 2017, which is the second highest count of all American national parks after Great Smoky Mountains National Park.[4] The Grand Canyon was designated a World Heritage Site by UNESCO in 1979. The park celebrated its 100th anniversary on February 26, 2019. ");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "ParkDescription",
                value: "Kings Canyon National Park is an American national park in the southern Sierra Nevada, in Fresno and Tulare Counties, California. Originally established in 1890 as General Grant National Park, the park was greatly expanded and renamed to Kings Canyon National Park on March 4, 1940. The park's namesake, Kings Canyon, is a rugged glacier-carved valley more than a mile (1,600 m) deep. Other natural features include multiple 14,000-foot (4,300 m) peaks, high mountain meadows, swift-flowing rivers, and some of the world's largest stands of giant sequoia trees. Kings Canyon is north of and contiguous with Sequoia National Park, and both parks are jointly administered by the National Park Service as the Sequoia and Kings Canyon National Parks. The majority of the 461,901-acre (186,925 ha) park, drained by the Middle and South Forks of the Kings River and many smaller streams, is designated wilderness. Tourist facilities are concentrated in two areas: Grant Grove, home to General Grant (the second largest tree in the world, measured by trunk volume) and Cedar Grove, located in the heart of Kings Canyon. Overnight hiking is required to access most of the park's backcountry, or high country, which for much of the year is covered in deep snow. The combined Pacific Crest Trail/John Muir Trail, a backpacking route, traverses the entire length of the park from north to south. General Grant National Park was initially created to protect a small area of giant sequoias from logging. Although John Muir's visits brought public attention to the huge wilderness area to the east, it took more than fifty years for the rest of Kings Canyon to be designated a national park. Environmental groups, park visitors and many local politicians wanted to see the area preserved; however, development interests wanted to build hydroelectric dams in the canyon. Even after President Franklin D. Roosevelt expanded the park in 1940, the fight continued until 1965, when the Cedar Grove and Tehipite Valley dam sites were finally annexed into the park.  As visitation rose post–World War II, further debate took place over whether the park should be developed as a tourist resort, or retained as a more natural environment restricted to simpler recreation such as hiking and camping. Ultimately, the preservation lobby prevailed and today, the park has only limited services and lodgings despite its size. Due to this and the lack of road access to most of the park, Kings Canyon remains the least visited of the major Sierra parks, with just under 700,000 visitors in 2017[3] compared to 1.3 million visitors at Sequoia[4] and over 4 million at Yosemite.");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7,
                column: "ParkDescription",
                value: " Olympic National Park is an American national park located in the State of Washington, on the Olympic Peninsula. The park has four regions: the Pacific coastline, alpine areas, the west side temperate rainforest and the forests of the drier east side. Within the park there are three distinct ecosystems which are subalpine forest and wildflower meadow, temperate forest, and the rugged Pacific coast. President Theodore Roosevelt originally designated Mount Olympus National Monument on 2 March 1909.[6][7] The monument was redesignated as a national park by Congress and President Franklin Roosevelt on June 29, 1938. In 1976, Olympic National Park was designated by UNESCO as an International Biosphere Reserve, and in 1981 as a World Heritage Site. In 1988, Congress designated 95 percent of the park as the Olympic Wilderness. ");
        }
    }
}
