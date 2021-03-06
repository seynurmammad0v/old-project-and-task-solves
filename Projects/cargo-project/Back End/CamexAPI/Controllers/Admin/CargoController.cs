using BackProject.Extentions;
using Business.Abstract;
using CamexAPI.Identity;
using CamexAPI.Models;
using Entity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CamexAPI.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CargoController : ControllerBase
    {
        private readonly ICargoService _cargoContext;
        private readonly IStatusService _statusContext;
        private readonly IWebHostEnvironment _env;
        private readonly MyIdentityDbContext _user;
        public CargoController(ICargoService cargoContext
            , MyIdentityDbContext user, IStatusService statusContext, IWebHostEnvironment env)
        {
            _cargoContext = cargoContext;
            _statusContext = statusContext;
            _env = env;
            _user = user;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                List<Cargo> cargos = _cargoContext.GetAllActive(id);
                return Ok(cargos);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
        [HttpGet("{str}/{id}")]
        public IActionResult GetUserData(string str,int id)
        {
            try
            {
                AppUser user = _user.Users.Where(u => u.CamexId ==id).FirstOrDefault();
                List<Cargo> cargos = _cargoContext.GetAllActiveUserParcels(user.Id, str);

                return Ok(cargos);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("info/{id}")]
        public IActionResult Info(int id)
        {
            try
            {
                Cargo cargo = _cargoContext.GetWithIdInclude(id);
                AppUser user = _user.Users.Where(u => u.Id == cargo.UserId).FirstOrDefault();
                cargo.CamexId = user.CamexId;
                if (cargo == null) return StatusCode(StatusCodes.Status500InternalServerError, new Response
                {
                    Status = "Error",
                    Messages = new Message[] {
                            new Message {
                                Lang_id = 1,
                                MessageLang="Model state isn't valid!"
                            },
                            new Message {
                                Lang_id = 2,
                                MessageLang="Состояние модели недействительно!"
                            },
                            new Message {
                                Lang_id = 3,
                                MessageLang="Model vəziyyəti etibarsızdır!"
                            }
                        }
                });
                return Ok(cargo);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] Cargo cargo)
        {
            try
            {
                AppUser user;
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response
                    {
                        Status = "Error",
                        Messages = new Message[] {
                            new Message {
                                Lang_id = 1,
                                MessageLang="Model state isn't valid!"
                            },
                            new Message {
                                Lang_id = 2,
                                MessageLang="Состояние модели недействительно!"
                            },
                            new Message {
                                Lang_id = 3,
                                MessageLang="Model vəziyyəti etibarsızdır!"
                            }
                        }
                    });
                }
                if (cargo.UserId != null)
                {
                     user = _user.Users.Where(u => u.Id == cargo.UserId).FirstOrDefault();
                    if (user == null) return StatusCode(StatusCodes.Status500InternalServerError, new Response
                    {
                        Status = "Error",
                        Messages = new Message[] {
                            new Message {
                                Lang_id = 1,
                                MessageLang="Model state isn't valid!"
                            },
                            new Message {
                                Lang_id = 2,
                                MessageLang="Состояние модели недействительно!"
                            },
                            new Message {
                                Lang_id = 3,
                                MessageLang="Model vəziyyəti etibarsızdır!"
                            }
                        }
                    });
                }
                else
                {
                     user = _user.Users.Where(u => u.CamexId == cargo.CamexId).FirstOrDefault();
                    if (user == null) return StatusCode(StatusCodes.Status500InternalServerError, new Response
                    {
                        Status = "Error",
                        Messages = new Message[] {
                            new Message {
                                Lang_id = 1,
                                MessageLang="Model state isn't valid!"
                            },
                            new Message {
                                Lang_id = 2,
                                MessageLang="Состояние модели недействительно!"
                            },
                            new Message {
                                Lang_id = 3,
                                MessageLang="Model vəziyyəti etibarsızdır!"
                            }
                        }
                    });
                }
                if (cargo.Photo!=null)
                {
                    ValidateModel res = cargo.Photo.PhotoValidate();
                    if (!res.Success) return StatusCode(StatusCodes.Status500InternalServerError, res.Response);
                    string folder = Path.Combine("Site", "images", "statements");
                    string fileName = await cargo.Photo.SaveImage(_env.WebRootPath, folder);
                    cargo.Image = fileName;
                    cargo.StatusId = _statusContext.GetWithStatement("InAnbar").Id;
                }
                else
                {
                    cargo.StatusId = _statusContext.GetWithStatement("WaitingInvoice").Id;
                }
                cargo.IsActived = true;
                cargo.OfficeId = user.OfficeId;
                cargo.UserId = user.Id;
                cargo.TrackCamex = Guid.NewGuid().ToString() + user.CamexId;
            

                _cargoContext.Add(cargo);

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // PUT api/<CountryController>/5
        [HttpPut("{id}")]
        public IActionResult PutAsync(int id, [FromForm] Cargo cargo)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response
                    {
                        Status = "Error",
                        Messages = new Message[] {
                            new Message {
                                Lang_id = 1,
                                MessageLang="Model state isn't valid!"
                            },
                            new Message {
                                Lang_id = 2,
                                MessageLang="Состояние модели недействительно!"
                            },
                            new Message {
                                Lang_id = 3,
                                MessageLang="Model vəziyyəti etibarsızdır!"
                            }
                        }
                    });
                }
                Cargo db_cargo = _cargoContext.GetWithId(id);
                if (db_cargo == null)
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response
                    {
                        Status = "Error",
                        Messages = new Message[] {
                            new Message {
                                Lang_id = 1,
                                MessageLang="Model state isn't valid!"
                            },
                            new Message {
                                Lang_id = 2,
                                MessageLang="Состояние модели недействительно!"
                            },
                            new Message {
                                Lang_id = 3,
                                MessageLang="Model vəziyyəti etibarsızdır!"
                            }
                        }
                    });

                db_cargo.Track = cargo.Track;
                db_cargo.Name = cargo.Name;
                db_cargo.ProductId = cargo.ProductId;
                db_cargo.Price = cargo.Price;
                db_cargo.CountryId = cargo.CountryId;
                db_cargo.Count = cargo.Count;
                db_cargo.Notice = cargo.Notice;
                db_cargo.Weight = cargo.Weight;
                db_cargo.CamexPrice = cargo.CamexPrice;
                db_cargo.StatusId = _statusContext.GetWithStatement("InAnbar").Id;
                db_cargo.ModifiedDate = DateTime.Now;
                _cargoContext.Update(db_cargo);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

    }
}
