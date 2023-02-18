using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Blazor.Domain;
public enum JobStatus
{
    NotStart,
    Queueing,
    Doing,
    Done,
    Pending
}