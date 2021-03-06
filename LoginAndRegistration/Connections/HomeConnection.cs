public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost("create/product")]
    public IActionResult CreateProduct(IndexViewModel modelData)
    {
        // To get the submitted Product from the submission, 
        // we would just need to grab "NewProduct" from the modelData object
        Product submittedProduct = modelData.NewProduct;
        if(ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View("Index");
    }
    [HttpPost("create/user")]
    public IActionResult CreateUser(IndexViewModel modelData)
    {
        // To get the submitted User from the submission, 
        // we would just need to grab "NewUser" from the modelData object
        User submittedUser = modelData.NewUser;
        if(ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View("Index");
    }
    [HttpGet("success")]
    public string Success()
    {
        return "You have successfully submitted!";
    }
}