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
	public class KalturaObject : KalturaObjectBase
	{
		#region Private Fields
		private Dictionary<string, KalturaListResponse> _RelatedObjects;
		#endregion

		#region Properties
		public Dictionary<string, KalturaListResponse> RelatedObjects
		{
			get { return _RelatedObjects; }
			set 
			{ 
				_RelatedObjects = value;
				OnPropertyChanged("RelatedObjects");
			}
		}
		#endregion

		#region CTor
		public KalturaObject()
		{
		}

		public KalturaObject(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "relatedObjects":
						{
							int index = 0;
							this.RelatedObjects = new Dictionary<string, KalturaListResponse>();
							foreach(XmlElement arrayNode in propertyNode.ChildNodes)
							{
								this.RelatedObjects[index.ToString()] = (KalturaListResponse)KalturaObjectFactory.Create(arrayNode, "KalturaListResponse");
								index++;
							}
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
			kparams.AddReplace("objectType", "KalturaObject");
			if (this.RelatedObjects != null)
			{
				if (this.RelatedObjects.Count == 0)
				{
					kparams.Add("relatedObjects:-", "");
				}
				else
				{
					foreach (KeyValuePair<string, KalturaListResponse> curEntry in this.RelatedObjects)
					{
						kparams.Add("relatedObjects:" + curEntry.Key, curEntry.Value.ToParams());
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

