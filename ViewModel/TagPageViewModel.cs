using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Alerts;
using System.Collections.ObjectModel;
using System.Text;

namespace DimensionsTagUtility;

public partial class TagPageViewModel : ObservableObject
{

    private string _query = "";
    public string Query
    {
        get { return _query; }
        set
        {
            if (_query == value) return;
            _query = value;
            OnPropertyChanged();
            ResetForms();
            QueryItems();
        }
    }

    private readonly byte[] vehicleBlock = [0x00, 0x01, 0x00, 0x00];
    private readonly byte[] emptyBlock = [0x00, 0x00, 0x00, 0x00];

    private const string _versionNumber = "Ver: 1.0.1";
    public string VersionNumber => _versionNumber;

    [ObservableProperty]
    bool _isDisplayed = false;

    [ObservableProperty]
    string _UidError = "";

    [ObservableProperty]
    string _searchError = "";

    [ObservableProperty]
    string results = "";

    [ObservableProperty]
    SearchItems? selectedItem;

    private byte[] _Uid = [];
    public byte[] Uid
    {
        get { return _Uid; }
        set
        {
            if (_Uid == value) return;
            _Uid = value;
            OnPropertyChanged();
            ResetForms();
            UidError = "";
        }
    }

    [ObservableProperty]
    byte[] _page0x24 = [];

    [ObservableProperty]
    byte[] _page0x25 = [];

    [ObservableProperty]
    byte[] _page0x26 = [];

    [ObservableProperty]
    byte[] _page0x2b = [];

    [ObservableProperty]
    ObservableCollection<SearchItems> _listItems = [];

    void ResetForms()
    {
        SearchError = "";
        (Page0x24, Page0x25, Page0x26, Page0x2b) = ([], [], [], []);
    }

    void QueryItems()
    {
        //Begin the digging for matches. 
        ListItems.Clear();

        if (Query == "")
        {
            Results = "";
            ListItems = [];
            return;
        }

        var items = SearchItems.SearchTags(Query);
        IsDisplayed = true;
        if (items == null || items.Count == 0)
        {
            ListItems.Add(new SearchItems() { ItemName = "Name not found." });
            Results = $" Results: {0} ";
        }
        else
        {
            ListItems = items;
            Results = $" Results: {ListItems.Count} ";
        }
    }

    [RelayCommand]
    void ItemSelected(string itemName)
    {
#if ANDROID
        HapticFeedback.Default.Perform(HapticFeedbackType.LongPress);
#endif
        if (itemName == "") return;

        Query = itemName;
        IsDisplayed = false;
        Results = "";
        SearchError = "";
    }

    [RelayCommand]
    void Search()
    {
        if (Query == "") { ReportError(ErrorType.Search); return; }

        ToyTag toy = new ToyTag(0, "", "", [], ToyTagType.None);

        var thisItem = ListItems.FirstOrDefault(x => x.ItemName == Query);
        if (thisItem == null) { ReportError(ErrorType.Search); return; }

        if (thisItem.Id == null || thisItem.ItemName == null) return;

        switch (thisItem.Id.Value)
        {
            case <= 999:
                Character? character = Character.Characters.FirstOrDefault(m => m.Id == thisItem.Id);
                if (character == null) return;

                toy = ToyTag.ConvertTo(character);
                break;

            case > 999:
                Vehicle? vehicle = Vehicle.Vehicles.FirstOrDefault(m => m.Id == thisItem.Id);
                if (vehicle == null) return;

                Vehicle? vehicleToLoad;
                switch (vehicle.Form)
                {
                    case 1:
                        toy = ToyTag.ConvertTo(vehicle);
                        break;

                    case 2:
                        vehicleToLoad = Vehicle.Vehicles.FirstOrDefault(v => v.Id == vehicle.Id - 1);
                        if (vehicleToLoad != null) toy = ToyTag.ConvertTo(vehicleToLoad);

                        break;

                    case 3:
                        vehicleToLoad = Vehicle.Vehicles.FirstOrDefault(x => x.Id == vehicle.Id - 2);
                        if (vehicleToLoad != null) toy = ToyTag.ConvertTo(vehicleToLoad);

                        break;
                }
                break;
        }
        if (toy.Name == "") { return; }
        GetPageValues(Uid, toy);
    }

    private void GetPageValues(byte[] Uid, ToyTag toy)
    {
        if (Uid == null || Uid.Length == 0) { ReportError(ErrorType.Uid); return; }
        if (toy == null) return;

        byte[] AuthenticationKey = LegoTagTools.GenerateCardPassword(Uid);
        Page0x2b = [0xA2, 0x2B, .. AuthenticationKey];

        switch (toy.ToyTagType)
        {
            case ToyTagType.Character:
                {
                    // Get the encrypted character ID
                    var car = LegoTagTools.EncrypCharactertId(Uid, toy.Id);
                    Page0x24 = [0xA2, 0x24, .. car.AsSpan(0, 4).ToArray()];
                    Page0x25 = [0xA2, 0x25, .. car.AsSpan(4, 4).ToArray()];
                    Page0x26 = [0xA2, 0x26, .. emptyBlock];

                }
                break;

            case ToyTagType.Vehicle:
                {
                    // Get the encrypted vehicle ID
                    var vec = LegoTagTools.EncryptVehicleId(toy.Id);
                    Page0x24 = [0xA2, 0x24, .. vec];
                    Page0x25 = [0xA2, 0x25, .. emptyBlock];
                    Page0x26 = [0xA2, 0x26, .. vehicleBlock];

                }
                break;
        }

    }

    [RelayCommand]
    async Task CopyPages()
    { 
        var allPages = new[] { Page0x24, Page0x25, Page0x26, Page0x2b };
           await CopyToClipBoard([.. allPages.Select(FormatBytes)]);
    }

    void ReportError(ErrorType error)
    {
        switch (error)
        {
            case ErrorType.Uid:
                UidError = "Insert valid tag Uid.";
                break;

            case ErrorType.Search:
                SearchError = "Invalid Character or Vehicle.";
                break;
        }
    }

    string FormatBytes(byte[] data) =>
    BitConverter.ToString(data).Replace("-", ":");

    async Task CopyToClipBoard(string[] text)
    {  
        StringBuilder message = new();

        if (text is null) { return; }
        foreach (string s in text)
        { 
            message.AppendLine(s); 
        }

        if (Clipboard.Default.HasText)
        { 
            await ClearClipboard();
        }
               
        await Clipboard.Default.SetTextAsync(message.ToString());  
    }

    private async Task ClearClipboard()
    {
        await Clipboard.Default.SetTextAsync(null);
    }

}
