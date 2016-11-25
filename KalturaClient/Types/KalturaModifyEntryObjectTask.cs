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
	public class KalturaModifyEntryObjectTask : KalturaObjectTask
	{
		#region Private Fields
		private int _InputMetadataProfileId = Int32.MinValue;
		private IList<KalturaKeyValue> _InputMetadata;
		private int _OutputMetadataProfileId = Int32.MinValue;
		private IList<KalturaKeyValue> _OutputMetadata;
		private string _InputUserId = null;
		private string _InputEntitledUsersEdit = null;
		private string _InputEntitledUsersPublish = null;
		#endregion

		#region Properties
		public int InputMetadataProfileId
		{
			get { return _InputMetadataProfileId; }
			set 
			{ 
				_InputMetadataProfileId = value;
				OnPropertyChanged("InputMetadataProfileId");
			}
		}
		public new IList<KalturaKeyValue> InputMetadata
		{
			get { return _InputMetadata; }
			set 
			{ 
				_InputMetadata = value;
				OnPropertyChanged("InputMetadata");
			}
		}
		public int OutputMetadataProfileId
		{
			get { return _OutputMetadataProfileId; }
			set 
			{ 
				_OutputMetadataProfileId = value;
				OnPropertyChanged("OutputMetadataProfileId");
			}
		}
		public new IList<KalturaKeyValue> OutputMetadata
		{
			get { return _OutputMetadata; }
			set 
			{ 
				_OutputMetadata = value;
				OnPropertyChanged("OutputMetadata");
			}
		}
		public string InputUserId
		{
			get { return _InputUserId; }
			set 
			{ 
				_InputUserId = value;
				OnPropertyChanged("InputUserId");
			}
		}
		public string InputEntitledUsersEdit
		{
			get { return _InputEntitledUsersEdit; }
			set 
			{ 
				_InputEntitledUsersEdit = value;
				OnPropertyChanged("InputEntitledUsersEdit");
			}
		}
		public string InputEntitledUsersPublish
		{
			get { return _InputEntitledUsersPublish; }
			set 
			{ 
				_InputEntitledUsersPublish = value;
				OnPropertyChanged("InputEntitledUsersPublish");
			}
		}
		#endregion

		#region CTor
		public KalturaModifyEntryObjectTask()
		{
		}

		public KalturaModifyEntryObjectTask(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "inputMetadataProfileId":
						this._InputMetadataProfileId = ParseInt(txt);
						continue;
					case "inputMetadata":
						this._InputMetadata = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._InputMetadata.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
					case "outputMetadataProfileId":
						this._OutputMetadataProfileId = ParseInt(txt);
						continue;
					case "outputMetadata":
						this._OutputMetadata = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._OutputMetadata.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
					case "inputUserId":
						this._InputUserId = txt;
						continue;
					case "inputEntitledUsersEdit":
						this._InputEntitledUsersEdit = txt;
						continue;
					case "inputEntitledUsersPublish":
						this._InputEntitledUsersPublish = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaModifyEntryObjectTask");
			kparams.AddIfNotNull("inputMetadataProfileId", this._InputMetadataProfileId);
			kparams.AddIfNotNull("inputMetadata", this._InputMetadata);
			kparams.AddIfNotNull("outputMetadataProfileId", this._OutputMetadataProfileId);
			kparams.AddIfNotNull("outputMetadata", this._OutputMetadata);
			kparams.AddIfNotNull("inputUserId", this._InputUserId);
			kparams.AddIfNotNull("inputEntitledUsersEdit", this._InputEntitledUsersEdit);
			kparams.AddIfNotNull("inputEntitledUsersPublish", this._InputEntitledUsersPublish);
			return kparams;
		}
		#endregion
	}
}

