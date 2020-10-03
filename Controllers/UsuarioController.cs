using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetcore_dojo.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_dojo.Controllers
{
    [ApiController]
    [Route("[controller]")] // route
    public class UsuarioController: ControllerBase
    {
        FirebaseAccount Instancia = FirebaseAccount.Instancia;

        [HttpGet]
        public async Task<List<Usuario>> Get(){
            return await Instancia.GetUser();
        }

        [HttpPost]
        public async Task<String> Post(Usuario user){
            return await Instancia.AddUser(user);
        }

        [HttpDelete]
        public async Task<String> Delete([FromQuery]String id){
            return await Instancia.DeleteUser(id);
        }
    }
}