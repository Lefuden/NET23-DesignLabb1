namespace NET23_DesignLabb1.Singleton;
public sealed class ImportantData
{
    //simple representation of a Singleton
    private ImportantData() { }

    private static ImportantData? _importantData;

    public static ImportantData GetImportantData()
    {
        if (_importantData == null)
        {
            _importantData = new ImportantData();
        }
        return _importantData;
    }

    public void ShowImportantData()
    {
        Console.WriteLine("This is very important data contained in a Singleton");
    }
}


//public sealed class ImportantData
//{
//    //simple representation of a Singleton
//    private string? Message { get; set; }

//    //private ImportantData(){}
//    private ImportantData(string message)
//    {
//        Message = message;
//    }

//    private static ImportantData? _importantData;

//    public static ImportantData GetImportantData()
//    {
//        if (_importantData == null)
//        {
//            _importantData = new ImportantData("This is very important data contained in a Singleton");
//        }
//        return _importantData;
//    }

//    public string ShowImportantData()
//    {
//        return _importantData.Message;
//    }
//}