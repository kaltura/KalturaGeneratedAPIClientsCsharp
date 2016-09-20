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
	public class KalturaStorageProfileBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		private KalturaStorageProfileStatus _StatusEqual = (KalturaStorageProfileStatus)Int32.MinValue;
		private string _StatusIn = null;
		private KalturaStorageProfileProtocol _ProtocolEqual = null;
		private string _ProtocolIn = null;
		#endregion

		#region Properties
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
			}
		}
		public string SystemNameEqual
		{
			get { return _SystemNameEqual; }
			set 
			{ 
				_SystemNameEqual = value;
				OnPropertyChanged("SystemNameEqual");
			}
		}
		public string SystemNameIn
		{
			get { return _SystemNameIn; }
			set 
			{ 
				_SystemNameIn = value;
				OnPropertyChanged("SystemNameIn");
			}
		}
		public KalturaStorageProfileStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public KalturaStorageProfileProtocol ProtocolEqual
		{
			get { return _ProtocolEqual; }
			set 
			{ 
				_ProtocolEqual = value;
				OnPropertyChanged("ProtocolEqual");
			}
		}
		public string ProtocolIn
		{
			get { return _ProtocolIn; }
			set 
			{ 
				_ProtocolIn = value;
				OnPropertyChanged("ProtocolIn");
			}
		}
		#endregion

		#region CTor
		public KalturaStorageProfileBaseFilter()
		{
		}

		public KalturaStorageProfileBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = ParseInt(txt);
						continue;
					case "idIn":
						this._IdIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "partnerIdEqual":
						this._PartnerIdEqual = ParseInt(txt);
						continue;
					case "partnerIdIn":
						this._PartnerIdIn = txt;
						continue;
					case "systemNameEqual":
						this._SystemNameEqual = txt;
						continue;
					case "systemNameIn":
						this._SystemNameIn = txt;
						continue;
					case "statusEqual":
						this._StatusEqual = (KalturaStorageProfileStatus)ParseEnum(typeof(KalturaStorageProfileStatus), txt);
						continue;
					case "statusIn":
						this._StatusIn = txt;
						continue;
					case "protocolEqual":
						this._ProtocolEqual = (KalturaStorageProfileProtocol)KalturaStringEnum.Parse(typeof(KalturaStorageProfileProtocol), txt);
						continue;
					case "protocolIn":
						this._ProtocolIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaStorageProfileBaseFilter");
			kparams.AddIfNotNull("idEqual", this.IdEqual);
			kparams.AddIfNotNull("idIn", this.IdIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this.PartnerIdIn);
			kparams.AddIfNotNull("systemNameEqual", this.SystemNameEqual);
			kparams.AddIfNotNull("systemNameIn", this.SystemNameIn);
			kparams.AddIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddIfNotNull("statusIn", this.StatusIn);
			kparams.AddIfNotNull("protocolEqual", this.ProtocolEqual);
			kparams.AddIfNotNull("protocolIn", this.ProtocolIn);
			return kparams;
		}
		#endregion
	}
}

