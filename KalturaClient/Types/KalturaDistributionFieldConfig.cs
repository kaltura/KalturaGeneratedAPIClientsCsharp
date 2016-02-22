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
	public class KalturaDistributionFieldConfig : KalturaObjectBase
	{
		#region Private Fields
		private string _FieldName = null;
		private string _UserFriendlyFieldName = null;
		private string _EntryMrssXslt = null;
		private KalturaDistributionFieldRequiredStatus _IsRequired = (KalturaDistributionFieldRequiredStatus)Int32.MinValue;
		private bool? _UpdateOnChange = false;
		private IList<KalturaString> _UpdateParams;
		private bool? _IsDefault = false;
		private bool? _TriggerDeleteOnError = false;
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
		public string UserFriendlyFieldName
		{
			get { return _UserFriendlyFieldName; }
			set 
			{ 
				_UserFriendlyFieldName = value;
				OnPropertyChanged("UserFriendlyFieldName");
			}
		}
		public string EntryMrssXslt
		{
			get { return _EntryMrssXslt; }
			set 
			{ 
				_EntryMrssXslt = value;
				OnPropertyChanged("EntryMrssXslt");
			}
		}
		public KalturaDistributionFieldRequiredStatus IsRequired
		{
			get { return _IsRequired; }
			set 
			{ 
				_IsRequired = value;
				OnPropertyChanged("IsRequired");
			}
		}
		public bool? UpdateOnChange
		{
			get { return _UpdateOnChange; }
			set 
			{ 
				_UpdateOnChange = value;
				OnPropertyChanged("UpdateOnChange");
			}
		}
		public IList<KalturaString> UpdateParams
		{
			get { return _UpdateParams; }
			set 
			{ 
				_UpdateParams = value;
				OnPropertyChanged("UpdateParams");
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
		public bool? TriggerDeleteOnError
		{
			get { return _TriggerDeleteOnError; }
			set 
			{ 
				_TriggerDeleteOnError = value;
				OnPropertyChanged("TriggerDeleteOnError");
			}
		}
		#endregion

		#region CTor
		public KalturaDistributionFieldConfig()
		{
		}

		public KalturaDistributionFieldConfig(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "fieldName":
						this.FieldName = txt;
						continue;
					case "userFriendlyFieldName":
						this.UserFriendlyFieldName = txt;
						continue;
					case "entryMrssXslt":
						this.EntryMrssXslt = txt;
						continue;
					case "isRequired":
						this.IsRequired = (KalturaDistributionFieldRequiredStatus)ParseEnum(typeof(KalturaDistributionFieldRequiredStatus), txt);
						continue;
					case "updateOnChange":
						this.UpdateOnChange = ParseBool(txt);
						continue;
					case "updateParams":
						this.UpdateParams = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.UpdateParams.Add((KalturaString)KalturaObjectFactory.Create(arrayNode, "KalturaString"));
						}
						continue;
					case "isDefault":
						this.IsDefault = ParseBool(txt);
						continue;
					case "triggerDeleteOnError":
						this.TriggerDeleteOnError = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDistributionFieldConfig");
			kparams.AddIfNotNull("fieldName", this.FieldName);
			kparams.AddIfNotNull("userFriendlyFieldName", this.UserFriendlyFieldName);
			kparams.AddIfNotNull("entryMrssXslt", this.EntryMrssXslt);
			kparams.AddIfNotNull("isRequired", this.IsRequired);
			kparams.AddIfNotNull("updateOnChange", this.UpdateOnChange);
			kparams.AddIfNotNull("updateParams", this.UpdateParams);
			kparams.AddIfNotNull("isDefault", this.IsDefault);
			kparams.AddIfNotNull("triggerDeleteOnError", this.TriggerDeleteOnError);
			return kparams;
		}
		#endregion
	}
}

