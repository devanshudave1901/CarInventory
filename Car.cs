// Car.cs
//Author - Devanshu Dave
//Date : 17-03-2021
// Description - The class named car which has the the information of all cars sepratly which also inclused their importance.




using System;
using System.Collections.Generic;
using System.Text;

namespace CarInventory
{
    /// <summary>
    /// A car class is created to have the info of all car
    /// </summary>
    class Car
    {
        // Private static declared with int data type which hold the car count to 0
        private static int CarCount = 0;
        // Private static declared with int data type which hold the car ID to 0
        private static int CarIdentificationNumber = 0;
        // Private static declared with string data type which hold the car Make to empty
        private static string CarMake   = String.Empty;
        // Private static declared with string data type which hold the car model to empty
        private static string CarModel   = String.Empty;
        // Private static declared with int data type which hold the car year to 0
        private static int CarYear = 0;
        // Private static declared with decimal data type which hold the car price to 0
        private static decimal CarPrice = 0;

        private bool CarNewStatus = false;
        /// <summary>
        /// Default to create a new car 
        /// </summary>

        public Car()
        {
            CarCount += 1;
            CarIdentificationNumber = CarCount;
            
            
        }
        /// <summary>
        /// This are parametirized constructor to create new car object
        /// </summary>
        /// <param name="Make"></param>
        /// <param name="Model"></param>
        /// <param name="Year"></param>
        /// <param name="Price"></param>
        /// <param name="Status"></param>

        public Car(string Make, string Model, int Year, decimal Price, bool Status): this()
        {
                // to pass all constructor
            CarMake = Make;
            CarModel = Model;
            CarYear = Year;
            CarPrice = Price;
            CarNewStatus = Status;
           // CarIdentificationNumber = IdentificationNumber;
        } 
        /// <summary>
        /// Read only property to get number of cars that already been created
        /// </summary>
        public int Count
        {
            get
            {
                return CarCount;
            }
        }
        /// <summary>
        ///   Read only property to get ID of cars that already been created
        /// </summary>
        public int IdentificationNumber
        {
            get
            {
                return CarIdentificationNumber;
            }
        }
        /// <summary>
        /// Status of new which has gets and sets to check for new car or oldcar 
        /// </summary>

        public bool NewStatus
        {

            get
            {
                return CarNewStatus;
            }

            set
            {
                CarNewStatus = value;
            }
        }
        /// <summary>
        /// Make propert and get set to have make of a car
        /// </summary>

        public string Make
        {
            get
            {
                return CarMake;
            }
            set
            {
                CarMake = value;
            }
        }
        /// <summary>
        /// model property with get set of model of a car
        /// </summary>
        public string Model
        {
            get
            {
                return CarModel;

            }
            set
            {
                CarModel = value;

            }
        }
        /// <summary>
        /// year propery with get and set
        /// </summary>
        public int Year
        {
            get
            {
                return CarYear;
            }
            set
            {
                CarYear = value;
            }
        }
        /// <summary>
        /// price property and get and set
        /// </summary>
        public decimal Price
        {
            get
            {
                return CarPrice;

            }
            set
            {
                CarPrice = value;
            }
        }
        /// <summary>
        /// This function hold the string object
        /// </summary>
        /// <returns></returns>
        public string GetCarData()
        {
            return "Your car is " + CarIdentificationNumber + " " + CarMake + " " + CarModel + " " + CarYear + " "  + CarPrice + " " + (CarNewStatus ? "I am new " : "I am not new");
        }

    }


}
