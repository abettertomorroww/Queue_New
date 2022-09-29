using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Queue_New.Models
{
    public class GasColumn
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Номер колонки
        /// </summary>
        [Required]
        public int ColumnNumber { get; set; }
        /// <summary>
        /// Время для формирования очереди
        /// </summary>
        [Required]
        public string QueueTime { get; set; }
        /// <summary>
        /// Факт бронирования времени
        /// </summary>
        [Required]
        public bool Occupied { get; set; }
        public string ClienPhoneNumber { get; set; }
       
        public int Code { get; set; }
    }
}
