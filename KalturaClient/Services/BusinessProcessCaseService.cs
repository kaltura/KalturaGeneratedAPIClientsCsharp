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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class BusinessProcessCaseAbortRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string OBJECT_TYPE = "objectType";
		public const string OBJECT_ID = "objectId";
		public const string BUSINESS_PROCESS_START_NOTIFICATION_TEMPLATE_ID = "businessProcessStartNotificationTemplateId";
		#endregion

		public EventNotificationEventObjectType ObjectType
		{
			set;
			get;
		}
		public string ObjectId
		{
			set;
			get;
		}
		public int BusinessProcessStartNotificationTemplateId
		{
			set;
			get;
		}

		public BusinessProcessCaseAbortRequestBuilder()
			: base("businessprocessnotification_businessprocesscase", "abort")
		{
		}

		public BusinessProcessCaseAbortRequestBuilder(EventNotificationEventObjectType objectType, string objectId, int businessProcessStartNotificationTemplateId)
			: this()
		{
			this.ObjectType = objectType;
			this.ObjectId = objectId;
			this.BusinessProcessStartNotificationTemplateId = businessProcessStartNotificationTemplateId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("objectType"))
				kparams.AddIfNotNull("objectType", ObjectType);
			if (!isMapped("objectId"))
				kparams.AddIfNotNull("objectId", ObjectId);
			if (!isMapped("businessProcessStartNotificationTemplateId"))
				kparams.AddIfNotNull("businessProcessStartNotificationTemplateId", BusinessProcessStartNotificationTemplateId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}

	public class BusinessProcessCaseListRequestBuilder : RequestBuilder<IList<BusinessProcessCase>>
	{
		#region Constants
		public const string OBJECT_TYPE = "objectType";
		public const string OBJECT_ID = "objectId";
		#endregion

		public EventNotificationEventObjectType ObjectType
		{
			set;
			get;
		}
		public string ObjectId
		{
			set;
			get;
		}

		public BusinessProcessCaseListRequestBuilder()
			: base("businessprocessnotification_businessprocesscase", "list")
		{
		}

		public BusinessProcessCaseListRequestBuilder(EventNotificationEventObjectType objectType, string objectId)
			: this()
		{
			this.ObjectType = objectType;
			this.ObjectId = objectId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("objectType"))
				kparams.AddIfNotNull("objectType", ObjectType);
			if (!isMapped("objectId"))
				kparams.AddIfNotNull("objectId", ObjectId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			IList<BusinessProcessCase> list = new List<BusinessProcessCase>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add(ObjectFactory.Create<BusinessProcessCase>(node));
			}
			return list;
		}
	}


	public class BusinessProcessCaseService
	{
		private BusinessProcessCaseService()
		{
		}

		public static BusinessProcessCaseAbortRequestBuilder Abort(EventNotificationEventObjectType objectType, string objectId, int businessProcessStartNotificationTemplateId)
		{
			return new BusinessProcessCaseAbortRequestBuilder(objectType, objectId, businessProcessStartNotificationTemplateId);
		}

		public static BusinessProcessCaseListRequestBuilder List(EventNotificationEventObjectType objectType, string objectId)
		{
			return new BusinessProcessCaseListRequestBuilder(objectType, objectId);
		}
	}
}
