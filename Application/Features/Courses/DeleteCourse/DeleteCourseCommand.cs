using System;
using System.Collections.Generic;
using System.Text;
using Application.Abstractions.Messaging;
using Domain.Common;
using global::Application.Abstractions.Messaging;

namespace Application.Features.Courses.DeleteCourse
{
    public sealed record DeleteCourseCommand(Guid Id) : ICommand<Result>;
}
