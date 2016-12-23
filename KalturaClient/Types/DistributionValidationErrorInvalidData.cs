// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2016  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class DistributionValidationErrorInvalidData : DistributionValidationError
	{
		#region Constants
		public const string FIELD_NAME = "fieldName";
		public const string VALIDATION_ERROR_TYPE = "validationErrorType";
		public const string VALIDATION_ERROR_PARAM = "validationErrorParam";
		#endregion

		#region Private Fields
		private string _FieldName = null;
		private DistributionValidationErrorType _ValidationErrorType = (DistributionValidationErrorType)Int32.MinValue;
		private string _ValidationErrorParam = null;
		#endregion

		#region Properties
		public string FieldName
		{
			get { return _FieldName; }
			set 
			{ 
				_FieldName = value;
				OnPropertyChanged("FieldName");
			}
		}
		public DistributionValidationErrorType ValidationErrorType
		{
			get { return _ValidationErrorType; }
			set 
			{ 
				_ValidationErrorType = value;
				OnPropertyChanged("ValidationErrorType");
			}
		}
		public string ValidationErrorParam
		{
			get { return _ValidationErrorParam; }
			set 
			{ 
				_ValidationErrorParam = value;
				OnPropertyChanged("ValidationErrorParam");
			}
		}
		#endregion

		#region CTor
		public DistributionValidationErrorInvalidData()
		{
		}

		public DistributionValidationErrorInvalidData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "fieldName":
						this._FieldName = propertyNode.InnerText;
						continue;
					case "validationErrorType":
						this._ValidationErrorType = (DistributionValidationErrorType)ParseEnum(typeof(DistributionValidationErrorType), propertyNode.InnerText);
						continue;
					case "validationErrorParam":
						this._ValidationErrorParam = propertyNode.InnerText;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDistributionValidationErrorInvalidData");
			kparams.AddIfNotNull("fieldName", this._FieldName);
			kparams.AddIfNotNull("validationErrorType", this._ValidationErrorType);
			kparams.AddIfNotNull("validationErrorParam", this._ValidationErrorParam);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FIELD_NAME:
					return "FieldName";
				case VALIDATION_ERROR_TYPE:
					return "ValidationErrorType";
				case VALIDATION_ERROR_PARAM:
					return "ValidationErrorParam";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

