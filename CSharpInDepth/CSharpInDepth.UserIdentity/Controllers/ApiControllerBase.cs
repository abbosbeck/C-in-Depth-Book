﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CSharpInDepth.UserIdentity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiControllerBase(ISender mediator) : ControllerBase
    {
        protected ISender Mediator { get; set; } = mediator;
    }
}
