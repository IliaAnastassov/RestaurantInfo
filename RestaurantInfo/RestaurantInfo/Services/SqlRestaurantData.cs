﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestaurantInfo.Data;
using RestaurantInfo.Models;

namespace RestaurantInfo.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private RestaurantInfoDbContext _context;

        public SqlRestaurantData(RestaurantInfoDbContext context)
        {
            _context = context;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Add(restaurant);
            _context.SaveChanges();

            return restaurant;
        }

        public Restaurant Update(Restaurant restaurant)
        {
            _context.Attach(restaurant).State = EntityState.Modified;
            _context.SaveChanges();

            return restaurant;
        }
    }
}
