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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class CategoryBaseFilter : RelatedFilter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string ID_NOT_IN = "idNotIn";
		public const string PARENT_ID_EQUAL = "parentIdEqual";
		public const string PARENT_ID_IN = "parentIdIn";
		public const string DEPTH_EQUAL = "depthEqual";
		public const string FULL_NAME_EQUAL = "fullNameEqual";
		public const string FULL_NAME_STARTS_WITH = "fullNameStartsWith";
		public const string FULL_NAME_IN = "fullNameIn";
		public const string FULL_IDS_EQUAL = "fullIdsEqual";
		public const string FULL_IDS_STARTS_WITH = "fullIdsStartsWith";
		public const string FULL_IDS_MATCH_OR = "fullIdsMatchOr";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string TAGS_LIKE = "tagsLike";
		public const string TAGS_MULTI_LIKE_OR = "tagsMultiLikeOr";
		public const string TAGS_MULTI_LIKE_AND = "tagsMultiLikeAnd";
		public const string APPEAR_IN_LIST_EQUAL = "appearInListEqual";
		public const string PRIVACY_EQUAL = "privacyEqual";
		public const string PRIVACY_IN = "privacyIn";
		public const string INHERITANCE_TYPE_EQUAL = "inheritanceTypeEqual";
		public const string INHERITANCE_TYPE_IN = "inheritanceTypeIn";
		public const string REFERENCE_ID_EQUAL = "referenceIdEqual";
		public const string REFERENCE_ID_EMPTY = "referenceIdEmpty";
		public const string CONTRIBUTION_POLICY_EQUAL = "contributionPolicyEqual";
		public const string MEMBERS_COUNT_GREATER_THAN_OR_EQUAL = "membersCountGreaterThanOrEqual";
		public const string MEMBERS_COUNT_LESS_THAN_OR_EQUAL = "membersCountLessThanOrEqual";
		public const string PENDING_MEMBERS_COUNT_GREATER_THAN_OR_EQUAL = "pendingMembersCountGreaterThanOrEqual";
		public const string PENDING_MEMBERS_COUNT_LESS_THAN_OR_EQUAL = "pendingMembersCountLessThanOrEqual";
		public const string PRIVACY_CONTEXT_EQUAL = "privacyContextEqual";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string INHERITED_PARENT_ID_EQUAL = "inheritedParentIdEqual";
		public const string INHERITED_PARENT_ID_IN = "inheritedParentIdIn";
		public const string PARTNER_SORT_VALUE_GREATER_THAN_OR_EQUAL = "partnerSortValueGreaterThanOrEqual";
		public const string PARTNER_SORT_VALUE_LESS_THAN_OR_EQUAL = "partnerSortValueLessThanOrEqual";
		public const string AGGREGATION_CATEGORIES_MULTI_LIKE_OR = "aggregationCategoriesMultiLikeOr";
		public const string AGGREGATION_CATEGORIES_MULTI_LIKE_AND = "aggregationCategoriesMultiLikeAnd";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private string _IdNotIn = null;
		private int _ParentIdEqual = Int32.MinValue;
		private string _ParentIdIn = null;
		private int _DepthEqual = Int32.MinValue;
		private string _FullNameEqual = null;
		private string _FullNameStartsWith = null;
		private string _FullNameIn = null;
		private string _FullIdsEqual = null;
		private string _FullIdsStartsWith = null;
		private string _FullIdsMatchOr = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private string _TagsLike = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private AppearInListType _AppearInListEqual = (AppearInListType)Int32.MinValue;
		private PrivacyType _PrivacyEqual = (PrivacyType)Int32.MinValue;
		private string _PrivacyIn = null;
		private InheritanceType _InheritanceTypeEqual = (InheritanceType)Int32.MinValue;
		private string _InheritanceTypeIn = null;
		private string _ReferenceIdEqual = null;
		private NullableBoolean _ReferenceIdEmpty = (NullableBoolean)Int32.MinValue;
		private ContributionPolicyType _ContributionPolicyEqual = (ContributionPolicyType)Int32.MinValue;
		private int _MembersCountGreaterThanOrEqual = Int32.MinValue;
		private int _MembersCountLessThanOrEqual = Int32.MinValue;
		private int _PendingMembersCountGreaterThanOrEqual = Int32.MinValue;
		private int _PendingMembersCountLessThanOrEqual = Int32.MinValue;
		private string _PrivacyContextEqual = null;
		private CategoryStatus _StatusEqual = (CategoryStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _InheritedParentIdEqual = Int32.MinValue;
		private string _InheritedParentIdIn = null;
		private int _PartnerSortValueGreaterThanOrEqual = Int32.MinValue;
		private int _PartnerSortValueLessThanOrEqual = Int32.MinValue;
		private string _AggregationCategoriesMultiLikeOr = null;
		private string _AggregationCategoriesMultiLikeAnd = null;
		#endregion

		#region Properties
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		public string IdNotIn
		{
			get { return _IdNotIn; }
			set 
			{ 
				_IdNotIn = value;
				OnPropertyChanged("IdNotIn");
			}
		}
		public int ParentIdEqual
		{
			get { return _ParentIdEqual; }
			set 
			{ 
				_ParentIdEqual = value;
				OnPropertyChanged("ParentIdEqual");
			}
		}
		public string ParentIdIn
		{
			get { return _ParentIdIn; }
			set 
			{ 
				_ParentIdIn = value;
				OnPropertyChanged("ParentIdIn");
			}
		}
		public int DepthEqual
		{
			get { return _DepthEqual; }
			set 
			{ 
				_DepthEqual = value;
				OnPropertyChanged("DepthEqual");
			}
		}
		public string FullNameEqual
		{
			get { return _FullNameEqual; }
			set 
			{ 
				_FullNameEqual = value;
				OnPropertyChanged("FullNameEqual");
			}
		}
		public string FullNameStartsWith
		{
			get { return _FullNameStartsWith; }
			set 
			{ 
				_FullNameStartsWith = value;
				OnPropertyChanged("FullNameStartsWith");
			}
		}
		public string FullNameIn
		{
			get { return _FullNameIn; }
			set 
			{ 
				_FullNameIn = value;
				OnPropertyChanged("FullNameIn");
			}
		}
		public string FullIdsEqual
		{
			get { return _FullIdsEqual; }
			set 
			{ 
				_FullIdsEqual = value;
				OnPropertyChanged("FullIdsEqual");
			}
		}
		public string FullIdsStartsWith
		{
			get { return _FullIdsStartsWith; }
			set 
			{ 
				_FullIdsStartsWith = value;
				OnPropertyChanged("FullIdsStartsWith");
			}
		}
		public string FullIdsMatchOr
		{
			get { return _FullIdsMatchOr; }
			set 
			{ 
				_FullIdsMatchOr = value;
				OnPropertyChanged("FullIdsMatchOr");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public string TagsLike
		{
			get { return _TagsLike; }
			set 
			{ 
				_TagsLike = value;
				OnPropertyChanged("TagsLike");
			}
		}
		public string TagsMultiLikeOr
		{
			get { return _TagsMultiLikeOr; }
			set 
			{ 
				_TagsMultiLikeOr = value;
				OnPropertyChanged("TagsMultiLikeOr");
			}
		}
		public string TagsMultiLikeAnd
		{
			get { return _TagsMultiLikeAnd; }
			set 
			{ 
				_TagsMultiLikeAnd = value;
				OnPropertyChanged("TagsMultiLikeAnd");
			}
		}
		public AppearInListType AppearInListEqual
		{
			get { return _AppearInListEqual; }
			set 
			{ 
				_AppearInListEqual = value;
				OnPropertyChanged("AppearInListEqual");
			}
		}
		public PrivacyType PrivacyEqual
		{
			get { return _PrivacyEqual; }
			set 
			{ 
				_PrivacyEqual = value;
				OnPropertyChanged("PrivacyEqual");
			}
		}
		public string PrivacyIn
		{
			get { return _PrivacyIn; }
			set 
			{ 
				_PrivacyIn = value;
				OnPropertyChanged("PrivacyIn");
			}
		}
		public InheritanceType InheritanceTypeEqual
		{
			get { return _InheritanceTypeEqual; }
			set 
			{ 
				_InheritanceTypeEqual = value;
				OnPropertyChanged("InheritanceTypeEqual");
			}
		}
		public string InheritanceTypeIn
		{
			get { return _InheritanceTypeIn; }
			set 
			{ 
				_InheritanceTypeIn = value;
				OnPropertyChanged("InheritanceTypeIn");
			}
		}
		public string ReferenceIdEqual
		{
			get { return _ReferenceIdEqual; }
			set 
			{ 
				_ReferenceIdEqual = value;
				OnPropertyChanged("ReferenceIdEqual");
			}
		}
		public NullableBoolean ReferenceIdEmpty
		{
			get { return _ReferenceIdEmpty; }
			set 
			{ 
				_ReferenceIdEmpty = value;
				OnPropertyChanged("ReferenceIdEmpty");
			}
		}
		public ContributionPolicyType ContributionPolicyEqual
		{
			get { return _ContributionPolicyEqual; }
			set 
			{ 
				_ContributionPolicyEqual = value;
				OnPropertyChanged("ContributionPolicyEqual");
			}
		}
		public int MembersCountGreaterThanOrEqual
		{
			get { return _MembersCountGreaterThanOrEqual; }
			set 
			{ 
				_MembersCountGreaterThanOrEqual = value;
				OnPropertyChanged("MembersCountGreaterThanOrEqual");
			}
		}
		public int MembersCountLessThanOrEqual
		{
			get { return _MembersCountLessThanOrEqual; }
			set 
			{ 
				_MembersCountLessThanOrEqual = value;
				OnPropertyChanged("MembersCountLessThanOrEqual");
			}
		}
		public int PendingMembersCountGreaterThanOrEqual
		{
			get { return _PendingMembersCountGreaterThanOrEqual; }
			set 
			{ 
				_PendingMembersCountGreaterThanOrEqual = value;
				OnPropertyChanged("PendingMembersCountGreaterThanOrEqual");
			}
		}
		public int PendingMembersCountLessThanOrEqual
		{
			get { return _PendingMembersCountLessThanOrEqual; }
			set 
			{ 
				_PendingMembersCountLessThanOrEqual = value;
				OnPropertyChanged("PendingMembersCountLessThanOrEqual");
			}
		}
		public string PrivacyContextEqual
		{
			get { return _PrivacyContextEqual; }
			set 
			{ 
				_PrivacyContextEqual = value;
				OnPropertyChanged("PrivacyContextEqual");
			}
		}
		public CategoryStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public int InheritedParentIdEqual
		{
			get { return _InheritedParentIdEqual; }
			set 
			{ 
				_InheritedParentIdEqual = value;
				OnPropertyChanged("InheritedParentIdEqual");
			}
		}
		public string InheritedParentIdIn
		{
			get { return _InheritedParentIdIn; }
			set 
			{ 
				_InheritedParentIdIn = value;
				OnPropertyChanged("InheritedParentIdIn");
			}
		}
		public int PartnerSortValueGreaterThanOrEqual
		{
			get { return _PartnerSortValueGreaterThanOrEqual; }
			set 
			{ 
				_PartnerSortValueGreaterThanOrEqual = value;
				OnPropertyChanged("PartnerSortValueGreaterThanOrEqual");
			}
		}
		public int PartnerSortValueLessThanOrEqual
		{
			get { return _PartnerSortValueLessThanOrEqual; }
			set 
			{ 
				_PartnerSortValueLessThanOrEqual = value;
				OnPropertyChanged("PartnerSortValueLessThanOrEqual");
			}
		}
		public string AggregationCategoriesMultiLikeOr
		{
			get { return _AggregationCategoriesMultiLikeOr; }
			set 
			{ 
				_AggregationCategoriesMultiLikeOr = value;
				OnPropertyChanged("AggregationCategoriesMultiLikeOr");
			}
		}
		public string AggregationCategoriesMultiLikeAnd
		{
			get { return _AggregationCategoriesMultiLikeAnd; }
			set 
			{ 
				_AggregationCategoriesMultiLikeAnd = value;
				OnPropertyChanged("AggregationCategoriesMultiLikeAnd");
			}
		}
		#endregion

		#region CTor
		public CategoryBaseFilter()
		{
		}

		public CategoryBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "idIn":
						this._IdIn = propertyNode.InnerText;
						continue;
					case "idNotIn":
						this._IdNotIn = propertyNode.InnerText;
						continue;
					case "parentIdEqual":
						this._ParentIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "parentIdIn":
						this._ParentIdIn = propertyNode.InnerText;
						continue;
					case "depthEqual":
						this._DepthEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "fullNameEqual":
						this._FullNameEqual = propertyNode.InnerText;
						continue;
					case "fullNameStartsWith":
						this._FullNameStartsWith = propertyNode.InnerText;
						continue;
					case "fullNameIn":
						this._FullNameIn = propertyNode.InnerText;
						continue;
					case "fullIdsEqual":
						this._FullIdsEqual = propertyNode.InnerText;
						continue;
					case "fullIdsStartsWith":
						this._FullIdsStartsWith = propertyNode.InnerText;
						continue;
					case "fullIdsMatchOr":
						this._FullIdsMatchOr = propertyNode.InnerText;
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "tagsLike":
						this._TagsLike = propertyNode.InnerText;
						continue;
					case "tagsMultiLikeOr":
						this._TagsMultiLikeOr = propertyNode.InnerText;
						continue;
					case "tagsMultiLikeAnd":
						this._TagsMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "appearInListEqual":
						this._AppearInListEqual = (AppearInListType)ParseEnum(typeof(AppearInListType), propertyNode.InnerText);
						continue;
					case "privacyEqual":
						this._PrivacyEqual = (PrivacyType)ParseEnum(typeof(PrivacyType), propertyNode.InnerText);
						continue;
					case "privacyIn":
						this._PrivacyIn = propertyNode.InnerText;
						continue;
					case "inheritanceTypeEqual":
						this._InheritanceTypeEqual = (InheritanceType)ParseEnum(typeof(InheritanceType), propertyNode.InnerText);
						continue;
					case "inheritanceTypeIn":
						this._InheritanceTypeIn = propertyNode.InnerText;
						continue;
					case "referenceIdEqual":
						this._ReferenceIdEqual = propertyNode.InnerText;
						continue;
					case "referenceIdEmpty":
						this._ReferenceIdEmpty = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "contributionPolicyEqual":
						this._ContributionPolicyEqual = (ContributionPolicyType)ParseEnum(typeof(ContributionPolicyType), propertyNode.InnerText);
						continue;
					case "membersCountGreaterThanOrEqual":
						this._MembersCountGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "membersCountLessThanOrEqual":
						this._MembersCountLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "pendingMembersCountGreaterThanOrEqual":
						this._PendingMembersCountGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "pendingMembersCountLessThanOrEqual":
						this._PendingMembersCountLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "privacyContextEqual":
						this._PrivacyContextEqual = propertyNode.InnerText;
						continue;
					case "statusEqual":
						this._StatusEqual = (CategoryStatus)ParseEnum(typeof(CategoryStatus), propertyNode.InnerText);
						continue;
					case "statusIn":
						this._StatusIn = propertyNode.InnerText;
						continue;
					case "inheritedParentIdEqual":
						this._InheritedParentIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "inheritedParentIdIn":
						this._InheritedParentIdIn = propertyNode.InnerText;
						continue;
					case "partnerSortValueGreaterThanOrEqual":
						this._PartnerSortValueGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerSortValueLessThanOrEqual":
						this._PartnerSortValueLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "aggregationCategoriesMultiLikeOr":
						this._AggregationCategoriesMultiLikeOr = propertyNode.InnerText;
						continue;
					case "aggregationCategoriesMultiLikeAnd":
						this._AggregationCategoriesMultiLikeAnd = propertyNode.InnerText;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCategoryBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("idNotIn", this._IdNotIn);
			kparams.AddIfNotNull("parentIdEqual", this._ParentIdEqual);
			kparams.AddIfNotNull("parentIdIn", this._ParentIdIn);
			kparams.AddIfNotNull("depthEqual", this._DepthEqual);
			kparams.AddIfNotNull("fullNameEqual", this._FullNameEqual);
			kparams.AddIfNotNull("fullNameStartsWith", this._FullNameStartsWith);
			kparams.AddIfNotNull("fullNameIn", this._FullNameIn);
			kparams.AddIfNotNull("fullIdsEqual", this._FullIdsEqual);
			kparams.AddIfNotNull("fullIdsStartsWith", this._FullIdsStartsWith);
			kparams.AddIfNotNull("fullIdsMatchOr", this._FullIdsMatchOr);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("tagsLike", this._TagsLike);
			kparams.AddIfNotNull("tagsMultiLikeOr", this._TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this._TagsMultiLikeAnd);
			kparams.AddIfNotNull("appearInListEqual", this._AppearInListEqual);
			kparams.AddIfNotNull("privacyEqual", this._PrivacyEqual);
			kparams.AddIfNotNull("privacyIn", this._PrivacyIn);
			kparams.AddIfNotNull("inheritanceTypeEqual", this._InheritanceTypeEqual);
			kparams.AddIfNotNull("inheritanceTypeIn", this._InheritanceTypeIn);
			kparams.AddIfNotNull("referenceIdEqual", this._ReferenceIdEqual);
			kparams.AddIfNotNull("referenceIdEmpty", this._ReferenceIdEmpty);
			kparams.AddIfNotNull("contributionPolicyEqual", this._ContributionPolicyEqual);
			kparams.AddIfNotNull("membersCountGreaterThanOrEqual", this._MembersCountGreaterThanOrEqual);
			kparams.AddIfNotNull("membersCountLessThanOrEqual", this._MembersCountLessThanOrEqual);
			kparams.AddIfNotNull("pendingMembersCountGreaterThanOrEqual", this._PendingMembersCountGreaterThanOrEqual);
			kparams.AddIfNotNull("pendingMembersCountLessThanOrEqual", this._PendingMembersCountLessThanOrEqual);
			kparams.AddIfNotNull("privacyContextEqual", this._PrivacyContextEqual);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("inheritedParentIdEqual", this._InheritedParentIdEqual);
			kparams.AddIfNotNull("inheritedParentIdIn", this._InheritedParentIdIn);
			kparams.AddIfNotNull("partnerSortValueGreaterThanOrEqual", this._PartnerSortValueGreaterThanOrEqual);
			kparams.AddIfNotNull("partnerSortValueLessThanOrEqual", this._PartnerSortValueLessThanOrEqual);
			kparams.AddIfNotNull("aggregationCategoriesMultiLikeOr", this._AggregationCategoriesMultiLikeOr);
			kparams.AddIfNotNull("aggregationCategoriesMultiLikeAnd", this._AggregationCategoriesMultiLikeAnd);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_EQUAL:
					return "IdEqual";
				case ID_IN:
					return "IdIn";
				case ID_NOT_IN:
					return "IdNotIn";
				case PARENT_ID_EQUAL:
					return "ParentIdEqual";
				case PARENT_ID_IN:
					return "ParentIdIn";
				case DEPTH_EQUAL:
					return "DepthEqual";
				case FULL_NAME_EQUAL:
					return "FullNameEqual";
				case FULL_NAME_STARTS_WITH:
					return "FullNameStartsWith";
				case FULL_NAME_IN:
					return "FullNameIn";
				case FULL_IDS_EQUAL:
					return "FullIdsEqual";
				case FULL_IDS_STARTS_WITH:
					return "FullIdsStartsWith";
				case FULL_IDS_MATCH_OR:
					return "FullIdsMatchOr";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case TAGS_LIKE:
					return "TagsLike";
				case TAGS_MULTI_LIKE_OR:
					return "TagsMultiLikeOr";
				case TAGS_MULTI_LIKE_AND:
					return "TagsMultiLikeAnd";
				case APPEAR_IN_LIST_EQUAL:
					return "AppearInListEqual";
				case PRIVACY_EQUAL:
					return "PrivacyEqual";
				case PRIVACY_IN:
					return "PrivacyIn";
				case INHERITANCE_TYPE_EQUAL:
					return "InheritanceTypeEqual";
				case INHERITANCE_TYPE_IN:
					return "InheritanceTypeIn";
				case REFERENCE_ID_EQUAL:
					return "ReferenceIdEqual";
				case REFERENCE_ID_EMPTY:
					return "ReferenceIdEmpty";
				case CONTRIBUTION_POLICY_EQUAL:
					return "ContributionPolicyEqual";
				case MEMBERS_COUNT_GREATER_THAN_OR_EQUAL:
					return "MembersCountGreaterThanOrEqual";
				case MEMBERS_COUNT_LESS_THAN_OR_EQUAL:
					return "MembersCountLessThanOrEqual";
				case PENDING_MEMBERS_COUNT_GREATER_THAN_OR_EQUAL:
					return "PendingMembersCountGreaterThanOrEqual";
				case PENDING_MEMBERS_COUNT_LESS_THAN_OR_EQUAL:
					return "PendingMembersCountLessThanOrEqual";
				case PRIVACY_CONTEXT_EQUAL:
					return "PrivacyContextEqual";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case INHERITED_PARENT_ID_EQUAL:
					return "InheritedParentIdEqual";
				case INHERITED_PARENT_ID_IN:
					return "InheritedParentIdIn";
				case PARTNER_SORT_VALUE_GREATER_THAN_OR_EQUAL:
					return "PartnerSortValueGreaterThanOrEqual";
				case PARTNER_SORT_VALUE_LESS_THAN_OR_EQUAL:
					return "PartnerSortValueLessThanOrEqual";
				case AGGREGATION_CATEGORIES_MULTI_LIKE_OR:
					return "AggregationCategoriesMultiLikeOr";
				case AGGREGATION_CATEGORIES_MULTI_LIKE_AND:
					return "AggregationCategoriesMultiLikeAnd";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

