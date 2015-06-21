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
	public class KalturaBatchQueuesStatus : KalturaObjectBase
	{
		#region Private Fields
		private KalturaBatchJobType _JobType = null;
		private int _WorkerId = Int32.MinValue;
		private string _TypeName = null;
		private int _Size = Int32.MinValue;
		private int _WaitTime = Int32.MinValue;
		#endregion

		#region Properties
		public KalturaBatchJobType JobType
		{
			get { return _JobType; }
			set 
			{ 
				_JobType = value;
				OnPropertyChanged("JobType");
			}
		}
		public int WorkerId
		{
			get { return _WorkerId; }
			set 
			{ 
				_WorkerId = value;
				OnPropertyChanged("WorkerId");
			}
		}
		public string TypeName
		{
			get { return _TypeName; }
			set 
			{ 
				_TypeName = value;
				OnPropertyChanged("TypeName");
			}
		}
		public int Size
		{
			get { return _Size; }
			set 
			{ 
				_Size = value;
				OnPropertyChanged("Size");
			}
		}
		public int WaitTime
		{
			get { return _WaitTime; }
			set 
			{ 
				_WaitTime = value;
				OnPropertyChanged("WaitTime");
			}
		}
		#endregion

		#region CTor
		public KalturaBatchQueuesStatus()
		{
		}

		public KalturaBatchQueuesStatus(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "jobType":
						this.JobType = (KalturaBatchJobType)KalturaStringEnum.Parse(typeof(KalturaBatchJobType), txt);
						continue;
					case "workerId":
						this.WorkerId = ParseInt(txt);
						continue;
					case "typeName":
						this.TypeName = txt;
						continue;
					case "size":
						this.Size = ParseInt(txt);
						continue;
					case "waitTime":
						this.WaitTime = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBatchQueuesStatus");
			kparams.AddStringEnumIfNotNull("jobType", this.JobType);
			kparams.AddIntIfNotNull("workerId", this.WorkerId);
			kparams.AddStringIfNotNull("typeName", this.TypeName);
			kparams.AddIntIfNotNull("size", this.Size);
			kparams.AddIntIfNotNull("waitTime", this.WaitTime);
			return kparams;
		}
		#endregion
	}
}

