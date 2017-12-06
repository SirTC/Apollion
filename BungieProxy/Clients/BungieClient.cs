﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;


namespace BungieProxy.Clients
{
    public class getClanStats {
        static void tester()
        {
            // Uses JSON.NET - http://www.nuget.org/packages/Newtonsoft.Json
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-Key", "YOUR-API-KEY-HERE");

                var response = client.GetAsync("https://www.bungie.net/platform/Destiny/Manifest/InventoryItem/1274330687/").Result;
                var content = response.Content.ReadAsStringAsync().Result;
                dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                Console.WriteLine(item.Response.data.inventoryItem.itemName); //Gjallarhorn
            }
        }
    }
    
    

}

   
