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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class SocialGetRequestBuilder : StandaloneRequestBuilder<Social>
	{
		#region Constants
		public const string TYPE = "type";
		#endregion

		public SocialNetwork Type
		{
			set;
			get;
		}

		public SocialGetRequestBuilder()
			: base("social", "get")
		{
		}

		public SocialGetRequestBuilder(SocialNetwork type)
			: this()
		{
			this.Type = type;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("type"))
				kparams.AddIfNotNull("type", Type);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Social>(result);
		}
	}

	public class SocialGetByTokenRequestBuilder : StandaloneRequestBuilder<Social>
	{
		#region Constants
		public const string PARTNER_ID = "partnerId";
		public const string TOKEN = "token";
		public const string TYPE = "type";
		#endregion

		public int PartnerId
		{
			set;
			get;
		}
		public string Token
		{
			set;
			get;
		}
		public SocialNetwork Type
		{
			set;
			get;
		}

		public SocialGetByTokenRequestBuilder()
			: base("social", "getByToken")
		{
		}

		public SocialGetByTokenRequestBuilder(int partnerId, string token, SocialNetwork type)
			: this()
		{
			this.PartnerId = partnerId;
			this.Token = token;
			this.Type = type;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("token"))
				kparams.AddIfNotNull("token", Token);
			if (!isMapped("type"))
				kparams.AddIfNotNull("type", Type);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Social>(result);
		}
	}

	public class SocialGetConfigurationRequestBuilder : StandaloneRequestBuilder<SocialConfig>
	{
		#region Constants
		public const string PARTNER_ID = "partnerId";
		public const string TYPE = "type";
		#endregion

		public int PartnerId
		{
			set;
			get;
		}
		public SocialNetwork Type
		{
			set;
			get;
		}

		public SocialGetConfigurationRequestBuilder()
			: base("social", "getConfiguration")
		{
		}

		public SocialGetConfigurationRequestBuilder(int partnerId, SocialNetwork type)
			: this()
		{
			this.PartnerId = partnerId;
			this.Type = type;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("type"))
				kparams.AddIfNotNull("type", Type);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<SocialConfig>(result);
		}
	}

	public class SocialLoginRequestBuilder : StandaloneRequestBuilder<LoginResponse>
	{
		#region Constants
		public const string PARTNER_ID = "partnerId";
		public const string TOKEN = "token";
		public const string TYPE = "type";
		public const string UDID = "udid";
		#endregion

		public int PartnerId
		{
			set;
			get;
		}
		public string Token
		{
			set;
			get;
		}
		public SocialNetwork Type
		{
			set;
			get;
		}
		public string Udid
		{
			set;
			get;
		}

		public SocialLoginRequestBuilder()
			: base("social", "login")
		{
		}

		public SocialLoginRequestBuilder(int partnerId, string token, SocialNetwork type, string udid)
			: this()
		{
			this.PartnerId = partnerId;
			this.Token = token;
			this.Type = type;
			this.Udid = udid;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("token"))
				kparams.AddIfNotNull("token", Token);
			if (!isMapped("type"))
				kparams.AddIfNotNull("type", Type);
			if (!isMapped("udid"))
				kparams.AddIfNotNull("udid", Udid);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<LoginResponse>(result);
		}
	}

	public class SocialMergeRequestBuilder : StandaloneRequestBuilder<Social>
	{
		#region Constants
		public const string TOKEN = "token";
		public const string TYPE = "type";
		#endregion

		public string Token
		{
			set;
			get;
		}
		public SocialNetwork Type
		{
			set;
			get;
		}

		public SocialMergeRequestBuilder()
			: base("social", "merge")
		{
		}

		public SocialMergeRequestBuilder(string token, SocialNetwork type)
			: this()
		{
			this.Token = token;
			this.Type = type;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("token"))
				kparams.AddIfNotNull("token", Token);
			if (!isMapped("type"))
				kparams.AddIfNotNull("type", Type);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Social>(result);
		}
	}

	public class SocialRegisterRequestBuilder : StandaloneRequestBuilder<Social>
	{
		#region Constants
		public const string PARTNER_ID = "partnerId";
		public const string TOKEN = "token";
		public const string TYPE = "type";
		#endregion

		public int PartnerId
		{
			set;
			get;
		}
		public string Token
		{
			set;
			get;
		}
		public SocialNetwork Type
		{
			set;
			get;
		}

		public SocialRegisterRequestBuilder()
			: base("social", "register")
		{
		}

		public SocialRegisterRequestBuilder(int partnerId, string token, SocialNetwork type)
			: this()
		{
			this.PartnerId = partnerId;
			this.Token = token;
			this.Type = type;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("token"))
				kparams.AddIfNotNull("token", Token);
			if (!isMapped("type"))
				kparams.AddIfNotNull("type", Type);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Social>(result);
		}
	}

	public class SocialUnmergeRequestBuilder : StandaloneRequestBuilder<Social>
	{
		#region Constants
		public const string TYPE = "type";
		#endregion

		public SocialNetwork Type
		{
			set;
			get;
		}

		public SocialUnmergeRequestBuilder()
			: base("social", "unmerge")
		{
		}

		public SocialUnmergeRequestBuilder(SocialNetwork type)
			: this()
		{
			this.Type = type;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("type"))
				kparams.AddIfNotNull("type", Type);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Social>(result);
		}
	}


	public class SocialService
	{
		private SocialService()
		{
		}

		public static SocialGetRequestBuilder Get(SocialNetwork type)
		{
			return new SocialGetRequestBuilder(type);
		}

		public static SocialGetByTokenRequestBuilder GetByToken(int partnerId, string token, SocialNetwork type)
		{
			return new SocialGetByTokenRequestBuilder(partnerId, token, type);
		}

		public static SocialGetConfigurationRequestBuilder GetConfiguration(int partnerId, SocialNetwork type)
		{
			return new SocialGetConfigurationRequestBuilder(partnerId, type);
		}

		public static SocialLoginRequestBuilder Login(int partnerId, string token, SocialNetwork type, string udid = null)
		{
			return new SocialLoginRequestBuilder(partnerId, token, type, udid);
		}

		public static SocialMergeRequestBuilder Merge(string token, SocialNetwork type)
		{
			return new SocialMergeRequestBuilder(token, type);
		}

		public static SocialRegisterRequestBuilder Register(int partnerId, string token, SocialNetwork type)
		{
			return new SocialRegisterRequestBuilder(partnerId, token, type);
		}

		public static SocialUnmergeRequestBuilder Unmerge(SocialNetwork type)
		{
			return new SocialUnmergeRequestBuilder(type);
		}
	}
}
