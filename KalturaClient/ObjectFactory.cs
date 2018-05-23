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
				
			string className = xmlElement["objectType"].InnerText;
			className = prefixRegex.Replace(className, "");
			
			Type type = Type.GetType("Kaltura.Types." + className);
			if (type == null)
			{
				type = typeof(T);
			}
			
			if (type == null)
				throw new SerializationException("Invalid object type");
			
			return (T)System.Activator.CreateInstance(type, xmlElement);
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
				case "KalturaEntryVendorTaskListResponse":
					return new ListResponse<EntryVendorTask>(xmlElement);
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
				case "KalturaReachProfileListResponse":
					return new ListResponse<ReachProfile>(xmlElement);
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
	}
}

