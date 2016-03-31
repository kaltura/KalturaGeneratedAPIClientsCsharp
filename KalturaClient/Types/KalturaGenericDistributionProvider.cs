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
	public class KalturaGenericDistributionProvider : KalturaDistributionProvider
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private bool? _IsDefault = null;
		private KalturaGenericDistributionProviderStatus _Status = (KalturaGenericDistributionProviderStatus)Int32.MinValue;
		private string _OptionalFlavorParamsIds = null;
		private string _RequiredFlavorParamsIds = null;
		private IList<KalturaDistributionThumbDimensions> _OptionalThumbDimensions;
		private IList<KalturaDistributionThumbDimensions> _RequiredThumbDimensions;
		private string _EditableFields = null;
		private string _MandatoryFields = null;
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
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
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
		public bool? IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		public KalturaGenericDistributionProviderStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public string OptionalFlavorParamsIds
		{
			get { return _OptionalFlavorParamsIds; }
			set 
			{ 
				_OptionalFlavorParamsIds = value;
				OnPropertyChanged("OptionalFlavorParamsIds");
			}
		}
		public string RequiredFlavorParamsIds
		{
			get { return _RequiredFlavorParamsIds; }
			set 
			{ 
				_RequiredFlavorParamsIds = value;
				OnPropertyChanged("RequiredFlavorParamsIds");
			}
		}
		public IList<KalturaDistributionThumbDimensions> OptionalThumbDimensions
		{
			get { return _OptionalThumbDimensions; }
			set 
			{ 
				_OptionalThumbDimensions = value;
				OnPropertyChanged("OptionalThumbDimensions");
			}
		}
		public IList<KalturaDistributionThumbDimensions> RequiredThumbDimensions
		{
			get { return _RequiredThumbDimensions; }
			set 
			{ 
				_RequiredThumbDimensions = value;
				OnPropertyChanged("RequiredThumbDimensions");
			}
		}
		public string EditableFields
		{
			get { return _EditableFields; }
			set 
			{ 
				_EditableFields = value;
				OnPropertyChanged("EditableFields");
			}
		}
		public string MandatoryFields
		{
			get { return _MandatoryFields; }
			set 
			{ 
				_MandatoryFields = value;
				OnPropertyChanged("MandatoryFields");
			}
		}
		#endregion

		#region CTor
		public KalturaGenericDistributionProvider()
		{
		}

		public KalturaGenericDistributionProvider(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "isDefault":
						this.IsDefault = ParseBool(txt);
						continue;
					case "status":
						this.Status = (KalturaGenericDistributionProviderStatus)ParseEnum(typeof(KalturaGenericDistributionProviderStatus), txt);
						continue;
					case "optionalFlavorParamsIds":
						this.OptionalFlavorParamsIds = txt;
						continue;
					case "requiredFlavorParamsIds":
						this.RequiredFlavorParamsIds = txt;
						continue;
					case "optionalThumbDimensions":
						this.OptionalThumbDimensions = new List<KalturaDistributionThumbDimensions>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.OptionalThumbDimensions.Add((KalturaDistributionThumbDimensions)KalturaObjectFactory.Create(arrayNode, "KalturaDistributionThumbDimensions"));
						}
						continue;
					case "requiredThumbDimensions":
						this.RequiredThumbDimensions = new List<KalturaDistributionThumbDimensions>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.RequiredThumbDimensions.Add((KalturaDistributionThumbDimensions)KalturaObjectFactory.Create(arrayNode, "KalturaDistributionThumbDimensions"));
						}
						continue;
					case "editableFields":
						this.EditableFields = txt;
						continue;
					case "mandatoryFields":
						this.MandatoryFields = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaGenericDistributionProvider");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("isDefault", this.IsDefault);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("optionalFlavorParamsIds", this.OptionalFlavorParamsIds);
			kparams.AddIfNotNull("requiredFlavorParamsIds", this.RequiredFlavorParamsIds);
			kparams.AddIfNotNull("optionalThumbDimensions", this.OptionalThumbDimensions);
			kparams.AddIfNotNull("requiredThumbDimensions", this.RequiredThumbDimensions);
			kparams.AddIfNotNull("editableFields", this.EditableFields);
			kparams.AddIfNotNull("mandatoryFields", this.MandatoryFields);
			return kparams;
		}
		#endregion
	}
}

