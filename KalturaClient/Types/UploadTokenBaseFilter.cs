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
	public class UploadTokenBaseFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string USER_ID_EQUAL = "userIdEqual";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string FILE_NAME_EQUAL = "fileNameEqual";
		public const string FILE_SIZE_EQUAL = "fileSizeEqual";
		#endregion

		#region Private Fields
		private string _IdEqual = null;
		private string _IdIn = null;
		private string _UserIdEqual = null;
		private UploadTokenStatus _StatusEqual = (UploadTokenStatus)Int32.MinValue;
		private string _StatusIn = null;
		private string _FileNameEqual = null;
		private double _FileSizeEqual = Double.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		/// <summary>
		/// Use IdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		/// <summary>
		/// Use UserIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserIdEqual
		{
			get { return _UserIdEqual; }
			set 
			{ 
				_UserIdEqual = value;
				OnPropertyChanged("UserIdEqual");
			}
		}
		/// <summary>
		/// Use StatusEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public UploadTokenStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
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
		/// Use FileNameEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileNameEqual
		{
			get { return _FileNameEqual; }
			set 
			{ 
				_FileNameEqual = value;
				OnPropertyChanged("FileNameEqual");
			}
		}
		/// <summary>
		/// Use FileSizeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		[Obsolete("Use FileSizeEqualAsDouble property instead")]
		public float FileSizeEqual
		{
			get { return (float)_FileSizeEqual; }
			set 
			{ 
				_FileSizeEqual = value;
				OnPropertyChanged("FileSizeEqual");
			}
		}
		///<summary>
		///Use this property FileSizeEqualAsDouble instead of the float FileSizeEqual property version
		///</summary>
		[JsonProperty]
		public double FileSizeEqualAsDouble
		{
			get { return _FileSizeEqual; }
			set 
			{ 
				_FileSizeEqual = value;
				OnPropertyChanged("FileSizeEqual");
			}
		}
		#endregion

		#region CTor
		public UploadTokenBaseFilter()
		{
		}

		public UploadTokenBaseFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = node["idEqual"].Value<string>();
			}
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["userIdEqual"] != null)
			{
				this._UserIdEqual = node["userIdEqual"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (UploadTokenStatus)ParseEnum(typeof(UploadTokenStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["fileNameEqual"] != null)
			{
				this._FileNameEqual = node["fileNameEqual"].Value<string>();
			}
			if(node["fileSizeEqual"] != null)
			{
				this._FileSizeEqual = ParseDouble(node["fileSizeEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUploadTokenBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("userIdEqual", this._UserIdEqual);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("fileNameEqual", this._FileNameEqual);
			kparams.AddIfNotNull("fileSizeEqual", this._FileSizeEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_EQUAL:
					return "IdEqual";
				case ID_IN:
					return "IdIn";
				case USER_ID_EQUAL:
					return "UserIdEqual";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case FILE_NAME_EQUAL:
					return "FileNameEqual";
				case FILE_SIZE_EQUAL:
					return "FileSizeEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

