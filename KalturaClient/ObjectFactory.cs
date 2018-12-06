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
using System.Collections.Generic;
using System.Xml;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Kaltura.Types;

namespace Kaltura
{
	public static class ObjectFactory
	{
		private static Regex prefixRegex = new Regex("^Kaltura");
		
		public static T Create<T>(XmlElement xmlElement) where T : ObjectBase
		{
			if (xmlElement["objectType"] == null)
			{
				return null;
			}
				
			var className = xmlElement["objectType"].InnerText;
			className = prefixRegex.Replace(className, "");
			
			var type = Type.GetType("Kaltura.Types." + className);
			if (type == null)
			{
				type = typeof(T);
			}
			
			if (type == null)
				throw new SerializationException("Invalid object type");
			
			return (T)System.Activator.CreateInstance(type, xmlElement);
		}
		public static T Create<T>(IDictionary<string,object> data) where T : ObjectBase
		{
			if (data == null || data["objectType"] == null)
			{
				return null;
			}
				
			var className = (string)data["objectType"];
			className = prefixRegex.Replace(className, "");
			
			var type = Type.GetType("Kaltura.Types." + className);
			if (type == null)
			{
				type = typeof(T);
			}
			
			if (type == null)
				throw new SerializationException("Invalid object type");
			
			return (T)System.Activator.CreateInstance(type, data);
		}
		
		public static IListResponse Create(XmlElement xmlElement)
		{
			if (xmlElement["objectType"] == null)
			{
				return null;
			}
			
			string className = xmlElement["objectType"].InnerText;
			switch (className)
			{
				case "KalturaFileSyncListResponse":
					return new ListResponse<FileSync>(xmlElement);
				case "KalturaBatchJobListResponse":
					return new ListResponse<BatchJob>(xmlElement);
				case "KalturaMediaInfoListResponse":
					return new ListResponse<MediaInfo>(xmlElement);
				case "KalturaFlavorParamsOutputListResponse":
					return new ListResponse<FlavorParamsOutput>(xmlElement);
				case "KalturaThumbParamsOutputListResponse":
					return new ListResponse<ThumbParamsOutput>(xmlElement);
				case "KalturaAccessControlListResponse":
					return new ListResponse<AccessControl>(xmlElement);
				case "KalturaAccessControlProfileListResponse":
					return new ListResponse<AccessControlProfile>(xmlElement);
				case "KalturaAnnotationListResponse":
					return new ListResponse<Annotation>(xmlElement);
				case "KalturaAppTokenListResponse":
					return new ListResponse<AppToken>(xmlElement);
				case "KalturaAttachmentAssetListResponse":
					return new ListResponse<AttachmentAsset>(xmlElement);
				case "KalturaAuditTrailListResponse":
					return new ListResponse<AuditTrail>(xmlElement);
				case "KalturaBaseEntryListResponse":
					return new ListResponse<BaseEntry>(xmlElement);
				case "KalturaBaseSyndicationFeedListResponse":
					return new ListResponse<BaseSyndicationFeed>(xmlElement);
				case "KalturaBulkUploadListResponse":
					return new ListResponse<BulkUpload>(xmlElement);
				case "KalturaBusinessProcessServerListResponse":
					return new ListResponse<BusinessProcessServer>(xmlElement);
				case "KalturaCaptionAssetItemListResponse":
					return new ListResponse<CaptionAssetItem>(xmlElement);
				case "KalturaCaptionAssetListResponse":
					return new ListResponse<CaptionAsset>(xmlElement);
				case "KalturaCaptionParamsListResponse":
					return new ListResponse<CaptionParams>(xmlElement);
				case "KalturaCategoryEntryListResponse":
					return new ListResponse<CategoryEntry>(xmlElement);
				case "KalturaCategoryListResponse":
					return new ListResponse<Category>(xmlElement);
				case "KalturaCategoryUserListResponse":
					return new ListResponse<CategoryUser>(xmlElement);
				case "KalturaControlPanelCommandListResponse":
					return new ListResponse<ControlPanelCommand>(xmlElement);
				case "KalturaConversionProfileAssetParamsListResponse":
					return new ListResponse<ConversionProfileAssetParams>(xmlElement);
				case "KalturaConversionProfileListResponse":
					return new ListResponse<ConversionProfile>(xmlElement);
				case "KalturaCuePointListResponse":
					return new ListResponse<CuePoint>(xmlElement);
				case "KalturaDataListResponse":
					return new ListResponse<DataEntry>(xmlElement);
				case "KalturaDeliveryProfileListResponse":
					return new ListResponse<DeliveryProfile>(xmlElement);
				case "KalturaDistributionProfileListResponse":
					return new ListResponse<DistributionProfile>(xmlElement);
				case "KalturaDistributionProviderListResponse":
					return new ListResponse<DistributionProvider>(xmlElement);
				case "KalturaDocumentListResponse":
					return new ListResponse<DocumentEntry>(xmlElement);
				case "KalturaDrmPolicyListResponse":
					return new ListResponse<DrmPolicy>(xmlElement);
				case "KalturaDrmProfileListResponse":
					return new ListResponse<DrmProfile>(xmlElement);
				case "KalturaDropFolderFileListResponse":
					return new ListResponse<DropFolderFile>(xmlElement);
				case "KalturaDropFolderListResponse":
					return new ListResponse<DropFolder>(xmlElement);
				case "KalturaEntryDistributionListResponse":
					return new ListResponse<EntryDistribution>(xmlElement);
				case "KalturaEntryServerNodeListResponse":
					return new ListResponse<EntryServerNode>(xmlElement);
				case "KalturaEventNotificationTemplateListResponse":
					return new ListResponse<EventNotificationTemplate>(xmlElement);
				case "KalturaExternalMediaEntryListResponse":
					return new ListResponse<ExternalMediaEntry>(xmlElement);
				case "KalturaFeatureStatusListResponse":
					return new ListResponse<FeatureStatus>(xmlElement);
				case "KalturaFileAssetListResponse":
					return new ListResponse<FileAsset>(xmlElement);
				case "KalturaFlavorAssetListResponse":
					return new ListResponse<FlavorAsset>(xmlElement);
				case "KalturaFlavorParamsListResponse":
					return new ListResponse<FlavorParams>(xmlElement);
				case "KalturaGenericDistributionProviderActionListResponse":
					return new ListResponse<GenericDistributionProviderAction>(xmlElement);
				case "KalturaGenericDistributionProviderListResponse":
					return new ListResponse<GenericDistributionProvider>(xmlElement);
				case "KalturaGroupUserListResponse":
					return new ListResponse<GroupUser>(xmlElement);
				case "KalturaLikeListResponse":
					return new ListResponse<Like>(xmlElement);
				case "KalturaLiveChannelListResponse":
					return new ListResponse<LiveChannel>(xmlElement);
				case "KalturaLiveChannelSegmentListResponse":
					return new ListResponse<LiveChannelSegment>(xmlElement);
				case "KalturaLiveStreamListResponse":
					return new ListResponse<LiveStreamEntry>(xmlElement);
				case "KalturaMediaListResponse":
					return new ListResponse<MediaEntry>(xmlElement);
				case "KalturaMetadataListResponse":
					return new ListResponse<Metadata>(xmlElement);
				case "KalturaMetadataProfileFieldListResponse":
					return new ListResponse<MetadataProfileField>(xmlElement);
				case "KalturaMetadataProfileListResponse":
					return new ListResponse<MetadataProfile>(xmlElement);
				case "KalturaMixListResponse":
					return new ListResponse<MixEntry>(xmlElement);
				case "KalturaModerationFlagListResponse":
					return new ListResponse<ModerationFlag>(xmlElement);
				case "KalturaObjectListResponse":
					return new ListResponse<ObjectBase>(xmlElement);
				case "KalturaPartnerListResponse":
					return new ListResponse<Partner>(xmlElement);
				case "KalturaPartnerUsageListResponse":
					return new ListResponse<VarPartnerUsageItem>(xmlElement);
				case "KalturaPermissionItemListResponse":
					return new ListResponse<PermissionItem>(xmlElement);
				case "KalturaPermissionListResponse":
					return new ListResponse<Permission>(xmlElement);
				case "KalturaPlaylistListResponse":
					return new ListResponse<Playlist>(xmlElement);
				case "KalturaQuizListResponse":
					return new ListResponse<Quiz>(xmlElement);
				case "KalturaRemotePathListResponse":
					return new ListResponse<RemotePath>(xmlElement);
				case "KalturaReportListResponse":
					return new ListResponse<Report>(xmlElement);
				case "KalturaResponseProfileListResponse":
					return new ListResponse<ResponseProfile>(xmlElement);
				case "KalturaScheduleEventListResponse":
					return new ListResponse<ScheduleEvent>(xmlElement);
				case "KalturaScheduleEventResourceListResponse":
					return new ListResponse<ScheduleEventResource>(xmlElement);
				case "KalturaScheduleResourceListResponse":
					return new ListResponse<ScheduleResource>(xmlElement);
				case "KalturaScheduledTaskProfileListResponse":
					return new ListResponse<ScheduledTaskProfile>(xmlElement);
				case "KalturaSchedulerListResponse":
					return new ListResponse<Scheduler>(xmlElement);
				case "KalturaSchedulerWorkerListResponse":
					return new ListResponse<SchedulerWorker>(xmlElement);
				case "KalturaServerNodeListResponse":
					return new ListResponse<ServerNode>(xmlElement);
				case "KalturaShortLinkListResponse":
					return new ListResponse<ShortLink>(xmlElement);
				case "KalturaStorageProfileListResponse":
					return new ListResponse<StorageProfile>(xmlElement);
				case "KalturaSystemPartnerUsageListResponse":
					return new ListResponse<SystemPartnerUsageItem>(xmlElement);
				case "KalturaTagListResponse":
					return new ListResponse<Tag>(xmlElement);
				case "KalturaThumbAssetListResponse":
					return new ListResponse<ThumbAsset>(xmlElement);
				case "KalturaThumbParamsListResponse":
					return new ListResponse<ThumbParams>(xmlElement);
				case "KalturaTrackEntryListResponse":
					return new ListResponse<TrackEntry>(xmlElement);
				case "KalturaTranscriptAssetListResponse":
					return new ListResponse<TranscriptAsset>(xmlElement);
				case "KalturaUiConfAdminListResponse":
					return new ListResponse<UiConfAdmin>(xmlElement);
				case "KalturaUiConfListResponse":
					return new ListResponse<UiConf>(xmlElement);
				case "KalturaUploadTokenListResponse":
					return new ListResponse<UploadToken>(xmlElement);
				case "KalturaUserEntryListResponse":
					return new ListResponse<UserEntry>(xmlElement);
				case "KalturaUserListResponse":
					return new ListResponse<User>(xmlElement);
				case "KalturaUserLoginDataListResponse":
					return new ListResponse<UserLoginData>(xmlElement);
				case "KalturaUserRoleListResponse":
					return new ListResponse<UserRole>(xmlElement);
				case "KalturaVirusScanProfileListResponse":
					return new ListResponse<VirusScanProfile>(xmlElement);
				case "KalturaWidgetListResponse":
					return new ListResponse<Widget>(xmlElement);
			}
		
			return null;
		}
		public static IListResponse Create(IDictionary<string,object> data)
		{
			if (data == null || data["objectType"] == null)
			{
				return null;
			}
			
			string className = (string)data["objectType"];
			switch (className)
			{
				case "KalturaFileSyncListResponse":
					return new ListResponse<FileSync>(data);
				case "KalturaBatchJobListResponse":
					return new ListResponse<BatchJob>(data);
				case "KalturaMediaInfoListResponse":
					return new ListResponse<MediaInfo>(data);
				case "KalturaFlavorParamsOutputListResponse":
					return new ListResponse<FlavorParamsOutput>(data);
				case "KalturaThumbParamsOutputListResponse":
					return new ListResponse<ThumbParamsOutput>(data);
				case "KalturaAccessControlListResponse":
					return new ListResponse<AccessControl>(data);
				case "KalturaAccessControlProfileListResponse":
					return new ListResponse<AccessControlProfile>(data);
				case "KalturaAnnotationListResponse":
					return new ListResponse<Annotation>(data);
				case "KalturaAppTokenListResponse":
					return new ListResponse<AppToken>(data);
				case "KalturaAttachmentAssetListResponse":
					return new ListResponse<AttachmentAsset>(data);
				case "KalturaAuditTrailListResponse":
					return new ListResponse<AuditTrail>(data);
				case "KalturaBaseEntryListResponse":
					return new ListResponse<BaseEntry>(data);
				case "KalturaBaseSyndicationFeedListResponse":
					return new ListResponse<BaseSyndicationFeed>(data);
				case "KalturaBulkUploadListResponse":
					return new ListResponse<BulkUpload>(data);
				case "KalturaBusinessProcessServerListResponse":
					return new ListResponse<BusinessProcessServer>(data);
				case "KalturaCaptionAssetItemListResponse":
					return new ListResponse<CaptionAssetItem>(data);
				case "KalturaCaptionAssetListResponse":
					return new ListResponse<CaptionAsset>(data);
				case "KalturaCaptionParamsListResponse":
					return new ListResponse<CaptionParams>(data);
				case "KalturaCategoryEntryListResponse":
					return new ListResponse<CategoryEntry>(data);
				case "KalturaCategoryListResponse":
					return new ListResponse<Category>(data);
				case "KalturaCategoryUserListResponse":
					return new ListResponse<CategoryUser>(data);
				case "KalturaControlPanelCommandListResponse":
					return new ListResponse<ControlPanelCommand>(data);
				case "KalturaConversionProfileAssetParamsListResponse":
					return new ListResponse<ConversionProfileAssetParams>(data);
				case "KalturaConversionProfileListResponse":
					return new ListResponse<ConversionProfile>(data);
				case "KalturaCuePointListResponse":
					return new ListResponse<CuePoint>(data);
				case "KalturaDataListResponse":
					return new ListResponse<DataEntry>(data);
				case "KalturaDeliveryProfileListResponse":
					return new ListResponse<DeliveryProfile>(data);
				case "KalturaDistributionProfileListResponse":
					return new ListResponse<DistributionProfile>(data);
				case "KalturaDistributionProviderListResponse":
					return new ListResponse<DistributionProvider>(data);
				case "KalturaDocumentListResponse":
					return new ListResponse<DocumentEntry>(data);
				case "KalturaDrmPolicyListResponse":
					return new ListResponse<DrmPolicy>(data);
				case "KalturaDrmProfileListResponse":
					return new ListResponse<DrmProfile>(data);
				case "KalturaDropFolderFileListResponse":
					return new ListResponse<DropFolderFile>(data);
				case "KalturaDropFolderListResponse":
					return new ListResponse<DropFolder>(data);
				case "KalturaEntryDistributionListResponse":
					return new ListResponse<EntryDistribution>(data);
				case "KalturaEntryServerNodeListResponse":
					return new ListResponse<EntryServerNode>(data);
				case "KalturaEventNotificationTemplateListResponse":
					return new ListResponse<EventNotificationTemplate>(data);
				case "KalturaExternalMediaEntryListResponse":
					return new ListResponse<ExternalMediaEntry>(data);
				case "KalturaFeatureStatusListResponse":
					return new ListResponse<FeatureStatus>(data);
				case "KalturaFileAssetListResponse":
					return new ListResponse<FileAsset>(data);
				case "KalturaFlavorAssetListResponse":
					return new ListResponse<FlavorAsset>(data);
				case "KalturaFlavorParamsListResponse":
					return new ListResponse<FlavorParams>(data);
				case "KalturaGenericDistributionProviderActionListResponse":
					return new ListResponse<GenericDistributionProviderAction>(data);
				case "KalturaGenericDistributionProviderListResponse":
					return new ListResponse<GenericDistributionProvider>(data);
				case "KalturaGroupUserListResponse":
					return new ListResponse<GroupUser>(data);
				case "KalturaLikeListResponse":
					return new ListResponse<Like>(data);
				case "KalturaLiveChannelListResponse":
					return new ListResponse<LiveChannel>(data);
				case "KalturaLiveChannelSegmentListResponse":
					return new ListResponse<LiveChannelSegment>(data);
				case "KalturaLiveStreamListResponse":
					return new ListResponse<LiveStreamEntry>(data);
				case "KalturaMediaListResponse":
					return new ListResponse<MediaEntry>(data);
				case "KalturaMetadataListResponse":
					return new ListResponse<Metadata>(data);
				case "KalturaMetadataProfileFieldListResponse":
					return new ListResponse<MetadataProfileField>(data);
				case "KalturaMetadataProfileListResponse":
					return new ListResponse<MetadataProfile>(data);
				case "KalturaMixListResponse":
					return new ListResponse<MixEntry>(data);
				case "KalturaModerationFlagListResponse":
					return new ListResponse<ModerationFlag>(data);
				case "KalturaObjectListResponse":
					return new ListResponse<ObjectBase>(data);
				case "KalturaPartnerListResponse":
					return new ListResponse<Partner>(data);
				case "KalturaPartnerUsageListResponse":
					return new ListResponse<VarPartnerUsageItem>(data);
				case "KalturaPermissionItemListResponse":
					return new ListResponse<PermissionItem>(data);
				case "KalturaPermissionListResponse":
					return new ListResponse<Permission>(data);
				case "KalturaPlaylistListResponse":
					return new ListResponse<Playlist>(data);
				case "KalturaQuizListResponse":
					return new ListResponse<Quiz>(data);
				case "KalturaRemotePathListResponse":
					return new ListResponse<RemotePath>(data);
				case "KalturaReportListResponse":
					return new ListResponse<Report>(data);
				case "KalturaResponseProfileListResponse":
					return new ListResponse<ResponseProfile>(data);
				case "KalturaScheduleEventListResponse":
					return new ListResponse<ScheduleEvent>(data);
				case "KalturaScheduleEventResourceListResponse":
					return new ListResponse<ScheduleEventResource>(data);
				case "KalturaScheduleResourceListResponse":
					return new ListResponse<ScheduleResource>(data);
				case "KalturaScheduledTaskProfileListResponse":
					return new ListResponse<ScheduledTaskProfile>(data);
				case "KalturaSchedulerListResponse":
					return new ListResponse<Scheduler>(data);
				case "KalturaSchedulerWorkerListResponse":
					return new ListResponse<SchedulerWorker>(data);
				case "KalturaServerNodeListResponse":
					return new ListResponse<ServerNode>(data);
				case "KalturaShortLinkListResponse":
					return new ListResponse<ShortLink>(data);
				case "KalturaStorageProfileListResponse":
					return new ListResponse<StorageProfile>(data);
				case "KalturaSystemPartnerUsageListResponse":
					return new ListResponse<SystemPartnerUsageItem>(data);
				case "KalturaTagListResponse":
					return new ListResponse<Tag>(data);
				case "KalturaThumbAssetListResponse":
					return new ListResponse<ThumbAsset>(data);
				case "KalturaThumbParamsListResponse":
					return new ListResponse<ThumbParams>(data);
				case "KalturaTrackEntryListResponse":
					return new ListResponse<TrackEntry>(data);
				case "KalturaTranscriptAssetListResponse":
					return new ListResponse<TranscriptAsset>(data);
				case "KalturaUiConfAdminListResponse":
					return new ListResponse<UiConfAdmin>(data);
				case "KalturaUiConfListResponse":
					return new ListResponse<UiConf>(data);
				case "KalturaUploadTokenListResponse":
					return new ListResponse<UploadToken>(data);
				case "KalturaUserEntryListResponse":
					return new ListResponse<UserEntry>(data);
				case "KalturaUserListResponse":
					return new ListResponse<User>(data);
				case "KalturaUserLoginDataListResponse":
					return new ListResponse<UserLoginData>(data);
				case "KalturaUserRoleListResponse":
					return new ListResponse<UserRole>(data);
				case "KalturaVirusScanProfileListResponse":
					return new ListResponse<VirusScanProfile>(data);
				case "KalturaWidgetListResponse":
					return new ListResponse<Widget>(data);
			}
		
			return null;
		}
	}
}

