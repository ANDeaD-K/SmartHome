﻿namespace Andead.SmartHome.Presentation.API.Models
{
    public class DeviceDto
    {
        public int Id { get; set; }

        public string DeviceName { get; set; }

        public string IeeeAddress { get; set; }

        public string FriendlyName { get; set; }

        public string ImageUrl { get; set; }

        public string Type { get; set; }

        public long NetworkAddress { get; set; }

        public long ManufacturerId { get; set; }

        public string ManufacturerName { get; set; }

        public string PowerSource { get; set; }

        public string ModelId { get; set; }

        public string Status { get; set; }
    }
}
