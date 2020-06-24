using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SuperAppPet.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SuperAppPet.Controllers
{
    public class UserController : Controller
    {
        private IConfiguration _configuration;

        public UserController(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        public async Task<IActionResult> Index(int? validation)
        {
            List<RootObject> userList = new List<RootObject>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(_configuration["FIAP:Address"]))
                {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    userList.Add(JsonConvert.DeserializeObject<RootObject>(apiResponse));
                }
            }

            if (validation == 1)
            {
                ViewData["Message"] = "The phone is not registered.";
            }

            return View(userList[0].Docs);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(string name, string email, string phone)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Email = email;
            userDTO.Name = name;
            userDTO.Phone = phone;

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(userDTO), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync(_configuration["FIAP:Address"], content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string phone)
        {
            UserModel userModel = await getUserAsync(phone);

            return View(userModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(string name, string email, string phone)
        {
            UserDTO userDTO = new UserDTO();
            userDTO.Email = email;
            userDTO.Name = name;
            userDTO.Phone = phone;

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(userDTO), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync(_configuration["FIAP:Address"] + userDTO.Phone, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Details(string phone)
        {
            try
            {
                UserModel userModel = await getUserAsync(phone);
                ViewData["PhoneNumber"] = userModel.Phone;

                return View(userModel);
            }
            catch
            {
                return RedirectToAction("Index", new { validation = 1 });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string phoneDel)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync(_configuration["FIAP:Address"] + phoneDel))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("Index");
        }

        public async Task<UserModel> getUserAsync(string phone)
        {
            UserModel user = new UserModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(_configuration["FIAP:Address"] + phone))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    user = JsonConvert.DeserializeObject<UserModel>(apiResponse);
                }
            }

            return user;
        }
    }
}