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
	public class KalturaDetachedResponseProfile : KalturaBaseResponseProfile
	{
		#region Private Fields
		private string _Name = null;
		private KalturaResponseProfileType _Type = (KalturaResponseProfileType)Int32.MinValue;
		private string _Fields = null;
		private KalturaRelatedFilter _Filter;
		private KalturaFilterPager _Pager;
		private IList<KalturaDetachedResponseProfile> _RelatedProfiles;
		private IList<KalturaResponseProfileMapping> _Mappings;
		#endregion

		#region Properties
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public KalturaResponseProfileType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string Fields
		{
			get { return _Fields; }
			set 
			{ 
				_Fields = value;
				OnPropertyChanged("Fields");
			}
		}
		public KalturaRelatedFilter Filter
		{
			get { return _Filter; }
			set 
			{ 
				_Filter = value;
				OnPropertyChanged("Filter");
			}
		}
		public KalturaFilterPager Pager
		{
			get { return _Pager; }
			set 
			{ 
				_Pager = value;
				OnPropertyChanged("Pager");
			}
		}
		public IList<KalturaDetachedResponseProfile> RelatedProfiles
		{
			get { return _RelatedProfiles; }
			set 
			{ 
				_RelatedProfiles = value;
				OnPropertyChanged("RelatedProfiles");
			}
		}
		public IList<KalturaResponseProfileMapping> Mappings
		{
			get { return _Mappings; }
			set 
			{ 
				_Mappings = value;
				OnPropertyChanged("Mappings");
			}
		}
		#endregion

		#region CTor
		public KalturaDetachedResponseProfile()
		{
		}

		public KalturaDetachedResponseProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "name":
						this.Name = txt;
						continue;
					case "type":
						this.Type = (KalturaResponseProfileType)ParseEnum(typeof(KalturaResponseProfileType), txt);
						continue;
					case "fields":
						this.Fields = txt;
						continue;
					case "filter":
						this.Filter = (KalturaRelatedFilter)KalturaObjectFactory.Create(propertyNode, "KalturaRelatedFilter");
						continue;
					case "pager":
						this.Pager = (KalturaFilterPager)KalturaObjectFactory.Create(propertyNode, "KalturaFilterPager");
						continue;
					case "relatedProfiles":
						this.RelatedProfiles = new List<KalturaDetachedResponseProfile>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.RelatedProfiles.Add((KalturaDetachedResponseProfile)KalturaObjectFactory.Create(arrayNode, "KalturaDetachedResponseProfile"));
						}
						continue;
					case "mappings":
						this.Mappings = new List<KalturaResponseProfileMapping>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Mappings.Add((KalturaResponseProfileMapping)KalturaObjectFactory.Create(arrayNode, "KalturaResponseProfileMapping"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDetachedResponseProfile");
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("type", this.Type);
			kparams.AddIfNotNull("fields", this.Fields);
			kparams.AddIfNotNull("filter", this.Filter);
			kparams.AddIfNotNull("pager", this.Pager);
			kparams.AddIfNotNull("relatedProfiles", this.RelatedProfiles);
			kparams.AddIfNotNull("mappings", this.Mappings);
			return kparams;
		}
		#endregion
	}
}

