using App.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_EclatEmporiaPresentation
{
    public class SessionData
    {
        private static SessionData instance;

        // Properties for user ID and role
        public User user { get; set; }

      //  public Cart CurrentCart { get; set; }
        // Private constructor to enforce singleton pattern
        private SessionData() { }

        // Singleton instance property
        public static SessionData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SessionData();
                }
                return instance;
            }
        }
    }

}
