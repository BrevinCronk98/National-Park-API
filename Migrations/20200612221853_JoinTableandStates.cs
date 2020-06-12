using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParkAPI.Migrations
{
    public partial class JoinTableandStates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StateName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "StatePark",
                columns: table => new
                {
                    StateParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StateId = table.Column<int>(nullable: false),
                    ParkId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatePark", x => x.StateParkId);
                    table.ForeignKey(
                        name: "FK_StatePark_Parks_ParkId",
                        column: x => x.ParkId,
                        principalTable: "Parks",
                        principalColumn: "ParkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StatePark_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "ParkLocation",
                value: "California");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8,
                columns: new[] { "ParkDescription", "ParkFauna", "ParkLocation", "ParkName" },
                values: new object[] { " Big Bend National Park is an American national park located in West Texas, bordering Mexico. The park has national significance as the largest protected area of Chihuahuan Desert topography and ecology in the United States. The park protects more than 1,200 species of plants, more than 450 species of birds, 56 species of reptiles, and 75 species of mammals.Geological features in the park include sea fossils and dinosaur bones, as well as volcanic dikes. The area has a rich cultural history, from archeological sites dating back nearly 10,000 years to more recent pioneers, ranchers, and miners. The Chisos Mountains are located in the park, the only mountain range in the United States to be fully contained within the boundary of a national park.The park encompasses an area of 801,163 acres (1,251.8 sq mi; 3,242.2 km sq). For more than 1,000 miles (1,600 km), the Rio Grande/Río Bravo forms the boundary between Mexico and the United States, and Big Bend National Park administers approximately 118 miles (190 km) along that boundary. The park was named after a large bend in the river, and the Texas—Mexico border.Because the Rio Grande serves as an international boundary, the park faces unusual constraints while administering and enforcing park rules, regulations, and policies. In accordance with the Treaty of Guadalupe Hidalgo, the park's territory extends only to the center of the deepest river channel as the river flowed in 1848. The rest of the land south of that channel, and the river, lies within Mexican territory. The park is bordered by the protected areas of Parque Nacional Cañon de Santa Elena and Maderas del Carmen in Mexico.", " Javelina, Pronghorns, Kangaroo Rat, Coyote, Golden Eagle, Black Tailed Jack Rabbit, and a whole lot more! ", "Texas", "Big Bend" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10,
                columns: new[] { "ParkDescription", "ParkFauna", "ParkFlora", "ParkLocation", "ParkName" },
                values: new object[] { "Guadalupe Mountains National Park is an American national park in the Guadalupe Mountains, east of El Paso, Texas. The mountain range includes Guadalupe Peak, the highest point in Texas at 8,749 feet (2,667 m), and El Capitan used as a landmark by travelers on the route later followed by the Butterfield Overland Mail stagecoach line. The ruins of a stagecoach station stand near the Pine Springs visitor center. The restored Frijole Ranch contains a small museum of local history and is the trailhead for Smith Spring. The park covers 86,367 acres (134.9 sq mi; 349.5 km sq) in the same mountain range as Carlsbad Caverns National Park, about 25 miles (40 km) to the north in New Mexico. The Guadalupe Peak Trail winds through pinyon pine and Douglas-fir forests as it ascends over 3,000 feet (910 m) to the summit of Guadalupe Peak, with views of El Capitan and the Chihuahuan Desert.The McKittrick Canyon trail leads to a stone cabin built in the early 1930s as the vacation home of Wallace Pratt, a petroleum geologist who donated the land. Dog Canyon, on the northern park boundary at the Texas-New Mexico State line, is accessed via Carlsbad, New Mexico or Dell City, Texas. Camping is available at the Pine Springs campground and at Dog Canyon. A public corral for livestock is available by reservation.The Gypsum sand dunes lie on the west side of the park near Dell City. A rough four-wheel drive road leads to the Williams Ranch.", " Mule Deer, Road Runner, , Black Bear, Badger, Bob Cat, Coyote and many many more!! ", "Big Tooth Maple, Honey Mesquite, Madrone, Mexican Buckeye, Juniper, and lots more!! ", "Texas", "Guadalupe Mountains National Park" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "StateId", "StateName" },
                values: new object[,]
                {
                    { 27, "Nevada" },
                    { 28, "New Hampshire" },
                    { 29, "New Jersey" },
                    { 30, "New Mexico" },
                    { 31, "New York" },
                    { 32, "North Carolina" },
                    { 33, "North Dakota" },
                    { 34, "Ohio" },
                    { 35, "Oklahoma" },
                    { 36, "Oregon" },
                    { 37, "Pennsylvania" },
                    { 38, "Rhode Island" },
                    { 39, "South Carolina" },
                    { 40, "South Dakota" },
                    { 41, "Tennessee" },
                    { 42, "Texas" },
                    { 43, "Utah" },
                    { 44, "Vermont" },
                    { 45, "Virginia" },
                    { 46, "Washington" },
                    { 47, "West Virginia" },
                    { 48, "Wisconsin" },
                    { 26, "Nebraska" },
                    { 25, "Montana" },
                    { 24, "Missouri" },
                    { 23, "Mississippi" },
                    { 1, "Alabama" },
                    { 2, "Alaska" },
                    { 3, "Arizona" },
                    { 4, "Arkansas" },
                    { 5, "California" },
                    { 6, "Colorado" },
                    { 7, "Conneticut" },
                    { 8, "Delaware" },
                    { 9, "Florida" },
                    { 10, "Georgia" },
                    { 49, "Wyoming" },
                    { 11, "Hawaii" },
                    { 13, "Illinois" },
                    { 14, "Indiana" },
                    { 15, "Iowa" },
                    { 16, "Kentucky" },
                    { 17, "Louisiana" },
                    { 18, "Maine" },
                    { 19, "Maryland" },
                    { 20, "Massachusetts" },
                    { 21, "Michigan" },
                    { 22, "Minnesota" },
                    { 12, "Idaho" },
                    { 50, "Kansas" }
                });

            migrationBuilder.InsertData(
                table: "StatePark",
                columns: new[] { "StateParkId", "ParkId", "StateId" },
                values: new object[,]
                {
                    { 4, 4, 3 },
                    { 6, 6, 5 },
                    { 9, 9, 6 },
                    { 1, 1, 18 },
                    { 5, 5, 26 },
                    { 3, 3, 40 },
                    { 8, 8, 42 },
                    { 10, 10, 42 },
                    { 2, 2, 43 },
                    { 7, 7, 46 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StatePark_ParkId",
                table: "StatePark",
                column: "ParkId");

            migrationBuilder.CreateIndex(
                name: "IX_StatePark_StateId",
                table: "StatePark",
                column: "StateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatePark");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "ParkLocation",
                value: "Californ");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8,
                columns: new[] { "ParkDescription", "ParkFauna", "ParkLocation", "ParkName" },
                values: new object[] { " Acadia National Park is an American national park located in the state of Maine, southwest of Bar Harbor. The park preserves about half of Mount Desert Island, many adjacent smaller islands, and part of the Schoodic Peninsula on the coast of Maine. Acadia was initially designated Sieur de Monts National Monument by proclamation of President Woodrow Wilson in 1916. Sieur de Monts was renamed and redesignated Lafayette National Park by Congress in 1919—the first national park in the United States east of the Mississippi River and the only one in the Northeastern United States. The park was renamed Acadia National Park in 1929. More than 3.4 million people visited the park in 2019. ", " Carnivores: Black Bear, Coyote, Fox, Raccoon, River Otters and many many more!! ", "Maine", "Acadia" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10,
                columns: new[] { "ParkDescription", "ParkFauna", "ParkFlora", "ParkLocation", "ParkName" },
                values: new object[] { "Wrangell–St. Elias National Park and Preserve is an American national park and preserve managed by the National Park Service in south central Alaska. The park and preserve were established in 1980 by the Alaska National Interest Lands Conservation Act. The protected areas are included in an International Biosphere Reserve and are part of the Kluane/Wrangell–St. Elias/Glacier Bay/Tatshenshini-Alsek UNESCO World Heritage Site. The park and preserve form the largest area managed by the National Park Service with a total of 13,175,799 acres (20,587.186 sq mi; 53,320.57 km sq), an expanse that could encapsulate a total of six Yellowstone National Parks. The park includes a large portion of the Saint Elias Mountains, which include most of the highest peaks in the United States and Canada, yet are within 10 miles (16 km) of tidewater, one of the highest reliefs in the world. Wrangell–St. Elias borders on Canada's Kluane National Park and Reserve to the east and approaches another American national park to the south, Glacier Bay. The chief distinction between park and preserve lands is that sport hunting is prohibited in the park and permitted in the preserve. In addition, 9,078,675 acres (3,674,009 ha) of the park and preserve are designated as the largest single wilderness in the United States.Wrangell–St. Elias National Monument was designated on December 1, 1978, by President Jimmy Carter using the Antiquities Act, pending final legislation to resolve the allotment of public lands in Alaska. Establishment as a national park and preserve followed the passage of the Alaska National Interest Lands Conservation Act in 1980. The park has long, extremely cold winters and a short summer season. Plate tectonics are responsible for the uplift of the mountain ranges that cross the park. The park's extreme high point is Mount Saint Elias at 18,008 feet (5,489 m), the second tallest mountain in both the United States and Canada. The park has been shaped by the competing forces of volcanism and glaciation. Mount Wrangell is an active volcano, one of several volcanoes in the western Wrangell Mountains. In the St. Elias Range, Mount Churchill has erupted explosively within the past 2,000 years. The park's glacial features include Malaspina Glacier, the largest piedmont glacier in North America, Hubbard Glacier, the longest tidewater glacier in Alaska, and Nabesna Glacier, the world's longest valley glacier. The Bagley Icefield covers much of the park's interior, which includes 60% of the permanently ice-covered terrain in Alaska. At the center of the park, the boomtown of Kennecott exploited one of the world's richest deposits of copper from 1903 to 1938, exposed by and in part incorporated into Kennicott Glacier. The abandoned mine buildings and mills comprise a National Historic Landmark district. ", " Cougars, Wolfs, Moose, Beavers, Canadian Lynxe, Red Fox, Coyote and many many more!! ", "Black Spuce, Blueberry, Dwarf Birch, Arctagrostis Latifolia, and lots more!! ", "Alaska", "Wrangell-St. Elias National Park and Preserve" });
        }
    }
}
