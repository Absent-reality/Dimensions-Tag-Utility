
namespace DimensionsTagUtility
{
    /// <summary>
    /// Character class for Lego Dimensions.
    /// </summary>
    public class Character : ILegoTag
    {
        /// <summary>
        /// Gets or sets the ID of the character.
        /// </summary>
        public ushort Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the character.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the icon of the character.
        /// </summary>
        public string Images { get; set; }

        /// <summary>
        /// Gets or sets the world the character is from..
        /// </summary>
        public string World { get; set; }

        /// <summary>
        /// Gets or sets the list of abilities of the character.
        /// </summary>
        public List<string> Abilities { get; set; }

        /// <summary>
        /// Character class constructor.
        /// </summary>
        /// <param name="id">The ID of the character.</param>
        /// <param name="name">The name of the character.</param>
        /// <param name="images">The icon image of the character.</param>
        /// <param name="world">The world the character is from.</param>
        /// <param name="abilities">The list of abilities of the character.</param>
        public Character(ushort id, string name, string world, string images, List<string> abilities)
        {
            Id = id;
            Name = name;
            Images = images;
            World = world;
            Abilities = abilities;
        }

        /// <summary>
        /// The list of all knonws characters.
        /// </summary>
        public static readonly List<Character> Characters =
        [
//          new Character(00, "Unknown"             , "Unknown",                                 "",                 new List<string>() { }),
            new Character(01, "Batman"              , "DC Comics",                               "batman.png",                     ["Grapple","Boomerang","Stealth","Rope Swing","Glide","Detective Mode","Master Build"]),
            new Character(02, "Gandalf"             , "Lord of the Rings",                       "gandalf.png",                    ["Magic","Magical Shield","Illumination"]),
            new Character(03, "Wyldstyle"           , "The Lego Movie",                          "wyldstyle.png",                  ["Relic Detector","Acrobat","Master Build"]),
            new Character(04, "Aquaman"             , "DC Comics",                               "aquaman.png",                    ["Atlantis Elemental","Dive","Hazard Cleaner","Growth","Water Spray"]),
            new Character(05, "Bad Cop"             , "The Lego Movie",                          "badcop.png",                     ["Laser","Relic Detector","Target"]),
            new Character(06, "Bane"                , "DC Comics",                               "bane.png",                       ["Big Transform","Super Strength","Super Strength Handles","Hazard Protection"]),
            new Character(07, "Bart Simpson"        , "The Simpsons",                            "bart_simpson.png",               ["Target","Mini Access"]),
            new Character(08, "Benny"               , "The Lego Movie",                          "benny.png",                      ["Hacking","Sonar Smash","Target","Master Build","Technology","Glide"]),
            new Character(09, "Chell"               , "Portal 2",                                "chell.png",                      ["Acrobat","Portal Gun"]),

            new Character(10, "Cole"                , "Lego Ninjago",                            "cole.png",                       ["Spinjitzu","Acrobat","Stealth","Laser Deflector","Super Strength"]),
            new Character(11, "Cragger"             , "Lego Legends of Chima",                   "cragger.png",                    ["CHI","Super Strength","Super Strength Handles","Dive","Hazard Protection"]),
            new Character(12, "Cyborg"              , "DC Comics",                               "cyborg.png",                     ["Target","Dive","Laser","Underwater Laser","Technology","Underwater Technology","Big Transform","Super Strength","Super Strength Handles","Character Changing","Flying","Fix-It","Hearts Regenerate"]),
            new Character(13, "Cyberman"            , "Doctor Who",                              "cyberman.png",                   ["Mind Control","Hacking","Drone Mazes","Silver LEGO Blowup","X-Ray Vision","Dive","Technology"]),
            new Character(14, "Doc Brown"           , "Back to the Future",                      "doc_brown.png",                  ["Hacking","Technology","Fix-It","Drone Mazes","Intelligence"]),
            new Character(15, "The Doctor"          , "Doctor Who",                              "the_doctor.png",                 ["Hacking","Technology","Fix-It","Sonar Smash","Intelligence"]),
            new Character(16, "Emmet"               , "The Lego Movie",                          "emmet.png",                      ["Drill","Master Build","Fix-It"]),
            new Character(17, "Eris"                , "Lego Legends of Chima",                   "eris.png",                       ["Super Strength","CHI","Target","Flying"]),
            new Character(18, "Gimli"               , "Lord of the Rings",                       "gimli.png",                      ["Super Strength","Super Strength Handles","Mini Access"]),
            new Character(19, "Gollum"              , "Lord of the Rings",                       "gollum.png",                     ["Boomerang","Silver LEGO Blowup","Mini Access","Acrobat","Dive"]),

            new Character(20, "Harley Quinn"        , "DC Comics",                               "harley_quinn.png",               ["Acrobat","Super Strength"]),
            new Character(21, "Homer Simpson"       , "The Simpsons",                            "homer_simpson.png",              ["Sonar Smash","Chili Eating","Big Transform","Super Strength","Super Strength Handles"]),
            new Character(22, "Jay"                 , "Lego Ninjago",                            "jay.png",                        ["Spinjitzu","Fix-It","Acrobat","Stealth","Electricity","Intelligence"]),
            new Character(23, "Joker"               , "DC Comics",                               "joker.png",                      ["Electricity","Target","Grapple","Hazard Protection"]),
            new Character(24, "Kai"                 , "Lego Ninjago",                            "kai.png",                        ["Spinjitzu","Acrobat","Stealth","Laser Deflector"]),
            new Character(25, "ACU Trooper"         , "Jurassic World",                          "acu_trooper.png",                ["Electricity","Illumination"]),
            new Character(26, "Gamer Kid"           , "Midway Arcade",                           "gamer_kid.png",                  ["Super Strength","Super Strength Handles","Laser","Invulnerability","Stealth","Speed"]),
            new Character(27, "Krusty"              , "The Simpsons",                            "krusty.png",                     ["Growth","Hazard Cleaner","Water Spray"]),
            new Character(28, "Laval"               , "Lego Legends of Chima",                   "laval.png",                      ["CHI","Super Strength","Acrobat","Laser Deflector","Sonar Smash"]),
            new Character(29, "Legolas"             , "Lord of the Rings",                       "legolas.png",                    ["Pole Vault","Target","Acrobat","Grind Rails"]),

            new Character(30, "Lloyd"               , "Lego Ninjago",                            "lloyd.png",                      ["Spinjitzu","Acrobat","Stealth","Laser Deflector","Illumination"]),
            new Character(31, "Marty McFly"         , "Back to the Future",                      "marty_mcfly.png",                ["Sonar Smash"]),
            new Character(32, "Nya"                 , "Lego Ninjago",                            "nya.png",                        ["Spinjitzu","Acrobat","Stealth","Laser Deflector","Fix-It"]),
            new Character(33, "Owen"                , "Jurassic World",                          "owen.png",                       ["Tracking","Stealth","Target","Vine Cut"]),
            new Character(34, "Peter Venkman"       , "Ghostbusters",                            "peter_vinkman.png",              ["Suspend Ghost","Laser","Hazard Protection"]),
            new Character(35, "Slimer"              , "Ghostbusters",                            "slimer.png",                     ["Boomerang","Flying","Slurp Access","Dive","Hazard Cleaner","Sonar Smash","Illumination","Mini Access","Hazard Protection"]),
            new Character(36, "Scooby"              , "Scooby-Doo",                              "scooby_doo.png",                 ["Tracking","Dig","Dive","Stealth","Glide"]),
            new Character(37, "Sensei Wu"           , "Lego Ninjago",                            "sensei_wu.png",                  ["Spinjitzu","Stealth","Pole Vault","Acrobat","Glide"]),
            new Character(38, "Shaggy"              , "Scooby-Doo",                              "shaggy.png",                     ["Tracking","Illumination","Stealth","Glide"]),
            new Character(39, "Stay Puft"           , "Ghostbusters",                            "stay_puft.png",                  ["Big Transform","Super Strength","Super Strength Handles","Hazard Protection"]),

            new Character(40, "Superman"            , "DC Comics",                               "superman.png",                   ["Flying","Dive","Invulnerability","Super Strength","Super Strength Handles","Freeze Breath","Laser","X-Ray Vision"]),
            new Character(41, "Unikitty"            , "The Lego Movie",                          "unikitty.png",                   ["Rainbow LEGO Objects","Master Build","Big Transform"]),
            new Character(42, "Wicked Witch"        , "Wizard of Oz",                            "wicked_witch.png",               ["Silver LEGO Blowup","Flying","Magic","Illumination","Mind Control","Magical Shield"]),
            new Character(43, "Wonder Woman"        , "DC Comics",                               "wonder_woman.png",               ["Acrobat","Flying","Mind Control","Laser Deflector","Invulnerability","Grapple","Boomerang","Dive","Super Strength","Super Strength Handles"]),
            new Character(44, "Zane"                , "Lego Ninjago",                            "zane.png",                       ["Acrobat","Spinjitzu","Stealth","Boomerang","Dive","X-Ray Vision"]),
            new Character(45, "Green Arrow"         , "DC Comics",                               "green_arrow.png",                ["Pole Vault","Target","Acrobat","Grapple"]),
            new Character(46, "Supergirl"           , "DC Comics",                               "supergirl.png",                  ["Flying","Laser","Invulnerability","Super Strength","Super Strength Handles","X-Ray Vision","Dive","Freeze Breath","Red Lantern Transformation","Lantern Constructs","Dig","Grapple"]),
            new Character(47, "Abby Yates"          , "Ghostbusters 2016",                       "abby_yates.png",                 ["Intelligence","Ghost Trap","Suspend Ghost","Ghost Puzzles","Laser","Hazard Protection","Charge Transfer","P.K.E. Meter","Character Changing","Technology","Silver LEGO Blowup","Fix-It","Grapple","Rope Swing","Super Strength","Super Strength Handles","Ghost Chipper"]),
            new Character(48, "Finn"                , "Adventure Time",                          "finn.png",                       ["Acrobat","Laser","Target","Laser Deflector","Pole Vault","Sword Switch","Cursed Red LEGO Objects","Grapple","Vine Cut","Rope Swing"]),
            new Character(49, "Ethan Hunt"          , "Mission: Impossible",                     "ethan_hunt.png",                 ["Acrobat","Target","Technology","Fuse Box","Magno Gloves","Drone Mazes","Grapple","Silver LEGO Blowup","Stealth","Scan Disguise","Dive","X-Ray Vision","Rope Swing"]),

            new Character(50, "Lumpy Space Princess", "Adventure Time",                          "lumpy.png",                      ["Boomerang","Hazard Protection","Rainbow LEGO Objects","Mini Access","Slurp Access","Target"]),
            new Character(51, "Jake the Dog"        , "Adventure Time",                          "jake_the_dog.png",               ["Grapple","Illumination","Slurp Access","Tracking","Dig","Rope Swing","Shape Shift","Super Strength","Super Strength Handles","Drill","Gyrosphere Switch","Sonar Smash","Dive","Mini Access","Drone Mazes","Big Transform"]),
            new Character(52, "Harry"               , "Harry Potter",                            "harrypotter.png",                ["Water Spray","Target","Laser Deflector","Diffindo","Flying","Illumination","Silver LEGO Blowup","Stealth","Magic","Parseltongue Doors","Apparate Access","Hazard Cleaner","Growth"]),
            new Character(53, "Lord Voldemort"      , "Harry Potter",                            "voldemort.png",                  ["Water Spray","Target","Laser Deflector","Diffindo","Flying","Illumination","Mind Control","Silver LEGO Blowup","Magic","Parseltongue Doors","Apparate Access","Hazard Cleaner","Growth"]),
            new Character(54, "Michael Knight"      , "Knight Rider",                            "michael_knight.png",             ["Acrobat","Hacking","Technology","Tracking","X-Ray Vision"]),
            new Character(55, "B.A.Baracus"         , "The A-Team",                              "ba_baracus.png",                 ["Target","Fix-It","Silver LEGO Blowup","Super Strength","Super Strength Handles","A-Team Master Build","Laser Deflector","Character Changing"]),
            new Character(56, "Newt Scamander"      , "Fantastic Beasts and Where to Find Them", "newt_scamander.png",             ["Water Spray","Target","Laser Deflector","Diffindo","Illumination","Silver LEGO Blowup","Stealth","Magic","Intelligence","Fix-It","Lockpicking","Fantastical Briefcase","Apparate Access","Hazard Cleaner","Growth"]),
            new Character(57, "Sonic"               , "Sonic the Hedgehog",                      "sonic_the_hedgehog.png",         ["Speed","Grind Rails","Acrobat","Super Strength","Super Transformation","Invulnerability","Laser Deflector","Super Jump"]),
//          new Character(58, "Unknown"             , "Unknown",                                 "",                               new List<string>() { "Unknown" }),
            new Character(59, "Gizmo"               , "Gremlins",                                "gizmo.png",                      ["Target","Mini Access","Grapple","Rope Swing","Vine Cut","Acrobat","Dig","Silver LEGO Blowup"]),

            new Character(60, "Stripe"              , "Gremlins",                                "stripe.png",                     ["Target","Acrobat","Dig","Vine Cut"]),
            new Character(61, "E.T."                , "E.T. the Extra-Terrestrial",              "e_t.png",                        ["Growth","Fix-It","Hearts Regenerate","Illumination","Stealth","Magic","Mini Access"]),
            new Character(62, "Tina Goldstein"      , "Fantastic Beasts and Where to Find Them", "tina_goldstein.png",             ["Acrobat","Water Spray","Target","Laser Deflector","Diffindo","Illumination","Silver LEGO Blowup","Stealth","Magic","Apparate Access","Magical Shield","Growth","Hazard Cleaner","Mind Control"]),
            new Character(63, "Marceline Abadeer"   , "Adventure Time",                          "marceline.png",                  ["Sonar Smash","Flying","Magic","Slurp Access","Dig","Tracking","Stealth","Acrobat","Cursed Red LEGO Objects","Hearts Regenerate","Mini Access","Vine Cut","Super Strength"]),
            new Character(64, "Batgirl"             , "The LEGO Batman Movie",                   "batgirl.png",                    ["Boomerang","Detective Mode","Stealth","Grapple","High Security Access","Glide","Rope Swing"]),
            new Character(65, "Robin (Lego Movie)"  , "The LEGO Batman Movie",                   "robin.png",                      ["Acrobat","Fix-It","Vent Access","Illumination","Suit Rip","Dive","Pole Vault","Laser Deflector","Glide","Grapple","Rope Swing"]),
            new Character(66, "Sloth"               , "The Goonies",                             "sloth.png",                      ["Super Strength","Super Strength Handles","Grapple","Rope Swing","Dig","Dive","Target","Uniform Changing","Character Changing","Mini Access","Intelligence","Silver LEGO Blowup","Acrobat","Laser Deflector","Technology","X-Ray Vision","Fix-It","Tracking","Illumination","Sonar Smash","Truffle Shuffle","Vine Cut"]),
            new Character(67, "Hermione Granger"    , "Harry Potter",                            "hermione_granger.png",           ["Acrobat","Water Spray","Target","Laser Deflector","Diffindo","Illumination","Silver LEGO Blowup","Magic","Intelligence","Apparate Access","Hazard Cleaner","Growth"]),
            new Character(68, "Chase McCain"        , "LEGO City: Undercover",                   "chase.png",                      ["Acrobat","Grapple","Rope Swing","Tracking","Relic Detector","Uniform Changing","Illumination","Silver LEGO Blowup","Super Strength","Water Spray","Growth","Hazard Cleaner","Glide","Target","Hacking","Flying","Drill"]),
            new Character(69, "Excalibur Batman"    , "The LEGO Batman Movie",                   "excal_batman.png",               ["Boomerang","Sword Switch","Stealth","Laser Deflector","Grapple","Rope Swing","Super Strength","Master Build"]),

            new Character(70, "Raven"               , "Teen Titans Go!",                         "raven.png",                      ["Magic","Raven Portals","Flying","Laser","Electricity","Drone Mazes","Hazard Protection","Intelligence","Lantern Constructs"]),
            new Character(71, "Beast Boy"           , "Teen Titans Go!",                         "beast.png",                      ["Atlantis Elemental","Acrobat","Dig","Flying","Drone Mazes","Slurp Access","Mini Access","Tracking","Dive"]),
            new Character(72, "Beetlejuice"         , "Beetlejuice World",                       "beetlejuice_char.png",           ["Mind Control","Magic","Slurp Access","Illumination","Mini Access","Super Strength","Apparate Access"]),
//          new Character(73, "Unknown"             , "Unknown",                                 "",                               new List<string>() { "Unknown" }),
            new Character(74, "Blossom"             , "The Powerpuff Girls",                     "blossom.png",                    ["Flying","Lantern Constructs","Laser","Freeze Breath","Energy Shield","Intelligence","Super Strength","Dive","X-Ray Vision","Hearts Regenerate"]),
            new Character(75, "Bubbles"             , "The Powerpuff Girls",                     "bubbles.png",                    ["Flying","Laser","Lantern Constructs","Rainbow LEGO Objects","Sonar Smash","Parseltongue Doors","Super Strength","Dive","Atlantis Elemental","Hearts Regenerate"]),
            new Character(76, "Buttercup"           , "The Powerpuff Girls",                     "buttercup.png",                  ["Flying","Lantern Constructs","Super Strength","Super Strength Handles","Energy Shield","Gyrosphere Switch","Dive","Spinjitzu","Hearts Regenerate"]),
            new Character(77, "Starfire"            , "Teen Titans Go!",                         "starfire.png",                   ["Atlantis Elemental","Acrobat","Laser","Rainbow LEGO Objects","Dive","Flying","Parseltongue Doors","Hearts Regenerate"]),
//          new Character(78, "Unknown"             , "Unknown",                                 "",                               new List<string>() { "Unknown" }),
//          new Character(79, "Unknown"             , "Unknown",                                 "",                               new List<string>() { "Unknown" }),
//          new Character(80, "Unknown"             , "Unknown",                                 "",                               new List<string>() { "Unknown" }),

            new Character(769, "Supergirl Red Lantern", "DC Comics",                             "red_lantern.png",                ["Flying","Dive","Invulnerability","Super Strength","Laser","X-Ray Vision","Lantern Constructs","Dig","Grapple","Freeze Breath"]),
        ];

    }
}
