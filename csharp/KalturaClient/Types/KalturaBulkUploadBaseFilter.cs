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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaBulkUploadBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _UploadedOnGreaterThanOrEqual = Int32.MinValue;
		private int _UploadedOnLessThanOrEqual = Int32.MinValue;
		private int _UploadedOnEqual = Int32.MinValue;
		private string _StatusIn = null;
		private KalturaBatchJobStatus _StatusEqual = (KalturaBatchJobStatus)Int32.MinValue;
		private KalturaBulkUploadObjectType _BulkUploadObjectTypeEqual = null;
		private string _BulkUploadObjectTypeIn = null;
		#endregion

		#region Properties
		public int UploadedOnGreaterThanOrEqual
		{
			get { return _UploadedOnGreaterThanOrEqual; }
			set 
			{ 
				_UploadedOnGreaterThanOrEqual = value;
				OnPropertyChanged("UploadedOnGreaterThanOrEqual");
			}
		}
		public int UploadedOnLessThanOrEqual
		{
			get { return _UploadedOnLessThanOrEqual; }
			set 
			{ 
				_UploadedOnLessThanOrEqual = value;
				OnPropertyChanged("UploadedOnLessThanOrEqual");
			}
		}
		public int UploadedOnEqual
		{
			get { return _UploadedOnEqual; }
			set 
			{ 
				_UploadedOnEqual = value;
				OnPropertyChanged("UploadedOnEqual");
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
		public KalturaBatchJobStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public KalturaBulkUploadObjectType BulkUploadObjectTypeEqual
		{
			get { return _BulkUploadObjectTypeEqual; }
			set 
			{ 
				_BulkUploadObjectTypeEqual = value;
				OnPropertyChanged("BulkUploadObjectTypeEqual");
			}
		}
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
		public KalturaBulkUploadBaseFilter()
		{
		}

		public KalturaBulkUploadBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "uploadedOnGreaterThanOrEqual":
						this.UploadedOnGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "uploadedOnLessThanOrEqual":
						this.UploadedOnLessThanOrEqual = ParseInt(txt);
						continue;
					case "uploadedOnEqual":
						this.UploadedOnEqual = ParseInt(txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaBatchJobStatus)ParseEnum(typeof(KalturaBatchJobStatus), txt);
						continue;
					case "bulkUploadObjectTypeEqual":
						this.BulkUploadObjectTypeEqual = (KalturaBulkUploadObjectType)KalturaStringEnum.Parse(typeof(KalturaBulkUploadObjectType), txt);
						continue;
					case "bulkUploadObjectTypeIn":
						this.BulkUploadObjectTypeIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBulkUploadBaseFilter");
			kparams.AddIntIfNotNull("uploadedOnGreaterThanOrEqual", this.UploadedOnGreaterThanOrEqual);
			kparams.AddIntIfNotNull("uploadedOnLessThanOrEqual", this.UploadedOnLessThanOrEqual);
			kparams.AddIntIfNotNull("uploadedOnEqual", this.UploadedOnEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringEnumIfNotNull("bulkUploadObjectTypeEqual", this.BulkUploadObjectTypeEqual);
			kparams.AddStringIfNotNull("bulkUploadObjectTypeIn", this.BulkUploadObjectTypeIn);
			return kparams;
		}
		#endregion
	}
}

