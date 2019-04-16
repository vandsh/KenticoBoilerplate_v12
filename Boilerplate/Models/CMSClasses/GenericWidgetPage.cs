﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using KMVCHelper.Models;

[assembly: RegisterDocumentType(GenericWidgetPage.CLASS_NAME, typeof(GenericWidgetPage))]

namespace KMVCHelper.Models
{
    /// <summary>
    /// Represents a content item of type GenericWidgetPage.
    /// </summary>
    public partial class GenericWidgetPage : TreeNode
    {
        #region "Constants and variables"

        /// <summary>
        /// The name of the data class.
        /// </summary>
        public const string CLASS_NAME = "KMVCHelper.GenericWidgetPage";


        /// <summary>
        /// The instance of the class that provides extended API for working with GenericWidgetPage fields.
        /// </summary>
        private readonly GenericWidgetPageFields mFields;

        #endregion


        #region "Properties"

        /// <summary>
        /// GenericWidgetPageID.
        /// </summary>
        [DatabaseIDField]
        public int GenericWidgetPageID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("GenericWidgetPageID"), 0);
            }
            set
            {
                SetValue("GenericWidgetPageID", value);
            }
        }


        /// <summary>
        /// The Layout (MVC View) that you wish to use.
        /// </summary>
        [DatabaseField]
        public string Layout
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Layout"), @"Index");
            }
            set
            {
                SetValue("Layout", value);
            }
        }


        /// <summary>
        /// Gets an object that provides extended API for working with GenericWidgetPage fields.
        /// </summary>
        [RegisterProperty]
        public GenericWidgetPageFields Fields
        {
            get
            {
                return mFields;
            }
        }


        /// <summary>
        /// Provides extended API for working with GenericWidgetPage fields.
        /// </summary>
        [RegisterAllProperties]
        public partial class GenericWidgetPageFields : AbstractHierarchicalObject<GenericWidgetPageFields>
        {
            /// <summary>
            /// The content item of type GenericWidgetPage that is a target of the extended API.
            /// </summary>
            private readonly GenericWidgetPage mInstance;


            /// <summary>
            /// Initializes a new instance of the <see cref="GenericWidgetPageFields" /> class with the specified content item of type GenericWidgetPage.
            /// </summary>
            /// <param name="instance">The content item of type GenericWidgetPage that is a target of the extended API.</param>
            public GenericWidgetPageFields(GenericWidgetPage instance)
            {
                mInstance = instance;
            }


            /// <summary>
            /// GenericWidgetPageID.
            /// </summary>
            public int ID
            {
                get
                {
                    return mInstance.GenericWidgetPageID;
                }
                set
                {
                    mInstance.GenericWidgetPageID = value;
                }
            }


            /// <summary>
            /// The Layout (MVC View) that you wish to use.
            /// </summary>
            public string Layout
            {
                get
                {
                    return mInstance.Layout;
                }
                set
                {
                    mInstance.Layout = value;
                }
            }
        }

        #endregion


        #region "Constructors"

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericWidgetPage" /> class.
        /// </summary>
        public GenericWidgetPage() : base(CLASS_NAME)
        {
            mFields = new GenericWidgetPageFields(this);
        }

        #endregion
    }
}