using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC5Practice.Models;

namespace MVC5Practice.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}