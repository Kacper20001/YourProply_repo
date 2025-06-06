﻿using System.ComponentModel.DataAnnotations;

namespace YourProply.Entities
{
    public class Property
    {
        public Property() { }

        public Property(int propertyId, string name, string description, Address address, bool isAvailable, string propertyType, double area, int numberOfRooms)
        {
            PropertyId = propertyId;
            Name = name;
            Description = description;
            Address = address;
            IsAvailable = isAvailable;
            PropertyType = propertyType;
            Area = area;
            NumberOfRooms = numberOfRooms;
        }

        [Key]
        public int PropertyId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public string PropertyType { get; set; }

        public double Area { get; set; }

        public int NumberOfRooms { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
