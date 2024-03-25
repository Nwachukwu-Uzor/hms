using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Application.Models.IDGenerator;

public class IDSettings
{
    public string StaffIDPrefix { get; set; } = string.Empty;
    public string PatientIDPrefix { get; set; } = string.Empty;
    public int IDLength { get; set; } = 10;
}
