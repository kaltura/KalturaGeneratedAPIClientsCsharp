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
// Copyright (C) 2006-2015  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaDistributionValidationErrorInvalidData : KalturaDistributionValidationError
	{
		#region Private Fields
		private string _FieldName = null;
		private KalturaDistributionValidationErrorType _ValidationErrorType = (KalturaDistributionValidationErrorType)Int32.MinValue;
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
		public KalturaDistributionValidationErrorType ValidationErrorType
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
		public KalturaDistributionValidationErrorInvalidData()
		{
		}

		public KalturaDistributionValidationErrorInvalidData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "fieldName":
						this.FieldName = txt;
						continue;
					case "validationErrorType":
						this.ValidationErrorType = (KalturaDistributionValidationErrorType)ParseEnum(typeof(KalturaDistributionValidationErrorType), txt);
						continue;
					case "validationErrorParam":
						this.ValidationErrorParam = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDistributionValidationErrorInvalidData");
			kparams.AddStringIfNotNull("fieldName", this.FieldName);
			kparams.AddEnumIfNotNull("validationErrorType", this.ValidationErrorType);
			kparams.AddStringIfNotNull("validationErrorParam", this.ValidationErrorParam);
			return kparams;
		}
		#endregion
	}
}

