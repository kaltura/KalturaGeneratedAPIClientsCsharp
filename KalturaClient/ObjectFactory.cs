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
				case "KalturaRegionListResponse":
					return new ListResponse<Region>(xmlElement);
				case "KalturaUserAssetRuleListResponse":
					return new ListResponse<UserAssetRule>(xmlElement);
				case "KalturaCDNAdapterProfileListResponse":
					return new ListResponse<CDNAdapterProfile>(xmlElement);
				case "KalturaBookmarkListResponse":
					return new ListResponse<Bookmark>(xmlElement);
				case "KalturaAssetListResponse":
					return new ListResponse<Asset>(xmlElement);
				case "KalturaAssetCommentListResponse":
					return new ListResponse<AssetComment>(xmlElement);
				case "KalturaSeriesRecordingListResponse":
					return new ListResponse<SeriesRecording>(xmlElement);
				case "KalturaHouseholdPremiumServiceListResponse":
					return new ListResponse<HouseholdPremiumService>(xmlElement);
				case "KalturaCDVRAdapterProfileListResponse":
					return new ListResponse<CDVRAdapterProfile>(xmlElement);
				case "KalturaExportTaskListResponse":
					return new ListResponse<ExportTask>(xmlElement);
				case "KalturaExternalChannelProfileListResponse":
					return new ListResponse<ExternalChannelProfile>(xmlElement);
				case "KalturaRecommendationProfileListResponse":
					return new ListResponse<RecommendationProfile>(xmlElement);
				case "KalturaRegistrySettingsListResponse":
					return new ListResponse<RegistrySettings>(xmlElement);
				case "KalturaHouseholdPaymentMethodListResponse":
					return new ListResponse<HouseholdPaymentMethod>(xmlElement);
				case "KalturaPaymentMethodProfileListResponse":
					return new ListResponse<PaymentMethodProfile>(xmlElement);
				case "KalturaHouseholdPaymentGatewayListResponse":
					return new ListResponse<HouseholdPaymentGateway>(xmlElement);
				case "KalturaPaymentGatewayProfileListResponse":
					return new ListResponse<PaymentGatewayProfile>(xmlElement);
				case "KalturaParentalRuleListResponse":
					return new ListResponse<ParentalRule>(xmlElement);
				case "KalturaRecordingListResponse":
					return new ListResponse<Recording>(xmlElement);
				case "KalturaBillingTransactionListResponse":
					return new ListResponse<BillingTransaction>(xmlElement);
				case "KalturaUserRoleListResponse":
					return new ListResponse<UserRole>(xmlElement);
				case "KalturaInboxMessageListResponse":
					return new ListResponse<InboxMessage>(xmlElement);
				case "KalturaFollowTvSeriesListResponse":
					return new ListResponse<FollowTvSeries>(xmlElement);
				case "KalturaAnnouncementListResponse":
					return new ListResponse<Announcement>(xmlElement);
				case "KalturaPersonalFeedListResponse":
					return new ListResponse<PersonalFeed>(xmlElement);
				case "KalturaTopicListResponse":
					return new ListResponse<Topic>(xmlElement);
				case "KalturaProductPriceListResponse":
					return new ListResponse<ProductPrice>(xmlElement);
				case "KalturaItemPriceListResponse":
					return new ListResponse<ItemPrice>(xmlElement);
				case "KalturaSubscriptionListResponse":
					return new ListResponse<Subscription>(xmlElement);
				case "KalturaProductsPriceListResponse":
					return new ListResponse<ProductPrice>(xmlElement);
				case "KalturaEntitlementListResponse":
					return new ListResponse<Entitlement>(xmlElement);
				case "KalturaHomeNetworkListResponse":
					return new ListResponse<HomeNetwork>(xmlElement);
				case "KalturaFavoriteListResponse":
					return new ListResponse<Favorite>(xmlElement);
				case "KalturaOTTUserListResponse":
					return new ListResponse<OTTUser>(xmlElement);
				case "KalturaAssetStatisticsListResponse":
					return new ListResponse<AssetStatistics>(xmlElement);
				case "KalturaSlimAssetInfoWrapper":
					return new ListResponse<BaseAssetInfo>(xmlElement);
				case "KalturaAssetHistoryListResponse":
					return new ListResponse<AssetHistory>(xmlElement);
			}
		
			return null;
		}
	}
}

