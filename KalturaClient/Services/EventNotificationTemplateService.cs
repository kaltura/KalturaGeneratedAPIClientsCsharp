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
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class EventNotificationTemplateAddRequestBuilder : RequestBuilder<EventNotificationTemplate>
	{
		#region Constants
		public const string EVENT_NOTIFICATION_TEMPLATE = "eventNotificationTemplate";
		#endregion

		public EventNotificationTemplate EventNotificationTemplate
		{
			set;
			get;
		}

		public EventNotificationTemplateAddRequestBuilder()
			: base("eventnotification_eventnotificationtemplate", "add")
		{
		}

		public EventNotificationTemplateAddRequestBuilder(EventNotificationTemplate eventNotificationTemplate)
			: this()
		{
			this.EventNotificationTemplate = eventNotificationTemplate;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("eventNotificationTemplate"))
				kparams.AddIfNotNull("eventNotificationTemplate", EventNotificationTemplate);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EventNotificationTemplate>(result);
		}
	}

	public class EventNotificationTemplateCloneRequestBuilder : RequestBuilder<EventNotificationTemplate>
	{
		#region Constants
		public const string ID = "id";
		public const string EVENT_NOTIFICATION_TEMPLATE = "eventNotificationTemplate";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public EventNotificationTemplate EventNotificationTemplate
		{
			set;
			get;
		}

		public EventNotificationTemplateCloneRequestBuilder()
			: base("eventnotification_eventnotificationtemplate", "clone")
		{
		}

		public EventNotificationTemplateCloneRequestBuilder(int id, EventNotificationTemplate eventNotificationTemplate)
			: this()
		{
			this.Id = id;
			this.EventNotificationTemplate = eventNotificationTemplate;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("eventNotificationTemplate"))
				kparams.AddIfNotNull("eventNotificationTemplate", EventNotificationTemplate);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EventNotificationTemplate>(result);
		}
	}

	public class EventNotificationTemplateDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public EventNotificationTemplateDeleteRequestBuilder()
			: base("eventnotification_eventnotificationtemplate", "delete")
		{
		}

		public EventNotificationTemplateDeleteRequestBuilder(int id)
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

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}

	public class EventNotificationTemplateDispatchRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string ID = "id";
		public const string SCOPE = "scope";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public EventNotificationScope Scope
		{
			set;
			get;
		}

		public EventNotificationTemplateDispatchRequestBuilder()
			: base("eventnotification_eventnotificationtemplate", "dispatch")
		{
		}

		public EventNotificationTemplateDispatchRequestBuilder(int id, EventNotificationScope scope)
			: this()
		{
			this.Id = id;
			this.Scope = scope;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("scope"))
				kparams.AddIfNotNull("scope", Scope);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<int>();
		}
	}

	public class EventNotificationTemplateGetRequestBuilder : RequestBuilder<EventNotificationTemplate>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public EventNotificationTemplateGetRequestBuilder()
			: base("eventnotification_eventnotificationtemplate", "get")
		{
		}

		public EventNotificationTemplateGetRequestBuilder(int id)
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EventNotificationTemplate>(result);
		}
	}

	public class EventNotificationTemplateListRequestBuilder : RequestBuilder<ListResponse<EventNotificationTemplate>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public EventNotificationTemplateFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public EventNotificationTemplateListRequestBuilder()
			: base("eventnotification_eventnotificationtemplate", "list")
		{
		}

		public EventNotificationTemplateListRequestBuilder(EventNotificationTemplateFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<EventNotificationTemplate>>(result);
		}
	}

	public class EventNotificationTemplateListByPartnerRequestBuilder : RequestBuilder<ListResponse<EventNotificationTemplate>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public PartnerFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public EventNotificationTemplateListByPartnerRequestBuilder()
			: base("eventnotification_eventnotificationtemplate", "listByPartner")
		{
		}

		public EventNotificationTemplateListByPartnerRequestBuilder(PartnerFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<EventNotificationTemplate>>(result);
		}
	}

	public class EventNotificationTemplateListTemplatesRequestBuilder : RequestBuilder<ListResponse<EventNotificationTemplate>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public EventNotificationTemplateFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public EventNotificationTemplateListTemplatesRequestBuilder()
			: base("eventnotification_eventnotificationtemplate", "listTemplates")
		{
		}

		public EventNotificationTemplateListTemplatesRequestBuilder(EventNotificationTemplateFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<EventNotificationTemplate>>(result);
		}
	}

	public class EventNotificationTemplateRegisterRequestBuilder : RequestBuilder<PushNotificationData>
	{
		#region Constants
		public const string NOTIFICATION_TEMPLATE_SYSTEM_NAME = "notificationTemplateSystemName";
		public const string PUSH_NOTIFICATION_PARAMS = "pushNotificationParams";
		#endregion

		public string NotificationTemplateSystemName
		{
			set;
			get;
		}
		public PushNotificationParams PushNotificationParams
		{
			set;
			get;
		}

		public EventNotificationTemplateRegisterRequestBuilder()
			: base("eventnotification_eventnotificationtemplate", "register")
		{
		}

		public EventNotificationTemplateRegisterRequestBuilder(string notificationTemplateSystemName, PushNotificationParams pushNotificationParams)
			: this()
		{
			this.NotificationTemplateSystemName = notificationTemplateSystemName;
			this.PushNotificationParams = pushNotificationParams;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("notificationTemplateSystemName"))
				kparams.AddIfNotNull("notificationTemplateSystemName", NotificationTemplateSystemName);
			if (!isMapped("pushNotificationParams"))
				kparams.AddIfNotNull("pushNotificationParams", PushNotificationParams);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<PushNotificationData>(result);
		}
	}

	public class EventNotificationTemplateSendCommandRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string NOTIFICATION_TEMPLATE_SYSTEM_NAME = "notificationTemplateSystemName";
		public const string PUSH_NOTIFICATION_PARAMS = "pushNotificationParams";
		public const string COMMAND = "command";
		#endregion

		public string NotificationTemplateSystemName
		{
			set;
			get;
		}
		public PushNotificationParams PushNotificationParams
		{
			set;
			get;
		}
		public PushNotificationCommandType Command
		{
			set;
			get;
		}

		public EventNotificationTemplateSendCommandRequestBuilder()
			: base("eventnotification_eventnotificationtemplate", "sendCommand")
		{
		}

		public EventNotificationTemplateSendCommandRequestBuilder(string notificationTemplateSystemName, PushNotificationParams pushNotificationParams, PushNotificationCommandType command)
			: this()
		{
			this.NotificationTemplateSystemName = notificationTemplateSystemName;
			this.PushNotificationParams = pushNotificationParams;
			this.Command = command;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("notificationTemplateSystemName"))
				kparams.AddIfNotNull("notificationTemplateSystemName", NotificationTemplateSystemName);
			if (!isMapped("pushNotificationParams"))
				kparams.AddIfNotNull("pushNotificationParams", PushNotificationParams);
			if (!isMapped("command"))
				kparams.AddIfNotNull("command", Command);
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

	public class EventNotificationTemplateUpdateRequestBuilder : RequestBuilder<EventNotificationTemplate>
	{
		#region Constants
		public const string ID = "id";
		public const string EVENT_NOTIFICATION_TEMPLATE = "eventNotificationTemplate";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public EventNotificationTemplate EventNotificationTemplate
		{
			set;
			get;
		}

		public EventNotificationTemplateUpdateRequestBuilder()
			: base("eventnotification_eventnotificationtemplate", "update")
		{
		}

		public EventNotificationTemplateUpdateRequestBuilder(int id, EventNotificationTemplate eventNotificationTemplate)
			: this()
		{
			this.Id = id;
			this.EventNotificationTemplate = eventNotificationTemplate;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("eventNotificationTemplate"))
				kparams.AddIfNotNull("eventNotificationTemplate", EventNotificationTemplate);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EventNotificationTemplate>(result);
		}
	}

	public class EventNotificationTemplateUpdateStatusRequestBuilder : RequestBuilder<EventNotificationTemplate>
	{
		#region Constants
		public const string ID = "id";
		public const string STATUS = "status";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public EventNotificationTemplateStatus Status
		{
			set;
			get;
		}

		public EventNotificationTemplateUpdateStatusRequestBuilder()
			: base("eventnotification_eventnotificationtemplate", "updateStatus")
		{
		}

		public EventNotificationTemplateUpdateStatusRequestBuilder(int id, EventNotificationTemplateStatus status)
			: this()
		{
			this.Id = id;
			this.Status = status;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("status"))
				kparams.AddIfNotNull("status", Status);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EventNotificationTemplate>(result);
		}
	}


	public class EventNotificationTemplateService
	{
		private EventNotificationTemplateService()
		{
		}

		public static EventNotificationTemplateAddRequestBuilder Add(EventNotificationTemplate eventNotificationTemplate)
		{
			return new EventNotificationTemplateAddRequestBuilder(eventNotificationTemplate);
		}

		public static EventNotificationTemplateCloneRequestBuilder Clone(int id, EventNotificationTemplate eventNotificationTemplate = null)
		{
			return new EventNotificationTemplateCloneRequestBuilder(id, eventNotificationTemplate);
		}

		public static EventNotificationTemplateDeleteRequestBuilder Delete(int id)
		{
			return new EventNotificationTemplateDeleteRequestBuilder(id);
		}

		public static EventNotificationTemplateDispatchRequestBuilder Dispatch(int id, EventNotificationScope scope)
		{
			return new EventNotificationTemplateDispatchRequestBuilder(id, scope);
		}

		public static EventNotificationTemplateGetRequestBuilder Get(int id)
		{
			return new EventNotificationTemplateGetRequestBuilder(id);
		}

		public static EventNotificationTemplateListRequestBuilder List(EventNotificationTemplateFilter filter = null, FilterPager pager = null)
		{
			return new EventNotificationTemplateListRequestBuilder(filter, pager);
		}

		public static EventNotificationTemplateListByPartnerRequestBuilder ListByPartner(PartnerFilter filter = null, FilterPager pager = null)
		{
			return new EventNotificationTemplateListByPartnerRequestBuilder(filter, pager);
		}

		public static EventNotificationTemplateListTemplatesRequestBuilder ListTemplates(EventNotificationTemplateFilter filter = null, FilterPager pager = null)
		{
			return new EventNotificationTemplateListTemplatesRequestBuilder(filter, pager);
		}

		public static EventNotificationTemplateRegisterRequestBuilder Register(string notificationTemplateSystemName, PushNotificationParams pushNotificationParams)
		{
			return new EventNotificationTemplateRegisterRequestBuilder(notificationTemplateSystemName, pushNotificationParams);
		}

		public static EventNotificationTemplateSendCommandRequestBuilder SendCommand(string notificationTemplateSystemName, PushNotificationParams pushNotificationParams, PushNotificationCommandType command)
		{
			return new EventNotificationTemplateSendCommandRequestBuilder(notificationTemplateSystemName, pushNotificationParams, command);
		}

		public static EventNotificationTemplateUpdateRequestBuilder Update(int id, EventNotificationTemplate eventNotificationTemplate)
		{
			return new EventNotificationTemplateUpdateRequestBuilder(id, eventNotificationTemplate);
		}

		public static EventNotificationTemplateUpdateStatusRequestBuilder UpdateStatus(int id, EventNotificationTemplateStatus status)
		{
			return new EventNotificationTemplateUpdateStatusRequestBuilder(id, status);
		}
	}
}
