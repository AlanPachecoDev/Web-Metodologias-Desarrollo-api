﻿using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Web;

using static System.Net.WebRequestMethods;

namespace API_Auth.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {



        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }
        //http://apiservicios.ecuasolmovsa.com:3009/api/Usuarios?usuario=5001&password=5001u
        [HttpGet(Name = "getUser")]

        public async Task<string> Get(string usuario, string password)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Usuarios?usuario=" + usuario + "&password=" + password;

                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("Emisores")]

        public async Task<string> Get()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/GetEmisor";

                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("Costos")]

        public async Task<string> GetEmisores()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/CentroCostosSelect";

                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("DeleteCentroDeCosto")]

        public async Task<string> DeleteCentroDeCostos(int codigoCentroCostos, String descripcioncentrocostos)
        {
            Console.WriteLine("Entra a Eliminar");
            Console.WriteLine("codigoCentroCostos: ", codigoCentroCostos, " | descripcioncentrocostos: ", descripcioncentrocostos);
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/CentroCostosDelete?codigocentrocostos=" + codigoCentroCostos + "&descripcioncentrocostos=" + descripcioncentrocostos;


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }



        [HttpGet("UpdateCentroDeCosto")]

        public async Task<string> UpdateCentroDeCostos(String codigoCentroCostos, String descripcioncentrocostos)
        {
            Console.WriteLine("codigoCentroCostos: ", codigoCentroCostos, " | descripcioncentrocostos: ", descripcioncentrocostos);
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/CentroCostosUpdate?codigocentrocostos=" + codigoCentroCostos + "&descripcioncentrocostos=" + descripcioncentrocostos;


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }


        [HttpGet("CreateCentroDeCosto")]

        public async Task<string> CreateCentroDeCostos(String codigoCentroCostos, String descripcioncentrocostos)
        {
            Console.WriteLine("codigoCentroCostos: ", codigoCentroCostos, " | descripcioncentrocostos: ", descripcioncentrocostos);

            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/CentroCostosInsert?codigocentrocostos=" + codigoCentroCostos + "&descripcioncentrocostos=" + descripcioncentrocostos;


                    HttpResponseMessage response = await httpClient.PostAsync(url, null);

                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("error: " + error);
            }
        }

        //36



        [HttpGet("SearchCentroDeCosto")]

        public async Task<string> SearchCentroDeCostos(String descripcioncentrocostos)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/CentroCostosSearch?descripcioncentrocostos=" + descripcioncentrocostos;


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }


        // ACTUALIZACION DE APIS
        [HttpGet("ListarPlanillas")]

        public async Task<string> GetPlanillas()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/MovimientoPlanillaSelect";

                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("DeleteMovimientoPlanilla")]
        public async Task<string> DeleteMovimientoPlanilla(int codigoMovimiento, string descripcionMovimiento)
        {
            Console.WriteLine("Entra a Eliminar Planilla");
            Console.WriteLine("codigoMovimiento: " + codigoMovimiento + " | descripcionMovimiento: " + descripcionMovimiento);
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var baseUrl = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios";
                    var endpoint = "/MovimeintoPlanillaDelete";
                    var queryParams = $"?codigomovimiento={codigoMovimiento}&descripcionomovimiento={descripcionMovimiento}";
                    var url = baseUrl + endpoint + queryParams;

                    // Agrega los encabezados necesarios si la API los requiere
                    // httpClient.DefaultRequestHeaders.Add("NombreEncabezado", "ValorEncabezado");

                    // Configura la autenticación si es necesario
                    // httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("TipoAutenticacion", "Token");
                    Console.WriteLine("URL DELETE: ", url);
                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("TipoOperacion")]

        public async Task<string> GetTipoOperacion()
        {
            Console.WriteLine("GetTipoOperacion()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/TipoOperacion";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }



        [HttpGet("SearchMovimientoPlanilla")]

        public async Task<string> SearchMovimientoPlanilla(String concepto)
        {
            Console.WriteLine("SearchMovimientoPlanilla");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/MovimientoPlanillaSearch?Concepto=" + concepto;


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("CreateMovimientoPlanilla")]

        public async Task<string> CreateMovimientoPlanilla(String concepto, int prioridad, String tipoOperacion, String c1, String c2, String c3, String c4, String me1, String me2, String me3, String Traba_Aplica_iess, String Traba_Proyecto_imp_renta, String Aplica_Proy_Renta, String Empresa_Afecta_Iess)
        {
            Console.WriteLine("CreateMovimientoPlanilla");
            try
            {
                Console.WriteLine("Traba_Aplica_iess, Traba_Proyecto_imp_renta, Aplica_Proy_Renta, Empresa_Afecta_Iess: ", Traba_Aplica_iess, Traba_Proyecto_imp_renta, Aplica_Proy_Renta, Empresa_Afecta_Iess);
                using (var httpClient = new HttpClient())
                {
                    String url1 = "hola";

                    url1 = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/MovimientoPlanillaInsert?conceptos=" + concepto + "&prioridad=" + prioridad + "&tipooperacion=" + tipoOperacion + "&cuenta1=" + c1 + "&cuenta2=" + c2 + "&cuenta3=" + c3 + "&cuenta4=" + c4 + "&MovimientoExcepcion1=" + me1 + "&MovimientoExcepcion2=" + me2 + "&MovimientoExcepcion3=" + me3 + "&Traba_Aplica_iess=" + Traba_Aplica_iess + "&Traba_Proyecto_imp_renta=" + Traba_Proyecto_imp_renta + "&Aplica_Proy_Renta=" + Aplica_Proy_Renta + "&Empresa_Afecta_Iess=" + Empresa_Afecta_Iess;


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.PostAsync(url1, null);

                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }


        [HttpGet("UpdateMovimientoPlanilla")]

        public async Task<string> UpdateMovimientoPlanilla(String codigo, String concepto, int prioridad, String tipoOperacion, String c1, String c2, String c3, String c4, String me1, String me2, String me3, String Traba_Aplica_iess, String Traba_Proyecto_imp_renta, String Aplica_Proy_Renta, String Empresa_Afecta_Iess)
        {
            Console.WriteLine("UpdateMovimientoPlanilla");
            try
            {
                Console.WriteLine("Traba_Aplica_iess, Traba_Proyecto_imp_renta, Aplica_Proy_Renta, Empresa_Afecta_Iess: ", Traba_Aplica_iess, Traba_Proyecto_imp_renta, Aplica_Proy_Renta, Empresa_Afecta_Iess);
                using (var httpClient = new HttpClient())
                {
                    String url1 = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/MovimientoPlanillaUpdate?codigoplanilla=" + codigo + "&conceptos=" + concepto + "&prioridad=" + prioridad + "&tipooperacion=" + tipoOperacion + "&cuenta1=" + c1 + "&cuenta2=" + c2 + "&cuenta3=" + c3 + "&cuenta4=" + c4 + "&MovimientoExcepcion1=" + me1 + "&MovimientoExcepcion2=" + me2 + "&MovimientoExcepcion3=" + me3 + "&Traba_Aplica_iess=" + Traba_Aplica_iess + "&Traba_Proyecto_imp_renta=" + Traba_Proyecto_imp_renta + "&Aplica_Proy_Renta=" + Aplica_Proy_Renta + "&Empresa_Afecta_Iess=" + Empresa_Afecta_Iess;

                    // Hacer una petición GET a la URL y esperar la respuesta
                    Console.Write("URL: ", url1);
                    HttpResponseMessage response = await httpClient.GetAsync(url1);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine("UPDATE MP result");
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }


        // ACTUALIZACION DE APIS
        [HttpGet("ListarTrabajadores")]

        public async Task<string> GetTrabajador(String sucursal)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {

                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/TrabajadorSelect?sucursal=" + sucursal;

                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola

                    Console.WriteLine("trabajadores");
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }


        [HttpGet("MovimientosExcepcion12")]

        public async Task<string> GetMovimientosExcepcion12()
        {
            Console.WriteLine("MovimientosExcepcion12()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/MovimientosExcepcion1y2";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("MovimientosExcepcion3")]

        public async Task<string> GetMovimientosExcepcion3()
        {
            Console.WriteLine("MovimientosExcepcion3()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/MovimientosExcepcion3";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("TrabaAfectaIESS")]

        public async Task<string> GetTrabaAfectaIESS()
        {
            Console.WriteLine("GetTrabaAfectaIESS()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/TrabaAfectaIESS";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("TrabAfecImpuestoRenta")]

        public async Task<string> GetTrabAfecImpuestoRenta()
        {
            Console.WriteLine("GetTrabAfecImpuestoRenta()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/TrabAfecImpuestoRenta";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("GetTrabajadorPorEmisor")]
        public async Task<string> Get(string codigo)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/TrabajadorSelect?sucursal=" + codigo;

                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }


        // Trabajadores

        [HttpGet("DeleteTrabajador")]

        public async Task<string> DeleteTrabajador(String sucursal, String codigoEmpleado)
        {

            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/TrabajadorDelete?sucursal=" + sucursal + "&codigoempleado=" + codigoEmpleado;

                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("TipoTrabajador")]

        public async Task<string> GetTipoTrabajador()
        {
            Console.WriteLine("GetTipoTrabajador()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/TipoTrabajador";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("Generos")]

        public async Task<string> GetGeneros()
        {
            Console.WriteLine("GetGeneros()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/Genero";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("EstadoTrabajador")]

        public async Task<string> GetEstadoTrabajador()
        {
            Console.WriteLine("GetEstadoTrabajador()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/EstadoTrabajador";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("EstadoCivil")]

        public async Task<string> GetEstadoCivil()
        {
            Console.WriteLine("GetEstadoCivil()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/EstadoCivil";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("TipoCese")]

        public async Task<string> GetTipoCese()
        {
            Console.WriteLine("GetTipoCese()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/TipoCese";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("TipoContrato")]

        public async Task<string> GetTipoContrato()
        {
            Console.WriteLine("GetTipoContrato()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/TipoContrato";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("TipoComision")]

        public async Task<string> GetTipoComision()
        {
            Console.WriteLine("GetTipoComision()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/TipoComision";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("TipoVacacion")]

        public async Task<string> GetTipoVacacion()
        {
            Console.WriteLine("GetTipoVacacion()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/PeriodoVacaciones";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("EsReingreso")]

        public async Task<string> GetEsReingreso()
        {
            Console.WriteLine("GetEsReingreso()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/EsReingreso";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }
        [HttpGet("TipoCuenta")]

        public async Task<string> GetTipoCuenta()
        {
            Console.WriteLine("GetTipoCuenta()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/TipoCuenta";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        public class TrabajadorModel
        {
            public int COMP_Codigo { get; set; }
            public string Tipo_trabajador { get; set; }
            public string Apellido_Paterno { get; set; }
            public string Apellido_Materno { get; set; }
            public string Nombres { get; set; }
            public string Identificacion { get; set; }
            public string Entidad_Bancaria { get; set; }
            public string CarnetIESS { get; set; }
            public string Direccion { get; set; }
            public string Telefono_Fijo { get; set; }
            public string Telefono_Movil { get; set; }
            public string Genero { get; set; }
            public string Nro_Cuenta_Bancaria { get; set; }
            public int Codigo_Categoria_Ocupacion { get; set; }
            public int Ocupacion { get; set; }
            public int Centro_Costos { get; set; }
            public string Nivel_Salarial { get; set; }
            public string EstadoTrabajador { get; set; }
            public string Tipo_Contrato { get; set; }
            public string Tipo_Cese { get; set; }
            public string EstadoCivil { get; set; }
            public string TipodeComision { get; set; }
            public string FechaNacimiento { get; set; }
            public string FechaIngreso { get; set; }
            public string FechaCese { get; set; }
            public string FechaReingreso { get; set; }
            public string Fecha_Ult_Actualizacion { get; set; }
            public string EsReingreso { get; set; }
            public string Tipo_Cuenta { get; set; }
            public int FormaCalculo13ro { get; set; }
            public int FormaCalculo14ro { get; set; }
            public int BoniComplementaria { get; set; }
            public int BoniEspecial { get; set; }
            public int Remuneracion_Minima { get; set; }
            public string Fondo_Reserva { get; set; }
        }

        [HttpPost("CreateTrabajador")]

        //36
        public async Task<string> CreateTrabajador([FromBody] TrabajadorModel trabajador)
        {


            try
            {
                using (var httpClient = new HttpClient())
                {
                    var baseUrl = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/TrabajadorInsert";
                    var queryParams = $"COMP_Codigo={trabajador.COMP_Codigo}&Tipo_trabajador={trabajador.Tipo_trabajador}&Apellido_Paterno={trabajador.Apellido_Paterno}&Apellido_Materno={trabajador.Apellido_Materno}&Nombres={trabajador.Nombres}&Identificacion={trabajador.Identificacion}&Entidad_Bancaria={trabajador.Entidad_Bancaria}&CarnetIESS={trabajador.CarnetIESS}&Direccion={trabajador.Direccion}&Telefono_Fijo={trabajador.Telefono_Fijo}&Telefono_Movil={trabajador.Telefono_Movil}&Genero={trabajador.Genero}&Nro_Cuenta_Bancaria={trabajador.Nro_Cuenta_Bancaria}&Codigo_Categoria_Ocupacion={trabajador.Codigo_Categoria_Ocupacion}&Ocupacion={trabajador.Ocupacion}&Centro_Costos={trabajador.Centro_Costos}&Nivel_Salarial={trabajador.Nivel_Salarial}&EstadoTrabajador={trabajador.EstadoTrabajador}&Tipo_Contrato={trabajador.Tipo_Contrato}&Tipo_Cese={trabajador.Tipo_Cese}&EstadoCivil={trabajador.EstadoCivil}&TipodeComision={trabajador.TipodeComision}&FechaNacimiento={trabajador.FechaNacimiento}&FechaIngreso={trabajador.FechaIngreso}&FechaCese={trabajador.FechaCese}&FechaReingreso={trabajador.FechaReingreso}&Fecha_Ult_Actualizacion={trabajador.Fecha_Ult_Actualizacion}&EsReingreso={trabajador.EsReingreso}&Tipo_Cuenta={trabajador.Tipo_Cuenta}&FormaCalculo13ro={trabajador.FormaCalculo13ro}&FormaCalculo14ro={trabajador.FormaCalculo14ro}&BoniComplementaria={trabajador.BoniComplementaria}&BoniEspecial={trabajador.BoniEspecial}&Remuneracion_Minima={trabajador.Remuneracion_Minima}&Fondo_Reserva={trabajador.Fondo_Reserva}";

                    var url = $"{baseUrl}?{queryParams}";
                    Console.WriteLine("agregar trabajardor url: {0}"+ url);
                    HttpResponseMessage response = await httpClient.PostAsync(url, null);

                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("error: " + error);
            }
        }


        [HttpGet("Ocupaciones")]

        public async Task<string> GetOcupaciones()
        {
            Console.WriteLine("GetOcupaciones()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/Ocupaciones";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("CategoriaOcupacional")]

        public async Task<string> GetCategoriaOcupacional()
        {
            Console.WriteLine("GetCategoriaOcupacional()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/CategoriaOcupacional";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("NivelSalarial")]

        public async Task<string> GetNivelSalarial()
        {
            Console.WriteLine("GetNivelSalarial()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/NivelSalarial";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("PlanDeCuentas")]

        public async Task<string> GetPlanDeCuentas()
        {
            Console.WriteLine("GetPlanDeCuentas()");
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/PlandeCuentas";


                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }


        [HttpGet("GestionCuentaContable")]

        public async Task<string> GetGestionCuentaContable(String sucursal)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {

                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/Gestion_Cuenta_Contable_Nomina_Select?Sucursal=" + sucursal;

                    // Hacer una petición GET a la URL y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Leer el contenido de la respuesta como una cadena de caracteres
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Mostrar el cuerpo de la respuesta en la consola

                    Console.WriteLine("GestionCuentasContables");
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                //return "Holi";
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("CreateGestionCuentaContable")]

        public async Task<string> CreateGestionCuentaContable(String Sucursal, String CodigoConceptoNomina, String CodigoCategoOcupacional, String CodigoOperacion, String CodigoCuenta, String CodigoTipoCuenta)
        {

            try
            {
                using (var httpClient = new HttpClient())
                {

                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/GestionContableNominaInsert?Sucursal=" + Sucursal + "&CodigoConceptoNomina=" + CodigoConceptoNomina + "&CodigoCategoOcupacional=" + CodigoCategoOcupacional + "&CodigoOperacion=" + CodigoOperacion + "&CodigoCuenta=" + CodigoCuenta + "&CodigoTipocuenta=" + CodigoTipoCuenta;
                    Console.WriteLine("GCC url: " + url);

                    HttpResponseMessage response = await httpClient.PostAsync(url, null);

                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine("GCC: " + responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("error: " + error);
            }
        }

        [HttpGet("DeleteGestionCuentaContable")]
        public async Task<string> DeleteGestionCuentaContable(String Sucursal, String CodigoConceptoNomina, String CodigoCategoOcupacional, String CodigoOperacion, String CodigoCuenta, String CodigoTipoCuenta)
        {
            Console.WriteLine("Sucursal: " + Sucursal + " | CodigoConceptoNomina: " + CodigoConceptoNomina + " | CodigoCategoOcupacional: " + CodigoCategoOcupacional + " | CodigoOperacion: " + CodigoOperacion + " | CodigoCuenta: " + CodigoCuenta + " | CodigoTipoCuenta: " + CodigoTipoCuenta);
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/GestionContableNominaDelete" + $"?Sucursal={Sucursal}&CodigoConceptoNomina={CodigoConceptoNomina}&CodigoCategoOcupacional={CodigoCategoOcupacional}&CodigoOperacion={CodigoOperacion}&CodigoCuenta={CodigoCuenta}&CodigoTipocuenta={CodigoTipoCuenta}";


                    // Agrega los encabezados necesarios si la API los requiere
                    // httpClient.DefaultRequestHeaders.Add("NombreEncabezado", "ValorEncabezado");

                    // Configura la autenticación si es necesario
                    // httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("TipoAutenticacion", "Token");
                    Console.WriteLine("URL DELETE: " + url);
                    // // Hacer una petición GET a la URL y esperar la respuesta
                    // HttpResponseMessage response = await httpClient.GetAsync(url);

                    // // Leer el contenido de la respuesta como una cadena de caracteres
                    // string responseBody = await response.Content.ReadAsStringAsync();

                    // // Mostrar el cuerpo de la respuesta en la consola
                    // Console.WriteLine(responseBody);
                    // return responseBody;


                    //------
                    HttpResponseMessage response = await httpClient.PostAsync(url, null);

                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine("GCC: " + responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }

        [HttpGet("EditGestionCuentaContable")]
        public async Task<string> EditGestionCuentaContable(String Sucursal, String CodigoConceptoNomina, String CodigoCategoOcupacional, String CodigoOperacion, String CodigoCuenta, String CodigoTipoCuenta)
        {
            Console.WriteLine("Sucursal: " + Sucursal + " | CodigoConceptoNomina: " + CodigoConceptoNomina + " | CodigoCategoOcupacional: " + CodigoCategoOcupacional + " | CodigoOperacion: " + CodigoOperacion + " | CodigoCuenta: " + CodigoCuenta + " | CodigoTipoCuenta: " + CodigoTipoCuenta);
            try
            {
                using (var httpClient = new HttpClient())
                {
        
                    var url = "http://apiservicios.ecuasolmovsa.com:3009/api/Varios/GestionContableNominaSearch" + $"?Sucursal={Sucursal}&CodigoConceptoNomina={CodigoConceptoNomina}&CodigoCategoOcupacional={CodigoCategoOcupacional}&CodigoOperacion={CodigoOperacion}&CodigoCuenta={CodigoCuenta}&CodigoTipocuenta={CodigoTipoCuenta}";


                    // Agrega los encabezados necesarios si la API los requiere
                    // httpClient.DefaultRequestHeaders.Add("NombreEncabezado", "ValorEncabezado");

                    // Configura la autenticación si es necesario
                    // httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("TipoAutenticacion", "Token");
                    Console.WriteLine("URL EditGestionCuentaContable: " + url);
                    // // Hacer una petición GET a la URL y esperar la respuesta
                    // HttpResponseMessage response = await httpClient.GetAsync(url);

                    // // Leer el contenido de la respuesta como una cadena de caracteres
                    // string responseBody = await response.Content.ReadAsStringAsync();

                    // // Mostrar el cuerpo de la respuesta en la consola
                    // Console.WriteLine(responseBody);
                    // return responseBody;


                    //------
                    HttpResponseMessage response = await httpClient.PostAsync(url, null);

                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine("GCC: " + responseBody);
                    return responseBody;
                }
            }
            catch (Exception error)
            {
                return ("erooor: " + error);
            }
        }
    }

}
