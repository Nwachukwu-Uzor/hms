using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Application.Features.AppUser.Commands.CreateAdminUserCommand;

public class CreateAdminUserCommandHandler : IRequestHandler<CreateAdminUserCommand, Unit>
{
    public CreateAdminUserCommandHandler()
    {
        
    }
    public Task<Unit> Handle(CreateAdminUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
