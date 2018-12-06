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
	public class EntryReplacementOptions : ObjectBase
	{
		#region Constants
		public const string KEEP_MANUAL_THUMBNAILS = "keepManualThumbnails";
		public const string PLUGIN_OPTION_ITEMS = "pluginOptionItems";
		#endregion

		#region Private Fields
		private int _KeepManualThumbnails = Int32.MinValue;
		private IList<PluginReplacementOptionsItem> _PluginOptionItems;
		#endregion

		#region Properties
		public int KeepManualThumbnails
		{
			get { return _KeepManualThumbnails; }
			set 
			{ 
				_KeepManualThumbnails = value;
				OnPropertyChanged("KeepManualThumbnails");
			}
		}
		public IList<PluginReplacementOptionsItem> PluginOptionItems
		{
			get { return _PluginOptionItems; }
			set 
			{ 
				_PluginOptionItems = value;
				OnPropertyChanged("PluginOptionItems");
			}
		}
		#endregion

		#region CTor
		public EntryReplacementOptions()
		{
		}

		public EntryReplacementOptions(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "keepManualThumbnails":
						this._KeepManualThumbnails = ParseInt(propertyNode.InnerText);
						continue;
					case "pluginOptionItems":
						this._PluginOptionItems = new List<PluginReplacementOptionsItem>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._PluginOptionItems.Add(ObjectFactory.Create<PluginReplacementOptionsItem>(arrayNode));
						}
						continue;
				}
			}
		}

		public EntryReplacementOptions(IDictionary<string,object> data) : base(data)
		{
			    this._KeepManualThumbnails = data.TryGetValueSafe<int>("keepManualThumbnails");
			    this._PluginOptionItems = new List<PluginReplacementOptionsItem>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("pluginOptionItems", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._PluginOptionItems.Add(ObjectFactory.Create<PluginReplacementOptionsItem>((IDictionary<string,object>)dataDictionary));
			    }
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryReplacementOptions");
			kparams.AddIfNotNull("keepManualThumbnails", this._KeepManualThumbnails);
			kparams.AddIfNotNull("pluginOptionItems", this._PluginOptionItems);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case KEEP_MANUAL_THUMBNAILS:
					return "KeepManualThumbnails";
				case PLUGIN_OPTION_ITEMS:
					return "PluginOptionItems";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

