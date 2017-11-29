using System;
using NineYi.Mall.BE;

namespace NineYi.Mall.BL
{
    /// <summary>
    /// 宅配Service
    /// </summary>
    public class DeliveryService
    {
        /// <summary>
        /// 運費計算器
        /// </summary>
        private ICalculatorService _calculatorService;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryService"/> class.
        /// </summary>
        /// <param name="calculatorService">ICalculatorService</param>
        public DeliveryService(ICalculatorService calculatorService)
        {
            this._calculatorService = calculatorService;
        }

        /// <summary>
        /// 計算運費
        /// </summary>
        /// <param name="deliveryItem">宅配資料</param>
        /// <returns>運費</returns>
        public double Calculate(DeliveryEntity deliveryItem)
        {
            if (deliveryItem == null)
            {
                throw new ArgumentException("請檢查 deliveryItem 參數");
            }

            var fee = this._calculatorService.Calculate(deliveryItem);

            return fee;
        }
    }
}
