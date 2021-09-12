using System;

namespace Vitorm.Hugin.Core
{
    public static class EnvironmentVariables
    {
        #region Index data
        
        public static string IndexName => Get("HUGIN_INDEX_NAME");
        public static string IndexUrl => Get("HUGIN_INDEX_URL");
        public static string IndexCurrencyCode => Get("HUGIN_INDEX_CURRENCYCODE");

        #endregion

        #region XPath

        public static string XPathName => Get("HUGIN_XPATH_NAME");
        public static string XPathLatestPrice => Get("HUGIN_XPATH_LATESTPRICE");
        public static string XPathDeltaPrice => Get("HUGIN_XPATH_DELTAPRICE");
        public static string XPathDeltaPricePercent => Get("HUGIN_XPATH_DELTAPRICEPERCENT");
        public static string XPathHighestPrice => Get("HUGIN_XPATH_HIGHESTPRICE");
        public static string XPathLowestPrice => Get("HUGIN_XPATH_LOWESTPRICE");
        public static string XPathVolume => Get("HUGIN_XPATH_VOLUME");
        public static string XPathMarketValue => Get("HUGIN_XPATH_MARKETVALUE");

        public static string XPathPriceToEarningsRatio => Get("HUGIN_XPATH_PRICETOEARNINGSRATIO");
        public static string XPathPriceToSalesRatio => Get("HUGIN_XPATH_PRICETOSALESRATIO");
        public static string XPathEarningsPerShare => Get("HUGIN_XPATH_EARNINGSPERSHARE");
        public static string XPathAdjustedEquityPerShare => Get("HUGIN_XPATH_ADJUSTEDEQUITYPERSHARE");
        public static string XPathDividendYield => Get("HUGIN_XPATH_DIVIDENDYIELD");
        public static string XPathDirectDividendPercent => Get("HUGIN_XPATH_DIRECTDIVIDENDPERCENT");

        #endregion

        #region Factors
        
        public static double VolumeFactor => Convert.ToDouble(Get("HUGIN_FACTOR_VOLUME") ?? "1.0");
        public static double MarketValueFactor => Convert.ToDouble(Get("HUGIN_FACTOR_MARKETVALUE") ?? "1.0");

        #endregion

        private static string Get(string name) => Environment.GetEnvironmentVariable(name);
    }
}