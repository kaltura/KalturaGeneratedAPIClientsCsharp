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
	public class KalturaPlaybackContextResult : KalturaObjectBase
	{
		#region Private Fields
		private IList<KalturaPlaybackSource> _Sources;
		private IList<KalturaFlavorAsset> _FlavorAssets;
		private IList<KalturaString> _Messages;
		private IList<KalturaRuleAction> _Actions;
		private IList<KalturaPlaybackRestriction> _Restrictions;
		#endregion

		#region Properties
		public new IList<KalturaPlaybackSource> Sources
		{
			get { return _Sources; }
			set 
			{ 
				_Sources = value;
				OnPropertyChanged("Sources");
			}
		}
		public new IList<KalturaFlavorAsset> FlavorAssets
		{
			get { return _FlavorAssets; }
			set 
			{ 
				_FlavorAssets = value;
				OnPropertyChanged("FlavorAssets");
			}
		}
		public new IList<KalturaString> Messages
		{
			get { return _Messages; }
			set 
			{ 
				_Messages = value;
				OnPropertyChanged("Messages");
			}
		}
		public new IList<KalturaRuleAction> Actions
		{
			get { return _Actions; }
			set 
			{ 
				_Actions = value;
				OnPropertyChanged("Actions");
			}
		}
		public new IList<KalturaPlaybackRestriction> Restrictions
		{
			get { return _Restrictions; }
			set 
			{ 
				_Restrictions = value;
				OnPropertyChanged("Restrictions");
			}
		}
		#endregion

		#region CTor
		public KalturaPlaybackContextResult()
		{
		}

		public KalturaPlaybackContextResult(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "sources":
						this._Sources = new List<KalturaPlaybackSource>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Sources.Add((KalturaPlaybackSource)KalturaObjectFactory.Create(arrayNode, "KalturaPlaybackSource"));
						}
						continue;
					case "flavorAssets":
						this._FlavorAssets = new List<KalturaFlavorAsset>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._FlavorAssets.Add((KalturaFlavorAsset)KalturaObjectFactory.Create(arrayNode, "KalturaFlavorAsset"));
						}
						continue;
					case "messages":
						this._Messages = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Messages.Add((KalturaString)KalturaObjectFactory.Create(arrayNode, "KalturaString"));
						}
						continue;
					case "actions":
						this._Actions = new List<KalturaRuleAction>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Actions.Add((KalturaRuleAction)KalturaObjectFactory.Create(arrayNode, "KalturaRuleAction"));
						}
						continue;
					case "restrictions":
						this._Restrictions = new List<KalturaPlaybackRestriction>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Restrictions.Add((KalturaPlaybackRestriction)KalturaObjectFactory.Create(arrayNode, "KalturaPlaybackRestriction"));
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
			kparams.AddReplace("objectType", "KalturaPlaybackContextResult");
			kparams.AddIfNotNull("sources", this._Sources);
			kparams.AddIfNotNull("flavorAssets", this._FlavorAssets);
			kparams.AddIfNotNull("messages", this._Messages);
			kparams.AddIfNotNull("actions", this._Actions);
			kparams.AddIfNotNull("restrictions", this._Restrictions);
			return kparams;
		}
		#endregion
	}
}

