
# HelperMathMethods

Paketi yükləmək üçün aşağıdakı commandı terminalda işlədin

```bash
NuGet\Install-Package HelperMathMethods
```

## Usage

```csharp
Program.cs içində servisi add etmək lazımdır və ya service registration içində

// Servisi DI container'a əlavə et
builder.Services.AddMathService();
```

## Example Usage
```CSharp
public class HomeController : Controller
{
    private readonly IMathMethodsService _mathService;

    public HomeController(IMathMethodsService mathService)
    {
        _mathService = mathService;
    }

    public IActionResult Index()
    {
        var result = _mathService.SumToInteger(5,7);
        return Content(result); // Output: 12
    }
}
```

