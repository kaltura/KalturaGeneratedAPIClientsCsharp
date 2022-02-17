// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class IndexTagsByPrivacyContextJobData : JobData
	{
		#region Constants
		public const string CHANGED_CATEGORY_ID = "changedCategoryId";
		public const string DELETED_PRIVACY_CONTEXTS = "deletedPrivacyContexts";
		public const string ADDED_PRIVACY_CONTEXTS = "addedPrivacyContexts";
		#endregion

		#region Private Fields
		private int _ChangedCategoryId = Int32.MinValue;
		private string _DeletedPrivacyContexts = null;
		private string _AddedPrivacyContexts = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ChangedCategoryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ChangedCategoryId
		{
			get { return _ChangedCategoryId; }
			set 
			{ 
				_ChangedCategoryId = value;
				OnPropertyChanged("ChangedCategoryId");
			}
		}
		/// <summary>
		/// Use DeletedPrivacyContextsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DeletedPrivacyContexts
		{
			get { return _DeletedPrivacyContexts; }
			set 
			{ 
				_DeletedPrivacyContexts = value;
				OnPropertyChanged("DeletedPrivacyContexts");
			}
		}
		/// <summary>
		/// Use AddedPrivacyContextsAsDouble property instead
		/// </summary>
		[JsonProperty]
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
		public IndexTagsByPrivacyContextJobData()
		{
		}

		public IndexTagsByPrivacyContextJobData(JToken node) : base(node)
		{
			if(node["changedCategoryId"] != null)
			{
				this._ChangedCategoryId = ParseInt(node["changedCategoryId"].Value<string>());
			}
			if(node["deletedPrivacyContexts"] != null)
			{
				this._DeletedPrivacyContexts = node["deletedPrivacyContexts"].Value<string>();
			}
			if(node["addedPrivacyContexts"] != null)
			{
				this._AddedPrivacyContexts = node["addedPrivacyContexts"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIndexTagsByPrivacyContextJobData");
			kparams.AddIfNotNull("changedCategoryId", this._ChangedCategoryId);
			kparams.AddIfNotNull("deletedPrivacyContexts", this._DeletedPrivacyContexts);
			kparams.AddIfNotNull("addedPrivacyContexts", this._AddedPrivacyContexts);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CHANGED_CATEGORY_ID:
					return "ChangedCategoryId";
				case DELETED_PRIVACY_CONTEXTS:
					return "DeletedPrivacyContexts";
				case ADDED_PRIVACY_CONTEXTS:
					return "AddedPrivacyContexts";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

