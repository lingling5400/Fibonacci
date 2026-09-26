using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fibonacci_sequence_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string n)
        {
            if (string.IsNullOrWhiteSpace(n))
            {
                ViewBag.Error = "請輸入數字";
                return View();
            }

            if (!int.TryParse(n.Trim(), out int number))
            {
                ViewBag.Error = "請輸入有效的整數";
                return View();
            }

            try
            {
                int result = Fibonacci(number);

                ViewBag.Result = result;

                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Error = "計算時發生錯誤：" + ex.Message;
                return View();
            }
        }


        private int Fibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
/*
Controller 流程註解:

Index功能：

接收使用者輸入的 n
驗證 n 是否為空值或空白
確認輸入內容是否可以轉換為整數
若可以轉換，將轉換後的數值命名為 number
呼叫 Fibonacci(number) 進行計算
將計算結果指定給 result
使用 ViewBag.Result = result 將結果傳遞給 View
若驗證或計算過程發生錯誤，將錯誤訊息傳回 View 顯示



Fibonacci功能：

使用遞迴方式計算費波那契數列
當 n <= 2 時回傳 1
否則透過：
Fibonacci(n - 1) + Fibonacci(n - 2)
持續遞迴計算



View 流程註解：

設定網頁頁籤名稱
設定頁面標題
顯示初始畫面
輸入框
「計算」按鈕
將使用者輸入的資料送給 Controller
接收 Controller 計算完成後透過 ViewBag.Result 傳回的結果
將計算結果顯示在畫面上
若 Controller 傳回錯誤訊息，則顯示錯誤訊息
*/
