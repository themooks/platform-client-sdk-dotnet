using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGamificationApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Leaderboard of the requesting user's division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>Leaderboard</returns>
        Leaderboard GetGamificationLeaderboard (String startWorkday, String endWorkday, string metricId = null);

        /// <summary>
        /// Leaderboard of the requesting user's division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>ApiResponse of Leaderboard</returns>
        ApiResponse<Leaderboard> GetGamificationLeaderboardWithHttpInfo (String startWorkday, String endWorkday, string metricId = null);

        /// <summary>
        /// Leaderboard by filter type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>Leaderboard</returns>
        Leaderboard GetGamificationLeaderboardAll (string filterType, string filterId, String startWorkday, String endWorkday, string metricId = null);

        /// <summary>
        /// Leaderboard by filter type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>ApiResponse of Leaderboard</returns>
        ApiResponse<Leaderboard> GetGamificationLeaderboardAllWithHttpInfo (string filterType, string filterId, String startWorkday, String endWorkday, string metricId = null);

        /// <summary>
        /// Best Points by division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <returns>OverallBestPoints</returns>
        OverallBestPoints GetGamificationLeaderboardAllBestpoints (string filterType, string filterId);

        /// <summary>
        /// Best Points by division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <returns>ApiResponse of OverallBestPoints</returns>
        ApiResponse<OverallBestPoints> GetGamificationLeaderboardAllBestpointsWithHttpInfo (string filterType, string filterId);

        /// <summary>
        /// Best Points of the requesting user's current performance profile or division
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OverallBestPoints</returns>
        OverallBestPoints GetGamificationLeaderboardBestpoints ();

        /// <summary>
        /// Best Points of the requesting user's current performance profile or division
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OverallBestPoints</returns>
        ApiResponse<OverallBestPoints> GetGamificationLeaderboardBestpointsWithHttpInfo ();

        /// <summary>
        /// Gamified metric by id
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>Metric</returns>
        Metric GetGamificationMetric (string metricId, String workday = null, string performanceProfileId = null);

        /// <summary>
        /// Gamified metric by id
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>ApiResponse of Metric</returns>
        ApiResponse<Metric> GetGamificationMetricWithHttpInfo (string metricId, String workday = null, string performanceProfileId = null);

        /// <summary>
        /// Metric definition by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricDefinitionId">metric definition id</param>
        /// <returns>MetricDefinition</returns>
        MetricDefinition GetGamificationMetricdefinition (string metricDefinitionId);

        /// <summary>
        /// Metric definition by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricDefinitionId">metric definition id</param>
        /// <returns>ApiResponse of MetricDefinition</returns>
        ApiResponse<MetricDefinition> GetGamificationMetricdefinitionWithHttpInfo (string metricDefinitionId);

        /// <summary>
        /// All metric definitions
        /// </summary>
        /// <remarks>
        /// Retrieves the metric definitions and their corresponding default objectives used to create a gamified metric
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetMetricDefinitionsResponse</returns>
        GetMetricDefinitionsResponse GetGamificationMetricdefinitions ();

        /// <summary>
        /// All metric definitions
        /// </summary>
        /// <remarks>
        /// Retrieves the metric definitions and their corresponding default objectives used to create a gamified metric
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetMetricDefinitionsResponse</returns>
        ApiResponse<GetMetricDefinitionsResponse> GetGamificationMetricdefinitionsWithHttpInfo ();

        /// <summary>
        /// All gamified metrics for a given profile
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>GetMetricsResponse</returns>
        GetMetricsResponse GetGamificationMetrics (string performanceProfileId = null, String workday = null);

        /// <summary>
        /// All gamified metrics for a given profile
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>ApiResponse of GetMetricsResponse</returns>
        ApiResponse<GetMetricsResponse> GetGamificationMetricsWithHttpInfo (string performanceProfileId = null, String workday = null);

        /// <summary>
        /// Performance profile by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>PerformanceProfile</returns>
        PerformanceProfile GetGamificationProfile (string profileId);

        /// <summary>
        /// Performance profile by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>ApiResponse of PerformanceProfile</returns>
        ApiResponse<PerformanceProfile> GetGamificationProfileWithHttpInfo (string profileId);

        /// <summary>
        /// Members of a given performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <returns>MemberListing</returns>
        MemberListing GetGamificationProfileMembers (string profileId);

        /// <summary>
        /// Members of a given performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <returns>ApiResponse of MemberListing</returns>
        ApiResponse<MemberListing> GetGamificationProfileMembersWithHttpInfo (string profileId);

        /// <summary>
        /// Performance profile gamified metric by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Metric</returns>
        Metric GetGamificationProfileMetric (string profileId, string metricId, String workday = null);

        /// <summary>
        /// Performance profile gamified metric by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>ApiResponse of Metric</returns>
        ApiResponse<Metric> GetGamificationProfileMetricWithHttpInfo (string profileId, string metricId, String workday = null);

        /// <summary>
        /// All gamified metrics for a given performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="metricIds">List of metric ids to filter the response (Optional, comma-separated). (optional)</param>
        /// <returns>GetMetricResponse</returns>
        GetMetricResponse GetGamificationProfileMetrics (string profileId, List<string> expand = null, String workday = null, string metricIds = null);

        /// <summary>
        /// All gamified metrics for a given performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="metricIds">List of metric ids to filter the response (Optional, comma-separated). (optional)</param>
        /// <returns>ApiResponse of GetMetricResponse</returns>
        ApiResponse<GetMetricResponse> GetGamificationProfileMetricsWithHttpInfo (string profileId, List<string> expand = null, String workday = null, string metricIds = null);

        /// <summary>
        /// All metrics for a given performance profile with objective details such as order and maxPoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>GetMetricsResponse</returns>
        GetMetricsResponse GetGamificationProfileMetricsObjectivedetails (string profileId, String workday = null);

        /// <summary>
        /// All metrics for a given performance profile with objective details such as order and maxPoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>ApiResponse of GetMetricsResponse</returns>
        ApiResponse<GetMetricsResponse> GetGamificationProfileMetricsObjectivedetailsWithHttpInfo (string profileId, String workday = null);

        /// <summary>
        /// All performance profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetProfilesResponse</returns>
        GetProfilesResponse GetGamificationProfiles ();

        /// <summary>
        /// All performance profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetProfilesResponse</returns>
        ApiResponse<GetProfilesResponse> GetGamificationProfilesWithHttpInfo ();

        /// <summary>
        /// Performance profile of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>PerformanceProfile</returns>
        PerformanceProfile GetGamificationProfilesUser (string userId, String workday = null);

        /// <summary>
        /// Performance profile of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>ApiResponse of PerformanceProfile</returns>
        ApiResponse<PerformanceProfile> GetGamificationProfilesUserWithHttpInfo (string userId, String workday = null);

        /// <summary>
        /// Performance profile of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>PerformanceProfile</returns>
        PerformanceProfile GetGamificationProfilesUsersMe (String workday = null);

        /// <summary>
        /// Performance profile of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>ApiResponse of PerformanceProfile</returns>
        ApiResponse<PerformanceProfile> GetGamificationProfilesUsersMeWithHttpInfo (String workday = null);

        /// <summary>
        /// Workday performance metrics of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>WorkdayMetricListing</returns>
        WorkdayMetricListing GetGamificationScorecards (String workday, List<string> expand = null);

        /// <summary>
        /// Workday performance metrics of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of WorkdayMetricListing</returns>
        ApiResponse<WorkdayMetricListing> GetGamificationScorecardsWithHttpInfo (String workday, List<string> expand = null);

        /// <summary>
        /// Attendance status metrics of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>AttendanceStatusListing</returns>
        AttendanceStatusListing GetGamificationScorecardsAttendance (String startWorkday, String endWorkday);

        /// <summary>
        /// Attendance status metrics of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>ApiResponse of AttendanceStatusListing</returns>
        ApiResponse<AttendanceStatusListing> GetGamificationScorecardsAttendanceWithHttpInfo (String startWorkday, String endWorkday);

        /// <summary>
        /// Best points of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserBestPoints</returns>
        UserBestPoints GetGamificationScorecardsBestpoints ();

        /// <summary>
        /// Best points of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserBestPoints</returns>
        ApiResponse<UserBestPoints> GetGamificationScorecardsBestpointsWithHttpInfo ();

        /// <summary>
        /// All-time points of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>AllTimePoints</returns>
        AllTimePoints GetGamificationScorecardsPointsAlltime (String endWorkday);

        /// <summary>
        /// All-time points of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>ApiResponse of AllTimePoints</returns>
        ApiResponse<AllTimePoints> GetGamificationScorecardsPointsAlltimeWithHttpInfo (String endWorkday);

        /// <summary>
        /// Average points of the requesting user's division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>SingleWorkdayAveragePoints</returns>
        SingleWorkdayAveragePoints GetGamificationScorecardsPointsAverage (String workday);

        /// <summary>
        /// Average points of the requesting user's division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>ApiResponse of SingleWorkdayAveragePoints</returns>
        ApiResponse<SingleWorkdayAveragePoints> GetGamificationScorecardsPointsAverageWithHttpInfo (String workday);

        /// <summary>
        /// Points trends of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>WorkdayPointsTrend</returns>
        WorkdayPointsTrend GetGamificationScorecardsPointsTrends (String startWorkday, String endWorkday, string dayOfWeek = null);

        /// <summary>
        /// Points trends of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>ApiResponse of WorkdayPointsTrend</returns>
        ApiResponse<WorkdayPointsTrend> GetGamificationScorecardsPointsTrendsWithHttpInfo (String startWorkday, String endWorkday, string dayOfWeek = null);

        /// <summary>
        /// Average performance values trends by metric of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>MetricValueTrendAverage</returns>
        MetricValueTrendAverage GetGamificationScorecardsProfileMetricUserValuesTrends (string profileId, string metricId, string userId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Average performance values trends by metric of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of MetricValueTrendAverage</returns>
        ApiResponse<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricUserValuesTrendsWithHttpInfo (string profileId, string metricId, string userId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Average performance values trends by metric of a division or a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>MetricValueTrendAverage</returns>
        MetricValueTrendAverage GetGamificationScorecardsProfileMetricUsersValuesTrends (string profileId, string metricId, string filterType, string filterId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Average performance values trends by metric of a division or a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of MetricValueTrendAverage</returns>
        ApiResponse<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricUsersValuesTrendsWithHttpInfo (string profileId, string metricId, string filterType, string filterId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Average performance values trends by metric of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, returns the values trends of the requesting user (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>MetricValueTrendAverage</returns>
        MetricValueTrendAverage GetGamificationScorecardsProfileMetricValuesTrends (string profileId, string metricId, String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Average performance values trends by metric of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, returns the values trends of the requesting user (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of MetricValueTrendAverage</returns>
        ApiResponse<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricValuesTrendsWithHttpInfo (string profileId, string metricId, String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Workday performance metrics for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>WorkdayMetricListing</returns>
        WorkdayMetricListing GetGamificationScorecardsUser (string userId, String workday, List<string> expand = null);

        /// <summary>
        /// Workday performance metrics for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of WorkdayMetricListing</returns>
        ApiResponse<WorkdayMetricListing> GetGamificationScorecardsUserWithHttpInfo (string userId, String workday, List<string> expand = null);

        /// <summary>
        /// Attendance status metrics for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>AttendanceStatusListing</returns>
        AttendanceStatusListing GetGamificationScorecardsUserAttendance (string userId, String startWorkday, String endWorkday);

        /// <summary>
        /// Attendance status metrics for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>ApiResponse of AttendanceStatusListing</returns>
        ApiResponse<AttendanceStatusListing> GetGamificationScorecardsUserAttendanceWithHttpInfo (string userId, String startWorkday, String endWorkday);

        /// <summary>
        /// Best points of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>UserBestPoints</returns>
        UserBestPoints GetGamificationScorecardsUserBestpoints (string userId);

        /// <summary>
        /// Best points of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of UserBestPoints</returns>
        ApiResponse<UserBestPoints> GetGamificationScorecardsUserBestpointsWithHttpInfo (string userId);

        /// <summary>
        /// All-time points for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>AllTimePoints</returns>
        AllTimePoints GetGamificationScorecardsUserPointsAlltime (string userId, String endWorkday);

        /// <summary>
        /// All-time points for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>ApiResponse of AllTimePoints</returns>
        ApiResponse<AllTimePoints> GetGamificationScorecardsUserPointsAlltimeWithHttpInfo (string userId, String endWorkday);

        /// <summary>
        /// Points trend for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>WorkdayPointsTrend</returns>
        WorkdayPointsTrend GetGamificationScorecardsUserPointsTrends (string userId, String startWorkday, String endWorkday, string dayOfWeek = null);

        /// <summary>
        /// Points trend for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>ApiResponse of WorkdayPointsTrend</returns>
        ApiResponse<WorkdayPointsTrend> GetGamificationScorecardsUserPointsTrendsWithHttpInfo (string userId, String startWorkday, String endWorkday, string dayOfWeek = null);

        /// <summary>
        /// Values trends of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>WorkdayValuesTrend</returns>
        WorkdayValuesTrend GetGamificationScorecardsUserValuesTrends (string userId, String startWorkday, String endWorkday, string timeZone = null);

        /// <summary>
        /// Values trends of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of WorkdayValuesTrend</returns>
        ApiResponse<WorkdayValuesTrend> GetGamificationScorecardsUserValuesTrendsWithHttpInfo (string userId, String startWorkday, String endWorkday, string timeZone = null);

        /// <summary>
        /// Workday average points by target group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>SingleWorkdayAveragePoints</returns>
        SingleWorkdayAveragePoints GetGamificationScorecardsUsersPointsAverage (string filterType, string filterId, String workday);

        /// <summary>
        /// Workday average points by target group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>ApiResponse of SingleWorkdayAveragePoints</returns>
        ApiResponse<SingleWorkdayAveragePoints> GetGamificationScorecardsUsersPointsAverageWithHttpInfo (string filterType, string filterId, String workday);

        /// <summary>
        /// Workday average values by target group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>SingleWorkdayAverageValues</returns>
        SingleWorkdayAverageValues GetGamificationScorecardsUsersValuesAverage (string filterType, string filterId, String workday, string timeZone = null);

        /// <summary>
        /// Workday average values by target group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of SingleWorkdayAverageValues</returns>
        ApiResponse<SingleWorkdayAverageValues> GetGamificationScorecardsUsersValuesAverageWithHttpInfo (string filterType, string filterId, String workday, string timeZone = null);

        /// <summary>
        /// Values trend by target group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>WorkdayValuesTrend</returns>
        WorkdayValuesTrend GetGamificationScorecardsUsersValuesTrends (string filterType, string filterId, String startWorkday, String endWorkday, string timeZone = null);

        /// <summary>
        /// Values trend by target group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of WorkdayValuesTrend</returns>
        ApiResponse<WorkdayValuesTrend> GetGamificationScorecardsUsersValuesTrendsWithHttpInfo (string filterType, string filterId, String startWorkday, String endWorkday, string timeZone = null);

        /// <summary>
        /// Average values of the requesting user's division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>SingleWorkdayAverageValues</returns>
        SingleWorkdayAverageValues GetGamificationScorecardsValuesAverage (String workday, string timeZone = null);

        /// <summary>
        /// Average values of the requesting user's division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of SingleWorkdayAverageValues</returns>
        ApiResponse<SingleWorkdayAverageValues> GetGamificationScorecardsValuesAverageWithHttpInfo (String workday, string timeZone = null);

        /// <summary>
        /// Values trends of the requesting user or group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, then the request is for the requesting user. (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the profile of the user as of this date. If not set, then the user&#39;s current profile will be used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>WorkdayValuesTrend</returns>
        WorkdayValuesTrend GetGamificationScorecardsValuesTrends (String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Values trends of the requesting user or group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, then the request is for the requesting user. (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the profile of the user as of this date. If not set, then the user&#39;s current profile will be used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of WorkdayValuesTrend</returns>
        ApiResponse<WorkdayValuesTrend> GetGamificationScorecardsValuesTrendsWithHttpInfo (String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Gamification activation status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GamificationStatus</returns>
        GamificationStatus GetGamificationStatus ();

        /// <summary>
        /// Gamification activation status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GamificationStatus</returns>
        ApiResponse<GamificationStatus> GetGamificationStatusWithHttpInfo ();

        /// <summary>
        /// Objective template by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">template id</param>
        /// <returns>ObjectiveTemplate</returns>
        ObjectiveTemplate GetGamificationTemplate (string templateId);

        /// <summary>
        /// Objective template by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">template id</param>
        /// <returns>ApiResponse of ObjectiveTemplate</returns>
        ApiResponse<ObjectiveTemplate> GetGamificationTemplateWithHttpInfo (string templateId);

        /// <summary>
        /// All objective templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetTemplatesResponse</returns>
        GetTemplatesResponse GetGamificationTemplates ();

        /// <summary>
        /// All objective templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetTemplatesResponse</returns>
        ApiResponse<GetTemplatesResponse> GetGamificationTemplatesWithHttpInfo ();

        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Metric</param>
        /// <returns>Metric</returns>
        Metric PostGamificationMetrics (CreateMetric body);

        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Metric</param>
        /// <returns>ApiResponse of Metric</returns>
        ApiResponse<Metric> PostGamificationMetricsWithHttpInfo (CreateMetric body);

        /// <summary>
        /// Activate a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>PerformanceProfile</returns>
        PerformanceProfile PostGamificationProfileActivate (string profileId);

        /// <summary>
        /// Activate a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>ApiResponse of PerformanceProfile</returns>
        ApiResponse<PerformanceProfile> PostGamificationProfileActivateWithHttpInfo (string profileId);

        /// <summary>
        /// Deactivate a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>PerformanceProfile</returns>
        PerformanceProfile PostGamificationProfileDeactivate (string profileId);

        /// <summary>
        /// Deactivate a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>ApiResponse of PerformanceProfile</returns>
        ApiResponse<PerformanceProfile> PostGamificationProfileDeactivateWithHttpInfo (string profileId);

        /// <summary>
        /// Assign members to a given performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">assignUsers</param>
        /// <returns>Assignment</returns>
        Assignment PostGamificationProfileMembers (string profileId, AssignUsers body);

        /// <summary>
        /// Assign members to a given performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">assignUsers</param>
        /// <returns>ApiResponse of Assignment</returns>
        ApiResponse<Assignment> PostGamificationProfileMembersWithHttpInfo (string profileId, AssignUsers body);

        /// <summary>
        /// Validate member assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">memberAssignments</param>
        /// <returns>AssignmentValidation</returns>
        AssignmentValidation PostGamificationProfileMembersValidate (string profileId, ValidateAssignUsers body);

        /// <summary>
        /// Validate member assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">memberAssignments</param>
        /// <returns>ApiResponse of AssignmentValidation</returns>
        ApiResponse<AssignmentValidation> PostGamificationProfileMembersValidateWithHttpInfo (string profileId, ValidateAssignUsers body);

        /// <summary>
        /// Creates a linked metric
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceProfileId">Source Performance Profile Id</param>
        /// <param name="sourceMetricId">Source Metric Id</param>
        /// <param name="body">linkedMetric</param>
        /// <returns>Metric</returns>
        Metric PostGamificationProfileMetricLink (string sourceProfileId, string sourceMetricId, TargetPerformanceProfile body);

        /// <summary>
        /// Creates a linked metric
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceProfileId">Source Performance Profile Id</param>
        /// <param name="sourceMetricId">Source Metric Id</param>
        /// <param name="body">linkedMetric</param>
        /// <returns>ApiResponse of Metric</returns>
        ApiResponse<Metric> PostGamificationProfileMetricLinkWithHttpInfo (string sourceProfileId, string sourceMetricId, TargetPerformanceProfile body);

        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective under in a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="body">Metric</param>
        /// <returns>Metric</returns>
        Metric PostGamificationProfileMetrics (string profileId, CreateMetric body);

        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective under in a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="body">Metric</param>
        /// <returns>ApiResponse of Metric</returns>
        ApiResponse<Metric> PostGamificationProfileMetricsWithHttpInfo (string profileId, CreateMetric body);

        /// <summary>
        /// Create a new custom performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">performanceProfile</param>
        /// <param name="copyMetrics">Flag to copy metrics. If set to false, there will be no metrics associated with the new profile. If set to true or is absent (the default behavior), all metrics from the default profile will be copied over into the new profile. (optional, default to true)</param>
        /// <returns>PerformanceProfile</returns>
        PerformanceProfile PostGamificationProfiles (CreatePerformanceProfile body, bool? copyMetrics = null);

        /// <summary>
        /// Create a new custom performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">performanceProfile</param>
        /// <param name="copyMetrics">Flag to copy metrics. If set to false, there will be no metrics associated with the new profile. If set to true or is absent (the default behavior), all metrics from the default profile will be copied over into the new profile. (optional, default to true)</param>
        /// <returns>ApiResponse of PerformanceProfile</returns>
        ApiResponse<PerformanceProfile> PostGamificationProfilesWithHttpInfo (CreatePerformanceProfile body, bool? copyMetrics = null);

        /// <summary>
        /// Updates a metric
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="body">Metric</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>Metric</returns>
        Metric PutGamificationMetric (string metricId, CreateMetric body, string performanceProfileId = null);

        /// <summary>
        /// Updates a metric
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="body">Metric</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>ApiResponse of Metric</returns>
        ApiResponse<Metric> PutGamificationMetricWithHttpInfo (string metricId, CreateMetric body, string performanceProfileId = null);

        /// <summary>
        /// Updates a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="body">performanceProfile (optional)</param>
        /// <returns>PerformanceProfile</returns>
        PerformanceProfile PutGamificationProfile (string profileId, PerformanceProfile body = null);

        /// <summary>
        /// Updates a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="body">performanceProfile (optional)</param>
        /// <returns>ApiResponse of PerformanceProfile</returns>
        ApiResponse<PerformanceProfile> PutGamificationProfileWithHttpInfo (string profileId, PerformanceProfile body = null);

        /// <summary>
        /// Updates a metric in performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="body">Metric</param>
        /// <returns>Metric</returns>
        Metric PutGamificationProfileMetric (string profileId, string metricId, CreateMetric body);

        /// <summary>
        /// Updates a metric in performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="body">Metric</param>
        /// <returns>ApiResponse of Metric</returns>
        ApiResponse<Metric> PutGamificationProfileMetricWithHttpInfo (string profileId, string metricId, CreateMetric body);

        /// <summary>
        /// Update gamification activation status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Gamification status</param>
        /// <returns>GamificationStatus</returns>
        GamificationStatus PutGamificationStatus (GamificationStatus status);

        /// <summary>
        /// Update gamification activation status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Gamification status</param>
        /// <returns>ApiResponse of GamificationStatus</returns>
        ApiResponse<GamificationStatus> PutGamificationStatusWithHttpInfo (GamificationStatus status);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// Leaderboard of the requesting user's division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>Task of Leaderboard</returns>
        System.Threading.Tasks.Task<Leaderboard> GetGamificationLeaderboardAsync (String startWorkday, String endWorkday, string metricId = null);

        /// <summary>
        /// Leaderboard of the requesting user's division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>Task of ApiResponse (Leaderboard)</returns>
        System.Threading.Tasks.Task<ApiResponse<Leaderboard>> GetGamificationLeaderboardAsyncWithHttpInfo (String startWorkday, String endWorkday, string metricId = null);

        /// <summary>
        /// Leaderboard by filter type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>Task of Leaderboard</returns>
        System.Threading.Tasks.Task<Leaderboard> GetGamificationLeaderboardAllAsync (string filterType, string filterId, String startWorkday, String endWorkday, string metricId = null);

        /// <summary>
        /// Leaderboard by filter type
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>Task of ApiResponse (Leaderboard)</returns>
        System.Threading.Tasks.Task<ApiResponse<Leaderboard>> GetGamificationLeaderboardAllAsyncWithHttpInfo (string filterType, string filterId, String startWorkday, String endWorkday, string metricId = null);

        /// <summary>
        /// Best Points by division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <returns>Task of OverallBestPoints</returns>
        System.Threading.Tasks.Task<OverallBestPoints> GetGamificationLeaderboardAllBestpointsAsync (string filterType, string filterId);

        /// <summary>
        /// Best Points by division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <returns>Task of ApiResponse (OverallBestPoints)</returns>
        System.Threading.Tasks.Task<ApiResponse<OverallBestPoints>> GetGamificationLeaderboardAllBestpointsAsyncWithHttpInfo (string filterType, string filterId);

        /// <summary>
        /// Best Points of the requesting user's current performance profile or division
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OverallBestPoints</returns>
        System.Threading.Tasks.Task<OverallBestPoints> GetGamificationLeaderboardBestpointsAsync ();

        /// <summary>
        /// Best Points of the requesting user's current performance profile or division
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OverallBestPoints)</returns>
        System.Threading.Tasks.Task<ApiResponse<OverallBestPoints>> GetGamificationLeaderboardBestpointsAsyncWithHttpInfo ();

        /// <summary>
        /// Gamified metric by id
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>Task of Metric</returns>
        System.Threading.Tasks.Task<Metric> GetGamificationMetricAsync (string metricId, String workday = null, string performanceProfileId = null);

        /// <summary>
        /// Gamified metric by id
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>Task of ApiResponse (Metric)</returns>
        System.Threading.Tasks.Task<ApiResponse<Metric>> GetGamificationMetricAsyncWithHttpInfo (string metricId, String workday = null, string performanceProfileId = null);

        /// <summary>
        /// Metric definition by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricDefinitionId">metric definition id</param>
        /// <returns>Task of MetricDefinition</returns>
        System.Threading.Tasks.Task<MetricDefinition> GetGamificationMetricdefinitionAsync (string metricDefinitionId);

        /// <summary>
        /// Metric definition by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricDefinitionId">metric definition id</param>
        /// <returns>Task of ApiResponse (MetricDefinition)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetricDefinition>> GetGamificationMetricdefinitionAsyncWithHttpInfo (string metricDefinitionId);

        /// <summary>
        /// All metric definitions
        /// </summary>
        /// <remarks>
        /// Retrieves the metric definitions and their corresponding default objectives used to create a gamified metric
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GetMetricDefinitionsResponse</returns>
        System.Threading.Tasks.Task<GetMetricDefinitionsResponse> GetGamificationMetricdefinitionsAsync ();

        /// <summary>
        /// All metric definitions
        /// </summary>
        /// <remarks>
        /// Retrieves the metric definitions and their corresponding default objectives used to create a gamified metric
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GetMetricDefinitionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetMetricDefinitionsResponse>> GetGamificationMetricdefinitionsAsyncWithHttpInfo ();

        /// <summary>
        /// All gamified metrics for a given profile
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of GetMetricsResponse</returns>
        System.Threading.Tasks.Task<GetMetricsResponse> GetGamificationMetricsAsync (string performanceProfileId = null, String workday = null);

        /// <summary>
        /// All gamified metrics for a given profile
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (GetMetricsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetMetricsResponse>> GetGamificationMetricsAsyncWithHttpInfo (string performanceProfileId = null, String workday = null);

        /// <summary>
        /// Performance profile by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>Task of PerformanceProfile</returns>
        System.Threading.Tasks.Task<PerformanceProfile> GetGamificationProfileAsync (string profileId);

        /// <summary>
        /// Performance profile by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>Task of ApiResponse (PerformanceProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<PerformanceProfile>> GetGamificationProfileAsyncWithHttpInfo (string profileId);

        /// <summary>
        /// Members of a given performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <returns>Task of MemberListing</returns>
        System.Threading.Tasks.Task<MemberListing> GetGamificationProfileMembersAsync (string profileId);

        /// <summary>
        /// Members of a given performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <returns>Task of ApiResponse (MemberListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<MemberListing>> GetGamificationProfileMembersAsyncWithHttpInfo (string profileId);

        /// <summary>
        /// Performance profile gamified metric by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of Metric</returns>
        System.Threading.Tasks.Task<Metric> GetGamificationProfileMetricAsync (string profileId, string metricId, String workday = null);

        /// <summary>
        /// Performance profile gamified metric by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (Metric)</returns>
        System.Threading.Tasks.Task<ApiResponse<Metric>> GetGamificationProfileMetricAsyncWithHttpInfo (string profileId, string metricId, String workday = null);

        /// <summary>
        /// All gamified metrics for a given performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="metricIds">List of metric ids to filter the response (Optional, comma-separated). (optional)</param>
        /// <returns>Task of GetMetricResponse</returns>
        System.Threading.Tasks.Task<GetMetricResponse> GetGamificationProfileMetricsAsync (string profileId, List<string> expand = null, String workday = null, string metricIds = null);

        /// <summary>
        /// All gamified metrics for a given performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="metricIds">List of metric ids to filter the response (Optional, comma-separated). (optional)</param>
        /// <returns>Task of ApiResponse (GetMetricResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetMetricResponse>> GetGamificationProfileMetricsAsyncWithHttpInfo (string profileId, List<string> expand = null, String workday = null, string metricIds = null);

        /// <summary>
        /// All metrics for a given performance profile with objective details such as order and maxPoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of GetMetricsResponse</returns>
        System.Threading.Tasks.Task<GetMetricsResponse> GetGamificationProfileMetricsObjectivedetailsAsync (string profileId, String workday = null);

        /// <summary>
        /// All metrics for a given performance profile with objective details such as order and maxPoints
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (GetMetricsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetMetricsResponse>> GetGamificationProfileMetricsObjectivedetailsAsyncWithHttpInfo (string profileId, String workday = null);

        /// <summary>
        /// All performance profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GetProfilesResponse</returns>
        System.Threading.Tasks.Task<GetProfilesResponse> GetGamificationProfilesAsync ();

        /// <summary>
        /// All performance profiles
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GetProfilesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetProfilesResponse>> GetGamificationProfilesAsyncWithHttpInfo ();

        /// <summary>
        /// Performance profile of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of PerformanceProfile</returns>
        System.Threading.Tasks.Task<PerformanceProfile> GetGamificationProfilesUserAsync (string userId, String workday = null);

        /// <summary>
        /// Performance profile of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (PerformanceProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<PerformanceProfile>> GetGamificationProfilesUserAsyncWithHttpInfo (string userId, String workday = null);

        /// <summary>
        /// Performance profile of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of PerformanceProfile</returns>
        System.Threading.Tasks.Task<PerformanceProfile> GetGamificationProfilesUsersMeAsync (String workday = null);

        /// <summary>
        /// Performance profile of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (PerformanceProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<PerformanceProfile>> GetGamificationProfilesUsersMeAsyncWithHttpInfo (String workday = null);

        /// <summary>
        /// Workday performance metrics of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of WorkdayMetricListing</returns>
        System.Threading.Tasks.Task<WorkdayMetricListing> GetGamificationScorecardsAsync (String workday, List<string> expand = null);

        /// <summary>
        /// Workday performance metrics of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (WorkdayMetricListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkdayMetricListing>> GetGamificationScorecardsAsyncWithHttpInfo (String workday, List<string> expand = null);

        /// <summary>
        /// Attendance status metrics of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of AttendanceStatusListing</returns>
        System.Threading.Tasks.Task<AttendanceStatusListing> GetGamificationScorecardsAttendanceAsync (String startWorkday, String endWorkday);

        /// <summary>
        /// Attendance status metrics of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of ApiResponse (AttendanceStatusListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttendanceStatusListing>> GetGamificationScorecardsAttendanceAsyncWithHttpInfo (String startWorkday, String endWorkday);

        /// <summary>
        /// Best points of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserBestPoints</returns>
        System.Threading.Tasks.Task<UserBestPoints> GetGamificationScorecardsBestpointsAsync ();

        /// <summary>
        /// Best points of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserBestPoints)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserBestPoints>> GetGamificationScorecardsBestpointsAsyncWithHttpInfo ();

        /// <summary>
        /// All-time points of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of AllTimePoints</returns>
        System.Threading.Tasks.Task<AllTimePoints> GetGamificationScorecardsPointsAlltimeAsync (String endWorkday);

        /// <summary>
        /// All-time points of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of ApiResponse (AllTimePoints)</returns>
        System.Threading.Tasks.Task<ApiResponse<AllTimePoints>> GetGamificationScorecardsPointsAlltimeAsyncWithHttpInfo (String endWorkday);

        /// <summary>
        /// Average points of the requesting user's division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of SingleWorkdayAveragePoints</returns>
        System.Threading.Tasks.Task<SingleWorkdayAveragePoints> GetGamificationScorecardsPointsAverageAsync (String workday);

        /// <summary>
        /// Average points of the requesting user's division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of ApiResponse (SingleWorkdayAveragePoints)</returns>
        System.Threading.Tasks.Task<ApiResponse<SingleWorkdayAveragePoints>> GetGamificationScorecardsPointsAverageAsyncWithHttpInfo (String workday);

        /// <summary>
        /// Points trends of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>Task of WorkdayPointsTrend</returns>
        System.Threading.Tasks.Task<WorkdayPointsTrend> GetGamificationScorecardsPointsTrendsAsync (String startWorkday, String endWorkday, string dayOfWeek = null);

        /// <summary>
        /// Points trends of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>Task of ApiResponse (WorkdayPointsTrend)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkdayPointsTrend>> GetGamificationScorecardsPointsTrendsAsyncWithHttpInfo (String startWorkday, String endWorkday, string dayOfWeek = null);

        /// <summary>
        /// Average performance values trends by metric of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of MetricValueTrendAverage</returns>
        System.Threading.Tasks.Task<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricUserValuesTrendsAsync (string profileId, string metricId, string userId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Average performance values trends by metric of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (MetricValueTrendAverage)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetricValueTrendAverage>> GetGamificationScorecardsProfileMetricUserValuesTrendsAsyncWithHttpInfo (string profileId, string metricId, string userId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Average performance values trends by metric of a division or a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of MetricValueTrendAverage</returns>
        System.Threading.Tasks.Task<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricUsersValuesTrendsAsync (string profileId, string metricId, string filterType, string filterId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Average performance values trends by metric of a division or a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (MetricValueTrendAverage)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetricValueTrendAverage>> GetGamificationScorecardsProfileMetricUsersValuesTrendsAsyncWithHttpInfo (string profileId, string metricId, string filterType, string filterId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Average performance values trends by metric of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, returns the values trends of the requesting user (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of MetricValueTrendAverage</returns>
        System.Threading.Tasks.Task<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricValuesTrendsAsync (string profileId, string metricId, String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Average performance values trends by metric of the requesting user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, returns the values trends of the requesting user (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (MetricValueTrendAverage)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetricValueTrendAverage>> GetGamificationScorecardsProfileMetricValuesTrendsAsyncWithHttpInfo (string profileId, string metricId, String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Workday performance metrics for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of WorkdayMetricListing</returns>
        System.Threading.Tasks.Task<WorkdayMetricListing> GetGamificationScorecardsUserAsync (string userId, String workday, List<string> expand = null);

        /// <summary>
        /// Workday performance metrics for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (WorkdayMetricListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkdayMetricListing>> GetGamificationScorecardsUserAsyncWithHttpInfo (string userId, String workday, List<string> expand = null);

        /// <summary>
        /// Attendance status metrics for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of AttendanceStatusListing</returns>
        System.Threading.Tasks.Task<AttendanceStatusListing> GetGamificationScorecardsUserAttendanceAsync (string userId, String startWorkday, String endWorkday);

        /// <summary>
        /// Attendance status metrics for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of ApiResponse (AttendanceStatusListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttendanceStatusListing>> GetGamificationScorecardsUserAttendanceAsyncWithHttpInfo (string userId, String startWorkday, String endWorkday);

        /// <summary>
        /// Best points of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>Task of UserBestPoints</returns>
        System.Threading.Tasks.Task<UserBestPoints> GetGamificationScorecardsUserBestpointsAsync (string userId);

        /// <summary>
        /// Best points of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>Task of ApiResponse (UserBestPoints)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserBestPoints>> GetGamificationScorecardsUserBestpointsAsyncWithHttpInfo (string userId);

        /// <summary>
        /// All-time points for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of AllTimePoints</returns>
        System.Threading.Tasks.Task<AllTimePoints> GetGamificationScorecardsUserPointsAlltimeAsync (string userId, String endWorkday);

        /// <summary>
        /// All-time points for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of ApiResponse (AllTimePoints)</returns>
        System.Threading.Tasks.Task<ApiResponse<AllTimePoints>> GetGamificationScorecardsUserPointsAlltimeAsyncWithHttpInfo (string userId, String endWorkday);

        /// <summary>
        /// Points trend for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>Task of WorkdayPointsTrend</returns>
        System.Threading.Tasks.Task<WorkdayPointsTrend> GetGamificationScorecardsUserPointsTrendsAsync (string userId, String startWorkday, String endWorkday, string dayOfWeek = null);

        /// <summary>
        /// Points trend for a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>Task of ApiResponse (WorkdayPointsTrend)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkdayPointsTrend>> GetGamificationScorecardsUserPointsTrendsAsyncWithHttpInfo (string userId, String startWorkday, String endWorkday, string dayOfWeek = null);

        /// <summary>
        /// Values trends of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of WorkdayValuesTrend</returns>
        System.Threading.Tasks.Task<WorkdayValuesTrend> GetGamificationScorecardsUserValuesTrendsAsync (string userId, String startWorkday, String endWorkday, string timeZone = null);

        /// <summary>
        /// Values trends of a user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (WorkdayValuesTrend)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkdayValuesTrend>> GetGamificationScorecardsUserValuesTrendsAsyncWithHttpInfo (string userId, String startWorkday, String endWorkday, string timeZone = null);

        /// <summary>
        /// Workday average points by target group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of SingleWorkdayAveragePoints</returns>
        System.Threading.Tasks.Task<SingleWorkdayAveragePoints> GetGamificationScorecardsUsersPointsAverageAsync (string filterType, string filterId, String workday);

        /// <summary>
        /// Workday average points by target group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of ApiResponse (SingleWorkdayAveragePoints)</returns>
        System.Threading.Tasks.Task<ApiResponse<SingleWorkdayAveragePoints>> GetGamificationScorecardsUsersPointsAverageAsyncWithHttpInfo (string filterType, string filterId, String workday);

        /// <summary>
        /// Workday average values by target group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of SingleWorkdayAverageValues</returns>
        System.Threading.Tasks.Task<SingleWorkdayAverageValues> GetGamificationScorecardsUsersValuesAverageAsync (string filterType, string filterId, String workday, string timeZone = null);

        /// <summary>
        /// Workday average values by target group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (SingleWorkdayAverageValues)</returns>
        System.Threading.Tasks.Task<ApiResponse<SingleWorkdayAverageValues>> GetGamificationScorecardsUsersValuesAverageAsyncWithHttpInfo (string filterType, string filterId, String workday, string timeZone = null);

        /// <summary>
        /// Values trend by target group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of WorkdayValuesTrend</returns>
        System.Threading.Tasks.Task<WorkdayValuesTrend> GetGamificationScorecardsUsersValuesTrendsAsync (string filterType, string filterId, String startWorkday, String endWorkday, string timeZone = null);

        /// <summary>
        /// Values trend by target group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (WorkdayValuesTrend)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkdayValuesTrend>> GetGamificationScorecardsUsersValuesTrendsAsyncWithHttpInfo (string filterType, string filterId, String startWorkday, String endWorkday, string timeZone = null);

        /// <summary>
        /// Average values of the requesting user's division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of SingleWorkdayAverageValues</returns>
        System.Threading.Tasks.Task<SingleWorkdayAverageValues> GetGamificationScorecardsValuesAverageAsync (String workday, string timeZone = null);

        /// <summary>
        /// Average values of the requesting user's division or performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (SingleWorkdayAverageValues)</returns>
        System.Threading.Tasks.Task<ApiResponse<SingleWorkdayAverageValues>> GetGamificationScorecardsValuesAverageAsyncWithHttpInfo (String workday, string timeZone = null);

        /// <summary>
        /// Values trends of the requesting user or group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, then the request is for the requesting user. (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the profile of the user as of this date. If not set, then the user&#39;s current profile will be used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of WorkdayValuesTrend</returns>
        System.Threading.Tasks.Task<WorkdayValuesTrend> GetGamificationScorecardsValuesTrendsAsync (String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Values trends of the requesting user or group
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, then the request is for the requesting user. (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the profile of the user as of this date. If not set, then the user&#39;s current profile will be used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (WorkdayValuesTrend)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkdayValuesTrend>> GetGamificationScorecardsValuesTrendsAsyncWithHttpInfo (String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null);

        /// <summary>
        /// Gamification activation status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GamificationStatus</returns>
        System.Threading.Tasks.Task<GamificationStatus> GetGamificationStatusAsync ();

        /// <summary>
        /// Gamification activation status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GamificationStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<GamificationStatus>> GetGamificationStatusAsyncWithHttpInfo ();

        /// <summary>
        /// Objective template by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">template id</param>
        /// <returns>Task of ObjectiveTemplate</returns>
        System.Threading.Tasks.Task<ObjectiveTemplate> GetGamificationTemplateAsync (string templateId);

        /// <summary>
        /// Objective template by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">template id</param>
        /// <returns>Task of ApiResponse (ObjectiveTemplate)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectiveTemplate>> GetGamificationTemplateAsyncWithHttpInfo (string templateId);

        /// <summary>
        /// All objective templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GetTemplatesResponse</returns>
        System.Threading.Tasks.Task<GetTemplatesResponse> GetGamificationTemplatesAsync ();

        /// <summary>
        /// All objective templates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GetTemplatesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetTemplatesResponse>> GetGamificationTemplatesAsyncWithHttpInfo ();

        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Metric</param>
        /// <returns>Task of Metric</returns>
        System.Threading.Tasks.Task<Metric> PostGamificationMetricsAsync (CreateMetric body);

        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Metric</param>
        /// <returns>Task of ApiResponse (Metric)</returns>
        System.Threading.Tasks.Task<ApiResponse<Metric>> PostGamificationMetricsAsyncWithHttpInfo (CreateMetric body);

        /// <summary>
        /// Activate a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>Task of PerformanceProfile</returns>
        System.Threading.Tasks.Task<PerformanceProfile> PostGamificationProfileActivateAsync (string profileId);

        /// <summary>
        /// Activate a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>Task of ApiResponse (PerformanceProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<PerformanceProfile>> PostGamificationProfileActivateAsyncWithHttpInfo (string profileId);

        /// <summary>
        /// Deactivate a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>Task of PerformanceProfile</returns>
        System.Threading.Tasks.Task<PerformanceProfile> PostGamificationProfileDeactivateAsync (string profileId);

        /// <summary>
        /// Deactivate a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>Task of ApiResponse (PerformanceProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<PerformanceProfile>> PostGamificationProfileDeactivateAsyncWithHttpInfo (string profileId);

        /// <summary>
        /// Assign members to a given performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">assignUsers</param>
        /// <returns>Task of Assignment</returns>
        System.Threading.Tasks.Task<Assignment> PostGamificationProfileMembersAsync (string profileId, AssignUsers body);

        /// <summary>
        /// Assign members to a given performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">assignUsers</param>
        /// <returns>Task of ApiResponse (Assignment)</returns>
        System.Threading.Tasks.Task<ApiResponse<Assignment>> PostGamificationProfileMembersAsyncWithHttpInfo (string profileId, AssignUsers body);

        /// <summary>
        /// Validate member assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">memberAssignments</param>
        /// <returns>Task of AssignmentValidation</returns>
        System.Threading.Tasks.Task<AssignmentValidation> PostGamificationProfileMembersValidateAsync (string profileId, ValidateAssignUsers body);

        /// <summary>
        /// Validate member assignment
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">memberAssignments</param>
        /// <returns>Task of ApiResponse (AssignmentValidation)</returns>
        System.Threading.Tasks.Task<ApiResponse<AssignmentValidation>> PostGamificationProfileMembersValidateAsyncWithHttpInfo (string profileId, ValidateAssignUsers body);

        /// <summary>
        /// Creates a linked metric
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceProfileId">Source Performance Profile Id</param>
        /// <param name="sourceMetricId">Source Metric Id</param>
        /// <param name="body">linkedMetric</param>
        /// <returns>Task of Metric</returns>
        System.Threading.Tasks.Task<Metric> PostGamificationProfileMetricLinkAsync (string sourceProfileId, string sourceMetricId, TargetPerformanceProfile body);

        /// <summary>
        /// Creates a linked metric
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceProfileId">Source Performance Profile Id</param>
        /// <param name="sourceMetricId">Source Metric Id</param>
        /// <param name="body">linkedMetric</param>
        /// <returns>Task of ApiResponse (Metric)</returns>
        System.Threading.Tasks.Task<ApiResponse<Metric>> PostGamificationProfileMetricLinkAsyncWithHttpInfo (string sourceProfileId, string sourceMetricId, TargetPerformanceProfile body);

        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective under in a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="body">Metric</param>
        /// <returns>Task of Metric</returns>
        System.Threading.Tasks.Task<Metric> PostGamificationProfileMetricsAsync (string profileId, CreateMetric body);

        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective under in a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="body">Metric</param>
        /// <returns>Task of ApiResponse (Metric)</returns>
        System.Threading.Tasks.Task<ApiResponse<Metric>> PostGamificationProfileMetricsAsyncWithHttpInfo (string profileId, CreateMetric body);

        /// <summary>
        /// Create a new custom performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">performanceProfile</param>
        /// <param name="copyMetrics">Flag to copy metrics. If set to false, there will be no metrics associated with the new profile. If set to true or is absent (the default behavior), all metrics from the default profile will be copied over into the new profile. (optional, default to true)</param>
        /// <returns>Task of PerformanceProfile</returns>
        System.Threading.Tasks.Task<PerformanceProfile> PostGamificationProfilesAsync (CreatePerformanceProfile body, bool? copyMetrics = null);

        /// <summary>
        /// Create a new custom performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">performanceProfile</param>
        /// <param name="copyMetrics">Flag to copy metrics. If set to false, there will be no metrics associated with the new profile. If set to true or is absent (the default behavior), all metrics from the default profile will be copied over into the new profile. (optional, default to true)</param>
        /// <returns>Task of ApiResponse (PerformanceProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<PerformanceProfile>> PostGamificationProfilesAsyncWithHttpInfo (CreatePerformanceProfile body, bool? copyMetrics = null);

        /// <summary>
        /// Updates a metric
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="body">Metric</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>Task of Metric</returns>
        System.Threading.Tasks.Task<Metric> PutGamificationMetricAsync (string metricId, CreateMetric body, string performanceProfileId = null);

        /// <summary>
        /// Updates a metric
        /// </summary>
        /// <remarks>
        /// This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="body">Metric</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>Task of ApiResponse (Metric)</returns>
        System.Threading.Tasks.Task<ApiResponse<Metric>> PutGamificationMetricAsyncWithHttpInfo (string metricId, CreateMetric body, string performanceProfileId = null);

        /// <summary>
        /// Updates a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="body">performanceProfile (optional)</param>
        /// <returns>Task of PerformanceProfile</returns>
        System.Threading.Tasks.Task<PerformanceProfile> PutGamificationProfileAsync (string profileId, PerformanceProfile body = null);

        /// <summary>
        /// Updates a performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="body">performanceProfile (optional)</param>
        /// <returns>Task of ApiResponse (PerformanceProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<PerformanceProfile>> PutGamificationProfileAsyncWithHttpInfo (string profileId, PerformanceProfile body = null);

        /// <summary>
        /// Updates a metric in performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="body">Metric</param>
        /// <returns>Task of Metric</returns>
        System.Threading.Tasks.Task<Metric> PutGamificationProfileMetricAsync (string profileId, string metricId, CreateMetric body);

        /// <summary>
        /// Updates a metric in performance profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="body">Metric</param>
        /// <returns>Task of ApiResponse (Metric)</returns>
        System.Threading.Tasks.Task<ApiResponse<Metric>> PutGamificationProfileMetricAsyncWithHttpInfo (string profileId, string metricId, CreateMetric body);

        /// <summary>
        /// Update gamification activation status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Gamification status</param>
        /// <returns>Task of GamificationStatus</returns>
        System.Threading.Tasks.Task<GamificationStatus> PutGamificationStatusAsync (GamificationStatus status);

        /// <summary>
        /// Update gamification activation status
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Gamification status</param>
        /// <returns>Task of ApiResponse (GamificationStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<GamificationStatus>> PutGamificationStatusAsyncWithHttpInfo (GamificationStatus status);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GamificationApi : IGamificationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GamificationApi(String basePath)
        {
            this.Configuration = new PureCloudPlatform.Client.V2.Client.Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GamificationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GamificationApi(PureCloudPlatform.Client.V2.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = PureCloudPlatform.Client.V2.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (this.Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'this.Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PureCloudPlatform.Client.V2.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use this.Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use this.Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }


        /// <summary>
        /// Leaderboard of the requesting user's division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>Leaderboard</returns>
        public Leaderboard GetGamificationLeaderboard (String startWorkday, String endWorkday, string metricId = null)
        {
             ApiResponse<Leaderboard> localVarResponse = GetGamificationLeaderboardWithHttpInfo(startWorkday, endWorkday, metricId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Leaderboard of the requesting user's division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>ApiResponse of Leaderboard</returns>
        public ApiResponse< Leaderboard > GetGamificationLeaderboardWithHttpInfo (String startWorkday, String endWorkday, string metricId = null)
        { 
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationLeaderboard");
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationLeaderboard");

            var localVarPath = "/api/v2/gamification/leaderboard";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (metricId != null) localVarQueryParams.Add(new Tuple<string, string>("metricId", this.Configuration.ApiClient.ParameterToString(metricId)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboard: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboard: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Leaderboard>(localVarStatusCode,
                localVarHeaders,
                (Leaderboard) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Leaderboard)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Leaderboard of the requesting user's division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>Task of Leaderboard</returns>
        public async System.Threading.Tasks.Task<Leaderboard> GetGamificationLeaderboardAsync (String startWorkday, String endWorkday, string metricId = null)
        {
             ApiResponse<Leaderboard> localVarResponse = await GetGamificationLeaderboardAsyncWithHttpInfo(startWorkday, endWorkday, metricId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Leaderboard of the requesting user's division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>Task of ApiResponse (Leaderboard)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Leaderboard>> GetGamificationLeaderboardAsyncWithHttpInfo (String startWorkday, String endWorkday, string metricId = null)
        { 
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationLeaderboard");
            
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationLeaderboard");
            

            var localVarPath = "/api/v2/gamification/leaderboard";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (metricId != null) localVarQueryParams.Add(new Tuple<string, string>("metricId", this.Configuration.ApiClient.ParameterToString(metricId)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboard: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboard: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Leaderboard>(localVarStatusCode,
                localVarHeaders,
                (Leaderboard) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Leaderboard)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Leaderboard by filter type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>Leaderboard</returns>
        public Leaderboard GetGamificationLeaderboardAll (string filterType, string filterId, String startWorkday, String endWorkday, string metricId = null)
        {
             ApiResponse<Leaderboard> localVarResponse = GetGamificationLeaderboardAllWithHttpInfo(filterType, filterId, startWorkday, endWorkday, metricId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Leaderboard by filter type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>ApiResponse of Leaderboard</returns>
        public ApiResponse< Leaderboard > GetGamificationLeaderboardAllWithHttpInfo (string filterType, string filterId, String startWorkday, String endWorkday, string metricId = null)
        { 
            // verify the required parameter 'filterType' is set
            if (filterType == null)
                throw new ApiException(400, "Missing required parameter 'filterType' when calling GamificationApi->GetGamificationLeaderboardAll");
            // verify the required parameter 'filterId' is set
            if (filterId == null)
                throw new ApiException(400, "Missing required parameter 'filterId' when calling GamificationApi->GetGamificationLeaderboardAll");
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationLeaderboardAll");
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationLeaderboardAll");

            var localVarPath = "/api/v2/gamification/leaderboard/all";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (filterId != null) localVarQueryParams.Add(new Tuple<string, string>("filterId", this.Configuration.ApiClient.ParameterToString(filterId)));
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (metricId != null) localVarQueryParams.Add(new Tuple<string, string>("metricId", this.Configuration.ApiClient.ParameterToString(metricId)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboardAll: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboardAll: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Leaderboard>(localVarStatusCode,
                localVarHeaders,
                (Leaderboard) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Leaderboard)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Leaderboard by filter type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>Task of Leaderboard</returns>
        public async System.Threading.Tasks.Task<Leaderboard> GetGamificationLeaderboardAllAsync (string filterType, string filterId, String startWorkday, String endWorkday, string metricId = null)
        {
             ApiResponse<Leaderboard> localVarResponse = await GetGamificationLeaderboardAllAsyncWithHttpInfo(filterType, filterId, startWorkday, endWorkday, metricId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Leaderboard by filter type 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <param name="startWorkday">Start workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday to retrieve for the leaderboard. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="metricId">Metric Id for which the leaderboard is to be generated. The total points is used if nothing is given. (optional)</param>
        /// <returns>Task of ApiResponse (Leaderboard)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Leaderboard>> GetGamificationLeaderboardAllAsyncWithHttpInfo (string filterType, string filterId, String startWorkday, String endWorkday, string metricId = null)
        { 
            // verify the required parameter 'filterType' is set
            if (filterType == null)
                throw new ApiException(400, "Missing required parameter 'filterType' when calling GamificationApi->GetGamificationLeaderboardAll");
            
            // verify the required parameter 'filterId' is set
            if (filterId == null)
                throw new ApiException(400, "Missing required parameter 'filterId' when calling GamificationApi->GetGamificationLeaderboardAll");
            
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationLeaderboardAll");
            
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationLeaderboardAll");
            

            var localVarPath = "/api/v2/gamification/leaderboard/all";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (filterId != null) localVarQueryParams.Add(new Tuple<string, string>("filterId", this.Configuration.ApiClient.ParameterToString(filterId)));
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (metricId != null) localVarQueryParams.Add(new Tuple<string, string>("metricId", this.Configuration.ApiClient.ParameterToString(metricId)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboardAll: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboardAll: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Leaderboard>(localVarStatusCode,
                localVarHeaders,
                (Leaderboard) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Leaderboard)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Best Points by division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <returns>OverallBestPoints</returns>
        public OverallBestPoints GetGamificationLeaderboardAllBestpoints (string filterType, string filterId)
        {
             ApiResponse<OverallBestPoints> localVarResponse = GetGamificationLeaderboardAllBestpointsWithHttpInfo(filterType, filterId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Best Points by division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <returns>ApiResponse of OverallBestPoints</returns>
        public ApiResponse< OverallBestPoints > GetGamificationLeaderboardAllBestpointsWithHttpInfo (string filterType, string filterId)
        { 
            // verify the required parameter 'filterType' is set
            if (filterType == null)
                throw new ApiException(400, "Missing required parameter 'filterType' when calling GamificationApi->GetGamificationLeaderboardAllBestpoints");
            // verify the required parameter 'filterId' is set
            if (filterId == null)
                throw new ApiException(400, "Missing required parameter 'filterId' when calling GamificationApi->GetGamificationLeaderboardAllBestpoints");

            var localVarPath = "/api/v2/gamification/leaderboard/all/bestpoints";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (filterId != null) localVarQueryParams.Add(new Tuple<string, string>("filterId", this.Configuration.ApiClient.ParameterToString(filterId)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboardAllBestpoints: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboardAllBestpoints: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OverallBestPoints>(localVarStatusCode,
                localVarHeaders,
                (OverallBestPoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OverallBestPoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Best Points by division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <returns>Task of OverallBestPoints</returns>
        public async System.Threading.Tasks.Task<OverallBestPoints> GetGamificationLeaderboardAllBestpointsAsync (string filterType, string filterId)
        {
             ApiResponse<OverallBestPoints> localVarResponse = await GetGamificationLeaderboardAllBestpointsAsyncWithHttpInfo(filterType, filterId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Best Points by division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division or performance profile Id</param>
        /// <returns>Task of ApiResponse (OverallBestPoints)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OverallBestPoints>> GetGamificationLeaderboardAllBestpointsAsyncWithHttpInfo (string filterType, string filterId)
        { 
            // verify the required parameter 'filterType' is set
            if (filterType == null)
                throw new ApiException(400, "Missing required parameter 'filterType' when calling GamificationApi->GetGamificationLeaderboardAllBestpoints");
            
            // verify the required parameter 'filterId' is set
            if (filterId == null)
                throw new ApiException(400, "Missing required parameter 'filterId' when calling GamificationApi->GetGamificationLeaderboardAllBestpoints");
            

            var localVarPath = "/api/v2/gamification/leaderboard/all/bestpoints";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (filterId != null) localVarQueryParams.Add(new Tuple<string, string>("filterId", this.Configuration.ApiClient.ParameterToString(filterId)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboardAllBestpoints: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboardAllBestpoints: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OverallBestPoints>(localVarStatusCode,
                localVarHeaders,
                (OverallBestPoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OverallBestPoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Best Points of the requesting user's current performance profile or division 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OverallBestPoints</returns>
        public OverallBestPoints GetGamificationLeaderboardBestpoints ()
        {
             ApiResponse<OverallBestPoints> localVarResponse = GetGamificationLeaderboardBestpointsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Best Points of the requesting user's current performance profile or division 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OverallBestPoints</returns>
        public ApiResponse< OverallBestPoints > GetGamificationLeaderboardBestpointsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/gamification/leaderboard/bestpoints";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboardBestpoints: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboardBestpoints: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OverallBestPoints>(localVarStatusCode,
                localVarHeaders,
                (OverallBestPoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OverallBestPoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Best Points of the requesting user's current performance profile or division 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of OverallBestPoints</returns>
        public async System.Threading.Tasks.Task<OverallBestPoints> GetGamificationLeaderboardBestpointsAsync ()
        {
             ApiResponse<OverallBestPoints> localVarResponse = await GetGamificationLeaderboardBestpointsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Best Points of the requesting user's current performance profile or division 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (OverallBestPoints)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OverallBestPoints>> GetGamificationLeaderboardBestpointsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/gamification/leaderboard/bestpoints";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboardBestpoints: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationLeaderboardBestpoints: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OverallBestPoints>(localVarStatusCode,
                localVarHeaders,
                (OverallBestPoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OverallBestPoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gamified metric by id This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>Metric</returns>
        public Metric GetGamificationMetric (string metricId, String workday = null, string performanceProfileId = null)
        {
             ApiResponse<Metric> localVarResponse = GetGamificationMetricWithHttpInfo(metricId, workday, performanceProfileId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gamified metric by id This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>ApiResponse of Metric</returns>
        public ApiResponse< Metric > GetGamificationMetricWithHttpInfo (string metricId, String workday = null, string performanceProfileId = null)
        { 
            // verify the required parameter 'metricId' is set
            if (metricId == null)
                throw new ApiException(400, "Missing required parameter 'metricId' when calling GamificationApi->GetGamificationMetric");

            var localVarPath = "/api/v2/gamification/metrics/{metricId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (metricId != null) localVarPathParams.Add("metricId", this.Configuration.ApiClient.ParameterToString(metricId));

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));
            if (performanceProfileId != null) localVarQueryParams.Add(new Tuple<string, string>("performanceProfileId", this.Configuration.ApiClient.ParameterToString(performanceProfileId)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetric: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetric: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Metric>(localVarStatusCode,
                localVarHeaders,
                (Metric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gamified metric by id This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>Task of Metric</returns>
        public async System.Threading.Tasks.Task<Metric> GetGamificationMetricAsync (string metricId, String workday = null, string performanceProfileId = null)
        {
             ApiResponse<Metric> localVarResponse = await GetGamificationMetricAsyncWithHttpInfo(metricId, workday, performanceProfileId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gamified metric by id This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>Task of ApiResponse (Metric)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Metric>> GetGamificationMetricAsyncWithHttpInfo (string metricId, String workday = null, string performanceProfileId = null)
        { 
            // verify the required parameter 'metricId' is set
            if (metricId == null)
                throw new ApiException(400, "Missing required parameter 'metricId' when calling GamificationApi->GetGamificationMetric");
            

            var localVarPath = "/api/v2/gamification/metrics/{metricId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (metricId != null) localVarPathParams.Add("metricId", this.Configuration.ApiClient.ParameterToString(metricId));

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));
            if (performanceProfileId != null) localVarQueryParams.Add(new Tuple<string, string>("performanceProfileId", this.Configuration.ApiClient.ParameterToString(performanceProfileId)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetric: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetric: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Metric>(localVarStatusCode,
                localVarHeaders,
                (Metric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Metric definition by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricDefinitionId">metric definition id</param>
        /// <returns>MetricDefinition</returns>
        public MetricDefinition GetGamificationMetricdefinition (string metricDefinitionId)
        {
             ApiResponse<MetricDefinition> localVarResponse = GetGamificationMetricdefinitionWithHttpInfo(metricDefinitionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Metric definition by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricDefinitionId">metric definition id</param>
        /// <returns>ApiResponse of MetricDefinition</returns>
        public ApiResponse< MetricDefinition > GetGamificationMetricdefinitionWithHttpInfo (string metricDefinitionId)
        { 
            // verify the required parameter 'metricDefinitionId' is set
            if (metricDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'metricDefinitionId' when calling GamificationApi->GetGamificationMetricdefinition");

            var localVarPath = "/api/v2/gamification/metricdefinitions/{metricDefinitionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (metricDefinitionId != null) localVarPathParams.Add("metricDefinitionId", this.Configuration.ApiClient.ParameterToString(metricDefinitionId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetricdefinition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetricdefinition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MetricDefinition>(localVarStatusCode,
                localVarHeaders,
                (MetricDefinition) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetricDefinition)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Metric definition by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricDefinitionId">metric definition id</param>
        /// <returns>Task of MetricDefinition</returns>
        public async System.Threading.Tasks.Task<MetricDefinition> GetGamificationMetricdefinitionAsync (string metricDefinitionId)
        {
             ApiResponse<MetricDefinition> localVarResponse = await GetGamificationMetricdefinitionAsyncWithHttpInfo(metricDefinitionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Metric definition by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricDefinitionId">metric definition id</param>
        /// <returns>Task of ApiResponse (MetricDefinition)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetricDefinition>> GetGamificationMetricdefinitionAsyncWithHttpInfo (string metricDefinitionId)
        { 
            // verify the required parameter 'metricDefinitionId' is set
            if (metricDefinitionId == null)
                throw new ApiException(400, "Missing required parameter 'metricDefinitionId' when calling GamificationApi->GetGamificationMetricdefinition");
            

            var localVarPath = "/api/v2/gamification/metricdefinitions/{metricDefinitionId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (metricDefinitionId != null) localVarPathParams.Add("metricDefinitionId", this.Configuration.ApiClient.ParameterToString(metricDefinitionId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetricdefinition: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetricdefinition: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MetricDefinition>(localVarStatusCode,
                localVarHeaders,
                (MetricDefinition) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetricDefinition)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// All metric definitions Retrieves the metric definitions and their corresponding default objectives used to create a gamified metric
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetMetricDefinitionsResponse</returns>
        public GetMetricDefinitionsResponse GetGamificationMetricdefinitions ()
        {
             ApiResponse<GetMetricDefinitionsResponse> localVarResponse = GetGamificationMetricdefinitionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// All metric definitions Retrieves the metric definitions and their corresponding default objectives used to create a gamified metric
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetMetricDefinitionsResponse</returns>
        public ApiResponse< GetMetricDefinitionsResponse > GetGamificationMetricdefinitionsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/gamification/metricdefinitions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetricdefinitions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetricdefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetMetricDefinitionsResponse>(localVarStatusCode,
                localVarHeaders,
                (GetMetricDefinitionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetMetricDefinitionsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// All metric definitions Retrieves the metric definitions and their corresponding default objectives used to create a gamified metric
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GetMetricDefinitionsResponse</returns>
        public async System.Threading.Tasks.Task<GetMetricDefinitionsResponse> GetGamificationMetricdefinitionsAsync ()
        {
             ApiResponse<GetMetricDefinitionsResponse> localVarResponse = await GetGamificationMetricdefinitionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// All metric definitions Retrieves the metric definitions and their corresponding default objectives used to create a gamified metric
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GetMetricDefinitionsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetMetricDefinitionsResponse>> GetGamificationMetricdefinitionsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/gamification/metricdefinitions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetricdefinitions: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetricdefinitions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetMetricDefinitionsResponse>(localVarStatusCode,
                localVarHeaders,
                (GetMetricDefinitionsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetMetricDefinitionsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// All gamified metrics for a given profile This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>GetMetricsResponse</returns>
        public GetMetricsResponse GetGamificationMetrics (string performanceProfileId = null, String workday = null)
        {
             ApiResponse<GetMetricsResponse> localVarResponse = GetGamificationMetricsWithHttpInfo(performanceProfileId, workday);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All gamified metrics for a given profile This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>ApiResponse of GetMetricsResponse</returns>
        public ApiResponse< GetMetricsResponse > GetGamificationMetricsWithHttpInfo (string performanceProfileId = null, String workday = null)
        { 

            var localVarPath = "/api/v2/gamification/metrics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (performanceProfileId != null) localVarQueryParams.Add(new Tuple<string, string>("performanceProfileId", this.Configuration.ApiClient.ParameterToString(performanceProfileId)));
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetrics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetrics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetMetricsResponse>(localVarStatusCode,
                localVarHeaders,
                (GetMetricsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetMetricsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// All gamified metrics for a given profile This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of GetMetricsResponse</returns>
        public async System.Threading.Tasks.Task<GetMetricsResponse> GetGamificationMetricsAsync (string performanceProfileId = null, String workday = null)
        {
             ApiResponse<GetMetricsResponse> localVarResponse = await GetGamificationMetricsAsyncWithHttpInfo(performanceProfileId, workday);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All gamified metrics for a given profile This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (GetMetricsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetMetricsResponse>> GetGamificationMetricsAsyncWithHttpInfo (string performanceProfileId = null, String workday = null)
        { 

            var localVarPath = "/api/v2/gamification/metrics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (performanceProfileId != null) localVarQueryParams.Add(new Tuple<string, string>("performanceProfileId", this.Configuration.ApiClient.ParameterToString(performanceProfileId)));
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetrics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationMetrics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetMetricsResponse>(localVarStatusCode,
                localVarHeaders,
                (GetMetricsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetMetricsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Performance profile by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>PerformanceProfile</returns>
        public PerformanceProfile GetGamificationProfile (string profileId)
        {
             ApiResponse<PerformanceProfile> localVarResponse = GetGamificationProfileWithHttpInfo(profileId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performance profile by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>ApiResponse of PerformanceProfile</returns>
        public ApiResponse< PerformanceProfile > GetGamificationProfileWithHttpInfo (string profileId)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationProfile");

            var localVarPath = "/api/v2/gamification/profiles/{profileId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfile: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerformanceProfile>(localVarStatusCode,
                localVarHeaders,
                (PerformanceProfile) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceProfile)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Performance profile by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>Task of PerformanceProfile</returns>
        public async System.Threading.Tasks.Task<PerformanceProfile> GetGamificationProfileAsync (string profileId)
        {
             ApiResponse<PerformanceProfile> localVarResponse = await GetGamificationProfileAsyncWithHttpInfo(profileId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performance profile by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>Task of ApiResponse (PerformanceProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PerformanceProfile>> GetGamificationProfileAsyncWithHttpInfo (string profileId)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationProfile");
            

            var localVarPath = "/api/v2/gamification/profiles/{profileId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfile: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerformanceProfile>(localVarStatusCode,
                localVarHeaders,
                (PerformanceProfile) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceProfile)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Members of a given performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <returns>MemberListing</returns>
        public MemberListing GetGamificationProfileMembers (string profileId)
        {
             ApiResponse<MemberListing> localVarResponse = GetGamificationProfileMembersWithHttpInfo(profileId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Members of a given performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <returns>ApiResponse of MemberListing</returns>
        public ApiResponse< MemberListing > GetGamificationProfileMembersWithHttpInfo (string profileId)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationProfileMembers");

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/members";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMembers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MemberListing>(localVarStatusCode,
                localVarHeaders,
                (MemberListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MemberListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Members of a given performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <returns>Task of MemberListing</returns>
        public async System.Threading.Tasks.Task<MemberListing> GetGamificationProfileMembersAsync (string profileId)
        {
             ApiResponse<MemberListing> localVarResponse = await GetGamificationProfileMembersAsyncWithHttpInfo(profileId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Members of a given performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <returns>Task of ApiResponse (MemberListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MemberListing>> GetGamificationProfileMembersAsyncWithHttpInfo (string profileId)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationProfileMembers");
            

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/members";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMembers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MemberListing>(localVarStatusCode,
                localVarHeaders,
                (MemberListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MemberListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Performance profile gamified metric by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Metric</returns>
        public Metric GetGamificationProfileMetric (string profileId, string metricId, String workday = null)
        {
             ApiResponse<Metric> localVarResponse = GetGamificationProfileMetricWithHttpInfo(profileId, metricId, workday);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performance profile gamified metric by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>ApiResponse of Metric</returns>
        public ApiResponse< Metric > GetGamificationProfileMetricWithHttpInfo (string profileId, string metricId, String workday = null)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationProfileMetric");
            // verify the required parameter 'metricId' is set
            if (metricId == null)
                throw new ApiException(400, "Missing required parameter 'metricId' when calling GamificationApi->GetGamificationProfileMetric");

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/metrics/{metricId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));
            if (metricId != null) localVarPathParams.Add("metricId", this.Configuration.ApiClient.ParameterToString(metricId));

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMetric: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMetric: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Metric>(localVarStatusCode,
                localVarHeaders,
                (Metric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Performance profile gamified metric by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of Metric</returns>
        public async System.Threading.Tasks.Task<Metric> GetGamificationProfileMetricAsync (string profileId, string metricId, String workday = null)
        {
             ApiResponse<Metric> localVarResponse = await GetGamificationProfileMetricAsyncWithHttpInfo(profileId, metricId, workday);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performance profile gamified metric by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (Metric)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Metric>> GetGamificationProfileMetricAsyncWithHttpInfo (string profileId, string metricId, String workday = null)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationProfileMetric");
            
            // verify the required parameter 'metricId' is set
            if (metricId == null)
                throw new ApiException(400, "Missing required parameter 'metricId' when calling GamificationApi->GetGamificationProfileMetric");
            

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/metrics/{metricId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));
            if (metricId != null) localVarPathParams.Add("metricId", this.Configuration.ApiClient.ParameterToString(metricId));

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMetric: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMetric: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Metric>(localVarStatusCode,
                localVarHeaders,
                (Metric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// All gamified metrics for a given performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="metricIds">List of metric ids to filter the response (Optional, comma-separated). (optional)</param>
        /// <returns>GetMetricResponse</returns>
        public GetMetricResponse GetGamificationProfileMetrics (string profileId, List<string> expand = null, String workday = null, string metricIds = null)
        {
             ApiResponse<GetMetricResponse> localVarResponse = GetGamificationProfileMetricsWithHttpInfo(profileId, expand, workday, metricIds);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All gamified metrics for a given performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="metricIds">List of metric ids to filter the response (Optional, comma-separated). (optional)</param>
        /// <returns>ApiResponse of GetMetricResponse</returns>
        public ApiResponse< GetMetricResponse > GetGamificationProfileMetricsWithHttpInfo (string profileId, List<string> expand = null, String workday = null, string metricIds = null)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationProfileMetrics");

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/metrics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));
            if (metricIds != null) localVarQueryParams.Add(new Tuple<string, string>("metricIds", this.Configuration.ApiClient.ParameterToString(metricIds)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMetrics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMetrics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetMetricResponse>(localVarStatusCode,
                localVarHeaders,
                (GetMetricResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetMetricResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// All gamified metrics for a given performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="metricIds">List of metric ids to filter the response (Optional, comma-separated). (optional)</param>
        /// <returns>Task of GetMetricResponse</returns>
        public async System.Threading.Tasks.Task<GetMetricResponse> GetGamificationProfileMetricsAsync (string profileId, List<string> expand = null, String workday = null, string metricIds = null)
        {
             ApiResponse<GetMetricResponse> localVarResponse = await GetGamificationProfileMetricsAsyncWithHttpInfo(profileId, expand, workday, metricIds);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All gamified metrics for a given performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="metricIds">List of metric ids to filter the response (Optional, comma-separated). (optional)</param>
        /// <returns>Task of ApiResponse (GetMetricResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetMetricResponse>> GetGamificationProfileMetricsAsyncWithHttpInfo (string profileId, List<string> expand = null, String workday = null, string metricIds = null)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationProfileMetrics");
            

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/metrics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));
            if (metricIds != null) localVarQueryParams.Add(new Tuple<string, string>("metricIds", this.Configuration.ApiClient.ParameterToString(metricIds)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMetrics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMetrics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetMetricResponse>(localVarStatusCode,
                localVarHeaders,
                (GetMetricResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetMetricResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// All metrics for a given performance profile with objective details such as order and maxPoints 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>GetMetricsResponse</returns>
        public GetMetricsResponse GetGamificationProfileMetricsObjectivedetails (string profileId, String workday = null)
        {
             ApiResponse<GetMetricsResponse> localVarResponse = GetGamificationProfileMetricsObjectivedetailsWithHttpInfo(profileId, workday);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All metrics for a given performance profile with objective details such as order and maxPoints 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>ApiResponse of GetMetricsResponse</returns>
        public ApiResponse< GetMetricsResponse > GetGamificationProfileMetricsObjectivedetailsWithHttpInfo (string profileId, String workday = null)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationProfileMetricsObjectivedetails");

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/metrics/objectivedetails";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMetricsObjectivedetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMetricsObjectivedetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetMetricsResponse>(localVarStatusCode,
                localVarHeaders,
                (GetMetricsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetMetricsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// All metrics for a given performance profile with objective details such as order and maxPoints 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of GetMetricsResponse</returns>
        public async System.Threading.Tasks.Task<GetMetricsResponse> GetGamificationProfileMetricsObjectivedetailsAsync (string profileId, String workday = null)
        {
             ApiResponse<GetMetricsResponse> localVarResponse = await GetGamificationProfileMetricsObjectivedetailsAsyncWithHttpInfo(profileId, workday);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All metrics for a given performance profile with objective details such as order and maxPoints 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="workday">The objective query workday. If not specified, then it retrieves the current objective. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (GetMetricsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetMetricsResponse>> GetGamificationProfileMetricsObjectivedetailsAsyncWithHttpInfo (string profileId, String workday = null)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationProfileMetricsObjectivedetails");
            

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/metrics/objectivedetails";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMetricsObjectivedetails: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfileMetricsObjectivedetails: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetMetricsResponse>(localVarStatusCode,
                localVarHeaders,
                (GetMetricsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetMetricsResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// All performance profiles 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetProfilesResponse</returns>
        public GetProfilesResponse GetGamificationProfiles ()
        {
             ApiResponse<GetProfilesResponse> localVarResponse = GetGamificationProfilesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// All performance profiles 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetProfilesResponse</returns>
        public ApiResponse< GetProfilesResponse > GetGamificationProfilesWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/gamification/profiles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfiles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfiles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetProfilesResponse>(localVarStatusCode,
                localVarHeaders,
                (GetProfilesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetProfilesResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// All performance profiles 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GetProfilesResponse</returns>
        public async System.Threading.Tasks.Task<GetProfilesResponse> GetGamificationProfilesAsync ()
        {
             ApiResponse<GetProfilesResponse> localVarResponse = await GetGamificationProfilesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// All performance profiles 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GetProfilesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetProfilesResponse>> GetGamificationProfilesAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/gamification/profiles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfiles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfiles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetProfilesResponse>(localVarStatusCode,
                localVarHeaders,
                (GetProfilesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetProfilesResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Performance profile of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>PerformanceProfile</returns>
        public PerformanceProfile GetGamificationProfilesUser (string userId, String workday = null)
        {
             ApiResponse<PerformanceProfile> localVarResponse = GetGamificationProfilesUserWithHttpInfo(userId, workday);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performance profile of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>ApiResponse of PerformanceProfile</returns>
        public ApiResponse< PerformanceProfile > GetGamificationProfilesUserWithHttpInfo (string userId, String workday = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationProfilesUser");

            var localVarPath = "/api/v2/gamification/profiles/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfilesUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfilesUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerformanceProfile>(localVarStatusCode,
                localVarHeaders,
                (PerformanceProfile) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceProfile)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Performance profile of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of PerformanceProfile</returns>
        public async System.Threading.Tasks.Task<PerformanceProfile> GetGamificationProfilesUserAsync (string userId, String workday = null)
        {
             ApiResponse<PerformanceProfile> localVarResponse = await GetGamificationProfilesUserAsyncWithHttpInfo(userId, workday);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performance profile of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (PerformanceProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PerformanceProfile>> GetGamificationProfilesUserAsyncWithHttpInfo (string userId, String workday = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationProfilesUser");
            

            var localVarPath = "/api/v2/gamification/profiles/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfilesUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfilesUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerformanceProfile>(localVarStatusCode,
                localVarHeaders,
                (PerformanceProfile) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceProfile)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Performance profile of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>PerformanceProfile</returns>
        public PerformanceProfile GetGamificationProfilesUsersMe (String workday = null)
        {
             ApiResponse<PerformanceProfile> localVarResponse = GetGamificationProfilesUsersMeWithHttpInfo(workday);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performance profile of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>ApiResponse of PerformanceProfile</returns>
        public ApiResponse< PerformanceProfile > GetGamificationProfilesUsersMeWithHttpInfo (String workday = null)
        { 

            var localVarPath = "/api/v2/gamification/profiles/users/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfilesUsersMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfilesUsersMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerformanceProfile>(localVarStatusCode,
                localVarHeaders,
                (PerformanceProfile) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceProfile)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Performance profile of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of PerformanceProfile</returns>
        public async System.Threading.Tasks.Task<PerformanceProfile> GetGamificationProfilesUsersMeAsync (String workday = null)
        {
             ApiResponse<PerformanceProfile> localVarResponse = await GetGamificationProfilesUsersMeAsyncWithHttpInfo(workday);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performance profile of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. If not provided, then queries the current performance profile. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (PerformanceProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PerformanceProfile>> GetGamificationProfilesUsersMeAsyncWithHttpInfo (String workday = null)
        { 

            var localVarPath = "/api/v2/gamification/profiles/users/me";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfilesUsersMe: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationProfilesUsersMe: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerformanceProfile>(localVarStatusCode,
                localVarHeaders,
                (PerformanceProfile) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceProfile)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Workday performance metrics of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>WorkdayMetricListing</returns>
        public WorkdayMetricListing GetGamificationScorecards (String workday, List<string> expand = null)
        {
             ApiResponse<WorkdayMetricListing> localVarResponse = GetGamificationScorecardsWithHttpInfo(workday, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Workday performance metrics of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of WorkdayMetricListing</returns>
        public ApiResponse< WorkdayMetricListing > GetGamificationScorecardsWithHttpInfo (String workday, List<string> expand = null)
        { 
            // verify the required parameter 'workday' is set
            if (workday == null)
                throw new ApiException(400, "Missing required parameter 'workday' when calling GamificationApi->GetGamificationScorecards");

            var localVarPath = "/api/v2/gamification/scorecards";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecards: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecards: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkdayMetricListing>(localVarStatusCode,
                localVarHeaders,
                (WorkdayMetricListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkdayMetricListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Workday performance metrics of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of WorkdayMetricListing</returns>
        public async System.Threading.Tasks.Task<WorkdayMetricListing> GetGamificationScorecardsAsync (String workday, List<string> expand = null)
        {
             ApiResponse<WorkdayMetricListing> localVarResponse = await GetGamificationScorecardsAsyncWithHttpInfo(workday, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Workday performance metrics of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (WorkdayMetricListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkdayMetricListing>> GetGamificationScorecardsAsyncWithHttpInfo (String workday, List<string> expand = null)
        { 
            // verify the required parameter 'workday' is set
            if (workday == null)
                throw new ApiException(400, "Missing required parameter 'workday' when calling GamificationApi->GetGamificationScorecards");
            

            var localVarPath = "/api/v2/gamification/scorecards";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecards: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecards: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkdayMetricListing>(localVarStatusCode,
                localVarHeaders,
                (WorkdayMetricListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkdayMetricListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Attendance status metrics of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>AttendanceStatusListing</returns>
        public AttendanceStatusListing GetGamificationScorecardsAttendance (String startWorkday, String endWorkday)
        {
             ApiResponse<AttendanceStatusListing> localVarResponse = GetGamificationScorecardsAttendanceWithHttpInfo(startWorkday, endWorkday);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Attendance status metrics of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>ApiResponse of AttendanceStatusListing</returns>
        public ApiResponse< AttendanceStatusListing > GetGamificationScorecardsAttendanceWithHttpInfo (String startWorkday, String endWorkday)
        { 
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsAttendance");
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsAttendance");

            var localVarPath = "/api/v2/gamification/scorecards/attendance";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsAttendance: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsAttendance: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttendanceStatusListing>(localVarStatusCode,
                localVarHeaders,
                (AttendanceStatusListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttendanceStatusListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Attendance status metrics of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of AttendanceStatusListing</returns>
        public async System.Threading.Tasks.Task<AttendanceStatusListing> GetGamificationScorecardsAttendanceAsync (String startWorkday, String endWorkday)
        {
             ApiResponse<AttendanceStatusListing> localVarResponse = await GetGamificationScorecardsAttendanceAsyncWithHttpInfo(startWorkday, endWorkday);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Attendance status metrics of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of ApiResponse (AttendanceStatusListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttendanceStatusListing>> GetGamificationScorecardsAttendanceAsyncWithHttpInfo (String startWorkday, String endWorkday)
        { 
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsAttendance");
            
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsAttendance");
            

            var localVarPath = "/api/v2/gamification/scorecards/attendance";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsAttendance: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsAttendance: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttendanceStatusListing>(localVarStatusCode,
                localVarHeaders,
                (AttendanceStatusListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttendanceStatusListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Best points of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserBestPoints</returns>
        public UserBestPoints GetGamificationScorecardsBestpoints ()
        {
             ApiResponse<UserBestPoints> localVarResponse = GetGamificationScorecardsBestpointsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Best points of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserBestPoints</returns>
        public ApiResponse< UserBestPoints > GetGamificationScorecardsBestpointsWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/gamification/scorecards/bestpoints";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsBestpoints: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsBestpoints: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserBestPoints>(localVarStatusCode,
                localVarHeaders,
                (UserBestPoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserBestPoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Best points of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UserBestPoints</returns>
        public async System.Threading.Tasks.Task<UserBestPoints> GetGamificationScorecardsBestpointsAsync ()
        {
             ApiResponse<UserBestPoints> localVarResponse = await GetGamificationScorecardsBestpointsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Best points of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UserBestPoints)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserBestPoints>> GetGamificationScorecardsBestpointsAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/gamification/scorecards/bestpoints";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsBestpoints: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsBestpoints: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserBestPoints>(localVarStatusCode,
                localVarHeaders,
                (UserBestPoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserBestPoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// All-time points of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>AllTimePoints</returns>
        public AllTimePoints GetGamificationScorecardsPointsAlltime (String endWorkday)
        {
             ApiResponse<AllTimePoints> localVarResponse = GetGamificationScorecardsPointsAlltimeWithHttpInfo(endWorkday);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All-time points of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>ApiResponse of AllTimePoints</returns>
        public ApiResponse< AllTimePoints > GetGamificationScorecardsPointsAlltimeWithHttpInfo (String endWorkday)
        { 
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsPointsAlltime");

            var localVarPath = "/api/v2/gamification/scorecards/points/alltime";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsPointsAlltime: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsPointsAlltime: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AllTimePoints>(localVarStatusCode,
                localVarHeaders,
                (AllTimePoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AllTimePoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// All-time points of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of AllTimePoints</returns>
        public async System.Threading.Tasks.Task<AllTimePoints> GetGamificationScorecardsPointsAlltimeAsync (String endWorkday)
        {
             ApiResponse<AllTimePoints> localVarResponse = await GetGamificationScorecardsPointsAlltimeAsyncWithHttpInfo(endWorkday);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All-time points of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of ApiResponse (AllTimePoints)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AllTimePoints>> GetGamificationScorecardsPointsAlltimeAsyncWithHttpInfo (String endWorkday)
        { 
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsPointsAlltime");
            

            var localVarPath = "/api/v2/gamification/scorecards/points/alltime";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsPointsAlltime: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsPointsAlltime: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AllTimePoints>(localVarStatusCode,
                localVarHeaders,
                (AllTimePoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AllTimePoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Average points of the requesting user's division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>SingleWorkdayAveragePoints</returns>
        public SingleWorkdayAveragePoints GetGamificationScorecardsPointsAverage (String workday)
        {
             ApiResponse<SingleWorkdayAveragePoints> localVarResponse = GetGamificationScorecardsPointsAverageWithHttpInfo(workday);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Average points of the requesting user's division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>ApiResponse of SingleWorkdayAveragePoints</returns>
        public ApiResponse< SingleWorkdayAveragePoints > GetGamificationScorecardsPointsAverageWithHttpInfo (String workday)
        { 
            // verify the required parameter 'workday' is set
            if (workday == null)
                throw new ApiException(400, "Missing required parameter 'workday' when calling GamificationApi->GetGamificationScorecardsPointsAverage");

            var localVarPath = "/api/v2/gamification/scorecards/points/average";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsPointsAverage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsPointsAverage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SingleWorkdayAveragePoints>(localVarStatusCode,
                localVarHeaders,
                (SingleWorkdayAveragePoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SingleWorkdayAveragePoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Average points of the requesting user's division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of SingleWorkdayAveragePoints</returns>
        public async System.Threading.Tasks.Task<SingleWorkdayAveragePoints> GetGamificationScorecardsPointsAverageAsync (String workday)
        {
             ApiResponse<SingleWorkdayAveragePoints> localVarResponse = await GetGamificationScorecardsPointsAverageAsyncWithHttpInfo(workday);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Average points of the requesting user's division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of ApiResponse (SingleWorkdayAveragePoints)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SingleWorkdayAveragePoints>> GetGamificationScorecardsPointsAverageAsyncWithHttpInfo (String workday)
        { 
            // verify the required parameter 'workday' is set
            if (workday == null)
                throw new ApiException(400, "Missing required parameter 'workday' when calling GamificationApi->GetGamificationScorecardsPointsAverage");
            

            var localVarPath = "/api/v2/gamification/scorecards/points/average";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsPointsAverage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsPointsAverage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SingleWorkdayAveragePoints>(localVarStatusCode,
                localVarHeaders,
                (SingleWorkdayAveragePoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SingleWorkdayAveragePoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Points trends of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>WorkdayPointsTrend</returns>
        public WorkdayPointsTrend GetGamificationScorecardsPointsTrends (String startWorkday, String endWorkday, string dayOfWeek = null)
        {
             ApiResponse<WorkdayPointsTrend> localVarResponse = GetGamificationScorecardsPointsTrendsWithHttpInfo(startWorkday, endWorkday, dayOfWeek);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Points trends of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>ApiResponse of WorkdayPointsTrend</returns>
        public ApiResponse< WorkdayPointsTrend > GetGamificationScorecardsPointsTrendsWithHttpInfo (String startWorkday, String endWorkday, string dayOfWeek = null)
        { 
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsPointsTrends");
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsPointsTrends");

            var localVarPath = "/api/v2/gamification/scorecards/points/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (dayOfWeek != null) localVarQueryParams.Add(new Tuple<string, string>("dayOfWeek", this.Configuration.ApiClient.ParameterToString(dayOfWeek)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsPointsTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsPointsTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkdayPointsTrend>(localVarStatusCode,
                localVarHeaders,
                (WorkdayPointsTrend) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkdayPointsTrend)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Points trends of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>Task of WorkdayPointsTrend</returns>
        public async System.Threading.Tasks.Task<WorkdayPointsTrend> GetGamificationScorecardsPointsTrendsAsync (String startWorkday, String endWorkday, string dayOfWeek = null)
        {
             ApiResponse<WorkdayPointsTrend> localVarResponse = await GetGamificationScorecardsPointsTrendsAsyncWithHttpInfo(startWorkday, endWorkday, dayOfWeek);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Points trends of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>Task of ApiResponse (WorkdayPointsTrend)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkdayPointsTrend>> GetGamificationScorecardsPointsTrendsAsyncWithHttpInfo (String startWorkday, String endWorkday, string dayOfWeek = null)
        { 
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsPointsTrends");
            
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsPointsTrends");
            

            var localVarPath = "/api/v2/gamification/scorecards/points/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (dayOfWeek != null) localVarQueryParams.Add(new Tuple<string, string>("dayOfWeek", this.Configuration.ApiClient.ParameterToString(dayOfWeek)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsPointsTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsPointsTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkdayPointsTrend>(localVarStatusCode,
                localVarHeaders,
                (WorkdayPointsTrend) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkdayPointsTrend)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Average performance values trends by metric of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>MetricValueTrendAverage</returns>
        public MetricValueTrendAverage GetGamificationScorecardsProfileMetricUserValuesTrends (string profileId, string metricId, string userId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null)
        {
             ApiResponse<MetricValueTrendAverage> localVarResponse = GetGamificationScorecardsProfileMetricUserValuesTrendsWithHttpInfo(profileId, metricId, userId, startWorkday, endWorkday, referenceWorkday, timeZone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Average performance values trends by metric of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of MetricValueTrendAverage</returns>
        public ApiResponse< MetricValueTrendAverage > GetGamificationScorecardsProfileMetricUserValuesTrendsWithHttpInfo (string profileId, string metricId, string userId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationScorecardsProfileMetricUserValuesTrends");
            // verify the required parameter 'metricId' is set
            if (metricId == null)
                throw new ApiException(400, "Missing required parameter 'metricId' when calling GamificationApi->GetGamificationScorecardsProfileMetricUserValuesTrends");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationScorecardsProfileMetricUserValuesTrends");
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsProfileMetricUserValuesTrends");
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsProfileMetricUserValuesTrends");

            var localVarPath = "/api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/users/{userId}/values/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));
            if (metricId != null) localVarPathParams.Add("metricId", this.Configuration.ApiClient.ParameterToString(metricId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (referenceWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("referenceWorkday", this.Configuration.ApiClient.ParameterToString(referenceWorkday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsProfileMetricUserValuesTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsProfileMetricUserValuesTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MetricValueTrendAverage>(localVarStatusCode,
                localVarHeaders,
                (MetricValueTrendAverage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetricValueTrendAverage)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Average performance values trends by metric of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of MetricValueTrendAverage</returns>
        public async System.Threading.Tasks.Task<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricUserValuesTrendsAsync (string profileId, string metricId, string userId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null)
        {
             ApiResponse<MetricValueTrendAverage> localVarResponse = await GetGamificationScorecardsProfileMetricUserValuesTrendsAsyncWithHttpInfo(profileId, metricId, userId, startWorkday, endWorkday, referenceWorkday, timeZone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Average performance values trends by metric of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (MetricValueTrendAverage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetricValueTrendAverage>> GetGamificationScorecardsProfileMetricUserValuesTrendsAsyncWithHttpInfo (string profileId, string metricId, string userId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationScorecardsProfileMetricUserValuesTrends");
            
            // verify the required parameter 'metricId' is set
            if (metricId == null)
                throw new ApiException(400, "Missing required parameter 'metricId' when calling GamificationApi->GetGamificationScorecardsProfileMetricUserValuesTrends");
            
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationScorecardsProfileMetricUserValuesTrends");
            
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsProfileMetricUserValuesTrends");
            
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsProfileMetricUserValuesTrends");
            

            var localVarPath = "/api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/users/{userId}/values/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));
            if (metricId != null) localVarPathParams.Add("metricId", this.Configuration.ApiClient.ParameterToString(metricId));
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (referenceWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("referenceWorkday", this.Configuration.ApiClient.ParameterToString(referenceWorkday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsProfileMetricUserValuesTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsProfileMetricUserValuesTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MetricValueTrendAverage>(localVarStatusCode,
                localVarHeaders,
                (MetricValueTrendAverage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetricValueTrendAverage)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Average performance values trends by metric of a division or a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>MetricValueTrendAverage</returns>
        public MetricValueTrendAverage GetGamificationScorecardsProfileMetricUsersValuesTrends (string profileId, string metricId, string filterType, string filterId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null)
        {
             ApiResponse<MetricValueTrendAverage> localVarResponse = GetGamificationScorecardsProfileMetricUsersValuesTrendsWithHttpInfo(profileId, metricId, filterType, filterId, startWorkday, endWorkday, referenceWorkday, timeZone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Average performance values trends by metric of a division or a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of MetricValueTrendAverage</returns>
        public ApiResponse< MetricValueTrendAverage > GetGamificationScorecardsProfileMetricUsersValuesTrendsWithHttpInfo (string profileId, string metricId, string filterType, string filterId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationScorecardsProfileMetricUsersValuesTrends");
            // verify the required parameter 'metricId' is set
            if (metricId == null)
                throw new ApiException(400, "Missing required parameter 'metricId' when calling GamificationApi->GetGamificationScorecardsProfileMetricUsersValuesTrends");
            // verify the required parameter 'filterType' is set
            if (filterType == null)
                throw new ApiException(400, "Missing required parameter 'filterType' when calling GamificationApi->GetGamificationScorecardsProfileMetricUsersValuesTrends");
            // verify the required parameter 'filterId' is set
            if (filterId == null)
                throw new ApiException(400, "Missing required parameter 'filterId' when calling GamificationApi->GetGamificationScorecardsProfileMetricUsersValuesTrends");
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsProfileMetricUsersValuesTrends");
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsProfileMetricUsersValuesTrends");

            var localVarPath = "/api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/users/values/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));
            if (metricId != null) localVarPathParams.Add("metricId", this.Configuration.ApiClient.ParameterToString(metricId));

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (filterId != null) localVarQueryParams.Add(new Tuple<string, string>("filterId", this.Configuration.ApiClient.ParameterToString(filterId)));
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (referenceWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("referenceWorkday", this.Configuration.ApiClient.ParameterToString(referenceWorkday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsProfileMetricUsersValuesTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsProfileMetricUsersValuesTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MetricValueTrendAverage>(localVarStatusCode,
                localVarHeaders,
                (MetricValueTrendAverage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetricValueTrendAverage)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Average performance values trends by metric of a division or a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of MetricValueTrendAverage</returns>
        public async System.Threading.Tasks.Task<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricUsersValuesTrendsAsync (string profileId, string metricId, string filterType, string filterId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null)
        {
             ApiResponse<MetricValueTrendAverage> localVarResponse = await GetGamificationScorecardsProfileMetricUsersValuesTrendsAsyncWithHttpInfo(profileId, metricId, filterType, filterId, startWorkday, endWorkday, referenceWorkday, timeZone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Average performance values trends by metric of a division or a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (MetricValueTrendAverage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetricValueTrendAverage>> GetGamificationScorecardsProfileMetricUsersValuesTrendsAsyncWithHttpInfo (string profileId, string metricId, string filterType, string filterId, String startWorkday, String endWorkday, String referenceWorkday = null, string timeZone = null)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationScorecardsProfileMetricUsersValuesTrends");
            
            // verify the required parameter 'metricId' is set
            if (metricId == null)
                throw new ApiException(400, "Missing required parameter 'metricId' when calling GamificationApi->GetGamificationScorecardsProfileMetricUsersValuesTrends");
            
            // verify the required parameter 'filterType' is set
            if (filterType == null)
                throw new ApiException(400, "Missing required parameter 'filterType' when calling GamificationApi->GetGamificationScorecardsProfileMetricUsersValuesTrends");
            
            // verify the required parameter 'filterId' is set
            if (filterId == null)
                throw new ApiException(400, "Missing required parameter 'filterId' when calling GamificationApi->GetGamificationScorecardsProfileMetricUsersValuesTrends");
            
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsProfileMetricUsersValuesTrends");
            
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsProfileMetricUsersValuesTrends");
            

            var localVarPath = "/api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/users/values/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));
            if (metricId != null) localVarPathParams.Add("metricId", this.Configuration.ApiClient.ParameterToString(metricId));

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (filterId != null) localVarQueryParams.Add(new Tuple<string, string>("filterId", this.Configuration.ApiClient.ParameterToString(filterId)));
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (referenceWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("referenceWorkday", this.Configuration.ApiClient.ParameterToString(referenceWorkday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsProfileMetricUsersValuesTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsProfileMetricUsersValuesTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MetricValueTrendAverage>(localVarStatusCode,
                localVarHeaders,
                (MetricValueTrendAverage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetricValueTrendAverage)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Average performance values trends by metric of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, returns the values trends of the requesting user (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>MetricValueTrendAverage</returns>
        public MetricValueTrendAverage GetGamificationScorecardsProfileMetricValuesTrends (string profileId, string metricId, String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null)
        {
             ApiResponse<MetricValueTrendAverage> localVarResponse = GetGamificationScorecardsProfileMetricValuesTrendsWithHttpInfo(profileId, metricId, startWorkday, endWorkday, filterType, referenceWorkday, timeZone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Average performance values trends by metric of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, returns the values trends of the requesting user (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of MetricValueTrendAverage</returns>
        public ApiResponse< MetricValueTrendAverage > GetGamificationScorecardsProfileMetricValuesTrendsWithHttpInfo (string profileId, string metricId, String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationScorecardsProfileMetricValuesTrends");
            // verify the required parameter 'metricId' is set
            if (metricId == null)
                throw new ApiException(400, "Missing required parameter 'metricId' when calling GamificationApi->GetGamificationScorecardsProfileMetricValuesTrends");
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsProfileMetricValuesTrends");
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsProfileMetricValuesTrends");

            var localVarPath = "/api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/values/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));
            if (metricId != null) localVarPathParams.Add("metricId", this.Configuration.ApiClient.ParameterToString(metricId));

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (referenceWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("referenceWorkday", this.Configuration.ApiClient.ParameterToString(referenceWorkday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsProfileMetricValuesTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsProfileMetricValuesTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MetricValueTrendAverage>(localVarStatusCode,
                localVarHeaders,
                (MetricValueTrendAverage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetricValueTrendAverage)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Average performance values trends by metric of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, returns the values trends of the requesting user (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of MetricValueTrendAverage</returns>
        public async System.Threading.Tasks.Task<MetricValueTrendAverage> GetGamificationScorecardsProfileMetricValuesTrendsAsync (string profileId, string metricId, String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null)
        {
             ApiResponse<MetricValueTrendAverage> localVarResponse = await GetGamificationScorecardsProfileMetricValuesTrendsAsyncWithHttpInfo(profileId, metricId, startWorkday, endWorkday, filterType, referenceWorkday, timeZone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Average performance values trends by metric of the requesting user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="metricId">metricId</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, returns the values trends of the requesting user (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the associated metric definition. If not set, then the value of endWorkday is used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (MetricValueTrendAverage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetricValueTrendAverage>> GetGamificationScorecardsProfileMetricValuesTrendsAsyncWithHttpInfo (string profileId, string metricId, String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->GetGamificationScorecardsProfileMetricValuesTrends");
            
            // verify the required parameter 'metricId' is set
            if (metricId == null)
                throw new ApiException(400, "Missing required parameter 'metricId' when calling GamificationApi->GetGamificationScorecardsProfileMetricValuesTrends");
            
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsProfileMetricValuesTrends");
            
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsProfileMetricValuesTrends");
            

            var localVarPath = "/api/v2/gamification/scorecards/profiles/{profileId}/metrics/{metricId}/values/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));
            if (metricId != null) localVarPathParams.Add("metricId", this.Configuration.ApiClient.ParameterToString(metricId));

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (referenceWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("referenceWorkday", this.Configuration.ApiClient.ParameterToString(referenceWorkday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsProfileMetricValuesTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsProfileMetricValuesTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MetricValueTrendAverage>(localVarStatusCode,
                localVarHeaders,
                (MetricValueTrendAverage) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetricValueTrendAverage)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Workday performance metrics for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>WorkdayMetricListing</returns>
        public WorkdayMetricListing GetGamificationScorecardsUser (string userId, String workday, List<string> expand = null)
        {
             ApiResponse<WorkdayMetricListing> localVarResponse = GetGamificationScorecardsUserWithHttpInfo(userId, workday, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Workday performance metrics for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>ApiResponse of WorkdayMetricListing</returns>
        public ApiResponse< WorkdayMetricListing > GetGamificationScorecardsUserWithHttpInfo (string userId, String workday, List<string> expand = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationScorecardsUser");
            // verify the required parameter 'workday' is set
            if (workday == null)
                throw new ApiException(400, "Missing required parameter 'workday' when calling GamificationApi->GetGamificationScorecardsUser");

            var localVarPath = "/api/v2/gamification/scorecards/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkdayMetricListing>(localVarStatusCode,
                localVarHeaders,
                (WorkdayMetricListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkdayMetricListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Workday performance metrics for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of WorkdayMetricListing</returns>
        public async System.Threading.Tasks.Task<WorkdayMetricListing> GetGamificationScorecardsUserAsync (string userId, String workday, List<string> expand = null)
        {
             ApiResponse<WorkdayMetricListing> localVarResponse = await GetGamificationScorecardsUserAsyncWithHttpInfo(userId, workday, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Workday performance metrics for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="workday">Target querying workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="expand">Which fields, if any, to expand. (optional)</param>
        /// <returns>Task of ApiResponse (WorkdayMetricListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkdayMetricListing>> GetGamificationScorecardsUserAsyncWithHttpInfo (string userId, String workday, List<string> expand = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationScorecardsUser");
            
            // verify the required parameter 'workday' is set
            if (workday == null)
                throw new ApiException(400, "Missing required parameter 'workday' when calling GamificationApi->GetGamificationScorecardsUser");
            

            var localVarPath = "/api/v2/gamification/scorecards/users/{userId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));
            if (expand != null) expand.ForEach(obj => { localVarQueryParams.Add(new Tuple<string, string>("expand", this.Configuration.ApiClient.ParameterToString(obj))); });

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkdayMetricListing>(localVarStatusCode,
                localVarHeaders,
                (WorkdayMetricListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkdayMetricListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Attendance status metrics for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>AttendanceStatusListing</returns>
        public AttendanceStatusListing GetGamificationScorecardsUserAttendance (string userId, String startWorkday, String endWorkday)
        {
             ApiResponse<AttendanceStatusListing> localVarResponse = GetGamificationScorecardsUserAttendanceWithHttpInfo(userId, startWorkday, endWorkday);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Attendance status metrics for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>ApiResponse of AttendanceStatusListing</returns>
        public ApiResponse< AttendanceStatusListing > GetGamificationScorecardsUserAttendanceWithHttpInfo (string userId, String startWorkday, String endWorkday)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationScorecardsUserAttendance");
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsUserAttendance");
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsUserAttendance");

            var localVarPath = "/api/v2/gamification/scorecards/users/{userId}/attendance";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserAttendance: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserAttendance: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttendanceStatusListing>(localVarStatusCode,
                localVarHeaders,
                (AttendanceStatusListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttendanceStatusListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Attendance status metrics for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of AttendanceStatusListing</returns>
        public async System.Threading.Tasks.Task<AttendanceStatusListing> GetGamificationScorecardsUserAttendanceAsync (string userId, String startWorkday, String endWorkday)
        {
             ApiResponse<AttendanceStatusListing> localVarResponse = await GetGamificationScorecardsUserAttendanceAsyncWithHttpInfo(userId, startWorkday, endWorkday);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Attendance status metrics for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of ApiResponse (AttendanceStatusListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttendanceStatusListing>> GetGamificationScorecardsUserAttendanceAsyncWithHttpInfo (string userId, String startWorkday, String endWorkday)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationScorecardsUserAttendance");
            
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsUserAttendance");
            
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsUserAttendance");
            

            var localVarPath = "/api/v2/gamification/scorecards/users/{userId}/attendance";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserAttendance: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserAttendance: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AttendanceStatusListing>(localVarStatusCode,
                localVarHeaders,
                (AttendanceStatusListing) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AttendanceStatusListing)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Best points of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>UserBestPoints</returns>
        public UserBestPoints GetGamificationScorecardsUserBestpoints (string userId)
        {
             ApiResponse<UserBestPoints> localVarResponse = GetGamificationScorecardsUserBestpointsWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Best points of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>ApiResponse of UserBestPoints</returns>
        public ApiResponse< UserBestPoints > GetGamificationScorecardsUserBestpointsWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationScorecardsUserBestpoints");

            var localVarPath = "/api/v2/gamification/scorecards/users/{userId}/bestpoints";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserBestpoints: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserBestpoints: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserBestPoints>(localVarStatusCode,
                localVarHeaders,
                (UserBestPoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserBestPoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Best points of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>Task of UserBestPoints</returns>
        public async System.Threading.Tasks.Task<UserBestPoints> GetGamificationScorecardsUserBestpointsAsync (string userId)
        {
             ApiResponse<UserBestPoints> localVarResponse = await GetGamificationScorecardsUserBestpointsAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Best points of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <returns>Task of ApiResponse (UserBestPoints)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserBestPoints>> GetGamificationScorecardsUserBestpointsAsyncWithHttpInfo (string userId)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationScorecardsUserBestpoints");
            

            var localVarPath = "/api/v2/gamification/scorecards/users/{userId}/bestpoints";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserBestpoints: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserBestpoints: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserBestPoints>(localVarStatusCode,
                localVarHeaders,
                (UserBestPoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserBestPoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// All-time points for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>AllTimePoints</returns>
        public AllTimePoints GetGamificationScorecardsUserPointsAlltime (string userId, String endWorkday)
        {
             ApiResponse<AllTimePoints> localVarResponse = GetGamificationScorecardsUserPointsAlltimeWithHttpInfo(userId, endWorkday);
             return localVarResponse.Data;
        }

        /// <summary>
        /// All-time points for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>ApiResponse of AllTimePoints</returns>
        public ApiResponse< AllTimePoints > GetGamificationScorecardsUserPointsAlltimeWithHttpInfo (string userId, String endWorkday)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationScorecardsUserPointsAlltime");
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsUserPointsAlltime");

            var localVarPath = "/api/v2/gamification/scorecards/users/{userId}/points/alltime";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserPointsAlltime: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserPointsAlltime: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AllTimePoints>(localVarStatusCode,
                localVarHeaders,
                (AllTimePoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AllTimePoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// All-time points for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of AllTimePoints</returns>
        public async System.Threading.Tasks.Task<AllTimePoints> GetGamificationScorecardsUserPointsAlltimeAsync (string userId, String endWorkday)
        {
             ApiResponse<AllTimePoints> localVarResponse = await GetGamificationScorecardsUserPointsAlltimeAsyncWithHttpInfo(userId, endWorkday);
             return localVarResponse.Data;

        }

        /// <summary>
        /// All-time points for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of ApiResponse (AllTimePoints)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AllTimePoints>> GetGamificationScorecardsUserPointsAlltimeAsyncWithHttpInfo (string userId, String endWorkday)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationScorecardsUserPointsAlltime");
            
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsUserPointsAlltime");
            

            var localVarPath = "/api/v2/gamification/scorecards/users/{userId}/points/alltime";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserPointsAlltime: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserPointsAlltime: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AllTimePoints>(localVarStatusCode,
                localVarHeaders,
                (AllTimePoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AllTimePoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Points trend for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>WorkdayPointsTrend</returns>
        public WorkdayPointsTrend GetGamificationScorecardsUserPointsTrends (string userId, String startWorkday, String endWorkday, string dayOfWeek = null)
        {
             ApiResponse<WorkdayPointsTrend> localVarResponse = GetGamificationScorecardsUserPointsTrendsWithHttpInfo(userId, startWorkday, endWorkday, dayOfWeek);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Points trend for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>ApiResponse of WorkdayPointsTrend</returns>
        public ApiResponse< WorkdayPointsTrend > GetGamificationScorecardsUserPointsTrendsWithHttpInfo (string userId, String startWorkday, String endWorkday, string dayOfWeek = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationScorecardsUserPointsTrends");
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsUserPointsTrends");
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsUserPointsTrends");

            var localVarPath = "/api/v2/gamification/scorecards/users/{userId}/points/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (dayOfWeek != null) localVarQueryParams.Add(new Tuple<string, string>("dayOfWeek", this.Configuration.ApiClient.ParameterToString(dayOfWeek)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserPointsTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserPointsTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkdayPointsTrend>(localVarStatusCode,
                localVarHeaders,
                (WorkdayPointsTrend) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkdayPointsTrend)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Points trend for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>Task of WorkdayPointsTrend</returns>
        public async System.Threading.Tasks.Task<WorkdayPointsTrend> GetGamificationScorecardsUserPointsTrendsAsync (string userId, String startWorkday, String endWorkday, string dayOfWeek = null)
        {
             ApiResponse<WorkdayPointsTrend> localVarResponse = await GetGamificationScorecardsUserPointsTrendsAsyncWithHttpInfo(userId, startWorkday, endWorkday, dayOfWeek);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Points trend for a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="dayOfWeek">Optional filter to specify which day of weeks to be included in the response (optional)</param>
        /// <returns>Task of ApiResponse (WorkdayPointsTrend)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkdayPointsTrend>> GetGamificationScorecardsUserPointsTrendsAsyncWithHttpInfo (string userId, String startWorkday, String endWorkday, string dayOfWeek = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationScorecardsUserPointsTrends");
            
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsUserPointsTrends");
            
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsUserPointsTrends");
            

            var localVarPath = "/api/v2/gamification/scorecards/users/{userId}/points/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (dayOfWeek != null) localVarQueryParams.Add(new Tuple<string, string>("dayOfWeek", this.Configuration.ApiClient.ParameterToString(dayOfWeek)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserPointsTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserPointsTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkdayPointsTrend>(localVarStatusCode,
                localVarHeaders,
                (WorkdayPointsTrend) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkdayPointsTrend)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Values trends of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>WorkdayValuesTrend</returns>
        public WorkdayValuesTrend GetGamificationScorecardsUserValuesTrends (string userId, String startWorkday, String endWorkday, string timeZone = null)
        {
             ApiResponse<WorkdayValuesTrend> localVarResponse = GetGamificationScorecardsUserValuesTrendsWithHttpInfo(userId, startWorkday, endWorkday, timeZone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Values trends of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of WorkdayValuesTrend</returns>
        public ApiResponse< WorkdayValuesTrend > GetGamificationScorecardsUserValuesTrendsWithHttpInfo (string userId, String startWorkday, String endWorkday, string timeZone = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationScorecardsUserValuesTrends");
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsUserValuesTrends");
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsUserValuesTrends");

            var localVarPath = "/api/v2/gamification/scorecards/users/{userId}/values/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserValuesTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserValuesTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkdayValuesTrend>(localVarStatusCode,
                localVarHeaders,
                (WorkdayValuesTrend) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkdayValuesTrend)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Values trends of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of WorkdayValuesTrend</returns>
        public async System.Threading.Tasks.Task<WorkdayValuesTrend> GetGamificationScorecardsUserValuesTrendsAsync (string userId, String startWorkday, String endWorkday, string timeZone = null)
        {
             ApiResponse<WorkdayValuesTrend> localVarResponse = await GetGamificationScorecardsUserValuesTrendsAsyncWithHttpInfo(userId, startWorkday, endWorkday, timeZone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Values trends of a user 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (WorkdayValuesTrend)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkdayValuesTrend>> GetGamificationScorecardsUserValuesTrendsAsyncWithHttpInfo (string userId, String startWorkday, String endWorkday, string timeZone = null)
        { 
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling GamificationApi->GetGamificationScorecardsUserValuesTrends");
            
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsUserValuesTrends");
            
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsUserValuesTrends");
            

            var localVarPath = "/api/v2/gamification/scorecards/users/{userId}/values/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (userId != null) localVarPathParams.Add("userId", this.Configuration.ApiClient.ParameterToString(userId));

            // Query params
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserValuesTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUserValuesTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkdayValuesTrend>(localVarStatusCode,
                localVarHeaders,
                (WorkdayValuesTrend) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkdayValuesTrend)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Workday average points by target group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>SingleWorkdayAveragePoints</returns>
        public SingleWorkdayAveragePoints GetGamificationScorecardsUsersPointsAverage (string filterType, string filterId, String workday)
        {
             ApiResponse<SingleWorkdayAveragePoints> localVarResponse = GetGamificationScorecardsUsersPointsAverageWithHttpInfo(filterType, filterId, workday);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Workday average points by target group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>ApiResponse of SingleWorkdayAveragePoints</returns>
        public ApiResponse< SingleWorkdayAveragePoints > GetGamificationScorecardsUsersPointsAverageWithHttpInfo (string filterType, string filterId, String workday)
        { 
            // verify the required parameter 'filterType' is set
            if (filterType == null)
                throw new ApiException(400, "Missing required parameter 'filterType' when calling GamificationApi->GetGamificationScorecardsUsersPointsAverage");
            // verify the required parameter 'filterId' is set
            if (filterId == null)
                throw new ApiException(400, "Missing required parameter 'filterId' when calling GamificationApi->GetGamificationScorecardsUsersPointsAverage");
            // verify the required parameter 'workday' is set
            if (workday == null)
                throw new ApiException(400, "Missing required parameter 'workday' when calling GamificationApi->GetGamificationScorecardsUsersPointsAverage");

            var localVarPath = "/api/v2/gamification/scorecards/users/points/average";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (filterId != null) localVarQueryParams.Add(new Tuple<string, string>("filterId", this.Configuration.ApiClient.ParameterToString(filterId)));
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUsersPointsAverage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUsersPointsAverage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SingleWorkdayAveragePoints>(localVarStatusCode,
                localVarHeaders,
                (SingleWorkdayAveragePoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SingleWorkdayAveragePoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Workday average points by target group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of SingleWorkdayAveragePoints</returns>
        public async System.Threading.Tasks.Task<SingleWorkdayAveragePoints> GetGamificationScorecardsUsersPointsAverageAsync (string filterType, string filterId, String workday)
        {
             ApiResponse<SingleWorkdayAveragePoints> localVarResponse = await GetGamificationScorecardsUsersPointsAverageAsyncWithHttpInfo(filterType, filterId, workday);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Workday average points by target group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <returns>Task of ApiResponse (SingleWorkdayAveragePoints)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SingleWorkdayAveragePoints>> GetGamificationScorecardsUsersPointsAverageAsyncWithHttpInfo (string filterType, string filterId, String workday)
        { 
            // verify the required parameter 'filterType' is set
            if (filterType == null)
                throw new ApiException(400, "Missing required parameter 'filterType' when calling GamificationApi->GetGamificationScorecardsUsersPointsAverage");
            
            // verify the required parameter 'filterId' is set
            if (filterId == null)
                throw new ApiException(400, "Missing required parameter 'filterId' when calling GamificationApi->GetGamificationScorecardsUsersPointsAverage");
            
            // verify the required parameter 'workday' is set
            if (workday == null)
                throw new ApiException(400, "Missing required parameter 'workday' when calling GamificationApi->GetGamificationScorecardsUsersPointsAverage");
            

            var localVarPath = "/api/v2/gamification/scorecards/users/points/average";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (filterId != null) localVarQueryParams.Add(new Tuple<string, string>("filterId", this.Configuration.ApiClient.ParameterToString(filterId)));
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUsersPointsAverage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUsersPointsAverage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SingleWorkdayAveragePoints>(localVarStatusCode,
                localVarHeaders,
                (SingleWorkdayAveragePoints) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SingleWorkdayAveragePoints)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Workday average values by target group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>SingleWorkdayAverageValues</returns>
        public SingleWorkdayAverageValues GetGamificationScorecardsUsersValuesAverage (string filterType, string filterId, String workday, string timeZone = null)
        {
             ApiResponse<SingleWorkdayAverageValues> localVarResponse = GetGamificationScorecardsUsersValuesAverageWithHttpInfo(filterType, filterId, workday, timeZone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Workday average values by target group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of SingleWorkdayAverageValues</returns>
        public ApiResponse< SingleWorkdayAverageValues > GetGamificationScorecardsUsersValuesAverageWithHttpInfo (string filterType, string filterId, String workday, string timeZone = null)
        { 
            // verify the required parameter 'filterType' is set
            if (filterType == null)
                throw new ApiException(400, "Missing required parameter 'filterType' when calling GamificationApi->GetGamificationScorecardsUsersValuesAverage");
            // verify the required parameter 'filterId' is set
            if (filterId == null)
                throw new ApiException(400, "Missing required parameter 'filterId' when calling GamificationApi->GetGamificationScorecardsUsersValuesAverage");
            // verify the required parameter 'workday' is set
            if (workday == null)
                throw new ApiException(400, "Missing required parameter 'workday' when calling GamificationApi->GetGamificationScorecardsUsersValuesAverage");

            var localVarPath = "/api/v2/gamification/scorecards/users/values/average";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (filterId != null) localVarQueryParams.Add(new Tuple<string, string>("filterId", this.Configuration.ApiClient.ParameterToString(filterId)));
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUsersValuesAverage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUsersValuesAverage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SingleWorkdayAverageValues>(localVarStatusCode,
                localVarHeaders,
                (SingleWorkdayAverageValues) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SingleWorkdayAverageValues)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Workday average values by target group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of SingleWorkdayAverageValues</returns>
        public async System.Threading.Tasks.Task<SingleWorkdayAverageValues> GetGamificationScorecardsUsersValuesAverageAsync (string filterType, string filterId, String workday, string timeZone = null)
        {
             ApiResponse<SingleWorkdayAverageValues> localVarResponse = await GetGamificationScorecardsUsersValuesAverageAsyncWithHttpInfo(filterType, filterId, workday, timeZone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Workday average values by target group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type. For example, division Id</param>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (SingleWorkdayAverageValues)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SingleWorkdayAverageValues>> GetGamificationScorecardsUsersValuesAverageAsyncWithHttpInfo (string filterType, string filterId, String workday, string timeZone = null)
        { 
            // verify the required parameter 'filterType' is set
            if (filterType == null)
                throw new ApiException(400, "Missing required parameter 'filterType' when calling GamificationApi->GetGamificationScorecardsUsersValuesAverage");
            
            // verify the required parameter 'filterId' is set
            if (filterId == null)
                throw new ApiException(400, "Missing required parameter 'filterId' when calling GamificationApi->GetGamificationScorecardsUsersValuesAverage");
            
            // verify the required parameter 'workday' is set
            if (workday == null)
                throw new ApiException(400, "Missing required parameter 'workday' when calling GamificationApi->GetGamificationScorecardsUsersValuesAverage");
            

            var localVarPath = "/api/v2/gamification/scorecards/users/values/average";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (filterId != null) localVarQueryParams.Add(new Tuple<string, string>("filterId", this.Configuration.ApiClient.ParameterToString(filterId)));
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUsersValuesAverage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUsersValuesAverage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SingleWorkdayAverageValues>(localVarStatusCode,
                localVarHeaders,
                (SingleWorkdayAverageValues) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SingleWorkdayAverageValues)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Values trend by target group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>WorkdayValuesTrend</returns>
        public WorkdayValuesTrend GetGamificationScorecardsUsersValuesTrends (string filterType, string filterId, String startWorkday, String endWorkday, string timeZone = null)
        {
             ApiResponse<WorkdayValuesTrend> localVarResponse = GetGamificationScorecardsUsersValuesTrendsWithHttpInfo(filterType, filterId, startWorkday, endWorkday, timeZone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Values trend by target group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of WorkdayValuesTrend</returns>
        public ApiResponse< WorkdayValuesTrend > GetGamificationScorecardsUsersValuesTrendsWithHttpInfo (string filterType, string filterId, String startWorkday, String endWorkday, string timeZone = null)
        { 
            // verify the required parameter 'filterType' is set
            if (filterType == null)
                throw new ApiException(400, "Missing required parameter 'filterType' when calling GamificationApi->GetGamificationScorecardsUsersValuesTrends");
            // verify the required parameter 'filterId' is set
            if (filterId == null)
                throw new ApiException(400, "Missing required parameter 'filterId' when calling GamificationApi->GetGamificationScorecardsUsersValuesTrends");
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsUsersValuesTrends");
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsUsersValuesTrends");

            var localVarPath = "/api/v2/gamification/scorecards/users/values/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (filterId != null) localVarQueryParams.Add(new Tuple<string, string>("filterId", this.Configuration.ApiClient.ParameterToString(filterId)));
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUsersValuesTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUsersValuesTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkdayValuesTrend>(localVarStatusCode,
                localVarHeaders,
                (WorkdayValuesTrend) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkdayValuesTrend)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Values trend by target group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of WorkdayValuesTrend</returns>
        public async System.Threading.Tasks.Task<WorkdayValuesTrend> GetGamificationScorecardsUsersValuesTrendsAsync (string filterType, string filterId, String startWorkday, String endWorkday, string timeZone = null)
        {
             ApiResponse<WorkdayValuesTrend> localVarResponse = await GetGamificationScorecardsUsersValuesTrendsAsyncWithHttpInfo(filterType, filterId, startWorkday, endWorkday, timeZone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Values trend by target group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterType">Filter type for the query request.</param>
        /// <param name="filterId">ID for the filter type.</param>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (WorkdayValuesTrend)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkdayValuesTrend>> GetGamificationScorecardsUsersValuesTrendsAsyncWithHttpInfo (string filterType, string filterId, String startWorkday, String endWorkday, string timeZone = null)
        { 
            // verify the required parameter 'filterType' is set
            if (filterType == null)
                throw new ApiException(400, "Missing required parameter 'filterType' when calling GamificationApi->GetGamificationScorecardsUsersValuesTrends");
            
            // verify the required parameter 'filterId' is set
            if (filterId == null)
                throw new ApiException(400, "Missing required parameter 'filterId' when calling GamificationApi->GetGamificationScorecardsUsersValuesTrends");
            
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsUsersValuesTrends");
            
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsUsersValuesTrends");
            

            var localVarPath = "/api/v2/gamification/scorecards/users/values/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (filterId != null) localVarQueryParams.Add(new Tuple<string, string>("filterId", this.Configuration.ApiClient.ParameterToString(filterId)));
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUsersValuesTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsUsersValuesTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkdayValuesTrend>(localVarStatusCode,
                localVarHeaders,
                (WorkdayValuesTrend) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkdayValuesTrend)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Average values of the requesting user's division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>SingleWorkdayAverageValues</returns>
        public SingleWorkdayAverageValues GetGamificationScorecardsValuesAverage (String workday, string timeZone = null)
        {
             ApiResponse<SingleWorkdayAverageValues> localVarResponse = GetGamificationScorecardsValuesAverageWithHttpInfo(workday, timeZone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Average values of the requesting user's division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of SingleWorkdayAverageValues</returns>
        public ApiResponse< SingleWorkdayAverageValues > GetGamificationScorecardsValuesAverageWithHttpInfo (String workday, string timeZone = null)
        { 
            // verify the required parameter 'workday' is set
            if (workday == null)
                throw new ApiException(400, "Missing required parameter 'workday' when calling GamificationApi->GetGamificationScorecardsValuesAverage");

            var localVarPath = "/api/v2/gamification/scorecards/values/average";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsValuesAverage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsValuesAverage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SingleWorkdayAverageValues>(localVarStatusCode,
                localVarHeaders,
                (SingleWorkdayAverageValues) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SingleWorkdayAverageValues)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Average values of the requesting user's division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of SingleWorkdayAverageValues</returns>
        public async System.Threading.Tasks.Task<SingleWorkdayAverageValues> GetGamificationScorecardsValuesAverageAsync (String workday, string timeZone = null)
        {
             ApiResponse<SingleWorkdayAverageValues> localVarResponse = await GetGamificationScorecardsValuesAverageAsyncWithHttpInfo(workday, timeZone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Average values of the requesting user's division or performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workday">The target workday. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (SingleWorkdayAverageValues)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SingleWorkdayAverageValues>> GetGamificationScorecardsValuesAverageAsyncWithHttpInfo (String workday, string timeZone = null)
        { 
            // verify the required parameter 'workday' is set
            if (workday == null)
                throw new ApiException(400, "Missing required parameter 'workday' when calling GamificationApi->GetGamificationScorecardsValuesAverage");
            

            var localVarPath = "/api/v2/gamification/scorecards/values/average";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (workday != null) localVarQueryParams.Add(new Tuple<string, string>("workday", this.Configuration.ApiClient.ParameterToString(workday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsValuesAverage: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsValuesAverage: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SingleWorkdayAverageValues>(localVarStatusCode,
                localVarHeaders,
                (SingleWorkdayAverageValues) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SingleWorkdayAverageValues)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Values trends of the requesting user or group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, then the request is for the requesting user. (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the profile of the user as of this date. If not set, then the user&#39;s current profile will be used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>WorkdayValuesTrend</returns>
        public WorkdayValuesTrend GetGamificationScorecardsValuesTrends (String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null)
        {
             ApiResponse<WorkdayValuesTrend> localVarResponse = GetGamificationScorecardsValuesTrendsWithHttpInfo(startWorkday, endWorkday, filterType, referenceWorkday, timeZone);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Values trends of the requesting user or group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, then the request is for the requesting user. (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the profile of the user as of this date. If not set, then the user&#39;s current profile will be used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>ApiResponse of WorkdayValuesTrend</returns>
        public ApiResponse< WorkdayValuesTrend > GetGamificationScorecardsValuesTrendsWithHttpInfo (String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null)
        { 
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsValuesTrends");
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsValuesTrends");

            var localVarPath = "/api/v2/gamification/scorecards/values/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (referenceWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("referenceWorkday", this.Configuration.ApiClient.ParameterToString(referenceWorkday)));
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsValuesTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsValuesTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkdayValuesTrend>(localVarStatusCode,
                localVarHeaders,
                (WorkdayValuesTrend) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkdayValuesTrend)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Values trends of the requesting user or group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, then the request is for the requesting user. (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the profile of the user as of this date. If not set, then the user&#39;s current profile will be used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of WorkdayValuesTrend</returns>
        public async System.Threading.Tasks.Task<WorkdayValuesTrend> GetGamificationScorecardsValuesTrendsAsync (String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null)
        {
             ApiResponse<WorkdayValuesTrend> localVarResponse = await GetGamificationScorecardsValuesTrendsAsyncWithHttpInfo(startWorkday, endWorkday, filterType, referenceWorkday, timeZone);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Values trends of the requesting user or group 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startWorkday">Start workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="endWorkday">End workday of querying workdays range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</param>
        /// <param name="filterType">Filter type for the query request. If not set, then the request is for the requesting user. (optional)</param>
        /// <param name="referenceWorkday">Reference workday for the trend. Used to determine the profile of the user as of this date. If not set, then the user&#39;s current profile will be used. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (optional)</param>
        /// <param name="timeZone">Timezone for the workday. Defaults to UTC (optional, default to "UTC")</param>
        /// <returns>Task of ApiResponse (WorkdayValuesTrend)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WorkdayValuesTrend>> GetGamificationScorecardsValuesTrendsAsyncWithHttpInfo (String startWorkday, String endWorkday, string filterType = null, String referenceWorkday = null, string timeZone = null)
        { 
            // verify the required parameter 'startWorkday' is set
            if (startWorkday == null)
                throw new ApiException(400, "Missing required parameter 'startWorkday' when calling GamificationApi->GetGamificationScorecardsValuesTrends");
            
            // verify the required parameter 'endWorkday' is set
            if (endWorkday == null)
                throw new ApiException(400, "Missing required parameter 'endWorkday' when calling GamificationApi->GetGamificationScorecardsValuesTrends");
            

            var localVarPath = "/api/v2/gamification/scorecards/values/trends";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (filterType != null) localVarQueryParams.Add(new Tuple<string, string>("filterType", this.Configuration.ApiClient.ParameterToString(filterType)));
            if (referenceWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("referenceWorkday", this.Configuration.ApiClient.ParameterToString(referenceWorkday)));
            if (startWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("startWorkday", this.Configuration.ApiClient.ParameterToString(startWorkday)));
            if (endWorkday != null) localVarQueryParams.Add(new Tuple<string, string>("endWorkday", this.Configuration.ApiClient.ParameterToString(endWorkday)));
            if (timeZone != null) localVarQueryParams.Add(new Tuple<string, string>("timeZone", this.Configuration.ApiClient.ParameterToString(timeZone)));

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsValuesTrends: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationScorecardsValuesTrends: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WorkdayValuesTrend>(localVarStatusCode,
                localVarHeaders,
                (WorkdayValuesTrend) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(WorkdayValuesTrend)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Gamification activation status 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GamificationStatus</returns>
        public GamificationStatus GetGamificationStatus ()
        {
             ApiResponse<GamificationStatus> localVarResponse = GetGamificationStatusWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gamification activation status 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GamificationStatus</returns>
        public ApiResponse< GamificationStatus > GetGamificationStatusWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/gamification/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GamificationStatus>(localVarStatusCode,
                localVarHeaders,
                (GamificationStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GamificationStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Gamification activation status 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GamificationStatus</returns>
        public async System.Threading.Tasks.Task<GamificationStatus> GetGamificationStatusAsync ()
        {
             ApiResponse<GamificationStatus> localVarResponse = await GetGamificationStatusAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gamification activation status 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GamificationStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GamificationStatus>> GetGamificationStatusAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/gamification/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GamificationStatus>(localVarStatusCode,
                localVarHeaders,
                (GamificationStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GamificationStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Objective template by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">template id</param>
        /// <returns>ObjectiveTemplate</returns>
        public ObjectiveTemplate GetGamificationTemplate (string templateId)
        {
             ApiResponse<ObjectiveTemplate> localVarResponse = GetGamificationTemplateWithHttpInfo(templateId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Objective template by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">template id</param>
        /// <returns>ApiResponse of ObjectiveTemplate</returns>
        public ApiResponse< ObjectiveTemplate > GetGamificationTemplateWithHttpInfo (string templateId)
        { 
            // verify the required parameter 'templateId' is set
            if (templateId == null)
                throw new ApiException(400, "Missing required parameter 'templateId' when calling GamificationApi->GetGamificationTemplate");

            var localVarPath = "/api/v2/gamification/templates/{templateId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (templateId != null) localVarPathParams.Add("templateId", this.Configuration.ApiClient.ParameterToString(templateId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationTemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObjectiveTemplate>(localVarStatusCode,
                localVarHeaders,
                (ObjectiveTemplate) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObjectiveTemplate)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Objective template by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">template id</param>
        /// <returns>Task of ObjectiveTemplate</returns>
        public async System.Threading.Tasks.Task<ObjectiveTemplate> GetGamificationTemplateAsync (string templateId)
        {
             ApiResponse<ObjectiveTemplate> localVarResponse = await GetGamificationTemplateAsyncWithHttpInfo(templateId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Objective template by id 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templateId">template id</param>
        /// <returns>Task of ApiResponse (ObjectiveTemplate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObjectiveTemplate>> GetGamificationTemplateAsyncWithHttpInfo (string templateId)
        { 
            // verify the required parameter 'templateId' is set
            if (templateId == null)
                throw new ApiException(400, "Missing required parameter 'templateId' when calling GamificationApi->GetGamificationTemplate");
            

            var localVarPath = "/api/v2/gamification/templates/{templateId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (templateId != null) localVarPathParams.Add("templateId", this.Configuration.ApiClient.ParameterToString(templateId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationTemplate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObjectiveTemplate>(localVarStatusCode,
                localVarHeaders,
                (ObjectiveTemplate) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObjectiveTemplate)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// All objective templates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetTemplatesResponse</returns>
        public GetTemplatesResponse GetGamificationTemplates ()
        {
             ApiResponse<GetTemplatesResponse> localVarResponse = GetGamificationTemplatesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// All objective templates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetTemplatesResponse</returns>
        public ApiResponse< GetTemplatesResponse > GetGamificationTemplatesWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/gamification/templates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationTemplates: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationTemplates: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetTemplatesResponse>(localVarStatusCode,
                localVarHeaders,
                (GetTemplatesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetTemplatesResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// All objective templates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GetTemplatesResponse</returns>
        public async System.Threading.Tasks.Task<GetTemplatesResponse> GetGamificationTemplatesAsync ()
        {
             ApiResponse<GetTemplatesResponse> localVarResponse = await GetGamificationTemplatesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// All objective templates 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GetTemplatesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetTemplatesResponse>> GetGamificationTemplatesAsyncWithHttpInfo ()
        { 

            var localVarPath = "/api/v2/gamification/templates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationTemplates: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetGamificationTemplates: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GetTemplatesResponse>(localVarStatusCode,
                localVarHeaders,
                (GetTemplatesResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetTemplatesResponse)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Metric</param>
        /// <returns>Metric</returns>
        public Metric PostGamificationMetrics (CreateMetric body)
        {
             ApiResponse<Metric> localVarResponse = PostGamificationMetricsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Metric</param>
        /// <returns>ApiResponse of Metric</returns>
        public ApiResponse< Metric > PostGamificationMetricsWithHttpInfo (CreateMetric body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PostGamificationMetrics");

            var localVarPath = "/api/v2/gamification/metrics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationMetrics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationMetrics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Metric>(localVarStatusCode,
                localVarHeaders,
                (Metric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Metric</param>
        /// <returns>Task of Metric</returns>
        public async System.Threading.Tasks.Task<Metric> PostGamificationMetricsAsync (CreateMetric body)
        {
             ApiResponse<Metric> localVarResponse = await PostGamificationMetricsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Metric</param>
        /// <returns>Task of ApiResponse (Metric)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Metric>> PostGamificationMetricsAsyncWithHttpInfo (CreateMetric body)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PostGamificationMetrics");
            

            var localVarPath = "/api/v2/gamification/metrics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationMetrics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationMetrics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Metric>(localVarStatusCode,
                localVarHeaders,
                (Metric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Activate a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>PerformanceProfile</returns>
        public PerformanceProfile PostGamificationProfileActivate (string profileId)
        {
             ApiResponse<PerformanceProfile> localVarResponse = PostGamificationProfileActivateWithHttpInfo(profileId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Activate a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>ApiResponse of PerformanceProfile</returns>
        public ApiResponse< PerformanceProfile > PostGamificationProfileActivateWithHttpInfo (string profileId)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->PostGamificationProfileActivate");

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/activate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileActivate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileActivate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerformanceProfile>(localVarStatusCode,
                localVarHeaders,
                (PerformanceProfile) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceProfile)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Activate a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>Task of PerformanceProfile</returns>
        public async System.Threading.Tasks.Task<PerformanceProfile> PostGamificationProfileActivateAsync (string profileId)
        {
             ApiResponse<PerformanceProfile> localVarResponse = await PostGamificationProfileActivateAsyncWithHttpInfo(profileId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Activate a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>Task of ApiResponse (PerformanceProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PerformanceProfile>> PostGamificationProfileActivateAsyncWithHttpInfo (string profileId)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->PostGamificationProfileActivate");
            

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/activate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileActivate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileActivate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerformanceProfile>(localVarStatusCode,
                localVarHeaders,
                (PerformanceProfile) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceProfile)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Deactivate a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>PerformanceProfile</returns>
        public PerformanceProfile PostGamificationProfileDeactivate (string profileId)
        {
             ApiResponse<PerformanceProfile> localVarResponse = PostGamificationProfileDeactivateWithHttpInfo(profileId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deactivate a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>ApiResponse of PerformanceProfile</returns>
        public ApiResponse< PerformanceProfile > PostGamificationProfileDeactivateWithHttpInfo (string profileId)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->PostGamificationProfileDeactivate");

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/deactivate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileDeactivate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileDeactivate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerformanceProfile>(localVarStatusCode,
                localVarHeaders,
                (PerformanceProfile) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceProfile)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Deactivate a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>Task of PerformanceProfile</returns>
        public async System.Threading.Tasks.Task<PerformanceProfile> PostGamificationProfileDeactivateAsync (string profileId)
        {
             ApiResponse<PerformanceProfile> localVarResponse = await PostGamificationProfileDeactivateAsyncWithHttpInfo(profileId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deactivate a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <returns>Task of ApiResponse (PerformanceProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PerformanceProfile>> PostGamificationProfileDeactivateAsyncWithHttpInfo (string profileId)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->PostGamificationProfileDeactivate");
            

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/deactivate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param


            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileDeactivate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileDeactivate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerformanceProfile>(localVarStatusCode,
                localVarHeaders,
                (PerformanceProfile) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceProfile)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Assign members to a given performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">assignUsers</param>
        /// <returns>Assignment</returns>
        public Assignment PostGamificationProfileMembers (string profileId, AssignUsers body)
        {
             ApiResponse<Assignment> localVarResponse = PostGamificationProfileMembersWithHttpInfo(profileId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Assign members to a given performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">assignUsers</param>
        /// <returns>ApiResponse of Assignment</returns>
        public ApiResponse< Assignment > PostGamificationProfileMembersWithHttpInfo (string profileId, AssignUsers body)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->PostGamificationProfileMembers");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PostGamificationProfileMembers");

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/members";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMembers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Assignment>(localVarStatusCode,
                localVarHeaders,
                (Assignment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Assignment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Assign members to a given performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">assignUsers</param>
        /// <returns>Task of Assignment</returns>
        public async System.Threading.Tasks.Task<Assignment> PostGamificationProfileMembersAsync (string profileId, AssignUsers body)
        {
             ApiResponse<Assignment> localVarResponse = await PostGamificationProfileMembersAsyncWithHttpInfo(profileId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Assign members to a given performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">assignUsers</param>
        /// <returns>Task of ApiResponse (Assignment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Assignment>> PostGamificationProfileMembersAsyncWithHttpInfo (string profileId, AssignUsers body)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->PostGamificationProfileMembers");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PostGamificationProfileMembers");
            

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/members";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMembers: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMembers: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Assignment>(localVarStatusCode,
                localVarHeaders,
                (Assignment) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Assignment)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Validate member assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">memberAssignments</param>
        /// <returns>AssignmentValidation</returns>
        public AssignmentValidation PostGamificationProfileMembersValidate (string profileId, ValidateAssignUsers body)
        {
             ApiResponse<AssignmentValidation> localVarResponse = PostGamificationProfileMembersValidateWithHttpInfo(profileId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validate member assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">memberAssignments</param>
        /// <returns>ApiResponse of AssignmentValidation</returns>
        public ApiResponse< AssignmentValidation > PostGamificationProfileMembersValidateWithHttpInfo (string profileId, ValidateAssignUsers body)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->PostGamificationProfileMembersValidate");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PostGamificationProfileMembersValidate");

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/members/validate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMembersValidate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMembersValidate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssignmentValidation>(localVarStatusCode,
                localVarHeaders,
                (AssignmentValidation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssignmentValidation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Validate member assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">memberAssignments</param>
        /// <returns>Task of AssignmentValidation</returns>
        public async System.Threading.Tasks.Task<AssignmentValidation> PostGamificationProfileMembersValidateAsync (string profileId, ValidateAssignUsers body)
        {
             ApiResponse<AssignmentValidation> localVarResponse = await PostGamificationProfileMembersValidateAsyncWithHttpInfo(profileId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validate member assignment 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Profile Id</param>
        /// <param name="body">memberAssignments</param>
        /// <returns>Task of ApiResponse (AssignmentValidation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AssignmentValidation>> PostGamificationProfileMembersValidateAsyncWithHttpInfo (string profileId, ValidateAssignUsers body)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->PostGamificationProfileMembersValidate");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PostGamificationProfileMembersValidate");
            

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/members/validate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMembersValidate: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMembersValidate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AssignmentValidation>(localVarStatusCode,
                localVarHeaders,
                (AssignmentValidation) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AssignmentValidation)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Creates a linked metric 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceProfileId">Source Performance Profile Id</param>
        /// <param name="sourceMetricId">Source Metric Id</param>
        /// <param name="body">linkedMetric</param>
        /// <returns>Metric</returns>
        public Metric PostGamificationProfileMetricLink (string sourceProfileId, string sourceMetricId, TargetPerformanceProfile body)
        {
             ApiResponse<Metric> localVarResponse = PostGamificationProfileMetricLinkWithHttpInfo(sourceProfileId, sourceMetricId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a linked metric 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceProfileId">Source Performance Profile Id</param>
        /// <param name="sourceMetricId">Source Metric Id</param>
        /// <param name="body">linkedMetric</param>
        /// <returns>ApiResponse of Metric</returns>
        public ApiResponse< Metric > PostGamificationProfileMetricLinkWithHttpInfo (string sourceProfileId, string sourceMetricId, TargetPerformanceProfile body)
        { 
            // verify the required parameter 'sourceProfileId' is set
            if (sourceProfileId == null)
                throw new ApiException(400, "Missing required parameter 'sourceProfileId' when calling GamificationApi->PostGamificationProfileMetricLink");
            // verify the required parameter 'sourceMetricId' is set
            if (sourceMetricId == null)
                throw new ApiException(400, "Missing required parameter 'sourceMetricId' when calling GamificationApi->PostGamificationProfileMetricLink");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PostGamificationProfileMetricLink");

            var localVarPath = "/api/v2/gamification/profiles/{sourceProfileId}/metrics/{sourceMetricId}/link";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (sourceProfileId != null) localVarPathParams.Add("sourceProfileId", this.Configuration.ApiClient.ParameterToString(sourceProfileId));
            if (sourceMetricId != null) localVarPathParams.Add("sourceMetricId", this.Configuration.ApiClient.ParameterToString(sourceMetricId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMetricLink: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMetricLink: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Metric>(localVarStatusCode,
                localVarHeaders,
                (Metric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Creates a linked metric 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceProfileId">Source Performance Profile Id</param>
        /// <param name="sourceMetricId">Source Metric Id</param>
        /// <param name="body">linkedMetric</param>
        /// <returns>Task of Metric</returns>
        public async System.Threading.Tasks.Task<Metric> PostGamificationProfileMetricLinkAsync (string sourceProfileId, string sourceMetricId, TargetPerformanceProfile body)
        {
             ApiResponse<Metric> localVarResponse = await PostGamificationProfileMetricLinkAsyncWithHttpInfo(sourceProfileId, sourceMetricId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a linked metric 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sourceProfileId">Source Performance Profile Id</param>
        /// <param name="sourceMetricId">Source Metric Id</param>
        /// <param name="body">linkedMetric</param>
        /// <returns>Task of ApiResponse (Metric)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Metric>> PostGamificationProfileMetricLinkAsyncWithHttpInfo (string sourceProfileId, string sourceMetricId, TargetPerformanceProfile body)
        { 
            // verify the required parameter 'sourceProfileId' is set
            if (sourceProfileId == null)
                throw new ApiException(400, "Missing required parameter 'sourceProfileId' when calling GamificationApi->PostGamificationProfileMetricLink");
            
            // verify the required parameter 'sourceMetricId' is set
            if (sourceMetricId == null)
                throw new ApiException(400, "Missing required parameter 'sourceMetricId' when calling GamificationApi->PostGamificationProfileMetricLink");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PostGamificationProfileMetricLink");
            

            var localVarPath = "/api/v2/gamification/profiles/{sourceProfileId}/metrics/{sourceMetricId}/link";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (sourceProfileId != null) localVarPathParams.Add("sourceProfileId", this.Configuration.ApiClient.ParameterToString(sourceProfileId));
            if (sourceMetricId != null) localVarPathParams.Add("sourceMetricId", this.Configuration.ApiClient.ParameterToString(sourceMetricId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMetricLink: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMetricLink: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Metric>(localVarStatusCode,
                localVarHeaders,
                (Metric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective under in a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="body">Metric</param>
        /// <returns>Metric</returns>
        public Metric PostGamificationProfileMetrics (string profileId, CreateMetric body)
        {
             ApiResponse<Metric> localVarResponse = PostGamificationProfileMetricsWithHttpInfo(profileId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective under in a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="body">Metric</param>
        /// <returns>ApiResponse of Metric</returns>
        public ApiResponse< Metric > PostGamificationProfileMetricsWithHttpInfo (string profileId, CreateMetric body)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->PostGamificationProfileMetrics");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PostGamificationProfileMetrics");

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/metrics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMetrics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMetrics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Metric>(localVarStatusCode,
                localVarHeaders,
                (Metric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective under in a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="body">Metric</param>
        /// <returns>Task of Metric</returns>
        public async System.Threading.Tasks.Task<Metric> PostGamificationProfileMetricsAsync (string profileId, CreateMetric body)
        {
             ApiResponse<Metric> localVarResponse = await PostGamificationProfileMetricsAsyncWithHttpInfo(profileId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a gamified metric with a given metric definition and metric objective under in a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="body">Metric</param>
        /// <returns>Task of ApiResponse (Metric)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Metric>> PostGamificationProfileMetricsAsyncWithHttpInfo (string profileId, CreateMetric body)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->PostGamificationProfileMetrics");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PostGamificationProfileMetrics");
            

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/metrics";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMetrics: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfileMetrics: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Metric>(localVarStatusCode,
                localVarHeaders,
                (Metric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Create a new custom performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">performanceProfile</param>
        /// <param name="copyMetrics">Flag to copy metrics. If set to false, there will be no metrics associated with the new profile. If set to true or is absent (the default behavior), all metrics from the default profile will be copied over into the new profile. (optional, default to true)</param>
        /// <returns>PerformanceProfile</returns>
        public PerformanceProfile PostGamificationProfiles (CreatePerformanceProfile body, bool? copyMetrics = null)
        {
             ApiResponse<PerformanceProfile> localVarResponse = PostGamificationProfilesWithHttpInfo(body, copyMetrics);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new custom performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">performanceProfile</param>
        /// <param name="copyMetrics">Flag to copy metrics. If set to false, there will be no metrics associated with the new profile. If set to true or is absent (the default behavior), all metrics from the default profile will be copied over into the new profile. (optional, default to true)</param>
        /// <returns>ApiResponse of PerformanceProfile</returns>
        public ApiResponse< PerformanceProfile > PostGamificationProfilesWithHttpInfo (CreatePerformanceProfile body, bool? copyMetrics = null)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PostGamificationProfiles");

            var localVarPath = "/api/v2/gamification/profiles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (copyMetrics != null) localVarQueryParams.Add(new Tuple<string, string>("copyMetrics", this.Configuration.ApiClient.ParameterToString(copyMetrics)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfiles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfiles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerformanceProfile>(localVarStatusCode,
                localVarHeaders,
                (PerformanceProfile) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceProfile)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Create a new custom performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">performanceProfile</param>
        /// <param name="copyMetrics">Flag to copy metrics. If set to false, there will be no metrics associated with the new profile. If set to true or is absent (the default behavior), all metrics from the default profile will be copied over into the new profile. (optional, default to true)</param>
        /// <returns>Task of PerformanceProfile</returns>
        public async System.Threading.Tasks.Task<PerformanceProfile> PostGamificationProfilesAsync (CreatePerformanceProfile body, bool? copyMetrics = null)
        {
             ApiResponse<PerformanceProfile> localVarResponse = await PostGamificationProfilesAsyncWithHttpInfo(body, copyMetrics);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new custom performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">performanceProfile</param>
        /// <param name="copyMetrics">Flag to copy metrics. If set to false, there will be no metrics associated with the new profile. If set to true or is absent (the default behavior), all metrics from the default profile will be copied over into the new profile. (optional, default to true)</param>
        /// <returns>Task of ApiResponse (PerformanceProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PerformanceProfile>> PostGamificationProfilesAsyncWithHttpInfo (CreatePerformanceProfile body, bool? copyMetrics = null)
        { 
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PostGamificationProfiles");
            

            var localVarPath = "/api/v2/gamification/profiles";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params
            if (copyMetrics != null) localVarQueryParams.Add(new Tuple<string, string>("copyMetrics", this.Configuration.ApiClient.ParameterToString(copyMetrics)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfiles: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostGamificationProfiles: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerformanceProfile>(localVarStatusCode,
                localVarHeaders,
                (PerformanceProfile) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceProfile)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Updates a metric This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="body">Metric</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>Metric</returns>
        public Metric PutGamificationMetric (string metricId, CreateMetric body, string performanceProfileId = null)
        {
             ApiResponse<Metric> localVarResponse = PutGamificationMetricWithHttpInfo(metricId, body, performanceProfileId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates a metric This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="body">Metric</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>ApiResponse of Metric</returns>
        public ApiResponse< Metric > PutGamificationMetricWithHttpInfo (string metricId, CreateMetric body, string performanceProfileId = null)
        { 
            // verify the required parameter 'metricId' is set
            if (metricId == null)
                throw new ApiException(400, "Missing required parameter 'metricId' when calling GamificationApi->PutGamificationMetric");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PutGamificationMetric");

            var localVarPath = "/api/v2/gamification/metrics/{metricId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (metricId != null) localVarPathParams.Add("metricId", this.Configuration.ApiClient.ParameterToString(metricId));

            // Query params
            if (performanceProfileId != null) localVarQueryParams.Add(new Tuple<string, string>("performanceProfileId", this.Configuration.ApiClient.ParameterToString(performanceProfileId)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationMetric: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationMetric: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Metric>(localVarStatusCode,
                localVarHeaders,
                (Metric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Updates a metric This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="body">Metric</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>Task of Metric</returns>
        public async System.Threading.Tasks.Task<Metric> PutGamificationMetricAsync (string metricId, CreateMetric body, string performanceProfileId = null)
        {
             ApiResponse<Metric> localVarResponse = await PutGamificationMetricAsyncWithHttpInfo(metricId, body, performanceProfileId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates a metric This API is deprecated. Use /api/v2/gamification/profiles/{profileId}/metrics/{metricId} instead.
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metricId">metric Id</param>
        /// <param name="body">Metric</param>
        /// <param name="performanceProfileId">The profile id of the metrics you are trying to retrieve. The DEFAULT profile is used if nothing is given. (optional)</param>
        /// <returns>Task of ApiResponse (Metric)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Metric>> PutGamificationMetricAsyncWithHttpInfo (string metricId, CreateMetric body, string performanceProfileId = null)
        { 
            // verify the required parameter 'metricId' is set
            if (metricId == null)
                throw new ApiException(400, "Missing required parameter 'metricId' when calling GamificationApi->PutGamificationMetric");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PutGamificationMetric");
            

            var localVarPath = "/api/v2/gamification/metrics/{metricId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (metricId != null) localVarPathParams.Add("metricId", this.Configuration.ApiClient.ParameterToString(metricId));

            // Query params
            if (performanceProfileId != null) localVarQueryParams.Add(new Tuple<string, string>("performanceProfileId", this.Configuration.ApiClient.ParameterToString(performanceProfileId)));

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationMetric: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationMetric: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Metric>(localVarStatusCode,
                localVarHeaders,
                (Metric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Updates a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="body">performanceProfile (optional)</param>
        /// <returns>PerformanceProfile</returns>
        public PerformanceProfile PutGamificationProfile (string profileId, PerformanceProfile body = null)
        {
             ApiResponse<PerformanceProfile> localVarResponse = PutGamificationProfileWithHttpInfo(profileId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="body">performanceProfile (optional)</param>
        /// <returns>ApiResponse of PerformanceProfile</returns>
        public ApiResponse< PerformanceProfile > PutGamificationProfileWithHttpInfo (string profileId, PerformanceProfile body = null)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->PutGamificationProfile");

            var localVarPath = "/api/v2/gamification/profiles/{profileId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationProfile: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationProfile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerformanceProfile>(localVarStatusCode,
                localVarHeaders,
                (PerformanceProfile) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceProfile)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Updates a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="body">performanceProfile (optional)</param>
        /// <returns>Task of PerformanceProfile</returns>
        public async System.Threading.Tasks.Task<PerformanceProfile> PutGamificationProfileAsync (string profileId, PerformanceProfile body = null)
        {
             ApiResponse<PerformanceProfile> localVarResponse = await PutGamificationProfileAsyncWithHttpInfo(profileId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates a performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">performanceProfileId</param>
        /// <param name="body">performanceProfile (optional)</param>
        /// <returns>Task of ApiResponse (PerformanceProfile)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PerformanceProfile>> PutGamificationProfileAsyncWithHttpInfo (string profileId, PerformanceProfile body = null)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->PutGamificationProfile");
            

            var localVarPath = "/api/v2/gamification/profiles/{profileId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationProfile: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationProfile: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerformanceProfile>(localVarStatusCode,
                localVarHeaders,
                (PerformanceProfile) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceProfile)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Updates a metric in performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="body">Metric</param>
        /// <returns>Metric</returns>
        public Metric PutGamificationProfileMetric (string profileId, string metricId, CreateMetric body)
        {
             ApiResponse<Metric> localVarResponse = PutGamificationProfileMetricWithHttpInfo(profileId, metricId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates a metric in performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="body">Metric</param>
        /// <returns>ApiResponse of Metric</returns>
        public ApiResponse< Metric > PutGamificationProfileMetricWithHttpInfo (string profileId, string metricId, CreateMetric body)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->PutGamificationProfileMetric");
            // verify the required parameter 'metricId' is set
            if (metricId == null)
                throw new ApiException(400, "Missing required parameter 'metricId' when calling GamificationApi->PutGamificationProfileMetric");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PutGamificationProfileMetric");

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/metrics/{metricId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));
            if (metricId != null) localVarPathParams.Add("metricId", this.Configuration.ApiClient.ParameterToString(metricId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationProfileMetric: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationProfileMetric: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Metric>(localVarStatusCode,
                localVarHeaders,
                (Metric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Updates a metric in performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="body">Metric</param>
        /// <returns>Task of Metric</returns>
        public async System.Threading.Tasks.Task<Metric> PutGamificationProfileMetricAsync (string profileId, string metricId, CreateMetric body)
        {
             ApiResponse<Metric> localVarResponse = await PutGamificationProfileMetricAsyncWithHttpInfo(profileId, metricId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates a metric in performance profile 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="profileId">Performance Profile Id</param>
        /// <param name="metricId">Metric Id</param>
        /// <param name="body">Metric</param>
        /// <returns>Task of ApiResponse (Metric)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Metric>> PutGamificationProfileMetricAsyncWithHttpInfo (string profileId, string metricId, CreateMetric body)
        { 
            // verify the required parameter 'profileId' is set
            if (profileId == null)
                throw new ApiException(400, "Missing required parameter 'profileId' when calling GamificationApi->PutGamificationProfileMetric");
            
            // verify the required parameter 'metricId' is set
            if (metricId == null)
                throw new ApiException(400, "Missing required parameter 'metricId' when calling GamificationApi->PutGamificationProfileMetric");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling GamificationApi->PutGamificationProfileMetric");
            

            var localVarPath = "/api/v2/gamification/profiles/{profileId}/metrics/{metricId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params
            if (profileId != null) localVarPathParams.Add("profileId", this.Configuration.ApiClient.ParameterToString(profileId));
            if (metricId != null) localVarPathParams.Add("metricId", this.Configuration.ApiClient.ParameterToString(metricId));

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (body != null && body.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            else
                localVarPostBody = body; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationProfileMetric: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationProfileMetric: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Metric>(localVarStatusCode,
                localVarHeaders,
                (Metric) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Metric)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



        /// <summary>
        /// Update gamification activation status 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Gamification status</param>
        /// <returns>GamificationStatus</returns>
        public GamificationStatus PutGamificationStatus (GamificationStatus status)
        {
             ApiResponse<GamificationStatus> localVarResponse = PutGamificationStatusWithHttpInfo(status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update gamification activation status 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Gamification status</param>
        /// <returns>ApiResponse of GamificationStatus</returns>
        public ApiResponse< GamificationStatus > PutGamificationStatusWithHttpInfo (GamificationStatus status)
        { 
            // verify the required parameter 'status' is set
            if (status == null)
                throw new ApiException(400, "Missing required parameter 'status' when calling GamificationApi->PutGamificationStatus");

            var localVarPath = "/api/v2/gamification/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"
                

            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (status != null && status.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(status); // http body (model) parameter
            else
                localVarPostBody = status; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GamificationStatus>(localVarStatusCode,
                localVarHeaders,
                (GamificationStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GamificationStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }


        /// <summary>
        /// Update gamification activation status 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Gamification status</param>
        /// <returns>Task of GamificationStatus</returns>
        public async System.Threading.Tasks.Task<GamificationStatus> PutGamificationStatusAsync (GamificationStatus status)
        {
             ApiResponse<GamificationStatus> localVarResponse = await PutGamificationStatusAsyncWithHttpInfo(status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update gamification activation status 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="status">Gamification status</param>
        /// <returns>Task of ApiResponse (GamificationStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GamificationStatus>> PutGamificationStatusAsyncWithHttpInfo (GamificationStatus status)
        { 
            // verify the required parameter 'status' is set
            if (status == null)
                throw new ApiException(400, "Missing required parameter 'status' when calling GamificationApi->PutGamificationStatus");
            

            var localVarPath = "/api/v2/gamification/status";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<Tuple<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
                
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {

                "application/json"

                
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // Path params

            // Query params

            // Header params

            // Form params
            
            // Body param
            if (status != null && status.GetType() != typeof(byte[]))
                localVarPostBody = this.Configuration.ApiClient.Serialize(status); // http body (model) parameter
            else
                localVarPostBody = status; // byte array



            // authentication (PureCloud OAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationStatus: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutGamificationStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<GamificationStatus>(localVarStatusCode,
                localVarHeaders,
                (GamificationStatus) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GamificationStatus)),
                localVarResponse.Content,
                localVarResponse.StatusDescription);
        }



    }

}
