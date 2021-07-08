// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2021  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class BulkUploadBaseFilter : Filter
	{
		#region Constants
		public const string UPLOADED_ON_GREATER_THAN_OR_EQUAL = "uploadedOnGreaterThanOrEqual";
		public const string UPLOADED_ON_LESS_THAN_OR_EQUAL = "uploadedOnLessThanOrEqual";
		public const string UPLOADED_ON_EQUAL = "uploadedOnEqual";
		public const string STATUS_IN = "statusIn";
		public const string STATUS_EQUAL = "statusEqual";
		public const string BULK_UPLOAD_OBJECT_TYPE_EQUAL = "bulkUploadObjectTypeEqual";
		public const string BULK_UPLOAD_OBJECT_TYPE_IN = "bulkUploadObjectTypeIn";
		#endregion

		#region Private Fields
		private int _UploadedOnGreaterThanOrEqual = Int32.MinValue;
		private int _UploadedOnLessThanOrEqual = Int32.MinValue;
		private int _UploadedOnEqual = Int32.MinValue;
		private string _StatusIn = null;
		private BatchJobStatus _StatusEqual = (BatchJobStatus)Int32.MinValue;
		private BulkUploadObjectType _BulkUploadObjectTypeEqual = null;
		private string _BulkUploadObjectTypeIn = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use UploadedOnGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UploadedOnGreaterThanOrEqual
		{
			get { return _UploadedOnGreaterThanOrEqual; }
			set 
			{ 
				_UploadedOnGreaterThanOrEqual = value;
				OnPropertyChanged("UploadedOnGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use UploadedOnLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UploadedOnLessThanOrEqual
		{
			get { return _UploadedOnLessThanOrEqual; }
			set 
			{ 
				_UploadedOnLessThanOrEqual = value;
				OnPropertyChanged("UploadedOnLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use UploadedOnEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UploadedOnEqual
		{
			get { return _UploadedOnEqual; }
			set 
			{ 
				_UploadedOnEqual = value;
				OnPropertyChanged("UploadedOnEqual");
			}
		}
		/// <summary>
		/// Use StatusInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		/// <summary>
		/// Use StatusEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BatchJobStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		/// <summary>
		/// Use BulkUploadObjectTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BulkUploadObjectType BulkUploadObjectTypeEqual
		{
			get { return _BulkUploadObjectTypeEqual; }
			set 
			{ 
				_BulkUploadObjectTypeEqual = value;
				OnPropertyChanged("BulkUploadObjectTypeEqual");
			}
		}
		/// <summary>
		/// Use BulkUploadObjectTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string BulkUploadObjectTypeIn
		{
			get { return _BulkUploadObjectTypeIn; }
			set 
			{ 
				_BulkUploadObjectTypeIn = value;
				OnPropertyChanged("BulkUploadObjectTypeIn");
			}
		}
		#endregion

		#region CTor
		public BulkUploadBaseFilter()
		{
		}

		public BulkUploadBaseFilter(JToken node) : base(node)
		{
			if(node["uploadedOnGreaterThanOrEqual"] != null)
			{
				this._UploadedOnGreaterThanOrEqual = ParseInt(node["uploadedOnGreaterThanOrEqual"].Value<string>());
			}
			if(node["uploadedOnLessThanOrEqual"] != null)
			{
				this._UploadedOnLessThanOrEqual = ParseInt(node["uploadedOnLessThanOrEqual"].Value<string>());
			}
			if(node["uploadedOnEqual"] != null)
			{
				this._UploadedOnEqual = ParseInt(node["uploadedOnEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (BatchJobStatus)ParseEnum(typeof(BatchJobStatus), node["statusEqual"].Value<string>());
			}
			if(node["bulkUploadObjectTypeEqual"] != null)
			{
				this._BulkUploadObjectTypeEqual = (BulkUploadObjectType)StringEnum.Parse(typeof(BulkUploadObjectType), node["bulkUploadObjectTypeEqual"].Value<string>());
			}
			if(node["bulkUploadObjectTypeIn"] != null)
			{
				this._BulkUploadObjectTypeIn = node["bulkUploadObjectTypeIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkUploadBaseFilter");
			kparams.AddIfNotNull("uploadedOnGreaterThanOrEqual", this._UploadedOnGreaterThanOrEqual);
			kparams.AddIfNotNull("uploadedOnLessThanOrEqual", this._UploadedOnLessThanOrEqual);
			kparams.AddIfNotNull("uploadedOnEqual", this._UploadedOnEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("bulkUploadObjectTypeEqual", this._BulkUploadObjectTypeEqual);
			kparams.AddIfNotNull("bulkUploadObjectTypeIn", this._BulkUploadObjectTypeIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case UPLOADED_ON_GREATER_THAN_OR_EQUAL:
					return "UploadedOnGreaterThanOrEqual";
				case UPLOADED_ON_LESS_THAN_OR_EQUAL:
					return "UploadedOnLessThanOrEqual";
				case UPLOADED_ON_EQUAL:
					return "UploadedOnEqual";
				case STATUS_IN:
					return "StatusIn";
				case STATUS_EQUAL:
					return "StatusEqual";
				case BULK_UPLOAD_OBJECT_TYPE_EQUAL:
					return "BulkUploadObjectTypeEqual";
				case BULK_UPLOAD_OBJECT_TYPE_IN:
					return "BulkUploadObjectTypeIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

