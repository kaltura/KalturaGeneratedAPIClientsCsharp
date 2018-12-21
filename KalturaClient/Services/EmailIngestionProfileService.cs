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
	public class EmailIngestionProfileAddRequestBuilder : RequestBuilder<EmailIngestionProfile>
	{
		#region Constants
		public const string EMAIL_IP = "EmailIP";
		#endregion

		public EmailIngestionProfile EmailIP
		{
			set;
			get;
		}

		public EmailIngestionProfileAddRequestBuilder()
			: base("emailingestionprofile", "add")
		{
		}

		public EmailIngestionProfileAddRequestBuilder(EmailIngestionProfile EmailIP)
			: this()
		{
			this.EmailIP = EmailIP;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("EmailIP"))
				kparams.AddIfNotNull("EmailIP", EmailIP);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EmailIngestionProfile>(result);
		}
	}

	public class EmailIngestionProfileAddMediaEntryRequestBuilder : RequestBuilder<MediaEntry>
	{
		#region Constants
		public const string MEDIA_ENTRY = "mediaEntry";
		public const string UPLOAD_TOKEN_ID = "uploadTokenId";
		public const string EMAIL_PROF_ID = "emailProfId";
		public const string FROM_ADDRESS = "fromAddress";
		public const string EMAIL_MSG_ID = "emailMsgId";
		#endregion

		public MediaEntry MediaEntry
		{
			set;
			get;
		}
		public string UploadTokenId
		{
			set;
			get;
		}
		public int EmailProfId
		{
			set;
			get;
		}
		public string FromAddress
		{
			set;
			get;
		}
		public string EmailMsgId
		{
			set;
			get;
		}

		public EmailIngestionProfileAddMediaEntryRequestBuilder()
			: base("emailingestionprofile", "addMediaEntry")
		{
		}

		public EmailIngestionProfileAddMediaEntryRequestBuilder(MediaEntry mediaEntry, string uploadTokenId, int emailProfId, string fromAddress, string emailMsgId)
			: this()
		{
			this.MediaEntry = mediaEntry;
			this.UploadTokenId = uploadTokenId;
			this.EmailProfId = emailProfId;
			this.FromAddress = fromAddress;
			this.EmailMsgId = emailMsgId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("mediaEntry"))
				kparams.AddIfNotNull("mediaEntry", MediaEntry);
			if (!isMapped("uploadTokenId"))
				kparams.AddIfNotNull("uploadTokenId", UploadTokenId);
			if (!isMapped("emailProfId"))
				kparams.AddIfNotNull("emailProfId", EmailProfId);
			if (!isMapped("fromAddress"))
				kparams.AddIfNotNull("fromAddress", FromAddress);
			if (!isMapped("emailMsgId"))
				kparams.AddIfNotNull("emailMsgId", EmailMsgId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class EmailIngestionProfileDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public EmailIngestionProfileDeleteRequestBuilder()
			: base("emailingestionprofile", "delete")
		{
		}

		public EmailIngestionProfileDeleteRequestBuilder(int id)
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

	public class EmailIngestionProfileGetRequestBuilder : RequestBuilder<EmailIngestionProfile>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public EmailIngestionProfileGetRequestBuilder()
			: base("emailingestionprofile", "get")
		{
		}

		public EmailIngestionProfileGetRequestBuilder(int id)
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
			return ObjectFactory.Create<EmailIngestionProfile>(result);
		}
	}

	public class EmailIngestionProfileGetByEmailAddressRequestBuilder : RequestBuilder<EmailIngestionProfile>
	{
		#region Constants
		public const string EMAIL_ADDRESS = "emailAddress";
		#endregion

		public string EmailAddress
		{
			set;
			get;
		}

		public EmailIngestionProfileGetByEmailAddressRequestBuilder()
			: base("emailingestionprofile", "getByEmailAddress")
		{
		}

		public EmailIngestionProfileGetByEmailAddressRequestBuilder(string emailAddress)
			: this()
		{
			this.EmailAddress = emailAddress;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("emailAddress"))
				kparams.AddIfNotNull("emailAddress", EmailAddress);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EmailIngestionProfile>(result);
		}
	}

	public class EmailIngestionProfileUpdateRequestBuilder : RequestBuilder<EmailIngestionProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string EMAIL_IP = "EmailIP";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public EmailIngestionProfile EmailIP
		{
			set;
			get;
		}

		public EmailIngestionProfileUpdateRequestBuilder()
			: base("emailingestionprofile", "update")
		{
		}

		public EmailIngestionProfileUpdateRequestBuilder(int id, EmailIngestionProfile EmailIP)
			: this()
		{
			this.Id = id;
			this.EmailIP = EmailIP;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("EmailIP"))
				kparams.AddIfNotNull("EmailIP", EmailIP);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EmailIngestionProfile>(result);
		}
	}


	public class EmailIngestionProfileService
	{
		private EmailIngestionProfileService()
		{
		}

		public static EmailIngestionProfileAddRequestBuilder Add(EmailIngestionProfile EmailIP)
		{
			return new EmailIngestionProfileAddRequestBuilder(EmailIP);
		}

		public static EmailIngestionProfileAddMediaEntryRequestBuilder AddMediaEntry(MediaEntry mediaEntry, string uploadTokenId, int emailProfId, string fromAddress, string emailMsgId)
		{
			return new EmailIngestionProfileAddMediaEntryRequestBuilder(mediaEntry, uploadTokenId, emailProfId, fromAddress, emailMsgId);
		}

		public static EmailIngestionProfileDeleteRequestBuilder Delete(int id)
		{
			return new EmailIngestionProfileDeleteRequestBuilder(id);
		}

		public static EmailIngestionProfileGetRequestBuilder Get(int id)
		{
			return new EmailIngestionProfileGetRequestBuilder(id);
		}

		public static EmailIngestionProfileGetByEmailAddressRequestBuilder GetByEmailAddress(string emailAddress)
		{
			return new EmailIngestionProfileGetByEmailAddressRequestBuilder(emailAddress);
		}

		public static EmailIngestionProfileUpdateRequestBuilder Update(int id, EmailIngestionProfile EmailIP)
		{
			return new EmailIngestionProfileUpdateRequestBuilder(id, EmailIP);
		}
	}
}
