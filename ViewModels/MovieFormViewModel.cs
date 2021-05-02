using System.Collections.Generic;
using VideoRentalApps.Models;

namespace VideoRentalApps.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }

        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";

                else
                return "New Movie";

            }
        }
    }
}