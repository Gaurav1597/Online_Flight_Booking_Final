using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Online_Flight_Booking_Final.Models;

namespace Online_Flight_Booking_Final.Controllers
{

    public class FlightBookingsController : Controller
    {
        private readonly Online_Flight_BookingDataContext _context;

        public FlightBookingsController(Online_Flight_BookingDataContext context)
        {
            _context = context;
        }

        // GET: FlightBookings
        [Authorize(Roles = "flight_admin, passenger")]
        public async Task<IActionResult> Index()
        {
            var online_Flight_BookingDataContext = _context.FlightBooking.Include(f => f.Flight).Include(f => f.Passenger);

            if (User.IsInRole("passenger")) {

                var online_Flight_BookingDataContextPassenger = _context.FlightBooking.Include(f => f.Flight)
                    .Include(f => f.Passenger).Where(p =>p.Passenger.Email.Equals(User.Identity.Name));
                return View(await online_Flight_BookingDataContextPassenger.ToListAsync());

            }
            return View(await online_Flight_BookingDataContext.ToListAsync());
        }

        // GET: FlightBookings/Details/5
        [Authorize(Roles = "flight_admin, passenger")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightBooking = await _context.FlightBooking
                .Include(f => f.Flight)
                .Include(f => f.Passenger)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flightBooking == null)
            {
                return NotFound();
            }

            return View(flightBooking);
        }

        // GET: FlightBookings/Create
        [Authorize(Roles = "passenger")]
        public async Task<IActionResult> Create(int Id)
        {

            var passenger = (from pass in _context.Passenger
                             where pass.Email.Equals(User.Identity.Name)
                             select pass).FirstOrDefault();


            var flight = (from flt in _context.Flight
                          where flt.Id == Id
                          select flt).FirstOrDefault();


            var booking = new FlightBooking();

            booking.PassengerId = passenger.Id;

            booking.FlightId = Id;
            booking.Passenger = passenger;
            booking.Flight = flight;

            _context.Add(booking);
            await _context.SaveChangesAsync();

                                            
            return View(booking);
        }



        // GET: FlightBookings/Edit/5
        [Authorize(Roles = "flight_admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightBooking = await _context.FlightBooking.FindAsync(id);
            if (flightBooking == null)
            {
                return NotFound();
            }
            ViewData["FlightId"] = new SelectList(_context.Flight, "Id", "FlightNumber", flightBooking.FlightId);
            ViewData["PassengerId"] = new SelectList(_context.Set<Passenger>(), "Id", "Name", flightBooking.PassengerId);
            return View(flightBooking);
        }

        // POST: FlightBookings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "flight_admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FlightId,PassengerId")] FlightBooking flightBooking)
        {
            if (id != flightBooking.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flightBooking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightBookingExists(flightBooking.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FlightId"] = new SelectList(_context.Flight, "Id", "FlightNumber", flightBooking.FlightId);
            ViewData["PassengerId"] = new SelectList(_context.Set<Passenger>(), "Id", "Name", flightBooking.PassengerId);
            return View(flightBooking);
        }

        // GET: FlightBookings/Delete/5
        [Authorize(Roles = "flight_admin,passenger")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightBooking = await _context.FlightBooking
                .Include(f => f.Flight)
                .Include(f => f.Passenger)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flightBooking == null)
            {
                return NotFound();
            }

            return View(flightBooking);
        }

        // POST: FlightBookings/Delete/5
        [Authorize(Roles = "flight_admin,passenger")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flightBooking = await _context.FlightBooking.FindAsync(id);
            _context.FlightBooking.Remove(flightBooking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightBookingExists(int id)
        {
            return _context.FlightBooking.Any(e => e.Id == id);
        }
    }
}
