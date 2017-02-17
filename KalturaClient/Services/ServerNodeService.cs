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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class ServerNodeAddRequestBuilder : RequestBuilder<ServerNode>
	{
		#region Constants
		public const string SERVER_NODE = "serverNode";
		#endregion

		public ServerNode ServerNode
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ServerNode>(result);
		}
	}

	public class ServerNodeDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string SERVER_NODE_ID = "serverNodeId";
		#endregion

		public string ServerNodeId
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}

	public class ServerNodeDisableRequestBuilder : RequestBuilder<ServerNode>
	{
		#region Constants
		public const string SERVER_NODE_ID = "serverNodeId";
		#endregion

		public string ServerNodeId
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ServerNode>(result);
		}
	}

	public class ServerNodeEnableRequestBuilder : RequestBuilder<ServerNode>
	{
		#region Constants
		public const string SERVER_NODE_ID = "serverNodeId";
		#endregion

		public string ServerNodeId
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ServerNode>(result);
		}
	}

	public class ServerNodeGetRequestBuilder : RequestBuilder<ServerNode>
	{
		#region Constants
		public const string SERVER_NODE_ID = "serverNodeId";
		#endregion

		public int ServerNodeId
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ServerNode>(result);
		}
	}

	public class ServerNodeListRequestBuilder : RequestBuilder<ListResponse<ServerNode>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public ServerNodeFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<ServerNode>>(result);
		}
	}

	public class ServerNodeReportStatusRequestBuilder : RequestBuilder<ServerNode>
	{
		#region Constants
		public const string HOST_NAME = "hostName";
		public const string SERVER_NODE = "serverNode";
		#endregion

		public string HostName
		{
			set;
			get;
		}
		public ServerNode ServerNode
		{
			set;
			get;
		}

		public ServerNodeReportStatusRequestBuilder()
			: base("servernode", "reportStatus")
		{
		}

		public ServerNodeReportStatusRequestBuilder(string hostName, ServerNode serverNode)
			: this()
		{
			this.HostName = hostName;
			this.ServerNode = serverNode;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("hostName"))
				kparams.AddIfNotNull("hostName", HostName);
			if (!isMapped("serverNode"))
				kparams.AddIfNotNull("serverNode", ServerNode);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
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

		public int ServerNodeId
		{
			set;
			get;
		}
		public ServerNode ServerNode
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
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

		public static ServerNodeListRequestBuilder List(ServerNodeFilter filter = null, FilterPager pager = null)
		{
			return new ServerNodeListRequestBuilder(filter, pager);
		}

		public static ServerNodeReportStatusRequestBuilder ReportStatus(string hostName, ServerNode serverNode = null)
		{
			return new ServerNodeReportStatusRequestBuilder(hostName, serverNode);
		}

		public static ServerNodeUpdateRequestBuilder Update(int serverNodeId, ServerNode serverNode)
		{
			return new ServerNodeUpdateRequestBuilder(serverNodeId, serverNode);
		}
	}
}
