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
	public class PreviewRestriction : SessionRestriction
	{
		#region Constants
		public const string PREVIEW_LENGTH = "previewLength";
		#endregion

		#region Private Fields
		private int _PreviewLength = Int32.MinValue;
		#endregion

		#region Properties
		public int PreviewLength
		{
			get { return _PreviewLength; }
			set 
			{ 
				_PreviewLength = value;
				OnPropertyChanged("PreviewLength");
			}
		}
		#endregion

		#region CTor
		public PreviewRestriction()
		{
		}

		public PreviewRestriction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "previewLength":
						this._PreviewLength = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public PreviewRestriction(IDictionary<string,object> data) : base(data)
		{
			    this._PreviewLength = data.TryGetValueSafe<int>("previewLength");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPreviewRestriction");
			kparams.AddIfNotNull("previewLength", this._PreviewLength);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PREVIEW_LENGTH:
					return "PreviewLength";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

