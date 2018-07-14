using System;
using System.ComponentModel.DataAnnotations;
using ValidatorLibrary;

namespace BusnessEntities
{
    public class Payment
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Date payment due/received
        /// </summary>
        [Required]
        [RecievedDateTime]
        public DateTime RecievedDateTime { get; set; }
        /// <summary>
        /// Indicates payment was late
        /// </summary>
        public bool Late { get; set; }
    }
}
