
namespace DimensionsTagUtility
{
    public class ToyTag : ILegoTag
    {
        /// <summary>
        /// The Id of the tag item.
        /// </summary>
        public ushort Id { get; set; }

        /// <summary>
        /// The Name of the tag item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The world associated with the tag item.
        /// </summary>
        public string World { get; set; }

        /// <summary>
        /// The list of abilities of the tag item.
        /// </summary>
        public List<string> Abilities { get; set; }

        /// <summary>
        /// Type of tag item.
        /// </summary>
        public ToyTagType ToyTagType { get; set; }

        public ToyTag(ushort id, string name, string world, List<string> abilites, ToyTagType toyType)
        {
            Id = id;
            Name = name;
            World = world;
            Abilities = abilites;
            ToyTagType = toyType;
        }

        /// <summary>
        /// Converts Character or Vehicle to a ToyTag object.
        /// Note: Drops images variable from character, and vehicle. Also drops form from vehicle.
        /// </summary>
        /// <param name="value">Character or vehicle object to convert.</param>
        /// <returns>ToyTag.</returns>
        public static ToyTag ConvertTo(object? value)
        {

            ArgumentNullException.ThrowIfNull(value);
            ToyTag? toy = new(0, "", "", [], ToyTagType.None);

            switch (value)
            {
                case Character character:
                    toy = new(character.Id, character.Name, character.World, character.Abilities, ToyTagType.Character);
                    break;

                case Vehicle vehicle:
                    toy = new(vehicle.Id, vehicle.Name, vehicle.World, vehicle.Abilities, ToyTagType.Vehicle);
                    break;
            }
            return toy;
        }

        /// <summary>
        /// Converts ToyTag to a Character or Vehicle object based on ToyTagType.
        /// </summary>
        /// <param name="value">ToyTag object to convert.</param>
        /// <returns>Character or Vehicle.</returns>
        public static object? ConvertFrom(ToyTag? value)
        {
            ArgumentNullException.ThrowIfNull(value);
            switch (value.ToyTagType)
            {
                case ToyTagType.None:
                    return value;

                case ToyTagType.Character:

                    if (value.Id == 0) return value;
                    var character = Character.Characters.FirstOrDefault(x => x.Id == value.Id);
                    return character;

                case ToyTagType.Vehicle:
                    if (value.Id == 0) return value;
                    var vehicle = Vehicle.Vehicles.FirstOrDefault(x => x.Id == value.Id);
                    return vehicle;
            }
            return value;
        }
    }
}
