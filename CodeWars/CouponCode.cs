
// Story
// Your online store likes to give out coupons for special occasions. Some customers try to cheat the system by entering invalid codes or using expired coupons.
//
//     Task
//     Your mission:
//     Write a function called checkCoupon which verifies that a coupon code is valid and not expired.
//
//     A coupon is no more valid on the day AFTER the expiration date. All dates will be passed as strings in this format: "MONTH DATE, YEAR".
//
//     Examples:
//     CheckCoupon("123", "123", "July 9, 2015", "July 9, 2015")  ==  true
//     CheckCoupon("123", "123", "July 9, 2015", "July 2, 2015")  ==  false


using System;

namespace CodeWars
{
    public static class CouponCode
    {
        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {
           

           return enteredCode == correctCode &&
                  DateTime.Compare(Convert.ToDateTime(currentDate), Convert.ToDateTime(expirationDate)) <= 0;
          
        }
    }
}