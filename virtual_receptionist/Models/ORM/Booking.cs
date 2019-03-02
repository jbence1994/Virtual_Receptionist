﻿using System;

namespace virtual_receptionist.Models.ORM
{
    /// <summary>
    /// Foglalások egyed
    /// </summary>
    public class Booking
    {
        #region Adattagok

        /// <summary>
        /// Foglalás azonosító
        /// </summary>
        private int id;

        /// <summary>
        /// Guest modell osztály egy példánya
        /// </summary>
        private Guest guest;

        /// <summary>
        /// Company modell osztály egy példánya
        /// </summary>
        private Company company;

        /// <summary>
        /// Room modell osztály egy példánya
        /// </summary>
        private Room room;

        /// <summary>
        /// Vendégek száma
        /// </summary>
        private int numberOfGuests;

        /// <summary>
        /// Érkezés dátuma
        /// </summary>
        private DateTime arrivalDate;

        /// <summary>
        /// Távozás dátuma
        /// </summary>
        private DateTime departureDate;

        #endregion

        #region Konstruktorok

        /// <summary>
        /// Booking osztály konstruktora
        /// </summary>
        /// <param name="id">Foglalás azonosító</param>
        /// <param name="guest">Guest egyed</param>
        /// <param name="company">Company egyed</param>
        /// <param name="room">Room egyed</param>
        /// <param name="numberOfGuests">Vendégek száma</param>
        /// <param name="arrivalDate">Érkezés dátuma</param>
        /// <param name="departureDate">Távozás dátuma</param>
        public Booking(int id, Guest guest, Company company, Room room, int numberOfGuests, DateTime arrivalDate,
            DateTime departureDate)
        {
            this.id = id;
            this.guest = guest;
            this.company = company;
            this.room = room;
            this.numberOfGuests = numberOfGuests;
            this.arrivalDate = arrivalDate;
            this.departureDate = departureDate;
        }

        #endregion

        #region Getter és setter tulajdonságok

        /// <summary>
        /// Foglalás azonosító
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Guest modell osztály egy példánya
        /// </summary>
        public Guest Guest
        {
            get { return guest; }
            set { guest = value; }
        }

        /// <summary>
        /// Company modell osztály egy példánya
        /// </summary>
        public Company Company
        {
            get { return company; }
            set { company = value; }
        }

        /// <summary>
        /// Room modell osztály egy példánya
        /// </summary>
        public Room Room
        {
            get { return room; }
            set { room = value; }
        }

        /// <summary>
        /// Vendégek száma
        /// </summary>
        public int NumberOfGuests
        {
            get { return numberOfGuests; }
            set { numberOfGuests = value; }
        }

        /// <summary>
        /// Érkezés dátuma
        /// </summary>
        public DateTime ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }

        /// <summary>
        /// Távozás dátuma
        /// </summary>
        public DateTime DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }

        #endregion

        #region Metódusok

        /// <summary>
        /// Reservation osztályból készült objektum string típusúvá alakítása
        /// </summary>
        /// <returns>Visszaadja a Reservation típusú objektumot string típusúra alakítva</returns>
        public override string ToString()
        {
            return $"{id} {guest} {company} {room} {numberOfGuests} {arrivalDate} {departureDate}";
        }

        #endregion
    }
}
