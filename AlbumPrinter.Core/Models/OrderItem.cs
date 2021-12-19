using AlbumPrinter.Core.Enums;
using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumPrinter.Core.Models
{
    [JsonConverter(typeof(JsonSubtypes), "ProductType")]
    public abstract class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public Guid Id { get; set; }

        [JsonIgnore]
        public Guid OrderID { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public abstract ProductType ProductType { get; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }

        [JsonIgnore]
        [NotMapped]
        public abstract double RequiredBinWidth { get; }
    }
}
