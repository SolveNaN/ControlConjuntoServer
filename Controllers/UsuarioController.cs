﻿using ControlConjuntoServer.Server.Data;
using ControlConjuntoServer.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControlConjuntoServer.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UsuarioController(ApplicationDbContext context)
        {

            _context = context;
        }

        [HttpGet]
        [Route("ConexionDB")]
        public async Task<ActionResult<string>> GetConexionDB()
        {
            try
            {
                var usuarios = await _context.Usuarios.ToListAsync();
                return "Buena Calidad";

            }
            catch (Exception ex)
            {
                return "Mala calidad";
            }
        }

        [HttpGet("Datos")]
        public async Task<ActionResult<List<Usuario>>> GetCuenta()
        {
            var lista = await _context.Usuarios.ToListAsync();
            return Ok(lista);
        }
    }
}