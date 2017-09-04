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
	public class CopyCaptionsJobData : JobData
	{
		#region Constants
		public const string SOURCE_ENTRY_ID = "sourceEntryId";
		public const string ENTRY_ID = "entryId";
		public const string OFFSET = "offset";
		public const string DURATION = "duration";
		public const string FULL_COPY = "fullCopy";
		#endregion

		#region Private Fields
		private string _SourceEntryId = null;
		private string _EntryId = null;
		private int _Offset = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private bool? _FullCopy = null;
		#endregion

		#region Properties
		public string SourceEntryId
		{
			get { return _SourceEntryId; }
			set 
			{ 
				_SourceEntryId = value;
				OnPropertyChanged("SourceEntryId");
			}
		}
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public int Offset
		{
			get { return _Offset; }
			set 
			{ 
				_Offset = value;
				OnPropertyChanged("Offset");
			}
		}
		public int Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		public bool? FullCopy
		{
			get { return _FullCopy; }
			set 
			{ 
				_FullCopy = value;
				OnPropertyChanged("FullCopy");
			}
		}
		#endregion

		#region CTor
		public CopyCaptionsJobData()
		{
		}

		public CopyCaptionsJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "sourceEntryId":
						this._SourceEntryId = propertyNode.InnerText;
						continue;
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "offset":
						this._Offset = ParseInt(propertyNode.InnerText);
						continue;
					case "duration":
						this._Duration = ParseInt(propertyNode.InnerText);
						continue;
					case "fullCopy":
						this._FullCopy = ParseBool(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaCopyCaptionsJobData");
			kparams.AddIfNotNull("sourceEntryId", this._SourceEntryId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("offset", this._Offset);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("fullCopy", this._FullCopy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SOURCE_ENTRY_ID:
					return "SourceEntryId";
				case ENTRY_ID:
					return "EntryId";
				case OFFSET:
					return "Offset";
				case DURATION:
					return "Duration";
				case FULL_COPY:
					return "FullCopy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

