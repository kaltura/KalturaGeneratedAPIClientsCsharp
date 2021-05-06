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
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Kaltura.Types;
using Newtonsoft.Json.Linq;

namespace Kaltura
{
	public static class ObjectFactory
	{
		private static Regex prefixRegex = new Regex("^Kaltura");
		
		public static T Create<T>(JToken jToken) where T : ObjectBase
		{
			if (jToken["objectType"] == null)
			{
				return null;
			}
				
			string className = jToken["objectType"].Value<string>();
			className = prefixRegex.Replace(className, "");
			
			Type type = Type.GetType("Kaltura.Types." + className);
			if (type == null)
			{
				type = typeof(T);
			}
			
			if (type == null)
				throw new SerializationException("Invalid object type");
			
			return (T)System.Activator.CreateInstance(type, jToken);
		}
		
		public static IListResponse Create(JToken jToken)
		{
			if (jToken["objectType"] == null)
			{
				return null;
			}
			
			string className = jToken["objectType"].Value<string>();
			switch (className)
			{
				case "KalturaFileSyncListResponse":
					return new ListResponse<FileSync>(jToken);
				case "KalturaBatchJobListResponse":
					return new ListResponse<BatchJob>(jToken);
				case "KalturaMediaInfoListResponse":
					return new ListResponse<MediaInfo>(jToken);
				case "KalturaFlavorParamsOutputListResponse":
					return new ListResponse<FlavorParamsOutput>(jToken);
				case "KalturaThumbParamsOutputListResponse":
					return new ListResponse<ThumbParamsOutput>(jToken);
				case "KalturaAccessControlListResponse":
					return new ListResponse<AccessControl>(jToken);
				case "KalturaAccessControlProfileListResponse":
					return new ListResponse<AccessControlProfile>(jToken);
				case "KalturaAnnotationListResponse":
					return new ListResponse<Annotation>(jToken);
				case "KalturaAppTokenListResponse":
					return new ListResponse<AppToken>(jToken);
				case "KalturaAttachmentAssetListResponse":
					return new ListResponse<AttachmentAsset>(jToken);
				case "KalturaAuditTrailListResponse":
					return new ListResponse<AuditTrail>(jToken);
				case "KalturaBaseEntryListResponse":
					return new ListResponse<BaseEntry>(jToken);
				case "KalturaBaseSyndicationFeedListResponse":
					return new ListResponse<BaseSyndicationFeed>(jToken);
				case "KalturaBeaconListResponse":
					return new ListResponse<Beacon>(jToken);
				case "KalturaBulkUploadListResponse":
					return new ListResponse<BulkUpload>(jToken);
				case "KalturaBusinessProcessServerListResponse":
					return new ListResponse<BusinessProcessServer>(jToken);
				case "KalturaCaptionAssetItemListResponse":
					return new ListResponse<CaptionAssetItem>(jToken);
				case "KalturaCaptionAssetListResponse":
					return new ListResponse<CaptionAsset>(jToken);
				case "KalturaCaptionParamsListResponse":
					return new ListResponse<CaptionParams>(jToken);
				case "KalturaCategoryEntryListResponse":
					return new ListResponse<CategoryEntry>(jToken);
				case "KalturaCategoryListResponse":
					return new ListResponse<Category>(jToken);
				case "KalturaCategoryUserListResponse":
					return new ListResponse<CategoryUser>(jToken);
				case "KalturaConfMapsListResponse":
					return new ListResponse<ConfMaps>(jToken);
				case "KalturaControlPanelCommandListResponse":
					return new ListResponse<ControlPanelCommand>(jToken);
				case "KalturaConversionProfileAssetParamsListResponse":
					return new ListResponse<ConversionProfileAssetParams>(jToken);
				case "KalturaConversionProfileListResponse":
					return new ListResponse<ConversionProfile>(jToken);
				case "KalturaCuePointListResponse":
					return new ListResponse<CuePoint>(jToken);
				case "KalturaDataListResponse":
					return new ListResponse<DataEntry>(jToken);
				case "KalturaDeliveryProfileListResponse":
					return new ListResponse<DeliveryProfile>(jToken);
				case "KalturaDistributionProfileListResponse":
					return new ListResponse<DistributionProfile>(jToken);
				case "KalturaDistributionProviderListResponse":
					return new ListResponse<DistributionProvider>(jToken);
				case "KalturaDocumentListResponse":
					return new ListResponse<DocumentEntry>(jToken);
				case "KalturaDrmPolicyListResponse":
					return new ListResponse<DrmPolicy>(jToken);
				case "KalturaDrmProfileListResponse":
					return new ListResponse<DrmProfile>(jToken);
				case "KalturaDropFolderFileListResponse":
					return new ListResponse<DropFolderFile>(jToken);
				case "KalturaDropFolderListResponse":
					return new ListResponse<DropFolder>(jToken);
				case "KalturaESearchHistoryListResponse":
					return new ListResponse<ESearchHistory>(jToken);
				case "KalturaEntryDistributionListResponse":
					return new ListResponse<EntryDistribution>(jToken);
				case "KalturaEntryServerNodeListResponse":
					return new ListResponse<EntryServerNode>(jToken);
				case "KalturaEntryVendorTaskListResponse":
					return new ListResponse<EntryVendorTask>(jToken);
				case "KalturaEventNotificationTemplateListResponse":
					return new ListResponse<EventNotificationTemplate>(jToken);
				case "KalturaExternalMediaEntryListResponse":
					return new ListResponse<ExternalMediaEntry>(jToken);
				case "KalturaFeatureStatusListResponse":
					return new ListResponse<FeatureStatus>(jToken);
				case "KalturaFileAssetListResponse":
					return new ListResponse<FileAsset>(jToken);
				case "KalturaFlavorAssetListResponse":
					return new ListResponse<FlavorAsset>(jToken);
				case "KalturaFlavorParamsListResponse":
					return new ListResponse<FlavorParams>(jToken);
				case "KalturaGenericDistributionProviderActionListResponse":
					return new ListResponse<GenericDistributionProviderAction>(jToken);
				case "KalturaGenericDistributionProviderListResponse":
					return new ListResponse<GenericDistributionProvider>(jToken);
				case "KalturaGroupListResponse":
					return new ListResponse<Group_>(jToken);
				case "KalturaGroupUserListResponse":
					return new ListResponse<GroupUser>(jToken);
				case "KalturaLikeListResponse":
					return new ListResponse<Like>(jToken);
				case "KalturaLiveChannelListResponse":
					return new ListResponse<LiveChannel>(jToken);
				case "KalturaLiveChannelSegmentListResponse":
					return new ListResponse<LiveChannelSegment>(jToken);
				case "KalturaLiveStreamListResponse":
					return new ListResponse<LiveStreamEntry>(jToken);
				case "KalturaMediaListResponse":
					return new ListResponse<MediaEntry>(jToken);
				case "KalturaMetadataListResponse":
					return new ListResponse<Metadata>(jToken);
				case "KalturaMetadataProfileFieldListResponse":
					return new ListResponse<MetadataProfileField>(jToken);
				case "KalturaMetadataProfileListResponse":
					return new ListResponse<MetadataProfile>(jToken);
				case "KalturaMixListResponse":
					return new ListResponse<MixEntry>(jToken);
				case "KalturaModerationFlagListResponse":
					return new ListResponse<ModerationFlag>(jToken);
				case "KalturaObjectListResponse":
					return new ListResponse<ObjectBase>(jToken);
				case "KalturaPartnerListResponse":
					return new ListResponse<Partner>(jToken);
				case "KalturaPartnerUsageListResponse":
					return new ListResponse<VarPartnerUsageItem>(jToken);
				case "KalturaPermissionItemListResponse":
					return new ListResponse<PermissionItem>(jToken);
				case "KalturaPermissionListResponse":
					return new ListResponse<Permission>(jToken);
				case "KalturaPlaylistListResponse":
					return new ListResponse<Playlist>(jToken);
				case "KalturaQuizListResponse":
					return new ListResponse<Quiz>(jToken);
				case "KalturaRatingCountListResponse":
					return new ListResponse<RatingCount>(jToken);
				case "KalturaReachProfileListResponse":
					return new ListResponse<ReachProfile>(jToken);
				case "KalturaRemotePathListResponse":
					return new ListResponse<RemotePath>(jToken);
				case "KalturaReportListResponse":
					return new ListResponse<Report>(jToken);
				case "KalturaResponseProfileListResponse":
					return new ListResponse<ResponseProfile>(jToken);
				case "KalturaScheduleEventListResponse":
					return new ListResponse<ScheduleEvent>(jToken);
				case "KalturaScheduleEventResourceListResponse":
					return new ListResponse<ScheduleEventResource>(jToken);
				case "KalturaScheduleResourceListResponse":
					return new ListResponse<ScheduleResource>(jToken);
				case "KalturaScheduledTaskProfileListResponse":
					return new ListResponse<ScheduledTaskProfile>(jToken);
				case "KalturaSchedulerListResponse":
					return new ListResponse<Scheduler>(jToken);
				case "KalturaSchedulerWorkerListResponse":
					return new ListResponse<SchedulerWorker>(jToken);
				case "KalturaServerNodeListResponse":
					return new ListResponse<ServerNode>(jToken);
				case "KalturaShortLinkListResponse":
					return new ListResponse<ShortLink>(jToken);
				case "KalturaSsoListResponse":
					return new ListResponse<Sso>(jToken);
				case "KalturaStorageProfileListResponse":
					return new ListResponse<StorageProfile>(jToken);
				case "KalturaSystemPartnerUsageListResponse":
					return new ListResponse<SystemPartnerUsageItem>(jToken);
				case "KalturaTagListResponse":
					return new ListResponse<Tag>(jToken);
				case "KalturaThumbAssetListResponse":
					return new ListResponse<ThumbAsset>(jToken);
				case "KalturaThumbParamsListResponse":
					return new ListResponse<ThumbParams>(jToken);
				case "KalturaTrackEntryListResponse":
					return new ListResponse<TrackEntry>(jToken);
				case "KalturaTranscriptAssetListResponse":
					return new ListResponse<TranscriptAsset>(jToken);
				case "KalturaUiConfAdminListResponse":
					return new ListResponse<UiConfAdmin>(jToken);
				case "KalturaUiConfListResponse":
					return new ListResponse<UiConf>(jToken);
				case "KalturaUploadTokenListResponse":
					return new ListResponse<UploadToken>(jToken);
				case "KalturaUserEntryListResponse":
					return new ListResponse<UserEntry>(jToken);
				case "KalturaUserListResponse":
					return new ListResponse<User>(jToken);
				case "KalturaUserLoginDataListResponse":
					return new ListResponse<UserLoginData>(jToken);
				case "KalturaUserRoleListResponse":
					return new ListResponse<UserRole>(jToken);
				case "KalturaVendorCatalogItemListResponse":
					return new ListResponse<VendorCatalogItem>(jToken);
				case "KalturaVirusScanProfileListResponse":
					return new ListResponse<VirusScanProfile>(jToken);
				case "KalturaWidgetListResponse":
					return new ListResponse<Widget>(jToken);
				case "KalturaZoomIntegrationSettingResponse":
					return new ListResponse<ZoomIntegrationSetting>(jToken);
			}
		
			return null;
		}
	}
}

