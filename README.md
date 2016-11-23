# IO.Severr - the C# library for the Severr API

Get your application events and errors to Severr via the *Severr API*.

- API version: 1.0.0
- SDK version: 1.0.0

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [IO.SeverrClient](http://www.nuget.org/packages/IO.SeverrClient/) - 1.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package IO.SeverrClient
```

## Getting Started

First setup a sample application and setup App.config to include your API key (see SeverrSampleApp project for an example).

```xml
&lt;configuration>
...
    &lt;appSettings>
      &lt;add key="severr.apiKey" value="a7a2807a2e8fd4602f70e9e8f819790a267213934083" />
      &lt;add key="severr.url" value="https://severr.io/api/v1/" />
      &lt;add key="severr.contextAppVersion" value="1.0" />
      &lt;add key="severr.contextEnvName" value="development"/>
    &lt;/appSettings>
&lt;/configuration>
```

And to send an exception to Severr, it's as simple as...

```csharp
using IO.SeverrClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeverrSampleApp
{
    /// &lt;summary>
    /// Sample program to generate an event
    /// &lt;/summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("This is a test exception.");
            }
            catch (Exception e)
            {
                // Send the event to Severr
                e.SendToSeverr();
            }
        }
    }
}
```

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AppEvent](https://github.com/severr/severr-csharp/blob/master/generated/docs/AppEvent.md)

