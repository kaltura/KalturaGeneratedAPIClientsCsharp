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
// Copyright (C) 2006-2021  Kaltura Inc.
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
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class ServerNodeAddRequestBuilder : RequestBuilder<ServerNode>
	{
		#region Constants
		public const string SERVER_NODE = "serverNode";
		#endregion

		public ServerNode ServerNode { get; set; }

		public ServerNodeAddRequestBuilder()
			: base("servernode", "add")
		{
		}

		public ServerNodeAddRequestBuilder(ServerNode serverNode)
			: this()
		{
			this.ServerNode = serverNode;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("serverNode"))
				kparams.AddIfNotNull("serverNode", ServerNode);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ServerNode>(result);
		}
	}

	public class ServerNodeDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string SERVER_NODE_ID = "serverNodeId";
		#endregion

		public string ServerNodeId { get; set; }

		public ServerNodeDeleteRequestBuilder()
			: base("servernode", "delete")
		{
		}

		public ServerNodeDeleteRequestBuilder(string serverNodeId)
			: this()
		{
			this.ServerNodeId = serverNodeId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("serverNodeId"))
				kparams.AddIfNotNull("serverNodeId", ServerNodeId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}

	public class ServerNodeDisableRequestBuilder : RequestBuilder<ServerNode>
	{
		#region Constants
		public const string SERVER_NODE_ID = "serverNodeId";
		#endregion

		public string ServerNodeId { get; set; }

		public ServerNodeDisableRequestBuilder()
			: base("servernode", "disable")
		{
		}

		public ServerNodeDisableRequestBuilder(string serverNodeId)
			: this()
		{
			this.ServerNodeId = serverNodeId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("serverNodeId"))
				kparams.AddIfNotNull("serverNodeId", ServerNodeId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ServerNode>(result);
		}
	}

	public class ServerNodeEnableRequestBuilder : RequestBuilder<ServerNode>
	{
		#region Constants
		public const string SERVER_NODE_ID = "serverNodeId";
		#endregion

		public string ServerNodeId { get; set; }

		public ServerNodeEnableRequestBuilder()
			: base("servernode", "enable")
		{
		}

		public ServerNodeEnableRequestBuilder(string serverNodeId)
			: this()
		{
			this.ServerNodeId = serverNodeId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("serverNodeId"))
				kparams.AddIfNotNull("serverNodeId", ServerNodeId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ServerNode>(result);
		}
	}

	public class ServerNodeGetRequestBuilder : RequestBuilder<ServerNode>
	{
		#region Constants
		public const string SERVER_NODE_ID = "serverNodeId";
		#endregion

		public int ServerNodeId { get; set; }

		public ServerNodeGetRequestBuilder()
			: base("servernode", "get")
		{
		}

		public ServerNodeGetRequestBuilder(int serverNodeId)
			: this()
		{
			this.ServerNodeId = serverNodeId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("serverNodeId"))
				kparams.AddIfNotNull("serverNodeId", ServerNodeId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ServerNode>(result);
		}
	}

	public class ServerNodeGetFullPathRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string HOST_NAME = "hostName";
		public const string PROTOCOL = "protocol";
		public const string DELIVERY_FORMAT = "deliveryFormat";
		public const string DELIVERY_TYPE = "deliveryType";
		#endregion

		public string HostName { get; set; }
		public string Protocol { get; set; }
		public string DeliveryFormat { get; set; }
		public string DeliveryType { get; set; }

		public ServerNodeGetFullPathRequestBuilder()
			: base("servernode", "getFullPath")
		{
		}

		public ServerNodeGetFullPathRequestBuilder(string hostName, string protocol, string deliveryFormat, string deliveryType)
			: this()
		{
			this.HostName = hostName;
			this.Protocol = protocol;
			this.DeliveryFormat = deliveryFormat;
			this.DeliveryType = deliveryType;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("hostName"))
				kparams.AddIfNotNull("hostName", HostName);
			if (!isMapped("protocol"))
				kparams.AddIfNotNull("protocol", Protocol);
			if (!isMapped("deliveryFormat"))
				kparams.AddIfNotNull("deliveryFormat", DeliveryFormat);
			if (!isMapped("deliveryType"))
				kparams.AddIfNotNull("deliveryType", DeliveryType);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<string>();
		}
	}

	public class ServerNodeListRequestBuilder : RequestBuilder<ListResponse<ServerNode>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public ServerNodeFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public ServerNodeListRequestBuilder()
			: base("servernode", "list")
		{
		}

		public ServerNodeListRequestBuilder(ServerNodeFilter filter, FilterPager pager)
			: this()
		{
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<ServerNode>>(result);
		}
	}

	public class ServerNodeMarkOfflineRequestBuilder : RequestBuilder<ServerNode>
	{
		#region Constants
		public const string SERVER_NODE_ID = "serverNodeId";
		#endregion

		public string ServerNodeId { get; set; }

		public ServerNodeMarkOfflineRequestBuilder()
			: base("servernode", "markOffline")
		{
		}

		public ServerNodeMarkOfflineRequestBuilder(string serverNodeId)
			: this()
		{
			this.ServerNodeId = serverNodeId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("serverNodeId"))
				kparams.AddIfNotNull("serverNodeId", ServerNodeId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ServerNode>(result);
		}
	}

	public class ServerNodeReportStatusRequestBuilder : RequestBuilder<ServerNode>
	{
		#region Constants
		public const string HOST_NAME = "hostName";
		public const string SERVER_NODE = "serverNode";
		public const string SERVER_NODE_STATUS = "serverNodeStatus";
		#endregion

		public string HostName { get; set; }
		public ServerNode ServerNode { get; set; }
		public ServerNodeStatus ServerNodeStatus { get; set; }

		public ServerNodeReportStatusRequestBuilder()
			: base("servernode", "reportStatus")
		{
		}

		public ServerNodeReportStatusRequestBuilder(string hostName, ServerNode serverNode, ServerNodeStatus serverNodeStatus)
			: this()
		{
			this.HostName = hostName;
			this.ServerNode = serverNode;
			this.ServerNodeStatus = serverNodeStatus;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("hostName"))
				kparams.AddIfNotNull("hostName", HostName);
			if (!isMapped("serverNode"))
				kparams.AddIfNotNull("serverNode", ServerNode);
			if (!isMapped("serverNodeStatus"))
				kparams.AddIfNotNull("serverNodeStatus", ServerNodeStatus);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ServerNode>(result);
		}
	}

	public class ServerNodeUpdateRequestBuilder : RequestBuilder<ServerNode>
	{
		#region Constants
		public const string SERVER_NODE_ID = "serverNodeId";
		public const string SERVER_NODE = "serverNode";
		#endregion

		public int ServerNodeId { get; set; }
		public ServerNode ServerNode { get; set; }

		public ServerNodeUpdateRequestBuilder()
			: base("servernode", "update")
		{
		}

		public ServerNodeUpdateRequestBuilder(int serverNodeId, ServerNode serverNode)
			: this()
		{
			this.ServerNodeId = serverNodeId;
			this.ServerNode = serverNode;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("serverNodeId"))
				kparams.AddIfNotNull("serverNodeId", ServerNodeId);
			if (!isMapped("serverNode"))
				kparams.AddIfNotNull("serverNode", ServerNode);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ServerNode>(result);
		}
	}


	public class ServerNodeService
	{
		private ServerNodeService()
		{
		}

		public static ServerNodeAddRequestBuilder Add(ServerNode serverNode)
		{
			return new ServerNodeAddRequestBuilder(serverNode);
		}

		public static ServerNodeDeleteRequestBuilder Delete(string serverNodeId)
		{
			return new ServerNodeDeleteRequestBuilder(serverNodeId);
		}

		public static ServerNodeDisableRequestBuilder Disable(string serverNodeId)
		{
			return new ServerNodeDisableRequestBuilder(serverNodeId);
		}

		public static ServerNodeEnableRequestBuilder Enable(string serverNodeId)
		{
			return new ServerNodeEnableRequestBuilder(serverNodeId);
		}

		public static ServerNodeGetRequestBuilder Get(int serverNodeId)
		{
			return new ServerNodeGetRequestBuilder(serverNodeId);
		}

		public static ServerNodeGetFullPathRequestBuilder GetFullPath(string hostName, string protocol = "http", string deliveryFormat = null, string deliveryType = null)
		{
			return new ServerNodeGetFullPathRequestBuilder(hostName, protocol, deliveryFormat, deliveryType);
		}

		public static ServerNodeListRequestBuilder List(ServerNodeFilter filter = null, FilterPager pager = null)
		{
			return new ServerNodeListRequestBuilder(filter, pager);
		}

		public static ServerNodeMarkOfflineRequestBuilder MarkOffline(string serverNodeId)
		{
			return new ServerNodeMarkOfflineRequestBuilder(serverNodeId);
		}

		public static ServerNodeReportStatusRequestBuilder ReportStatus(string hostName, ServerNode serverNode = null, ServerNodeStatus serverNodeStatus = (ServerNodeStatus)(1))
		{
			return new ServerNodeReportStatusRequestBuilder(hostName, serverNode, serverNodeStatus);
		}

		public static ServerNodeUpdateRequestBuilder Update(int serverNodeId, ServerNode serverNode)
		{
			return new ServerNodeUpdateRequestBuilder(serverNodeId, serverNode);
		}
	}
}
