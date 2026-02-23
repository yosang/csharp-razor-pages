# Project
This is a simple setup of a Razor Pages application with C# and .NET.

This application is built from the ground up with the `web` template. 

# Razor Pages
Razor Pages follow a page-centric model (closer to MVVM — Model-View-ViewModel) rather than the controller-centric MVC pattern.
- Pages live under the `Pages` folder.
- Logic + Presentation lives in `PageModel` class (`.cshtml.cs`).
    - This is where we have our ViewModel with the endpoint methods.
- The `.cshtml` are the Views.
- Routing is mostly file based.

# Usage
1. Clone the repository with `git clone https://github.com/yosang/csharp-razor-pages`
1. Build the application with `dotnet build`
2. Run it with `dotnet run` / `dotnet watch` (for hot reload).

# Endpoints
- `/` - Index page
- `/Details/:id` - Product details by id

# Author
[Yosmel Chiang](https://github.com/yosang)