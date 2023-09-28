namespace uberBrackFast.Controllers

    [Route("[controller]")]
    public class uberBrackfast : Controller
    {
        private readonly ILogger<uberBrackfast> _logger;

        public uberBrackfast(ILogger<uberBrackfast> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
