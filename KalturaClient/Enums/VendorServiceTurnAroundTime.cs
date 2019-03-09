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
// Copyright (C) 2006-2019  Kaltura Inc.
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
namespace Kaltura.Enums
{
	public enum VendorServiceTurnAroundTime
	{
		BEST_EFFORT = -1,
		IMMEDIATE = 0,
		THIRTY_MINUTES = 1800,
		TWO_HOURS = 7200,
		THREE_HOURS = 10800,
		SIX_HOURS = 21600,
		EIGHT_HOURS = 28800,
		TWELVE_HOURS = 43200,
		TWENTY_FOUR_HOURS = 86400,
		FORTY_EIGHT_HOURS = 172800,
		TEN_DAYS = 864000,
	}
}