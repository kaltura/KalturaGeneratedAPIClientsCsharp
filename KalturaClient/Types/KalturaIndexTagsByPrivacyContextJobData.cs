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
	public class KalturaIndexTagsByPrivacyContextJobData : KalturaJobData
	{
		#region Private Fields
		private int _ChangedCategoryId = Int32.MinValue;
		private string _DeletedPrivacyContexts = null;
		private string _AddedPrivacyContexts = null;
		#endregion

		#region Properties
		public int ChangedCategoryId
		{
			get { return _ChangedCategoryId; }
			set 
			{ 
				_ChangedCategoryId = value;
				OnPropertyChanged("ChangedCategoryId");
			}
		}
		public string DeletedPrivacyContexts
		{
			get { return _DeletedPrivacyContexts; }
			set 
			{ 
				_DeletedPrivacyContexts = value;
				OnPropertyChanged("DeletedPrivacyContexts");
			}
		}
		public string AddedPrivacyContexts
		{
			get { return _AddedPrivacyContexts; }
			set 
			{ 
				_AddedPrivacyContexts = value;
				OnPropertyChanged("AddedPrivacyContexts");
			}
		}
		#endregion

		#region CTor
		public KalturaIndexTagsByPrivacyContextJobData()
		{
		}

		public KalturaIndexTagsByPrivacyContextJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "changedCategoryId":
						this.ChangedCategoryId = ParseInt(txt);
						continue;
					case "deletedPrivacyContexts":
						this.DeletedPrivacyContexts = txt;
						continue;
					case "addedPrivacyContexts":
						this.AddedPrivacyContexts = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaIndexTagsByPrivacyContextJobData");
			kparams.AddIntIfNotNull("changedCategoryId", this.ChangedCategoryId);
			kparams.AddStringIfNotNull("deletedPrivacyContexts", this.DeletedPrivacyContexts);
			kparams.AddStringIfNotNull("addedPrivacyContexts", this.AddedPrivacyContexts);
			return kparams;
		}
		#endregion
	}
}

