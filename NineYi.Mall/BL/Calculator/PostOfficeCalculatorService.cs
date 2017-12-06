using NineYi.Mall.BE;

namespace NineYi.Mall.BL.Calculator
{
    /// <summary>
    /// 郵局運費計算器
    /// </summary>
    public class PostOfficeCalculatorService : ICalculatorService
    {
        /// <summary>
        /// 計算運費
        /// </summary>
        /// <param name="deliveryItem">宅配資料</param>
        /// <returns>運費</returns>
        public double Calculate(DeliveryEntity deliveryItem)
        {
            var weight = deliveryItem.ProductWeight;
            var feeByWeight = 80 + (weight * 10);

            var length = deliveryItem.ProductLength;
            var width = deliveryItem.ProductWidth;
            var height = deliveryItem.ProductHeight;

            var size = length * width * height;

            var feeBySize = size * 0.00001 * 110;

            if (feeByWeight > feeBySize)
            {
                return feeByWeight;
            }

            return feeBySize;
        }
    }
}
