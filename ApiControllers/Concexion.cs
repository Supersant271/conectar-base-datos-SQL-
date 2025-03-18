using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("Conexion")]
public class Conezion : Controller {
    [HttpGet("sql")]
    public  IActionResult ListarCarrerasql(){
        return OK ("Me estoy conectando a SQL server");
    }
    
    [HttpGet("mongo")]
    public IActionResult ListarSalonesMongob(){
        return OK ("Me estoy conectando a MongoDb");
    }
}
