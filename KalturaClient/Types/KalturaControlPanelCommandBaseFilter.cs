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
	public class KalturaControlPanelCommandBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _CreatedByIdEqual = Int32.MinValue;
		private KalturaControlPanelCommandType _TypeEqual = (KalturaControlPanelCommandType)Int32.MinValue;
		private string _TypeIn = null;
		private KalturaControlPanelCommandTargetType _TargetTypeEqual = (KalturaControlPanelCommandTargetType)Int32.MinValue;
		private string _TargetTypeIn = null;
		private KalturaControlPanelCommandStatus _StatusEqual = (KalturaControlPanelCommandStatus)Int32.MinValue;
		private string _StatusIn = null;
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
		public int CreatedByIdEqual
		{
			get { return _CreatedByIdEqual; }
			set 
			{ 
				_CreatedByIdEqual = value;
				OnPropertyChanged("CreatedByIdEqual");
			}
		}
		public KalturaControlPanelCommandType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		public string TypeIn
		{
			get { return _TypeIn; }
			set 
			{ 
				_TypeIn = value;
				OnPropertyChanged("TypeIn");
			}
		}
		public KalturaControlPanelCommandTargetType TargetTypeEqual
		{
			get { return _TargetTypeEqual; }
			set 
			{ 
				_TargetTypeEqual = value;
				OnPropertyChanged("TargetTypeEqual");
			}
		}
		public string TargetTypeIn
		{
			get { return _TargetTypeIn; }
			set 
			{ 
				_TargetTypeIn = value;
				OnPropertyChanged("TargetTypeIn");
			}
		}
		public KalturaControlPanelCommandStatus StatusEqual
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
		#endregion

		#region CTor
		public KalturaControlPanelCommandBaseFilter()
		{
		}

		public KalturaControlPanelCommandBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this.IdEqual = ParseInt(txt);
						continue;
					case "idIn":
						this.IdIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this.CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this.CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "createdByIdEqual":
						this.CreatedByIdEqual = ParseInt(txt);
						continue;
					case "typeEqual":
						this.TypeEqual = (KalturaControlPanelCommandType)ParseEnum(typeof(KalturaControlPanelCommandType), txt);
						continue;
					case "typeIn":
						this.TypeIn = txt;
						continue;
					case "targetTypeEqual":
						this.TargetTypeEqual = (KalturaControlPanelCommandTargetType)ParseEnum(typeof(KalturaControlPanelCommandTargetType), txt);
						continue;
					case "targetTypeIn":
						this.TargetTypeIn = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaControlPanelCommandStatus)ParseEnum(typeof(KalturaControlPanelCommandStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaControlPanelCommandBaseFilter");
			kparams.AddIfNotNull("idEqual", this.IdEqual);
			kparams.AddIfNotNull("idIn", this.IdIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("createdByIdEqual", this.CreatedByIdEqual);
			kparams.AddIfNotNull("typeEqual", this.TypeEqual);
			kparams.AddIfNotNull("typeIn", this.TypeIn);
			kparams.AddIfNotNull("targetTypeEqual", this.TargetTypeEqual);
			kparams.AddIfNotNull("targetTypeIn", this.TargetTypeIn);
			kparams.AddIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddIfNotNull("statusIn", this.StatusIn);
			return kparams;
		}
		#endregion
	}
}

