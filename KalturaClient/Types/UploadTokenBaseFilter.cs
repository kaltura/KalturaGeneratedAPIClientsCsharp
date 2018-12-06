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
// Copyright (C) 2006-2018  Kaltura Inc.
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
		private float _FileSizeEqual = Single.MinValue;
		#endregion

		#region Properties
		public string IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		public string UserIdEqual
		{
			get { return _UserIdEqual; }
			set 
			{ 
				_UserIdEqual = value;
				OnPropertyChanged("UserIdEqual");
			}
		}
		public UploadTokenStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public string FileNameEqual
		{
			get { return _FileNameEqual; }
			set 
			{ 
				_FileNameEqual = value;
				OnPropertyChanged("FileNameEqual");
			}
		}
		public float FileSizeEqual
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

		public UploadTokenBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = propertyNode.InnerText;
						continue;
					case "idIn":
						this._IdIn = propertyNode.InnerText;
						continue;
					case "userIdEqual":
						this._UserIdEqual = propertyNode.InnerText;
						continue;
					case "statusEqual":
						this._StatusEqual = (UploadTokenStatus)ParseEnum(typeof(UploadTokenStatus), propertyNode.InnerText);
						continue;
					case "statusIn":
						this._StatusIn = propertyNode.InnerText;
						continue;
					case "fileNameEqual":
						this._FileNameEqual = propertyNode.InnerText;
						continue;
					case "fileSizeEqual":
						this._FileSizeEqual = ParseFloat(propertyNode.InnerText);
						continue;
				}
			}
		}

		public UploadTokenBaseFilter(IDictionary<string,object> data) : base(data)
		{
			    this._IdEqual = data.TryGetValueSafe<string>("idEqual");
			    this._IdIn = data.TryGetValueSafe<string>("idIn");
			    this._UserIdEqual = data.TryGetValueSafe<string>("userIdEqual");
			    this._StatusEqual = (UploadTokenStatus)ParseEnum(typeof(UploadTokenStatus), data.TryGetValueSafe<int>("statusEqual"));
			    this._StatusIn = data.TryGetValueSafe<string>("statusIn");
			    this._FileNameEqual = data.TryGetValueSafe<string>("fileNameEqual");
			    this._FileSizeEqual = data.TryGetValueSafe<float>("fileSizeEqual");
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

