using System.Diagnostics;
using Microsoft.Extensions.Configuration;

Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt"))));

Trace.AutoFlush = true;


Debug.WriteLine("Debug says, I'm debugging!");
Trace.WriteLine("Trace says, I am watching");

ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json",
        optional: true, reloadOnChange: true);
IConfiguration configuration = builder.Build();

TraceSwitch ts = new(displayName: "PacktSwitch", description: "This switch is set via a JSON config.");

configuration.GetSection("PacktSwitch").Bind(ts);
Trace.WriteLineIf(ts.TraceError, "Trace error");
Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace information");
Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");