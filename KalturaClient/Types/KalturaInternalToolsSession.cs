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
	public class KalturaInternalToolsSession : KalturaObjectBase
	{
		#region Private Fields
		private int _Partner_id = Int32.MinValue;
		private int _Valid_until = Int32.MinValue;
		private string _Partner_pattern = null;
		private KalturaSessionType _Type = (KalturaSessionType)Int32.MinValue;
		private string _Error = null;
		private int _Rand = Int32.MinValue;
		private string _User = null;
		private string _Privileges = null;
		#endregion

		#region Properties
		public int Partner_id
		{
			get { return _Partner_id; }
			set 
			{ 
				_Partner_id = value;
				OnPropertyChanged("Partner_id");
			}
		}
		public int Valid_until
		{
			get { return _Valid_until; }
			set 
			{ 
				_Valid_until = value;
				OnPropertyChanged("Valid_until");
			}
		}
		public string Partner_pattern
		{
			get { return _Partner_pattern; }
			set 
			{ 
				_Partner_pattern = value;
				OnPropertyChanged("Partner_pattern");
			}
		}
		public KalturaSessionType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string Error
		{
			get { return _Error; }
			set 
			{ 
				_Error = value;
				OnPropertyChanged("Error");
			}
		}
		public int Rand
		{
			get { return _Rand; }
			set 
			{ 
				_Rand = value;
				OnPropertyChanged("Rand");
			}
		}
		public string User
		{
			get { return _User; }
			set 
			{ 
				_User = value;
				OnPropertyChanged("User");
			}
		}
		public string Privileges
		{
			get { return _Privileges; }
			set 
			{ 
				_Privileges = value;
				OnPropertyChanged("Privileges");
			}
		}
		#endregion

		#region CTor
		public KalturaInternalToolsSession()
		{
		}

		public KalturaInternalToolsSession(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "partner_id":
						this.Partner_id = ParseInt(txt);
						continue;
					case "valid_until":
						this.Valid_until = ParseInt(txt);
						continue;
					case "partner_pattern":
						this.Partner_pattern = txt;
						continue;
					case "type":
						this.Type = (KalturaSessionType)ParseEnum(typeof(KalturaSessionType), txt);
						continue;
					case "error":
						this.Error = txt;
						continue;
					case "rand":
						this.Rand = ParseInt(txt);
						continue;
					case "user":
						this.User = txt;
						continue;
					case "privileges":
						this.Privileges = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaInternalToolsSession");
			kparams.AddIfNotNull("partner_id", this.Partner_id);
			kparams.AddIfNotNull("valid_until", this.Valid_until);
			kparams.AddIfNotNull("partner_pattern", this.Partner_pattern);
			kparams.AddIfNotNull("type", this.Type);
			kparams.AddIfNotNull("error", this.Error);
			kparams.AddIfNotNull("rand", this.Rand);
			kparams.AddIfNotNull("user", this.User);
			kparams.AddIfNotNull("privileges", this.Privileges);
			return kparams;
		}
		#endregion
	}
}

