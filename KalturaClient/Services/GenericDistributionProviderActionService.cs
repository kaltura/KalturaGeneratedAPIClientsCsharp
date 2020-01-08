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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class GenericDistributionProviderActionAddRequestBuilder : RequestBuilder<GenericDistributionProviderAction>
	{
		#region Constants
		public const string GENERIC_DISTRIBUTION_PROVIDER_ACTION = "genericDistributionProviderAction";
		#endregion

		public GenericDistributionProviderAction GenericDistributionProviderAction { get; set; }

		public GenericDistributionProviderActionAddRequestBuilder()
			: base("contentdistribution_genericdistributionprovideraction", "add")
		{
		}

		public GenericDistributionProviderActionAddRequestBuilder(GenericDistributionProviderAction genericDistributionProviderAction)
			: this()
		{
			this.GenericDistributionProviderAction = genericDistributionProviderAction;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("genericDistributionProviderAction"))
				kparams.AddIfNotNull("genericDistributionProviderAction", GenericDistributionProviderAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GenericDistributionProviderAction>(result);
		}
	}

	public class GenericDistributionProviderActionAddMrssTransformRequestBuilder : RequestBuilder<GenericDistributionProviderAction>
	{
		#region Constants
		public const string ID = "id";
		public const string XSL_DATA = "xslData";
		#endregion

		public int Id { get; set; }
		public string XslData { get; set; }

		public GenericDistributionProviderActionAddMrssTransformRequestBuilder()
			: base("contentdistribution_genericdistributionprovideraction", "addMrssTransform")
		{
		}

		public GenericDistributionProviderActionAddMrssTransformRequestBuilder(int id, string xslData)
			: this()
		{
			this.Id = id;
			this.XslData = xslData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("xslData"))
				kparams.AddIfNotNull("xslData", XslData);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GenericDistributionProviderAction>(result);
		}
	}

	public class GenericDistributionProviderActionAddMrssTransformFromFileRequestBuilder : RequestBuilder<GenericDistributionProviderAction>
	{
		#region Constants
		public const string ID = "id";
		public const string XSL_FILE = "xslFile";
		#endregion

		public int Id { get; set; }
		public Stream XslFile { get; set; }
		public string XslFile_FileName { get; set; }

		public GenericDistributionProviderActionAddMrssTransformFromFileRequestBuilder()
			: base("contentdistribution_genericdistributionprovideraction", "addMrssTransformFromFile")
		{
		}

		public GenericDistributionProviderActionAddMrssTransformFromFileRequestBuilder(int id, Stream xslFile)
			: this()
		{
			this.Id = id;
			this.XslFile = xslFile;
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
			kfiles.Add("xslFile", new FileData(XslFile, XslFile_FileName));
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GenericDistributionProviderAction>(result);
		}
	}

	public class GenericDistributionProviderActionAddMrssValidateRequestBuilder : RequestBuilder<GenericDistributionProviderAction>
	{
		#region Constants
		public const string ID = "id";
		public const string XSD_DATA = "xsdData";
		#endregion

		public int Id { get; set; }
		public string XsdData { get; set; }

		public GenericDistributionProviderActionAddMrssValidateRequestBuilder()
			: base("contentdistribution_genericdistributionprovideraction", "addMrssValidate")
		{
		}

		public GenericDistributionProviderActionAddMrssValidateRequestBuilder(int id, string xsdData)
			: this()
		{
			this.Id = id;
			this.XsdData = xsdData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("xsdData"))
				kparams.AddIfNotNull("xsdData", XsdData);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GenericDistributionProviderAction>(result);
		}
	}

	public class GenericDistributionProviderActionAddMrssValidateFromFileRequestBuilder : RequestBuilder<GenericDistributionProviderAction>
	{
		#region Constants
		public const string ID = "id";
		public const string XSD_FILE = "xsdFile";
		#endregion

		public int Id { get; set; }
		public Stream XsdFile { get; set; }
		public string XsdFile_FileName { get; set; }

		public GenericDistributionProviderActionAddMrssValidateFromFileRequestBuilder()
			: base("contentdistribution_genericdistributionprovideraction", "addMrssValidateFromFile")
		{
		}

		public GenericDistributionProviderActionAddMrssValidateFromFileRequestBuilder(int id, Stream xsdFile)
			: this()
		{
			this.Id = id;
			this.XsdFile = xsdFile;
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
			kfiles.Add("xsdFile", new FileData(XsdFile, XsdFile_FileName));
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GenericDistributionProviderAction>(result);
		}
	}

	public class GenericDistributionProviderActionAddResultsTransformRequestBuilder : RequestBuilder<GenericDistributionProviderAction>
	{
		#region Constants
		public const string ID = "id";
		public const string TRANSFORM_DATA = "transformData";
		#endregion

		public int Id { get; set; }
		public string TransformData { get; set; }

		public GenericDistributionProviderActionAddResultsTransformRequestBuilder()
			: base("contentdistribution_genericdistributionprovideraction", "addResultsTransform")
		{
		}

		public GenericDistributionProviderActionAddResultsTransformRequestBuilder(int id, string transformData)
			: this()
		{
			this.Id = id;
			this.TransformData = transformData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("transformData"))
				kparams.AddIfNotNull("transformData", TransformData);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GenericDistributionProviderAction>(result);
		}
	}

	public class GenericDistributionProviderActionAddResultsTransformFromFileRequestBuilder : RequestBuilder<GenericDistributionProviderAction>
	{
		#region Constants
		public const string ID = "id";
		public const string TRANSFORM_FILE = "transformFile";
		#endregion

		public int Id { get; set; }
		public Stream TransformFile { get; set; }
		public string TransformFile_FileName { get; set; }

		public GenericDistributionProviderActionAddResultsTransformFromFileRequestBuilder()
			: base("contentdistribution_genericdistributionprovideraction", "addResultsTransformFromFile")
		{
		}

		public GenericDistributionProviderActionAddResultsTransformFromFileRequestBuilder(int id, Stream transformFile)
			: this()
		{
			this.Id = id;
			this.TransformFile = transformFile;
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
			kfiles.Add("transformFile", new FileData(TransformFile, TransformFile_FileName));
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GenericDistributionProviderAction>(result);
		}
	}

	public class GenericDistributionProviderActionDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public GenericDistributionProviderActionDeleteRequestBuilder()
			: base("contentdistribution_genericdistributionprovideraction", "delete")
		{
		}

		public GenericDistributionProviderActionDeleteRequestBuilder(int id)
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

	public class GenericDistributionProviderActionDeleteByProviderIdRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string GENERIC_DISTRIBUTION_PROVIDER_ID = "genericDistributionProviderId";
		public const string ACTION_TYPE = "actionType";
		#endregion

		public int GenericDistributionProviderId { get; set; }
		public DistributionAction ActionType { get; set; }

		public GenericDistributionProviderActionDeleteByProviderIdRequestBuilder()
			: base("contentdistribution_genericdistributionprovideraction", "deleteByProviderId")
		{
		}

		public GenericDistributionProviderActionDeleteByProviderIdRequestBuilder(int genericDistributionProviderId, DistributionAction actionType)
			: this()
		{
			this.GenericDistributionProviderId = genericDistributionProviderId;
			this.ActionType = actionType;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("genericDistributionProviderId"))
				kparams.AddIfNotNull("genericDistributionProviderId", GenericDistributionProviderId);
			if (!isMapped("actionType"))
				kparams.AddIfNotNull("actionType", ActionType);
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

	public class GenericDistributionProviderActionGetRequestBuilder : RequestBuilder<GenericDistributionProviderAction>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public GenericDistributionProviderActionGetRequestBuilder()
			: base("contentdistribution_genericdistributionprovideraction", "get")
		{
		}

		public GenericDistributionProviderActionGetRequestBuilder(int id)
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
			return ObjectFactory.Create<GenericDistributionProviderAction>(result);
		}
	}

	public class GenericDistributionProviderActionGetByProviderIdRequestBuilder : RequestBuilder<GenericDistributionProviderAction>
	{
		#region Constants
		public const string GENERIC_DISTRIBUTION_PROVIDER_ID = "genericDistributionProviderId";
		public const string ACTION_TYPE = "actionType";
		#endregion

		public int GenericDistributionProviderId { get; set; }
		public DistributionAction ActionType { get; set; }

		public GenericDistributionProviderActionGetByProviderIdRequestBuilder()
			: base("contentdistribution_genericdistributionprovideraction", "getByProviderId")
		{
		}

		public GenericDistributionProviderActionGetByProviderIdRequestBuilder(int genericDistributionProviderId, DistributionAction actionType)
			: this()
		{
			this.GenericDistributionProviderId = genericDistributionProviderId;
			this.ActionType = actionType;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("genericDistributionProviderId"))
				kparams.AddIfNotNull("genericDistributionProviderId", GenericDistributionProviderId);
			if (!isMapped("actionType"))
				kparams.AddIfNotNull("actionType", ActionType);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GenericDistributionProviderAction>(result);
		}
	}

	public class GenericDistributionProviderActionListRequestBuilder : RequestBuilder<ListResponse<GenericDistributionProviderAction>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public GenericDistributionProviderActionFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public GenericDistributionProviderActionListRequestBuilder()
			: base("contentdistribution_genericdistributionprovideraction", "list")
		{
		}

		public GenericDistributionProviderActionListRequestBuilder(GenericDistributionProviderActionFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<GenericDistributionProviderAction>>(result);
		}
	}

	public class GenericDistributionProviderActionUpdateRequestBuilder : RequestBuilder<GenericDistributionProviderAction>
	{
		#region Constants
		public const string ID = "id";
		public const string GENERIC_DISTRIBUTION_PROVIDER_ACTION = "genericDistributionProviderAction";
		#endregion

		public int Id { get; set; }
		public GenericDistributionProviderAction GenericDistributionProviderAction { get; set; }

		public GenericDistributionProviderActionUpdateRequestBuilder()
			: base("contentdistribution_genericdistributionprovideraction", "update")
		{
		}

		public GenericDistributionProviderActionUpdateRequestBuilder(int id, GenericDistributionProviderAction genericDistributionProviderAction)
			: this()
		{
			this.Id = id;
			this.GenericDistributionProviderAction = genericDistributionProviderAction;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("genericDistributionProviderAction"))
				kparams.AddIfNotNull("genericDistributionProviderAction", GenericDistributionProviderAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GenericDistributionProviderAction>(result);
		}
	}

	public class GenericDistributionProviderActionUpdateByProviderIdRequestBuilder : RequestBuilder<GenericDistributionProviderAction>
	{
		#region Constants
		public const string GENERIC_DISTRIBUTION_PROVIDER_ID = "genericDistributionProviderId";
		public const string ACTION_TYPE = "actionType";
		public const string GENERIC_DISTRIBUTION_PROVIDER_ACTION = "genericDistributionProviderAction";
		#endregion

		public int GenericDistributionProviderId { get; set; }
		public DistributionAction ActionType { get; set; }
		public GenericDistributionProviderAction GenericDistributionProviderAction { get; set; }

		public GenericDistributionProviderActionUpdateByProviderIdRequestBuilder()
			: base("contentdistribution_genericdistributionprovideraction", "updateByProviderId")
		{
		}

		public GenericDistributionProviderActionUpdateByProviderIdRequestBuilder(int genericDistributionProviderId, DistributionAction actionType, GenericDistributionProviderAction genericDistributionProviderAction)
			: this()
		{
			this.GenericDistributionProviderId = genericDistributionProviderId;
			this.ActionType = actionType;
			this.GenericDistributionProviderAction = genericDistributionProviderAction;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("genericDistributionProviderId"))
				kparams.AddIfNotNull("genericDistributionProviderId", GenericDistributionProviderId);
			if (!isMapped("actionType"))
				kparams.AddIfNotNull("actionType", ActionType);
			if (!isMapped("genericDistributionProviderAction"))
				kparams.AddIfNotNull("genericDistributionProviderAction", GenericDistributionProviderAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GenericDistributionProviderAction>(result);
		}
	}


	public class GenericDistributionProviderActionService
	{
		private GenericDistributionProviderActionService()
		{
		}

		public static GenericDistributionProviderActionAddRequestBuilder Add(GenericDistributionProviderAction genericDistributionProviderAction)
		{
			return new GenericDistributionProviderActionAddRequestBuilder(genericDistributionProviderAction);
		}

		public static GenericDistributionProviderActionAddMrssTransformRequestBuilder AddMrssTransform(int id, string xslData)
		{
			return new GenericDistributionProviderActionAddMrssTransformRequestBuilder(id, xslData);
		}

		public static GenericDistributionProviderActionAddMrssTransformFromFileRequestBuilder AddMrssTransformFromFile(int id, Stream xslFile)
		{
			return new GenericDistributionProviderActionAddMrssTransformFromFileRequestBuilder(id, xslFile);
		}

		public static GenericDistributionProviderActionAddMrssValidateRequestBuilder AddMrssValidate(int id, string xsdData)
		{
			return new GenericDistributionProviderActionAddMrssValidateRequestBuilder(id, xsdData);
		}

		public static GenericDistributionProviderActionAddMrssValidateFromFileRequestBuilder AddMrssValidateFromFile(int id, Stream xsdFile)
		{
			return new GenericDistributionProviderActionAddMrssValidateFromFileRequestBuilder(id, xsdFile);
		}

		public static GenericDistributionProviderActionAddResultsTransformRequestBuilder AddResultsTransform(int id, string transformData)
		{
			return new GenericDistributionProviderActionAddResultsTransformRequestBuilder(id, transformData);
		}

		public static GenericDistributionProviderActionAddResultsTransformFromFileRequestBuilder AddResultsTransformFromFile(int id, Stream transformFile)
		{
			return new GenericDistributionProviderActionAddResultsTransformFromFileRequestBuilder(id, transformFile);
		}

		public static GenericDistributionProviderActionDeleteRequestBuilder Delete(int id)
		{
			return new GenericDistributionProviderActionDeleteRequestBuilder(id);
		}

		public static GenericDistributionProviderActionDeleteByProviderIdRequestBuilder DeleteByProviderId(int genericDistributionProviderId, DistributionAction actionType)
		{
			return new GenericDistributionProviderActionDeleteByProviderIdRequestBuilder(genericDistributionProviderId, actionType);
		}

		public static GenericDistributionProviderActionGetRequestBuilder Get(int id)
		{
			return new GenericDistributionProviderActionGetRequestBuilder(id);
		}

		public static GenericDistributionProviderActionGetByProviderIdRequestBuilder GetByProviderId(int genericDistributionProviderId, DistributionAction actionType)
		{
			return new GenericDistributionProviderActionGetByProviderIdRequestBuilder(genericDistributionProviderId, actionType);
		}

		public static GenericDistributionProviderActionListRequestBuilder List(GenericDistributionProviderActionFilter filter = null, FilterPager pager = null)
		{
			return new GenericDistributionProviderActionListRequestBuilder(filter, pager);
		}

		public static GenericDistributionProviderActionUpdateRequestBuilder Update(int id, GenericDistributionProviderAction genericDistributionProviderAction)
		{
			return new GenericDistributionProviderActionUpdateRequestBuilder(id, genericDistributionProviderAction);
		}

		public static GenericDistributionProviderActionUpdateByProviderIdRequestBuilder UpdateByProviderId(int genericDistributionProviderId, DistributionAction actionType, GenericDistributionProviderAction genericDistributionProviderAction)
		{
			return new GenericDistributionProviderActionUpdateByProviderIdRequestBuilder(genericDistributionProviderId, actionType, genericDistributionProviderAction);
		}
	}
}
