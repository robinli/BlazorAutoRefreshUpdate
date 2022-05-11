# Blazor 發行後瀏覽器端自動重新載入網頁

## 前言
這個範例提供以下三種 Blazor 型態發行新版程式時，瀏覽器(用戶端)可以自動重新整理網址取得新版程式。
-   Blazor Server App
-   Blazor WebAssembly App
-   Blazor WebAssembly App + PWA

主要是參考 Blazor Train 教學影片 [Handling App Updates: Carl Franklin's Blazor Train Ep 60](https://www.youtube.com/watch?v=IdauS04L7H8)
改版為 .NET 6.0，另外 PWA 專案有提供介面

![Software Update UI](https://i.imgur.com/IR15aLk.png)


## 開發環境
- Visual Studio 2022
- .NET 6.0
- 預設的 Blazor 範本


## 追蹤程式碼

程式碼修改細節，可以透過 Find in Files 輸入 `Auto Refresh Update Tip`
檢視所有程式碼片段。

![Find in Files](https://i.imgur.com/wzU4sgu.png)  
  
![Key in: Auto Refresh Update Tip](https://i.imgur.com/6WYaAZ4.png)  
  
![Find Result](https://i.imgur.com/st7s85A.png)  


## 發行程序
### Blazor Server App 
不用修改任何檔案。

### Blazor WebAssembly App
-   appsettings.json 文檔中的版號
-   Index.razor (非必要)
    
### Blazor WebAssembly App + PWA 發行新版本需要修改以下檔案版號

-   appsettings.json
-   Toolbar.razor
-   service-worker.published.js
-   Index.razor (非必要)


## 參考資源
Blazor Train 教學影片 [Handling App Updates: Carl Franklin's Blazor Train Ep 60](https://www.youtube.com/watch?v=IdauS04L7H8)
