
# HelperMathMethods

To install the package, run the following command in the terminal:

```bash
NuGet\Install-Package HelperMathMethods
```

## Usage

```csharp
You need to add the service in Program.cs or during service registration

// Register the service to the DI container
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

