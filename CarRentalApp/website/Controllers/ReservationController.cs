using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website.Models;

namespace website.Controllers
{
    public class ReservationsController : Controller
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarRentalDb;Integrated Security=True;";
        // Veritabanı bağlantı dizesi

        public ActionResult Index()
        {
            var model = new List<ReservationViewModel>();

            // Veritabanı bağlantısını oluşturun
            using (var connection = new SqlConnection(connectionString))
            {
                // SQL sorgusunu tanımlayın
                string query = @"
            SELECT
                r.Id AS ReservationId,
                c.Id AS CarId,
                c.Model AS CarModel,
                c.Year AS CarYear,
                c.IsAvailable AS CarIsAvailable,
                cb.Id AS CarBrandId,
                cb.Name AS CarBrandName,
                cu.Id AS CustomerId,
                cu.FirstName AS CustomerFirstName,
                cu.LastName AS CustomerLastName,
                cu.Email AS CustomerEmail,
                cu.PhoneNumber AS CustomerPhoneNumber,
                r.StartDate AS ReservationStartDate,
                r.EndDate AS ReservationEndDate
            FROM
                Reservations r
            JOIN Cars c ON r.CarId = c.Id
            JOIN CarBrands cb ON c.BrandId = cb.Id
            JOIN Customers cu ON r.CustomerId = cu.Id;";

                // SQL komutunu oluşturun
                using (var command = new SqlCommand(query, connection))
                {
                    // Bağlantıyı açın
                    connection.Open();

                    // Verileri okuyun
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            model.Add(new ReservationViewModel
                            {
                                ReservationId = reader.GetInt32(0),
                                CarId = reader.GetInt32(1),
                                CarModel = reader.GetString(2),
                                CarYear = reader.GetInt32(3),
                                CarIsAvailable = reader.GetBoolean(4),
                                CarBrandId = reader.GetInt32(5),
                                CarBrandName = reader.GetString(6),
                                CustomerId = reader.GetInt32(7),
                                CustomerFirstName = reader.GetString(8),
                                CustomerLastName = reader.GetString(9),
                                CustomerEmail = reader.GetString(10),
                                CustomerPhoneNumber = reader.GetString(11),
                                ReservationStartDate = reader.GetDateTime(12),
                                ReservationEndDate = reader.GetDateTime(13)
                            });
                        }
                    }
                }
            }

            // Modeli View'a gönderin
            return View(model);
        }

    }
}
       

