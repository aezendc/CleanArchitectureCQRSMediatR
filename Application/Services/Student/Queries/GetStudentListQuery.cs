using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Student.Queries
{
    public class GetStudentListQuery : IRequest<List<StudentDetails>>
    {
    }
}
