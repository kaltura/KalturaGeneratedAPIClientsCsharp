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
	public class DirectoryRestriction : BaseRestriction
	{
		#region Constants
		public const string DIRECTORY_RESTRICTION_TYPE = "directoryRestrictionType";
		#endregion

		#region Private Fields
		private DirectoryRestrictionType _DirectoryRestrictionType = (DirectoryRestrictionType)Int32.MinValue;
		#endregion

		#region Properties
		public DirectoryRestrictionType DirectoryRestrictionType
		{
			get { return _DirectoryRestrictionType; }
			set 
			{ 
				_DirectoryRestrictionType = value;
				OnPropertyChanged("DirectoryRestrictionType");
			}
		}
		#endregion

		#region CTor
		public DirectoryRestriction()
		{
		}

		public DirectoryRestriction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "directoryRestrictionType":
						this._DirectoryRestrictionType = (DirectoryRestrictionType)ParseEnum(typeof(DirectoryRestrictionType), propertyNode.InnerText);
						continue;
				}
			}
		}

		public DirectoryRestriction(IDictionary<string,object> data) : base(data)
		{
			    this._DirectoryRestrictionType = (DirectoryRestrictionType)ParseEnum(typeof(DirectoryRestrictionType), data.TryGetValueSafe<int>("directoryRestrictionType"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDirectoryRestriction");
			kparams.AddIfNotNull("directoryRestrictionType", this._DirectoryRestrictionType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DIRECTORY_RESTRICTION_TYPE:
					return "DirectoryRestrictionType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

