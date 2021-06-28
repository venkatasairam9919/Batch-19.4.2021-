﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCClient.Models;
using Newtonsoft.Json;

namespace MVCClient.Services
{
    public class UserService
    {
        public UserModel Validate(Login login)
        {
            UserModel userModel = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:10635/");
              
                var contentData = new StringContent(JsonConvert.SerializeObject(login),
                System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("api/Account/Login/",contentData).Result;
                userModel = JsonConvert.DeserializeObject<UserModel>(response.Content.ReadAsStringAsync().Result);
              
            }
            return userModel;
        }
        public User GetUserById(string Uid)
        {
            User user = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:10635/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType);
                client.DefaultRequestHeaders.Authorization =new AuthenticationHeaderValue("Bearer",Common.Token);
                HttpResponseMessage response = client.GetAsync("api/User/GetUserById/" + Uid).Result;
               user = JsonConvert.DeserializeObject<User>(response.Content.ReadAsStringAsync().Result);

            }
            return user;
        }
        public List<User> GetUsers()
        {
            List<User> users = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:10635/");
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(contentType); //setting content type
               client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Common.Token);
                HttpResponseMessage response = client.GetAsync("api/User/GetUsers").Result;
                users = JsonConvert.DeserializeObject<List<User>>(response.Content.ReadAsStringAsync().Result);

            }
            return users;
        }
    }
}
