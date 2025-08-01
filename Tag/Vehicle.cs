
namespace DimensionsTagUtility
{
    /// <summary>
    /// Vehicle class for Lego Dimensions.
    /// </summary>
    public class Vehicle : ILegoTag
    {
        /// <summary>
        /// The ID of the vehicle.
        /// </summary>
        public ushort Id { get; set; }

        /// <summary>
        /// Form order of vehicle.
        /// </summary>
        public int Form { get; set; }

        /// <summary>
        /// The name of the vehicle.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The world the vehicle is from.
        /// </summary>
        public string World { get; set; }

        /// <summary>
        /// Gets or sets the icon of the vehicle.
        /// </summary>
        public string Images { get; set; }

        /// <summary>
        /// Gets or sets the list of abilities of the vehicle.
        /// </summary>
        public List<string> Abilities { get; set; }

        /// <summary>
        /// Gets the vehicle rebuild.
        /// </summary>
        public VehicleRebuild Rebuild
        {
            get
            {
                var id = Id - 1000;
                if (id < 155)
                {
                    return (VehicleRebuild)(id % 3);
                }

                return (VehicleRebuild)((id + 1) % 3);
            }
        }

        /// <summary>
        /// The vehicle's constructor.
        /// </summary>
        /// <param name="id">The ID of the vehicle.</param>
        /// <param name="form">The form order of the vehicles.</param>
        /// <param name="name">The name of the vehicle.</param>
        /// <param name="world">The world the vehicle is from.</param>
        /// <param name="images">The image icon for the vehicle.</param>
        /// <param name="abilities">List of abilities.</param>
        public Vehicle(ushort id, int form, string name, string world, string images, List<string> abilities)
        {
            Id = id;
            Form = form;
            Name = name;
            World = world;
            Images = images;
            Abilities = abilities;
        }

        /// <summary>
        /// The list of all knowns vehicles.
        /// </summary>
        public static readonly List<Vehicle> Vehicles = [
//            new Vehicle(0000, "Empty Vehicle Tag"         , "Unknown"                                  , new List<string>() { "" }),

            new Vehicle(1000, 1, "Police Car"                  , "The Lego Movie"                           , "police_car.png"        , ["Accelerator Switches","Tow Bar"]),
            new Vehicle(1001, 2, "Aerial Squad Car"            , "The Lego Movie"                           , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Accelerator Switches","Tow Bar"]),
            new Vehicle(1002, 3, "Missile Striker"             , "The Lego Movie"                           , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Silver LEGO Blowup","Accelerator Switches","Tow Bar"]),

            new Vehicle(1003, 1, "Gravity Sprinter"            , "The Simpsons"                             , "gravity_sprinter.png"  , ["Accelerator Switches"]),
            new Vehicle(1004, 2, "Street Shredder"             , "The Simpsons"                             , ""                      , ["Accelerator Switches","Speed Boost","Tow Bar"]),
            new Vehicle(1005, 3,"Sky Clobberer"               , "The Simpsons"                             , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Special Attack","Accelerator Switches","Speed Boost","Tow Bar"]),

            new Vehicle(1006, 1, "Batmobile"                   , "DC Comics"                                , "batmobile.png"         , ["Accelerator Switches"]),
            new Vehicle(1007, 2, "Batblaster"                  , "DC Comics"                                , ""                      , ["Accelerator Switches","Sonar Smash","Tow Bar"]),
            new Vehicle(1008, 3, "Sonic Batray"                , "DC Comics"                                , ""                      , ["Accelerator Switches","Special Attack","Sonar Smash","Tow Bar"]),

            new Vehicle(1009, 1, "Benny's Spaceship"           , "The Lego Movie"                           , "bennys_spaceship.png"  , ["Flying","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1010, 2, "Lasercraft"                  , "The Lego Movie"                           , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Gold LEGO Blowup"]),
            new Vehicle(1011, 3, "The Annihilator"             , "The Lego Movie"                           , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Silver LEGO Blowup","Gold LEGO Blowup"]),

            new Vehicle(1012, 1, "DeLorean Time Machine"       , "Back to the Future"                       , "delorean.png"          , ["Accelerator Switches","Time Travel"]),
            new Vehicle(1013, 2, "Ultra Time Machine"          , "Back to the Future"                       , ""                      , ["Special Attack","Electricity","Tow Bar","Accelerator Switches","Time Travel"]),
            new Vehicle(1014, 3, "Electric Time Machine"       , "Back to the Future"                       , ""                      , ["Silver LEGO Blowup","Flying","Flight Docks and Flight Cargo Hooks","Time Travel","Special Attack","Electricity","Tow Bar"]),

            new Vehicle(1015, 1, "Hoverboard"                  , "Back to the Future"                       , "hoverboard.png"        , ["Hover"]),
            new Vehicle(1016, 2, "Cyclone Board"               , "Back to the Future"                       , ""                      , ["Special Attack","Hover"]),
            new Vehicle(1017, 3, "Ultimate Hoverjet"           , "Back to the Future"                       , ""                      , ["Flying","Special Attack","Silver LEGO Blowup","Hover"]),

            new Vehicle(1018, 1, "Eagle Interceptor"           , "Lego Legends of Chima"                    , "eagle_interceptor.png" , ["Flying","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1019, 2, "Eagle Skyblazer"             , "Lego Legends of Chima"                    , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Speed Boost","Silver LEGO Blowup"]),
            new Vehicle(1020, 3, "Eagle Swoop Diver"           , "Lego Legends of Chima"                    , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Special Attack","Gold LEGO Blowup","Speed Boost","Silver LEGO Blowup"]),

            new Vehicle(1021, 1, "Swamp Skimmer"               , "Lego Legends of Chima"                    , "swamp_skimmer.png"     , ["Sail"]),
            new Vehicle(1022, 2, "Croc Command Sub"            , "Lego Legends of Chima"                    , ""                      , ["Sail","Speed Boost","Special Attack"]),
            new Vehicle(1023, 3, "Cragger's Fireship"          , "Lego Legends of Chima"                    , ""                      , ["Dive","Silver LEGO Blowup","Sail","Speed Boost","Special Attack"]),

            new Vehicle(1024, 1, "Cyber Guard"                 , "DC Comics"                                , "cyber_gaurd.png"       , ["Mech Walker"]),
            new Vehicle(1025, 2, "Cyber-Wrecker"               , "DC Comics"                                , ""                      , ["Mech Walker","Super Strength","Dig"]),
            new Vehicle(1026, 3, "Laser Robot Walker"          , "DC Comics"                                , ""                      , ["Gold LEGO Blowup","Mech Walker","Super Strength","Dig"]),

            new Vehicle(1027, 1, "K9"                          , "Doctor Who"                               , "k_nine.png"            , ["Silver LEGO Blowup"]),
            new Vehicle(1028, 2, "K9 Ruff Rover"               , "Doctor Who"                               , ""                      , ["Sonar Smash","Silver LEGO Blowup"]),
            new Vehicle(1029, 3, "K9 Laser Cutter"             , "Doctor Who"                               , ""                      , ["Gold LEGO Blowup","Sonar Smash","Silver LEGO Blowup"]),

            new Vehicle(1030, 1, "TARDIS"                      , "Doctor Who"                               , "tardis.png"            , ["TARDIS Travel","Stealth","Flying","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1031, 2, "Laser-Pulse TARDIS"          , "Doctor Who"                               , ""                      , ["TARDIS Travel","Stealth","Flying","Gold LEGO Blowup"]),
            new Vehicle(1032, 3, "Energy-Burst TARDIS"         , "Doctor Who"                               , ""                      , ["TARDIS Travel","Stealth","Flying","Flight Docks and Flight Cargo Hooks","Gold LEGO Blowup"]),

            new Vehicle(1033, 1, "Emmet's Excavator"           , "The Lego Movie"                           , "emmets_excavator.png"  , ["Accelerator Switches","Dig"]),
            new Vehicle(1034, 2, "The Destroydozer"            , "The Lego Movie"                           , ""                      , ["Accelerator Switches","Dig","Tow Bar"]),
            new Vehicle(1035, 3, "Destruct-o-Mech"             , "The Lego Movie"                           , ""                      , ["Mech Walker","Super Strength","Accelerator Switches","Dig","Tow Bar"]),

            new Vehicle(1036, 1, "Winged Monkey"               , "Wizard of Oz"                             , "winged_monkey.png"     , [""]),
            new Vehicle(1037, 2, "Battle Monkey"               , "Wizard of Oz"                             , ""                      , ["Special Attack","Silver LEGO Blowup","Flying"]),
            new Vehicle(1038, 3, "Commander Monkey"            , "Wizard of Oz"                             , ""                      , ["Flying","Special Weapon","Sonar Smash","Special Attack","Silver LEGO Blowup"]),

            new Vehicle(1039, 1, "Axe Chariot"                 , "Lord of the Rings"                        , "axe_chariot.png"       , ["Accelerator Switches","Tow Bar"]),
            new Vehicle(1040, 2, "Axe Hurler"                  , "Lord of the Rings"                        , ""                      , ["Accelerator Switches","Special Attack","Tow Bar"]),
            new Vehicle(1041, 3, "Soaring Chariot"             , "Lord of the Rings"                        , ""                      , ["Accelerator Switches","Flying","Flight Docks and Flight Cargo Hooks","Tow Bar","Special Attack"]),

            new Vehicle(1042, 1, "Shelob the Great"            , "Lord of the Rings"                        , "shelob_the_great.png"  , ["Dig"]),
            new Vehicle(1043, 2, "8-Legged Stalker"            , "Lord of the Rings"                        , ""                      , ["Super Strength","Special Attack","Dig"]),
            new Vehicle(1044, 3, "Poison Slinger"              , "Lord of the Rings"                        , ""                      , ["Special Attack","Dig","Super Strength"]),

            new Vehicle(1045, 1, "Homer's Car"                 , "The Simpsons"                             , "homers_car.png"        , ["Accelerator Switches","Tow Bar"]),
            new Vehicle(1046, 2, "The SubmaHomer"              , "The Simpsons"                             , ""                      , ["Dive","Silver LEGO Blowup","Accelerator Switches","Tow Bar"]),
            new Vehicle(1047, 3, "The Homecraft"               , "The Simpsons"                             , ""                      , ["Sail","Dive","Silver LEGO Blowup","Accelerator Switches","Tow Bar"]),

            new Vehicle(1048, 1, "Taunt-o-Vision"              , "The Simpsons"                             , "taunt_o_vision.png"    , ["Taunt","Silver LEGO Blowup"]),
            new Vehicle(1049, 2, "The MechaHomer"              , "The Simpsons"                             , ""                      , ["Gold LEGO Blowup","Taunt","Silver LEGO Blowup"]),
            new Vehicle(1050, 3, "Blast Cam"                   , "The Simpsons"                             , ""                      , ["Special Weapon","Gold LEGO Blowup","Taunt","Silver LEGO Blowup"]),

            new Vehicle(1051, 1, "Velociraptor"                , "Jurassic World"                           , "velociraptor.png"      , ["Guardian Ability","Vine Cut"]),
            new Vehicle(1052, 2, "Spike Attack Raptor"         , "Jurassic World"                           , ""                      , ["Special Attack","Vine Cut","Guardian Ability","Super Strength"]),
            new Vehicle(1053, 3, "Venom Raptor"                , "Jurassic World"                           , ""                      , ["Super Strength","Dig","Vine Cut","Guardian Ability","Special Attack"]),

            new Vehicle(1054, 1, "Gyrosphere"                  , "Jurassic World"                           , "gyrosphere.png"        , ["Gyrosphere Switch"]),
            new Vehicle(1055, 2, "Sonic Beam Gyrosphere"       , "Jurassic World"                           , ""                      , ["Gyrosphere Switch","Sonar Smash"]),
            new Vehicle(1056, 3, "Speed Boost Gyrosphere"      , "Jurassic World"                           , ""                      , ["Gyrosphere Switch","Speed Boost","Sonar Smash"]),

            new Vehicle(1057, 1, "Clown Bike"                  , "The Simpsons"                             , "clown_bike.png"        , ["Accelerator Switches"]),
            new Vehicle(1058, 2, "Cannon Bike"                 , "The Simpsons"                             , ""                      , ["Accelerator Switches","Special Attack","Tow Bar"]),
            new Vehicle(1059, 3, "Anti-Gravity Rocket Bike"    , "The Simpsons"                             , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Accelerator Switches","Special Attack","Tow Bar"]),

            new Vehicle(1060, 1, "Mighty Lion Rider"           , "Lego Legends of Chima"                    , "mighty_lion_rider.png" , ["Accelerator Switches"]),
            new Vehicle(1061, 2, "Lion Blazer"                 , "Lego Legends of Chima"                    , ""                      , ["Special Attack","Tow Bar","Accelerator Switches"]),
            new Vehicle(1062, 3, "Fire Lion"                   , "Lego Legends of Chima"                    , ""                      , ["Special Weapon","Special Attack","Tow Bar","Accelerator Switches"]),

            new Vehicle(1063, 1, "Arrow Launcher"              , "Lord of the Rings"                        , "arrow_launcher.png"    , ["Accelerator Switches"]),
            new Vehicle(1064, 2, "Seeking Shooter"             , "Lord of the Rings"                        , ""                      , ["Accelerator Switches","Special Attack","Tow Bar"]),
            new Vehicle(1065, 3, "Triple Ballista"             , "Lord of the Rings"                        , ""                      , ["Accelerator Switches","Special Weapon","Special Attack","Tow Bar"]),

            new Vehicle(1066, 1, "Mystery Machine"             , "Scooby-Doo"                               , "mystery_machine.png"   , ["Accelerator Switches"]),
            new Vehicle(1067, 2, "Mystery Tow"                 , "Scooby-Doo"                               , ""                      , ["Accelerator Switches","Tow Bar"]),
            new Vehicle(1068, 3, "Mystery Monster"             , "Scooby-Doo"                               , ""                      , ["Accelerator Switches","Water Spray","Tow Bar"]),

            new Vehicle(1069, 1, "Boulder Bomber"              , "Lego Ninjago"                             , "boulder_bomber.png"    , ["Flying","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1070, 2, "Boulder Blaster"             , "Lego Ninjago"                             , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Silver LEGO Blowup"]),
            new Vehicle(1071, 3, "Cyclone Jet"                 , "Lego Ninjago"                             , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Special Attack","Silver LEGO Blowup"]),

            new Vehicle(1072, 1, "Storm Fighter"               , "Lego Ninjago"                             , "storm_fighter.png"     , ["Flying","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1073, 2, "Lightning Jet"               , "Lego Ninjago"                             , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Gold LEGO Blowup","Electricity"]),
            new Vehicle(1074, 3, "Electro-Shooter"             , "Lego Ninjago"                             , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Gold LEGO Blowup","Electricity","Special Attack"]),

            new Vehicle(1075, 1, "Blade Bike"                  , "Lego Ninjago"                             , "blade_bike.png"        , ["Accelerator Switches"]),
            new Vehicle(1076, 2, "Flying Fire Bike"            , "Lego Ninjago"                             , ""                      , ["Accelerator Switches","Special Attack","Flying","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1077, 3, "Blades of Fire"              , "Lego Ninjago"                             , ""                      , ["Accelerator Switches","Special Attack","Flying","Flight Docks and Flight Cargo Hooks"]),

            new Vehicle(1078, 1, "Samurai Mech"                , "Lego Ninjago"                             , "samurai_mech.png"      , ["Mech Walker","Super Strength"]),
            new Vehicle(1079, 2, "Samurai Shooter"             , "Lego Ninjago"                             , ""                      , ["Silver LEGO Blowup","Mech Walker","Super Strength"]),
            new Vehicle(1080, 3, "Soaring Samurai Mech"        , "Lego Ninjago"                             , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Silver LEGO Blowup","Mech Walker","Super Strength"]),

            new Vehicle(1081, 1, "Companion Cube"              , "Portal 2"                                 , "companion_cube.png"    , ["Weight Switch"]),
            new Vehicle(1082, 2, "Laser Deflector"             , "Portal 2"                                 , ""                      , ["Laser Deflector","Weight Switch"]),
            new Vehicle(1083, 3, "Gold Heart Emitter"          , "Portal 2"                                 , ""                      , ["Hearts Regenerate","Weight Switch","Laser Deflector"]),

            new Vehicle(1084, 1, "Sentry Turret"               , "Portal 2"                                 , "sentry_turret.png"     , ["Turret Switches"]),
            new Vehicle(1085, 2, "Turret Striker"              , "Portal 2"                                 , ""                      , ["Gold LEGO Blowup","Turret Switches"]),
            new Vehicle(1086, 3, "Flying Turret Carrier"       , "Portal 2"                                 , ""                      , ["Silver LEGO Blowup","Flying","Flight Docks and Flight Cargo Hooks","Gold LEGO Blowup","Turret Switches"]),

            new Vehicle(1087, 1, "Scooby Snack"                , "Scooby-Doo"                               , "scooby_snack.png"      , ["Super Strength"]),
            new Vehicle(1088, 2, "Scooby Fire Snack"           , "Scooby-Doo"                               , ""                      , ["Gold LEGO Blowup","Super Strength"]),
            new Vehicle(1089, 3, "Scooby Ghost Snack"          , "Scooby-Doo"                               , ""                      , ["Stealth","Gold LEGO Blowup","Super Strength"]),

            new Vehicle(1090, 1, "Cloud Cuckoo Car"            , "The Lego Movie"                           , "cloud_cuckoo_car.png"  , ["Flying","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1091, 2, "X-Stream Soaker"             , "The Lego Movie"                           , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Water Spray"]),
            new Vehicle(1092, 3, "Rainbow Cannon"              , "The Lego Movie"                           , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Special Attack","Water Spray"]),

            new Vehicle(1093, 1, "Invisible Jet"               , "DC Comics"                                , "invisible_jet.png"     , ["Flying","Flight Docks and Flight Cargo Hooks","Stealth"]),
            new Vehicle(1094, 2, "Stealth Laser Shooter"       , "DC Comics"                                , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Stealth","Gold LEGO Blowup"]),
            new Vehicle(1095, 3, "Torpedo Bomber"              , "DC Comics"                                , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Stealth","Gold LEGO Blowup","Silver LEGO Blowup"]),

            new Vehicle(1096, 1, "Ninja Copter"                , "Lego Ninjago"                             , "ninja_copter.png"      , ["Flying","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1097, 2, "Glaciator"                   , "Lego Ninjago"                             , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Special Attack"]),
            new Vehicle(1098, 3, "Freeze Fighter"              , "Lego Ninjago"                             , ""                      , ["Flying","Flight Docks and Flight Cargo Hooks","Gold LEGO Blowup","Special Attack"]),

            new Vehicle(1099, 1, "Traveling Time Train"        , "Back to the Future"                       , "traveling_time_train.png" , ["Accelerator Switches","Time Travel"]),
            new Vehicle(1100, 2, "Flying Time Train "          , "Back to the Future"                       , ""                         , ["Flying","Flight Docks and Flight Cargo Hooks","Time Travel","Accelerator Switches","Tow Bar"]),
            new Vehicle(1101, 3, "Missile Blast Time Train"    , "Back to the Future"                       , ""                         , ["Flying","Flight Docks and Flight Cargo Hooks","Silver LEGO Blowup","Time Travel","Accelerator Switches","Tow Bar"]),

            new Vehicle(1102, 1, "Aqua Watercraft"             , "DC Comics"                                , "aqua_watercraft.png"      , ["Sail","Dive"]),
            new Vehicle(1103, 2, "Seven Seas Speeder"          , "DC Comics"                                , ""                         , ["Speed Boost","Special Weapon","Sail","Dive"]),
            new Vehicle(1104, 3, "Trident of Fire"             , "DC Comics"                                , ""                         , ["Silver LEGO Blowup","Special Attack","Speed Boost","Special Weapon","Sail","Dive"]),

            new Vehicle(1105, 1, "Drill Driver"                , "DC Comics"                                , "drill_driver.png"         , ["Accelerator Switches","Drill","Dig"]),
            new Vehicle(1106, 2, "Bane Dig 'n' Drill"          , "DC Comics"                                , ""                         , ["Tow Bar","Dig","Drill","Accelerator Switches"]),
            new Vehicle(1107, 3, "Bane Drill 'n' Blast"        , "DC Comics"                                , ""                         , ["Special Attack","Silver LEGO Blowup","Drill","Dig","Accelerator Switches","Tow Bar"]),

            new Vehicle(1108, 1, "Quinn-mobile"                , "DC Comics"                                , "quinn_mobile.png"         , ["Accelerator Switches"]),
            new Vehicle(1109, 2, "Quinn Ultra Racer"           , "DC Comics"                                , ""                         , ["Speed Boost","Tow Bar","Accelerator Switches"]),
            new Vehicle(1110, 3, "Missile Launcher"            , "DC Comics"                                , ""                         , ["Silver LEGO Blowup","Speed Boost","Tow Bar","Accelerator Switches"]),

            new Vehicle(1111, 1, "The Jokers Chopper"          , "DC Comics"                                , "jokers_chopper.png"       , ["Flying","Flight Docks and Flight Cargo Hooks","Special Attack"]),
            new Vehicle(1112, 2, "Mischievous Missile Blaster" , "DC Comics"                                , ""                         , ["Flying","Flight Docks and Flight Cargo Hooks","Special Attack"]),
            new Vehicle(1113, 3, "Lock 'n' Laser Jet"          , "DC Comics"                                , ""                         , ["Flying","Flight Docks and Flight Cargo Hooks","Gold LEGO Blowup","Special Attack"]),

            new Vehicle(1114, 1, "Hover Pod"                   , "DC Comics"                                , "hover_pod.png"            , ["Flying","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1115, 2, "Krypton Striker"             , "DC Comics"                                , ""                         , ["Flying","Flight Docks and Flight Cargo Hooks","Special Weapon"]),
            new Vehicle(1116, 3, "Hover Pod 2"                 , "DC Comics"                                , ""                         , ["Flying","Flight Docks and Flight Cargo Hooks","Silver LEGO Blowup","Special Weapon"]),

            new Vehicle(1117, 1, "Dalek"                       , "Doctor Who"                               , "dalek.png"                , [""]),
            new Vehicle(1118, 2, "Fire 'n' Ride Dalek"         , "Doctor Who"                               , ""                         , ["Gold LEGO Blowup"]),
            new Vehicle(1119, 3, "Silver Shooter Dalek"        , "Doctor Who"                               , ""                         , ["Flying","Flight Docks and Flight Cargo Hooks","Silver LEGO Blowup","Gold LEGO Blowup"]),

            new Vehicle(1120, 1, "Ecto-1"                      , "Ghostbusters"                             , "ecto_one.png"             , ["Accelerator Switches"]),
            new Vehicle(1121, 2, "Ecto-1 Blaster"              , "Ghostbusters"                             , ""                         , ["Accelerator Switches","Water Spray","Tow Bar"]),
            new Vehicle(1122, 3, "Ecto-1 Water Diver"          , "Ghostbusters"                             , ""                         , ["Dive","Silver LEGO Blowup","Accelerator Switches","Water Spray","Tow Bar"]),

            new Vehicle(1123, 1, "Ghost Trap"                  , "Ghostbusters"                             , "ghost_trap.png"           , ["Ghost Trap"]),
            new Vehicle(1124, 2, "Ghost Stun'n'Trap"           , "Ghostbusters"                             , ""                         , ["Ghost Trap","Special Attack"]),
            new Vehicle(1125, 3, "Proton Zapper"               , "Ghostbusters"                             , ""                         , ["Gold LEGO Blowup","Special Weapon","Ghost Trap","Special Attack"]),

//            new Vehicle(1126, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
//            new Vehicle(1127, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
//            new Vehicle(1128, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),

//            new Vehicle(1129, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
//            new Vehicle(1130, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
//            new Vehicle(1131, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),

            new Vehicle(1132, 1, "Llyod's Golden Dragon"       , "Lego Ninjago"                             , "lloyds_golden_dragon.png" , ["Flying"]),
            new Vehicle(1133, 2, "Sword Projector Dragon"      , "Lego Ninjago"                             , ""                         , ["Flying","Special Attack"]),
            new Vehicle(1134, 3, "Llyod's Golden Dragon 2"     , "Lego Ninjago"                             , ""                         , ["Unknown"]),

 //           new Vehicle(1135, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
 //           new Vehicle(1136, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
 //           new Vehicle(1137, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
 
 //           new Vehicle(1138, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
 //           new Vehicle(1139, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
 //           new Vehicle(1140, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),

 //           new Vehicle(1141, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
 //           new Vehicle(1142, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
 //           new Vehicle(1143, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
              
            // vvv Not sure if this is just another build of lloyds dragon vvv
            new Vehicle(1144, 1, "Mega Flight Dragon"          , "Lego Ninjago"                             , "lloyds_golden_dragon.png" , ["Flying","Special Weapon","Special Attack"]),
            new Vehicle(1145, 2, "Mega Flight Dragon 1"        , "Lego Ninjago"                             , ""                         , ["Unknown"]),
            new Vehicle(1146, 3, "Mega Flight Dragon 2"        , "Lego Ninjago"                             , ""                         , ["Unknown"]),

//            new Vehicle(1147, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
//            new Vehicle(1148, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
//            new Vehicle(1149, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),

//            new Vehicle(1150, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
//            new Vehicle(1151, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
//            new Vehicle(1152, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),

//            new Vehicle(1153, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),
 //           new Vehicle(1154, "Unknown"                   , "Unknown"                                  , new List<string>() { "Unknown" }),

            new Vehicle(1155, 1, "Flying White Dragon"         , "Lego Ninjago"                             , "flying_white_dragon.png"  , ["Flying"]),
            new Vehicle(1156, 2, "Golden Fire Dragon"          , "Lego Ninjago"                             , ""                         , ["Flying","Special Attack"]),
            new Vehicle(1157, 3, "Ultra Destruction Dragon"    , "Lego Ninjago"                             , ""                         , ["Flying","Special Weapon","Special Attack"]),

            new Vehicle(1158, 1, "Arcade Machine"              , "Midway Arcade"                            , "arcade_machine.png"       , ["Arcade Docks"]),
            new Vehicle(1159, 2, "8-bit Shooter"               , "Midway Arcade"                            , ""                         , ["Flying","Arcade Docks"]),
            new Vehicle(1160, 3, "The Pixelator"               , "Midway Arcade"                            , ""                         , ["Special Attack","Arcade Docks","Flying"]),

            new Vehicle(1161, 1, "G-61555 Spy Hunter"          , "Midway Arcade"                            , "g_sixty_five.png"         , ["Accelerator Switches","Tow Bar"]),
            new Vehicle(1162, 2, "The Interdiver"              , "Midway Arcade"                            , ""                         , ["Sail","Silver LEGO Blowup","Accelerator Switches","Tow Bar"]),
            new Vehicle(1163, 3, "Aerial Spyhunter"            , "Midway Arcade"                            , ""                         , ["Flying","Flight Docks and Flight Cargo Hooks","Gold LEGO Blowup","Sail","Silver LEGO Blowup","Accelerator Switches","Tow Bar"]),

            new Vehicle(1164, 1, "Slime Shooter"               , "Ghostbusters"                             , "slime_shooter.png"        , ["Slime Bolts","Special Attack"]),
            new Vehicle(1165, 2, "Slime Exploder"              , "Ghostbusters"                             , ""                         , ["Slime Beam","Slime Bolts","Special Attack"]),
            new Vehicle(1166, 3, "Slime Streamer"              , "Ghostbusters"                             , ""                         , ["Slime Bomb","Silver LEGO Blowup","Slime Beam","Slime Bolts","Special Attack"]),

            new Vehicle(1167, 1, "Terror Dog"                  , "Ghostbusters"                             , "terror_dog.png"           , ["Guardian Ability"]),
            new Vehicle(1168, 2, "Terror Dog Destroyer"        , "Ghostbusters"                             , ""                         , ["Silver LEGO Blowup","Dig","Guardian Ability"]),
            new Vehicle(1169, 3, "Soaring Terror Dog"          , "Ghostbusters"                             , ""                         , ["Flying","Special Weapon","Silver LEGO Blowup","Dig","Guardian Ability"]),

            new Vehicle(1170, 1, "Tandem War Elefant"          , "Adventure Time"                           , "tandem_war_elefant.png"   , ["Hover","Gold LEGO Blowup","Guardian Ability"]),
            new Vehicle(1171, 2, "Cosmic Squid"                , "Adventure Time"                           , ""                         , ["Flight Docks and Flight Cargo Hooks","Tow Bar","Water Spray","Hover","Gold LEGO Blowup","Guardian Ability"]),
            new Vehicle(1172, 3, "Psychic Submarine"           , "Adventure Time"                           , ""                         , ["Gold LEGO Blowup","Underwater Interactions","Underwater Drone","Flight Docks and Flight Cargo Hooks","Tow Bar","Water Spray","Hover","Guardian Ability"]),

            new Vehicle(1173, 1, "BMO"                         , "Adventure Time"                           , "bmo.png"                  , ["BMO Docks","Illumination","Guardian Ability"]),
            new Vehicle(1174, 2, "DOGMO"                       , "Adventure Time"                           , ""                         , ["Dig","Illumination","Guardian Ability","BMO Docks"]),
            new Vehicle(1175, 3, "SNAKEMO"                     , "Adventure Time"                           , ""                         , ["Electricity","Dig","Illumination","Guardian Ability","BMO Docks"]),

            new Vehicle(1176, 1, "Jakemobile"                  , "Adventure Time"                           , "jakemobile.png"           , ["Tow Bar","Guardian Ability","Accelerator Switches"]),
            new Vehicle(1177, 2, "Snail Dude Jake"             , "Adventure Time"                           , ""                         , ["Sonar Smash","Super Jump","Super Strength","Guardian Ability","Tow Bar","Accelerator Switches"]),
            new Vehicle(1178, 3, "Hover Jake"                  , "Adventure Time"                           , ""                         , ["Sail","Tow Bar","Water Spray","Guardian Ability","Sonar Smash","Super Jump","Super Strength","Tow Bar","Accelerator Switches"]),

            new Vehicle(1179, 1, "Lumpy Car"                   , "Adventure Time"                           , "lumpy_car.png"            , ["Accelerator Switches","Tow Bar","Jump"]),
            new Vehicle(1180, 2, "Lumpy Land Whale"            , "Adventure Time"                           , ""                         , ["Underwater Drone","Sonar Smash","Underwater Interactions","Accelerator Switches","Tow Bar","Jump"]),
            new Vehicle(1181, 3, "Lumpy Truck"                 , "Adventure Time"                           , ""                         , ["Rainbow LEGO Objects","Gold LEGO Blowup","Flight Docks and Flight Cargo Hooks","Underwater Drone","Sonar Smash","Underwater Interactions","Accelerator Switches","Tow Bar","Jump"]),

            new Vehicle(1182, 1, "Lunatic Amp"                 , "Adventure Time"                           , "lunatic_amp.png"          , ["Sonar Smash","Super Jump","Dig","Tow Bar"]),
            new Vehicle(1183, 2, "Shadow Scorpion"             , "Adventure Time"                           , ""                         , ["Flight Docks and Flight Cargo Hooks","Special Attack","Tow Bar","Sonar Smash","Super Jump","Dig"]),
            new Vehicle(1184, 3, "Heavy Metal Monster"         , "Adventure Time"                           , ""                         , ["Guardian Ability","Super Strength","Cursed Red LEGO Objects","Flight Docks and Flight Cargo Hooks","Special Attack","Tow Bar","Sonar Smash","Super Jump","Dig"]),

            new Vehicle(1185, 1, "B.A.'s Van"                  , "The A-Team"                               , "ba_van.png"               , ["Accelerator Switches","Tow Bar"]),
            new Vehicle(1186, 2, "Fool Shmasher"               , "The A-Team"                               , ""                         , ["Accelerator Switches","Silver LEGO Blowup","Special Attack","Super Strength","Tow Bar"]),
            new Vehicle(1187, 3, "Pain Plane"                  , "The A-Team"                               , ""                         , ["Flying","Flight Docks and Flight Cargo Hooks","Sail","Accelerator Switches","Silver LEGO Blowup","Special Attack","Super Strength","Tow Bar"]),

            new Vehicle(1188, 1, "Phone Home"                  , "E.T. the Extra-Terrestrial"               , "phone_home.png"           , ["Phone Home","Sonar Smash"]),
            new Vehicle(1189, 2, "Mobile Uplink"               , "E.T. the Extra-Terrestrial"               , ""                         , ["Phone Home","Special Attack","Sonar Smash"]),
            new Vehicle(1190, 3, "Super-Charged Satellite"     , "E.T. the Extra-Terrestrial"               , ""                         , ["Silver LEGO Blowup","Gold LEGO Blowup","Flight Docks and Flight Cargo Hooks","Tow Bar","Phone Home","Special Attack","Sonar Smash"]),

            new Vehicle(1191, 1, "Niffler"                     , "Fantastic Beasts and Where to Find Them"  , "niffler.png"              , ["Playable Character","Enhanced Stud Attraction","Dig","Guardian Ability"]),
            new Vehicle(1192, 2, "Sinister Scorpion"           , "Fantastic Beasts and Where to Find Them"  , ""                         , ["Vine Cut","Special Weapon","Playable Character","Enhanced Stud Attraction","Dig","Guardian Ability"]),
            new Vehicle(1193, 3, "Vicious Vulture"             , "Fantastic Beasts and Where to Find Them"  , ""                         , ["Gold LEGO Blowup","Guardian Ability","Vine Cut","Special Weapon","Playable Character","Enhanced Stud Attraction","Dig"]),

            new Vehicle(1194, 1, "Swooping Evil"               , "Fantastic Beasts and Where to Find Them"  , "swooping_evil.png"        , ["Playable Character","Guardian Ability"]),
            new Vehicle(1195, 2, "Brutal Bloom"                , "Fantastic Beasts and Where to Find Them"  , ""                         , ["Special Weapon","Guardian Ability","Tow Bar","Vine Cut","Playable Character"]),
            new Vehicle(1196, 3, "Crawling Creeper"            , "Fantastic Beasts and Where to Find Them"  , ""                         , ["Super Jump","Electricity","Dig","Special Weapon","Guardian Ability","Tow Bar","Vine Cut","Playable Character"]),

            new Vehicle(1197, 1, "Ecto-1 (2016)"               , "Ghostbusters 2016"                        , "ecto_twenty_sixteen.png"  , ["Accelerator Switches","Tow Bar"]),
            new Vehicle(1198, 2, "Ectozer"                     , "Ghostbusters 2016"                        , ""                         , ["Accelerator Switches","Tow Bar","Special Attack","Super Strength"]),
            new Vehicle(1199, 3, "PerfEcto"                    , "Ghostbusters 2016"                        , ""                         , ["Electricity","Water Spray","Flying","Sail","Accelerator Switches","Tow Bar","Special Attack","Super Strength"]),

            new Vehicle(1200, 1, "Flash 'n' Finish"            , "Gremlins"                                 , "flash_n_finish.png"       , ["Illumination","Sonar Smash","Gold LEGO Blowup"]),
            new Vehicle(1201, 2, "Rampage Record Player"       , "Gremlins"                                 , ""                         , ["Special Attack","Special Weapon","Illumination","Sonar Smash","Gold LEGO Blowup"]),
            new Vehicle(1202, 3, "Stripe's Throne"             , "Gremlins"                                 , ""                         , ["Super Jump","Cursed Red LEGO Objects","Special Attack","Special Weapon","Illumination","Sonar Smash","Gold LEGO Blowup"]),

            new Vehicle(1203, 1, "R.C. Car"                    , "Gremlins"                                 , "rc_car.png"               , ["Accelerator Switches","Special Attack","Electricity"]),
            new Vehicle(1204, 2, "Gadget-o-matic"              , "Gremlins"                                 , ""                         , ["Accelerator Switches","Special Attack","Tow Bar","Electricity"]),
            new Vehicle(1205, 3, "Scarlet Scorpion"            , "Gremlins"                                 , ""                         , ["Super Jump","Vine Cut","Accelerator Switches","Special Attack","Tow Bar","Electricity"]),

            new Vehicle(1206, 1, "Hogwart Express"             , "Harry Potter"                             , "hogwarts_express.png"     , ["Accelerator Switches","Tow Bar","Sonar Smash"]),
            new Vehicle(1207, 2, "Steam Warrior"               , "Harry Potter"                             , ""                         , ["Super Strength","Super Jump","Special Attack","Guardian Ability","Accelerator Switches","Tow Bar","Sonar Smash"]),
            new Vehicle(1208, 3, "Soaring Steam Plane"         , "Harry Potter"                             , ""                         , ["Gold LEGO Blowup","Flight Docks and Flight Cargo Hooks","Super Strength","Super Jump","Special Attack","Guardian Ability","Accelerator Switches","Tow Bar","Sonar Smash"]),

            new Vehicle(1209, 1, "Enchanted Car"               , "Harry Potter"                             , "enchanted_car.png"        , ["Accelerator Switches","Tow Bar","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1210, 2, "Shark Sub"                   , "Harry Potter"                             , ""                         , ["Underwater Drone","Underwater Interactions","Sonar Smash","Accelerator Switches","Tow Bar","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1211, 3, "Monstrous Mouth"             , "Harry Potter"                             , ""                         , ["Vine Cut","Gold LEGO Blowup","Underwater Drone","Underwater Interactions","Sonar Smash","Accelerator Switches","Tow Bar","Flight Docks and Flight Cargo Hooks"]),

            new Vehicle(1212, 1, "IMF Scrambler"               , "Mission: Impossible"                      , "imf_scrambler.png"        , ["Accelerator Switches","Jump","Special Attack"]),
            new Vehicle(1213, 2, "Shock Cycle"                 , "Mission: Impossible"                      , ""                         , ["Accelerator Switches","Jump","Special Weapon","Silver LEGO Blowup","Special Attack"]),
            new Vehicle(1214, 3, "IMF Covert Jet"              , "Mission: Impossible"                      , ""                         , ["Flight Docks and Flight Cargo Hooks","Underwater Interactions","Special Weapon","Tow Bar","Accelerator Switches","Jump","Silver LEGO Blowup","Special Attack"]),

            new Vehicle(1215, 1, "IMF Sports Car"              , "Mission: Impossible"                      , "imf_sports_car.png"       , ["Accelerator Switches","Tow Bar"]),
            new Vehicle(1216, 2, "IMF Tank"                    , "Mission: Impossible"                      , ""                         , ["Super Strength","Gold LEGO Blowup","Tow Bar","Accelerator Switches"]),
            new Vehicle(1217, 3, "IMF Splorer"                 , "Mission: Impossible"                      , ""                         , ["Underwater Drone","Underwater Interactions","Super Strength","Gold LEGO Blowup","Tow Bar","Accelerator Switches"]),

            new Vehicle(1218, 1, "Sonic Speedster"             , "Sonic the Hedgehog"                       , "sonic_speedster.png"      , ["Accelerator Switches","Tow Bar"]),
            new Vehicle(1219, 2, "Blue Typhoon"                , "Sonic the Hedgehog"                       , ""                         , ["Flight Docks and Flight Cargo Hooks","Sail","Sonar Smash","Tow Bar","Accelerator Switches"]),
            new Vehicle(1220, 3, "Moto Bug"                    , "Sonic the Hedgehog"                       , ""                         , ["Accelerator Switches","Dig","Vine Cut","Super Jump","Flight Docks and Flight Cargo Hooks","Sail","Sonar Smash","Tow Bar"]),

            new Vehicle(1221, 1, "The Tornado"                 , "Sonic the Hedgehog"                       , "tornado.png"              , ["Tow Bar","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1222, 2, "Crabmeat"                    , "Sonic the Hedgehog"                       , ""                         , ["Jump","Gold LEGO Blowup","Super Jump","Guardian Ability","Tow Bar","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1223, 3, "Eggcatcher"                  , "Sonic the Hedgehog"                       , ""                         , ["Tow Bar","Flight Docks and Flight Cargo Hooks","Electricity","Jump","Gold LEGO Blowup","Super Jump","Guardian Ability"]),

            new Vehicle(1224, 1, "K.I.T.T."                    , "Knight Rider"                             , "kitt.png"                 , ["Accelerator Switches","Gold LEGO Blowup"]),
            new Vehicle(1225, 2, "Goliath Armored Semi"        , "Knight Rider"                             , ""                         , ["Tow Bar","Super Strength","Electricity","Accelerator Switches","Gold LEGO Blowup"]),
            new Vehicle(1226, 3, "K.I.T.T. Jet"                , "Knight Rider"                             , ""                         , ["Flight Docks and Flight Cargo Hooks","Gold LEGO Blowup","Silver LEGO Blowup","Tow Bar","Super Strength","Electricity","Accelerator Switches"]),

            new Vehicle(1227, 1, "Police helicopter"           , "LEGO City: Undercover"                    , "police_helicopter.png"    , ["Flight Docks and Flight Cargo Hooks","Special Attack","Tow Bar"]),
            new Vehicle(1228, 2, "Police hovercraft"           , "LEGO City: Undercover"                    , ""                         , ["Gold LEGO Blowup","Accelerator Switches","Super Jump","Special Attack","Flight Docks and Flight Cargo Hooks","Tow Bar"]),
            new Vehicle(1229, 3, "Police Plane"                , "LEGO City: Undercover"                    , ""                         , ["Flight Docks and Flight Cargo Hooks","Tow Bar","Drone Mazes","Gold LEGO Blowup","Accelerator Switches","Super Jump","Special Attack"]),

            new Vehicle(1230, 1, "Bionic Steed"                , "The LEGO Batman Movie"                    , "bionic_steed.png"         , ["Super Jump","Special Weapon"]),
            new Vehicle(1231, 2, "Bat Raptor"                  , "The LEGO Batman Movie"                    , ""                         , ["Super Jump","Super Strength","Special Weapon"]),
            new Vehicle(1232, 3, "Ultrabat"                    , "The LEGO Batman Movie"                    , ""                         , ["Sonar Smash","Super Strength","Super Jump","Super Strength","Special Weapon"]),

            new Vehicle(1233, 1, "Batwing"                     , "The LEGO Batman Movie"                    , "batwing.png"              , ["Tow Bar","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1234, 2, "The Black Thunder"           , "The LEGO Batman Movie"                    , ""                         , ["Accelerator Switches","Tow Bar","Flight Docks and Flight Cargo Hooks"]),
            new Vehicle(1235, 3, "Bat-Tank"                    , "The LEGO Batman Movie"                    , ""                         , ["Accelerator Switches","Tow Bar","Silver LEGO Blowup","Flight Docks and Flight Cargo Hooks"]),

            new Vehicle(1236, 1, "Skeleton Organ"              , "The Goonies"                              , "skeleton_organ.png"       , ["Organ Docks","Special Weapon","Sonar Smash"]),
            new Vehicle(1237, 2, "Skeleton Jukebox"            , "The Goonies"                              , ""                         , ["Jump","Special Weapon","Electricity","Organ Docks","Sonar Smash"]),
            new Vehicle(1238, 3, "Skele-Turkey"                , "The Goonies"                              , ""                         , ["Gold LEGO Blowup","Flight Docks and Flight Cargo Hooks","Tow Bar","Jump","Special Weapon","Electricity","Organ Docks","Sonar Smash"]),

            new Vehicle(1239, 1, "One-Eyed Willy's Pirate Ship", "The Goonies"                              , "pirateship.png"           , ["Sail","Silver LEGO Blowup","Special Attack"]),
            new Vehicle(1240, 2, "Fanged Fortune"              , "The Goonies"                              , ""                         , ["Water Spray","Special Attack","Vine Cut","Sail","Silver LEGO Blowup"]),
            new Vehicle(1241, 3, "Inferno Cannon"              , "The Goonies"                              , ""                         , ["Special Attack","Special Weapon","Silver LEGO Blowup","Water Spray","Vine Cut","Sail"]),

            new Vehicle(1242, 1, "Buckbeak"                    , "Harry Potter"                             , "buckbeak.png"             , ["Super Strength","Flying","Guardian Ability","Silver LEGO Blowup"]),
            new Vehicle(1243, 2, "Giant Owl"                   , "Harry Potter"                             , ""                         , ["Flying","Electricity","Super Strength","Guardian Ability","Silver LEGO Blowup"]),
            new Vehicle(1244, 3, "Fierce Falcon"               , "Harry Potter"                             , ""                         , ["Flying","Special Weapon","Sonar Smash","Electricity","Super Strength","Guardian Ability","Silver LEGO Blowup"]),

            new Vehicle(1245, 1, "Saturn's Sandworm"           , "Beetlejuice"                              , "saturns_sandworm.png"     , ["Sonar Smash"]),
            new Vehicle(1246, 2, "Spooky Spider"               , "Beetlejuice"                              , ""                         , ["Special Weapon","Super Jump","Cursed Red LEGO Objects","Enhanced Stud Attraction","Sonar Smash"]),
            new Vehicle(1247, 3, "Haunted Vacuum"              , "Beetlejuice"                              , ""                         , ["Gold LEGO Blowup","Tow Bar","Silver LEGO Blowup","Special Weapon","Super Jump","Cursed Red LEGO Objects","Enhanced Stud Attraction","Sonar Smash"]),

            new Vehicle(1248, 1, "PPG Smartphone"              , "The Powerpuff Girls"                      , "ppg_smartphone.png"       , ["Flight Docks and Flight Cargo Hooks","Gold LEGO Blowup"]),
            new Vehicle(1249, 2, "PPG Hotline"                 , "The Powerpuff Girls"                      , ""                         , ["Special Weapon","Rainbow LEGO Objects","Flight Docks and Flight Cargo Hooks","Gold LEGO Blowup"]),
            new Vehicle(1250, 3, "Powerpuff Mag-Net"           , "The Powerpuff Girls"                      , ""                         , ["Special Weapon","Enhanced Stud Attraction","Silver LEGO Blowup","Rainbow LEGO Objects","Flight Docks and Flight Cargo Hooks","Gold LEGO Blowup"]),

            new Vehicle(1251, 1, "Ka-Pow Cannon"               , "The Powerpuff Girls"                      , "kapow.png"                , ["Special Weapon","Silver LEGO Blowup"]),
            new Vehicle(1252, 2, "Slammin' Guitar"             , "The Powerpuff Girls"                      , ""                         , ["Special Weapon","Super Strength","Accelerator Switches","Tow Bar","Silver LEGO Blowup"]),
            new Vehicle(1253, 3, "Megablast-Bot"               , "The Powerpuff Girls"                      , ""                         , ["Special Attack","Special Weapon","Sonar Smash","Super Strength","Accelerator Switches","Tow Bar","Silver LEGO Blowup"]),

            new Vehicle(1254, 1, "Octi"                        , "The Powerpuff Girls"                      , "octi.png"                 , ["Gold LEGO Blowup"]),
            new Vehicle(1255, 2, "Super SKunk"                 , "The Powerpuff Girls"                      , ""                         , ["Vine Cut","Super Jump","Dig","Gold LEGO Blowup"]),
            new Vehicle(1256, 3, "Sonic Squid"                 , "The Powerpuff Girls"                      , ""                         , ["Water Spray","Vine Cut","Super Jump","Dig","Gold LEGO Blowup"]),

            new Vehicle(1257, 1, "T-Car"                       , "Teen Titans Go!"                          , "t_car.png"                , ["Super Jump","Accelerator Switches","Tow Bar"]),
            new Vehicle(1258, 2, "T-Forklift"                  , "Teen Titans Go!"                          , ""                         , ["Super Jump","Accelerator Switches","Drone Mazes","Tow Bar"]),
            new Vehicle(1259, 3, "T-Plane"                     , "Teen Titans Go!"                          , ""                         , ["Accelerator Switches","Flight Docks and Flight Cargo Hooks","Tow Bar","Sail","Super Jump","Drone Mazes"]),

            new Vehicle(1260, 1, "Spellbook of Azarath"        , "Teen Titans Go!"                          , "spellbook_of_azarath.png" , ["Summon Ability","Rainbow LEGO Objects","Cursed Red LEGO Objects","Sonar Smash"]),
            new Vehicle(1261, 2, "Raven Wings"                 , "Teen Titans Go!"                          , ""                         , ["Cursed Red LEGO Objects","Flying","Gold LEGO Blowup","Tow Bar","Sonar Smash","Summon Ability","Rainbow LEGO Objects"]),
            new Vehicle(1262, 3, "Giant Hand"                  , "Teen Titans Go!"                          , ""                         , ["Super Jump","Dig","Super Strength","Cursed Red LEGO Objects","Flying","Gold LEGO Blowup","Tow Bar","Sonar Smash","Summon Ability","Rainbow LEGO Objects"]),

            new Vehicle(1263, 1, "Titan Robot"                 , "Teen Titans Go!"                          , "titan_robot.png"          , ["Special Weapon","Super Strength","Tow Bar","Silver LEGO Blowup"]),
            new Vehicle(1264, 2, "T-Rocket"                    , "Teen Titans Go!"                          , ""                         , ["Gold LEGO Blowup","Flying","Special Weapon","Super Strength","Tow Bar","Silver LEGO Blowup"]),
            new Vehicle(1265, 3, "Robot Retriever"             , "Teen Titans Go!"                          , ""                         , ["Super Jump","Dig","Electricity","Gold LEGO Blowup","Flying","Special Weapon","Super Strength","Tow Bar","Silver LEGO Blowup"]),
            ];

    }
}
