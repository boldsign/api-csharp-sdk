namespace BoldSign.Examples
{
    using BoldSign.Api;
    using BoldSign.Model;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    ///     The team examples.
    /// </summary>
    public class TeamExamples
    {
        private readonly TeamClient TeamClient;

        /// <summary>
        ///     Initializes a new instance of the <see cref="TeamExamples" /> class.
        /// </summary>
        /// <param name="TeamClient">The team api.</param>
        public TeamExamples(TeamClient TeamClient) => this.TeamClient = TeamClient;

        /// <summary>
        ///     Gets the Team Details.
        /// </summary>
        /// <returns>A Team Response.</returns>
        public TeamDetails GetTeamDetails()
        {
            // This is an example team id, add your own team id upon usage.
            var teamId = "91e302a6-2eab-430b-9684-999b484aef2b";

            var teamDetails = this.TeamClient.GetTeamDetails(teamId);

            return teamDetails;
        }

        /// <summary>
        ///  Get the team list.
        /// </summary>
        /// <returns>A Team List Response.</returns>
        public TeamList List()
        {
            var teamListDetails = this.TeamClient.ListTeam(page: 1, pageSize: 1);

            return teamListDetails;
        }

        /// <summary>
        /// Creates a new team.
        /// </summary>
        /// <returns>A Created team.</returns>
        public TeamCreated Create()
        {
            var createTeam = new CreateTeam()
            {
                TeamName = "Team test1",
            };

            var create = this.TeamClient.CreateTeam(createTeam);

            return create;
        }

        /// <summary>
        /// Updates team Name.
        /// </summary>
        public void Update()
        {
            var updateTeam = new UpdateTeam()
            {
                // This is an example team id, add your own team id upon usage.
                TeamId = "bc51981f-5669-4cb2-95e0-f043e44366e2",
                TeamName = "Team test1",
            };

            this.TeamClient.UpdateTeam(updateTeam);
        }
    }
}