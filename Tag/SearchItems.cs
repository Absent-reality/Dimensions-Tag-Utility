using System.Collections.ObjectModel;

namespace DimensionsTagUtility
{
    /// <summary>
    /// Class to organize get items.
    /// </summary>
    public class SearchItems
    {
        public string? ItemName { get; set; }
        public ushort? Id { get; set; }

        /// <summary>
        /// Use to search through all tag info.
        /// </summary>
        /// <param name="filterText">String input of what to search for.</param>
        /// <returns>Returns an observable collection containing search results.</returns>
        public static ObservableCollection<SearchItems> SearchTags(string filterText)
        {
            ObservableCollection<SearchItems> totalTags = [];

            var charList = Character.Characters.FindAll(x => !string.IsNullOrWhiteSpace(x.Name) && x.Name.Contains(filterText, StringComparison.OrdinalIgnoreCase));
            var vehiList = Vehicle.Vehicles.FindAll(x => !string.IsNullOrWhiteSpace(x.Name) && x.Name.Contains(filterText, StringComparison.OrdinalIgnoreCase));

            if (charList == null || charList.Count <= 0)
            {
            }
            else
            {
                foreach (var x in charList)
                {
                    totalTags.Add(new SearchItems() { ItemName = x.Name, Id = x.Id });
                }
            }

            if (vehiList == null || vehiList.Count <= 0)
            {
            }
            else
            {
                foreach (var x in vehiList)
                {
                    totalTags.Add(new SearchItems() { ItemName = x.Name, Id = x.Id });
                }
            }

            return totalTags;
        }
    }
}
