﻿using System;
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

        // 單一職責原則(SRP)，就一個類別而言，應該只有一個引起他變化的原因
        // 例如寫WinForm 會產生一個Form 於是把所有功能都寫在這上面，這就意味著，無論任何需求要來，都需要修改這個Form，這很糟糕，維護麻煩，複用不可能，缺乏靈活性
        // 如果一個類別承擔的職責過多，就等於把這些職責藕荷在一起，一個職責的變化可能會削弱或者抑制這個類別完成其他職責的能力。這種藕荷會導致脆弱的設計，當變化發生時，設計會遭受到意想不到的破壞
        // 所以要分出做不同的事情要不同的介面
        // 軟體設計真正要做的許多內容，就是發現職責並把那些職責相互分離
        // 如果想到多於一個的動機去改變一個類別，那麼這個類別就具有多於一個的職責，就該考慮類別職責分離
        // 無程式碼

        // 開放封閉原則
        // 在軟體設計模式中，這種不能修改，但可以擴展的概念也是最重要的一中設計原則，就是開放封閉原則或叫開閉原則
        // 開閉原則，是說軟體實體(類別，模組，函數等等)應該可以擴展，但不可修改
        // 2大特徵 1.對於擴展是開放的 2.對於更改是封閉的
        // 怎樣設計才能面對需求的改變卻可以保持相對穩定，從而使得系統在第一個版本以後不斷推出新的版本
        // 設計軟體要容易維護又不容易出錯的最好辦法就是多擴展少修改
        // 無論模組多麼地封閉，都會存在一些無法對之封閉的變化，既然不可能完全封閉，設計人員必須對於他設計的模組應該對哪種邊畫封閉做出選擇，他必須先猜測最有可能發生的變化種類然後構造抽象來隔離那些變化
        // 等到變化發生時，立即採取行動
        // 在我們最初編寫程式碼時，假設變化不會發生。當變化發生時，我們就建立抽象來隔離以後發生的同類變化，面對需求，對程式的改動是透過增加新程式碼進行的，而不是更改現有的程式碼
        // 開放封閉原則是物件導向設計的核心所在。遵循這個原則可以帶來物件導向技術所聲稱的巨大好處，也就是可維護，可擴展，可複用，靈活性好。開發人員應該僅對程式中頻繁變化的那些部分做出抽象，然而，對於應用程式中的每個部分都刻意地進行抽象同樣不是一個好主意。拒絕不成熟的抽象和抽象本身一樣重要
        // 無程式碼

    }
}