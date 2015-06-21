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
	public class KalturaWorkerQueueFilter : KalturaObjectBase
	{
		#region Private Fields
		private int _SchedulerId = Int32.MinValue;
		private int _WorkerId = Int32.MinValue;
		private KalturaBatchJobType _JobType = null;
		private KalturaBatchJobFilter _Filter;
		#endregion

		#region Properties
		public int SchedulerId
		{
			get { return _SchedulerId; }
			set 
			{ 
				_SchedulerId = value;
				OnPropertyChanged("SchedulerId");
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
		public KalturaBatchJobType JobType
		{
			get { return _JobType; }
			set 
			{ 
				_JobType = value;
				OnPropertyChanged("JobType");
			}
		}
		public KalturaBatchJobFilter Filter
		{
			get { return _Filter; }
			set 
			{ 
				_Filter = value;
				OnPropertyChanged("Filter");
			}
		}
		#endregion

		#region CTor
		public KalturaWorkerQueueFilter()
		{
		}

		public KalturaWorkerQueueFilter(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "schedulerId":
						this.SchedulerId = ParseInt(txt);
						continue;
					case "workerId":
						this.WorkerId = ParseInt(txt);
						continue;
					case "jobType":
						this.JobType = (KalturaBatchJobType)KalturaStringEnum.Parse(typeof(KalturaBatchJobType), txt);
						continue;
					case "filter":
						this.Filter = (KalturaBatchJobFilter)KalturaObjectFactory.Create(propertyNode, "KalturaBatchJobFilter");
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaWorkerQueueFilter");
			kparams.AddIntIfNotNull("schedulerId", this.SchedulerId);
			kparams.AddIntIfNotNull("workerId", this.WorkerId);
			kparams.AddStringEnumIfNotNull("jobType", this.JobType);
			if (this.Filter != null)
				kparams.Add("filter", this.Filter.ToParams());
			return kparams;
		}
		#endregion
	}
}

