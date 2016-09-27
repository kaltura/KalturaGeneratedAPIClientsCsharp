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
	public class KalturaModifyCategoriesObjectTask : KalturaObjectTask
	{
		#region Private Fields
		private KalturaScheduledTaskAddOrRemoveType _AddRemoveType = (KalturaScheduledTaskAddOrRemoveType)Int32.MinValue;
		private IList<KalturaIntegerValue> _CategoryIds;
		#endregion

		#region Properties
		public KalturaScheduledTaskAddOrRemoveType AddRemoveType
		{
			get { return _AddRemoveType; }
			set 
			{ 
				_AddRemoveType = value;
				OnPropertyChanged("AddRemoveType");
			}
		}
		public new IList<KalturaIntegerValue> CategoryIds
		{
			get { return _CategoryIds; }
			set 
			{ 
				_CategoryIds = value;
				OnPropertyChanged("CategoryIds");
			}
		}
		#endregion

		#region CTor
		public KalturaModifyCategoriesObjectTask()
		{
		}

		public KalturaModifyCategoriesObjectTask(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "addRemoveType":
						this._AddRemoveType = (KalturaScheduledTaskAddOrRemoveType)ParseEnum(typeof(KalturaScheduledTaskAddOrRemoveType), txt);
						continue;
					case "categoryIds":
						this._CategoryIds = new List<KalturaIntegerValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._CategoryIds.Add((KalturaIntegerValue)KalturaObjectFactory.Create(arrayNode, "KalturaIntegerValue"));
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
			kparams.AddReplace("objectType", "KalturaModifyCategoriesObjectTask");
			kparams.AddIfNotNull("addRemoveType", this._AddRemoveType);
			kparams.AddIfNotNull("categoryIds", this._CategoryIds);
			return kparams;
		}
		#endregion
	}
}

