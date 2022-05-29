using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_Clone.Models;

namespace Vidly_Clone.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}