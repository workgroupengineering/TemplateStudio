namespace Param_RootNamespace.Desktop
open System
open Avalonia
//{--{
open Avalonia.ReactiveUI
//}--}
open Param_RootNamespace

module Program =

    [<CompiledName "BuildAvaloniaApp">] 
    let buildAvaloniaApp () = 
        AppBuilder
            .Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace(areas = Array.empty)
//{--{
            .UseReactiveUI()
//}--}

    [<EntryPoint; STAThread>]
    let main argv =
        buildAvaloniaApp().StartWithClassicDesktopLifetime(argv)
