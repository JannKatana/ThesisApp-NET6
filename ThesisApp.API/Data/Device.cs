﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ThesisApp.API.Data
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(RoomId))]
        public int? RoomId { get; set; }
        public Room RoomLocation { get; set; }

        public IList<User> Users { get; set; }
    }
}
