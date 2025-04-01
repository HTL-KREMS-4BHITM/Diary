using Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Configurations;
using Model.Entities;

namespace Domain.Repositories.Implementations;

public class ResponseRepository : ARepositoryAsync<Response>, IRepositoryAsync<Response>
{
    public ResponseRepository(DiaryContext context) : base(context)
    {
    }
}