using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CompatibleSoftware.Poker.DAL.Adapters;
using CompatibleSoftware.Poker.Ports.Command;
using CompatibleSoftware.Poker.Ports.Repositories;
using CompatibleSoftware.Poker.Ports.Services;

namespace CompatibleSoftware.Poker.API.Controllers
{
    /// <summary>
    /// Controller for dealing with poker tables
    /// </summary>
    public class TableController : ApiController
    {
        /// <summary>
        /// The injected table service to delegate work to
        /// </summary>
        private readonly ITableService _tableService;

        /// <summary>
        /// Using poor mans DI for now but will be replaced at a later date
        /// </summary>
        public TableController()
            : this(new TableService(new TableRepository(), new JoinRequestRepository()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableController"/> 
        /// and takes in the service instance to use
        /// </summary>
        /// <param name="tableService">The service that will be used for doing the real work</param>
        public TableController(ITableService tableService)
        {
            _tableService = tableService;
        }

        /// <summary>
        /// Get a list of all currently active Poker Tables
        /// </summary>
        /// <returns>A list of Poker Tables</returns>
        [Route("tables")]
        public HttpResponseMessage Get()
        {
            try
            {
                var tables = _tableService.GetAllActiveTables();

                return Request.CreateResponse(HttpStatusCode.OK, tables);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Creates a new table
        /// </summary>
        /// <returns>The newly created table</returns>
        [Route("tables")]
        [HttpPost]
        public HttpResponseMessage Create(CreateTableCommand createTableCommand)
        {
            try
            {
                var table = _tableService.CreateTable(createTableCommand);

                return Request.CreateResponse(HttpStatusCode.Created, table);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Gets a list of players at the table
        /// </summary>
        /// <returns>A list of players</returns>
        [Route("tables/{tableId}/players")]
        [HttpGet]
        public HttpResponseMessage GetPlayersAtTable(int tableId)
        {
            try
            {
                var players = _tableService.GetTablePlayers(tableId);

                return Request.CreateResponse(HttpStatusCode.OK, players);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Controller action that is fired when a player asks to join a table
        /// </summary>
        /// <param name="joinTableCommand">The command to execute</param>
        /// <returns>A newly created request resource</returns>
        [Route("joinrequest")]
        [HttpPost]
        public HttpResponseMessage PlayerRequestToJoinTable(JoinTableCommand joinTableCommand)
        {
            try
            {
                var joinRequest = _tableService.JoinTable(joinTableCommand);

                return Request.CreateResponse(HttpStatusCode.OK, joinRequest);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
