using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CompatibleSoftware.Poker.DAL.Adapters;
using CompatibleSoftware.Poker.Ports.Command;
using CompatibleSoftware.Poker.Ports.Services;

namespace CompatibleSoftware.Poker.API.Controllers
{
    public class PlayerController : ApiController
    {
        /// <summary>
        /// The injected table service to delegate work to
        /// </summary>
        private readonly IPlayerService _playerService;

        /// <summary>
        /// Using poor mans DI for now but will be replaced at a later date
        /// </summary>
        public PlayerController()
            : this(new PlayerService(new PlayerRepository()))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerController"/> 
        /// and takes in the service instance to use
        /// </summary>
        /// <param name="playerService">The player service which will handle all the real work</param>
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        /// <summary>
        /// Get a list of all currently registered players
        /// </summary>
        /// <returns>A list of players</returns>
        [Route("players")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var players = _playerService.GetAllCurrentPlayers();

                return Request.CreateResponse(HttpStatusCode.OK, players);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Creates a new player
        /// </summary>
        /// <returns>The newly created player</returns>
        [Route("players")]
        [HttpPost]
        public HttpResponseMessage Create(CreatePlayerCommand createPlayerCommand)
        {
            try
            {
                var player = _playerService.CreatePlayer(createPlayerCommand);

                return Request.CreateResponse(HttpStatusCode.Created, player);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
