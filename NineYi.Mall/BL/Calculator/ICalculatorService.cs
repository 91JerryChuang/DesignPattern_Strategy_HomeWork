using NineYi.Mall.BE;

namespace NineYi.Mall.BL
{
    /// <summary>
    /// 運費計算器
    /// </summary>
    public interface ICalculatorService
    {
        /// <summary>
        /// 計算運費
        /// </summary>
        /// <param name="deliveryItem">宅配資料</param>
        /// <returns>運費</returns>
        double Calculate(DeliveryEntity deliveryItem);
    }
}
