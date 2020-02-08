using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RitoAPI.Models;

namespace SummonerStratz.Controllers
{
    public class ChampionController : Controller
    {
        public async Task<IActionResult> ChampionList()
        {
            string apiResponse;
            using (HttpClient httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://ddragon.leagueoflegends.com/cdn/10.3.1/data/en_US/champion.json"))
                {
                    apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            var result = JsonConvert.DeserializeObject<ChampionList>(apiResponse);

            return View(result);
        }

        public async Task<IActionResult> showChampion(String id)
        {
            string apiResponse;
            using (HttpClient httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://ddragon.leagueoflegends.com/cdn/10.3.1/data/en_US/champion/" + id + ".json"))
                {
                    apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            var result = JsonConvert.DeserializeObject<Champion>(apiResponse);

            return View(result);
        }
    }
}