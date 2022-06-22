// <copyright file="ITeamClient.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Api
{
    using System.Threading.Tasks;
    using BoldSign.Model;

    /// <summary>
    ///    Represents a collection of functions to interact with the API endpoints. The functions perform actions such as create a new team, update team name, get team details with its group members, and get list of teams in an organization.
    /// </summary>
    public interface ITeamClient : IApiAccessor
    {
        /// <summary>
        /// Get team Details for the given team Id.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="teamId">team Id.</param>
        /// <returns>TeamDetails.</returns>
        TeamDetails GetTeamDetails(string teamId);

        /// <summary>
        /// Get team Details for the given team Id.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="teamId">Team Id.</param>
        /// <returns>ApiResponse of TeamDetails.</returns>
        ApiResponse<TeamDetails> GetTeamDetailsWithHttpInfo(string teamId);

        /// <summary>
        /// Get team list.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="page">Page.</param>
        /// <param name="pageSize">page Size (optional, default to 10).</param>
        /// <returns>TeamDetails.</returns>
        TeamList ListTeam(int page, int? pageSize = default);

        /// <summary>
        /// Get team List.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="page">page.</param>
        /// <param name="pageSize">page Size (optional, default to 10).</param>
        /// <returns>ApiResponse of TeamListResponse.</returns>
        ApiResponse<TeamList> ListTeamWithHttpInfo(int page, int? pageSize = default);

        /// <summary>
        /// Creates a new Team.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="createTeam">create team.</param>
        /// <returns>CreateTeam.</returns>
        TeamCreated CreateTeam(CreateTeam createTeam);

        /// <summary>
        ///  Creates a new Team.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="createTeam">create team.</param>
        /// <returns>ApiResponse of CreateTeam.</returns>
        ApiResponse<TeamCreated> CreateTeamWithHttpInfo(CreateTeam createTeam);

        /// <summary>
        /// Updates team Name.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="updateTeam">update team.</param>
        void UpdateTeam(UpdateTeam updateTeam);

        /// <summary>
        /// Updates team Name.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="updateTeam">update team.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        ApiResponse<object> UpdateTeamWithHttpInfo(UpdateTeam updateTeam);

        /// <summary>
        /// Get team Details for the given team Id.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="teamId">team Id.</param>
        /// <returns>TeamDetails.</returns>
        Task<TeamDetails> GetTeamDetailsAsync(string teamId);

        /// <summary>
        /// Get team Details for the given team Id.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="teamId">Team Id.</param>
        /// <returns>ApiResponse of TeamDetails.</returns>
        Task<ApiResponse<TeamDetails>> GetTeamDetailsAsyncWithHttpInfo(string teamId);

        /// <summary>
        /// Get team List.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="page">page.</param>
        /// <param name="pageSize">page Size (optional, default to 10).</param>
        /// <returns>TeamList.</returns>
        Task<TeamList> ListTeamAsync(int page, int? pageSize = default);

        /// <summary>
        /// Get team List.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="page">page.</param>
        /// <param name="pageSize">page Size (optional, default to 10).</param>
        /// <returns>ApiResponse of TeamListResponse.</returns>
        Task<ApiResponse<TeamList>> ListTeamAsyncWithHttpInfo(int page, int? pageSize = default);

        /// <summary>
        ///  Creates a new Team.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="createTeam">crate team.</param>
        /// <returns>CreateTeam.</returns>
        Task<TeamCreated> CreateTeamAsync(CreateTeam createTeam);

        /// <summary>
        ///  Creates a new Team.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="createTeam">create team.</param>
        /// <returns>ApiResponse of CreateTeam.</returns>
        Task<ApiResponse<TeamCreated>> CreateTeamAsyncWithHttpInfo(CreateTeam createTeam);

        /// <summary>
        /// Updates team Name.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="updateTeam">update team.</param>
        /// <returns>UpdateTeamName.</returns>
        Task UpdateTeamAsync(UpdateTeam updateTeam);

        /// <summary>
        /// Updates team Name.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call.</exception>
        /// <param name="updateTeam">update team.</param>
        /// <returns>ApiResponse of Object(void).</returns>
        Task<ApiResponse<object>> UpdateTeamAsyncWithHttpInfo(UpdateTeam updateTeam);
    }
}
