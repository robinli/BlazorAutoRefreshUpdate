# Blazor App Auto Update

## About this
This repository provides the following three types of Blazor App, when you publish new version app, the browser/client will automatically update the new version.
-   Blazor Server App
-   Blazor WebAssembly App
-   Blazor WebAssembly App + PWA

In Balzor + PWA project, I create a dialog UI for software update message.

![Software Update UI](https://i.imgur.com/IR15aLk.png)


## Development
- Visual Studio 2022
- .NET 6.0
- Default Blazor project template


## Tracing Source Code

Search by **Find in Files** enter: `Auto Refresh Update Tip`
to view all code snippets。

![Find in Files](https://i.imgur.com/wzU4sgu.png)  
  
![Key in: Auto Refresh Update Tip](https://i.imgur.com/6WYaAZ4.png)  
  
![Find Result](https://i.imgur.com/st7s85A.png)  


## Step before publish 
To release a new version, you need to modify the following file version numbers, except Blazor Server App.

### Blazor Server App 
(none)

### Blazor WebAssembly App
-   appsettings.json
-   Index.razor (option, just for testing)
    
### Blazor WebAssembly App + PWA
-   appsettings.json
-   Toolbar.razor
-   service-worker.published.js
-   Index.razor (option, just for testing)


## Reference
Blazor Train YouTube video [Handling App Updates: Carl Franklin's Blazor Train Ep 60](https://www.youtube.com/watch?v=IdauS04L7H8)

[My Chinese blog - Blazor 發行後瀏覽器端自動重新載入網頁](https://note.robinks.net/2022/05/blazor-app-auto-update.html)