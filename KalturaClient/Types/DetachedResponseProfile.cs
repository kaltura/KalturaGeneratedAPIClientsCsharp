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
	public class DetachedResponseProfile : BaseResponseProfile
	{
		#region Constants
		public const string NAME = "name";
		public const string TYPE = "type";
		public const string FIELDS = "fields";
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		public const string RELATED_PROFILES = "relatedProfiles";
		public const string MAPPINGS = "mappings";
		#endregion

		#region Private Fields
		private string _Name = null;
		private ResponseProfileType _Type = (ResponseProfileType)Int32.MinValue;
		private string _Fields = null;
		private RelatedFilter _Filter;
		private FilterPager _Pager;
		private IList<DetachedResponseProfile> _RelatedProfiles;
		private IList<ResponseProfileMapping> _Mappings;
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
		public ResponseProfileType Type
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
		public RelatedFilter Filter
		{
			get { return _Filter; }
			set 
			{ 
				_Filter = value;
				OnPropertyChanged("Filter");
			}
		}
		public FilterPager Pager
		{
			get { return _Pager; }
			set 
			{ 
				_Pager = value;
				OnPropertyChanged("Pager");
			}
		}
		public IList<DetachedResponseProfile> RelatedProfiles
		{
			get { return _RelatedProfiles; }
			set 
			{ 
				_RelatedProfiles = value;
				OnPropertyChanged("RelatedProfiles");
			}
		}
		public IList<ResponseProfileMapping> Mappings
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
		public DetachedResponseProfile()
		{
		}

		public DetachedResponseProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "type":
						this._Type = (ResponseProfileType)ParseEnum(typeof(ResponseProfileType), propertyNode.InnerText);
						continue;
					case "fields":
						this._Fields = propertyNode.InnerText;
						continue;
					case "filter":
						this._Filter = ObjectFactory.Create<RelatedFilter>(propertyNode);
						continue;
					case "pager":
						this._Pager = ObjectFactory.Create<FilterPager>(propertyNode);
						continue;
					case "relatedProfiles":
						this._RelatedProfiles = new List<DetachedResponseProfile>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._RelatedProfiles.Add(ObjectFactory.Create<DetachedResponseProfile>(arrayNode));
						}
						continue;
					case "mappings":
						this._Mappings = new List<ResponseProfileMapping>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Mappings.Add(ObjectFactory.Create<ResponseProfileMapping>(arrayNode));
						}
						continue;
				}
			}
		}

		public DetachedResponseProfile(IDictionary<string,object> data) : base(data)
		{
			    this._Name = data.TryGetValueSafe<string>("name");
			    this._Type = (ResponseProfileType)ParseEnum(typeof(ResponseProfileType), data.TryGetValueSafe<int>("type"));
			    this._Fields = data.TryGetValueSafe<string>("fields");
			    this._Filter = ObjectFactory.Create<RelatedFilter>(data.TryGetValueSafe<IDictionary<string,object>>("filter"));
			    this._Pager = ObjectFactory.Create<FilterPager>(data.TryGetValueSafe<IDictionary<string,object>>("pager"));
			    this._RelatedProfiles = new List<DetachedResponseProfile>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("relatedProfiles", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._RelatedProfiles.Add(ObjectFactory.Create<DetachedResponseProfile>((IDictionary<string,object>)dataDictionary));
			    }
			    this._Mappings = new List<ResponseProfileMapping>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("mappings", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._Mappings.Add(ObjectFactory.Create<ResponseProfileMapping>((IDictionary<string,object>)dataDictionary));
			    }
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDetachedResponseProfile");
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("fields", this._Fields);
			kparams.AddIfNotNull("filter", this._Filter);
			kparams.AddIfNotNull("pager", this._Pager);
			kparams.AddIfNotNull("relatedProfiles", this._RelatedProfiles);
			kparams.AddIfNotNull("mappings", this._Mappings);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case NAME:
					return "Name";
				case TYPE:
					return "Type";
				case FIELDS:
					return "Fields";
				case FILTER:
					return "Filter";
				case PAGER:
					return "Pager";
				case RELATED_PROFILES:
					return "RelatedProfiles";
				case MAPPINGS:
					return "Mappings";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

