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
	public class IntegrationDispatchRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string DATA = "data";
		public const string OBJECT_TYPE = "objectType";
		public const string OBJECT_ID = "objectId";
		#endregion

		public IntegrationJobData Data
		{
			set;
			get;
		}
		public BatchJobObjectType ObjectType
		{
			set;
			get;
		}
		public string ObjectId
		{
			set;
			get;
		}

		public IntegrationDispatchRequestBuilder()
			: base("integration_integration", "dispatch")
		{
		}

		public IntegrationDispatchRequestBuilder(IntegrationJobData data, BatchJobObjectType objectType, string objectId)
			: this()
		{
			this.Data = data;
			this.ObjectType = objectType;
			this.ObjectId = objectId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("data"))
				kparams.AddIfNotNull("data", Data);
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
			return int.Parse(result.InnerText);
		}
		public override object DeserializeObject(object result)
		{
			return (int)(result);
		}
	}

	public class IntegrationNotifyRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public IntegrationNotifyRequestBuilder()
			: base("integration_integration", "notify")
		{
		}

		public IntegrationNotifyRequestBuilder(int id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
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
		public override object DeserializeObject(object result)
		{
			return null;
		}
	}


	public class IntegrationService
	{
		private IntegrationService()
		{
		}

		public static IntegrationDispatchRequestBuilder Dispatch(IntegrationJobData data, BatchJobObjectType objectType, string objectId)
		{
			return new IntegrationDispatchRequestBuilder(data, objectType, objectId);
		}

		public static IntegrationNotifyRequestBuilder Notify(int id)
		{
			return new IntegrationNotifyRequestBuilder(id);
		}
	}
}
