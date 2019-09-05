using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.Data.Interface;
using DesignPattern.Data.Service;
using DesignPattern.Data.Strategy;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Controllers
{
    public class DesignPatternController : Controller
    {
        // 命名要規矩
        // 用IF的話要每個條件都要做判斷，等於電腦做了3次白工
        // 物件導向程式設計 容易維護(只需更改要改的地方) 容易複用(可以重複利用) 容易擴展(若要加功能只修增加某個地方就好了) 靈活性(可到處被人呼叫)
        // 透過封裝、繼承、多型把程式的耦合度降低
        // 把業務邏輯和介面分開
        // 增加演算法時不影響其他的程式碼
        // 物件導向的程式設計，並不是類別越多越好，類別的畫方式為了封裝，但分類的基礎是抽象，具有相同屬性和功能之物件的抽象集合才是類別

        // 簡單工廠模式
        public IActionResult SimpleFactoryPattern()
        {
            SimpleFactoryPattern simple = new SimpleFactoryPattern();
            return View();
        }

        // 策略模式 它定義了演算法家族，分別封裝起來，讓他們之間可以互相替換，此模式讓演算法的變化，不會影響到使用演算法的客戶
        // 用在經常會替換方法
        public IActionResult StrategyPattern()
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContentInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContentInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContentInterface();

            return View();
        }

        // 用商場收銀系統 策略與簡單工廠結合
        // 1.策略模式是一種定義一系列演算法的方法。從概念上來看，所有這些演算法完成的都是相同的工作，只能實現不同，
        // 它可以以相同的方法調用所有的演算法，減少了各種演算法類別與使用演算法類別之間的耦合[DPE]
        // 2.策略模式的優點是簡化了單元測試，因為每個演算法都有自己的類別，可以透過自己的介面單獨測試[DPE]
        // 3.當不同的行為堆切在一個類別中時，就很難避免使用條件敘述來選擇合適的行為。將這些行為封裝在一個個獨立的Strategy類別中，可以在這些行為的類別中消除條件敘述[DP]
        // 4.策略模式就是用來封裝演算法的，但在實踐中，我們發現可以用它來封裝幾乎任何類型的規則，只要在分析過程中聽到需要在不同時間應用不同的業務規則
        // 就可以考慮使用策略模式處理這種變化的可能性[DPE]
        // 5.在基本的策略模式中，選擇所用具體實現的職責由用戶端物件承擔，並轉給策略模式的Context物件[DPE]
        public IActionResult StrategyPatternV2(string type)
        {
            CashContext context = new CashContext(type);
            return View();
        }
    }
}