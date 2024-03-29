﻿using HospitalManagement.Domain.Common;

namespace HospitalManagement.Domain.Entities;

public class Department : BaseEntity
{
    public string Name { get; set; }
    public List<Job> Job { get; set; }
}
