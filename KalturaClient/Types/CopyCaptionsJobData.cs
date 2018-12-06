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
	public class CopyCaptionsJobData : JobData
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CLIPS_DESCRIPTION_ARRAY = "clipsDescriptionArray";
		public const string FULL_COPY = "fullCopy";
		#endregion

		#region Private Fields
		private string _EntryId = null;
		private IList<ClipDescription> _ClipsDescriptionArray;
		private bool? _FullCopy = null;
		#endregion

		#region Properties
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public IList<ClipDescription> ClipsDescriptionArray
		{
			get { return _ClipsDescriptionArray; }
			set 
			{ 
				_ClipsDescriptionArray = value;
				OnPropertyChanged("ClipsDescriptionArray");
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
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "clipsDescriptionArray":
						this._ClipsDescriptionArray = new List<ClipDescription>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._ClipsDescriptionArray.Add(ObjectFactory.Create<ClipDescription>(arrayNode));
						}
						continue;
					case "fullCopy":
						this._FullCopy = ParseBool(propertyNode.InnerText);
						continue;
				}
			}
		}

		public CopyCaptionsJobData(IDictionary<string,object> data) : base(data)
		{
			    this._EntryId = data.TryGetValueSafe<string>("entryId");
			    this._ClipsDescriptionArray = new List<ClipDescription>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("clipsDescriptionArray", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._ClipsDescriptionArray.Add(ObjectFactory.Create<ClipDescription>((IDictionary<string,object>)dataDictionary));
			    }
			    this._FullCopy = data.TryGetValueSafe<bool>("fullCopy");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCopyCaptionsJobData");
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("clipsDescriptionArray", this._ClipsDescriptionArray);
			kparams.AddIfNotNull("fullCopy", this._FullCopy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_ID:
					return "EntryId";
				case CLIPS_DESCRIPTION_ARRAY:
					return "ClipsDescriptionArray";
				case FULL_COPY:
					return "FullCopy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

