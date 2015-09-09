﻿using Bridge.Html5;

namespace Bridge.AngularJS
{
    //[Ignore] set on main definition
    public static partial class AngularJSExtensions
    {
        /// <summary>
        /// Sets the NG repeat to the element with the specified free text
        /// expression.
        /// </summary>
        /// <param name="el">Element to apply the ngRepeat to</param>
        /// <param name="expression">Valid ngRepeat AngularJS expression</param>
        /// <remarks>Must be used inside a ngController scope</remarks>
        [Template("{el}.setAttribute('ng-repeat', {expression})")]
        public static void SetNGRepeat(this Element el, string expression)
        {
        }

        /// <summary>
        /// Sets the NG repeat to the element with the specified iteration
        /// variable and iterated array names.
        /// </summary>
        /// <param name="el">Element to apply ngRepeat to</param>
        /// <param name="variable">Iteration variable</param>
        /// <param name="array">Existing array in the scoped controller.</param>
        /// <remarks>Must be used inside a ngController scope</remarks>
        [Template("{el}.setAttribute('ng-repeat', " +
            "'' + {variable} + ' in ' + {array})")]
        public static void SetNGRepeat(this Element el, string variable,
            string array)
        {
        }

        // FIXME: There are much more over Filter and OrderBy. Another approach
        //        will have to be taken.
        /// <summary>
        /// Sets the NG repeat to the element with the specified iteration
        /// variable, iterated array and filter input field.
        /// </summary>
        /// <param name="el">Element to apply ngRepeat to</param>
        /// <param name="variable">Iteration variable</param>
        /// <param name="array">Existing array in the scoped controller.</param>
        /// <param name="filterInputField">Filter input field.</param>
        /// <remarks>
        /// Must be used inside a ngController scope and input field for filter
        /// must be defined somewhere else in the page
        /// </remarks>
        [Template("{el}.setAttribute('ng-repeat', " +
                  "'' + {variable} + ' in ' + {array} + ' | " +
                  "filter:' + {filterInputField})")]
        public static void SetNGRepeatWithFilter(this Element el,
            string variable, string array, string filterInputField)
        {
        }


        /// <summary>
        /// Sets the NG repeat to the element with the specified iteration
        /// variable, iterated array, filter input and order input fields.
        /// </summary>
        /// <param name="el">Element to apply ngRepeat to.</param>
        /// <param name="variable">Iteration variable.</param>
        /// <param name="array">Existing array in the scoped controller.</param>
        /// <param name="filterInputField">Filter input field.</param>
        /// <param name="orderByInputField">Order by input field.</param>
        /// <remarks>
        /// Must be used inside a ngController scope and input field for filter
        /// must be defined somewhere else in the page
        /// </remarks>
        [Template("{el}.setAttribute('ng-repeat', " +
                  "'' + {variable} + ' in ' + {array} + ' | " +
                  "filter: ' + {filterInputField} + ' | " +
                  "orderBy: ' + {orderByInputField})")]
        public static void SetNGRepeat(this Element el, string variable,
            string array, string filterInputField, string orderByInputField)
        {
        }

        /// <summary>
        /// Sets the NG repeat to the element with the specified iteration
        /// variable, iterated array and OrderBy input field.
        /// </summary>
        /// <param name="el">El.</param>
        /// <param name="variable">Variable.</param>
        /// <param name="array">Array.</param>
        /// <param name="orderByInputField">Order by input field.</param>
        [Template("{el}.setAttribute('ng-repeat', " +
                  "'' + {variable} + ' in ' + {array} + ' | " +
                  "orderBy: ' + {orderByInputField})")]
        public static void SetNGRepeatWithOrderBy(this Element el,
            string variable, string array, string orderByInputField)
        {
        }

        /// <summary>
        /// Drops the NG repeat from the specified element.
        /// </summary>
        /// <param name="el">Element to drop the ngRepeat from.</param>
        [Template("{el}.removeAttribute('ng-repeat')")]
        public static void RemovepNGRepeat(this Element el)
        {
        }

        // TODO: a way to represent all the modifiers with actual 
        //       variables' references not string variables.
    }
}