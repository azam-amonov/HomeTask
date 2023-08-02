namespace HomeWork_16.N16_HT2;
/*
- SmartHomeService dan foydalaning

unda quyidagi propertylar bo'lsin 
- IsActivated - hozir SmartHome ishlayotgan yoki yo'qligini bildiradi ( read-only )
- DeviceName - o'rnatilgan Smart Home markaziy boshqaruv qurilmasi nomi ( init-only )
- CurrentTemperature - temperatureni yozib borish uchun ( write-only )
- ExpectedTemperature - foydalanuvchi xohlayotgan temperaturani sozlash ( read-write )

unda quyidagi methodlar bo'lsin
- Activate methodi yordamida ishga tushiriladigan ( activate ) qilinadigan bo'lsin
- DisplayHomeTemperature - bunda vaqt davomida foydalanuvchi xohlagan va SmartHome ta'minlay olgan temperatura chiqsin

- temperaturani expected va current qiymatlarini saqlash uchun Temperature modelidan foydalanish mumkin
 */

/*Temperature model yaratdim
 3 ta feidl ochdim
 
*/
public class SmartHomeService
{
    
    // Data List
    private List<TemperatureModel> _tempModels = new List<TemperatureModel>();
    
    // Feildlar
    private bool _isActive;
    private string _deviceName;
    private TemperatureModel _temperature;
    
    // Properylar
    public bool IsActive => _isActive;
    public string DeviceName { get; init; }

    public int CurrentTemperature
    {
        set => _temperature.CurrentTemperature = value; 
    }
    
    public int ExpectedTemperature{ get; set; }

    // Constructor
    public SmartHomeService(string deviceName)
    {
        DeviceName = deviceName;
        Add(23, 25);
        Add(22, 25);
        Add(23, 25);
        Add(22, 25);
        Add(24, 25);
        Add(22, 25);
    }

    public void Add(int current, int expected)
    {
        _tempModels.Add(new TemperatureModel
        {
                        CurrentTemperature = current,
                        ExpectedTemperature = expected
        });
    }

    public void Activate(bool enabled)
    {
        _isActive = enabled;
        if(_isActive)
            Console.WriteLine("SmartHomeService is activated!");
        else
            Console.WriteLine("SmartHomeService is Deactivated!");
    }

    public void DisplayTemperature()
    {
        foreach (var t in _tempModels)
        {
            Console.WriteLine($"Expected {t.ExpectedTemperature}˚C => Current {t.CurrentTemperature}˚C");
        }
    }
    
    
    
}