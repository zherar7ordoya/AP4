[![CI Build](https://github.com/grantwinney/SurvivingWinForms/actions/workflows/dotnet.yml/badge.svg?branch=master)](https://github.com/grantwinney/SurvivingWinForms/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)
![Language](https://img.shields.io/github/languages/top/grantwinney/SurvivingWinForms.svg)
[![Twitter](https://img.shields.io/twitter/url/http/shields.io.svg)](https://twitter.com/intent/tweet?url=https%3A%2F%2Fgithub.com%2Fgrantwinney%2FSurvivingWinForms&text=We%27re%20stuck%20with%20it..%20let%27s%20make%20the%20best%20of%20it.&hashtags=winforms,csharp)

<img src="https://raw.githubusercontent.com/wiki/grantwinney/SurvivingWinForms/uploads/survival.jpg">

# Surviving WinForms

Let's face it, WinForms is here to stay. Whatever new hotness comes and goes in the world of web, many developers will find themselves supporting the desktop apps of yesteryear (or yesterdecade).

The apps work, representing thousands of hours of effort and business rules, fine-tuning and bug fixes, and companies won't needlessly convert anytime soon. In truth, it might not even be wise... an app converted to a new platform could very well introduce dozens or _hundreds_ of new bugs.

So to all my fellow devs that find themselves supporting the old coldness, let's make the best of it...

## Anti-Patterns

* Using nameof to avoid magic strings ([blog post](https://grantwinney.com/using-nameof-to-avoid-magic-strings), [source code](https://github.com/grantwinney/Surviving-WinForms/tree/master/AntiPatterns/MagicStrings/NameOfVersusMagicStrings))

## Debugging / Logging

* How to log errors in WinForms using NLog ([blog post](https://grantwinney.com/log-errors-in-winforms-with-nlog/), [source code](https://github.com/grantwinney/SurvivingWinForms/tree/master/Debugging/Logging/NLogUtility))
* A dev-friendly error box with links to the docs ([blog post](https://grantwinney.com/the-helpful-exception-box/), [source code](https://github.com/grantwinney/SurvivingWinForms/tree/master/Debugging/Misc/MessageBoxForDevs))

## Testing 

* Mocking the MessageBox ([blog post](https://grantwinney.com/mocking-messagebox-in-winforms/), [source code](https://github.com/grantwinney/SurvivingWinForms/tree/master/Testing/MockingMessageBox))
* Using MVP to test a WinForms app ([blog post](https://grantwinney.com/its-possible-to-test-a-winforms-app-using-mvp/), [source code](https://github.com/grantwinney/SurvivingWinForms/tree/master/Testing/MVP))

## Threading

* Using Async, Await, and Task to keep the WinForms UI responsive ([blog post](https://grantwinney.com/using-async-await-and-task-to-keep-the-winforms-ui-more-responsive/), [source code](https://github.com/grantwinney/SurvivingWinForms/tree/master/Threading/AsyncAwait))

## Web

* Hosting a simple webpage in WinForms with CEFSharp ([blog post](https://grantwinney.com/hosting-a-simple-webpage-in-winforms-with-cefsharp), [source code](https://github.com/grantwinney/SurvivingWinForms/tree/master/Web/CEFSharp/BasicCefSharp))

# Other Resources

Other interesting and helpful links, in no particular order:

* [WinForms source code for .NET Core](https://github.com/dotnet/winforms)
* [Top WinForms open source projects on GitHub](https://awesomeopensource.com/projects/winforms)
* [What's new in Windows Forms in .NET 6.0 - .NET Blog](https://devblogs.microsoft.com/dotnet/whats-new-in-windows-forms-in-net-6-0/) _(Igor Velikorossov)_
