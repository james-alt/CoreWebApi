﻿using CoreWebApi.Core.Entities;
using CoreWebApi.Core.Interfaces;
using FluentValidation;
using MediatR;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoreWebApi.Core.Handlers
{
    public class GetBlogsQuery : IRequest<IEnumerable<Blog>>
    {

    }

    public class GetBlogsQueryValidator : AbstractValidator<GetBlogsQuery>
    {
        public GetBlogsQueryValidator() {
        }
    }

    public class GetBlogsHandler : IRequestHandler<GetBlogsQuery, IEnumerable<Blog>>
    {
        private readonly IRepository _repository;
        private readonly ILogger _logger;

        public GetBlogsHandler(IRepository repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public Task<IEnumerable<Blog>> Handle(GetBlogsQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_repository.List<Blog>());
        }

    }
}
