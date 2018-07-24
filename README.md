#  .NET/C# 開發實戰 掌握相依性注入的觀念與開發技巧

練習專案說明

|專案名稱|專案說明|備註|
|-|-|-|
|InversionOfControl|程式執行流程反轉控制 Inversion of Control 之情境練習|共有兩個專案，分別是：主控制台應用專案 ControOverTheFlowOfAProgram 與 WPF 的 GUI 事件驅動專案 InversionTheFlowOfProgram|
|InversionOfControlOO|物件導向設計之反轉控制 Inversion of Control 之情境練習|練習如何在物件導向設計中進行反轉控制、學習工廠方法之設計模式的用法|
|-|-|-|
|ConcreteClass|正多邊形之週長與面積 使用類別|實作練習 ： 類別繼承、抽象類別繼承、介面實作|
|AbstractClass|正邊形之週長與面積 抽象類別|實作練習 ： 類別繼承、抽象類別繼承、介面實作|
|InterfaceImplementation|正多邊形之週長與面積 使用介面|實作練習 ： 類別繼承、抽象類別繼承、介面實作|
|InterfaceExplicitImp|實作介面 / 明確介面實作 練習|在此練習中，分別使用 實作介面 與 以明確方式實作介面 兩個操作，了解這兩者介面實作的差異|
|ServiceLocatorDependencyInjection|服務定位與手動相依性注入練習|體驗本課程的精神，本練習共需要開發三個專案來演練|
|DependencyInversion|相依反轉原則 DIP 之情境練習|違反 DIP 的例子 與 使用抽象型別解決此一問題|
|PoorManDI|窮人 DI (或稱 Pure DI) 練習|設計出一個 DI 機制，具有註冊抽象型別與具體型別能力，並且可以解析出抽象型別的具體實作物件|
|FirstUnity|DI 容器的使用 : Unity|體驗如何安裝與使用 Unity 之 IoC Container|
|FirstAutofac|DI 容器的使用 : Autofac |體驗如何安裝與使用 Autofac 之 IoC Container|
|FirstStructureMap|DI 容器的使用 : StructureMap|體驗如何安裝與使用 StructureMap 之 IoC Container|
|FirstNinject|DI 容器的使用 : Ninject|體驗如何安裝與使用 StructureMap 之 IoC Ninject|
|FirstNetCore|DI 容器的使用 : .NET Core|體驗如何安裝與使用 .NET Core 之 IoC Ninject|
|UnityDI|三種相依性注入的使用操作練習 : Unity|體驗如何做到這三種注入(建構式、屬性、方法)的用法|
|DeepResolve|深層解析練習 : Unity|透過 Facade pattern 與配合深層解析，達到減少建構式參數的問題|
|RegisterTypeNamed|具名註冊與解析 : Unity|使用具名註冊與解析技術，在進行註冊與解析的時候，指定一個名稱  / 使用 IUnityContainer. Registrations 查看該 IoC 容器內的註冊項目清單|
|MultiConstructor|多建構函式的對應Unity|在本練習中，將會想要指定類別內多個建構式的其中一個，作為預設注入使用的建構函式|
|InjectingValue|建構式參或屬性數需要有常數: Unity|當要注入的物件，是個數值型別物件或者是字串，我們要學習，其建構式需要在進行型別對應註冊的時候，指定這些要注入的常數值|
|InjectingObject|註冊既有物件 : Unity|在本練習中，我們將會注入我們自己產生的物件到建構式內|
|LifetimeManager|不同物件生命週期管理練習 : Unity|在本練習中，我們將會使用 Unity 物件生命週期管理類別，告知 IoC 容易要如何建立與釋放物件|
|UnityInterception|注入物件之攔截練習 : Unity|在本練習中，將會使用 IoC 容器的攔截功能，加入進需要注入的物件內|
|ASPNETMVC5Unity|在 ASP.NET MVC 5 中使用相依性注入 : Unity|本練習將會建立一個 ASP.NET MVC 5 專案，並且使用 Unity IoC Container 來實作相依性注入開發|
|ASPWebFormsUnity|在 ASP.NET Web.Forms 中使用相依性注入 : Unity|本練習將會建立一個 ASP.NET Web Form 專案，並且使用 Unity IoC Container 來實作相依性注入開發|
|UnityAutoRegistration|Unity IoC 容器自動註冊|使用 IUnityContainer. RegisterTypes 根據自動搜尋組件內的型別與相關設定，自動進行 IoC 容器的型別對應註冊|
|UnityConfigurationXML|Unity IoC 容器 使用 XML 註冊|使用 App.config 來定義需要註冊的介面與具體實作型別，並且在建立 IoC 容器之後，LoadConfiguration讀取該 XML 相關設定，自動進行 IoC 容器的型別對應註冊|
||||
