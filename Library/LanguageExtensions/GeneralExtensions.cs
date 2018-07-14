using System;
using System.Collections.Generic;

namespace Library.LanguageExtensions
{ 
    public static class GeneralExtensions
    {
        #region Generic

        /// <summary>
        /// Determine if a value is in a range inclusive.
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="pValue">Value to determine if in range</param>
        /// <param name="pLowerValue">Minimum value of T</param>
        /// <param name="pUpperValue">Maximum value of T</param>
        /// <returns>True if value is in range, false if value is not in range.</returns>
        public static bool Between<T>(this T pValue, T pLowerValue, T pUpperValue) =>
            Comparer<T>.Default.Compare(pValue, pLowerValue) >= 0 &&
            Comparer<T>.Default.Compare(pValue, pUpperValue) <= 0;

        #endregion
        #region non-generic
        // the following represent non-generic range extension methods

        /// <summary>
        /// Determine if a value is within range of int.
        /// </summary>
        /// <param name="pValue"></param>
        /// <param name="pLowerValue"></param>
        /// <param name="pUpperValue"></param>
        /// <param name="pInclusive"></param>
        /// <returns></returns>
        public static bool Between(this int pValue, int pLowerValue, int pUpperValue, bool pInclusive = false)
        {
            return pInclusive
                ? pLowerValue <= pValue && pValue <= pUpperValue
                : pLowerValue < pValue && pValue < pUpperValue;
        }
        /// <summary>
        /// Determine if a value is within range of double.
        /// </summary>
        /// <param name="pValue"></param>
        /// <param name="pLowerValue"></param>
        /// <param name="pUpperValue"></param>
        /// <param name="pInclusive"></param>
        /// <returns></returns>
        public static bool Between(this double pValue, double pLowerValue, double pUpperValue, bool pInclusive = false)
        {
            return pInclusive
                ? pLowerValue <= pValue && pValue <= pUpperValue
                : pLowerValue < pValue && pValue < pUpperValue;
        }
        /// <summary>
        /// Determine if a value is within range of DateTime.
        /// </summary>
        /// <param name="pValue"></param>
        /// <param name="pLowerValue"></param>
        /// <param name="pUpperValue"></param>
        /// <param name="pInclusive"></param>
        /// <returns></returns>
        public static bool Between(this DateTime pValue, DateTime pLowerValue, DateTime pUpperValue, bool pInclusive = false)
        {
            return pInclusive
                ? pLowerValue <= pValue && pValue <= pUpperValue
                : pLowerValue < pValue && pValue < pUpperValue;
        }

        #endregion
    }


}
