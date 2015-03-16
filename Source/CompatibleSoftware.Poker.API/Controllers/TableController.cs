using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CompatibleSoftware.Poker.DAL.Adapters;
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
            : this(new TableService(new TableRepository()))
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
    }
}
