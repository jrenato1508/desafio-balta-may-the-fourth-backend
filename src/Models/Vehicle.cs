using System.ComponentModel.DataAnnotations;

namespace MayTheFourth.Api.Models
{
    public class Vehicle : Entity
    {
        public string? name { get; set; }
        public string? model { get; set; }
        public string? manufacter { get; set; }
        public double? cost_in_credits { get; set; }
        public double? lenght { get; set; }
        public double? max_atmosphering_speed { get; set; }
        public int? crew { get; set; }
        public int? passengers { get; set; }
        public string? cargo_capacity { get; set; }
        public string? consumables { get; set; }
        public string? vehicle_class { get; set; }
        public string? pilots { get; set; }
        public string? films { get; set; }
        public DateTime? created { get; set; }
        public DateTime? edited { get; set; }
        public string? url { get; set; }        
    }
}
