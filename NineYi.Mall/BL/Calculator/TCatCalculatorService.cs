using NineYi.Mall.BE;

namespace NineYi.Mall.BL
{
    /// <summary>
    /// 黑貓運費計算器
    /// </summary>
    public class TCatCalculatorService : ICalculatorService
    {
        /// <summary>
        /// 計算運費
        /// </summary>
        /// <param name="deliveryItem">宅配資料</param>
        /// <returns>運費</returns>
        public double Calculate(DeliveryEntity deliveryItem)
        {
            var fee = 0d;
            var weight = deliveryItem.ProductWeight;
            if (weight > 20)
            {
                fee = 400d;
            }
            else
            {
                fee = 100 + (weight * 10);
            }

            return fee;
        }
    }
}
