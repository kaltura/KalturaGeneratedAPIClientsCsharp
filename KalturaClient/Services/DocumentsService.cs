// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class DocumentsAddFromEntryRequestBuilder : RequestBuilder<DocumentEntry>
	{
		#region Constants
		public const string SOURCE_ENTRY_ID = "sourceEntryId";
		public const string DOCUMENT_ENTRY = "documentEntry";
		public const string SOURCE_FLAVOR_PARAMS_ID = "sourceFlavorParamsId";
		#endregion

		public string SourceEntryId { get; set; }
		public DocumentEntry DocumentEntry { get; set; }
		public int SourceFlavorParamsId { get; set; }

		public DocumentsAddFromEntryRequestBuilder()
			: base("document_documents", "addFromEntry")
		{
		}

		public DocumentsAddFromEntryRequestBuilder(string sourceEntryId, DocumentEntry documentEntry, int sourceFlavorParamsId)
			: this()
		{
			this.SourceEntryId = sourceEntryId;
			this.DocumentEntry = documentEntry;
			this.SourceFlavorParamsId = sourceFlavorParamsId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("sourceEntryId"))
				kparams.AddIfNotNull("sourceEntryId", SourceEntryId);
			if (!isMapped("documentEntry"))
				kparams.AddIfNotNull("documentEntry", DocumentEntry);
			if (!isMapped("sourceFlavorParamsId"))
				kparams.AddIfNotNull("sourceFlavorParamsId", SourceFlavorParamsId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DocumentEntry>(result);
		}
	}

	public class DocumentsAddFromFlavorAssetRequestBuilder : RequestBuilder<DocumentEntry>
	{
		#region Constants
		public const string SOURCE_FLAVOR_ASSET_ID = "sourceFlavorAssetId";
		public const string DOCUMENT_ENTRY = "documentEntry";
		#endregion

		public string SourceFlavorAssetId { get; set; }
		public DocumentEntry DocumentEntry { get; set; }

		public DocumentsAddFromFlavorAssetRequestBuilder()
			: base("document_documents", "addFromFlavorAsset")
		{
		}

		public DocumentsAddFromFlavorAssetRequestBuilder(string sourceFlavorAssetId, DocumentEntry documentEntry)
			: this()
		{
			this.SourceFlavorAssetId = sourceFlavorAssetId;
			this.DocumentEntry = documentEntry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("sourceFlavorAssetId"))
				kparams.AddIfNotNull("sourceFlavorAssetId", SourceFlavorAssetId);
			if (!isMapped("documentEntry"))
				kparams.AddIfNotNull("documentEntry", DocumentEntry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DocumentEntry>(result);
		}
	}

	public class DocumentsAddFromUploadedFileRequestBuilder : RequestBuilder<DocumentEntry>
	{
		#region Constants
		public const string DOCUMENT_ENTRY = "documentEntry";
		public const string UPLOAD_TOKEN_ID = "uploadTokenId";
		#endregion

		public DocumentEntry DocumentEntry { get; set; }
		public string UploadTokenId { get; set; }

		public DocumentsAddFromUploadedFileRequestBuilder()
			: base("document_documents", "addFromUploadedFile")
		{
		}

		public DocumentsAddFromUploadedFileRequestBuilder(DocumentEntry documentEntry, string uploadTokenId)
			: this()
		{
			this.DocumentEntry = documentEntry;
			this.UploadTokenId = uploadTokenId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("documentEntry"))
				kparams.AddIfNotNull("documentEntry", DocumentEntry);
			if (!isMapped("uploadTokenId"))
				kparams.AddIfNotNull("uploadTokenId", UploadTokenId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DocumentEntry>(result);
		}
	}

	public class DocumentsApproveReplaceRequestBuilder : RequestBuilder<DocumentEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public DocumentsApproveReplaceRequestBuilder()
			: base("document_documents", "approveReplace")
		{
		}

		public DocumentsApproveReplaceRequestBuilder(string entryId)
			: this()
		{
			this.EntryId = entryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DocumentEntry>(result);
		}
	}

	public class DocumentsCancelReplaceRequestBuilder : RequestBuilder<DocumentEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public DocumentsCancelReplaceRequestBuilder()
			: base("document_documents", "cancelReplace")
		{
		}

		public DocumentsCancelReplaceRequestBuilder(string entryId)
			: this()
		{
			this.EntryId = entryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DocumentEntry>(result);
		}
	}

	public class DocumentsConvertRequestBuilder : RequestBuilder<long>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		public const string DYNAMIC_CONVERSION_ATTRIBUTES = "dynamicConversionAttributes";
		#endregion

		public string EntryId { get; set; }
		public int ConversionProfileId { get; set; }
		public IList<ConversionAttribute> DynamicConversionAttributes { get; set; }

		public DocumentsConvertRequestBuilder()
			: base("document_documents", "convert")
		{
		}

		public DocumentsConvertRequestBuilder(string entryId, int conversionProfileId, IList<ConversionAttribute> dynamicConversionAttributes)
			: this()
		{
			this.EntryId = entryId;
			this.ConversionProfileId = conversionProfileId;
			this.DynamicConversionAttributes = dynamicConversionAttributes;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("conversionProfileId"))
				kparams.AddIfNotNull("conversionProfileId", ConversionProfileId);
			if (!isMapped("dynamicConversionAttributes"))
				kparams.AddIfNotNull("dynamicConversionAttributes", DynamicConversionAttributes);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<long>();
		}
	}

	public class DocumentsConvertPptToSwfRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public DocumentsConvertPptToSwfRequestBuilder()
			: base("document_documents", "convertPptToSwf")
		{
		}

		public DocumentsConvertPptToSwfRequestBuilder(string entryId)
			: this()
		{
			this.EntryId = entryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
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

	public class DocumentsDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public DocumentsDeleteRequestBuilder()
			: base("document_documents", "delete")
		{
		}

		public DocumentsDeleteRequestBuilder(string entryId)
			: this()
		{
			this.EntryId = entryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
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

	public class DocumentsGetRequestBuilder : RequestBuilder<DocumentEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string VERSION = "version";
		#endregion

		public string EntryId { get; set; }
		public int Version { get; set; }

		public DocumentsGetRequestBuilder()
			: base("document_documents", "get")
		{
		}

		public DocumentsGetRequestBuilder(string entryId, int version)
			: this()
		{
			this.EntryId = entryId;
			this.Version = version;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("version"))
				kparams.AddIfNotNull("version", Version);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DocumentEntry>(result);
		}
	}

	public class DocumentsListRequestBuilder : RequestBuilder<ListResponse<DocumentEntry>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public DocumentEntryFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public DocumentsListRequestBuilder()
			: base("document_documents", "list")
		{
		}

		public DocumentsListRequestBuilder(DocumentEntryFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<DocumentEntry>>(result);
		}
	}

	public class DocumentsUpdateRequestBuilder : RequestBuilder<DocumentEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string DOCUMENT_ENTRY = "documentEntry";
		#endregion

		public string EntryId { get; set; }
		public DocumentEntry DocumentEntry { get; set; }

		public DocumentsUpdateRequestBuilder()
			: base("document_documents", "update")
		{
		}

		public DocumentsUpdateRequestBuilder(string entryId, DocumentEntry documentEntry)
			: this()
		{
			this.EntryId = entryId;
			this.DocumentEntry = documentEntry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("documentEntry"))
				kparams.AddIfNotNull("documentEntry", DocumentEntry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DocumentEntry>(result);
		}
	}

	public class DocumentsUpdateContentRequestBuilder : RequestBuilder<DocumentEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string RESOURCE = "resource";
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		#endregion

		public string EntryId { get; set; }
		public Resource Resource { get; set; }
		public int ConversionProfileId { get; set; }

		public DocumentsUpdateContentRequestBuilder()
			: base("document_documents", "updateContent")
		{
		}

		public DocumentsUpdateContentRequestBuilder(string entryId, Resource resource, int conversionProfileId)
			: this()
		{
			this.EntryId = entryId;
			this.Resource = resource;
			this.ConversionProfileId = conversionProfileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("resource"))
				kparams.AddIfNotNull("resource", Resource);
			if (!isMapped("conversionProfileId"))
				kparams.AddIfNotNull("conversionProfileId", ConversionProfileId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DocumentEntry>(result);
		}
	}

	public class DocumentsUploadRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		#endregion

		public Stream FileData { get; set; }
		public string FileData_FileName { get; set; }

		public DocumentsUploadRequestBuilder()
			: base("document_documents", "upload")
		{
		}

		public DocumentsUploadRequestBuilder(Stream fileData)
			: this()
		{
			this.FileData = fileData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			kfiles.Add("fileData", new FileData(FileData, FileData_FileName));
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<string>();
		}
	}


	public class DocumentsService
	{
		private DocumentsService()
		{
		}

		public static DocumentsAddFromEntryRequestBuilder AddFromEntry(string sourceEntryId, DocumentEntry documentEntry = null, int sourceFlavorParamsId = Int32.MinValue)
		{
			return new DocumentsAddFromEntryRequestBuilder(sourceEntryId, documentEntry, sourceFlavorParamsId);
		}

		public static DocumentsAddFromFlavorAssetRequestBuilder AddFromFlavorAsset(string sourceFlavorAssetId, DocumentEntry documentEntry = null)
		{
			return new DocumentsAddFromFlavorAssetRequestBuilder(sourceFlavorAssetId, documentEntry);
		}

		public static DocumentsAddFromUploadedFileRequestBuilder AddFromUploadedFile(DocumentEntry documentEntry, string uploadTokenId)
		{
			return new DocumentsAddFromUploadedFileRequestBuilder(documentEntry, uploadTokenId);
		}

		public static DocumentsApproveReplaceRequestBuilder ApproveReplace(string entryId)
		{
			return new DocumentsApproveReplaceRequestBuilder(entryId);
		}

		public static DocumentsCancelReplaceRequestBuilder CancelReplace(string entryId)
		{
			return new DocumentsCancelReplaceRequestBuilder(entryId);
		}

		public static DocumentsConvertRequestBuilder Convert(string entryId, int conversionProfileId = Int32.MinValue, IList<ConversionAttribute> dynamicConversionAttributes = null)
		{
			return new DocumentsConvertRequestBuilder(entryId, conversionProfileId, dynamicConversionAttributes);
		}

		public static DocumentsConvertPptToSwfRequestBuilder ConvertPptToSwf(string entryId)
		{
			return new DocumentsConvertPptToSwfRequestBuilder(entryId);
		}

		public static DocumentsDeleteRequestBuilder Delete(string entryId)
		{
			return new DocumentsDeleteRequestBuilder(entryId);
		}

		public static DocumentsGetRequestBuilder Get(string entryId, int version = -1)
		{
			return new DocumentsGetRequestBuilder(entryId, version);
		}

		public static DocumentsListRequestBuilder List(DocumentEntryFilter filter = null, FilterPager pager = null)
		{
			return new DocumentsListRequestBuilder(filter, pager);
		}

		public static DocumentsUpdateRequestBuilder Update(string entryId, DocumentEntry documentEntry)
		{
			return new DocumentsUpdateRequestBuilder(entryId, documentEntry);
		}

		public static DocumentsUpdateContentRequestBuilder UpdateContent(string entryId, Resource resource, int conversionProfileId = Int32.MinValue)
		{
			return new DocumentsUpdateContentRequestBuilder(entryId, resource, conversionProfileId);
		}

		public static DocumentsUploadRequestBuilder Upload(Stream fileData)
		{
			return new DocumentsUploadRequestBuilder(fileData);
		}
	}
}
