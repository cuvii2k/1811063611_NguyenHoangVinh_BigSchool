using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace _1811063611_NguyenHoangVinh_BigSchool.Controllers
{
    public class WebAPIController : ApiController
    {
        
            // GET api/<controller>   : url to use => api/vs
            public string Get()
            {
                return "Hi from web api controller";
            }

            // GET api/<controller>/5   : url to use => api/vs/5
            public string Get(int id)
            {
                return (id + 1).ToString();
            }
        }
    }