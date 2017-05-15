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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class PlayReadyCopyRight : PlayReadyRight
	{
		#region Constants
		public const string COPY_COUNT = "copyCount";
		public const string COPY_ENABLERS = "copyEnablers";
		#endregion

		#region Private Fields
		private int _CopyCount = Int32.MinValue;
		private IList<PlayReadyCopyEnablerHolder> _CopyEnablers;
		#endregion

		#region Properties
		public int CopyCount
		{
			get { return _CopyCount; }
			set 
			{ 
				_CopyCount = value;
				OnPropertyChanged("CopyCount");
			}
		}
		public IList<PlayReadyCopyEnablerHolder> CopyEnablers
		{
			get { return _CopyEnablers; }
			set 
			{ 
				_CopyEnablers = value;
				OnPropertyChanged("CopyEnablers");
			}
		}
		#endregion

		#region CTor
		public PlayReadyCopyRight()
		{
		}

		public PlayReadyCopyRight(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "copyCount":
						this._CopyCount = ParseInt(propertyNode.InnerText);
						continue;
					case "copyEnablers":
						this._CopyEnablers = new List<PlayReadyCopyEnablerHolder>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._CopyEnablers.Add(ObjectFactory.Create<PlayReadyCopyEnablerHolder>(arrayNode));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPlayReadyCopyRight");
			kparams.AddIfNotNull("copyCount", this._CopyCount);
			kparams.AddIfNotNull("copyEnablers", this._CopyEnablers);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case COPY_COUNT:
					return "CopyCount";
				case COPY_ENABLERS:
					return "CopyEnablers";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

