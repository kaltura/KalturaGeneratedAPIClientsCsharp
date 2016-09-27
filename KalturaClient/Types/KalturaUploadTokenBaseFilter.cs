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

namespace Kaltura
{
	public class KalturaUploadTokenBaseFilter : KalturaFilter
	{
		#region Private Fields
		private string _IdEqual = null;
		private string _IdIn = null;
		private string _UserIdEqual = null;
		private KalturaUploadTokenStatus _StatusEqual = (KalturaUploadTokenStatus)Int32.MinValue;
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
		public KalturaUploadTokenStatus StatusEqual
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
		public KalturaUploadTokenBaseFilter()
		{
		}

		public KalturaUploadTokenBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = txt;
						continue;
					case "idIn":
						this._IdIn = txt;
						continue;
					case "userIdEqual":
						this._UserIdEqual = txt;
						continue;
					case "statusEqual":
						this._StatusEqual = (KalturaUploadTokenStatus)ParseEnum(typeof(KalturaUploadTokenStatus), txt);
						continue;
					case "statusIn":
						this._StatusIn = txt;
						continue;
					case "fileNameEqual":
						this._FileNameEqual = txt;
						continue;
					case "fileSizeEqual":
						this._FileSizeEqual = ParseFloat(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
		#endregion
	}
}

