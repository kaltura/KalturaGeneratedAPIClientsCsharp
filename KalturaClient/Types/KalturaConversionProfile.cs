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
	public class KalturaConversionProfile : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private KalturaConversionProfileStatus _Status = null;
		private KalturaConversionProfileType _Type = null;
		private string _Name = null;
		private string _SystemName = null;
		private string _Tags = null;
		private string _Description = null;
		private string _DefaultEntryId = null;
		private int _CreatedAt = Int32.MinValue;
		private string _FlavorParamsIds = null;
		private KalturaNullableBoolean _IsDefault = (KalturaNullableBoolean)Int32.MinValue;
		private bool? _IsPartnerDefault = false;
		private KalturaCropDimensions _CropDimensions;
		private int _ClipStart = Int32.MinValue;
		private int _ClipDuration = Int32.MinValue;
		private string _XslTransformation = null;
		private int _StorageProfileId = Int32.MinValue;
		private KalturaMediaParserType _MediaParserType = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public KalturaConversionProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaConversionProfileType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string DefaultEntryId
		{
			get { return _DefaultEntryId; }
			set 
			{ 
				_DefaultEntryId = value;
				OnPropertyChanged("DefaultEntryId");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public string FlavorParamsIds
		{
			get { return _FlavorParamsIds; }
			set 
			{ 
				_FlavorParamsIds = value;
				OnPropertyChanged("FlavorParamsIds");
			}
		}
		public KalturaNullableBoolean IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		public bool? IsPartnerDefault
		{
			get { return _IsPartnerDefault; }
			set 
			{ 
				_IsPartnerDefault = value;
				OnPropertyChanged("IsPartnerDefault");
			}
		}
		public KalturaCropDimensions CropDimensions
		{
			get { return _CropDimensions; }
			set 
			{ 
				_CropDimensions = value;
				OnPropertyChanged("CropDimensions");
			}
		}
		public int ClipStart
		{
			get { return _ClipStart; }
			set 
			{ 
				_ClipStart = value;
				OnPropertyChanged("ClipStart");
			}
		}
		public int ClipDuration
		{
			get { return _ClipDuration; }
			set 
			{ 
				_ClipDuration = value;
				OnPropertyChanged("ClipDuration");
			}
		}
		public string XslTransformation
		{
			get { return _XslTransformation; }
			set 
			{ 
				_XslTransformation = value;
				OnPropertyChanged("XslTransformation");
			}
		}
		public int StorageProfileId
		{
			get { return _StorageProfileId; }
			set 
			{ 
				_StorageProfileId = value;
				OnPropertyChanged("StorageProfileId");
			}
		}
		public KalturaMediaParserType MediaParserType
		{
			get { return _MediaParserType; }
			set 
			{ 
				_MediaParserType = value;
				OnPropertyChanged("MediaParserType");
			}
		}
		#endregion

		#region CTor
		public KalturaConversionProfile()
		{
		}

		public KalturaConversionProfile(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "status":
						this.Status = (KalturaConversionProfileStatus)KalturaStringEnum.Parse(typeof(KalturaConversionProfileStatus), txt);
						continue;
					case "type":
						this.Type = (KalturaConversionProfileType)KalturaStringEnum.Parse(typeof(KalturaConversionProfileType), txt);
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "systemName":
						this.SystemName = txt;
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "defaultEntryId":
						this.DefaultEntryId = txt;
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "flavorParamsIds":
						this.FlavorParamsIds = txt;
						continue;
					case "isDefault":
						this.IsDefault = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "isPartnerDefault":
						this.IsPartnerDefault = ParseBool(txt);
						continue;
					case "cropDimensions":
						this.CropDimensions = (KalturaCropDimensions)KalturaObjectFactory.Create(propertyNode, "KalturaCropDimensions");
						continue;
					case "clipStart":
						this.ClipStart = ParseInt(txt);
						continue;
					case "clipDuration":
						this.ClipDuration = ParseInt(txt);
						continue;
					case "xslTransformation":
						this.XslTransformation = txt;
						continue;
					case "storageProfileId":
						this.StorageProfileId = ParseInt(txt);
						continue;
					case "mediaParserType":
						this.MediaParserType = (KalturaMediaParserType)KalturaStringEnum.Parse(typeof(KalturaMediaParserType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaConversionProfile");
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringEnumIfNotNull("status", this.Status);
			kparams.AddStringEnumIfNotNull("type", this.Type);
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddStringIfNotNull("systemName", this.SystemName);
			kparams.AddStringIfNotNull("tags", this.Tags);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddStringIfNotNull("defaultEntryId", this.DefaultEntryId);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddStringIfNotNull("flavorParamsIds", this.FlavorParamsIds);
			kparams.AddEnumIfNotNull("isDefault", this.IsDefault);
			kparams.AddBoolIfNotNull("isPartnerDefault", this.IsPartnerDefault);
			if (this.CropDimensions != null)
				kparams.Add("cropDimensions", this.CropDimensions.ToParams());
			kparams.AddIntIfNotNull("clipStart", this.ClipStart);
			kparams.AddIntIfNotNull("clipDuration", this.ClipDuration);
			kparams.AddStringIfNotNull("xslTransformation", this.XslTransformation);
			kparams.AddIntIfNotNull("storageProfileId", this.StorageProfileId);
			kparams.AddStringEnumIfNotNull("mediaParserType", this.MediaParserType);
			return kparams;
		}
		#endregion
	}
}

