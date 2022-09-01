using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Queue_New.Models;

namespace Queue_New.Data
{
    public class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.gasColumns.Any())
            {
                context.gasColumns.AddRange(
                    new GasColumn
                    {
                        ColumnNumber = 1,
                        QueueTime = "10-00",
                        Occupied = false
                    },
                    new GasColumn
                    {
                        ColumnNumber = 1,
                        QueueTime = "11-00",
                        Occupied = false
                    },
                    new GasColumn
                    {
                        ColumnNumber = 1,
                        QueueTime = "12-00",
                        Occupied = false
                    },
                    new GasColumn
                    {
                        ColumnNumber = 1,
                        QueueTime = "13-00",
                        Occupied = false
                    },
                    new GasColumn
                    {
                        ColumnNumber = 2,
                        QueueTime = "10-00",
                        Occupied = false
                    },
                    new GasColumn
                    {
                        ColumnNumber = 2,
                        QueueTime = "11-00",
                        Occupied = false
                    },
                    new GasColumn
                    {
                        ColumnNumber = 2,
                        QueueTime = "12-00",
                        Occupied = false
                    },
                    new GasColumn
                    {
                        ColumnNumber = 2,
                        QueueTime = "13-00",
                        Occupied = false
                    });
                context.SaveChanges();
            }
        }
    }
}
