using NineYi.Mall.BE;

namespace NineYi.Mall.BL
{
    /// <summary>
    /// 大榮運費計算器
    /// </summary>
    public class KTJCalculatorService : ICalculatorService
    {
        /// <summary>
        /// 計算運費
        /// </summary>
        /// <param name="deliveryItem">宅配資料</param>
        /// <returns>運費</returns>
        public double Calculate(DeliveryEntity deliveryItem)
        {
            var length = deliveryItem.ProductLength;
            var width = deliveryItem.ProductWidth;
            var height = deliveryItem.ProductHeight;

            var size = length * width * height;

            var fee = 0d;

            if (length > 50 || width > 50 || height > 50)
            {
                fee = (size * 0.00001 * 110) + 50;
            }
            else
            {
                fee = size * 0.00001 * 120;
            }

            return fee;
        }
    }
}
