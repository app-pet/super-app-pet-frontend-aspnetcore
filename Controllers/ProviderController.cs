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
    public class ProviderController : Controller
    {
        private IConfiguration _configuration;

        public ProviderController(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        public async Task<IActionResult> Index(int? validation)
        {
            List<RootProviderObject> providerList = new List<RootProviderObject>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(_configuration["FIAP:ProviderAddress"]))
                {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    providerList.Add(JsonConvert.DeserializeObject<RootProviderObject>(apiResponse));
                }
            }

            if (validation == 1)
            {
                ViewData["Message"] = "The phone is not registered.";
            }

            return View(providerList[0].Docs);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(string services, string name, string email, string phone)
        {
            string[] myArray = services.Split(new char[] { ';' });

            ProviderDTO providerDTO = new ProviderDTO();
            providerDTO.Services = myArray;
            providerDTO.Email = email;
            providerDTO.Name = name;
            providerDTO.Phone = phone;

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(providerDTO), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync(_configuration["FIAP:ProviderAddress"], content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string phone)
        {
            ProviderModel providerModel = await getProviderAsync(phone);

            var aux = "";

            foreach (string values in providerModel.Services)
            {
                aux += values + ";";
            }

            ViewData["Aux"] = aux;

            return View(providerModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditProvider(string services, string name, string email, string phone)
        {
            string[] myArray = services.Split(new char[] { ';' });

            ProviderDTO providerDTO = new ProviderDTO();
            providerDTO.Services = myArray;
            providerDTO.Email = email;
            providerDTO.Name = name;
            providerDTO.Phone = phone;

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(providerDTO), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync(_configuration["FIAP:ProviderAddress"] + providerDTO.Phone, content))
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
                ProviderModel providerModel = await getProviderAsync(phone);
                ViewData["PhoneNumber"] = providerModel.Phone;

                return View(providerModel);
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
                using (var response = await httpClient.DeleteAsync(_configuration["FIAP:ProviderAddress"] + phoneDel))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("Index");
        }

        public async Task<ProviderModel> getProviderAsync(string phone)
        {
            ProviderModel provider = new ProviderModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(_configuration["FIAP:ProviderAddress"] + phone))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    provider = JsonConvert.DeserializeObject<ProviderModel>(apiResponse);
                }
            }

            return provider;
        }
    }
}