using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTOs.Report
{
    public class GetDisciplineVisitsReportResponse
    {
        public string FullName { get; set; }
        public int Present { get; set; }
        public int Missing { get; set; }
        public int Liberation { get; set; }
        public int AnotherSubgroup { get; set; }
        public int SeriousReason { get; set; }
        public int Incalculable { get; set; }
    }
}